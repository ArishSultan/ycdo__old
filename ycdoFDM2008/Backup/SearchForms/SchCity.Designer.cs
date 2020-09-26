namespace FDM.SearchForms
{
    partial class SchCity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchCity));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsSelect = new System.Windows.Forms.ToolStripButton();
            this.dgvCities = new System.Windows.Forms.DataGridView();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsSelect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(240, 25);
            this.toolStrip1.TabIndex = 2;
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
            // dgvCities
            // 
            this.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityName,
            this.ID});
            this.dgvCities.Location = new System.Drawing.Point(12, 47);
            this.dgvCities.Name = "dgvCities";
            this.dgvCities.Size = new System.Drawing.Size(213, 193);
            this.dgvCities.TabIndex = 1;
            this.dgvCities.DoubleClick += new System.EventHandler(this.dgvCities_DoubleClick);
            // 
            // CityName
            // 
            this.CityName.HeaderText = "CityName";
            this.CityName.Name = "CityName";
            this.CityName.Width = 170;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(50, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(175, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // SchCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 247);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvCities);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SchCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select City";
            this.Load += new System.EventHandler(this.SchCity_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsSelect;
        private System.Windows.Forms.DataGridView dgvCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}