namespace FDM
{
    partial class frmSecondTurn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecondTurn));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsReprintToken = new System.Windows.Forms.ToolStripButton();
            this.tsSyring = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chxSyringe = new System.Windows.Forms.CheckBox();
            this.cbxRs10 = new System.Windows.Forms.ComboBox();
            this.txtExistingToken = new System.Windows.Forms.TextBox();
            this.btnExistingToken = new System.Windows.Forms.Button();
            this.gbLabTest = new System.Windows.Forms.GroupBox();
            this.txtDays = new System.Windows.Forms.NumericUpDown();
            this.gbxPerDayDose = new System.Windows.Forms.GroupBox();
            this.rbThreeDay = new System.Windows.Forms.RadioButton();
            this.rbTwoDay = new System.Windows.Forms.RadioButton();
            this.rbOneDay = new System.Windows.Forms.RadioButton();
            this.btnAddLabTest = new System.Windows.Forms.Button();
            this.cbxLabTest = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstLabTest = new System.Windows.Forms.ListBox();
            this.rbGeneral2nd = new System.Windows.Forms.RadioButton();
            this.rbYCOD = new System.Windows.Forms.RadioButton();
            this.rbPoor = new System.Windows.Forms.RadioButton();
            this.rbDeserving = new System.Windows.Forms.RadioButton();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblRS10 = new System.Windows.Forms.Label();
            this.lblTokenDate2nd = new System.Windows.Forms.Label();
            this.lblTokenNumber2nd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLabTest = new System.Windows.Forms.RadioButton();
            this.rbInjection = new System.Windows.Forms.RadioButton();
            this.dtpPatientRegistration2nd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatientCNIC2nd = new System.Windows.Forms.TextBox();
            this.txtPateintRegistrationNumber2nd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPatientAddress2nd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPatientLastName2nd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPatientFirstName2nd = new System.Windows.Forms.TextBox();
            this.lblCurrentTokenNumber2nd = new System.Windows.Forms.Label();
            this.txtSecondLabTotal = new System.Windows.Forms.TextBox();
            this.txtSecondFreeTotal = new System.Windows.Forms.TextBox();
            this.txtSecondInjTotal = new System.Windows.Forms.TextBox();
            this.txtSecondPaidTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCashRecieved2nd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCashRecievedByUser = new System.Windows.Forms.TextBox();
            this.txtPatientMobile2nd = new System.Windows.Forms.TextBox();
            this.lblPatientMobile = new System.Windows.Forms.Label();
            this.txtPatientAge2nd = new System.Windows.Forms.TextBox();
            this.lblPatientAge = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRooms = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbLabTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDays)).BeginInit();
            this.gbxPerDayDose.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsNew,
            this.tsSave,
            this.tsReprintToken,
            this.tsSyring});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 25);
            this.toolStrip1.TabIndex = 1;
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
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsReprintToken
            // 
            this.tsReprintToken.Image = ((System.Drawing.Image)(resources.GetObject("tsReprintToken.Image")));
            this.tsReprintToken.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReprintToken.Name = "tsReprintToken";
            this.tsReprintToken.Size = new System.Drawing.Size(112, 22);
            this.tsReprintToken.Text = "&Duplicate Token";
            this.tsReprintToken.Click += new System.EventHandler(this.tsReprintToken_Click);
            // 
            // tsSyring
            // 
            this.tsSyring.Image = ((System.Drawing.Image)(resources.GetObject("tsSyring.Image")));
            this.tsSyring.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSyring.Name = "tsSyring";
            this.tsSyring.Size = new System.Drawing.Size(60, 22);
            this.tsSyring.Text = "Syring";
            this.tsSyring.Click += new System.EventHandler(this.tsSyring_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FDM.Properties.Resources.hd_patient;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 85);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // chxSyringe
            // 
            this.chxSyringe.AutoSize = true;
            this.chxSyringe.Location = new System.Drawing.Point(381, 249);
            this.chxSyringe.Name = "chxSyringe";
            this.chxSyringe.Size = new System.Drawing.Size(77, 17);
            this.chxSyringe.TabIndex = 66;
            this.chxSyringe.Text = "Add Syring";
            this.chxSyringe.UseVisualStyleBackColor = true;
            // 
            // cbxRs10
            // 
            this.cbxRs10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxRs10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxRs10.FormattingEnabled = true;
            this.cbxRs10.Location = new System.Drawing.Point(297, 266);
            this.cbxRs10.Name = "cbxRs10";
            this.cbxRs10.Size = new System.Drawing.Size(277, 21);
            this.cbxRs10.TabIndex = 16;
            // 
            // txtExistingToken
            // 
            this.txtExistingToken.BackColor = System.Drawing.Color.Gainsboro;
            this.txtExistingToken.Location = new System.Drawing.Point(483, 127);
            this.txtExistingToken.Name = "txtExistingToken";
            this.txtExistingToken.ReadOnly = true;
            this.txtExistingToken.Size = new System.Drawing.Size(78, 20);
            this.txtExistingToken.TabIndex = 64;
            this.txtExistingToken.Visible = false;
            // 
            // btnExistingToken
            // 
            this.btnExistingToken.Location = new System.Drawing.Point(373, 124);
            this.btnExistingToken.Name = "btnExistingToken";
            this.btnExistingToken.Size = new System.Drawing.Size(105, 23);
            this.btnExistingToken.TabIndex = 63;
            this.btnExistingToken.Text = "E&xisting Token No.";
            this.btnExistingToken.UseVisualStyleBackColor = true;
            this.btnExistingToken.Click += new System.EventHandler(this.btnExistingToken_Click);
            // 
            // gbLabTest
            // 
            this.gbLabTest.Controls.Add(this.txtDays);
            this.gbLabTest.Controls.Add(this.gbxPerDayDose);
            this.gbLabTest.Controls.Add(this.btnAddLabTest);
            this.gbLabTest.Controls.Add(this.cbxLabTest);
            this.gbLabTest.Controls.Add(this.label9);
            this.gbLabTest.Controls.Add(this.lstLabTest);
            this.gbLabTest.Controls.Add(this.rbGeneral2nd);
            this.gbLabTest.Controls.Add(this.rbYCOD);
            this.gbLabTest.Controls.Add(this.rbPoor);
            this.gbLabTest.Controls.Add(this.rbDeserving);
            this.gbLabTest.Controls.Add(this.lblDays);
            this.gbLabTest.Location = new System.Drawing.Point(26, 332);
            this.gbLabTest.Name = "gbLabTest";
            this.gbLabTest.Size = new System.Drawing.Size(643, 117);
            this.gbLabTest.TabIndex = 10;
            this.gbLabTest.TabStop = false;
            this.gbLabTest.Text = "Lab Test";
            this.gbLabTest.Visible = false;
            // 
            // txtDays
            // 
            this.txtDays.Enabled = false;
            this.txtDays.Location = new System.Drawing.Point(259, 89);
            this.txtDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.txtDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(109, 20);
            this.txtDays.TabIndex = 8;
            this.txtDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbxPerDayDose
            // 
            this.gbxPerDayDose.Controls.Add(this.rbThreeDay);
            this.gbxPerDayDose.Controls.Add(this.rbTwoDay);
            this.gbxPerDayDose.Controls.Add(this.rbOneDay);
            this.gbxPerDayDose.Location = new System.Drawing.Point(374, 19);
            this.gbxPerDayDose.Name = "gbxPerDayDose";
            this.gbxPerDayDose.Size = new System.Drawing.Size(58, 67);
            this.gbxPerDayDose.TabIndex = 6;
            this.gbxPerDayDose.TabStop = false;
            this.gbxPerDayDose.Text = "Dose";
            // 
            // rbThreeDay
            // 
            this.rbThreeDay.AutoSize = true;
            this.rbThreeDay.Location = new System.Drawing.Point(6, 46);
            this.rbThreeDay.Name = "rbThreeDay";
            this.rbThreeDay.Size = new System.Drawing.Size(39, 17);
            this.rbThreeDay.TabIndex = 2;
            this.rbThreeDay.Text = "tds";
            this.rbThreeDay.UseVisualStyleBackColor = true;
            // 
            // rbTwoDay
            // 
            this.rbTwoDay.AutoSize = true;
            this.rbTwoDay.Location = new System.Drawing.Point(6, 30);
            this.rbTwoDay.Name = "rbTwoDay";
            this.rbTwoDay.Size = new System.Drawing.Size(37, 17);
            this.rbTwoDay.TabIndex = 1;
            this.rbTwoDay.Text = "bd";
            this.rbTwoDay.UseVisualStyleBackColor = true;
            // 
            // rbOneDay
            // 
            this.rbOneDay.AutoSize = true;
            this.rbOneDay.Checked = true;
            this.rbOneDay.Location = new System.Drawing.Point(6, 15);
            this.rbOneDay.Name = "rbOneDay";
            this.rbOneDay.Size = new System.Drawing.Size(37, 17);
            this.rbOneDay.TabIndex = 0;
            this.rbOneDay.TabStop = true;
            this.rbOneDay.Text = "od";
            this.rbOneDay.UseVisualStyleBackColor = true;
            // 
            // btnAddLabTest
            // 
            this.btnAddLabTest.Location = new System.Drawing.Point(374, 87);
            this.btnAddLabTest.Name = "btnAddLabTest";
            this.btnAddLabTest.Size = new System.Drawing.Size(58, 23);
            this.btnAddLabTest.TabIndex = 9;
            this.btnAddLabTest.Text = "Add";
            this.btnAddLabTest.UseVisualStyleBackColor = true;
            this.btnAddLabTest.Click += new System.EventHandler(this.btnAddLabTest_Click);
            // 
            // cbxLabTest
            // 
            this.cbxLabTest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLabTest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLabTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLabTest.FormattingEnabled = true;
            this.cbxLabTest.Location = new System.Drawing.Point(61, 60);
            this.cbxLabTest.Name = "cbxLabTest";
            this.cbxLabTest.Size = new System.Drawing.Size(307, 24);
            this.cbxLabTest.TabIndex = 5;
            this.cbxLabTest.SelectedIndexChanged += new System.EventHandler(this.cbxLabTest_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Lab Test:";
            // 
            // lstLabTest
            // 
            this.lstLabTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLabTest.FormattingEnabled = true;
            this.lstLabTest.ItemHeight = 16;
            this.lstLabTest.Location = new System.Drawing.Point(438, 11);
            this.lstLabTest.Name = "lstLabTest";
            this.lstLabTest.Size = new System.Drawing.Size(199, 100);
            this.lstLabTest.TabIndex = 10;
            this.lstLabTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstLabTest_KeyDown);
            // 
            // rbGeneral2nd
            // 
            this.rbGeneral2nd.AutoSize = true;
            this.rbGeneral2nd.Checked = true;
            this.rbGeneral2nd.Location = new System.Drawing.Point(89, 42);
            this.rbGeneral2nd.Name = "rbGeneral2nd";
            this.rbGeneral2nd.Size = new System.Drawing.Size(62, 17);
            this.rbGeneral2nd.TabIndex = 3;
            this.rbGeneral2nd.TabStop = true;
            this.rbGeneral2nd.Text = "General";
            this.rbGeneral2nd.UseVisualStyleBackColor = true;
            this.rbGeneral2nd.CheckedChanged += new System.EventHandler(this.PatientPayType_Changed);
            // 
            // rbYCOD
            // 
            this.rbYCOD.AutoSize = true;
            this.rbYCOD.Location = new System.Drawing.Point(89, 19);
            this.rbYCOD.Name = "rbYCOD";
            this.rbYCOD.Size = new System.Drawing.Size(96, 17);
            this.rbYCOD.TabIndex = 1;
            this.rbYCOD.Text = "YCDO Member";
            this.rbYCOD.UseVisualStyleBackColor = true;
            this.rbYCOD.CheckedChanged += new System.EventHandler(this.PatientPayType_Changed);
            // 
            // rbPoor
            // 
            this.rbPoor.AutoSize = true;
            this.rbPoor.Location = new System.Drawing.Point(10, 42);
            this.rbPoor.Name = "rbPoor";
            this.rbPoor.Size = new System.Drawing.Size(47, 17);
            this.rbPoor.TabIndex = 2;
            this.rbPoor.Text = "Poor";
            this.rbPoor.UseVisualStyleBackColor = true;
            this.rbPoor.CheckedChanged += new System.EventHandler(this.PatientPayType_Changed);
            // 
            // rbDeserving
            // 
            this.rbDeserving.AutoSize = true;
            this.rbDeserving.Location = new System.Drawing.Point(10, 19);
            this.rbDeserving.Name = "rbDeserving";
            this.rbDeserving.Size = new System.Drawing.Size(73, 17);
            this.rbDeserving.TabIndex = 0;
            this.rbDeserving.Text = "Deserving";
            this.rbDeserving.UseVisualStyleBackColor = true;
            this.rbDeserving.CheckedChanged += new System.EventHandler(this.PatientPayType_Changed);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(205, 92);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(34, 13);
            this.lblDays.TabIndex = 7;
            this.lblDays.Text = "Days:";
            // 
            // lblRS10
            // 
            this.lblRS10.AutoSize = true;
            this.lblRS10.Location = new System.Drawing.Point(297, 250);
            this.lblRS10.Name = "lblRS10";
            this.lblRS10.Size = new System.Drawing.Size(38, 13);
            this.lblRS10.TabIndex = 51;
            this.lblRS10.Text = "Rs. 10";
            // 
            // lblTokenDate2nd
            // 
            this.lblTokenDate2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenDate2nd.Location = new System.Drawing.Point(594, 241);
            this.lblTokenDate2nd.Name = "lblTokenDate2nd";
            this.lblTokenDate2nd.Size = new System.Drawing.Size(165, 25);
            this.lblTokenDate2nd.TabIndex = 60;
            this.lblTokenDate2nd.Text = "Date";
            this.lblTokenDate2nd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTokenNumber2nd
            // 
            this.lblTokenNumber2nd.AutoSize = true;
            this.lblTokenNumber2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenNumber2nd.Location = new System.Drawing.Point(594, 126);
            this.lblTokenNumber2nd.Name = "lblTokenNumber2nd";
            this.lblTokenNumber2nd.Size = new System.Drawing.Size(165, 25);
            this.lblTokenNumber2nd.TabIndex = 61;
            this.lblTokenNumber2nd.Text = "Token Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Patient Registration #:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLabTest);
            this.groupBox1.Controls.Add(this.rbInjection);
            this.groupBox1.Location = new System.Drawing.Point(682, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 67);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Token Type";
            // 
            // rbLabTest
            // 
            this.rbLabTest.AutoSize = true;
            this.rbLabTest.Location = new System.Drawing.Point(6, 42);
            this.rbLabTest.Name = "rbLabTest";
            this.rbLabTest.Size = new System.Drawing.Size(67, 17);
            this.rbLabTest.TabIndex = 1;
            this.rbLabTest.Text = "Lab Test";
            this.rbLabTest.UseVisualStyleBackColor = true;
            // 
            // rbInjection
            // 
            this.rbInjection.AutoSize = true;
            this.rbInjection.Checked = true;
            this.rbInjection.Location = new System.Drawing.Point(6, 19);
            this.rbInjection.Name = "rbInjection";
            this.rbInjection.Size = new System.Drawing.Size(65, 17);
            this.rbInjection.TabIndex = 0;
            this.rbInjection.TabStop = true;
            this.rbInjection.Text = "Injection";
            this.rbInjection.UseVisualStyleBackColor = true;
            this.rbInjection.CheckedChanged += new System.EventHandler(this.rbInjection_CheckedChanged);
            // 
            // dtpPatientRegistration2nd
            // 
            this.dtpPatientRegistration2nd.CustomFormat = "dd/MM/yyyy";
            this.dtpPatientRegistration2nd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPatientRegistration2nd.Location = new System.Drawing.Point(190, 149);
            this.dtpPatientRegistration2nd.Name = "dtpPatientRegistration2nd";
            this.dtpPatientRegistration2nd.Size = new System.Drawing.Size(169, 20);
            this.dtpPatientRegistration2nd.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Patient Registration Date:";
            // 
            // txtPatientCNIC2nd
            // 
            this.txtPatientCNIC2nd.Location = new System.Drawing.Point(28, 228);
            this.txtPatientCNIC2nd.Name = "txtPatientCNIC2nd";
            this.txtPatientCNIC2nd.Size = new System.Drawing.Size(156, 20);
            this.txtPatientCNIC2nd.TabIndex = 5;
            // 
            // txtPateintRegistrationNumber2nd
            // 
            this.txtPateintRegistrationNumber2nd.BackColor = System.Drawing.Color.White;
            this.txtPateintRegistrationNumber2nd.Location = new System.Drawing.Point(28, 149);
            this.txtPateintRegistrationNumber2nd.Name = "txtPateintRegistrationNumber2nd";
            this.txtPateintRegistrationNumber2nd.ReadOnly = true;
            this.txtPateintRegistrationNumber2nd.Size = new System.Drawing.Size(156, 20);
            this.txtPateintRegistrationNumber2nd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Patient CNIC #:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "First Name:";
            // 
            // txtPatientAddress2nd
            // 
            this.txtPatientAddress2nd.Location = new System.Drawing.Point(26, 266);
            this.txtPatientAddress2nd.Multiline = true;
            this.txtPatientAddress2nd.Name = "txtPatientAddress2nd";
            this.txtPatientAddress2nd.Size = new System.Drawing.Size(265, 19);
            this.txtPatientAddress2nd.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Patient Address:";
            // 
            // txtPatientLastName2nd
            // 
            this.txtPatientLastName2nd.Location = new System.Drawing.Point(190, 188);
            this.txtPatientLastName2nd.Name = "txtPatientLastName2nd";
            this.txtPatientLastName2nd.Size = new System.Drawing.Size(169, 20);
            this.txtPatientLastName2nd.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Last Name:";
            // 
            // txtPatientFirstName2nd
            // 
            this.txtPatientFirstName2nd.Location = new System.Drawing.Point(28, 188);
            this.txtPatientFirstName2nd.Name = "txtPatientFirstName2nd";
            this.txtPatientFirstName2nd.Size = new System.Drawing.Size(156, 20);
            this.txtPatientFirstName2nd.TabIndex = 3;
            // 
            // lblCurrentTokenNumber2nd
            // 
            this.lblCurrentTokenNumber2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTokenNumber2nd.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentTokenNumber2nd.Location = new System.Drawing.Point(464, 152);
            this.lblCurrentTokenNumber2nd.Name = "lblCurrentTokenNumber2nd";
            this.lblCurrentTokenNumber2nd.Size = new System.Drawing.Size(347, 107);
            this.lblCurrentTokenNumber2nd.TabIndex = 62;
            this.lblCurrentTokenNumber2nd.Text = "-100";
            this.lblCurrentTokenNumber2nd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentTokenNumber2nd.Click += new System.EventHandler(this.lblCurrentTokenNumber2nd_Click);
            // 
            // txtSecondLabTotal
            // 
            this.txtSecondLabTotal.BackColor = System.Drawing.Color.White;
            this.txtSecondLabTotal.Location = new System.Drawing.Point(26, 481);
            this.txtSecondLabTotal.Name = "txtSecondLabTotal";
            this.txtSecondLabTotal.ReadOnly = true;
            this.txtSecondLabTotal.Size = new System.Drawing.Size(193, 20);
            this.txtSecondLabTotal.TabIndex = 76;
            this.txtSecondLabTotal.Visible = false;
            // 
            // txtSecondFreeTotal
            // 
            this.txtSecondFreeTotal.BackColor = System.Drawing.Color.White;
            this.txtSecondFreeTotal.Location = new System.Drawing.Point(229, 455);
            this.txtSecondFreeTotal.Name = "txtSecondFreeTotal";
            this.txtSecondFreeTotal.ReadOnly = true;
            this.txtSecondFreeTotal.Size = new System.Drawing.Size(193, 20);
            this.txtSecondFreeTotal.TabIndex = 75;
            this.txtSecondFreeTotal.Visible = false;
            // 
            // txtSecondInjTotal
            // 
            this.txtSecondInjTotal.BackColor = System.Drawing.Color.White;
            this.txtSecondInjTotal.Location = new System.Drawing.Point(428, 455);
            this.txtSecondInjTotal.Name = "txtSecondInjTotal";
            this.txtSecondInjTotal.ReadOnly = true;
            this.txtSecondInjTotal.Size = new System.Drawing.Size(193, 20);
            this.txtSecondInjTotal.TabIndex = 74;
            this.txtSecondInjTotal.Visible = false;
            // 
            // txtSecondPaidTotal
            // 
            this.txtSecondPaidTotal.BackColor = System.Drawing.Color.White;
            this.txtSecondPaidTotal.Location = new System.Drawing.Point(26, 455);
            this.txtSecondPaidTotal.Name = "txtSecondPaidTotal";
            this.txtSecondPaidTotal.ReadOnly = true;
            this.txtSecondPaidTotal.Size = new System.Drawing.Size(193, 20);
            this.txtSecondPaidTotal.TabIndex = 73;
            this.txtSecondPaidTotal.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(684, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total Cash:";
            // 
            // txtCashRecieved2nd
            // 
            this.txtCashRecieved2nd.BackColor = System.Drawing.Color.White;
            this.txtCashRecieved2nd.Location = new System.Drawing.Point(683, 379);
            this.txtCashRecieved2nd.Name = "txtCashRecieved2nd";
            this.txtCashRecieved2nd.ReadOnly = true;
            this.txtCashRecieved2nd.Size = new System.Drawing.Size(112, 20);
            this.txtCashRecieved2nd.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Cash Received:";
            // 
            // txtCashRecievedByUser
            // 
            this.txtCashRecievedByUser.BackColor = System.Drawing.Color.White;
            this.txtCashRecievedByUser.Location = new System.Drawing.Point(683, 431);
            this.txtCashRecievedByUser.Name = "txtCashRecievedByUser";
            this.txtCashRecievedByUser.Size = new System.Drawing.Size(112, 20);
            this.txtCashRecievedByUser.TabIndex = 14;
            this.txtCashRecievedByUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCashRecievedByUser_KeyDown);
            this.txtCashRecievedByUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashRecievedByUser_KeyPress);
            // 
            // txtPatientMobile2nd
            // 
            this.txtPatientMobile2nd.Location = new System.Drawing.Point(190, 229);
            this.txtPatientMobile2nd.Name = "txtPatientMobile2nd";
            this.txtPatientMobile2nd.Size = new System.Drawing.Size(169, 20);
            this.txtPatientMobile2nd.TabIndex = 6;
            // 
            // lblPatientMobile
            // 
            this.lblPatientMobile.AutoSize = true;
            this.lblPatientMobile.Location = new System.Drawing.Point(190, 213);
            this.lblPatientMobile.Name = "lblPatientMobile";
            this.lblPatientMobile.Size = new System.Drawing.Size(87, 13);
            this.lblPatientMobile.TabIndex = 79;
            this.lblPatientMobile.Text = "Patient Mobile #:";
            // 
            // txtPatientAge2nd
            // 
            this.txtPatientAge2nd.Location = new System.Drawing.Point(369, 229);
            this.txtPatientAge2nd.Name = "txtPatientAge2nd";
            this.txtPatientAge2nd.Size = new System.Drawing.Size(74, 20);
            this.txtPatientAge2nd.TabIndex = 7;
            // 
            // lblPatientAge
            // 
            this.lblPatientAge.AutoSize = true;
            this.lblPatientAge.Location = new System.Drawing.Point(369, 213);
            this.lblPatientAge.Name = "lblPatientAge";
            this.lblPatientAge.Size = new System.Drawing.Size(29, 13);
            this.lblPatientAge.TabIndex = 81;
            this.lblPatientAge.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Checked By :";
            // 
            // cbxRooms
            // 
            this.cbxRooms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxRooms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxRooms.FormattingEnabled = true;
            this.cbxRooms.Location = new System.Drawing.Point(26, 304);
            this.cbxRooms.Name = "cbxRooms";
            this.cbxRooms.Size = new System.Drawing.Size(265, 21);
            this.cbxRooms.TabIndex = 9;
            // 
            // frmSecondTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxRooms);
            this.Controls.Add(this.txtPatientAge2nd);
            this.Controls.Add(this.lblPatientAge);
            this.Controls.Add(this.txtPatientMobile2nd);
            this.Controls.Add(this.lblPatientMobile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCashRecievedByUser);
            this.Controls.Add(this.txtSecondLabTotal);
            this.Controls.Add(this.txtSecondFreeTotal);
            this.Controls.Add(this.txtSecondInjTotal);
            this.Controls.Add(this.txtSecondPaidTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCashRecieved2nd);
            this.Controls.Add(this.chxSyringe);
            this.Controls.Add(this.cbxRs10);
            this.Controls.Add(this.txtExistingToken);
            this.Controls.Add(this.btnExistingToken);
            this.Controls.Add(this.gbLabTest);
            this.Controls.Add(this.lblRS10);
            this.Controls.Add(this.lblTokenDate2nd);
            this.Controls.Add(this.lblTokenNumber2nd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpPatientRegistration2nd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPatientCNIC2nd);
            this.Controls.Add(this.txtPateintRegistrationNumber2nd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPatientAddress2nd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPatientLastName2nd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPatientFirstName2nd);
            this.Controls.Add(this.lblCurrentTokenNumber2nd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSecondTurn";
            this.Text = "Second Turn";
            this.Load += new System.EventHandler(this.frmSecondTurn_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbLabTest.ResumeLayout(false);
            this.gbLabTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDays)).EndInit();
            this.gbxPerDayDose.ResumeLayout(false);
            this.gbxPerDayDose.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton tsReprintToken;
        private System.Windows.Forms.ToolStripButton tsSyring;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chxSyringe;
        private System.Windows.Forms.ComboBox cbxRs10;
        private System.Windows.Forms.TextBox txtExistingToken;
        private System.Windows.Forms.Button btnExistingToken;
        private System.Windows.Forms.GroupBox gbLabTest;
        private System.Windows.Forms.NumericUpDown txtDays;
        private System.Windows.Forms.GroupBox gbxPerDayDose;
        private System.Windows.Forms.RadioButton rbThreeDay;
        private System.Windows.Forms.RadioButton rbTwoDay;
        private System.Windows.Forms.RadioButton rbOneDay;
        private System.Windows.Forms.Button btnAddLabTest;
        private System.Windows.Forms.ComboBox cbxLabTest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstLabTest;
        private System.Windows.Forms.RadioButton rbGeneral2nd;
        private System.Windows.Forms.RadioButton rbYCOD;
        private System.Windows.Forms.RadioButton rbPoor;
        private System.Windows.Forms.RadioButton rbDeserving;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblRS10;
        private System.Windows.Forms.Label lblTokenDate2nd;
        private System.Windows.Forms.Label lblTokenNumber2nd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLabTest;
        private System.Windows.Forms.RadioButton rbInjection;
        private System.Windows.Forms.DateTimePicker dtpPatientRegistration2nd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatientCNIC2nd;
        private System.Windows.Forms.TextBox txtPateintRegistrationNumber2nd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPatientAddress2nd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPatientLastName2nd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPatientFirstName2nd;
        private System.Windows.Forms.Label lblCurrentTokenNumber2nd;
        private System.Windows.Forms.TextBox txtSecondLabTotal;
        private System.Windows.Forms.TextBox txtSecondFreeTotal;
        private System.Windows.Forms.TextBox txtSecondInjTotal;
        private System.Windows.Forms.TextBox txtSecondPaidTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCashRecieved2nd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCashRecievedByUser;
        private System.Windows.Forms.TextBox txtPatientMobile2nd;
        private System.Windows.Forms.Label lblPatientMobile;
        private System.Windows.Forms.TextBox txtPatientAge2nd;
        private System.Windows.Forms.Label lblPatientAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRooms;
    }
}