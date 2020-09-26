namespace FDM
{
    partial class frmFourthTurn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFourthTurn));
            this.lblThirdCashReceived = new System.Windows.Forms.Label();
            this.cbxmembers = new System.Windows.Forms.ComboBox();
            this.txtThirdPaidTotal = new System.Windows.Forms.TextBox();
            this.txtThirdCashReceived = new System.Windows.Forms.TextBox();
            this.rbThirdGeneral = new System.Windows.Forms.RadioButton();
            this.rbThirdYCDO = new System.Windows.Forms.RadioButton();
            this.rbThirdPoor = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpThirdPatientRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThirdCNIC = new System.Windows.Forms.TextBox();
            this.txtThirdPatientRegistrationNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtThirdAddress = new System.Windows.Forms.TextBox();
            this.lblThirdAlwaysPaid = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtThirdLastName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtThirdFirstName = new System.Windows.Forms.TextBox();
            this.lbxPaidMedicine = new System.Windows.Forms.ListBox();
            this.cmdPaidCancel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmPaidCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.txtThirdExistingToken = new System.Windows.Forms.TextBox();
            this.btnThirdExistingToken = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsReprintToken = new System.Windows.Forms.ToolStripButton();
            this.txtDays = new System.Windows.Forms.NumericUpDown();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblCurrentTokenNumber2nd = new System.Windows.Forms.Label();
            this.lblTokenDate2nd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCashRecievedByUser = new System.Windows.Forms.TextBox();
            this.txtThirdAge = new System.Windows.Forms.TextBox();
            this.lblPatientAge = new System.Windows.Forms.Label();
            this.txtThirdMobile = new System.Windows.Forms.TextBox();
            this.lblPatientMobile = new System.Windows.Forms.Label();
            this.txtThirdRoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdPaidCancel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDays)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThirdCashReceived
            // 
            this.lblThirdCashReceived.AutoSize = true;
            this.lblThirdCashReceived.Location = new System.Drawing.Point(511, 333);
            this.lblThirdCashReceived.Name = "lblThirdCashReceived";
            this.lblThirdCashReceived.Size = new System.Drawing.Size(61, 13);
            this.lblThirdCashReceived.TabIndex = 132;
            this.lblThirdCashReceived.Text = "Total Cash:";
            // 
            // cbxmembers
            // 
            this.cbxmembers.FormattingEnabled = true;
            this.cbxmembers.Location = new System.Drawing.Point(7, 387);
            this.cbxmembers.Name = "cbxmembers";
            this.cbxmembers.Size = new System.Drawing.Size(125, 21);
            this.cbxmembers.TabIndex = 11;
            this.cbxmembers.Visible = false;
            // 
            // txtThirdPaidTotal
            // 
            this.txtThirdPaidTotal.BackColor = System.Drawing.Color.White;
            this.txtThirdPaidTotal.Location = new System.Drawing.Point(7, 364);
            this.txtThirdPaidTotal.Name = "txtThirdPaidTotal";
            this.txtThirdPaidTotal.ReadOnly = true;
            this.txtThirdPaidTotal.Size = new System.Drawing.Size(193, 20);
            this.txtThirdPaidTotal.TabIndex = 10;
            // 
            // txtThirdCashReceived
            // 
            this.txtThirdCashReceived.BackColor = System.Drawing.Color.White;
            this.txtThirdCashReceived.Location = new System.Drawing.Point(514, 349);
            this.txtThirdCashReceived.Name = "txtThirdCashReceived";
            this.txtThirdCashReceived.ReadOnly = true;
            this.txtThirdCashReceived.Size = new System.Drawing.Size(107, 20);
            this.txtThirdCashReceived.TabIndex = 16;
            // 
            // rbThirdGeneral
            // 
            this.rbThirdGeneral.AutoSize = true;
            this.rbThirdGeneral.Checked = true;
            this.rbThirdGeneral.Location = new System.Drawing.Point(515, 303);
            this.rbThirdGeneral.Name = "rbThirdGeneral";
            this.rbThirdGeneral.Size = new System.Drawing.Size(62, 17);
            this.rbThirdGeneral.TabIndex = 15;
            this.rbThirdGeneral.TabStop = true;
            this.rbThirdGeneral.Text = "General";
            this.rbThirdGeneral.UseVisualStyleBackColor = true;
            this.rbThirdGeneral.CheckedChanged += new System.EventHandler(this.PatientPayType3rd_Changed);
            // 
            // rbThirdYCDO
            // 
            this.rbThirdYCDO.AutoSize = true;
            this.rbThirdYCDO.Location = new System.Drawing.Point(515, 285);
            this.rbThirdYCDO.Name = "rbThirdYCDO";
            this.rbThirdYCDO.Size = new System.Drawing.Size(96, 17);
            this.rbThirdYCDO.TabIndex = 14;
            this.rbThirdYCDO.Text = "YCDO Member";
            this.rbThirdYCDO.UseVisualStyleBackColor = true;
            this.rbThirdYCDO.CheckedChanged += new System.EventHandler(this.PatientPayType3rd_Changed);
            // 
            // rbThirdPoor
            // 
            this.rbThirdPoor.AutoSize = true;
            this.rbThirdPoor.Location = new System.Drawing.Point(515, 267);
            this.rbThirdPoor.Name = "rbThirdPoor";
            this.rbThirdPoor.Size = new System.Drawing.Size(47, 17);
            this.rbThirdPoor.TabIndex = 13;
            this.rbThirdPoor.Text = "Poor";
            this.rbThirdPoor.UseVisualStyleBackColor = true;
            this.rbThirdPoor.CheckedChanged += new System.EventHandler(this.PatientPayType3rd_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Patient Registration #:";
            // 
            // dtpThirdPatientRegistrationDate
            // 
            this.dtpThirdPatientRegistrationDate.CustomFormat = "dd/MM/yyyy";
            this.dtpThirdPatientRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThirdPatientRegistrationDate.Location = new System.Drawing.Point(152, 95);
            this.dtpThirdPatientRegistrationDate.Name = "dtpThirdPatientRegistrationDate";
            this.dtpThirdPatientRegistrationDate.Size = new System.Drawing.Size(147, 20);
            this.dtpThirdPatientRegistrationDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Patient Registration Date:";
            // 
            // txtThirdCNIC
            // 
            this.txtThirdCNIC.Location = new System.Drawing.Point(10, 173);
            this.txtThirdCNIC.Name = "txtThirdCNIC";
            this.txtThirdCNIC.Size = new System.Drawing.Size(138, 20);
            this.txtThirdCNIC.TabIndex = 5;
            // 
            // txtThirdPatientRegistrationNumber
            // 
            this.txtThirdPatientRegistrationNumber.BackColor = System.Drawing.Color.White;
            this.txtThirdPatientRegistrationNumber.Location = new System.Drawing.Point(10, 95);
            this.txtThirdPatientRegistrationNumber.Name = "txtThirdPatientRegistrationNumber";
            this.txtThirdPatientRegistrationNumber.ReadOnly = true;
            this.txtThirdPatientRegistrationNumber.Size = new System.Drawing.Size(138, 20);
            this.txtThirdPatientRegistrationNumber.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 119;
            this.label12.Text = "Patient CNIC #:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 115;
            this.label13.Text = "First Name:";
            // 
            // txtThirdAddress
            // 
            this.txtThirdAddress.Location = new System.Drawing.Point(10, 211);
            this.txtThirdAddress.Multiline = true;
            this.txtThirdAddress.Name = "txtThirdAddress";
            this.txtThirdAddress.Size = new System.Drawing.Size(229, 40);
            this.txtThirdAddress.TabIndex = 7;
            // 
            // lblThirdAlwaysPaid
            // 
            this.lblThirdAlwaysPaid.AutoSize = true;
            this.lblThirdAlwaysPaid.Location = new System.Drawing.Point(4, 254);
            this.lblThirdAlwaysPaid.Name = "lblThirdAlwaysPaid";
            this.lblThirdAlwaysPaid.Size = new System.Drawing.Size(64, 13);
            this.lblThirdAlwaysPaid.TabIndex = 121;
            this.lblThirdAlwaysPaid.Text = "Always Paid";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 123;
            this.label14.Text = "Patient Address:";
            // 
            // txtThirdLastName
            // 
            this.txtThirdLastName.Location = new System.Drawing.Point(152, 134);
            this.txtThirdLastName.Name = "txtThirdLastName";
            this.txtThirdLastName.Size = new System.Drawing.Size(147, 20);
            this.txtThirdLastName.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(152, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 117;
            this.label15.Text = "Last Name:";
            // 
            // txtThirdFirstName
            // 
            this.txtThirdFirstName.Location = new System.Drawing.Point(10, 134);
            this.txtThirdFirstName.Name = "txtThirdFirstName";
            this.txtThirdFirstName.Size = new System.Drawing.Size(138, 20);
            this.txtThirdFirstName.TabIndex = 3;
            // 
            // lbxPaidMedicine
            // 
            this.lbxPaidMedicine.ContextMenuStrip = this.cmdPaidCancel;
            this.lbxPaidMedicine.FormattingEnabled = true;
            this.lbxPaidMedicine.Location = new System.Drawing.Point(7, 267);
            this.lbxPaidMedicine.Name = "lbxPaidMedicine";
            this.lbxPaidMedicine.Size = new System.Drawing.Size(193, 95);
            this.lbxPaidMedicine.TabIndex = 9;
            this.lbxPaidMedicine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxPaidMedicine_KeyDown);
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
            // txtThirdExistingToken
            // 
            this.txtThirdExistingToken.BackColor = System.Drawing.Color.Gainsboro;
            this.txtThirdExistingToken.Location = new System.Drawing.Point(134, 54);
            this.txtThirdExistingToken.Name = "txtThirdExistingToken";
            this.txtThirdExistingToken.ReadOnly = true;
            this.txtThirdExistingToken.Size = new System.Drawing.Size(121, 20);
            this.txtThirdExistingToken.TabIndex = 107;
            this.txtThirdExistingToken.Visible = false;
            // 
            // btnThirdExistingToken
            // 
            this.btnThirdExistingToken.Location = new System.Drawing.Point(10, 51);
            this.btnThirdExistingToken.Name = "btnThirdExistingToken";
            this.btnThirdExistingToken.Size = new System.Drawing.Size(109, 23);
            this.btnThirdExistingToken.TabIndex = 106;
            this.btnThirdExistingToken.Text = "E&xisting Token No.";
            this.btnThirdExistingToken.UseVisualStyleBackColor = true;
            this.btnThirdExistingToken.Click += new System.EventHandler(this.btnThirdExistingToken_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsNew,
            this.tsSave,
            this.tsReprintToken});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 25);
            this.toolStrip1.TabIndex = 141;
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
            this.tsReprintToken.Visible = false;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(245, 369);
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
            this.txtDays.TabIndex = 12;
            this.txtDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDays.ValueChanged += new System.EventHandler(this.txtDays_ValueChanged);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(205, 372);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(34, 13);
            this.lblDays.TabIndex = 142;
            this.lblDays.Text = "Days:";
            // 
            // lblCurrentTokenNumber2nd
            // 
            this.lblCurrentTokenNumber2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTokenNumber2nd.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentTokenNumber2nd.Location = new System.Drawing.Point(305, 54);
            this.lblCurrentTokenNumber2nd.Name = "lblCurrentTokenNumber2nd";
            this.lblCurrentTokenNumber2nd.Size = new System.Drawing.Size(337, 107);
            this.lblCurrentTokenNumber2nd.TabIndex = 144;
            this.lblCurrentTokenNumber2nd.Text = "-100";
            this.lblCurrentTokenNumber2nd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTokenDate2nd
            // 
            this.lblTokenDate2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenDate2nd.Location = new System.Drawing.Point(397, 148);
            this.lblTokenDate2nd.Name = "lblTokenDate2nd";
            this.lblTokenDate2nd.Size = new System.Drawing.Size(165, 25);
            this.lblTokenDate2nd.TabIndex = 145;
            this.lblTokenDate2nd.Text = "Date";
            this.lblTokenDate2nd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 146;
            this.label1.Text = "Cash Received:";
            // 
            // txtCashRecievedByUser
            // 
            this.txtCashRecievedByUser.BackColor = System.Drawing.Color.White;
            this.txtCashRecievedByUser.Location = new System.Drawing.Point(514, 388);
            this.txtCashRecievedByUser.Name = "txtCashRecievedByUser";
            this.txtCashRecievedByUser.Size = new System.Drawing.Size(112, 20);
            this.txtCashRecievedByUser.TabIndex = 17;
            this.txtCashRecievedByUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashRecievedByUser_KeyPress);
            // 
            // txtThirdAge
            // 
            this.txtThirdAge.Location = new System.Drawing.Point(245, 211);
            this.txtThirdAge.Name = "txtThirdAge";
            this.txtThirdAge.Size = new System.Drawing.Size(54, 20);
            this.txtThirdAge.TabIndex = 8;
            this.txtThirdAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPatientAge
            // 
            this.lblPatientAge.AutoSize = true;
            this.lblPatientAge.Location = new System.Drawing.Point(245, 195);
            this.lblPatientAge.Name = "lblPatientAge";
            this.lblPatientAge.Size = new System.Drawing.Size(29, 13);
            this.lblPatientAge.TabIndex = 151;
            this.lblPatientAge.Text = "Age:";
            // 
            // txtThirdMobile
            // 
            this.txtThirdMobile.Location = new System.Drawing.Point(152, 173);
            this.txtThirdMobile.Name = "txtThirdMobile";
            this.txtThirdMobile.Size = new System.Drawing.Size(147, 20);
            this.txtThirdMobile.TabIndex = 6;
            // 
            // lblPatientMobile
            // 
            this.lblPatientMobile.AutoSize = true;
            this.lblPatientMobile.Location = new System.Drawing.Point(152, 157);
            this.lblPatientMobile.Name = "lblPatientMobile";
            this.lblPatientMobile.Size = new System.Drawing.Size(87, 13);
            this.lblPatientMobile.TabIndex = 150;
            this.lblPatientMobile.Text = "Patient Mobile #:";
            // 
            // txtThirdRoom
            // 
            this.txtThirdRoom.Enabled = false;
            this.txtThirdRoom.Location = new System.Drawing.Point(245, 264);
            this.txtThirdRoom.Name = "txtThirdRoom";
            this.txtThirdRoom.Size = new System.Drawing.Size(190, 20);
            this.txtThirdRoom.TabIndex = 153;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 152;
            this.label6.Text = "Checked By:";
            // 
            // frmFourthTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 415);
            this.Controls.Add(this.txtThirdRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtThirdAge);
            this.Controls.Add(this.lblPatientAge);
            this.Controls.Add(this.txtThirdMobile);
            this.Controls.Add(this.lblPatientMobile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCashRecievedByUser);
            this.Controls.Add(this.lblTokenDate2nd);
            this.Controls.Add(this.lblCurrentTokenNumber2nd);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblThirdCashReceived);
            this.Controls.Add(this.cbxmembers);
            this.Controls.Add(this.txtThirdPaidTotal);
            this.Controls.Add(this.txtThirdCashReceived);
            this.Controls.Add(this.rbThirdGeneral);
            this.Controls.Add(this.rbThirdYCDO);
            this.Controls.Add(this.rbThirdPoor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpThirdPatientRegistrationDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtThirdCNIC);
            this.Controls.Add(this.txtThirdPatientRegistrationNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtThirdAddress);
            this.Controls.Add(this.lblThirdAlwaysPaid);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtThirdLastName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtThirdFirstName);
            this.Controls.Add(this.lbxPaidMedicine);
            this.Controls.Add(this.txtThirdExistingToken);
            this.Controls.Add(this.btnThirdExistingToken);
            this.Name = "frmFourthTurn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Second Turn (days)";
            this.Load += new System.EventHandler(this.frmFourthTurn_Load);
            this.cmdPaidCancel.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThirdCashReceived;
        private System.Windows.Forms.ComboBox cbxmembers;
        private System.Windows.Forms.TextBox txtThirdPaidTotal;
        private System.Windows.Forms.TextBox txtThirdCashReceived;
        private System.Windows.Forms.RadioButton rbThirdGeneral;
        private System.Windows.Forms.RadioButton rbThirdYCDO;
        private System.Windows.Forms.RadioButton rbThirdPoor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpThirdPatientRegistrationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThirdCNIC;
        private System.Windows.Forms.TextBox txtThirdPatientRegistrationNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtThirdAddress;
        private System.Windows.Forms.Label lblThirdAlwaysPaid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtThirdLastName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtThirdFirstName;
        private System.Windows.Forms.ListBox lbxPaidMedicine;
        private System.Windows.Forms.TextBox txtThirdExistingToken;
        private System.Windows.Forms.Button btnThirdExistingToken;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripButton tsReprintToken;
        private System.Windows.Forms.NumericUpDown txtDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblCurrentTokenNumber2nd;
        private System.Windows.Forms.Label lblTokenDate2nd;
        private System.Windows.Forms.ContextMenuStrip cmdPaidCancel;
        private System.Windows.Forms.ToolStripMenuItem tsmPaidCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCashRecievedByUser;
        private System.Windows.Forms.TextBox txtThirdAge;
        private System.Windows.Forms.Label lblPatientAge;
        private System.Windows.Forms.TextBox txtThirdMobile;
        private System.Windows.Forms.Label lblPatientMobile;
        private System.Windows.Forms.TextBox txtThirdRoom;
        private System.Windows.Forms.Label label6;
    }
}