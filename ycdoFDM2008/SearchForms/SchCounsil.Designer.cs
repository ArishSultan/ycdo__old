namespace FDM.SearchForms
{
    partial class SchCounsil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchCounsil));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsSelect = new System.Windows.Forms.ToolStripButton();
            this.DGVCounsil = new System.Windows.Forms.DataGridView();
            this.txtSearchCounsil = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCounsil)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsSelect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(249, 25);
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
            // DGVCounsil
            // 
            this.DGVCounsil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCounsil.Location = new System.Drawing.Point(22, 71);
            this.DGVCounsil.Name = "DGVCounsil";
            this.DGVCounsil.ReadOnly = true;
            this.DGVCounsil.Size = new System.Drawing.Size(205, 211);
            this.DGVCounsil.TabIndex = 1;
            // 
            // txtSearchCounsil
            // 
            this.txtSearchCounsil.Location = new System.Drawing.Point(63, 45);
            this.txtSearchCounsil.Name = "txtSearchCounsil";
            this.txtSearchCounsil.Size = new System.Drawing.Size(150, 20);
            this.txtSearchCounsil.TabIndex = 0;
            this.txtSearchCounsil.TextChanged += new System.EventHandler(this.txtSearchCounsil_TextChanged);
            // 
            // SchCounsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 294);
            this.Controls.Add(this.txtSearchCounsil);
            this.Controls.Add(this.DGVCounsil);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SchCounsil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Counsil";
            this.Load += new System.EventHandler(this.SchCounsil_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCounsil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsSelect;
        private System.Windows.Forms.DataGridView DGVCounsil;
        private System.Windows.Forms.TextBox txtSearchCounsil;
    }
}