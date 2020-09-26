namespace FDM
{
    partial class frmLabortory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLabortory));
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.gbLabTest = new System.Windows.Forms.GroupBox();
            this.btnSaveRemarks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lstLabTest = new System.Windows.Forms.ListBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblTokenNumber = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsGetNewTokens = new System.Windows.Forms.ToolStripButton();
            this.txtPatientDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblPatientRegistrationNumber = new System.Windows.Forms.Label();
            this.lblCurrentTokenNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.gbLabTest.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTokens
            // 
            this.dgvTokens.AllowUserToAddRows = false;
            this.dgvTokens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvTokens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Location = new System.Drawing.Point(547, 38);
            this.dgvTokens.MultiSelect = false;
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.RowHeadersVisible = false;
            this.dgvTokens.Size = new System.Drawing.Size(193, 381);
            this.dgvTokens.TabIndex = 50;
            this.dgvTokens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTokens_CellClick);
            this.dgvTokens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTokens_CellContentClick);
            // 
            // gbLabTest
            // 
            this.gbLabTest.Controls.Add(this.btnSaveRemarks);
            this.gbLabTest.Controls.Add(this.label1);
            this.gbLabTest.Controls.Add(this.txtRemarks);
            this.gbLabTest.Controls.Add(this.lstLabTest);
            this.gbLabTest.Location = new System.Drawing.Point(15, 307);
            this.gbLabTest.Name = "gbLabTest";
            this.gbLabTest.Size = new System.Drawing.Size(526, 145);
            this.gbLabTest.TabIndex = 49;
            this.gbLabTest.TabStop = false;
            this.gbLabTest.Text = "Lab Test and Remarks";
          
            // 
            // btnSaveRemarks
            // 
            this.btnSaveRemarks.Location = new System.Drawing.Point(213, 118);
            this.btnSaveRemarks.Name = "btnSaveRemarks";
            this.btnSaveRemarks.Size = new System.Drawing.Size(127, 23);
            this.btnSaveRemarks.TabIndex = 52;
            this.btnSaveRemarks.Text = "Save Remarks";
            this.btnSaveRemarks.UseVisualStyleBackColor = true;
            this.btnSaveRemarks.Click += new System.EventHandler(this.btnSaveRemarks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.Location = new System.Drawing.Point(213, 21);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(307, 92);
            this.txtRemarks.TabIndex = 51;
            // 
            // lstLabTest
            // 
            this.lstLabTest.FormattingEnabled = true;
            this.lstLabTest.Location = new System.Drawing.Point(6, 17);
            this.lstLabTest.Name = "lstLabTest";
            this.lstLabTest.Size = new System.Drawing.Size(201, 95);
            this.lstLabTest.TabIndex = 10;
            // 
            // lblToDate
            // 
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(339, 175);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(165, 25);
            this.lblToDate.TabIndex = 38;
            this.lblToDate.Text = "To Date";
            this.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(12, 73);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(165, 25);
            this.lblRoom.TabIndex = 40;
            this.lblRoom.Text = "Token Number";
            // 
            // lblTokenNumber
            // 
            this.lblTokenNumber.AutoSize = true;
            this.lblTokenNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenNumber.Location = new System.Drawing.Point(339, 74);
            this.lblTokenNumber.Name = "lblTokenNumber";
            this.lblTokenNumber.Size = new System.Drawing.Size(165, 25);
            this.lblTokenNumber.TabIndex = 47;
            this.lblTokenNumber.Text = "Token Number";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsGetNewTokens});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsClose
            // 
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(53, 22);
            this.tsClose.Text = "&Close";
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click_1);
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
            // txtPatientDetails
            // 
            this.txtPatientDetails.BackColor = System.Drawing.Color.White;
            this.txtPatientDetails.Location = new System.Drawing.Point(15, 206);
            this.txtPatientDetails.Multiline = true;
            this.txtPatientDetails.Name = "txtPatientDetails";
            this.txtPatientDetails.ReadOnly = true;
            this.txtPatientDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPatientDetails.Size = new System.Drawing.Size(526, 101);
            this.txtPatientDetails.TabIndex = 46;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(12, 193);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(80, 13);
            this.lblDetails.TabIndex = 45;
            this.lblDetails.Text = "Patient Details:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.White;
            this.txtPatientName.Location = new System.Drawing.Point(15, 167);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(265, 20);
            this.txtPatientName.TabIndex = 44;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(12, 154);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(75, 13);
            this.lblPatientName.TabIndex = 43;
            this.lblPatientName.Text = "Patient Name:";
            // 
            // txtPatientRegistrationNumber
            // 
            this.txtPatientRegistrationNumber.BackColor = System.Drawing.Color.White;
            this.txtPatientRegistrationNumber.Location = new System.Drawing.Point(15, 127);
            this.txtPatientRegistrationNumber.Name = "txtPatientRegistrationNumber";
            this.txtPatientRegistrationNumber.ReadOnly = true;
            this.txtPatientRegistrationNumber.Size = new System.Drawing.Size(265, 20);
            this.txtPatientRegistrationNumber.TabIndex = 42;
            // 
            // lblPatientRegistrationNumber
            // 
            this.lblPatientRegistrationNumber.AutoSize = true;
            this.lblPatientRegistrationNumber.Location = new System.Drawing.Point(12, 112);
            this.lblPatientRegistrationNumber.Name = "lblPatientRegistrationNumber";
            this.lblPatientRegistrationNumber.Size = new System.Drawing.Size(117, 13);
            this.lblPatientRegistrationNumber.TabIndex = 41;
            this.lblPatientRegistrationNumber.Text = "Patient Registration #:";
            // 
            // lblCurrentTokenNumber
            // 
            this.lblCurrentTokenNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTokenNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentTokenNumber.Location = new System.Drawing.Point(238, 83);
            this.lblCurrentTokenNumber.Name = "lblCurrentTokenNumber";
            this.lblCurrentTokenNumber.Size = new System.Drawing.Size(358, 108);
            this.lblCurrentTokenNumber.TabIndex = 48;
            this.lblCurrentTokenNumber.Text = "10000";
            this.lblCurrentTokenNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLabortory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 454);
            this.Controls.Add(this.dgvTokens);
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
            this.Name = "frmLabortory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pathology Lab";
            this.Load += new System.EventHandler(this.frmLabortory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.gbLabTest.ResumeLayout(false);
            this.gbLabTest.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTokens;
        private System.Windows.Forms.GroupBox gbLabTest;
        private System.Windows.Forms.ListBox lstLabTest;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblTokenNumber;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsGetNewTokens;
        private System.Windows.Forms.TextBox txtPatientDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientRegistrationNumber;
        private System.Windows.Forms.Label lblPatientRegistrationNumber;
        private System.Windows.Forms.Label lblCurrentTokenNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnSaveRemarks;

    }
}