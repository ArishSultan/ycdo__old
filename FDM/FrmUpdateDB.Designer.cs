namespace FDM
{
    partial class FrmUpdateDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateDB));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsAll = new System.Windows.Forms.ToolStripButton();
            this.tsNone = new System.Windows.Forms.ToolStripButton();
            this.lblLoad = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkSalesInvoice = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(77, 54);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(592, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsUpdate,
            this.tsAll,
            this.tsNone});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsClose
            // 
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(53, 22);
            this.tsClose.Text = "Close";
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click);
            // 
            // tsUpdate
            // 
            this.tsUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsUpdate.Image")));
            this.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUpdate.Name = "tsUpdate";
            this.tsUpdate.Size = new System.Drawing.Size(62, 22);
            this.tsUpdate.Text = "Update";
            this.tsUpdate.Click += new System.EventHandler(this.tsUpdate_Click);
            // 
            // tsAll
            // 
            this.tsAll.Image = ((System.Drawing.Image)(resources.GetObject("tsAll.Image")));
            this.tsAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAll.Name = "tsAll";
            this.tsAll.Size = new System.Drawing.Size(70, 22);
            this.tsAll.Text = "Select All";
            this.tsAll.Click += new System.EventHandler(this.tsAll_Click);
            // 
            // tsNone
            // 
            this.tsNone.Image = ((System.Drawing.Image)(resources.GetObject("tsNone.Image")));
            this.tsNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNone.Name = "tsNone";
            this.tsNone.Size = new System.Drawing.Size(84, 22);
            this.tsNone.Text = "Select None";
            this.tsNone.Click += new System.EventHandler(this.tsNone_Click);
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.Location = new System.Drawing.Point(83, 36);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(225, 17);
            this.lblLoad.TabIndex = 2;
            this.lblLoad.Text = "Performing requested operation ...";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 64);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // chkSalesInvoice
            // 
            this.chkSalesInvoice.AutoSize = true;
            this.chkSalesInvoice.Location = new System.Drawing.Point(75, 93);
            this.chkSalesInvoice.Name = "chkSalesInvoice";
            this.chkSalesInvoice.Size = new System.Drawing.Size(93, 17);
            this.chkSalesInvoice.TabIndex = 16;
            this.chkSalesInvoice.Text = "Sales_Invoice";
            this.chkSalesInvoice.UseVisualStyleBackColor = true;
            // 
            // FrmUpdateDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 198);
            this.ControlBox = false;
            this.Controls.Add(this.chkSalesInvoice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.progressBar1);
            this.Name = "FrmUpdateDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Database";
            this.Load += new System.EventHandler(this.FrmUpdateDB_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsUpdate;
        private System.Windows.Forms.Label lblLoad;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton tsAll;
        private System.Windows.Forms.ToolStripButton tsNone;
        private System.Windows.Forms.CheckBox chkSalesInvoice;
    }
}