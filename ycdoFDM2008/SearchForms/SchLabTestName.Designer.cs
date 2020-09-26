namespace FDM.SearchForms
{
    partial class SchLabTestName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchLabTestName));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsSelect = new System.Windows.Forms.ToolStripButton();
            this.DGVCountry = new System.Windows.Forms.DataGridView();
            this.txtSearchCountry = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsSelect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(539, 25);
            this.toolStrip1.TabIndex = 77;
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
            // DGVCountry
            // 
            this.DGVCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCountry.Location = new System.Drawing.Point(22, 63);
            this.DGVCountry.Name = "DGVCountry";
            this.DGVCountry.ReadOnly = true;
            this.DGVCountry.RowHeadersVisible = false;
            this.DGVCountry.Size = new System.Drawing.Size(505, 246);
            this.DGVCountry.TabIndex = 78;
            this.DGVCountry.DoubleClick += new System.EventHandler(this.DGVCountry_DoubleClick);
            this.DGVCountry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCountry_CellContentClick);
            // 
            // txtSearchCountry
            // 
            this.txtSearchCountry.Location = new System.Drawing.Point(22, 37);
            this.txtSearchCountry.Name = "txtSearchCountry";
            this.txtSearchCountry.Size = new System.Drawing.Size(505, 20);
            this.txtSearchCountry.TabIndex = 79;
            this.txtSearchCountry.TextChanged += new System.EventHandler(this.txtSearchCountry_TextChanged);
            // 
            // SchLabTestName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 319);
            this.Controls.Add(this.txtSearchCountry);
            this.Controls.Add(this.DGVCountry);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SchLabTestName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchLabTestName";
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
        private System.Windows.Forms.ToolStripButton tsSelect;
        private System.Windows.Forms.DataGridView DGVCountry;
        private System.Windows.Forms.TextBox txtSearchCountry;
    }
}