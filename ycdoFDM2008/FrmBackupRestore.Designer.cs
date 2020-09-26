namespace FDM
{
    partial class FrmBackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackupRestore));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsBackup = new System.Windows.Forms.ToolStripButton();
            this.tsRestore = new System.Windows.Forms.ToolStripButton();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnselectpath = new System.Windows.Forms.Button();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRestoreFileNameandPath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsBackup,
            this.tsRestore});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(677, 25);
            this.toolStrip1.TabIndex = 21;
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
            // tsBackup
            // 
            this.tsBackup.Image = ((System.Drawing.Image)(resources.GetObject("tsBackup.Image")));
            this.tsBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBackup.Name = "tsBackup";
            this.tsBackup.Size = new System.Drawing.Size(61, 22);
            this.tsBackup.Text = "Backup";
            this.tsBackup.Click += new System.EventHandler(this.tsBackup_Click);
            // 
            // tsRestore
            // 
            this.tsRestore.Image = ((System.Drawing.Image)(resources.GetObject("tsRestore.Image")));
            this.tsRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRestore.Name = "tsRestore";
            this.tsRestore.Size = new System.Drawing.Size(65, 22);
            this.tsRestore.Text = "Restore";
            this.tsRestore.Click += new System.EventHandler(this.tsRestore_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Location = new System.Drawing.Point(570, 170);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(83, 23);
            this.btnSelectFile.TabIndex = 25;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnselectpath
            // 
            this.btnselectpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselectpath.Location = new System.Drawing.Point(570, 129);
            this.btnselectpath.Name = "btnselectpath";
            this.btnselectpath.Size = new System.Drawing.Size(83, 23);
            this.btnselectpath.TabIndex = 24;
            this.btnselectpath.Text = "Change Path";
            this.btnselectpath.UseVisualStyleBackColor = true;
            this.btnselectpath.Click += new System.EventHandler(this.btnselectpath_Click);
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(12, 131);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.ReadOnly = true;
            this.txtBackupPath.Size = new System.Drawing.Size(552, 20);
            this.txtBackupPath.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Restore File Name && Path";
            // 
            // txtRestoreFileNameandPath
            // 
            this.txtRestoreFileNameandPath.Location = new System.Drawing.Point(12, 170);
            this.txtRestoreFileNameandPath.Name = "txtRestoreFileNameandPath";
            this.txtRestoreFileNameandPath.ReadOnly = true;
            this.txtRestoreFileNameandPath.Size = new System.Drawing.Size(552, 20);
            this.txtRestoreFileNameandPath.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FDM.Properties.Resources.hd_blain;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 95);
            this.panel1.TabIndex = 45;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(514, 59);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Backup && Restore Data";
            // 
            // FrmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 205);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRestoreFileNameandPath);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnselectpath);
            this.Controls.Add(this.txtBackupPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "FrmBackupRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup/Restore";
            this.Load += new System.EventHandler(this.frmBackupRestore_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsBackup;
        private System.Windows.Forms.ToolStripButton tsRestore;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnselectpath;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRestoreFileNameandPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
    }
}