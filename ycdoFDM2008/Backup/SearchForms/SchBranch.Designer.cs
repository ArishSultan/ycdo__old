namespace FDM.SearchForms
{
    partial class SchBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchBranch));
            this.dgvBranch = new System.Windows.Forms.DataGridView();
            this.BranchCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsSelect = new System.Windows.Forms.ToolStripButton();
            this.txtBranchCode = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBranch
            // 
            this.dgvBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBranch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BranchCode,
            this.BranchName,
            this.City,
            this.Phone,
            this.ID});
            this.dgvBranch.Location = new System.Drawing.Point(12, 50);
            this.dgvBranch.Name = "dgvBranch";
            this.dgvBranch.Size = new System.Drawing.Size(543, 296);
            this.dgvBranch.TabIndex = 5;
            this.dgvBranch.DoubleClick += new System.EventHandler(this.dgvBranch_DoubleClick);
            // 
            // BranchCode
            // 
            this.BranchCode.HeaderText = "BranchCode";
            this.BranchCode.Name = "BranchCode";
            // 
            // BranchName
            // 
            this.BranchName.HeaderText = "BranchName";
            this.BranchName.Name = "BranchName";
            this.BranchName.Width = 150;
            // 
            // City
            // 
            this.City.HeaderText = "CityName";
            this.City.Name = "City";
            this.City.Width = 150;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "PhoneNumber";
            this.Phone.Name = "Phone";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsSelect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(571, 25);
            this.toolStrip1.TabIndex = 4;
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
            // tsSelect
            // 
            this.tsSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsSelect.Image")));
            this.tsSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSelect.Name = "tsSelect";
            this.tsSelect.Size = new System.Drawing.Size(56, 22);
            this.tsSelect.Text = "Select";
            this.tsSelect.Click += new System.EventHandler(this.tsSelect_Click);
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.Location = new System.Drawing.Point(52, 28);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(105, 20);
            this.txtBranchCode.TabIndex = 0;
            this.txtBranchCode.TextChanged += new System.EventHandler(this.txtBranchCode_TextChanged);
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(157, 28);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(145, 20);
            this.txtBranchName.TabIndex = 1;
            this.txtBranchName.TextChanged += new System.EventHandler(this.txtBranchName_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(453, 28);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(102, 20);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(299, 28);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(155, 20);
            this.txtCityName.TabIndex = 2;
            this.txtCityName.TextChanged += new System.EventHandler(this.txtCityName_TextChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // SchBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 358);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.txtBranchCode);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvBranch);
            this.Name = "SchBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchBranch";
            this.Load += new System.EventHandler(this.SchBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBranch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.TextBox txtBranchCode;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}