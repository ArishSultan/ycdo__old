namespace FDM
{
    partial class frmIssuedMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssuedMedicine));
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvIssueMedicine = new System.Windows.Forms.DataGridView();
            this.cbxLabTest = new System.Windows.Forms.ComboBox();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.txtIssueNumber = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblRecieveNumber = new System.Windows.Forms.Label();
            this.lblRecieveDate = new System.Windows.Forms.Label();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrossAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cbxbranches = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueMedicine)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(129, 382);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 21);
            this.txtID.TabIndex = 26;
            this.txtID.Visible = false;
            // 
            // dgvIssueMedicine
            // 
            this.dgvIssueMedicine.AllowUserToAddRows = false;
            this.dgvIssueMedicine.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvIssueMedicine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssueMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvIssueMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssueMedicine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssueMedicine.Location = new System.Drawing.Point(39, 226);
            this.dgvIssueMedicine.Name = "dgvIssueMedicine";
            this.dgvIssueMedicine.ReadOnly = true;
            this.dgvIssueMedicine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvIssueMedicine.RowHeadersVisible = false;
            this.dgvIssueMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssueMedicine.Size = new System.Drawing.Size(473, 150);
            this.dgvIssueMedicine.TabIndex = 23;
            this.dgvIssueMedicine.DoubleClick += new System.EventHandler(this.dgvIssueMedicine_DoubleClick);
            // 
            // cbxLabTest
            // 
            this.cbxLabTest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLabTest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLabTest.FormattingEnabled = true;
            this.cbxLabTest.Location = new System.Drawing.Point(39, 199);
            this.cbxLabTest.Name = "cbxLabTest";
            this.cbxLabTest.Size = new System.Drawing.Size(228, 21);
            this.cbxLabTest.TabIndex = 7;
            this.cbxLabTest.SelectedIndexChanged += new System.EventHandler(this.cbxLabTest_SelectedIndexChanged);
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(39, 151);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(121, 21);
            this.dtpIssueDate.TabIndex = 1;
            // 
            // txtIssueNumber
            // 
            this.txtIssueNumber.Location = new System.Drawing.Point(163, 151);
            this.txtIssueNumber.Name = "txtIssueNumber";
            this.txtIssueNumber.Size = new System.Drawing.Size(104, 21);
            this.txtIssueNumber.TabIndex = 3;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(327, 199);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(104, 21);
            this.txtQty.TabIndex = 11;
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(324, 182);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(49, 13);
            this.lblQty.TabIndex = 10;
            this.lblQty.Text = "Quantity";
            // 
            // lblRecieveNumber
            // 
            this.lblRecieveNumber.AutoSize = true;
            this.lblRecieveNumber.Location = new System.Drawing.Point(160, 135);
            this.lblRecieveNumber.Name = "lblRecieveNumber";
            this.lblRecieveNumber.Size = new System.Drawing.Size(73, 13);
            this.lblRecieveNumber.TabIndex = 2;
            this.lblRecieveNumber.Text = "Issue Number";
            // 
            // lblRecieveDate
            // 
            this.lblRecieveDate.AutoSize = true;
            this.lblRecieveDate.Location = new System.Drawing.Point(36, 135);
            this.lblRecieveDate.Name = "lblRecieveDate";
            this.lblRecieveDate.Size = new System.Drawing.Size(59, 13);
            this.lblRecieveDate.TabIndex = 0;
            this.lblRecieveDate.Text = "Issue Date";
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Location = new System.Drawing.Point(36, 183);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(48, 13);
            this.lblMedicine.TabIndex = 6;
            this.lblMedicine.Text = "Medicine";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsNew,
            this.tsSave,
            this.tsEdit,
            this.tsDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(535, 25);
            this.toolStrip1.TabIndex = 17;
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
            // tsNew
            // 
            this.tsNew.Image = ((System.Drawing.Image)(resources.GetObject("tsNew.Image")));
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(51, 22);
            this.tsNew.Text = "&New";
            this.tsNew.Click += new System.EventHandler(this.tsNew_Click);
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
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsDelete.Image")));
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(60, 22);
            this.tsDelete.Text = "&Delete";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(269, 199);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(52, 21);
            this.txtPrice.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price\\Unit";
            // 
            // txtGrossAmount
            // 
            this.txtGrossAmount.Location = new System.Drawing.Point(437, 200);
            this.txtGrossAmount.Name = "txtGrossAmount";
            this.txtGrossAmount.Size = new System.Drawing.Size(75, 21);
            this.txtGrossAmount.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gross Amount";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Location = new System.Drawing.Point(437, 379);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(75, 21);
            this.txtNetAmount.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Net Amount";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::FDM.Properties.Resources.symbol_check_icon;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(39, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 22);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FDM.Properties.Resources.hd_blain;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 95);
            this.panel1.TabIndex = 25;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(102, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(289, 59);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = " Issue Medicines";
            // 
            // cbxbranches
            // 
            this.cbxbranches.FormattingEnabled = true;
            this.cbxbranches.Location = new System.Drawing.Point(273, 151);
            this.cbxbranches.Name = "cbxbranches";
            this.cbxbranches.Size = new System.Drawing.Size(158, 21);
            this.cbxbranches.TabIndex = 5;
            this.cbxbranches.SelectedIndexChanged += new System.EventHandler(this.cbxbranches_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Branch Name";
            // 
            // frmIssuedMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 417);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxbranches);
            this.Controls.Add(this.txtNetAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGrossAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvIssueMedicine);
            this.Controls.Add(this.cbxLabTest);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIssueNumber);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblRecieveNumber);
            this.Controls.Add(this.lblRecieveDate);
            this.Controls.Add(this.lblMedicine);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmIssuedMedicine";
            this.Text = " Issue Medicines";
            this.Load += new System.EventHandler(this.frmMedicineIssued_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueMedicine)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvIssueMedicine;
        private System.Windows.Forms.ComboBox cbxLabTest;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtIssueNumber;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblRecieveNumber;
        private System.Windows.Forms.Label lblRecieveDate;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrossAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxbranches;
        private System.Windows.Forms.Label label4;
    }
}