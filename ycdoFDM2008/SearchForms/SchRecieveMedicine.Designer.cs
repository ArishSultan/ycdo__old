namespace FDM.SearchForms
{
    partial class SchRecieveMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchRecieveMedicine));
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            this.ItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecievedNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receivedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchItemNumber = new System.Windows.Forms.TextBox();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.txtRecieveNo = new System.Windows.Forms.TextBox();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblclose = new System.Windows.Forms.ToolStripButton();
            this.lblSelect = new System.Windows.Forms.ToolStripButton();
            this.txtReceiveDate = new System.Windows.Forms.TextBox();
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
            this.dgvMedicines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNumber,
            this.MedicineName,
            this.RecievedNumber,
            this.Receivedate,
            this.ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicines.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicines.Location = new System.Drawing.Point(2, 47);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMedicines.RowHeadersVisible = false;
            this.dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicines.Size = new System.Drawing.Size(446, 240);
            this.dgvMedicines.TabIndex = 12;
            this.dgvMedicines.DoubleClick += new System.EventHandler(this.dgvMedicines_DoubleClick);
            // 
            // ItemNumber
            // 
            this.ItemNumber.HeaderText = "ItemNumber";
            this.ItemNumber.Name = "ItemNumber";
            // 
            // MedicineName
            // 
            this.MedicineName.HeaderText = "MedicineName";
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Width = 150;
            // 
            // RecievedNumber
            // 
            this.RecievedNumber.HeaderText = "RecievedNumber";
            this.RecievedNumber.Name = "RecievedNumber";
            // 
            // Receivedate
            // 
            this.Receivedate.HeaderText = "Receive date";
            this.Receivedate.Name = "Receivedate";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // txtSearchItemNumber
            // 
            this.txtSearchItemNumber.Location = new System.Drawing.Point(4, 26);
            this.txtSearchItemNumber.Name = "txtSearchItemNumber";
            this.txtSearchItemNumber.Size = new System.Drawing.Size(109, 20);
            this.txtSearchItemNumber.TabIndex = 0;
            this.txtSearchItemNumber.TextChanged += new System.EventHandler(this.txtSearchItemNumber_TextChanged);
            // 
            // txtMedName
            // 
            this.txtMedName.Location = new System.Drawing.Point(109, 26);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(145, 20);
            this.txtMedName.TabIndex = 1;
            this.txtMedName.TextChanged += new System.EventHandler(this.txtMedName_TextChanged);
            // 
            // txtRecieveNo
            // 
            this.txtRecieveNo.Location = new System.Drawing.Point(251, 26);
            this.txtRecieveNo.Name = "txtRecieveNo";
            this.txtRecieveNo.Size = new System.Drawing.Size(103, 20);
            this.txtRecieveNo.TabIndex = 2;
            this.txtRecieveNo.TextChanged += new System.EventHandler(this.txtRecieveNo_TextChanged);
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
            this.tsSelect.Click += new System.EventHandler(this.tsSelect_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblclose,
            this.lblSelect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(449, 25);
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
            // txtReceiveDate
            // 
            this.txtReceiveDate.Location = new System.Drawing.Point(346, 26);
            this.txtReceiveDate.Name = "txtReceiveDate";
            this.txtReceiveDate.Size = new System.Drawing.Size(103, 20);
            this.txtReceiveDate.TabIndex = 3;
            this.txtReceiveDate.TextChanged += new System.EventHandler(this.txtReceiveDate_TextChanged);
            // 
            // SchRecieveMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 286);
            this.ControlBox = false;
            this.Controls.Add(this.txtReceiveDate);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtRecieveNo);
            this.Controls.Add(this.txtMedName);
            this.Controls.Add(this.dgvMedicines);
            this.Controls.Add(this.txtSearchItemNumber);
            this.Name = "SchRecieveMedicine";
            this.Text = "Sch Recieve Medicine";
            this.Load += new System.EventHandler(this.SchRecieveMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicines;
        private System.Windows.Forms.TextBox txtSearchItemNumber;
        private System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.TextBox txtRecieveNo;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsSelect;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton lblclose;
        private System.Windows.Forms.ToolStripButton lblSelect;
        private System.Windows.Forms.TextBox txtReceiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecievedNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receivedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}