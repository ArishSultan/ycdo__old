namespace FDM.SearchForms
{
    partial class SchIssuedMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchIssuedMedicine));
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchMedicineID = new System.Windows.Forms.TextBox();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.txtIssueNo = new System.Windows.Forms.TextBox();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsSelect = new System.Windows.Forms.ToolStripButton();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblclose = new System.Windows.Forms.ToolStripButton();
            this.lblSelect = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.AllowUserToAddRows = false;
            this.dgvMedicines.AllowUserToDeleteRows = false;
            this.dgvMedicines.AllowUserToResizeColumns = false;
            this.dgvMedicines.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMedicines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineID,
            this.MedicineName,
            this.IssueNumber,
            this.IssueDate,
            this.ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicines.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicines.Location = new System.Drawing.Point(12, 47);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.RowHeadersVisible = false;
            this.dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicines.Size = new System.Drawing.Size(453, 240);
            this.dgvMedicines.TabIndex = 15;
            this.dgvMedicines.DoubleClick += new System.EventHandler(this.dgvMedicines_DoubleClick);
            // 
            // MedicineID
            // 
            this.MedicineID.HeaderText = "MedicineID";
            this.MedicineID.Name = "MedicineID";
            // 
            // MedicineName
            // 
            this.MedicineName.HeaderText = "MedicineName";
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Width = 150;
            // 
            // IssueNumber
            // 
            this.IssueNumber.HeaderText = "IssueNumber";
            this.IssueNumber.Name = "IssueNumber";
            // 
            // IssueDate
            // 
            this.IssueDate.HeaderText = "Issue Date";
            this.IssueDate.Name = "IssueDate";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // txtSearchMedicineID
            // 
            this.txtSearchMedicineID.Location = new System.Drawing.Point(14, 26);
            this.txtSearchMedicineID.Name = "txtSearchMedicineID";
            this.txtSearchMedicineID.Size = new System.Drawing.Size(102, 20);
            this.txtSearchMedicineID.TabIndex = 0;
            this.txtSearchMedicineID.TextChanged += new System.EventHandler(this.txtSearchMedicineID_TextChanged);
            // 
            // txtMedName
            // 
            this.txtMedName.Location = new System.Drawing.Point(115, 26);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(150, 20);
            this.txtMedName.TabIndex = 1;
            this.txtMedName.TextChanged += new System.EventHandler(this.txtMedName_TextChanged);
            // 
            // txtIssueNo
            // 
            this.txtIssueNo.Location = new System.Drawing.Point(260, 26);
            this.txtIssueNo.Name = "txtIssueNo";
            this.txtIssueNo.Size = new System.Drawing.Size(105, 20);
            this.txtIssueNo.TabIndex = 2;
            this.txtIssueNo.TextChanged += new System.EventHandler(this.txtIssueNo_TextChanged);
            // 
            // tsClose
            // 
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(53, 22);
            this.tsClose.Text = "&Close";
            // 
            // tsSelect
            // 
            this.tsSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsSelect.Image")));
            this.tsSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSelect.Name = "tsSelect";
            this.tsSelect.Size = new System.Drawing.Size(56, 22);
            this.tsSelect.Text = "Select";
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Location = new System.Drawing.Point(362, 26);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(105, 20);
            this.txtIssueDate.TabIndex = 3;
            this.txtIssueDate.TextChanged += new System.EventHandler(this.txtIssueDate_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblclose,
            this.lblSelect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(479, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblclose
            // 
            this.lblclose.Image = ((System.Drawing.Image)(resources.GetObject("lblclose.Image")));
            this.lblclose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(53, 22);
            this.lblclose.Text = "&Close";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.Image = ((System.Drawing.Image)(resources.GetObject("lblSelect.Image")));
            this.lblSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(56, 22);
            this.lblSelect.Text = "Select";
            this.lblSelect.Click += new System.EventHandler(this.lblSelect_Click);
            // 
            // SchIssuedMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 309);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtIssueDate);
            this.Controls.Add(this.txtIssueNo);
            this.Controls.Add(this.txtMedName);
            this.Controls.Add(this.dgvMedicines);
            this.Controls.Add(this.txtSearchMedicineID);
            this.Name = "SchIssuedMedicine";
            this.Text = "SchIssuedMedicine";
            this.Load += new System.EventHandler(this.SchIssuedMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicines;
        private System.Windows.Forms.TextBox txtSearchMedicineID;
        private System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.TextBox txtIssueNo;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton lblclose;
        private System.Windows.Forms.ToolStripButton lblSelect;
    }
}