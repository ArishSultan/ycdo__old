namespace FDM
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsSetupLED = new System.Windows.Forms.ToolStripButton();
            this.tsPatientRegistration = new System.Windows.Forms.ToolStripButton();
            this.tsDoctorsCheckup = new System.Windows.Forms.ToolStripButton();
            this.tsRoom = new System.Windows.Forms.ToolStripButton();
            this.tsPrintSummary = new System.Windows.Forms.ToolStripButton();
            this.tsLabTest = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.tsUserRight = new System.Windows.Forms.ToolStripButton();
            this.tsBackup = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsExit = new System.Windows.Forms.ToolStripButton();
            this.btnMain = new System.Windows.Forms.Button();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSetupLED,
            this.tsPatientRegistration,
            this.tsDoctorsCheckup,
            this.tsRoom,
            this.tsPrintSummary,
            this.tsLabTest,
            this.tsUser,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton8,
            this.toolStripButton7,
            this.tsUserRight,
            this.tsBackup,
            this.toolStripButton1,
            this.tsExit});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(130, 639);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsSetupLED
            // 
            this.tsSetupLED.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSetupLED.Image = ((System.Drawing.Image)(resources.GetObject("tsSetupLED.Image")));
            this.tsSetupLED.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSetupLED.Name = "tsSetupLED";
            this.tsSetupLED.Size = new System.Drawing.Size(127, 17);
            this.tsSetupLED.Text = "Setup L E D\'s";
            this.tsSetupLED.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsSetupLED.Click += new System.EventHandler(this.tsSetupLED_Click);
            // 
            // tsPatientRegistration
            // 
            this.tsPatientRegistration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsPatientRegistration.Image = ((System.Drawing.Image)(resources.GetObject("tsPatientRegistration.Image")));
            this.tsPatientRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsPatientRegistration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPatientRegistration.Name = "tsPatientRegistration";
            this.tsPatientRegistration.Size = new System.Drawing.Size(127, 17);
            this.tsPatientRegistration.Text = "Patient Registeration";
            this.tsPatientRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsPatientRegistration.Click += new System.EventHandler(this.tsPatientRegistration_Click);
            // 
            // tsDoctorsCheckup
            // 
            this.tsDoctorsCheckup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDoctorsCheckup.Image = ((System.Drawing.Image)(resources.GetObject("tsDoctorsCheckup.Image")));
            this.tsDoctorsCheckup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDoctorsCheckup.Name = "tsDoctorsCheckup";
            this.tsDoctorsCheckup.Size = new System.Drawing.Size(127, 17);
            this.tsDoctorsCheckup.Text = "Doctor Checkup";
            this.tsDoctorsCheckup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsDoctorsCheckup.Click += new System.EventHandler(this.tsDoctorsCheckup_Click);
            // 
            // tsRoom
            // 
            this.tsRoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsRoom.Image = ((System.Drawing.Image)(resources.GetObject("tsRoom.Image")));
            this.tsRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRoom.Name = "tsRoom";
            this.tsRoom.Size = new System.Drawing.Size(127, 17);
            this.tsRoom.Text = "Room";
            this.tsRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsRoom.Click += new System.EventHandler(this.tsRoom_Click);
            // 
            // tsPrintSummary
            // 
            this.tsPrintSummary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsPrintSummary.Image = ((System.Drawing.Image)(resources.GetObject("tsPrintSummary.Image")));
            this.tsPrintSummary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrintSummary.Name = "tsPrintSummary";
            this.tsPrintSummary.Size = new System.Drawing.Size(127, 17);
            this.tsPrintSummary.Text = "Print Summary";
            this.tsPrintSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsPrintSummary.Click += new System.EventHandler(this.tsPrintSummary_Click);
            // 
            // tsLabTest
            // 
            this.tsLabTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsLabTest.Image = ((System.Drawing.Image)(resources.GetObject("tsLabTest.Image")));
            this.tsLabTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLabTest.Name = "tsLabTest";
            this.tsLabTest.Size = new System.Drawing.Size(127, 17);
            this.tsLabTest.Text = "Lab Test";
            this.tsLabTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsLabTest.Click += new System.EventHandler(this.tsLabTest_Click);
            // 
            // tsUser
            // 
            this.tsUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsUser.Image = ((System.Drawing.Image)(resources.GetObject("tsUser.Image")));
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(127, 17);
            this.tsUser.Text = "Create/Change User";
            this.tsUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(127, 17);
            this.toolStripButton2.Text = "Membership Form";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(127, 17);
            this.toolStripButton3.Text = "Branch Form";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(127, 17);
            this.toolStripButton4.Text = "City";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(127, 17);
            this.toolStripButton5.Text = "Members Summary";
            this.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(127, 17);
            this.toolStripButton6.Text = "Donor Form";
            this.toolStripButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(127, 17);
            this.toolStripButton7.Text = "BranchesWithCityReport";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // tsUserRight
            // 
            this.tsUserRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsUserRight.Image = ((System.Drawing.Image)(resources.GetObject("tsUserRight.Image")));
            this.tsUserRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUserRight.Name = "tsUserRight";
            this.tsUserRight.Size = new System.Drawing.Size(127, 17);
            this.tsUserRight.Text = "User Right";
            this.tsUserRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsUserRight.Click += new System.EventHandler(this.tsUserRight_Click);
            // 
            // tsBackup
            // 
            this.tsBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBackup.Image = ((System.Drawing.Image)(resources.GetObject("tsBackup.Image")));
            this.tsBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBackup.Name = "tsBackup";
            this.tsBackup.Size = new System.Drawing.Size(127, 17);
            this.tsBackup.Text = "Backup/Restore";
            this.tsBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsBackup.Click += new System.EventHandler(this.tsBackup_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(127, 17);
            this.toolStripButton1.Text = "Version";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.Click += new System.EventHandler(this.tsVersion_Click);
            // 
            // tsExit
            // 
            this.tsExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsExit.Image = ((System.Drawing.Image)(resources.GetObject("tsExit.Image")));
            this.tsExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(127, 17);
            this.tsExit.Text = "Exit";
            this.tsExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // btnMain
            // 
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMain.Location = new System.Drawing.Point(130, 0);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(17, 639);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Minimizeed";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(127, 17);
            this.toolStripButton8.Text = "Donors Summary";
            this.toolStripButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 639);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.tsMenu);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsBackup;
        private System.Windows.Forms.ToolStripButton tsExit;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsPatientRegistration;
        private System.Windows.Forms.ToolStripButton tsPrintSummary;
        private System.Windows.Forms.ToolStripButton tsDoctorsCheckup;
        private System.Windows.Forms.ToolStripButton tsRoom;
        private System.Windows.Forms.ToolStripButton tsLabTest;
        private System.Windows.Forms.ToolStripButton tsUserRight;
        private System.Windows.Forms.ToolStripButton tsSetupLED;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
    }
}