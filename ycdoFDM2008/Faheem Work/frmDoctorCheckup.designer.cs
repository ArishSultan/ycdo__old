namespace FDM
{
    partial class frmDoctorCheckup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctorCheckup));
            this.lblTokenNumber = new System.Windows.Forms.Label();
            this.lblCurrentTokenNumber = new System.Windows.Forms.Label();
            this.txtPatientRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblPatientRegistrationNumber = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblLoadingNextToken = new System.Windows.Forms.Label();
            this.pbxLoading = new System.Windows.Forms.PictureBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtPatientDetails = new System.Windows.Forms.TextBox();
            this.gbLabTest = new System.Windows.Forms.GroupBox();
            this.gbxPerDayDose = new System.Windows.Forms.GroupBox();
            this.rbThreeDay = new System.Windows.Forms.RadioButton();
            this.rbTwoDay = new System.Windows.Forms.RadioButton();
            this.rbOneDay = new System.Windows.Forms.RadioButton();
            this.btnAddLabTest = new System.Windows.Forms.Button();
            this.cbxLabTest = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstLabTest = new System.Windows.Forms.ListBox();
            this.lstLabTestId = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).BeginInit();
            this.gbLabTest.SuspendLayout();
            this.gbxPerDayDose.SuspendLayout();
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
            this.tsClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(598, 25);
            this.toolStrip1.TabIndex = 3;
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
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(331, 442);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(246, 52);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next Token";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            // lblLoadingNextToken
            // 
            this.lblLoadingNextToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingNextToken.ForeColor = System.Drawing.Color.Green;
            this.lblLoadingNextToken.Location = new System.Drawing.Point(12, 469);
            this.lblLoadingNextToken.Name = "lblLoadingNextToken";
            this.lblLoadingNextToken.Size = new System.Drawing.Size(313, 25);
            this.lblLoadingNextToken.TabIndex = 2;
            this.lblLoadingNextToken.Text = "Loading  Next Token ...";
            this.lblLoadingNextToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLoadingNextToken.Visible = false;
            // 
            // pbxLoading
            // 
            this.pbxLoading.Image = global::FDM.Properties.Resources.Green_006_loading;
            this.pbxLoading.Location = new System.Drawing.Point(183, 476);
            this.pbxLoading.Name = "pbxLoading";
            this.pbxLoading.Size = new System.Drawing.Size(142, 18);
            this.pbxLoading.TabIndex = 35;
            this.pbxLoading.TabStop = false;
            this.pbxLoading.Visible = false;
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
            this.gbLabTest.Controls.Add(this.gbxPerDayDose);
            this.gbLabTest.Controls.Add(this.btnAddLabTest);
            this.gbLabTest.Controls.Add(this.cbxLabTest);
            this.gbLabTest.Controls.Add(this.label9);
            this.gbLabTest.Controls.Add(this.lstLabTest);
            this.gbLabTest.Location = new System.Drawing.Point(17, 284);
            this.gbLabTest.Name = "gbLabTest";
            this.gbLabTest.Size = new System.Drawing.Size(537, 112);
            this.gbLabTest.TabIndex = 36;
            this.gbLabTest.TabStop = false;
            this.gbLabTest.Text = "Medicine";
            // 
            // gbxPerDayDose
            // 
            this.gbxPerDayDose.Controls.Add(this.rbThreeDay);
            this.gbxPerDayDose.Controls.Add(this.rbTwoDay);
            this.gbxPerDayDose.Controls.Add(this.rbOneDay);
            this.gbxPerDayDose.Location = new System.Drawing.Point(189, 14);
            this.gbxPerDayDose.Name = "gbxPerDayDose";
            this.gbxPerDayDose.Size = new System.Drawing.Size(81, 67);
            this.gbxPerDayDose.TabIndex = 6;
            this.gbxPerDayDose.TabStop = false;
            this.gbxPerDayDose.Text = "Dose";
            // 
            // rbThreeDay
            // 
            this.rbThreeDay.AutoSize = true;
            this.rbThreeDay.Location = new System.Drawing.Point(6, 46);
            this.rbThreeDay.Name = "rbThreeDay";
            this.rbThreeDay.Size = new System.Drawing.Size(59, 17);
            this.rbThreeDay.TabIndex = 2;
            this.rbThreeDay.Text = "3 / day";
            this.rbThreeDay.UseVisualStyleBackColor = true;
            // 
            // rbTwoDay
            // 
            this.rbTwoDay.AutoSize = true;
            this.rbTwoDay.Location = new System.Drawing.Point(6, 30);
            this.rbTwoDay.Name = "rbTwoDay";
            this.rbTwoDay.Size = new System.Drawing.Size(59, 17);
            this.rbTwoDay.TabIndex = 1;
            this.rbTwoDay.Text = "2 / day";
            this.rbTwoDay.UseVisualStyleBackColor = true;
            // 
            // rbOneDay
            // 
            this.rbOneDay.AutoSize = true;
            this.rbOneDay.Checked = true;
            this.rbOneDay.Location = new System.Drawing.Point(6, 15);
            this.rbOneDay.Name = "rbOneDay";
            this.rbOneDay.Size = new System.Drawing.Size(59, 17);
            this.rbOneDay.TabIndex = 0;
            this.rbOneDay.TabStop = true;
            this.rbOneDay.Text = "1 / day";
            this.rbOneDay.UseVisualStyleBackColor = true;
            // 
            // btnAddLabTest
            // 
            this.btnAddLabTest.Location = new System.Drawing.Point(195, 87);
            this.btnAddLabTest.Name = "btnAddLabTest";
            this.btnAddLabTest.Size = new System.Drawing.Size(75, 23);
            this.btnAddLabTest.TabIndex = 9;
            this.btnAddLabTest.Text = "Add";
            this.btnAddLabTest.UseVisualStyleBackColor = true;
            this.btnAddLabTest.Click += new System.EventHandler(this.btnAddLabTest_Click);
            // 
            // cbxLabTest
            // 
            this.cbxLabTest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLabTest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLabTest.FormattingEnabled = true;
            this.cbxLabTest.Location = new System.Drawing.Point(63, 19);
            this.cbxLabTest.Name = "cbxLabTest";
            this.cbxLabTest.Size = new System.Drawing.Size(109, 21);
            this.cbxLabTest.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Medicine";
            // 
            // lstLabTest
            // 
            this.lstLabTest.FormattingEnabled = true;
            this.lstLabTest.Location = new System.Drawing.Point(288, 15);
            this.lstLabTest.Name = "lstLabTest";
            this.lstLabTest.Size = new System.Drawing.Size(198, 95);
            this.lstLabTest.TabIndex = 10;
            this.lstLabTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstLabTest_KeyDown);
            // 
            // lstLabTestId
            // 
            this.lstLabTestId.FormattingEnabled = true;
            this.lstLabTestId.Location = new System.Drawing.Point(560, 284);
            this.lstLabTestId.Name = "lstLabTestId";
            this.lstLabTestId.Size = new System.Drawing.Size(198, 95);
            this.lstLabTestId.TabIndex = 37;
            this.lstLabTestId.Visible = false;
            // 
            // frmDoctorCheckup
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 506);
            this.Controls.Add(this.lstLabTestId);
            this.Controls.Add(this.gbLabTest);
            this.Controls.Add(this.pbxLoading);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblLoadingNextToken);
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
            this.Name = "frmDoctorCheckup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Step 2: Doctors Checkup";
            this.Load += new System.EventHandler(this.frmDoctorCheckup_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).EndInit();
            this.gbLabTest.ResumeLayout(false);
            this.gbLabTest.PerformLayout();
            this.gbxPerDayDose.ResumeLayout(false);
            this.gbxPerDayDose.PerformLayout();
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
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.PictureBox pbxLoading;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblLoadingNextToken;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtPatientDetails;
        private System.Windows.Forms.GroupBox gbLabTest;
        private System.Windows.Forms.GroupBox gbxPerDayDose;
        private System.Windows.Forms.RadioButton rbThreeDay;
        private System.Windows.Forms.RadioButton rbTwoDay;
        private System.Windows.Forms.RadioButton rbOneDay;
        private System.Windows.Forms.Button btnAddLabTest;
        private System.Windows.Forms.ComboBox cbxLabTest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstLabTest;
        private System.Windows.Forms.ListBox lstLabTestId;
    }
}