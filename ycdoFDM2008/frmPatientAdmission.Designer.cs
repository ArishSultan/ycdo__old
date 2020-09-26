namespace FDM
{
    partial class frmPatientAdmission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientAdmission));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPatientDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblPatientRegistrationNumber = new System.Windows.Forms.Label();
            this.gbxLabTest = new System.Windows.Forms.GroupBox();
            this.txtDiffDiag = new System.Windows.Forms.TextBox();
            this.btnAddDiffDiag = new System.Windows.Forms.Button();
            this.cbxDiffDiag = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbLabTest = new System.Windows.Forms.GroupBox();
            this.txtProvDiag = new System.Windows.Forms.TextBox();
            this.btnAddProveDiag = new System.Windows.Forms.Button();
            this.cbxProvDiag = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.txtPluse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBPsys = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBPdia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTokens = new System.Windows.Forms.Label();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.gbxLabTest.SuspendLayout();
            this.gbLabTest.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatientDetails
            // 
            this.txtPatientDetails.BackColor = System.Drawing.Color.White;
            this.txtPatientDetails.Location = new System.Drawing.Point(12, 134);
            this.txtPatientDetails.Multiline = true;
            this.txtPatientDetails.Name = "txtPatientDetails";
            this.txtPatientDetails.ReadOnly = true;
            this.txtPatientDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPatientDetails.Size = new System.Drawing.Size(265, 75);
            this.txtPatientDetails.TabIndex = 19;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(9, 121);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(78, 13);
            this.lblDetails.TabIndex = 18;
            this.lblDetails.Text = "Patient Details:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.White;
            this.txtPatientName.Location = new System.Drawing.Point(12, 95);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(265, 20);
            this.txtPatientName.TabIndex = 17;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(9, 82);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(74, 13);
            this.lblPatientName.TabIndex = 16;
            this.lblPatientName.Text = "Patient Name:";
            // 
            // txtPatientRegistrationNumber
            // 
            this.txtPatientRegistrationNumber.BackColor = System.Drawing.Color.White;
            this.txtPatientRegistrationNumber.Location = new System.Drawing.Point(12, 55);
            this.txtPatientRegistrationNumber.Name = "txtPatientRegistrationNumber";
            this.txtPatientRegistrationNumber.ReadOnly = true;
            this.txtPatientRegistrationNumber.Size = new System.Drawing.Size(265, 20);
            this.txtPatientRegistrationNumber.TabIndex = 15;
            // 
            // lblPatientRegistrationNumber
            // 
            this.lblPatientRegistrationNumber.AutoSize = true;
            this.lblPatientRegistrationNumber.Location = new System.Drawing.Point(9, 40);
            this.lblPatientRegistrationNumber.Name = "lblPatientRegistrationNumber";
            this.lblPatientRegistrationNumber.Size = new System.Drawing.Size(112, 13);
            this.lblPatientRegistrationNumber.TabIndex = 14;
            this.lblPatientRegistrationNumber.Text = "Patient Registration #:";
            // 
            // gbxLabTest
            // 
            this.gbxLabTest.Controls.Add(this.txtDiffDiag);
            this.gbxLabTest.Controls.Add(this.btnAddDiffDiag);
            this.gbxLabTest.Controls.Add(this.cbxDiffDiag);
            this.gbxLabTest.Controls.Add(this.label2);
            this.gbxLabTest.Location = new System.Drawing.Point(12, 227);
            this.gbxLabTest.Name = "gbxLabTest";
            this.gbxLabTest.Size = new System.Drawing.Size(566, 112);
            this.gbxLabTest.TabIndex = 45;
            this.gbxLabTest.TabStop = false;
            this.gbxLabTest.Text = "Differential Diagnosis";
            // 
            // txtDiffDiag
            // 
            this.txtDiffDiag.BackColor = System.Drawing.Color.White;
            this.txtDiffDiag.Location = new System.Drawing.Point(333, 16);
            this.txtDiffDiag.Multiline = true;
            this.txtDiffDiag.Name = "txtDiffDiag";
            this.txtDiffDiag.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiffDiag.Size = new System.Drawing.Size(227, 87);
            this.txtDiffDiag.TabIndex = 20;
            // 
            // btnAddDiffDiag
            // 
            this.btnAddDiffDiag.Location = new System.Drawing.Point(243, 82);
            this.btnAddDiffDiag.Name = "btnAddDiffDiag";
            this.btnAddDiffDiag.Size = new System.Drawing.Size(75, 23);
            this.btnAddDiffDiag.TabIndex = 9;
            this.btnAddDiffDiag.Text = "Add";
            this.btnAddDiffDiag.UseVisualStyleBackColor = true;
            this.btnAddDiffDiag.Click += new System.EventHandler(this.btnAddDiffDiag_Click);
            // 
            // cbxDiffDiag
            // 
            this.cbxDiffDiag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDiffDiag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDiffDiag.FormattingEnabled = true;
            this.cbxDiffDiag.Location = new System.Drawing.Point(63, 35);
            this.cbxDiffDiag.Name = "cbxDiffDiag";
            this.cbxDiffDiag.Size = new System.Drawing.Size(264, 21);
            this.cbxDiffDiag.TabIndex = 5;
            this.cbxDiffDiag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxDiffDiag_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Differential Diagnosis";
            // 
            // gbLabTest
            // 
            this.gbLabTest.Controls.Add(this.txtProvDiag);
            this.gbLabTest.Controls.Add(this.btnAddProveDiag);
            this.gbLabTest.Controls.Add(this.cbxProvDiag);
            this.gbLabTest.Controls.Add(this.label9);
            this.gbLabTest.Location = new System.Drawing.Point(12, 345);
            this.gbLabTest.Name = "gbLabTest";
            this.gbLabTest.Size = new System.Drawing.Size(566, 112);
            this.gbLabTest.TabIndex = 44;
            this.gbLabTest.TabStop = false;
            this.gbLabTest.Text = "Provisional Diagnosis";
            // 
            // txtProvDiag
            // 
            this.txtProvDiag.BackColor = System.Drawing.Color.White;
            this.txtProvDiag.Location = new System.Drawing.Point(333, 19);
            this.txtProvDiag.Multiline = true;
            this.txtProvDiag.Name = "txtProvDiag";
            this.txtProvDiag.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProvDiag.Size = new System.Drawing.Size(227, 87);
            this.txtProvDiag.TabIndex = 21;
            // 
            // btnAddProveDiag
            // 
            this.btnAddProveDiag.Location = new System.Drawing.Point(243, 82);
            this.btnAddProveDiag.Name = "btnAddProveDiag";
            this.btnAddProveDiag.Size = new System.Drawing.Size(75, 23);
            this.btnAddProveDiag.TabIndex = 9;
            this.btnAddProveDiag.Text = "Add";
            this.btnAddProveDiag.UseVisualStyleBackColor = true;
            this.btnAddProveDiag.Click += new System.EventHandler(this.btnAddProveDiag_Click);
            // 
            // cbxProvDiag
            // 
            this.cbxProvDiag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProvDiag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProvDiag.FormattingEnabled = true;
            this.cbxProvDiag.Location = new System.Drawing.Point(63, 35);
            this.cbxProvDiag.Name = "cbxProvDiag";
            this.cbxProvDiag.Size = new System.Drawing.Size(264, 21);
            this.cbxProvDiag.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Provisional Diagnosis";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsSave,
            this.tsEdit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(777, 25);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsClose
            // 
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(56, 22);
            this.tsClose.Text = "&Close";
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
            // tsEdit
            // 
            this.tsEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsEdit.Image")));
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(47, 22);
            this.tsEdit.Text = "&Edit";
            // 
            // txtPluse
            // 
            this.txtPluse.BackColor = System.Drawing.Color.White;
            this.txtPluse.Location = new System.Drawing.Point(345, 52);
            this.txtPluse.Name = "txtPluse";
            this.txtPluse.Size = new System.Drawing.Size(92, 20);
            this.txtPluse.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Pluse:";
            // 
            // txtTemp
            // 
            this.txtTemp.BackColor = System.Drawing.Color.White;
            this.txtTemp.Location = new System.Drawing.Point(345, 78);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(92, 20);
            this.txtTemp.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Temp:";
            // 
            // txtRR
            // 
            this.txtRR.BackColor = System.Drawing.Color.White;
            this.txtRR.Location = new System.Drawing.Point(345, 104);
            this.txtRR.Name = "txtRR";
            this.txtRR.Size = new System.Drawing.Size(92, 20);
            this.txtRR.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "R/R:";
            // 
            // txtBPsys
            // 
            this.txtBPsys.BackColor = System.Drawing.Color.White;
            this.txtBPsys.Location = new System.Drawing.Point(345, 129);
            this.txtBPsys.Name = "txtBPsys";
            this.txtBPsys.Size = new System.Drawing.Size(39, 20);
            this.txtBPsys.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "B.P:";
            // 
            // txtBPdia
            // 
            this.txtBPdia.BackColor = System.Drawing.Color.White;
            this.txtBPdia.Location = new System.Drawing.Point(398, 129);
            this.txtBPdia.Name = "txtBPdia";
            this.txtBPdia.Size = new System.Drawing.Size(39, 20);
            this.txtBPdia.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "/";
            // 
            // lblTokens
            // 
            this.lblTokens.AutoSize = true;
            this.lblTokens.Location = new System.Drawing.Point(581, 9);
            this.lblTokens.Name = "lblTokens";
            this.lblTokens.Size = new System.Drawing.Size(46, 13);
            this.lblTokens.TabIndex = 58;
            this.lblTokens.Text = "Tokens:";
            // 
            // dgvTokens
            // 
            this.dgvTokens.AllowUserToAddRows = false;
            this.dgvTokens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvTokens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTokens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTokens.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTokens.Location = new System.Drawing.Point(584, 24);
            this.dgvTokens.MultiSelect = false;
            this.dgvTokens.Name = "dgvTokens";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTokens.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTokens.RowHeadersVisible = false;
            this.dgvTokens.Size = new System.Drawing.Size(184, 433);
            this.dgvTokens.TabIndex = 57;
            this.dgvTokens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTokens_CellClick);
            // 
            // frmPatientAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 467);
            this.Controls.Add(this.lblTokens);
            this.Controls.Add(this.dgvTokens);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBPdia);
            this.Controls.Add(this.txtBPsys);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPluse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbxLabTest);
            this.Controls.Add(this.gbLabTest);
            this.Controls.Add(this.txtPatientDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtPatientRegistrationNumber);
            this.Controls.Add(this.lblPatientRegistrationNumber);
            this.Name = "frmPatientAdmission";
            this.Text = "frmPatientAdmission";
            this.Load += new System.EventHandler(this.frmPatientAdmission_Load);
            this.gbxLabTest.ResumeLayout(false);
            this.gbxLabTest.PerformLayout();
            this.gbLabTest.ResumeLayout(false);
            this.gbLabTest.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatientDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientRegistrationNumber;
        private System.Windows.Forms.Label lblPatientRegistrationNumber;
        private System.Windows.Forms.GroupBox gbxLabTest;
        private System.Windows.Forms.GroupBox gbLabTest;
        private System.Windows.Forms.TextBox txtDiffDiag;
        private System.Windows.Forms.Button btnAddDiffDiag;
        private System.Windows.Forms.ComboBox cbxDiffDiag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProvDiag;
        private System.Windows.Forms.Button btnAddProveDiag;
        private System.Windows.Forms.ComboBox cbxProvDiag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.TextBox txtPluse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBPsys;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBPdia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTokens;
        private System.Windows.Forms.DataGridView dgvTokens;
    }
}