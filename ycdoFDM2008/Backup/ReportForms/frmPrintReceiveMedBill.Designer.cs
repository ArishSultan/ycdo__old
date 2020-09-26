namespace FDM.ReportForms
{
    partial class frmPrintReceiveMedBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReceiveMedBill));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.rbPurchase = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRetail = new System.Windows.Forms.RadioButton();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsPreview = new System.Windows.Forms.ToolStripButton();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsPreview,
            this.tsPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(292, 25);
            this.toolStrip1.TabIndex = 84;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // rbPurchase
            // 
            this.rbPurchase.AutoSize = true;
            this.rbPurchase.Location = new System.Drawing.Point(6, 56);
            this.rbPurchase.Name = "rbPurchase";
            this.rbPurchase.Size = new System.Drawing.Size(142, 17);
            this.rbPurchase.TabIndex = 1;
            this.rbPurchase.TabStop = true;
            this.rbPurchase.Text = "Print With PurchasePrice";
            this.rbPurchase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPurchase);
            this.groupBox1.Controls.Add(this.rbRetail);
            this.groupBox1.Location = new System.Drawing.Point(46, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 100);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // rbRetail
            // 
            this.rbRetail.AutoSize = true;
            this.rbRetail.Checked = true;
            this.rbRetail.Location = new System.Drawing.Point(6, 19);
            this.rbRetail.Name = "rbRetail";
            this.rbRetail.Size = new System.Drawing.Size(128, 17);
            this.rbRetail.TabIndex = 0;
            this.rbRetail.TabStop = true;
            this.rbRetail.Text = "Print With Retail Price";
            this.rbRetail.UseVisualStyleBackColor = true;
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
            this.tsPreview.Visible = false;
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
            // panel1
            // 
            this.panel1.BackgroundImage = global::FDM.Properties.Resources.hd_blain;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Location = new System.Drawing.Point(1, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 95);
            this.panel1.TabIndex = 83;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(267, 59);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Printing Option";
            // 
            // frmPrintReceiveMedBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrintReceiveMedBill";
            this.Text = "Print Receive Med Bill";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsPreview;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton rbPurchase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRetail;
    }
}