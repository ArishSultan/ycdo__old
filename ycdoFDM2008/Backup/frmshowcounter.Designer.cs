namespace FDM
{
    partial class frmshowcounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmshowcounter));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.section2DrSaminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.section3DrSohailJalilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.section4DrJameelaFaizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.section5DrAhmedKhalilAyyazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrentTokenNumber = new System.Windows.Forms.Label();
            this.section1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.toolStripButton2,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(292, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton2.Text = "Reset";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.section1ToolStripMenuItem,
            this.section2DrSaminaToolStripMenuItem,
            this.section3DrSohailJalilToolStripMenuItem,
            this.section4DrJameelaFaizaToolStripMenuItem,
            this.section5DrAhmedKhalilAyyazToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(77, 22);
            this.toolStripDropDownButton1.Text = "Doctors";
            // 
            // section2DrSaminaToolStripMenuItem
            // 
            this.section2DrSaminaToolStripMenuItem.Name = "section2DrSaminaToolStripMenuItem";
            this.section2DrSaminaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.section2DrSaminaToolStripMenuItem.Text = "Section 2";
            this.section2DrSaminaToolStripMenuItem.Click += new System.EventHandler(this.section2DrSaminaToolStripMenuItem_Click);
            // 
            // section3DrSohailJalilToolStripMenuItem
            // 
            this.section3DrSohailJalilToolStripMenuItem.Name = "section3DrSohailJalilToolStripMenuItem";
            this.section3DrSohailJalilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.section3DrSohailJalilToolStripMenuItem.Text = "Section 3";
            this.section3DrSohailJalilToolStripMenuItem.Click += new System.EventHandler(this.section3DrSohailJalilToolStripMenuItem_Click);
            // 
            // section4DrJameelaFaizaToolStripMenuItem
            // 
            this.section4DrJameelaFaizaToolStripMenuItem.Name = "section4DrJameelaFaizaToolStripMenuItem";
            this.section4DrJameelaFaizaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.section4DrJameelaFaizaToolStripMenuItem.Text = "Section 4";
            this.section4DrJameelaFaizaToolStripMenuItem.Click += new System.EventHandler(this.section4DrJameelaFaizaToolStripMenuItem_Click);
            // 
            // section5DrAhmedKhalilAyyazToolStripMenuItem
            // 
            this.section5DrAhmedKhalilAyyazToolStripMenuItem.Name = "section5DrAhmedKhalilAyyazToolStripMenuItem";
            this.section5DrAhmedKhalilAyyazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.section5DrAhmedKhalilAyyazToolStripMenuItem.Text = "Section 5";
            this.section5DrAhmedKhalilAyyazToolStripMenuItem.Click += new System.EventHandler(this.section5DrAhmedKhalilAyyazToolStripMenuItem_Click);
            // 
            // lblCurrentTokenNumber
            // 
            this.lblCurrentTokenNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTokenNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentTokenNumber.Location = new System.Drawing.Point(-37, 79);
            this.lblCurrentTokenNumber.Name = "lblCurrentTokenNumber";
            this.lblCurrentTokenNumber.Size = new System.Drawing.Size(367, 108);
            this.lblCurrentTokenNumber.TabIndex = 13;
            this.lblCurrentTokenNumber.Text = "000";
            this.lblCurrentTokenNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section1ToolStripMenuItem
            // 
            this.section1ToolStripMenuItem.Name = "section1ToolStripMenuItem";
            this.section1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.section1ToolStripMenuItem.Text = "Section 1";
            // 
            // frmshowcounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lblCurrentTokenNumber);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmshowcounter";
            this.Text = "Counter";
            this.Load += new System.EventHandler(this.frmshowcounter_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label lblCurrentTokenNumber;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem section2DrSaminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem section3DrSohailJalilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem section4DrJameelaFaizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem section5DrAhmedKhalilAyyazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem section1ToolStripMenuItem;
    }
}