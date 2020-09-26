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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctorCheckup));
            this.lblTokenNumber = new System.Windows.Forms.Label();
            this.lblCurrentTokenNumber = new System.Windows.Forms.Label();
            this.txtPatientRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblPatientRegistrationNumber = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblLoadingNextToken = new System.Windows.Forms.Label();
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
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.lblTokens = new System.Windows.Forms.Label();
            this.gbxLabTest = new System.Windows.Forms.GroupBox();
            this.btnAddPathology = new System.Windows.Forms.Button();
            this.cbxPathologyTest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxLabTest = new System.Windows.Forms.ListBox();
            this.btnDoTest = new System.Windows.Forms.Button();
            this.pbxLoading = new System.Windows.Forms.PictureBox();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.gbLabTest.SuspendLayout();
            this.gbxPerDayDose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.gbxLabTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).BeginInit();
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
            this.tsRefresh,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(777, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(350, 513);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 27);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Get Medicine";
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
            this.lblLoadingNextToken.Location = new System.Drawing.Point(31, 511);
            this.lblLoadingNextToken.Name = "lblLoadingNextToken";
            this.lblLoadingNextToken.Size = new System.Drawing.Size(313, 25);
            this.lblLoadingNextToken.TabIndex = 2;
            this.lblLoadingNextToken.Text = "Loading  Next Token ...";
            this.lblLoadingNextToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLoadingNextToken.Visible = false;
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
            this.txtPatientDetails.Size = new System.Drawing.Size(562, 87);
            this.txtPatientDetails.TabIndex = 10;
            // 
            // gbLabTest
            // 
            this.gbLabTest.Controls.Add(this.gbxPerDayDose);
            this.gbLabTest.Controls.Add(this.btnAddLabTest);
            this.gbLabTest.Controls.Add(this.cbxLabTest);
            this.gbLabTest.Controls.Add(this.label9);
            this.gbLabTest.Controls.Add(this.lstLabTest);
            this.gbLabTest.Location = new System.Drawing.Point(17, 397);
            this.gbLabTest.Name = "gbLabTest";
            this.gbLabTest.Size = new System.Drawing.Size(566, 112);
            this.gbLabTest.TabIndex = 36;
            this.gbLabTest.TabStop = false;
            this.gbLabTest.Text = "Medicine";
            // 
            // gbxPerDayDose
            // 
            this.gbxPerDayDose.Controls.Add(this.rbThreeDay);
            this.gbxPerDayDose.Controls.Add(this.rbTwoDay);
            this.gbxPerDayDose.Controls.Add(this.rbOneDay);
            this.gbxPerDayDose.Location = new System.Drawing.Point(159, 41);
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
            this.btnAddLabTest.Location = new System.Drawing.Point(243, 82);
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
            this.cbxLabTest.Location = new System.Drawing.Point(63, 17);
            this.cbxLabTest.Name = "cbxLabTest";
            this.cbxLabTest.Size = new System.Drawing.Size(264, 21);
            this.cbxLabTest.TabIndex = 5;
            this.cbxLabTest.SelectedIndexChanged += new System.EventHandler(this.cbxLabTest_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Medicine";
            // 
            // lstLabTest
            // 
            this.lstLabTest.FormattingEnabled = true;
            this.lstLabTest.Location = new System.Drawing.Point(333, 11);
            this.lstLabTest.Name = "lstLabTest";
            this.lstLabTest.Size = new System.Drawing.Size(227, 95);
            this.lstLabTest.TabIndex = 10;
            this.lstLabTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstLabTest_KeyDown);
            // 
            // lstLabTestId
            // 
            this.lstLabTestId.FormattingEnabled = true;
            this.lstLabTestId.Location = new System.Drawing.Point(315, 569);
            this.lstLabTestId.Name = "lstLabTestId";
            this.lstLabTestId.Size = new System.Drawing.Size(68, 95);
            this.lstLabTestId.TabIndex = 37;
            this.lstLabTestId.Visible = false;
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
            this.dgvTokens.Location = new System.Drawing.Point(589, 79);
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
            this.dgvTokens.Size = new System.Drawing.Size(184, 461);
            this.dgvTokens.TabIndex = 38;
            this.dgvTokens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTokens_CellClick);
            this.dgvTokens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTokens_CellContentClick);
            // 
            // lblTokens
            // 
            this.lblTokens.AutoSize = true;
            this.lblTokens.Location = new System.Drawing.Point(586, 64);
            this.lblTokens.Name = "lblTokens";
            this.lblTokens.Size = new System.Drawing.Size(46, 13);
            this.lblTokens.TabIndex = 39;
            this.lblTokens.Text = "Tokens:";
            // 
            // gbxLabTest
            // 
            this.gbxLabTest.Controls.Add(this.btnAddPathology);
            this.gbxLabTest.Controls.Add(this.cbxPathologyTest);
            this.gbxLabTest.Controls.Add(this.label2);
            this.gbxLabTest.Controls.Add(this.lbxLabTest);
            this.gbxLabTest.Location = new System.Drawing.Point(17, 246);
            this.gbxLabTest.Name = "gbxLabTest";
            this.gbxLabTest.Size = new System.Drawing.Size(566, 112);
            this.gbxLabTest.TabIndex = 37;
            this.gbxLabTest.TabStop = false;
            this.gbxLabTest.Text = "Lab Test";
            // 
            // btnAddPathology
            // 
            this.btnAddPathology.Location = new System.Drawing.Point(243, 82);
            this.btnAddPathology.Name = "btnAddPathology";
            this.btnAddPathology.Size = new System.Drawing.Size(75, 23);
            this.btnAddPathology.TabIndex = 9;
            this.btnAddPathology.Text = "Add";
            this.btnAddPathology.UseVisualStyleBackColor = true;
            this.btnAddPathology.Click += new System.EventHandler(this.btnAddPathology_Click);
            // 
            // cbxPathologyTest
            // 
            this.cbxPathologyTest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPathologyTest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPathologyTest.FormattingEnabled = true;
            this.cbxPathologyTest.Location = new System.Drawing.Point(63, 17);
            this.cbxPathologyTest.Name = "cbxPathologyTest";
            this.cbxPathologyTest.Size = new System.Drawing.Size(264, 21);
            this.cbxPathologyTest.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lab Test";
            // 
            // lbxLabTest
            // 
            this.lbxLabTest.FormattingEnabled = true;
            this.lbxLabTest.Location = new System.Drawing.Point(333, 11);
            this.lbxLabTest.Name = "lbxLabTest";
            this.lbxLabTest.Size = new System.Drawing.Size(227, 95);
            this.lbxLabTest.TabIndex = 10;
            this.lbxLabTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstLabTest_KeyDown);
            // 
            // btnDoTest
            // 
            this.btnDoTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoTest.Location = new System.Drawing.Point(350, 364);
            this.btnDoTest.Name = "btnDoTest";
            this.btnDoTest.Size = new System.Drawing.Size(121, 27);
            this.btnDoTest.TabIndex = 40;
            this.btnDoTest.Text = "Do LabTest";
            this.btnDoTest.UseVisualStyleBackColor = true;
            this.btnDoTest.Click += new System.EventHandler(this.btnDoTest_Click);
            // 
            // pbxLoading
            // 
            this.pbxLoading.Image = global::FDM.Properties.Resources.Green_006_loading;
            this.pbxLoading.Location = new System.Drawing.Point(202, 516);
            this.pbxLoading.Name = "pbxLoading";
            this.pbxLoading.Size = new System.Drawing.Size(142, 18);
            this.pbxLoading.TabIndex = 35;
            this.pbxLoading.TabStop = false;
            this.pbxLoading.Visible = false;
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
            // tsRefresh
            // 
            this.tsRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsRefresh.Image")));
            this.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRefresh.Name = "tsRefresh";
            this.tsRefresh.Size = new System.Drawing.Size(65, 22);
            this.tsRefresh.Text = "Refresh";
            this.tsRefresh.Click += new System.EventHandler(this.tsRefresh_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton1.Text = "Verify Token";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(95, 22);
            this.toolStripButton2.Text = "Show Counter";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frmDoctorCheckup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 545);
            this.Controls.Add(this.btnDoTest);
            this.Controls.Add(this.gbxLabTest);
            this.Controls.Add(this.lblTokens);
            this.Controls.Add(this.dgvTokens);
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
            this.gbLabTest.ResumeLayout(false);
            this.gbLabTest.PerformLayout();
            this.gbxPerDayDose.ResumeLayout(false);
            this.gbxPerDayDose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.gbxLabTest.ResumeLayout(false);
            this.gbxLabTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvTokens;
        private System.Windows.Forms.Label lblTokens;
        private System.Windows.Forms.ToolStripButton tsRefresh;
        private System.Windows.Forms.GroupBox gbxLabTest;
        private System.Windows.Forms.Button btnAddPathology;
        private System.Windows.Forms.ComboBox cbxPathologyTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxLabTest;
        private System.Windows.Forms.Button btnDoTest;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}