namespace FDM.ReportForms
{
    partial class FrmMembershipReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMembershipReport));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsPreview = new System.Windows.Forms.ToolStripButton();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.tsClear = new System.Windows.Forms.ToolStripButton();
            this.cbxbranches = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbcommitte = new System.Windows.Forms.RadioButton();
            this.rbCounsil = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbBloodgroup = new System.Windows.Forms.RadioButton();
            this.rbCityName = new System.Windows.Forms.RadioButton();
            this.rbBranchName = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsPreview,
            this.tsPrint,
            this.tsClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(358, 25);
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
            // tsPreview
            // 
            this.tsPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsPreview.Image")));
            this.tsPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPreview.Name = "tsPreview";
            this.tsPreview.Size = new System.Drawing.Size(65, 22);
            this.tsPreview.Text = "Previe&w";
            this.tsPreview.Click += new System.EventHandler(this.tsPreview_Click);
            // 
            // tsPrint
            // 
            this.tsPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsPrint.Image")));
            this.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.Size = new System.Drawing.Size(49, 22);
            this.tsPrint.Text = "Print";
            this.tsPrint.Click += new System.EventHandler(this.tsPrint_Click);
            // 
            // tsClear
            // 
            this.tsClear.Image = ((System.Drawing.Image)(resources.GetObject("tsClear.Image")));
            this.tsClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClear.Name = "tsClear";
            this.tsClear.Size = new System.Drawing.Size(79, 22);
            this.tsClear.Text = "P&review All";
            this.tsClear.Click += new System.EventHandler(this.tsClear_Click);
            // 
            // cbxbranches
            // 
            this.cbxbranches.FormattingEnabled = true;
            this.cbxbranches.Location = new System.Drawing.Point(138, 78);
            this.cbxbranches.Name = "cbxbranches";
            this.cbxbranches.Size = new System.Drawing.Size(168, 21);
            this.cbxbranches.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbcommitte);
            this.groupBox1.Controls.Add(this.rbCounsil);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Controls.Add(this.rbBloodgroup);
            this.groupBox1.Controls.Add(this.rbCityName);
            this.groupBox1.Controls.Add(this.rbBranchName);
            this.groupBox1.Controls.Add(this.cbxbranches);
            this.groupBox1.Location = new System.Drawing.Point(13, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select ";
            // 
            // rbcommitte
            // 
            this.rbcommitte.AutoSize = true;
            this.rbcommitte.Location = new System.Drawing.Point(23, 126);
            this.rbcommitte.Name = "rbcommitte";
            this.rbcommitte.Size = new System.Drawing.Size(96, 17);
            this.rbcommitte.TabIndex = 5;
            this.rbcommitte.TabStop = true;
            this.rbcommitte.Text = "Committe Wise";
            this.rbcommitte.UseVisualStyleBackColor = true;
            this.rbcommitte.CheckedChanged += new System.EventHandler(this.rbcommitte_CheckedChanged);
            // 
            // rbCounsil
            // 
            this.rbCounsil.AutoSize = true;
            this.rbCounsil.Location = new System.Drawing.Point(23, 102);
            this.rbCounsil.Name = "rbCounsil";
            this.rbCounsil.Size = new System.Drawing.Size(85, 17);
            this.rbCounsil.TabIndex = 4;
            this.rbCounsil.TabStop = true;
            this.rbCounsil.Text = "Counsil Wise";
            this.rbCounsil.UseVisualStyleBackColor = true;
            this.rbCounsil.CheckedChanged += new System.EventHandler(this.rbCounsil_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(279, 102);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(42, 17);
            this.rbAll.TabIndex = 6;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "ALL";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.Visible = false;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbCityName_CheckedChanged);
            // 
            // rbBloodgroup
            // 
            this.rbBloodgroup.AutoSize = true;
            this.rbBloodgroup.Location = new System.Drawing.Point(23, 79);
            this.rbBloodgroup.Name = "rbBloodgroup";
            this.rbBloodgroup.Size = new System.Drawing.Size(109, 17);
            this.rbBloodgroup.TabIndex = 3;
            this.rbBloodgroup.TabStop = true;
            this.rbBloodgroup.Text = "Blood Group Wise";
            this.rbBloodgroup.UseVisualStyleBackColor = true;
            this.rbBloodgroup.CheckedChanged += new System.EventHandler(this.rbBloodgroup_CheckedChanged);
            // 
            // rbCityName
            // 
            this.rbCityName.AutoSize = true;
            this.rbCityName.Location = new System.Drawing.Point(23, 56);
            this.rbCityName.Name = "rbCityName";
            this.rbCityName.Size = new System.Drawing.Size(70, 17);
            this.rbCityName.TabIndex = 2;
            this.rbCityName.TabStop = true;
            this.rbCityName.Text = "City Wise";
            this.rbCityName.UseVisualStyleBackColor = true;
            this.rbCityName.CheckedChanged += new System.EventHandler(this.rbCityName_CheckedChanged);
            // 
            // rbBranchName
            // 
            this.rbBranchName.AutoSize = true;
            this.rbBranchName.Location = new System.Drawing.Point(23, 30);
            this.rbBranchName.Name = "rbBranchName";
            this.rbBranchName.Size = new System.Drawing.Size(84, 17);
            this.rbBranchName.TabIndex = 1;
            this.rbBranchName.TabStop = true;
            this.rbBranchName.Text = "Branch Wise";
            this.rbBranchName.UseVisualStyleBackColor = true;
            this.rbBranchName.CheckedChanged += new System.EventHandler(this.rbBranchName_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FDM.Properties.Resources.hd_blain;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 95);
            this.panel1.TabIndex = 83;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(39, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(262, 59);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Members Report";
            // 
            // FrmMembershipReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 319);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMembershipReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MembershipReport";
            this.Load += new System.EventHandler(this.FrmMembershipReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsPreview;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.ToolStripButton tsClear;
        private System.Windows.Forms.ComboBox cbxbranches;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCityName;
        private System.Windows.Forms.RadioButton rbBranchName;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbBloodgroup;
        private System.Windows.Forms.RadioButton rbCounsil;
        private System.Windows.Forms.RadioButton rbcommitte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
    }
}