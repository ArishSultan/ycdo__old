namespace FDM
{
    partial class frmdoctortoken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdoctortoken));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lbxLabTest = new System.Windows.Forms.ListBox();
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
            this.lbxInjection = new System.Windows.Forms.ListBox();
            this.lblThirdInjections = new System.Windows.Forms.Label();
            this.lbxFreeMedicine = new System.Windows.Forms.ListBox();
            this.lblThirdFree = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(679, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "Close";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::FDM.Properties.Resources.symbol_check_icon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Violet;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton2.Text = "Token";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FDM.Properties.Resources.hd_patient;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 85);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(212, 287);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 119;
            this.label18.Text = "LabTest";
            // 
            // lbxLabTest
            // 
            this.lbxLabTest.FormattingEnabled = true;
            this.lbxLabTest.Location = new System.Drawing.Point(212, 300);
            this.lbxLabTest.Name = "lbxLabTest";
            this.lbxLabTest.Size = new System.Drawing.Size(193, 95);
            this.lbxLabTest.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Patient Registration #:";
            // 
            // dtpThirdPatientRegistrationDate
            // 
            this.dtpThirdPatientRegistrationDate.CustomFormat = "dd/MM/yyyy";
            this.dtpThirdPatientRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThirdPatientRegistrationDate.Location = new System.Drawing.Point(142, 128);
            this.dtpThirdPatientRegistrationDate.Name = "dtpThirdPatientRegistrationDate";
            this.dtpThirdPatientRegistrationDate.Size = new System.Drawing.Size(138, 20);
            this.dtpThirdPatientRegistrationDate.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 107;
            this.label3.Text = "Patient Registration Date:";
            // 
            // txtThirdCNIC
            // 
            this.txtThirdCNIC.Location = new System.Drawing.Point(12, 206);
            this.txtThirdCNIC.Name = "txtThirdCNIC";
            this.txtThirdCNIC.Size = new System.Drawing.Size(265, 20);
            this.txtThirdCNIC.TabIndex = 114;
            // 
            // txtThirdPatientRegistrationNumber
            // 
            this.txtThirdPatientRegistrationNumber.BackColor = System.Drawing.Color.White;
            this.txtThirdPatientRegistrationNumber.Location = new System.Drawing.Point(12, 128);
            this.txtThirdPatientRegistrationNumber.Name = "txtThirdPatientRegistrationNumber";
            this.txtThirdPatientRegistrationNumber.ReadOnly = true;
            this.txtThirdPatientRegistrationNumber.Size = new System.Drawing.Size(121, 20);
            this.txtThirdPatientRegistrationNumber.TabIndex = 106;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 113;
            this.label12.Text = "Patient CNIC #:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 109;
            this.label13.Text = "First Name:";
            // 
            // txtThirdAddress
            // 
            this.txtThirdAddress.Location = new System.Drawing.Point(7, 244);
            this.txtThirdAddress.Multiline = true;
            this.txtThirdAddress.Name = "txtThirdAddress";
            this.txtThirdAddress.Size = new System.Drawing.Size(265, 40);
            this.txtThirdAddress.TabIndex = 117;
            // 
            // lblThirdAlwaysPaid
            // 
            this.lblThirdAlwaysPaid.AutoSize = true;
            this.lblThirdAlwaysPaid.Location = new System.Drawing.Point(6, 287);
            this.lblThirdAlwaysPaid.Name = "lblThirdAlwaysPaid";
            this.lblThirdAlwaysPaid.Size = new System.Drawing.Size(64, 13);
            this.lblThirdAlwaysPaid.TabIndex = 115;
            this.lblThirdAlwaysPaid.Text = "Always Paid";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 116;
            this.label14.Text = "Patient Address:";
            // 
            // txtThirdLastName
            // 
            this.txtThirdLastName.Location = new System.Drawing.Point(139, 167);
            this.txtThirdLastName.Name = "txtThirdLastName";
            this.txtThirdLastName.Size = new System.Drawing.Size(138, 20);
            this.txtThirdLastName.TabIndex = 112;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(142, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 111;
            this.label15.Text = "Last Name:";
            // 
            // txtThirdFirstName
            // 
            this.txtThirdFirstName.Location = new System.Drawing.Point(12, 167);
            this.txtThirdFirstName.Name = "txtThirdFirstName";
            this.txtThirdFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtThirdFirstName.TabIndex = 110;
            // 
            // lbxPaidMedicine
            // 
            this.lbxPaidMedicine.FormattingEnabled = true;
            this.lbxPaidMedicine.Location = new System.Drawing.Point(9, 300);
            this.lbxPaidMedicine.Name = "lbxPaidMedicine";
            this.lbxPaidMedicine.Size = new System.Drawing.Size(193, 95);
            this.lbxPaidMedicine.TabIndex = 104;
            // 
            // lbxInjection
            // 
            this.lbxInjection.FormattingEnabled = true;
            this.lbxInjection.Location = new System.Drawing.Point(421, 300);
            this.lbxInjection.Name = "lbxInjection";
            this.lbxInjection.Size = new System.Drawing.Size(193, 95);
            this.lbxInjection.TabIndex = 120;
            // 
            // lblThirdInjections
            // 
            this.lblThirdInjections.AutoSize = true;
            this.lblThirdInjections.Location = new System.Drawing.Point(418, 287);
            this.lblThirdInjections.Name = "lblThirdInjections";
            this.lblThirdInjections.Size = new System.Drawing.Size(41, 13);
            this.lblThirdInjections.TabIndex = 121;
            this.lblThirdInjections.Text = "Rs. 10 ";
            // 
            // lbxFreeMedicine
            // 
            this.lbxFreeMedicine.FormattingEnabled = true;
            this.lbxFreeMedicine.Location = new System.Drawing.Point(281, 181);
            this.lbxFreeMedicine.Name = "lbxFreeMedicine";
            this.lbxFreeMedicine.Size = new System.Drawing.Size(193, 82);
            this.lbxFreeMedicine.TabIndex = 122;
            // 
            // lblThirdFree
            // 
            this.lblThirdFree.AutoSize = true;
            this.lblThirdFree.Location = new System.Drawing.Point(283, 167);
            this.lblThirdFree.Name = "lblThirdFree";
            this.lblThirdFree.Size = new System.Drawing.Size(74, 13);
            this.lblThirdFree.TabIndex = 123;
            this.lblThirdFree.Text = "Free Medicine";
            // 
            // frmdoctortoken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 423);
            this.Controls.Add(this.lbxFreeMedicine);
            this.Controls.Add(this.lblThirdFree);
            this.Controls.Add(this.lblThirdInjections);
            this.Controls.Add(this.lbxInjection);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lbxLabTest);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmdoctortoken";
            this.Text = "Verify Token";
            this.Load += new System.EventHandler(this.frmdoctortoken_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox lbxLabTest;
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
        private System.Windows.Forms.ListBox lbxInjection;
        private System.Windows.Forms.Label lblThirdInjections;
        private System.Windows.Forms.ListBox lbxFreeMedicine;
        private System.Windows.Forms.Label lblThirdFree;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}