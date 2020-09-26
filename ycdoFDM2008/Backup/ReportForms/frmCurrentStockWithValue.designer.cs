namespace FDM.ReportForms
{
    partial class frmCurrentStockWithValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrentStockWithValue));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsPreview = new System.Windows.Forms.ToolStripButton();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.tsPreviewAll = new System.Windows.Forms.ToolStripButton();
            this.gbxCS = new System.Windows.Forms.GroupBox();
            this.rbLabTest = new System.Windows.Forms.RadioButton();
            this.rbWithoutLabTest = new System.Windows.Forms.RadioButton();
            this.rbLabTestnMedicine = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbxCS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FDM.Properties.Resources.hd_blain;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 95);
            this.panel1.TabIndex = 78;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(460, 59);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Current Stock Value Report";
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
            this.toolStrip1.Size = new System.Drawing.Size(466, 25);
            this.toolStrip1.TabIndex = 79;
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
            this.gbxCS.Controls.Add(this.rbLabTest);
            this.gbxCS.Controls.Add(this.rbWithoutLabTest);
            this.gbxCS.Controls.Add(this.rbLabTestnMedicine);
            this.gbxCS.Location = new System.Drawing.Point(104, 123);
            this.gbxCS.Name = "gbxCS";
            this.gbxCS.Size = new System.Drawing.Size(254, 71);
            this.gbxCS.TabIndex = 82;
            this.gbxCS.TabStop = false;
            this.gbxCS.Text = "Select";
            // 
            // rbLabTest
            // 
            this.rbLabTest.AutoSize = true;
            this.rbLabTest.Location = new System.Drawing.Point(6, 19);
            this.rbLabTest.Name = "rbLabTest";
            this.rbLabTest.Size = new System.Drawing.Size(66, 17);
            this.rbLabTest.TabIndex = 2;
            this.rbLabTest.Text = " LabTest";
            this.rbLabTest.UseVisualStyleBackColor = true;
            // 
            // rbWithoutLabTest
            // 
            this.rbWithoutLabTest.AutoSize = true;
            this.rbWithoutLabTest.Location = new System.Drawing.Point(109, 19);
            this.rbWithoutLabTest.Name = "rbWithoutLabTest";
            this.rbWithoutLabTest.Size = new System.Drawing.Size(71, 17);
            this.rbWithoutLabTest.TabIndex = 1;
            this.rbWithoutLabTest.Text = "Medicines";
            this.rbWithoutLabTest.UseVisualStyleBackColor = true;
            // 
            // rbLabTestnMedicine
            // 
            this.rbLabTestnMedicine.AutoSize = true;
            this.rbLabTestnMedicine.Checked = true;
            this.rbLabTestnMedicine.Location = new System.Drawing.Point(6, 48);
            this.rbLabTestnMedicine.Name = "rbLabTestnMedicine";
            this.rbLabTestnMedicine.Size = new System.Drawing.Size(129, 17);
            this.rbLabTestnMedicine.TabIndex = 0;
            this.rbLabTestnMedicine.TabStop = true;
            this.rbLabTestnMedicine.Text = "LabTest And Medicine";
            this.rbLabTestnMedicine.UseVisualStyleBackColor = true;
            // 
            // frmCurrentStockWithValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 206);
            this.ControlBox = false;
            this.Controls.Add(this.gbxCS);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCurrentStockWithValue";
            this.Text = "Current Stock With Value";
            this.Load += new System.EventHandler(this.frmCurrentStockWithValue_Load);
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
        private System.Windows.Forms.RadioButton rbLabTestnMedicine;
        private System.Windows.Forms.RadioButton rbLabTest;
    }
}