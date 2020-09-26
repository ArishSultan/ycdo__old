namespace FDM
{
    partial class frmThirdTurn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThirdTurn));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsReprintToken = new System.Windows.Forms.ToolStripButton();
            this.tsSyring = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chxSyringThird = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtThirdPaidLabTest = new System.Windows.Forms.TextBox();
            this.lbxLabTest = new System.Windows.Forms.ListBox();
            this.lblThirdCashReceived = new System.Windows.Forms.Label();
            this.cbxmembers = new System.Windows.Forms.ComboBox();
            this.txtThirdInjectionTotal = new System.Windows.Forms.TextBox();
            this.txtThirdFreeTotal = new System.Windows.Forms.TextBox();
            this.txtThirdPaidTotal = new System.Windows.Forms.TextBox();
            this.txtThirdCashReceived = new System.Windows.Forms.TextBox();
            this.rbThirdGeneral = new System.Windows.Forms.RadioButton();
            this.rbThirdYCDO = new System.Windows.Forms.RadioButton();
            this.rbThirdPoor = new System.Windows.Forms.RadioButton();
            this.lblThirdTokenDate = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpThirdPatientRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThirdCNIC = new System.Windows.Forms.TextBox();
            this.txtThirdPatientRegistrationNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtThirdAddress = new System.Windows.Forms.TextBox();
            this.lblThirdAlwaysPaid = new System.Windows.Forms.Label();
            this.lblThirdInjections = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtThirdLastName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtThirdFirstName = new System.Windows.Forms.TextBox();
            this.lbxPaidMedicine = new System.Windows.Forms.ListBox();
            this.lbxFreeMedicine = new System.Windows.Forms.ListBox();
            this.lbxInjection = new System.Windows.Forms.ListBox();
            this.txtThirdExistingToken = new System.Windows.Forms.TextBox();
            this.btnThirdExistingToken = new System.Windows.Forms.Button();
            this.lblThirdMainToken = new System.Windows.Forms.Label();
            this.lblThirdFree = new System.Windows.Forms.Label();
            this.cmdLabtestCancel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmLabtestCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdPaidCancel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmPaidCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdInjectionCancel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmInjectionCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmdLabtestCancel.SuspendLayout();
            this.cmdPaidCancel.SuspendLayout();
            this.cmdInjectionCancel.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(724, 25);
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
            this.tsReprintToken.Size = new System.Drawing.Size(113, 22);
            this.tsReprintToken.Text = "&Duplicate Token";
            this.tsReprintToken.Visible = false;
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
            this.pictureBox1.Size = new System.Drawing.Size(724, 85);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // chxSyringThird
            // 
            this.chxSyringThird.AutoSize = true;
            this.chxSyringThird.Location = new System.Drawing.Point(283, 192);
            this.chxSyringThird.Name = "chxSyringThird";
            this.chxSyringThird.Size = new System.Drawing.Size(77, 17);
            this.chxSyringThird.TabIndex = 104;
            this.chxSyringThird.Text = "Add Syring";
            this.chxSyringThird.UseVisualStyleBackColor = true;
            this.chxSyringThird.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(212, 328);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 103;
            this.label18.Text = "LabTest";
            // 
            // txtThirdPaidLabTest
            // 
            this.txtThirdPaidLabTest.BackColor = System.Drawing.Color.White;
            this.txtThirdPaidLabTest.Location = new System.Drawing.Point(212, 438);
            this.txtThirdPaidLabTest.Name = "txtThirdPaidLabTest";
            this.txtThirdPaidLabTest.ReadOnly = true;
            this.txtThirdPaidLabTest.Size = new System.Drawing.Size(193, 20);
            this.txtThirdPaidLabTest.TabIndex = 102;
            // 
            // lbxLabTest
            // 
            this.lbxLabTest.FormattingEnabled = true;
            this.lbxLabTest.Location = new System.Drawing.Point(212, 341);
            this.lbxLabTest.Name = "lbxLabTest";
            this.lbxLabTest.Size = new System.Drawing.Size(193, 95);
            this.lbxLabTest.TabIndex = 101;
            // 
            // lblThirdCashReceived
            // 
            this.lblThirdCashReceived.AutoSize = true;
            this.lblThirdCashReceived.Location = new System.Drawing.Point(607, 422);
            this.lblThirdCashReceived.Name = "lblThirdCashReceived";
            this.lblThirdCashReceived.Size = new System.Drawing.Size(83, 13);
            this.lblThirdCashReceived.TabIndex = 96;
            this.lblThirdCashReceived.Text = "Cash Received:";
            // 
            // cbxmembers
            // 
            this.cbxmembers.FormattingEnabled = true;
            this.cbxmembers.Location = new System.Drawing.Point(9, 461);
            this.cbxmembers.Name = "cbxmembers";
            this.cbxmembers.Size = new System.Drawing.Size(125, 21);
            this.cbxmembers.TabIndex = 69;
            this.cbxmembers.Visible = false;
            // 
            // txtThirdInjectionTotal
            // 
            this.txtThirdInjectionTotal.BackColor = System.Drawing.Color.White;
            this.txtThirdInjectionTotal.Location = new System.Drawing.Point(411, 438);
            this.txtThirdInjectionTotal.Name = "txtThirdInjectionTotal";
            this.txtThirdInjectionTotal.ReadOnly = true;
            this.txtThirdInjectionTotal.Size = new System.Drawing.Size(193, 20);
            this.txtThirdInjectionTotal.TabIndex = 97;
            // 
            // txtThirdFreeTotal
            // 
            this.txtThirdFreeTotal.BackColor = System.Drawing.Color.White;
            this.txtThirdFreeTotal.Location = new System.Drawing.Point(278, 310);
            this.txtThirdFreeTotal.Name = "txtThirdFreeTotal";
            this.txtThirdFreeTotal.ReadOnly = true;
            this.txtThirdFreeTotal.Size = new System.Drawing.Size(193, 20);
            this.txtThirdFreeTotal.TabIndex = 100;
            // 
            // txtThirdPaidTotal
            // 
            this.txtThirdPaidTotal.BackColor = System.Drawing.Color.White;
            this.txtThirdPaidTotal.Location = new System.Drawing.Point(9, 438);
            this.txtThirdPaidTotal.Name = "txtThirdPaidTotal";
            this.txtThirdPaidTotal.ReadOnly = true;
            this.txtThirdPaidTotal.Size = new System.Drawing.Size(193, 20);
            this.txtThirdPaidTotal.TabIndex = 99;
            // 
            // txtThirdCashReceived
            // 
            this.txtThirdCashReceived.BackColor = System.Drawing.Color.White;
            this.txtThirdCashReceived.Location = new System.Drawing.Point(610, 438);
            this.txtThirdCashReceived.Name = "txtThirdCashReceived";
            this.txtThirdCashReceived.ReadOnly = true;
            this.txtThirdCashReceived.Size = new System.Drawing.Size(107, 20);
            this.txtThirdCashReceived.TabIndex = 98;
            // 
            // rbThirdGeneral
            // 
            this.rbThirdGeneral.AutoSize = true;
            this.rbThirdGeneral.Checked = true;
            this.rbThirdGeneral.Location = new System.Drawing.Point(610, 377);
            this.rbThirdGeneral.Name = "rbThirdGeneral";
            this.rbThirdGeneral.Size = new System.Drawing.Size(62, 17);
            this.rbThirdGeneral.TabIndex = 95;
            this.rbThirdGeneral.TabStop = true;
            this.rbThirdGeneral.Text = "General";
            this.rbThirdGeneral.UseVisualStyleBackColor = true;
            this.rbThirdGeneral.CheckedChanged += new System.EventHandler(this.PatientPayType3rd_Changed);
            // 
            // rbThirdYCDO
            // 
            this.rbThirdYCDO.AutoSize = true;
            this.rbThirdYCDO.Location = new System.Drawing.Point(610, 359);
            this.rbThirdYCDO.Name = "rbThirdYCDO";
            this.rbThirdYCDO.Size = new System.Drawing.Size(96, 17);
            this.rbThirdYCDO.TabIndex = 93;
            this.rbThirdYCDO.Text = "YCDO Member";
            this.rbThirdYCDO.UseVisualStyleBackColor = true;
            this.rbThirdYCDO.CheckedChanged += new System.EventHandler(this.PatientPayType3rd_Changed);
            // 
            // rbThirdPoor
            // 
            this.rbThirdPoor.AutoSize = true;
            this.rbThirdPoor.Location = new System.Drawing.Point(610, 341);
            this.rbThirdPoor.Name = "rbThirdPoor";
            this.rbThirdPoor.Size = new System.Drawing.Size(47, 17);
            this.rbThirdPoor.TabIndex = 94;
            this.rbThirdPoor.Text = "Poor";
            this.rbThirdPoor.UseVisualStyleBackColor = true;
            this.rbThirdPoor.CheckedChanged += new System.EventHandler(this.PatientPayType3rd_Changed);
            // 
            // lblThirdTokenDate
            // 
            this.lblThirdTokenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdTokenDate.Location = new System.Drawing.Point(527, 226);
            this.lblThirdTokenDate.Name = "lblThirdTokenDate";
            this.lblThirdTokenDate.Size = new System.Drawing.Size(165, 25);
            this.lblThirdTokenDate.TabIndex = 90;
            this.lblThirdTokenDate.Text = "Date";
            this.lblThirdTokenDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(524, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(165, 25);
            this.label17.TabIndex = 91;
            this.label17.Text = "Token Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Patient Registration #:";
            // 
            // dtpThirdPatientRegistrationDate
            // 
            this.dtpThirdPatientRegistrationDate.CustomFormat = "dd/MM/yyyy";
            this.dtpThirdPatientRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThirdPatientRegistrationDate.Location = new System.Drawing.Point(142, 169);
            this.dtpThirdPatientRegistrationDate.Name = "dtpThirdPatientRegistrationDate";
            this.dtpThirdPatientRegistrationDate.Size = new System.Drawing.Size(138, 20);
            this.dtpThirdPatientRegistrationDate.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Patient Registration Date:";
            // 
            // txtThirdCNIC
            // 
            this.txtThirdCNIC.Location = new System.Drawing.Point(12, 247);
            this.txtThirdCNIC.Name = "txtThirdCNIC";
            this.txtThirdCNIC.Size = new System.Drawing.Size(265, 20);
            this.txtThirdCNIC.TabIndex = 84;
            // 
            // txtThirdPatientRegistrationNumber
            // 
            this.txtThirdPatientRegistrationNumber.BackColor = System.Drawing.Color.White;
            this.txtThirdPatientRegistrationNumber.Location = new System.Drawing.Point(12, 169);
            this.txtThirdPatientRegistrationNumber.Name = "txtThirdPatientRegistrationNumber";
            this.txtThirdPatientRegistrationNumber.ReadOnly = true;
            this.txtThirdPatientRegistrationNumber.Size = new System.Drawing.Size(121, 20);
            this.txtThirdPatientRegistrationNumber.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "Patient CNIC #:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 79;
            this.label13.Text = "First Name:";
            // 
            // txtThirdAddress
            // 
            this.txtThirdAddress.Location = new System.Drawing.Point(7, 285);
            this.txtThirdAddress.Multiline = true;
            this.txtThirdAddress.Name = "txtThirdAddress";
            this.txtThirdAddress.Size = new System.Drawing.Size(265, 40);
            this.txtThirdAddress.TabIndex = 89;
            // 
            // lblThirdAlwaysPaid
            // 
            this.lblThirdAlwaysPaid.AutoSize = true;
            this.lblThirdAlwaysPaid.Location = new System.Drawing.Point(6, 328);
            this.lblThirdAlwaysPaid.Name = "lblThirdAlwaysPaid";
            this.lblThirdAlwaysPaid.Size = new System.Drawing.Size(64, 13);
            this.lblThirdAlwaysPaid.TabIndex = 85;
            this.lblThirdAlwaysPaid.Text = "Always Paid";
            // 
            // lblThirdInjections
            // 
            this.lblThirdInjections.AutoSize = true;
            this.lblThirdInjections.Location = new System.Drawing.Point(408, 328);
            this.lblThirdInjections.Name = "lblThirdInjections";
            this.lblThirdInjections.Size = new System.Drawing.Size(41, 13);
            this.lblThirdInjections.TabIndex = 86;
            this.lblThirdInjections.Text = "Rs. 10 ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 87;
            this.label14.Text = "Patient Address:";
            // 
            // txtThirdLastName
            // 
            this.txtThirdLastName.Location = new System.Drawing.Point(139, 208);
            this.txtThirdLastName.Name = "txtThirdLastName";
            this.txtThirdLastName.Size = new System.Drawing.Size(138, 20);
            this.txtThirdLastName.TabIndex = 82;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(142, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 81;
            this.label15.Text = "Last Name:";
            // 
            // txtThirdFirstName
            // 
            this.txtThirdFirstName.Location = new System.Drawing.Point(12, 208);
            this.txtThirdFirstName.Name = "txtThirdFirstName";
            this.txtThirdFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtThirdFirstName.TabIndex = 80;
            // 
            // lbxPaidMedicine
            // 
            this.lbxPaidMedicine.FormattingEnabled = true;
            this.lbxPaidMedicine.Location = new System.Drawing.Point(9, 341);
            this.lbxPaidMedicine.Name = "lbxPaidMedicine";
            this.lbxPaidMedicine.Size = new System.Drawing.Size(193, 95);
            this.lbxPaidMedicine.TabIndex = 73;
            // 
            // lbxFreeMedicine
            // 
            this.lbxFreeMedicine.FormattingEnabled = true;
            this.lbxFreeMedicine.Location = new System.Drawing.Point(278, 226);
            this.lbxFreeMedicine.Name = "lbxFreeMedicine";
            this.lbxFreeMedicine.Size = new System.Drawing.Size(193, 82);
            this.lbxFreeMedicine.TabIndex = 72;
            // 
            // lbxInjection
            // 
            this.lbxInjection.FormattingEnabled = true;
            this.lbxInjection.Location = new System.Drawing.Point(411, 341);
            this.lbxInjection.Name = "lbxInjection";
            this.lbxInjection.Size = new System.Drawing.Size(193, 95);
            this.lbxInjection.TabIndex = 74;
            // 
            // txtThirdExistingToken
            // 
            this.txtThirdExistingToken.BackColor = System.Drawing.Color.Gainsboro;
            this.txtThirdExistingToken.Location = new System.Drawing.Point(136, 128);
            this.txtThirdExistingToken.Name = "txtThirdExistingToken";
            this.txtThirdExistingToken.ReadOnly = true;
            this.txtThirdExistingToken.Size = new System.Drawing.Size(121, 20);
            this.txtThirdExistingToken.TabIndex = 71;
            this.txtThirdExistingToken.Visible = false;
            // 
            // btnThirdExistingToken
            // 
            this.btnThirdExistingToken.Location = new System.Drawing.Point(12, 125);
            this.btnThirdExistingToken.Name = "btnThirdExistingToken";
            this.btnThirdExistingToken.Size = new System.Drawing.Size(109, 23);
            this.btnThirdExistingToken.TabIndex = 70;
            this.btnThirdExistingToken.Text = "Enter Token ";
            this.btnThirdExistingToken.UseVisualStyleBackColor = true;
            this.btnThirdExistingToken.Click += new System.EventHandler(this.btnThirdExistingToken_Click);
            // 
            // lblThirdMainToken
            // 
            this.lblThirdMainToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdMainToken.ForeColor = System.Drawing.Color.Navy;
            this.lblThirdMainToken.Location = new System.Drawing.Point(411, 118);
            this.lblThirdMainToken.Name = "lblThirdMainToken";
            this.lblThirdMainToken.Size = new System.Drawing.Size(350, 97);
            this.lblThirdMainToken.TabIndex = 92;
            this.lblThirdMainToken.Text = "-100";
            this.lblThirdMainToken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThirdFree
            // 
            this.lblThirdFree.AutoSize = true;
            this.lblThirdFree.Location = new System.Drawing.Point(280, 212);
            this.lblThirdFree.Name = "lblThirdFree";
            this.lblThirdFree.Size = new System.Drawing.Size(74, 13);
            this.lblThirdFree.TabIndex = 88;
            this.lblThirdFree.Text = "Free Medicine";
            // 
            // cmdLabtestCancel
            // 
            this.cmdLabtestCancel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLabtestCancel});
            this.cmdLabtestCancel.Name = "cmsCancel";
            this.cmdLabtestCancel.Size = new System.Drawing.Size(111, 26);
            // 
            // tsmLabtestCancel
            // 
            this.tsmLabtestCancel.Name = "tsmLabtestCancel";
            this.tsmLabtestCancel.Size = new System.Drawing.Size(110, 22);
            this.tsmLabtestCancel.Text = "Cancel";
            this.tsmLabtestCancel.Click += new System.EventHandler(this.tsmLabtestCancel_Click);
            // 
            // cmdPaidCancel
            // 
            this.cmdPaidCancel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPaidCancel});
            this.cmdPaidCancel.Name = "cmsCancel";
            this.cmdPaidCancel.Size = new System.Drawing.Size(111, 26);
            // 
            // tsmPaidCancel
            // 
            this.tsmPaidCancel.Name = "tsmPaidCancel";
            this.tsmPaidCancel.Size = new System.Drawing.Size(110, 22);
            this.tsmPaidCancel.Text = "Cancel";
            this.tsmPaidCancel.Click += new System.EventHandler(this.tsmPaidCancel_Click);
            // 
            // cmdInjectionCancel
            // 
            this.cmdInjectionCancel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmInjectionCancel});
            this.cmdInjectionCancel.Name = "cmdInjectionCancel";
            this.cmdInjectionCancel.Size = new System.Drawing.Size(111, 26);
            // 
            // tsmInjectionCancel
            // 
            this.tsmInjectionCancel.Name = "tsmInjectionCancel";
            this.tsmInjectionCancel.Size = new System.Drawing.Size(110, 22);
            this.tsmInjectionCancel.Text = "Cancel";
            this.tsmInjectionCancel.Click += new System.EventHandler(this.tsmInjectionCancel_Click);
            // 
            // frmThirdTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 489);
            this.Controls.Add(this.chxSyringThird);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtThirdPaidLabTest);
            this.Controls.Add(this.lbxLabTest);
            this.Controls.Add(this.lblThirdCashReceived);
            this.Controls.Add(this.cbxmembers);
            this.Controls.Add(this.txtThirdInjectionTotal);
            this.Controls.Add(this.txtThirdFreeTotal);
            this.Controls.Add(this.txtThirdPaidTotal);
            this.Controls.Add(this.txtThirdCashReceived);
            this.Controls.Add(this.rbThirdGeneral);
            this.Controls.Add(this.rbThirdYCDO);
            this.Controls.Add(this.rbThirdPoor);
            this.Controls.Add(this.lblThirdTokenDate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpThirdPatientRegistrationDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtThirdCNIC);
            this.Controls.Add(this.txtThirdPatientRegistrationNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtThirdAddress);
            this.Controls.Add(this.lblThirdAlwaysPaid);
            this.Controls.Add(this.lblThirdInjections);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtThirdLastName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtThirdFirstName);
            this.Controls.Add(this.lbxPaidMedicine);
            this.Controls.Add(this.lbxFreeMedicine);
            this.Controls.Add(this.lbxInjection);
            this.Controls.Add(this.txtThirdExistingToken);
            this.Controls.Add(this.btnThirdExistingToken);
            this.Controls.Add(this.lblThirdMainToken);
            this.Controls.Add(this.lblThirdFree);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmThirdTurn";
            this.Text = "Third Turn";
            this.Load += new System.EventHandler(this.frmThirdTurn_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmdLabtestCancel.ResumeLayout(false);
            this.cmdPaidCancel.ResumeLayout(false);
            this.cmdInjectionCancel.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox chxSyringThird;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtThirdPaidLabTest;
        private System.Windows.Forms.ListBox lbxLabTest;
        private System.Windows.Forms.Label lblThirdCashReceived;
        private System.Windows.Forms.ComboBox cbxmembers;
        private System.Windows.Forms.TextBox txtThirdInjectionTotal;
        private System.Windows.Forms.TextBox txtThirdFreeTotal;
        private System.Windows.Forms.TextBox txtThirdPaidTotal;
        private System.Windows.Forms.TextBox txtThirdCashReceived;
        private System.Windows.Forms.RadioButton rbThirdGeneral;
        private System.Windows.Forms.RadioButton rbThirdYCDO;
        private System.Windows.Forms.RadioButton rbThirdPoor;
        private System.Windows.Forms.Label lblThirdTokenDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpThirdPatientRegistrationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThirdCNIC;
        private System.Windows.Forms.TextBox txtThirdPatientRegistrationNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtThirdAddress;
        private System.Windows.Forms.Label lblThirdAlwaysPaid;
        private System.Windows.Forms.Label lblThirdInjections;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtThirdLastName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtThirdFirstName;
        private System.Windows.Forms.ListBox lbxPaidMedicine;
        private System.Windows.Forms.ListBox lbxFreeMedicine;
        private System.Windows.Forms.ListBox lbxInjection;
        private System.Windows.Forms.TextBox txtThirdExistingToken;
        private System.Windows.Forms.Button btnThirdExistingToken;
        private System.Windows.Forms.Label lblThirdMainToken;
        private System.Windows.Forms.Label lblThirdFree;
        private System.Windows.Forms.ContextMenuStrip cmdLabtestCancel;
        private System.Windows.Forms.ToolStripMenuItem tsmLabtestCancel;
        private System.Windows.Forms.ContextMenuStrip cmdPaidCancel;
        private System.Windows.Forms.ToolStripMenuItem tsmPaidCancel;
        private System.Windows.Forms.ContextMenuStrip cmdInjectionCancel;
        private System.Windows.Forms.ToolStripMenuItem tsmInjectionCancel;
    }
}