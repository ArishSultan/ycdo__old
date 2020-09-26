namespace FDM
{
    partial class frmDoctorChecupRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctorChecupRoom));
            this.cbxRooms = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxRooms
            // 
            this.cbxRooms.FormattingEnabled = true;
            this.cbxRooms.Location = new System.Drawing.Point(82, 58);
            this.cbxRooms.Name = "cbxRooms";
            this.cbxRooms.Size = new System.Drawing.Size(209, 21);
            this.cbxRooms.TabIndex = 0;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(79, 42);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(122, 13);
            this.lblRoom.TabIndex = 1;
            this.lblRoom.Text = "Please select the Room:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsSelect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(351, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsClose
            // 
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(56, 22);
            this.tsClose.Text = "Close";
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click);
            // 
            // tsSelect
            // 
            this.tsSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsSelect.Image")));
            this.tsSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSelect.Name = "tsSelect";
            this.tsSelect.Size = new System.Drawing.Size(58, 22);
            this.tsSelect.Text = "Select";
            this.tsSelect.Click += new System.EventHandler(this.tsSelect_Click);
            // 
            // frmDoctorChecupRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 138);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.cbxRooms);
            this.Name = "frmDoctorChecupRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Check Up Room Selection";
            this.Load += new System.EventHandler(this.frmDoctorChecupRoom_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxRooms;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsSelect;
    }
}