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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTokenNumber = new System.Windows.Forms.Label();
            this.lblCurrentTokenNumber = new System.Windows.Forms.Label();
            this.txtPatientRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblPatientRegistrationNumber = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsGetNewTokens = new System.Windows.Forms.ToolStripButton();
            this.Search = new System.Windows.Forms.ToolStripButton();
            this.tsMedicienIssued = new System.Windows.Forms.ToolStripButton();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtPatientDetails = new System.Windows.Forms.TextBox();
            this.gbLabTest = new System.Windows.Forms.GroupBox();
            this.btnFreeMedicineCancelAll = new System.Windows.Forms.Button();
            this.btnFreeCancel = new System.Windows.Forms.Button();
            this.btnAlwaysPaidCancelAll = new System.Windows.Forms.Button();
            this.btnAlwaysPaidCancel = new System.Windows.Forms.Button();
            this.lstPaidandInjection = new System.Windows.Forms.ListBox();
            this.lstLabTest = new System.Windows.Forms.ListBox();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.btnAlwaysPaid = new System.Windows.Forms.Button();
            this.txtPaidToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.gbLabTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
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
            this.lblCurrentTokenNumber.Location = new System.Drawing.Point(235, 35);
            this.lblCurrentTokenNumber.Name = "lblCurrentTokenNumber";
            this.lblCurrentTokenNumber.Size = new System.Drawing.Size(358, 108);
            this.lblCurrentTokenNumber.TabIndex = 12;
            this.lblCurrentTokenNumber.Text = "10000";
            this.lblCurrentTokenNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentTokenNumber.Click += new System.EventHandler(this.lblCurrentTokenNumber_Click);
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
            this.tsGetNewTokens,
            this.Search,
            this.tsMedicienIssued});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(741, 25);
            this.toolStrip1.TabIndex = 3;
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
            // tsGetNewTokens
            // 
            this.tsGetNewTokens.Image = ((System.Drawing.Image)(resources.GetObject("tsGetNewTokens.Image")));
            this.tsGetNewTokens.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGetNewTokens.Name = "tsGetNewTokens";
            this.tsGetNewTokens.Size = new System.Drawing.Size(97, 22);
            this.tsGetNewTokens.Text = "Refresh Token";
            this.tsGetNewTokens.Click += new System.EventHandler(this.tsGetNewTokens_Click);
            // 
            // Search
            // 
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(86, 22);
            this.Search.Text = "View History";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // tsMedicienIssued
            // 
            this.tsMedicienIssued.Image = ((System.Drawing.Image)(resources.GetObject("tsMedicienIssued.Image")));
            this.tsMedicienIssued.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMedicienIssued.Name = "tsMedicienIssued";
            this.tsMedicienIssued.Size = new System.Drawing.Size(103, 22);
            this.tsMedicienIssued.Text = "Medicine Issued";
            this.tsMedicienIssued.Click += new System.EventHandler(this.tsMedicienIssued_Click);
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
            this.txtPatientDetails.Size = new System.Drawing.Size(526, 101);
            this.txtPatientDetails.TabIndex = 10;
            // 
            // gbLabTest
            // 
            this.gbLabTest.Controls.Add(this.btnFreeMedicineCancelAll);
            this.gbLabTest.Controls.Add(this.btnFreeCancel);
            this.gbLabTest.Controls.Add(this.btnAlwaysPaidCancelAll);
            this.gbLabTest.Controls.Add(this.btnAlwaysPaidCancel);
            this.gbLabTest.Controls.Add(this.lstPaidandInjection);
            this.gbLabTest.Controls.Add(this.lstLabTest);
            this.gbLabTest.Location = new System.Drawing.Point(15, 265);
            this.gbLabTest.Name = "gbLabTest";
            this.gbLabTest.Size = new System.Drawing.Size(526, 165);
            this.gbLabTest.TabIndex = 36;
            this.gbLabTest.TabStop = false;
            this.gbLabTest.Text = "Medicine";
            // 
            // btnFreeMedicineCancelAll
            // 
            this.btnFreeMedicineCancelAll.Location = new System.Drawing.Point(92, 139);
            this.btnFreeMedicineCancelAll.Name = "btnFreeMedicineCancelAll";
            this.btnFreeMedicineCancelAll.Size = new System.Drawing.Size(75, 23);
            this.btnFreeMedicineCancelAll.TabIndex = 11;
            this.btnFreeMedicineCancelAll.Text = "Cancel All";
            this.btnFreeMedicineCancelAll.UseVisualStyleBackColor = true;
            this.btnFreeMedicineCancelAll.Click += new System.EventHandler(this.btnFreeMedicineCancelAll_Click);
            // 
            // btnFreeCancel
            // 
            this.btnFreeCancel.Location = new System.Drawing.Point(173, 139);
            this.btnFreeCancel.Name = "btnFreeCancel";
            this.btnFreeCancel.Size = new System.Drawing.Size(75, 23);
            this.btnFreeCancel.TabIndex = 11;
            this.btnFreeCancel.Text = "Cancel ";
            this.btnFreeCancel.UseVisualStyleBackColor = true;
            this.btnFreeCancel.Click += new System.EventHandler(this.btnFreeCancel_Click);
            // 
            // btnAlwaysPaidCancelAll
            // 
            this.btnAlwaysPaidCancelAll.Location = new System.Drawing.Point(358, 139);
            this.btnAlwaysPaidCancelAll.Name = "btnAlwaysPaidCancelAll";
            this.btnAlwaysPaidCancelAll.Size = new System.Drawing.Size(75, 23);
            this.btnAlwaysPaidCancelAll.TabIndex = 11;
            this.btnAlwaysPaidCancelAll.Text = "Cancel All";
            this.btnAlwaysPaidCancelAll.UseVisualStyleBackColor = true;
            this.btnAlwaysPaidCancelAll.Click += new System.EventHandler(this.btnAlwaysPaidCancelAll_Click);
            // 
            // btnAlwaysPaidCancel
            // 
            this.btnAlwaysPaidCancel.Location = new System.Drawing.Point(439, 139);
            this.btnAlwaysPaidCancel.Name = "btnAlwaysPaidCancel";
            this.btnAlwaysPaidCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAlwaysPaidCancel.TabIndex = 11;
            this.btnAlwaysPaidCancel.Text = "Cancel ";
            this.btnAlwaysPaidCancel.UseVisualStyleBackColor = true;
            this.btnAlwaysPaidCancel.Click += new System.EventHandler(this.btnAlwaysPaidCancel_Click);
            // 
            // lstPaidandInjection
            // 
            this.lstPaidandInjection.FormattingEnabled = true;
            this.lstPaidandInjection.Location = new System.Drawing.Point(270, 15);
            this.lstPaidandInjection.Name = "lstPaidandInjection";
            this.lstPaidandInjection.Size = new System.Drawing.Size(242, 121);
            this.lstPaidandInjection.TabIndex = 10;
            this.lstPaidandInjection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstLabTest_KeyDown);
            // 
            // lstLabTest
            // 
            this.lstLabTest.FormattingEnabled = true;
            this.lstLabTest.Location = new System.Drawing.Point(6, 15);
            this.lstLabTest.Name = "lstLabTest";
            this.lstLabTest.Size = new System.Drawing.Size(242, 121);
            this.lstLabTest.TabIndex = 10;
            this.lstLabTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstLabTest_KeyDown);
            // 
            // dgvTokens
            // 
            this.dgvTokens.AllowUserToAddRows = false;
            this.dgvTokens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvTokens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTokens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTokens.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTokens.Location = new System.Drawing.Point(544, 28);
            this.dgvTokens.MultiSelect = false;
            this.dgvTokens.Name = "dgvTokens";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTokens.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTokens.RowHeadersVisible = false;
            this.dgvTokens.Size = new System.Drawing.Size(197, 401);
            this.dgvTokens.TabIndex = 37;
            this.dgvTokens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTokens_CellClick);
            this.dgvTokens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTokens_CellContentClick);
            // 
            // btnAlwaysPaid
            // 
            this.btnAlwaysPaid.Location = new System.Drawing.Point(654, 382);
            this.btnAlwaysPaid.Name = "btnAlwaysPaid";
            this.btnAlwaysPaid.Size = new System.Drawing.Size(75, 23);
            this.btnAlwaysPaid.TabIndex = 38;
            this.btnAlwaysPaid.Text = "Verify";
            this.btnAlwaysPaid.UseVisualStyleBackColor = true;
            this.btnAlwaysPaid.Click += new System.EventHandler(this.btnAlwaysPaid_Click);
            // 
            // txtPaidToken
            // 
            this.txtPaidToken.BackColor = System.Drawing.Color.White;
            this.txtPaidToken.Location = new System.Drawing.Point(563, 385);
            this.txtPaidToken.Name = "txtPaidToken";
            this.txtPaidToken.Size = new System.Drawing.Size(85, 20);
            this.txtPaidToken.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Paid Token:";
            // 
            // frmPharmacyMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 433);
            this.Controls.Add(this.dgvTokens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbLabTest);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblTokenNumber);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtPatientDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtPatientRegistrationNumber);
            this.Controls.Add(this.lblPatientRegistrationNumber);
            this.Controls.Add(this.lblCurrentTokenNumber);
            this.Controls.Add(this.btnAlwaysPaid);
            this.Controls.Add(this.txtPaidToken);
            this.Name = "frmPharmacyMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Step 3: Pharmacy Medicine Issue";
            this.Load += new System.EventHandler(this.frmDoctorCheckup_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbLabTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
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
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtPatientDetails;
        private System.Windows.Forms.GroupBox gbLabTest;
        private System.Windows.Forms.ListBox lstLabTest;
        private System.Windows.Forms.ToolStripButton tsMedicienIssued;
        private System.Windows.Forms.DataGridView dgvTokens;
        private System.Windows.Forms.ToolStripButton tsGetNewTokens;
        private System.Windows.Forms.Button btnAlwaysPaid;
        private System.Windows.Forms.TextBox txtPaidToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton Search;
        private System.Windows.Forms.ListBox lstPaidandInjection;
        private System.Windows.Forms.Button btnFreeCancel;
        private System.Windows.Forms.Button btnAlwaysPaidCancel;
        private System.Windows.Forms.Button btnFreeMedicineCancelAll;
        private System.Windows.Forms.Button btnAlwaysPaidCancelAll;
    }
}