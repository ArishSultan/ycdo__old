namespace FDM.ReportForms
{
    partial class frmDonorAndMemberCollectionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonorAndMemberCollectionReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTodate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpfromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbDonationtype = new System.Windows.Forms.RadioButton();
            this.Mycbx = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.Controls.Add(this.dtpTodate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpfromDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Controls.Add(this.rbDonationtype);
            this.groupBox1.Controls.Add(this.Mycbx);
            this.groupBox1.Location = new System.Drawing.Point(27, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 226);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select ";
            // 
            // dtpTodate
            // 
            this.dtpTodate.CustomFormat = "dd/MM/yyyy";
            this.dtpTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTodate.Location = new System.Drawing.Point(135, 85);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Size = new System.Drawing.Size(93, 20);
            this.dtpTodate.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "To Date";
            // 
            // dtpfromDate
            // 
            this.dtpfromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpfromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfromDate.Location = new System.Drawing.Point(135, 53);
            this.dtpfromDate.Name = "dtpfromDate";
            this.dtpfromDate.Size = new System.Drawing.Size(93, 20);
            this.dtpfromDate.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "From Date";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(15, 115);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(42, 17);
            this.rbAll.TabIndex = 51;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "ALL";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.Visible = false;
            // 
            // rbDonationtype
            // 
            this.rbDonationtype.AutoSize = true;
            this.rbDonationtype.Location = new System.Drawing.Point(15, 19);
            this.rbDonationtype.Name = "rbDonationtype";
            this.rbDonationtype.Size = new System.Drawing.Size(95, 17);
            this.rbDonationtype.TabIndex = 51;
            this.rbDonationtype.TabStop = true;
            this.rbDonationtype.Text = "Donation Type";
            this.rbDonationtype.UseVisualStyleBackColor = true;
            this.rbDonationtype.CheckedChanged += new System.EventHandler(this.rbDonationtype_CheckedChanged);
            // 
            // Mycbx
            // 
            this.Mycbx.FormattingEnabled = true;
            this.Mycbx.Location = new System.Drawing.Point(135, 19);
            this.Mycbx.Name = "Mycbx";
            this.Mycbx.Size = new System.Drawing.Size(147, 21);
            this.Mycbx.TabIndex = 49;
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
            this.toolStrip1.Size = new System.Drawing.Size(373, 25);
            this.toolStrip1.TabIndex = 52;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsClose
            // 
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(53, 22);
            this.tsClose.Text = "&Close";
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
            // frmDonorAndMemberCollectionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDonorAndMemberCollectionReport";
            this.Text = "Donor And Member Collection Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTodate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDonationtype;
        private System.Windows.Forms.ComboBox Mycbx;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsPreview;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.ToolStripButton tsClear;
        private System.Windows.Forms.RadioButton rbAll;
    }
}