namespace FDM
{
    partial class FrmMembership
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMembership));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
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
            this.txtMembersshipNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMonthlyFee = new System.Windows.Forms.TextBox();
            this.cbxCities = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.grpreference = new System.Windows.Forms.GroupBox();
            this.cbxReference = new System.Windows.Forms.ComboBox();
            this.rbselectDonors = new System.Windows.Forms.RadioButton();
            this.rbselectMembers = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpcurrentdate = new System.Windows.Forms.DateTimePicker();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbxMembertype = new System.Windows.Forms.ComboBox();
            this.cbxCounsil = new System.Windows.Forms.CheckedListBox();
            this.cbxCommitte = new System.Windows.Forms.CheckedListBox();
            this.pbxMemberHeader = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpCollectionDate = new System.Windows.Forms.DateTimePicker();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.grpreference.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberHeader)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(779, 25);
            this.toolStrip1.TabIndex = 42;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsClose
            // 
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(56, 22);
            this.tsClose.Text = "&Close";
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click);
            // 
            // tsNew
            // 
            this.tsNew.Image = ((System.Drawing.Image)(resources.GetObject("tsNew.Image")));
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(51, 22);
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
            this.tsEdit.Size = new System.Drawing.Size(47, 22);
            this.tsEdit.Text = "&Edit";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsDelete.Image")));
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(60, 22);
            this.tsDelete.Text = "&Delete";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Name :";
            // 
            // txtfathername
            // 
            this.txtfathername.Location = new System.Drawing.Point(339, 138);
            this.txtfathername.Name = "txtfathername";
            this.txtfathername.Size = new System.Drawing.Size(158, 20);
            this.txtfathername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "S/O,W/O,D/O :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Of Birth:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(339, 164);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(158, 21);
            this.cbxGender.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender :";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(90, 191);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(158, 20);
            this.txtNIC.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "NIC :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Reference :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(90, 218);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(158, 20);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ph/Mob Office :";
            // 
            // txtEmaiAdress
            // 
            this.txtEmaiAdress.Location = new System.Drawing.Point(238, 353);
            this.txtEmaiAdress.Name = "txtEmaiAdress";
            this.txtEmaiAdress.Size = new System.Drawing.Size(100, 20);
            this.txtEmaiAdress.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Blood Group :";
            // 
            // cbxbloodGroup
            // 
            this.cbxbloodGroup.FormattingEnabled = true;
            this.cbxbloodGroup.Location = new System.Drawing.Point(339, 191);
            this.cbxbloodGroup.Name = "cbxbloodGroup";
            this.cbxbloodGroup.Size = new System.Drawing.Size(158, 21);
            this.cbxbloodGroup.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(502, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Membership Fee Rs:";
            // 
            // txtMembershipFee
            // 
            this.txtMembershipFee.Location = new System.Drawing.Point(611, 221);
            this.txtMembershipFee.Name = "txtMembershipFee";
            this.txtMembershipFee.Size = new System.Drawing.Size(158, 20);
            this.txtMembershipFee.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Collection Date :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(90, 270);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(408, 48);
            this.txtAdress.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Adress :";
            // 
            // cbxbranches
            // 
            this.cbxbranches.FormattingEnabled = true;
            this.cbxbranches.Location = new System.Drawing.Point(90, 324);
            this.cbxbranches.Name = "cbxbranches";
            this.cbxbranches.Size = new System.Drawing.Size(96, 21);
            this.cbxbranches.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Branches :";
            // 
            // txtMembersshipNo
            // 
            this.txtMembersshipNo.Enabled = false;
            this.txtMembersshipNo.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembersshipNo.ForeColor = System.Drawing.Color.Maroon;
            this.txtMembersshipNo.Location = new System.Drawing.Point(503, 135);
            this.txtMembersshipNo.Multiline = true;
            this.txtMembersshipNo.Name = "txtMembersshipNo";
            this.txtMembersshipNo.Size = new System.Drawing.Size(266, 80);
            this.txtMembersshipNo.TabIndex = 41;
            this.txtMembersshipNo.Text = "100000";
            this.txtMembersshipNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Marital Status :";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(90, 351);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(96, 21);
            this.cbxStatus.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(252, 218);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Monthly :";
            // 
            // txtMonthlyFee
            // 
            this.txtMonthlyFee.Location = new System.Drawing.Point(339, 218);
            this.txtMonthlyFee.Name = "txtMonthlyFee";
            this.txtMonthlyFee.Size = new System.Drawing.Size(158, 20);
            this.txtMonthlyFee.TabIndex = 15;
            // 
            // cbxCities
            // 
            this.cbxCities.FormattingEnabled = true;
            this.cbxCities.Location = new System.Drawing.Point(238, 324);
            this.cbxCities.Name = "cbxCities";
            this.cbxCities.Size = new System.Drawing.Size(96, 21);
            this.cbxCities.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(192, 324);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "City :";
            // 
            // grpreference
            // 
            this.grpreference.Controls.Add(this.cbxReference);
            this.grpreference.Controls.Add(this.rbselectDonors);
            this.grpreference.Controls.Add(this.rbselectMembers);
            this.grpreference.Controls.Add(this.label6);
            this.grpreference.Location = new System.Drawing.Point(7, 375);
            this.grpreference.Name = "grpreference";
            this.grpreference.Size = new System.Drawing.Size(497, 47);
            this.grpreference.TabIndex = 34;
            this.grpreference.TabStop = false;
            this.grpreference.Text = "Refered By:";
            // 
            // cbxReference
            // 
            this.cbxReference.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxReference.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxReference.FormattingEnabled = true;
            this.cbxReference.Location = new System.Drawing.Point(333, 20);
            this.cbxReference.Name = "cbxReference";
            this.cbxReference.Size = new System.Drawing.Size(158, 21);
            this.cbxReference.TabIndex = 3;
            // 
            // rbselectDonors
            // 
            this.rbselectDonors.AutoSize = true;
            this.rbselectDonors.Location = new System.Drawing.Point(94, 20);
            this.rbselectDonors.Name = "rbselectDonors";
            this.rbselectDonors.Size = new System.Drawing.Size(59, 17);
            this.rbselectDonors.TabIndex = 1;
            this.rbselectDonors.Text = "Donors";
            this.rbselectDonors.UseVisualStyleBackColor = true;
            this.rbselectDonors.CheckedChanged += new System.EventHandler(this.rbselectDonors_CheckedChanged);
            // 
            // rbselectMembers
            // 
            this.rbselectMembers.AutoSize = true;
            this.rbselectMembers.Checked = true;
            this.rbselectMembers.Location = new System.Drawing.Point(11, 20);
            this.rbselectMembers.Name = "rbselectMembers";
            this.rbselectMembers.Size = new System.Drawing.Size(68, 17);
            this.rbselectMembers.TabIndex = 0;
            this.rbselectMembers.TabStop = true;
            this.rbselectMembers.Text = "Members";
            this.rbselectMembers.UseVisualStyleBackColor = true;
            this.rbselectMembers.CheckedChanged += new System.EventHandler(this.rbselectMembers_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 244);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "CurrentDate :";
            // 
            // dtpcurrentdate
            // 
            this.dtpcurrentdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcurrentdate.Location = new System.Drawing.Point(90, 244);
            this.dtpcurrentdate.Name = "dtpcurrentdate";
            this.dtpcurrentdate.Size = new System.Drawing.Size(158, 20);
            this.dtpcurrentdate.TabIndex = 17;
            // 
            // cbxCountry
            // 
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Location = new System.Drawing.Point(402, 324);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(96, 21);
            this.cbxCountry.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(343, 324);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Country :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(344, 356);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Type :";
            // 
            // cbxMembertype
            // 
            this.cbxMembertype.FormattingEnabled = true;
            this.cbxMembertype.Location = new System.Drawing.Point(402, 353);
            this.cbxMembertype.Name = "cbxMembertype";
            this.cbxMembertype.Size = new System.Drawing.Size(96, 21);
            this.cbxMembertype.TabIndex = 33;
            // 
            // cbxCounsil
            // 
            this.cbxCounsil.FormattingEnabled = true;
            this.cbxCounsil.Location = new System.Drawing.Point(648, 268);
            this.cbxCounsil.Name = "cbxCounsil";
            this.cbxCounsil.Size = new System.Drawing.Size(124, 154);
            this.cbxCounsil.TabIndex = 40;
            // 
            // cbxCommitte
            // 
            this.cbxCommitte.FormattingEnabled = true;
            this.cbxCommitte.Location = new System.Drawing.Point(509, 268);
            this.cbxCommitte.Name = "cbxCommitte";
            this.cbxCommitte.Size = new System.Drawing.Size(124, 154);
            this.cbxCommitte.TabIndex = 38;
            // 
            // pbxMemberHeader
            // 
            this.pbxMemberHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxMemberHeader.Image = global::FDM.Properties.Resources.hd_member;
            this.pbxMemberHeader.Location = new System.Drawing.Point(0, 25);
            this.pbxMemberHeader.Name = "pbxMemberHeader";
            this.pbxMemberHeader.Size = new System.Drawing.Size(779, 104);
            this.pbxMemberHeader.TabIndex = 45;
            this.pbxMemberHeader.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(506, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Comittees:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(650, 248);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "Councils:";
            // 
            // dtpCollectionDate
            // 
            this.dtpCollectionDate.CustomFormat = "dd";
            this.dtpCollectionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCollectionDate.Location = new System.Drawing.Point(339, 241);
            this.dtpCollectionDate.Name = "dtpCollectionDate";
            this.dtpCollectionDate.Size = new System.Drawing.Size(158, 20);
            this.dtpCollectionDate.TabIndex = 19;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(89, 138);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(158, 20);
            this.txtname.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(89, 165);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(158, 20);
            this.txtAge.TabIndex = 46;
            // 
            // FrmMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(779, 439);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.dtpCollectionDate);
            this.Controls.Add(this.pbxMemberHeader);
            this.Controls.Add(this.cbxCommitte);
            this.Controls.Add(this.cbxCounsil);
            this.Controls.Add(this.dtpcurrentdate);
            this.Controls.Add(this.grpreference);
            this.Controls.Add(this.cbxMembertype);
            this.Controls.Add(this.cbxCountry);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbxCities);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbxbranches);
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
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfathername);
            this.Controls.Add(this.txtMembershipFee);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtEmaiAdress);
            this.Controls.Add(this.txtMonthlyFee);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.txtMembersshipNo);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMembership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membership & Bio Data Form";
            this.Load += new System.EventHandler(this.FrmMembership_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpreference.ResumeLayout(false);
            this.grpreference.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberHeader)).EndInit();
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
        private System.Windows.Forms.TextBox txtMembersshipNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMonthlyFee;
        private System.Windows.Forms.ComboBox cbxCities;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox grpreference;
        private System.Windows.Forms.RadioButton rbselectMembers;
        private System.Windows.Forms.ComboBox cbxReference;
        private System.Windows.Forms.RadioButton rbselectDonors;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpcurrentdate;
        private System.Windows.Forms.ComboBox cbxCountry;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbxMembertype;
        private System.Windows.Forms.CheckedListBox cbxCounsil;
        private System.Windows.Forms.CheckedListBox cbxCommitte;
        private System.Windows.Forms.PictureBox pbxMemberHeader;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpCollectionDate;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtAge;
    }
}