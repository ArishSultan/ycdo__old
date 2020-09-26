namespace FDM
{
    partial class frmPharmacyMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPharmacyMedicine));
            this.lblTokenNumber = new System.Windows.Forms.Label();
            this.lblCurrentTokenNumber = new System.Windows.Forms.Label();
            this.txtPatientRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblPatientRegistrationNumber = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtPatientDetails = new System.Windows.Forms.TextBox();
            this.gbLabTest = new System.Windows.Forms.GroupBox();
            this.lstLabTest = new System.Windows.Forms.ListBox();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsExistingToken = new System.Windows.Forms.ToolStripButton();
            this.tsMedicienIssued = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.gbLabTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTokenNumber
            // 
            this.lblTokenNumber.AutoSize = true;
            this.lblTokenNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenNumber.Location = new System.Drawing.Point(339, 26);
            this.lblTokenNumber.Name = "lblTokenNumber";
            this.lblTokenNumber.Size = new System.Drawing.Size(165, 25);
            this.lblTokenNumber.TabIndex = 11;
            this.lblTokenNumber.Text = "Token Number";
            // 
            // lblCurrentTokenNumber
            // 
            this.lblCurrentTokenNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTokenNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentTokenNumber.Location = new System.Drawing.Point(242, 35);
            this.lblCurrentTokenNumber.Name = "lblCurrentTokenNumber";
            this.lblCurrentTokenNumber.Size = new System.Drawing.Size(367, 108);
            this.lblCurrentTokenNumber.TabIndex = 12;
            this.lblCurrentTokenNumber.Text = "10000";
            this.lblCurrentTokenNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPatientRegistrationNumber
            // 
            this.txtPatientRegistrationNumber.BackColor = System.Drawing.Color.White;
            this.txtPatientRegistrationNumber.Location = new System.Drawing.Point(15, 79);
            this.txtPatientRegistrationNumber.Name = "txtPatientRegistrationNumber";
            this.txtPatientRegistrationNumber.ReadOnly = true;
            this.txtPatientRegistrationNumber.Size = new System.Drawing.Size(265, 20);
            this.txtPatientRegistrationNumber.TabIndex = 6;
            // 
            // lblPatientRegistrationNumber
            // 
            this.lblPatientRegistrationNumber.AutoSize = true;
            this.lblPatientRegistrationNumber.Location = new System.Drawing.Point(12, 64);
            this.lblPatientRegistrationNumber.Name = "lblPatientRegistrationNumber";
            this.lblPatientRegistrationNumber.Size = new System.Drawing.Size(112, 13);
            this.lblPatientRegistrationNumber.TabIndex = 5;
            this.lblPatientRegistrationNumber.Text = "Patient Registration #:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.White;
            this.txtPatientName.Location = new System.Drawing.Point(15, 119);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(265, 20);
            this.txtPatientName.TabIndex = 8;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(12, 106);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(74, 13);
            this.lblPatientName.TabIndex = 7;
            this.lblPatientName.Text = "Patient Name:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsExistingToken,
            this.tsMedicienIssued});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(598, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblToDate
            // 
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(339, 127);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(165, 25);
            this.lblToDate.TabIndex = 0;
            this.lblToDate.Text = "To Date";
            this.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(12, 25);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(165, 25);
            this.lblRoom.TabIndex = 4;
            this.lblRoom.Text = "Token Number";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(12, 145);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(78, 13);
            this.lblDetails.TabIndex = 9;
            this.lblDetails.Text = "Patient Details:";
            // 
            // txtPatientDetails
            // 
            this.txtPatientDetails.BackColor = System.Drawing.Color.White;
            this.txtPatientDetails.Location = new System.Drawing.Point(15, 158);
            this.txtPatientDetails.Multiline = true;
            this.txtPatientDetails.Name = "txtPatientDetails";
            this.txtPatientDetails.ReadOnly = true;
            this.txtPatientDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPatientDetails.Size = new System.Drawing.Size(562, 101);
            this.txtPatientDetails.TabIndex = 10;
            // 
            // gbLabTest
            // 
            this.gbLabTest.Controls.Add(this.lstLabTest);
            this.gbLabTest.Location = new System.Drawing.Point(17, 284);
            this.gbLabTest.Name = "gbLabTest";
            this.gbLabTest.Size = new System.Drawing.Size(537, 112);
            this.gbLabTest.TabIndex = 36;
            this.gbLabTest.TabStop = false;
            this.gbLabTest.Text = "Medicine";
            // 
            // lstLabTest
            // 
            this.lstLabTest.FormattingEnabled = true;
            this.lstLabTest.Location = new System.Drawing.Point(23, 15);
            this.lstLabTest.Name = "lstLabTest";
            this.lstLabTest.Size = new System.Drawing.Size(463, 95);
            this.lstLabTest.TabIndex = 10;
            this.lstLabTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstLabTest_KeyDown);
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
            // tsExistingToken
            // 
            this.tsExistingToken.Image = ((System.Drawing.Image)(resources.GetObject("tsExistingToken.Image")));
            this.tsExistingToken.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExistingToken.Name = "tsExistingToken";
            this.tsExistingToken.Size = new System.Drawing.Size(103, 22);
            this.tsExistingToken.Text = "Existing Token";
            this.tsExistingToken.Click += new System.EventHandler(this.tsExistingToken_Click);
            // 
            // tsMedicienIssued
            // 
            this.tsMedicienIssued.Image = ((System.Drawing.Image)(resources.GetObject("tsMedicienIssued.Image")));
            this.tsMedicienIssued.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMedicienIssued.Name = "tsMedicienIssued";
            this.tsMedicienIssued.Size = new System.Drawing.Size(112, 22);
            this.tsMedicienIssued.Text = "Medicine Issued";
            this.tsMedicienIssued.Click += new System.EventHandler(this.tsMedicienIssued_Click);
            // 
            // frmPharmacyMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 423);
            this.Controls.Add(this.gbLabTest);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblTokenNumber);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtPatientDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtPatientRegistrationNumber);
            this.Controls.Add(this.lblPatientRegistrationNumber);
            this.Controls.Add(this.lblCurrentTokenNumber);
            this.Name = "frmPharmacyMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Step 3: Pharmacy Medicine Issue";
            this.Load += new System.EventHandler(this.frmDoctorCheckup_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbLabTest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTokenNumber;
        private System.Windows.Forms.Label lblCurrentTokenNumber;
        private System.Windows.Forms.TextBox txtPatientRegistrationNumber;
        private System.Windows.Forms.Label lblPatientRegistrationNumber;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtPatientDetails;
        private System.Windows.Forms.GroupBox gbLabTest;
        private System.Windows.Forms.ListBox lstLabTest;
        private System.Windows.Forms.ToolStripButton tsExistingToken;
        private System.Windows.Forms.ToolStripButton tsMedicienIssued;
    }
}