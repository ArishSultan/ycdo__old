namespace FDM.SearchForms
{
    partial class SchMedicinesIssued
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchMedicinesIssued));
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            this.txtSearchTokenNo = new System.Windows.Forms.TextBox();
            this.txtSearchTokenDate = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.Select = new System.Windows.Forms.ToolStripButton();
            this.txtSearchTokenMonthYear = new System.Windows.Forms.TextBox();
            this.txtSearchRegNO = new System.Windows.Forms.TextBox();
            this.txtSearchFirsName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.AllowUserToResizeColumns = false;
            this.dgvMedicines.AllowUserToResizeRows = false;
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Location = new System.Drawing.Point(2, 48);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.RowHeadersVisible = false;
            this.dgvMedicines.Size = new System.Drawing.Size(448, 357);
            this.dgvMedicines.TabIndex = 5;
            this.dgvMedicines.DoubleClick += new System.EventHandler(this.dgvMedicines_DoubleClick);
            // 
            // txtSearchTokenNo
            // 
            this.txtSearchTokenNo.Location = new System.Drawing.Point(81, 27);
            this.txtSearchTokenNo.Name = "txtSearchTokenNo";
            this.txtSearchTokenNo.Size = new System.Drawing.Size(80, 20);
            this.txtSearchTokenNo.TabIndex = 1;
            this.txtSearchTokenNo.TextChanged += new System.EventHandler(this.txtSearchTokenNo_TextChanged);
            // 
            // txtSearchTokenDate
            // 
            this.txtSearchTokenDate.Location = new System.Drawing.Point(1, 27);
            this.txtSearchTokenDate.Name = "txtSearchTokenDate";
            this.txtSearchTokenDate.Size = new System.Drawing.Size(80, 20);
            this.txtSearchTokenDate.TabIndex = 0;
            this.txtSearchTokenDate.TextChanged += new System.EventHandler(this.txtSearchTokenDate_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.Select});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(451, 25);
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
            // Select
            // 
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(56, 22);
            this.Select.Text = "Select";
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // txtSearchTokenMonthYear
            // 
            this.txtSearchTokenMonthYear.Location = new System.Drawing.Point(162, 27);
            this.txtSearchTokenMonthYear.Name = "txtSearchTokenMonthYear";
            this.txtSearchTokenMonthYear.Size = new System.Drawing.Size(91, 20);
            this.txtSearchTokenMonthYear.TabIndex = 2;
            this.txtSearchTokenMonthYear.TextChanged += new System.EventHandler(this.txtSearchTokenMonthYear_TextChanged);
            // 
            // txtSearchRegNO
            // 
            this.txtSearchRegNO.Location = new System.Drawing.Point(254, 27);
            this.txtSearchRegNO.Name = "txtSearchRegNO";
            this.txtSearchRegNO.Size = new System.Drawing.Size(93, 20);
            this.txtSearchRegNO.TabIndex = 6;
            this.txtSearchRegNO.TextChanged += new System.EventHandler(this.txtSearchRegNO_TextChanged);
            // 
            // txtSearchFirsName
            // 
            this.txtSearchFirsName.Location = new System.Drawing.Point(347, 27);
            this.txtSearchFirsName.Name = "txtSearchFirsName";
            this.txtSearchFirsName.Size = new System.Drawing.Size(103, 20);
            this.txtSearchFirsName.TabIndex = 7;
            this.txtSearchFirsName.TextChanged += new System.EventHandler(this.txtSearchFirsName_TextChanged);
            // 
            // SchMedicinesIssued
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 406);
            this.Controls.Add(this.txtSearchFirsName);
            this.Controls.Add(this.txtSearchRegNO);
            this.Controls.Add(this.txtSearchTokenMonthYear);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtSearchTokenDate);
            this.Controls.Add(this.txtSearchTokenNo);
            this.Controls.Add(this.dgvMedicines);
            this.Name = "SchMedicinesIssued";
            this.Text = "Medicines Issued";
            this.Load += new System.EventHandler(this.SchMedicinesIssued_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicines;
        private System.Windows.Forms.TextBox txtSearchTokenNo;
        private System.Windows.Forms.TextBox txtSearchTokenDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton Select;
        private System.Windows.Forms.TextBox txtSearchTokenMonthYear;
        private System.Windows.Forms.TextBox txtSearchRegNO;
        private System.Windows.Forms.TextBox txtSearchFirsName;
    }
}