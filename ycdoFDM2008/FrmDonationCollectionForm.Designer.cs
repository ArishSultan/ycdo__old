namespace FDM
{
    partial class FrmDonationCollectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonationCollectionForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.txtCollectionfee = new System.Windows.Forms.TextBox();
            this.cbxName = new System.Windows.Forms.ComboBox();
            this.lblotherDonation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCollectionDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbdonor = new System.Windows.Forms.RadioButton();
            this.rbmembers = new System.Windows.Forms.RadioButton();
            this.txtReciptNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCheck = new System.Windows.Forms.RadioButton();
            this.cbxDonationtype = new System.Windows.Forms.ComboBox();
            this.txtOtherDonation = new System.Windows.Forms.TextBox();
            this.txtCheckDetails = new System.Windows.Forms.TextBox();
            this.lblCheckDetails = new System.Windows.Forms.Label();
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
            this.tsNew,
            this.tsSave,
            this.tsEdit,
            this.tsDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(435, 25);
            this.toolStrip1.TabIndex = 8;
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
            // tsNew
            // 
            this.tsNew.Image = ((System.Drawing.Image)(resources.GetObject("tsNew.Image")));
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(48, 22);
            this.tsNew.Text = "&New";
            this.tsNew.Click += new System.EventHandler(this.tsNew_Click);
            // 
            // tsSave
            // 
            this.tsSave.Image = ((System.Drawing.Image)(resources.GetObject("tsSave.Image")));
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(51, 22);
            this.tsSave.Text = "&Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsEdit.Image")));
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(45, 22);
            this.tsEdit.Text = "&Edit";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsDelete.Image")));
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(58, 22);
            this.tsDelete.Text = "&Delete";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // txtCollectionfee
            // 
            this.txtCollectionfee.Location = new System.Drawing.Point(82, 49);
            this.txtCollectionfee.Name = "txtCollectionfee";
            this.txtCollectionfee.Size = new System.Drawing.Size(162, 20);
            this.txtCollectionfee.TabIndex = 3;
            // 
            // cbxName
            // 
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(82, 27);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(162, 21);
            this.cbxName.TabIndex = 2;
            this.cbxName.SelectedIndexChanged += new System.EventHandler(this.cbxName_SelectedIndexChanged);
            // 
            // lblotherDonation
            // 
            this.lblotherDonation.AutoSize = true;
            this.lblotherDonation.Location = new System.Drawing.Point(53, 329);
            this.lblotherDonation.Name = "lblotherDonation";
            this.lblotherDonation.Size = new System.Drawing.Size(81, 13);
            this.lblotherDonation.TabIndex = 4;
            this.lblotherDonation.Text = "Other Donation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date";
            // 
            // dtpCollectionDate
            // 
            this.dtpCollectionDate.CustomFormat = "dd/MM/yyyy";
            this.dtpCollectionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCollectionDate.Location = new System.Drawing.Point(160, 121);
            this.dtpCollectionDate.Name = "dtpCollectionDate";
            this.dtpCollectionDate.Size = new System.Drawing.Size(162, 20);
            this.dtpCollectionDate.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbdonor);
            this.groupBox1.Controls.Add(this.rbmembers);
            this.groupBox1.Controls.Add(this.cbxName);
            this.groupBox1.Controls.Add(this.txtReciptNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCollectionfee);
            this.groupBox1.Location = new System.Drawing.Point(78, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // rbdonor
            // 
            this.rbdonor.AutoSize = true;
            this.rbdonor.Location = new System.Drawing.Point(6, 31);
            this.rbdonor.Name = "rbdonor";
            this.rbdonor.Size = new System.Drawing.Size(54, 17);
            this.rbdonor.TabIndex = 1;
            this.rbdonor.TabStop = true;
            this.rbdonor.Text = "Donor";
            this.rbdonor.UseVisualStyleBackColor = true;
            this.rbdonor.CheckedChanged += new System.EventHandler(this.rbdonor_CheckedChanged);
            // 
            // rbmembers
            // 
            this.rbmembers.AutoSize = true;
            this.rbmembers.Location = new System.Drawing.Point(6, 15);
            this.rbmembers.Name = "rbmembers";
            this.rbmembers.Size = new System.Drawing.Size(63, 17);
            this.rbmembers.TabIndex = 0;
            this.rbmembers.TabStop = true;
            this.rbmembers.Text = "Member";
            this.rbmembers.UseVisualStyleBackColor = true;
            this.rbmembers.CheckedChanged += new System.EventHandler(this.rbmembers_CheckedChanged);
            // 
            // txtReciptNo
            // 
            this.txtReciptNo.Location = new System.Drawing.Point(82, 70);
            this.txtReciptNo.Name = "txtReciptNo";
            this.txtReciptNo.Size = new System.Drawing.Size(162, 20);
            this.txtReciptNo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Member Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recipt No";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(379, 304);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(38, 20);
            this.txtID.TabIndex = 5;
            this.txtID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbOther);
            this.groupBox2.Controls.Add(this.rbCash);
            this.groupBox2.Controls.Add(this.rbCheck);
            this.groupBox2.Location = new System.Drawing.Point(78, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 36);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Donation Type";
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(183, 16);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(53, 17);
            this.rbOther.TabIndex = 2;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            this.rbOther.CheckedChanged += new System.EventHandler(this.rbOther_CheckedChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(100, 16);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(49, 17);
            this.rbCash.TabIndex = 1;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // rbCheck
            // 
            this.rbCheck.AutoSize = true;
            this.rbCheck.Location = new System.Drawing.Point(13, 16);
            this.rbCheck.Name = "rbCheck";
            this.rbCheck.Size = new System.Drawing.Size(54, 17);
            this.rbCheck.TabIndex = 0;
            this.rbCheck.TabStop = true;
            this.rbCheck.Text = "Check";
            this.rbCheck.UseVisualStyleBackColor = true;
            this.rbCheck.CheckedChanged += new System.EventHandler(this.rbCheck_CheckedChanged);
            // 
            // cbxDonationtype
            // 
            this.cbxDonationtype.FormattingEnabled = true;
            this.cbxDonationtype.Location = new System.Drawing.Point(134, 291);
            this.cbxDonationtype.Name = "cbxDonationtype";
            this.cbxDonationtype.Size = new System.Drawing.Size(162, 21);
            this.cbxDonationtype.TabIndex = 2;
            this.cbxDonationtype.SelectedIndexChanged += new System.EventHandler(this.cbxName_SelectedIndexChanged);
            // 
            // txtOtherDonation
            // 
            this.txtOtherDonation.Location = new System.Drawing.Point(134, 326);
            this.txtOtherDonation.Name = "txtOtherDonation";
            this.txtOtherDonation.Size = new System.Drawing.Size(239, 20);
            this.txtOtherDonation.TabIndex = 3;
            // 
            // txtCheckDetails
            // 
            this.txtCheckDetails.Location = new System.Drawing.Point(134, 318);
            this.txtCheckDetails.Name = "txtCheckDetails";
            this.txtCheckDetails.Size = new System.Drawing.Size(239, 20);
            this.txtCheckDetails.TabIndex = 3;
            // 
            // lblCheckDetails
            // 
            this.lblCheckDetails.AutoSize = true;
            this.lblCheckDetails.Location = new System.Drawing.Point(58, 321);
            this.lblCheckDetails.Name = "lblCheckDetails";
            this.lblCheckDetails.Size = new System.Drawing.Size(71, 13);
            this.lblCheckDetails.TabIndex = 4;
            this.lblCheckDetails.Text = "Check Details";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FDM.Properties.Resources.hd_blain;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 95);
            this.panel1.TabIndex = 79;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(333, 59);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Donation";
            // 
            // FrmDonationCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxDonationtype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpCollectionDate);
            this.Controls.Add(this.txtCheckDetails);
            this.Controls.Add(this.txtOtherDonation);
            this.Controls.Add(this.lblCheckDetails);
            this.Controls.Add(this.lblotherDonation);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmDonationCollectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donation Collection Form";
            this.Load += new System.EventHandler(this.FrmDonationCollectionForm_Load);
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
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.TextBox txtCollectionfee;
        private System.Windows.Forms.ComboBox cbxName;
        private System.Windows.Forms.Label lblotherDonation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCollectionDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbdonor;
        private System.Windows.Forms.RadioButton rbmembers;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtReciptNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCheck;
        private System.Windows.Forms.ComboBox cbxDonationtype;
        private System.Windows.Forms.TextBox txtOtherDonation;
        private System.Windows.Forms.TextBox txtCheckDetails;
        private System.Windows.Forms.Label lblCheckDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
    }
}