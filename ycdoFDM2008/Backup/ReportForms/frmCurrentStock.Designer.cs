namespace FDM.ReportForms
{
    partial class frmCurrentStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrentStock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsPreview = new System.Windows.Forms.ToolStripButton();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.tsPreviewAll = new System.Windows.Forms.ToolStripButton();
            this.gbxCS = new System.Windows.Forms.GroupBox();
            this.rbLabTests = new System.Windows.Forms.RadioButton();
            this.rbWithoutLabTest = new System.Windows.Forms.RadioButton();
            this.rbLabTestnMedicines = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbxCS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FDM.Properties.Resources.hd_blain;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 95);
            this.panel1.TabIndex = 79;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(8, 14);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(370, 59);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Current Stock Report";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsPreview,
            this.tsPrint,
            this.tsPreviewAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(382, 25);
            this.toolStrip1.TabIndex = 80;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsClose
            // 
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(53, 22);
            this.tsClose.Text = "&Close";
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click);
            // 
            // tsPreview
            // 
            this.tsPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsPreview.Image")));
            this.tsPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPreview.Name = "tsPreview";
            this.tsPreview.Size = new System.Drawing.Size(65, 22);
            this.tsPreview.Text = "Previe&w";
            this.tsPreview.Click += new System.EventHandler(this.tsPreview_Click);
            // 
            // tsPrint
            // 
            this.tsPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsPrint.Image")));
            this.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.Size = new System.Drawing.Size(49, 22);
            this.tsPrint.Text = "Print";
            this.tsPrint.Click += new System.EventHandler(this.tsPrint_Click);
            // 
            // tsPreviewAll
            // 
            this.tsPreviewAll.Image = ((System.Drawing.Image)(resources.GetObject("tsPreviewAll.Image")));
            this.tsPreviewAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPreviewAll.Name = "tsPreviewAll";
            this.tsPreviewAll.Size = new System.Drawing.Size(79, 22);
            this.tsPreviewAll.Text = "P&review All";
            this.tsPreviewAll.Visible = false;
            // 
            // gbxCS
            // 
            this.gbxCS.Controls.Add(this.rbLabTests);
            this.gbxCS.Controls.Add(this.rbWithoutLabTest);
            this.gbxCS.Controls.Add(this.rbLabTestnMedicines);
            this.gbxCS.Location = new System.Drawing.Point(46, 126);
            this.gbxCS.Name = "gbxCS";
            this.gbxCS.Size = new System.Drawing.Size(287, 58);
            this.gbxCS.TabIndex = 81;
            this.gbxCS.TabStop = false;
            this.gbxCS.Text = "Select";
            // 
            // rbLabTests
            // 
            this.rbLabTests.AutoSize = true;
            this.rbLabTests.Location = new System.Drawing.Point(40, 16);
            this.rbLabTests.Name = "rbLabTests";
            this.rbLabTests.Size = new System.Drawing.Size(66, 17);
            this.rbLabTests.TabIndex = 2;
            this.rbLabTests.TabStop = true;
            this.rbLabTests.Text = " LabTest";
            this.rbLabTests.UseVisualStyleBackColor = true;
            // 
            // rbWithoutLabTest
            // 
            this.rbWithoutLabTest.AutoSize = true;
            this.rbWithoutLabTest.Location = new System.Drawing.Point(129, 16);
            this.rbWithoutLabTest.Name = "rbWithoutLabTest";
            this.rbWithoutLabTest.Size = new System.Drawing.Size(71, 17);
            this.rbWithoutLabTest.TabIndex = 1;
            this.rbWithoutLabTest.Text = "Medicines";
            this.rbWithoutLabTest.UseVisualStyleBackColor = true;
            // 
            // rbLabTestnMedicines
            // 
            this.rbLabTestnMedicines.AutoSize = true;
            this.rbLabTestnMedicines.Checked = true;
            this.rbLabTestnMedicines.Location = new System.Drawing.Point(40, 35);
            this.rbLabTestnMedicines.Name = "rbLabTestnMedicines";
            this.rbLabTestnMedicines.Size = new System.Drawing.Size(137, 17);
            this.rbLabTestnMedicines.TabIndex = 0;
            this.rbLabTestnMedicines.TabStop = true;
            this.rbLabTestnMedicines.Text = " LabTest And Medicines";
            this.rbLabTestnMedicines.UseVisualStyleBackColor = true;
            // 
            // frmCurrentStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 194);
            this.ControlBox = false;
            this.Controls.Add(this.gbxCS);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCurrentStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Stock";
            this.Load += new System.EventHandler(this.frmCurrentStock_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbxCS.ResumeLayout(false);
            this.gbxCS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsPreview;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.ToolStripButton tsPreviewAll;
        private System.Windows.Forms.GroupBox gbxCS;
        private System.Windows.Forms.RadioButton rbWithoutLabTest;
        private System.Windows.Forms.RadioButton rbLabTestnMedicines;
        private System.Windows.Forms.RadioButton rbLabTests;
    }
}