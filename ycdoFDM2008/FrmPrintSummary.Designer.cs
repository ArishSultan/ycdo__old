namespace FDM
{
    partial class FrmPrintSummary
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.gbPrintedInvoice = new System.Windows.Forms.GroupBox();
            this.chkPrintCompanyDetail = new System.Windows.Forms.CheckBox();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.btnPrintedInvoice = new System.Windows.Forms.Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dgvPrintedInvoices = new System.Windows.Forms.DataGridView();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excludeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noOfBoxesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printedInvoicesDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.gbPrintedInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintedInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printedInvoicesDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(6, 39);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(96, 20);
            this.dtpFromDate.TabIndex = 0;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(108, 39);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(96, 20);
            this.dtpToDate.TabIndex = 0;
            // 
            // gbPrintedInvoice
            // 
            this.gbPrintedInvoice.Controls.Add(this.chkPrintCompanyDetail);
            this.gbPrintedInvoice.Controls.Add(this.chkSelectAll);
            this.gbPrintedInvoice.Controls.Add(this.btnPrintedInvoice);
            this.gbPrintedInvoice.Controls.Add(this.lblToDate);
            this.gbPrintedInvoice.Controls.Add(this.lblFromDate);
            this.gbPrintedInvoice.Controls.Add(this.dtpFromDate);
            this.gbPrintedInvoice.Controls.Add(this.dtpToDate);
            this.gbPrintedInvoice.Location = new System.Drawing.Point(27, 19);
            this.gbPrintedInvoice.Name = "gbPrintedInvoice";
            this.gbPrintedInvoice.Size = new System.Drawing.Size(573, 64);
            this.gbPrintedInvoice.TabIndex = 1;
            this.gbPrintedInvoice.TabStop = false;
            this.gbPrintedInvoice.Text = "Printed Invoices Selection";
            // 
            // chkPrintCompanyDetail
            // 
            this.chkPrintCompanyDetail.AutoSize = true;
            this.chkPrintCompanyDetail.Location = new System.Drawing.Point(377, 42);
            this.chkPrintCompanyDetail.Name = "chkPrintCompanyDetail";
            this.chkPrintCompanyDetail.Size = new System.Drawing.Size(187, 17);
            this.chkPrintCompanyDetail.TabIndex = 4;
            this.chkPrintCompanyDetail.Text = "Print Company Name and Address";
            this.chkPrintCompanyDetail.UseVisualStyleBackColor = true;
            this.chkPrintCompanyDetail.CheckedChanged += new System.EventHandler(this.chkPrintCompanyDetail_CheckedChanged);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(301, 42);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chkSelectAll.TabIndex = 4;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // btnPrintedInvoice
            // 
            this.btnPrintedInvoice.Location = new System.Drawing.Point(210, 23);
            this.btnPrintedInvoice.Name = "btnPrintedInvoice";
            this.btnPrintedInvoice.Size = new System.Drawing.Size(85, 36);
            this.btnPrintedInvoice.TabIndex = 3;
            this.btnPrintedInvoice.Text = "Show Printed Invoices";
            this.btnPrintedInvoice.UseVisualStyleBackColor = true;
            this.btnPrintedInvoice.Click += new System.EventHandler(this.btnPrintedInvoice_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(112, 23);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(49, 13);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "To Date:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(6, 23);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(59, 13);
            this.lblFromDate.TabIndex = 1;
            this.lblFromDate.Text = "From Date:";
            // 
            // dgvPrintedInvoices
            // 
            this.dgvPrintedInvoices.AllowUserToAddRows = false;
            this.dgvPrintedInvoices.AllowUserToDeleteRows = false;
            this.dgvPrintedInvoices.AllowUserToOrderColumns = true;
            this.dgvPrintedInvoices.AllowUserToResizeColumns = false;
            this.dgvPrintedInvoices.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPrintedInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrintedInvoices.AutoGenerateColumns = false;
            this.dgvPrintedInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintedInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceDateDataGridViewTextBoxColumn,
            this.invoiceNumberDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.excludeDataGridViewCheckBoxColumn,
            this.noOfBoxesDataGridViewTextBoxColumn});
            this.dgvPrintedInvoices.DataSource = this.printedInvoicesDataTableBindingSource;
            this.dgvPrintedInvoices.Location = new System.Drawing.Point(23, 89);
            this.dgvPrintedInvoices.Name = "dgvPrintedInvoices";
            this.dgvPrintedInvoices.RowHeadersVisible = false;
            this.dgvPrintedInvoices.Size = new System.Drawing.Size(582, 268);
            this.dgvPrintedInvoices.TabIndex = 2;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.Frozen = true;
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "Invoice Date";
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceNumberDataGridViewTextBoxColumn
            // 
            this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.Frozen = true;
            this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "Invoice No";
            this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
            this.invoiceNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Frozen = true;
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // excludeDataGridViewCheckBoxColumn
            // 
            this.excludeDataGridViewCheckBoxColumn.DataPropertyName = "Exclude";
            this.excludeDataGridViewCheckBoxColumn.HeaderText = "Exclude";
            this.excludeDataGridViewCheckBoxColumn.Name = "excludeDataGridViewCheckBoxColumn";
            this.excludeDataGridViewCheckBoxColumn.Width = 70;
            // 
            // noOfBoxesDataGridViewTextBoxColumn
            // 
            this.noOfBoxesDataGridViewTextBoxColumn.DataPropertyName = "NoOfBoxes";
            this.noOfBoxesDataGridViewTextBoxColumn.HeaderText = "No Of Boxes";
            this.noOfBoxesDataGridViewTextBoxColumn.Name = "noOfBoxesDataGridViewTextBoxColumn";
            this.noOfBoxesDataGridViewTextBoxColumn.Width = 90;
            // 
            // printedInvoicesDataTableBindingSource
            // 
            this.printedInvoicesDataTableBindingSource.DataSource = typeof(Common.Datasets.DsPrintedInvoices.PrintedInvoicesDataTable);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(424, 374);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 25);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print Labels";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(515, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(332, 374);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 25);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Preview Labels";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // FrmPrintLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 418);
            this.Controls.Add(this.dgvPrintedInvoices);
            this.Controls.Add(this.gbPrintedInvoice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPrint);
            this.Name = "FrmPrintLabels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Box Labels for Printed Sales Invoices";
            this.Load += new System.EventHandler(this.FrmPrintLabels_Load);
            this.gbPrintedInvoice.ResumeLayout(false);
            this.gbPrintedInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintedInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printedInvoicesDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.GroupBox gbPrintedInvoice;
        private System.Windows.Forms.Button btnPrintedInvoice;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.CheckBox chkPrintCompanyDetail;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.DataGridView dgvPrintedInvoices;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.BindingSource printedInvoicesDataTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn excludeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfBoxesDataGridViewTextBoxColumn;
    }
}

