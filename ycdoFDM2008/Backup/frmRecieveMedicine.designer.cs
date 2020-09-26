namespace FDM
{
    partial class s
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(s));
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.dtpReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.lblRecieveDate = new System.Windows.Forms.Label();
            this.lblRecieveNumber = new System.Windows.Forms.Label();
            this.txtRecieveNumber = new System.Windows.Forms.TextBox();
            this.cbxLabTest = new System.Windows.Forms.ComboBox();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.dgvRecieveMedicine = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrossAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsDel = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecieveMedicine)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(335, 203);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(94, 20);
            this.txtQty.TabIndex = 4;
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(332, 187);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(49, 13);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "Quantity";
            // 
            // dtpReceiveDate
            // 
            this.dtpReceiveDate.CustomFormat = "dd/MM/yyyy";
            this.dtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceiveDate.Location = new System.Drawing.Point(39, 155);
            this.dtpReceiveDate.Name = "dtpReceiveDate";
            this.dtpReceiveDate.Size = new System.Drawing.Size(121, 20);
            this.dtpReceiveDate.TabIndex = 0;
            // 
            // lblRecieveDate
            // 
            this.lblRecieveDate.AutoSize = true;
            this.lblRecieveDate.Location = new System.Drawing.Point(36, 139);
            this.lblRecieveDate.Name = "lblRecieveDate";
            this.lblRecieveDate.Size = new System.Drawing.Size(71, 13);
            this.lblRecieveDate.TabIndex = 0;
            this.lblRecieveDate.Text = "Recieve Date";
            // 
            // lblRecieveNumber
            // 
            this.lblRecieveNumber.AutoSize = true;
            this.lblRecieveNumber.Location = new System.Drawing.Point(160, 139);
            this.lblRecieveNumber.Name = "lblRecieveNumber";
            this.lblRecieveNumber.Size = new System.Drawing.Size(85, 13);
            this.lblRecieveNumber.TabIndex = 2;
            this.lblRecieveNumber.Text = "Recieve Number";
            // 
            // txtRecieveNumber
            // 
            this.txtRecieveNumber.Location = new System.Drawing.Point(163, 155);
            this.txtRecieveNumber.Name = "txtRecieveNumber";
            this.txtRecieveNumber.Size = new System.Drawing.Size(104, 20);
            this.txtRecieveNumber.TabIndex = 1;
            // 
            // cbxLabTest
            // 
            this.cbxLabTest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLabTest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLabTest.FormattingEnabled = true;
            this.cbxLabTest.Location = new System.Drawing.Point(39, 204);
            this.cbxLabTest.Name = "cbxLabTest";
            this.cbxLabTest.Size = new System.Drawing.Size(228, 21);
            this.cbxLabTest.TabIndex = 2;
            this.cbxLabTest.SelectedIndexChanged += new System.EventHandler(this.cbxLabTest_SelectedIndexChanged);
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Location = new System.Drawing.Point(36, 187);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(48, 13);
            this.lblMedicine.TabIndex = 4;
            this.lblMedicine.Text = "Medicine";
            // 
            // dgvRecieveMedicine
            // 
            this.dgvRecieveMedicine.AllowUserToAddRows = false;
            this.dgvRecieveMedicine.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRecieveMedicine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecieveMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecieveMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecieveMedicine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecieveMedicine.Location = new System.Drawing.Point(39, 232);
            this.dgvRecieveMedicine.Name = "dgvRecieveMedicine";
            this.dgvRecieveMedicine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRecieveMedicine.RowHeadersVisible = false;
            this.dgvRecieveMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecieveMedicine.Size = new System.Drawing.Size(473, 150);
            this.dgvRecieveMedicine.TabIndex = 9;
            this.dgvRecieveMedicine.DoubleClick += new System.EventHandler(this.dgvRecieveMedicine_DoubleClick);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(39, 412);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 20);
            this.txtID.TabIndex = 12;
            this.txtID.Visible = false;
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Location = new System.Drawing.Point(437, 386);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(75, 20);
            this.txtNetAmount.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Net Amount";
            // 
            // txtGrossAmount
            // 
            this.txtGrossAmount.Location = new System.Drawing.Point(437, 204);
            this.txtGrossAmount.Name = "txtGrossAmount";
            this.txtGrossAmount.Size = new System.Drawing.Size(75, 20);
            this.txtGrossAmount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Gross Amount";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(277, 204);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(52, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Price\\Unit";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsNew,
            this.tsSave,
            this.tsEdit,
            this.tsDel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(613, 25);
            this.toolStrip2.TabIndex = 39;
            this.toolStrip2.Text = "toolStrip2";
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
            // tsNew
            // 
            this.tsNew.Image = ((System.Drawing.Image)(resources.GetObject("tsNew.Image")));
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(48, 22);
            this.tsNew.Text = "&New";
            this.tsNew.Click += new System.EventHandler(this.tsNew_Click_1);
            // 
            // tsSave
            // 
            this.tsSave.Image = ((System.Drawing.Image)(resources.GetObject("tsSave.Image")));
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(51, 22);
            this.tsSave.Text = "&Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click_1);
            // 
            // tsEdit
            // 
            this.tsEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsEdit.Image")));
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(45, 22);
            this.tsEdit.Text = "&Edit";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click_1);
            // 
            // tsDel
            // 
            this.tsDel.Image = ((System.Drawing.Image)(resources.GetObject("tsDel.Image")));
            this.tsDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDel.Name = "tsDel";
            this.tsDel.Size = new System.Drawing.Size(58, 22);
            this.tsDel.Text = "&Delete";
            this.tsDel.Click += new System.EventHandler(this.tsDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::FDM.Properties.Resources.symbol_check_icon;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(39, 386);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 20);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FDM.Properties.Resources.hd_blain;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 95);
            this.panel1.TabIndex = 11;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(514, 59);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Recieve Medicine";
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 432);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.txtNetAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGrossAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvRecieveMedicine);
            this.Controls.Add(this.cbxLabTest);
            this.Controls.Add(this.dtpReceiveDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRecieveNumber);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblRecieveNumber);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblRecieveDate);
            this.Controls.Add(this.lblMedicine);
            this.Name = "s";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recieve Medicines";
            this.Load += new System.EventHandler(this.frmRecieveMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecieveMedicine)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.DateTimePicker dtpReceiveDate;
        private System.Windows.Forms.Label lblRecieveDate;
        private System.Windows.Forms.Label lblRecieveNumber;
        private System.Windows.Forms.TextBox txtRecieveNumber;
        private System.Windows.Forms.ComboBox cbxLabTest;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.DataGridView dgvRecieveMedicine;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrossAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripButton tsDel;
    }
}