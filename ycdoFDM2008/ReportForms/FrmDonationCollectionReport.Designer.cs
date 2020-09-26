namespace FDM.ReportForms
{
    partial class FrmDonationCollectionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonationCollectionReport));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsPreview = new System.Windows.Forms.ToolStripButton();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.tsClear = new System.Windows.Forms.ToolStripButton();
            this.cbxMemberName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDonors = new System.Windows.Forms.RadioButton();
            this.rbMembers = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(387, 25);
            this.toolStrip1.TabIndex = 48;
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
            // tsClear
            // 
            this.tsClear.Image = ((System.Drawing.Image)(resources.GetObject("tsClear.Image")));
            this.tsClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClear.Name = "tsClear";
            this.tsClear.Size = new System.Drawing.Size(79, 22);
            this.tsClear.Text = "P&review All";
            this.tsClear.Click += new System.EventHandler(this.tsClear_Click);
            // 
            // cbxMemberName
            // 
            this.cbxMemberName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxMemberName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMemberName.FormattingEnabled = true;
            this.cbxMemberName.Location = new System.Drawing.Point(6, 53);
            this.cbxMemberName.Name = "cbxMemberName";
            this.cbxMemberName.Size = new System.Drawing.Size(203, 21);
            this.cbxMemberName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDonors);
            this.groupBox1.Controls.Add(this.rbMembers);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Controls.Add(this.cbxMemberName);
            this.groupBox1.Location = new System.Drawing.Point(75, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbDonors
            // 
            this.rbDonors.AutoSize = true;
            this.rbDonors.Checked = true;
            this.rbDonors.Location = new System.Drawing.Point(118, 19);
            this.rbDonors.Name = "rbDonors";
            this.rbDonors.Size = new System.Drawing.Size(59, 17);
            this.rbDonors.TabIndex = 53;
            this.rbDonors.TabStop = true;
            this.rbDonors.Text = "Donors";
            this.rbDonors.UseVisualStyleBackColor = true;
            this.rbDonors.CheckedChanged += new System.EventHandler(this.rbDonors_CheckedChanged);
            // 
            // rbMembers
            // 
            this.rbMembers.AutoSize = true;
            this.rbMembers.Location = new System.Drawing.Point(30, 19);
            this.rbMembers.Name = "rbMembers";
            this.rbMembers.Size = new System.Drawing.Size(68, 17);
            this.rbMembers.TabIndex = 52;
            this.rbMembers.Text = "Members";
            this.rbMembers.UseVisualStyleBackColor = true;
            this.rbMembers.CheckedChanged += new System.EventHandler(this.rbMembers_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(279, 102);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(44, 17);
            this.rbAll.TabIndex = 51;
            this.rbAll.Text = "ALL";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.Visible = false;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbCityName_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpToDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpFromDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(75, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 106);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(94, 65);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(105, 20);
            this.dtpToDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(94, 33);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(105, 20);
            this.dtpFromDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "From Date";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FDM.Properties.Resources.hd_blain;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Location = new System.Drawing.Point(-2, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 95);
            this.panel1.TabIndex = 81;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(8, 14);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(410, 59);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Donor Collection Report";
            // 
            // FrmDonationCollectionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 328);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmDonationCollectionReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor Collection Report";
            this.Load += new System.EventHandler(this.FrmMembershipReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsPreview;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.ToolStripButton tsClear;
        private System.Windows.Forms.ComboBox cbxMemberName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.RadioButton rbDonors;
        private System.Windows.Forms.RadioButton rbMembers;
    }
}