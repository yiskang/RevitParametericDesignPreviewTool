﻿// (C) Copyright 2022 by Autodesk, Inc. 
//
// Permission to use, copy, modify, and distribute this software
// in object code form for any purpose and without fee is hereby
// granted, provided that the above copyright notice appears in
// all copies and that both that copyright notice and the limited
// warranty and restricted rights notice below appear in all
// supporting documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS. 
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK,
// INC. DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL
// BE UNINTERRUPTED OR ERROR FREE.
//
// Use, duplication, or disclosure by the U.S. Government is
// subject to restrictions set forth in FAR 52.227-19 (Commercial
// Computer Software - Restricted Rights) and DFAR 252.227-7013(c)
// (1)(ii)(Rights in Technical Data and Computer Software), as
// applicable.
//

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitParametericDesignPreviewTool
{
    public class ParametericDesignDummyViewEventHandler : IExternalEventHandler
    {
        private System.Windows.Forms.Integration.ElementHost rvtPreviewControlHost;
        private ElementId targetElementId;

        public bool DisposingView { get; set; }
        public ElementId ViewId { get; private set; }

        public ParametericDesignDummyViewEventHandler(System.Windows.Forms.Integration.ElementHost rvtPreviewControlHost, ElementId targetElementId)
        {
            this.rvtPreviewControlHost = rvtPreviewControlHost;
            this.targetElementId = targetElementId;
        }

        private View3D CreateView3D(Document doc)
        {
            using (var collector = new FilteredElementCollector(doc))
            {
                collector.OfClass(typeof(ViewFamilyType));
                var viewFamilyType = collector.Cast<ViewFamilyType>().FirstOrDefault(viewType => viewType.ViewFamily == ViewFamily.ThreeDimensional);

                if (viewFamilyType == null) throw new InvalidDataException("Not ViewFamilyType for 3D found");

                var view = View3D.CreateIsometric(doc, viewFamilyType.Id);

                if (view == null) throw new InvalidOperationException("Failed to create 3D view for ParametericDesignControl");

                view.IsolateElementTemporary(this.targetElementId);
                view.ConvertTemporaryHideIsolateToPermanent();

                this.ViewId = view.Id;

                return view;
            }
        }

        public void Execute(UIApplication app)
        {
            Document doc = app.ActiveUIDocument.Document;
            var message = this.DisposingView ? "Delete ParametericDesignControl DBView" : "Create ParametericDesignControl DBView";
            using (var trans = new Transaction(doc, message))
            {
                trans.Start();

                if (this.DisposingView && this.ViewId != null)
                {
                    doc.Delete(this.ViewId);
                    this.ViewId = null;
                }
                else
                {
                    this.CreateView3D(doc);
                }

                trans.Commit();
            }

            PreviewControl control = this.rvtPreviewControlHost.Child as PreviewControl;
            if (control != null)
                control.Dispose();

            if (!this.DisposingView)
            {
                var previewCtrl = new PreviewControl(doc, this.ViewId);
                this.rvtPreviewControlHost.Child = previewCtrl;
            }
        }

        public string GetName()
        {
            return "ParametericDesignControl DBView event hanlder";
        }
    }
}