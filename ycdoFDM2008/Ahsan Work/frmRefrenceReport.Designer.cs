namespace FDM.ReportForms
{
    partial class frmRefrenceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRefrenceReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbselectDonors = new System.Windows.Forms.RadioButton();
            this.rbselectMembers = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxReference = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsPreview = new System.Windows.Forms.ToolStripButton();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.tsClear = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbselectDonors);
            this.groupBox1.Controls.Add(this.rbselectMembers);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxReference);
            this.groupBox1.Location = new System.Drawing.Point(4, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 100);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Reference";
            // 
            // rbselectDonors
            // 
            this.rbselectDonors.AutoSize = true;
            this.rbselectDonors.Location = new System.Drawing.Point(175, 19);
            this.rbselectDonors.Name = "rbselectDonors";
            this.rbselectDonors.Size = new System.Drawing.Size(59, 17);
            this.rbselectDonors.TabIndex = 1;
            this.rbselectDonors.TabStop = true;
            this.rbselectDonors.Text = "Donors";
            this.rbselectDonors.UseVisualStyleBackColor = true;
            this.rbselectDonors.CheckedChanged += new System.EventHandler(this.rbselectDonors_CheckedChanged);
            // 
            // rbselectMembers
            // 
            this.rbselectMembers.AutoSize = true;
            this.rbselectMembers.Location = new System.Drawing.Point(87, 19);
            this.rbselectMembers.Name = "rbselectMembers";
            this.rbselectMembers.Size = new System.Drawing.Size(68, 17);
            this.rbselectMembers.TabIndex = 0;
            this.rbselectMembers.TabStop = true;
            this.rbselectMembers.Text = "Members";
            this.rbselectMembers.UseVisualStyleBackColor = true;
            this.rbselectMembers.CheckedChanged += new System.EventHandler(this.rbselectMembers_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Reference :";
            // 
            // cbxReference
            // 
            this.cbxReference.FormattingEnabled = true;
            this.cbxReference.Location = new System.Drawing.Point(87, 53);
            this.cbxReference.Name = "cbxReference";
            this.cbxReference.Size = new System.Drawing.Size(158, 21);
            this.cbxReference.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsPreview,
            this.tsPrint,
            this.tsClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(264, 25);
            this.toolStrip1.TabIndex = 53;
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
            // 
            // tsClear
            // 
            this.tsClear.Image = ((System.Drawing.Image)(resources.GetObject("tsClear.Image")));
            this.tsClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClear.Name = "tsClear";
            this.tsClear.Size = new System.Drawing.Size(79, 22);
            this.tsClear.Text = "P&review All";
            // 
            // frmRefrenceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 150);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRefrenceReport";
            this.Text = "Refrence Report";
            this.Load += new System.EventHandler(this.frmRefrenceReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbselectDonors;
        private System.Windows.Forms.RadioButton rbselectMembers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxReference;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsPreview;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.ToolStripButton tsClear;
    }
}