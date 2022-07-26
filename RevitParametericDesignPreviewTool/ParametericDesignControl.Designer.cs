﻿namespace RevitParametericDesignPreviewTool
{
    partial class ParametericDesignControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParametericDesignControl));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rvtPreviewControlHost = new System.Windows.Forms.Integration.ElementHost();
            this.leftSideTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.parametersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbRebarSpacing = new System.Windows.Forms.Label();
            this.numInputRebarSpacing = new System.Windows.Forms.NumericUpDown();
            this.btnApplyChange = new System.Windows.Forms.Button();
            this.cmbRebarShape = new System.Windows.Forms.ComboBox();
            this.lbRebarShape = new System.Windows.Forms.Label();
            this.lbRebarTyep = new System.Windows.Forms.Label();
            this.cmbRebarType = new System.Windows.Forms.ComboBox();
            this.lbRebarCoverSpace = new System.Windows.Forms.Label();
            this.numInputRebarCoverSpace = new System.Windows.Forms.NumericUpDown();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbSpinner = new System.Windows.Forms.PictureBox();
            this.mainTableLayoutPanel.SuspendLayout();
            this.leftSideTableLayoutPanel.SuspendLayout();
            this.parametersTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInputRebarSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputRebarCoverSpace)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.rvtPreviewControlHost, 2, 0);
            this.mainTableLayoutPanel.Controls.Add(this.leftSideTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(734, 611);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // rvtPreviewControlHost
            // 
            this.rvtPreviewControlHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvtPreviewControlHost.Location = new System.Drawing.Point(369, 3);
            this.rvtPreviewControlHost.Name = "rvtPreviewControlHost";
            this.rvtPreviewControlHost.Size = new System.Drawing.Size(362, 605);
            this.rvtPreviewControlHost.TabIndex = 0;
            this.rvtPreviewControlHost.Text = "elementHost1";
            this.rvtPreviewControlHost.Child = null;
            // 
            // leftSideTableLayoutPanel
            // 
            this.leftSideTableLayoutPanel.ColumnCount = 1;
            this.leftSideTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftSideTableLayoutPanel.Controls.Add(this.parametersTableLayoutPanel, 0, 1);
            this.leftSideTableLayoutPanel.Controls.Add(this.lbTitle, 0, 0);
            this.leftSideTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftSideTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.leftSideTableLayoutPanel.Name = "leftSideTableLayoutPanel";
            this.leftSideTableLayoutPanel.RowCount = 2;
            this.leftSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.leftSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.leftSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftSideTableLayoutPanel.Size = new System.Drawing.Size(287, 605);
            this.leftSideTableLayoutPanel.TabIndex = 1;
            // 
            // parametersTableLayoutPanel
            // 
            this.parametersTableLayoutPanel.ColumnCount = 2;
            this.parametersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.parametersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.parametersTableLayoutPanel.Controls.Add(this.lbRebarSpacing, 0, 0);
            this.parametersTableLayoutPanel.Controls.Add(this.numInputRebarSpacing, 1, 0);
            this.parametersTableLayoutPanel.Controls.Add(this.btnApplyChange, 1, 4);
            this.parametersTableLayoutPanel.Controls.Add(this.cmbRebarShape, 1, 3);
            this.parametersTableLayoutPanel.Controls.Add(this.lbRebarShape, 0, 3);
            this.parametersTableLayoutPanel.Controls.Add(this.lbRebarTyep, 0, 2);
            this.parametersTableLayoutPanel.Controls.Add(this.cmbRebarType, 1, 2);
            this.parametersTableLayoutPanel.Controls.Add(this.lbRebarCoverSpace, 0, 1);
            this.parametersTableLayoutPanel.Controls.Add(this.numInputRebarCoverSpace, 1, 1);
            this.parametersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parametersTableLayoutPanel.Location = new System.Drawing.Point(3, 63);
            this.parametersTableLayoutPanel.Name = "parametersTableLayoutPanel";
            this.parametersTableLayoutPanel.RowCount = 6;
            this.parametersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.parametersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.parametersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.parametersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.parametersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.parametersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.parametersTableLayoutPanel.Size = new System.Drawing.Size(281, 539);
            this.parametersTableLayoutPanel.TabIndex = 0;
            // 
            // lbRebarSpacing
            // 
            this.lbRebarSpacing.AutoSize = true;
            this.lbRebarSpacing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRebarSpacing.Location = new System.Drawing.Point(3, 0);
            this.lbRebarSpacing.Name = "lbRebarSpacing";
            this.lbRebarSpacing.Size = new System.Drawing.Size(78, 26);
            this.lbRebarSpacing.TabIndex = 0;
            this.lbRebarSpacing.Text = "Spacing (mm)";
            this.lbRebarSpacing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numInputRebarSpacing
            // 
            this.numInputRebarSpacing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numInputRebarSpacing.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numInputRebarSpacing.Location = new System.Drawing.Point(87, 3);
            this.numInputRebarSpacing.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numInputRebarSpacing.Name = "numInputRebarSpacing";
            this.numInputRebarSpacing.Size = new System.Drawing.Size(191, 20);
            this.numInputRebarSpacing.TabIndex = 6;
            this.numInputRebarSpacing.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnApplyChange
            // 
            this.btnApplyChange.Location = new System.Drawing.Point(87, 188);
            this.btnApplyChange.Name = "btnApplyChange";
            this.btnApplyChange.Size = new System.Drawing.Size(191, 20);
            this.btnApplyChange.TabIndex = 7;
            this.btnApplyChange.Text = "Apply";
            this.btnApplyChange.UseVisualStyleBackColor = true;
            this.btnApplyChange.Click += new System.EventHandler(this.btnApplyChange_Click);
            // 
            // cmbRebarShape
            // 
            this.cmbRebarShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRebarShape.FormattingEnabled = true;
            this.cmbRebarShape.Location = new System.Drawing.Point(87, 81);
            this.cmbRebarShape.Name = "cmbRebarShape";
            this.cmbRebarShape.Size = new System.Drawing.Size(191, 21);
            this.cmbRebarShape.TabIndex = 5;
            // 
            // lbRebarShape
            // 
            this.lbRebarShape.AutoSize = true;
            this.lbRebarShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRebarShape.Location = new System.Drawing.Point(3, 78);
            this.lbRebarShape.Name = "lbRebarShape";
            this.lbRebarShape.Size = new System.Drawing.Size(78, 107);
            this.lbRebarShape.TabIndex = 2;
            this.lbRebarShape.Text = "RebarShape";
            // 
            // lbRebarTyep
            // 
            this.lbRebarTyep.AutoSize = true;
            this.lbRebarTyep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRebarTyep.Location = new System.Drawing.Point(3, 52);
            this.lbRebarTyep.Name = "lbRebarTyep";
            this.lbRebarTyep.Size = new System.Drawing.Size(78, 26);
            this.lbRebarTyep.TabIndex = 1;
            this.lbRebarTyep.Text = "Rebar Type";
            this.lbRebarTyep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRebarType
            // 
            this.cmbRebarType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRebarType.FormattingEnabled = true;
            this.cmbRebarType.Location = new System.Drawing.Point(87, 55);
            this.cmbRebarType.Name = "cmbRebarType";
            this.cmbRebarType.Size = new System.Drawing.Size(191, 21);
            this.cmbRebarType.TabIndex = 4;
            // 
            // lbRebarCoverSpace
            // 
            this.lbRebarCoverSpace.AutoSize = true;
            this.lbRebarCoverSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRebarCoverSpace.Location = new System.Drawing.Point(3, 26);
            this.lbRebarCoverSpace.Name = "lbRebarCoverSpace";
            this.lbRebarCoverSpace.Size = new System.Drawing.Size(78, 26);
            this.lbRebarCoverSpace.TabIndex = 8;
            this.lbRebarCoverSpace.Text = "Cover (mm)";
            this.lbRebarCoverSpace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numInputRebarCoverSpace
            // 
            this.numInputRebarCoverSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numInputRebarCoverSpace.Location = new System.Drawing.Point(87, 29);
            this.numInputRebarCoverSpace.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numInputRebarCoverSpace.Name = "numInputRebarCoverSpace";
            this.numInputRebarCoverSpace.Size = new System.Drawing.Size(191, 20);
            this.numInputRebarCoverSpace.TabIndex = 9;
            this.numInputRebarCoverSpace.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(281, 60);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Stirrups";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pbSpinner, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(296, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(67, 605);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pbSpinner
            // 
            this.pbSpinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSpinner.ErrorImage = global::RevitParametericDesignPreviewTool.Properties.Resources.Spinner;
            this.pbSpinner.Image = global::RevitParametericDesignPreviewTool.Properties.Resources.Spinner;
            this.pbSpinner.InitialImage = global::RevitParametericDesignPreviewTool.Properties.Resources.Spinner;
            this.pbSpinner.Location = new System.Drawing.Point(3, 203);
            this.pbSpinner.Name = "pbSpinner";
            this.pbSpinner.Size = new System.Drawing.Size(61, 94);
            this.pbSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpinner.TabIndex = 0;
            this.pbSpinner.TabStop = false;
            this.pbSpinner.Visible = false;
            // 
            // ParametericDesignControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParametericDesignControl";
            this.Text = "Parameteric Design Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParametericDesignControl_FormClosing);
            this.Shown += new System.EventHandler(this.ParametericDesignWindow_Shown);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.leftSideTableLayoutPanel.ResumeLayout(false);
            this.leftSideTableLayoutPanel.PerformLayout();
            this.parametersTableLayoutPanel.ResumeLayout(false);
            this.parametersTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInputRebarSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputRebarCoverSpace)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Integration.ElementHost rvtPreviewControlHost;
        private System.Windows.Forms.TableLayoutPanel leftSideTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel parametersTableLayoutPanel;
        private System.Windows.Forms.Label lbRebarSpacing;
        private System.Windows.Forms.Label lbRebarTyep;
        private System.Windows.Forms.Label lbRebarShape;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox cmbRebarType;
        private System.Windows.Forms.ComboBox cmbRebarShape;
        private System.Windows.Forms.NumericUpDown numInputRebarSpacing;
        private System.Windows.Forms.Button btnApplyChange;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbSpinner;
        private System.Windows.Forms.Label lbRebarCoverSpace;
        private System.Windows.Forms.NumericUpDown numInputRebarCoverSpace;
    }
}