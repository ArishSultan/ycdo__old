namespace FDM.SearchForms
{
    partial class SchPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchPatient));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.Select = new System.Windows.Forms.ToolStripButton();
            this.DGVCountry = new System.Windows.Forms.DataGridView();
            this.txtSearchbyFName = new System.Windows.Forms.TextBox();
            this.txtSearchByPType = new System.Windows.Forms.TextBox();
            this.txtSearchByAdddress = new System.Windows.Forms.TextBox();
            this.txtSearchByNIC = new System.Windows.Forms.TextBox();
            this.txtSearchbyLName = new System.Windows.Forms.TextBox();
            this.txtSearchbyRegDate = new System.Windows.Forms.TextBox();
            this.txtSearchbyRegNo = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.Select});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(707, 25);
            this.toolStrip1.TabIndex = 7;
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
            // Select
            // 
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(58, 22);
            this.Select.Text = "Select";
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // DGVCountry
            // 
            this.DGVCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCountry.Location = new System.Drawing.Point(0, 54);
            this.DGVCountry.Name = "DGVCountry";
            this.DGVCountry.ReadOnly = true;
            this.DGVCountry.RowHeadersVisible = false;
            this.DGVCountry.Size = new System.Drawing.Size(707, 239);
            this.DGVCountry.TabIndex = 8;
            this.DGVCountry.DoubleClick += new System.EventHandler(this.DGVCountry_DoubleClick);
            // 
            // txtSearchbyFName
            // 
            this.txtSearchbyFName.Location = new System.Drawing.Point(201, 28);
            this.txtSearchbyFName.Multiline = true;
            this.txtSearchbyFName.Name = "txtSearchbyFName";
            this.txtSearchbyFName.Size = new System.Drawing.Size(97, 20);
            this.txtSearchbyFName.TabIndex = 2;
            this.txtSearchbyFName.TextChanged += new System.EventHandler(this.txtSearchbyFName_TextChanged);
            // 
            // txtSearchByPType
            // 
            this.txtSearchByPType.Location = new System.Drawing.Point(603, 28);
            this.txtSearchByPType.Multiline = true;
            this.txtSearchByPType.Name = "txtSearchByPType";
            this.txtSearchByPType.Size = new System.Drawing.Size(103, 20);
            this.txtSearchByPType.TabIndex = 6;
            this.txtSearchByPType.TextChanged += new System.EventHandler(this.txtSearchByPType_TextChanged);
            // 
            // txtSearchByAdddress
            // 
            this.txtSearchByAdddress.Location = new System.Drawing.Point(505, 28);
            this.txtSearchByAdddress.Multiline = true;
            this.txtSearchByAdddress.Name = "txtSearchByAdddress";
            this.txtSearchByAdddress.Size = new System.Drawing.Size(93, 20);
            this.txtSearchByAdddress.TabIndex = 5;
            this.txtSearchByAdddress.TextChanged += new System.EventHandler(this.txtSearchByAdddress_TextChanged);
            // 
            // txtSearchByNIC
            // 
            this.txtSearchByNIC.Location = new System.Drawing.Point(409, 28);
            this.txtSearchByNIC.Multiline = true;
            this.txtSearchByNIC.Name = "txtSearchByNIC";
            this.txtSearchByNIC.Size = new System.Drawing.Size(90, 20);
            this.txtSearchByNIC.TabIndex = 4;
            this.txtSearchByNIC.TextChanged += new System.EventHandler(this.txtSearchByNIC_TextChanged);
            // 
            // txtSearchbyLName
            // 
            this.txtSearchbyLName.Location = new System.Drawing.Point(304, 28);
            this.txtSearchbyLName.Multiline = true;
            this.txtSearchbyLName.Name = "txtSearchbyLName";
            this.txtSearchbyLName.Size = new System.Drawing.Size(99, 20);
            this.txtSearchbyLName.TabIndex = 3;
            this.txtSearchbyLName.TextChanged += new System.EventHandler(this.txtSearchbyLName_TextChanged);
            // 
            // txtSearchbyRegDate
            // 
            this.txtSearchbyRegDate.Location = new System.Drawing.Point(101, 28);
            this.txtSearchbyRegDate.Multiline = true;
            this.txtSearchbyRegDate.Name = "txtSearchbyRegDate";
            this.txtSearchbyRegDate.Size = new System.Drawing.Size(94, 20);
            this.txtSearchbyRegDate.TabIndex = 1;
            this.txtSearchbyRegDate.TextChanged += new System.EventHandler(this.txtSearchbyRegDate_TextChanged);
            // 
            // txtSearchbyRegNo
            // 
            this.txtSearchbyRegNo.Location = new System.Drawing.Point(0, 28);
            this.txtSearchbyRegNo.Multiline = true;
            this.txtSearchbyRegNo.Name = "txtSearchbyRegNo";
            this.txtSearchbyRegNo.Size = new System.Drawing.Size(95, 20);
            this.txtSearchbyRegNo.TabIndex = 0;
            this.txtSearchbyRegNo.TextChanged += new System.EventHandler(this.txtSearchbyRegNo_TextChanged);
            // 
            // SchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 294);
            this.Controls.Add(this.txtSearchbyRegNo);
            this.Controls.Add(this.txtSearchbyRegDate);
            this.Controls.Add(this.txtSearchbyLName);
            this.Controls.Add(this.txtSearchByNIC);
            this.Controls.Add(this.txtSearchByAdddress);
            this.Controls.Add(this.txtSearchByPType);
            this.Controls.Add(this.txtSearchbyFName);
            this.Controls.Add(this.DGVCountry);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SchPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seach Registered Patients";
            this.Load += new System.EventHandler(this.SchCountry_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCountry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.DataGridView DGVCountry;
        private System.Windows.Forms.TextBox txtSearchbyFName;
        private System.Windows.Forms.TextBox txtSearchByPType;
        private System.Windows.Forms.TextBox txtSearchByAdddress;
        private System.Windows.Forms.TextBox txtSearchByNIC;
        private System.Windows.Forms.TextBox txtSearchbyLName;
        private System.Windows.Forms.TextBox txtSearchbyRegDate;
        private System.Windows.Forms.TextBox txtSearchbyRegNo;
        private System.Windows.Forms.ToolStripButton Select;
    }
}