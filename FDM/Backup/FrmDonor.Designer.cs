namespace FDM
{
    partial class FrmDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfathername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmaiAdress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxbloodGroup = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMembershipFee = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxbranches = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMembersshipNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCollectionDate = new System.Windows.Forms.TextBox();
            this.cbxFundType = new System.Windows.Forms.ComboBox();
            this.cbxCities = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbselectDonors = new System.Windows.Forms.RadioButton();
            this.rbselectMembers = new System.Windows.Forms.RadioButton();
            this.cbxReference = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(532, 25);
            this.toolStrip1.TabIndex = 27;
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
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click_1);
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
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(93, 53);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(158, 20);
            this.txtname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Donor Name :";
            // 
            // txtfathername
            // 
            this.txtfathername.Location = new System.Drawing.Point(353, 55);
            this.txtfathername.Name = "txtfathername";
            this.txtfathername.Size = new System.Drawing.Size(158, 20);
            this.txtfathername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "S/O,W/O,D/O :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Age :";
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(353, 138);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(158, 21);
            this.cbxGender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Gender :";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(94, 179);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(158, 20);
            this.txtNIC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "NIC :";
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
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(94, 216);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(158, 20);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ph/Mob Office :";
            // 
            // txtEmaiAdress
            // 
            this.txtEmaiAdress.Location = new System.Drawing.Point(353, 254);
            this.txtEmaiAdress.Name = "txtEmaiAdress";
            this.txtEmaiAdress.Size = new System.Drawing.Size(158, 20);
            this.txtEmaiAdress.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "E-Mail Adress :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Blood Group :";
            // 
            // cbxbloodGroup
            // 
            this.cbxbloodGroup.FormattingEnabled = true;
            this.cbxbloodGroup.Location = new System.Drawing.Point(94, 254);
            this.cbxbloodGroup.Name = "cbxbloodGroup";
            this.cbxbloodGroup.Size = new System.Drawing.Size(158, 21);
            this.cbxbloodGroup.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Fund Rs:";
            // 
            // txtMembershipFee
            // 
            this.txtMembershipFee.Location = new System.Drawing.Point(362, 293);
            this.txtMembershipFee.Name = "txtMembershipFee";
            this.txtMembershipFee.Size = new System.Drawing.Size(149, 20);
            this.txtMembershipFee.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Collection Date :";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(93, 365);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(418, 39);
            this.txtAdress.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Adress :";
            // 
            // cbxbranches
            // 
            this.cbxbranches.FormattingEnabled = true;
            this.cbxbranches.Location = new System.Drawing.Point(94, 423);
            this.cbxbranches.Name = "cbxbranches";
            this.cbxbranches.Size = new System.Drawing.Size(158, 21);
            this.cbxbranches.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 426);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Branches :";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(94, 136);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(158, 20);
            this.txtAge.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Donor No :";
            // 
            // txtMembersshipNo
            // 
            this.txtMembersshipNo.Location = new System.Drawing.Point(94, 95);
            this.txtMembersshipNo.Name = "txtMembersshipNo";
            this.txtMembersshipNo.Size = new System.Drawing.Size(158, 20);
            this.txtMembersshipNo.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(263, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Status :";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(353, 95);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(158, 21);
            this.cbxStatus.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 296);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Fund Type :";
            // 
            // txtCollectionDate
            // 
            this.txtCollectionDate.Location = new System.Drawing.Point(353, 332);
            this.txtCollectionDate.Name = "txtCollectionDate";
            this.txtCollectionDate.Size = new System.Drawing.Size(158, 20);
            this.txtCollectionDate.TabIndex = 13;
            // 
            // cbxFundType
            // 
            this.cbxFundType.FormattingEnabled = true;
            this.cbxFundType.Location = new System.Drawing.Point(93, 293);
            this.cbxFundType.Name = "cbxFundType";
            this.cbxFundType.Size = new System.Drawing.Size(158, 21);
            this.cbxFundType.TabIndex = 10;
            // 
            // cbxCities
            // 
            this.cbxCities.FormattingEnabled = true;
            this.cbxCities.Location = new System.Drawing.Point(353, 423);
            this.cbxCities.Name = "cbxCities";
            this.cbxCities.Size = new System.Drawing.Size(158, 21);
            this.cbxCities.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(267, 426);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "City :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 335);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Current Date :";
            // 
            // dtpCurrentDate
            // 
            this.dtpCurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCurrentDate.Location = new System.Drawing.Point(94, 331);
            this.dtpCurrentDate.Name = "dtpCurrentDate";
            this.dtpCurrentDate.Size = new System.Drawing.Size(158, 20);
            this.dtpCurrentDate.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbselectDonors);
            this.groupBox1.Controls.Add(this.rbselectMembers);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxReference);
            this.groupBox1.Location = new System.Drawing.Point(266, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 83);
            this.groupBox1.TabIndex = 31;
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
            // cbxReference
            // 
            this.cbxReference.FormattingEnabled = true;
            this.cbxReference.Location = new System.Drawing.Point(87, 53);
            this.cbxReference.Name = "cbxReference";
            this.cbxReference.Size = new System.Drawing.Size(158, 21);
            this.cbxReference.TabIndex = 2;
            // 
            // FrmDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(532, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpCurrentDate);
            this.Controls.Add(this.cbxCities);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbxbranches);
            this.Controls.Add(this.cbxFundType);
            this.Controls.Add(this.cbxbloodGroup);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfathername);
            this.Controls.Add(this.txtMembershipFee);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtCollectionDate);
            this.Controls.Add(this.txtEmaiAdress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtMembersshipNo);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmDonor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDonor";
            this.Load += new System.EventHandler(this.FrmMembership_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfathername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmaiAdress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxbloodGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMembershipFee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxbranches;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMembersshipNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCollectionDate;
        private System.Windows.Forms.ComboBox cbxFundType;
        private System.Windows.Forms.ComboBox cbxCities;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpCurrentDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbselectDonors;
        private System.Windows.Forms.RadioButton rbselectMembers;
        private System.Windows.Forms.ComboBox cbxReference;
    }
}