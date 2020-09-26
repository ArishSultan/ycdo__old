namespace FDM
{
    partial class frmPatientRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientRegistration));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsReprintToken = new System.Windows.Forms.ToolStripButton();
            this.tsSyring = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNewPatient = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTokenDate = new System.Windows.Forms.Label();
            this.lblTokenNumber = new System.Windows.Forms.Label();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.lblPatientRegistrationNumber = new System.Windows.Forms.Label();
            this.gbTokenType = new System.Windows.Forms.GroupBox();
            this.rbPoor = new System.Windows.Forms.RadioButton();
            this.rbPrivate = new System.Windows.Forms.RadioButton();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.dtpPatientRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.lblPatientRegistrationDate = new System.Windows.Forms.Label();
            this.txtPatientCNIC = new System.Windows.Forms.TextBox();
            this.txtPateintRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblPatientCNIC = new System.Windows.Forms.Label();
            this.lblPatientFirstName = new System.Windows.Forms.Label();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.lblPatientAddress = new System.Windows.Forms.Label();
            this.txtPatientLastName = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblPatientLastName = new System.Windows.Forms.Label();
            this.lblCashRecieved = new System.Windows.Forms.Label();
            this.txtCashRecieved = new System.Windows.Forms.TextBox();
            this.txtPatientFirstName = new System.Windows.Forms.TextBox();
            this.lblCurrentTokenNumber = new System.Windows.Forms.Label();
            this.txtPatientMobile = new System.Windows.Forms.TextBox();
            this.lblPatientMobile = new System.Windows.Forms.Label();
            this.txtPatientAge = new System.Windows.Forms.TextBox();
            this.lblPatientAge = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbTokenType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentInformation
            // 
            this.lblStudentInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentInformation.Size = new System.Drawing.Size(228, 21);
            this.lblStudentInformation.Text = "0000 -  -  - ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsNew,
            this.tsSave,
            this.tsReprintToken,
            this.tsSyring,
            this.toolStripSeparator1,
            this.tsbNewPatient,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(670, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsClose
            // 
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(60, 24);
            this.tsClose.Text = "&Close";
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click);
            // 
            // tsNew
            // 
            this.tsNew.Image = ((System.Drawing.Image)(resources.GetObject("tsNew.Image")));
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(55, 24);
            this.tsNew.Text = "&New";
            this.tsNew.Click += new System.EventHandler(this.tsNew_Click);
            // 
            // tsSave
            // 
            this.tsSave.Image = ((System.Drawing.Image)(resources.GetObject("tsSave.Image")));
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(55, 24);
            this.tsSave.Text = "&Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsReprintToken
            // 
            this.tsReprintToken.Image = ((System.Drawing.Image)(resources.GetObject("tsReprintToken.Image")));
            this.tsReprintToken.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReprintToken.Name = "tsReprintToken";
            this.tsReprintToken.Size = new System.Drawing.Size(116, 24);
            this.tsReprintToken.Text = "&Duplicate Token";
            this.tsReprintToken.Click += new System.EventHandler(this.tsReprintToken_Click);
            // 
            // tsSyring
            // 
            this.tsSyring.Image = ((System.Drawing.Image)(resources.GetObject("tsSyring.Image")));
            this.tsSyring.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSyring.Name = "tsSyring";
            this.tsSyring.Size = new System.Drawing.Size(64, 24);
            this.tsSyring.Text = "Syring";
            this.tsSyring.Click += new System.EventHandler(this.tsSyring_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbNewPatient
            // 
            this.tsbNewPatient.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewPatient.Image")));
            this.tsbNewPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewPatient.Name = "tsbNewPatient";
            this.tsbNewPatient.Size = new System.Drawing.Size(95, 24);
            this.tsbNewPatient.Text = "New Patient";
            this.tsbNewPatient.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FDM.Properties.Resources.hd_patient;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 85);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Members";
            this.label1.Visible = false;
            // 
            // lblTokenDate
            // 
            this.lblTokenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenDate.Location = new System.Drawing.Point(401, 220);
            this.lblTokenDate.Name = "lblTokenDate";
            this.lblTokenDate.Size = new System.Drawing.Size(165, 25);
            this.lblTokenDate.TabIndex = 40;
            this.lblTokenDate.Text = "Date";
            this.lblTokenDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTokenNumber
            // 
            this.lblTokenNumber.AutoSize = true;
            this.lblTokenNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenNumber.Location = new System.Drawing.Point(401, 118);
            this.lblTokenNumber.Name = "lblTokenNumber";
            this.lblTokenNumber.Size = new System.Drawing.Size(165, 25);
            this.lblTokenNumber.TabIndex = 39;
            this.lblTokenNumber.Text = "Token Number";
            // 
            // lstRooms
            // 
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.Location = new System.Drawing.Point(132, 306);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(300, 69);
            this.lstRooms.TabIndex = 10;
            // 
            // lblPatientRegistrationNumber
            // 
            this.lblPatientRegistrationNumber.AutoSize = true;
            this.lblPatientRegistrationNumber.Location = new System.Drawing.Point(14, 121);
            this.lblPatientRegistrationNumber.Name = "lblPatientRegistrationNumber";
            this.lblPatientRegistrationNumber.Size = new System.Drawing.Size(112, 13);
            this.lblPatientRegistrationNumber.TabIndex = 1;
            this.lblPatientRegistrationNumber.Text = "Patient Registration #:";
            // 
            // gbTokenType
            // 
            this.gbTokenType.Controls.Add(this.rbPoor);
            this.gbTokenType.Controls.Add(this.rbPrivate);
            this.gbTokenType.Controls.Add(this.rbGeneral);
            this.gbTokenType.Location = new System.Drawing.Point(17, 294);
            this.gbTokenType.Name = "gbTokenType";
            this.gbTokenType.Size = new System.Drawing.Size(109, 85);
            this.gbTokenType.TabIndex = 9;
            this.gbTokenType.TabStop = false;
            this.gbTokenType.Text = "Token Type";
            // 
            // rbPoor
            // 
            this.rbPoor.AutoSize = true;
            this.rbPoor.Location = new System.Drawing.Point(6, 15);
            this.rbPoor.Name = "rbPoor";
            this.rbPoor.Size = new System.Drawing.Size(47, 17);
            this.rbPoor.TabIndex = 2;
            this.rbPoor.Text = "Poor";
            this.rbPoor.UseVisualStyleBackColor = true;
            this.rbPoor.CheckedChanged += new System.EventHandler(this.rbPoor_CheckedChanged);
            // 
            // rbPrivate
            // 
            this.rbPrivate.AutoSize = true;
            this.rbPrivate.Location = new System.Drawing.Point(6, 61);
            this.rbPrivate.Name = "rbPrivate";
            this.rbPrivate.Size = new System.Drawing.Size(61, 17);
            this.rbPrivate.TabIndex = 1;
            this.rbPrivate.Text = "Private ";
            this.rbPrivate.UseVisualStyleBackColor = true;
            this.rbPrivate.CheckedChanged += new System.EventHandler(this.rbGeneral_CheckedChanged);
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Checked = true;
            this.rbGeneral.Location = new System.Drawing.Point(6, 38);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(65, 17);
            this.rbGeneral.TabIndex = 0;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "General ";
            this.rbGeneral.UseVisualStyleBackColor = true;
            this.rbGeneral.CheckedChanged += new System.EventHandler(this.rbGeneral_CheckedChanged_1);
            // 
            // dtpPatientRegistrationDate
            // 
            this.dtpPatientRegistrationDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPatientRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPatientRegistrationDate.Location = new System.Drawing.Point(144, 136);
            this.dtpPatientRegistrationDate.Name = "dtpPatientRegistrationDate";
            this.dtpPatientRegistrationDate.Size = new System.Drawing.Size(138, 20);
            this.dtpPatientRegistrationDate.TabIndex = 2;
            // 
            // lblPatientRegistrationDate
            // 
            this.lblPatientRegistrationDate.AutoSize = true;
            this.lblPatientRegistrationDate.Location = new System.Drawing.Point(144, 121);
            this.lblPatientRegistrationDate.Name = "lblPatientRegistrationDate";
            this.lblPatientRegistrationDate.Size = new System.Drawing.Size(128, 13);
            this.lblPatientRegistrationDate.TabIndex = 1;
            this.lblPatientRegistrationDate.Text = "Patient Registration Date:";
            // 
            // txtPatientCNIC
            // 
            this.txtPatientCNIC.Location = new System.Drawing.Point(17, 215);
            this.txtPatientCNIC.Name = "txtPatientCNIC";
            this.txtPatientCNIC.Size = new System.Drawing.Size(265, 20);
            this.txtPatientCNIC.TabIndex = 5;
            // 
            // txtPateintRegistrationNumber
            // 
            this.txtPateintRegistrationNumber.BackColor = System.Drawing.Color.White;
            this.txtPateintRegistrationNumber.Location = new System.Drawing.Point(17, 136);
            this.txtPateintRegistrationNumber.Name = "txtPateintRegistrationNumber";
            this.txtPateintRegistrationNumber.ReadOnly = true;
            this.txtPateintRegistrationNumber.Size = new System.Drawing.Size(121, 20);
            this.txtPateintRegistrationNumber.TabIndex = 1;
            // 
            // lblPatientCNIC
            // 
            this.lblPatientCNIC.AutoSize = true;
            this.lblPatientCNIC.Location = new System.Drawing.Point(14, 199);
            this.lblPatientCNIC.Name = "lblPatientCNIC";
            this.lblPatientCNIC.Size = new System.Drawing.Size(81, 13);
            this.lblPatientCNIC.TabIndex = 25;
            this.lblPatientCNIC.Text = "Patient CNIC #:";
            // 
            // lblPatientFirstName
            // 
            this.lblPatientFirstName.AutoSize = true;
            this.lblPatientFirstName.Location = new System.Drawing.Point(14, 159);
            this.lblPatientFirstName.Name = "lblPatientFirstName";
            this.lblPatientFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblPatientFirstName.TabIndex = 21;
            this.lblPatientFirstName.Text = "First Name:";
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.Location = new System.Drawing.Point(17, 257);
            this.txtPatientAddress.Multiline = true;
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(265, 36);
            this.txtPatientAddress.TabIndex = 7;
            // 
            // lblPatientAddress
            // 
            this.lblPatientAddress.AutoSize = true;
            this.lblPatientAddress.Location = new System.Drawing.Point(14, 242);
            this.lblPatientAddress.Name = "lblPatientAddress";
            this.lblPatientAddress.Size = new System.Drawing.Size(84, 13);
            this.lblPatientAddress.TabIndex = 31;
            this.lblPatientAddress.Text = "Patient Address:";
            // 
            // txtPatientLastName
            // 
            this.txtPatientLastName.Location = new System.Drawing.Point(144, 175);
            this.txtPatientLastName.Name = "txtPatientLastName";
            this.txtPatientLastName.Size = new System.Drawing.Size(138, 20);
            this.txtPatientLastName.TabIndex = 4;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(129, 293);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(74, 13);
            this.lblRoom.TabIndex = 29;
            this.lblRoom.Text = "Select Room :";
            // 
            // lblPatientLastName
            // 
            this.lblPatientLastName.AutoSize = true;
            this.lblPatientLastName.Location = new System.Drawing.Point(151, 159);
            this.lblPatientLastName.Name = "lblPatientLastName";
            this.lblPatientLastName.Size = new System.Drawing.Size(61, 13);
            this.lblPatientLastName.TabIndex = 23;
            this.lblPatientLastName.Text = "Last Name:";
            // 
            // lblCashRecieved
            // 
            this.lblCashRecieved.AutoSize = true;
            this.lblCashRecieved.Location = new System.Drawing.Point(531, 331);
            this.lblCashRecieved.Name = "lblCashRecieved";
            this.lblCashRecieved.Size = new System.Drawing.Size(83, 13);
            this.lblCashRecieved.TabIndex = 32;
            this.lblCashRecieved.Text = "Cash Received:";
            // 
            // txtCashRecieved
            // 
            this.txtCashRecieved.BackColor = System.Drawing.Color.White;
            this.txtCashRecieved.Location = new System.Drawing.Point(532, 345);
            this.txtCashRecieved.Name = "txtCashRecieved";
            this.txtCashRecieved.ReadOnly = true;
            this.txtCashRecieved.Size = new System.Drawing.Size(103, 20);
            this.txtCashRecieved.TabIndex = 11;
            // 
            // txtPatientFirstName
            // 
            this.txtPatientFirstName.Location = new System.Drawing.Point(17, 175);
            this.txtPatientFirstName.Name = "txtPatientFirstName";
            this.txtPatientFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtPatientFirstName.TabIndex = 3;
            // 
            // lblCurrentTokenNumber
            // 
            this.lblCurrentTokenNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTokenNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentTokenNumber.Location = new System.Drawing.Point(320, 127);
            this.lblCurrentTokenNumber.Name = "lblCurrentTokenNumber";
            this.lblCurrentTokenNumber.Size = new System.Drawing.Size(330, 108);
            this.lblCurrentTokenNumber.TabIndex = 38;
            this.lblCurrentTokenNumber.Text = "10000";
            this.lblCurrentTokenNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPatientMobile
            // 
            this.txtPatientMobile.Location = new System.Drawing.Point(288, 273);
            this.txtPatientMobile.Name = "txtPatientMobile";
            this.txtPatientMobile.Size = new System.Drawing.Size(144, 20);
            this.txtPatientMobile.TabIndex = 8;
            // 
            // lblPatientMobile
            // 
            this.lblPatientMobile.AutoSize = true;
            this.lblPatientMobile.Location = new System.Drawing.Point(285, 257);
            this.lblPatientMobile.Name = "lblPatientMobile";
            this.lblPatientMobile.Size = new System.Drawing.Size(87, 13);
            this.lblPatientMobile.TabIndex = 42;
            this.lblPatientMobile.Text = "Patient Mobile #:";
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.Location = new System.Drawing.Point(288, 215);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Size = new System.Drawing.Size(71, 20);
            this.txtPatientAge.TabIndex = 6;
            this.txtPatientAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPatientAge
            // 
            this.lblPatientAge.AutoSize = true;
            this.lblPatientAge.Location = new System.Drawing.Point(285, 199);
            this.lblPatientAge.Name = "lblPatientAge";
            this.lblPatientAge.Size = new System.Drawing.Size(65, 13);
            this.lblPatientAge.TabIndex = 13;
            this.lblPatientAge.Text = "Patient Age:";
            // 
            // frmPatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 557);
            this.Controls.Add(this.txtPatientAge);
            this.Controls.Add(this.lblPatientAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTokenDate);
            this.Controls.Add(this.lblTokenNumber);
            this.Controls.Add(this.lstRooms);
            this.Controls.Add(this.lblPatientRegistrationNumber);
            this.Controls.Add(this.gbTokenType);
            this.Controls.Add(this.dtpPatientRegistrationDate);
            this.Controls.Add(this.lblPatientRegistrationDate);
            this.Controls.Add(this.txtPatientCNIC);
            this.Controls.Add(this.txtPateintRegistrationNumber);
            this.Controls.Add(this.lblPatientCNIC);
            this.Controls.Add(this.lblPatientFirstName);
            this.Controls.Add(this.txtPatientAddress);
            this.Controls.Add(this.lblPatientAddress);
            this.Controls.Add(this.txtPatientLastName);
            this.Controls.Add(this.txtPatientMobile);
            this.Controls.Add(this.lblPatientMobile);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblPatientLastName);
            this.Controls.Add(this.lblCashRecieved);
            this.Controls.Add(this.txtCashRecieved);
            this.Controls.Add(this.txtPatientFirstName);
            this.Controls.Add(this.lblCurrentTokenNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(303, 249);
            this.Name = "frmPatientRegistration";
            this.Text = "";
            this.Load += new System.EventHandler(this.frmPatientRegistration_Load);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.lblCurrentTokenNumber, 0);
            this.Controls.SetChildIndex(this.txtPatientFirstName, 0);
            this.Controls.SetChildIndex(this.txtCashRecieved, 0);
            this.Controls.SetChildIndex(this.lblCashRecieved, 0);
            this.Controls.SetChildIndex(this.lblPatientLastName, 0);
            this.Controls.SetChildIndex(this.lblRoom, 0);
            this.Controls.SetChildIndex(this.lblPatientMobile, 0);
            this.Controls.SetChildIndex(this.txtPatientMobile, 0);
            this.Controls.SetChildIndex(this.txtPatientLastName, 0);
            this.Controls.SetChildIndex(this.lblPatientAddress, 0);
            this.Controls.SetChildIndex(this.txtPatientAddress, 0);
            this.Controls.SetChildIndex(this.lblPatientFirstName, 0);
            this.Controls.SetChildIndex(this.lblPatientCNIC, 0);
            this.Controls.SetChildIndex(this.txtPateintRegistrationNumber, 0);
            this.Controls.SetChildIndex(this.txtPatientCNIC, 0);
            this.Controls.SetChildIndex(this.lblPatientRegistrationDate, 0);
            this.Controls.SetChildIndex(this.dtpPatientRegistrationDate, 0);
            this.Controls.SetChildIndex(this.gbTokenType, 0);
            this.Controls.SetChildIndex(this.lblPatientRegistrationNumber, 0);
            this.Controls.SetChildIndex(this.lstRooms, 0);
            this.Controls.SetChildIndex(this.lblTokenNumber, 0);
            this.Controls.SetChildIndex(this.lblTokenDate, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblPatientAge, 0);
            this.Controls.SetChildIndex(this.txtPatientAge, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbTokenType.ResumeLayout(false);
            this.gbTokenType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton tsReprintToken;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton tsSyring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTokenDate;
        private System.Windows.Forms.Label lblTokenNumber;
        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.Label lblPatientRegistrationNumber;
        private System.Windows.Forms.GroupBox gbTokenType;
        private System.Windows.Forms.RadioButton rbPrivate;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.DateTimePicker dtpPatientRegistrationDate;
        private System.Windows.Forms.Label lblPatientRegistrationDate;
        private System.Windows.Forms.TextBox txtPatientCNIC;
        private System.Windows.Forms.TextBox txtPateintRegistrationNumber;
        private System.Windows.Forms.Label lblPatientCNIC;
        private System.Windows.Forms.Label lblPatientFirstName;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.Label lblPatientAddress;
        private System.Windows.Forms.TextBox txtPatientLastName;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblPatientLastName;
        private System.Windows.Forms.Label lblCashRecieved;
        private System.Windows.Forms.TextBox txtCashRecieved;
        private System.Windows.Forms.TextBox txtPatientFirstName;
        private System.Windows.Forms.Label lblCurrentTokenNumber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNewPatient;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox txtPatientMobile;
        private System.Windows.Forms.Label lblPatientMobile;
        private System.Windows.Forms.RadioButton rbPoor;
        private System.Windows.Forms.TextBox txtPatientAge;
        private System.Windows.Forms.Label lblPatientAge;
    }
}