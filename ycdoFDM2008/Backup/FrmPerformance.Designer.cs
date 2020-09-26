namespace FDM
{
    partial class FrmPerformance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerformance));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cbxMember = new System.Windows.Forms.ComboBox();
            this.rbSelectDonor = new System.Windows.Forms.RadioButton();
            this.rbSelectMember = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgoodentries = new System.Windows.Forms.TextBox();
            this.txtbadentries = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsNew,
            this.tsSave,
            this.tsEdit,
            this.tsDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(376, 25);
            this.toolStrip1.TabIndex = 10;
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
            // tsNew
            // 
            this.tsNew.Image = ((System.Drawing.Image)(resources.GetObject("tsNew.Image")));
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(48, 22);
            this.tsNew.Text = "&New";
            this.tsNew.Click += new System.EventHandler(this.tsNew_Click);
            // 
            // tsSave
            // 
            this.tsSave.Image = ((System.Drawing.Image)(resources.GetObject("tsSave.Image")));
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(51, 22);
            this.tsSave.Text = "&Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click_1);
            // 
            // tsEdit
            // 
            this.tsEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsEdit.Image")));
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(45, 22);
            this.tsEdit.Text = "&Edit";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsDelete.Image")));
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(58, 22);
            this.tsDelete.Text = "&Delete";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(348, 28);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(28, 20);
            this.txtid.TabIndex = 0;
            this.txtid.Visible = false;
            // 
            // cbxMember
            // 
            this.cbxMember.FormattingEnabled = true;
            this.cbxMember.Location = new System.Drawing.Point(87, 147);
            this.cbxMember.Name = "cbxMember";
            this.cbxMember.Size = new System.Drawing.Size(181, 21);
            this.cbxMember.TabIndex = 5;
            // 
            // rbSelectDonor
            // 
            this.rbSelectDonor.AutoSize = true;
            this.rbSelectDonor.Location = new System.Drawing.Point(185, 124);
            this.rbSelectDonor.Name = "rbSelectDonor";
            this.rbSelectDonor.Size = new System.Drawing.Size(83, 17);
            this.rbSelectDonor.TabIndex = 3;
            this.rbSelectDonor.TabStop = true;
            this.rbSelectDonor.Text = "SelectDonor";
            this.rbSelectDonor.UseVisualStyleBackColor = true;
            this.rbSelectDonor.CheckedChanged += new System.EventHandler(this.rbSelectDonor_CheckedChanged);
            // 
            // rbSelectMember
            // 
            this.rbSelectMember.AutoSize = true;
            this.rbSelectMember.Location = new System.Drawing.Point(87, 124);
            this.rbSelectMember.Name = "rbSelectMember";
            this.rbSelectMember.Size = new System.Drawing.Size(92, 17);
            this.rbSelectMember.TabIndex = 2;
            this.rbSelectMember.TabStop = true;
            this.rbSelectMember.Text = "SelectMember";
            this.rbSelectMember.UseVisualStyleBackColor = true;
            this.rbSelectMember.CheckedChanged += new System.EventHandler(this.rbSelectMember_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // txtgoodentries
            // 
            this.txtgoodentries.Location = new System.Drawing.Point(87, 170);
            this.txtgoodentries.Multiline = true;
            this.txtgoodentries.Name = "txtgoodentries";
            this.txtgoodentries.Size = new System.Drawing.Size(277, 29);
            this.txtgoodentries.TabIndex = 7;
            // 
            // txtbadentries
            // 
            this.txtbadentries.Location = new System.Drawing.Point(87, 202);
            this.txtbadentries.Multiline = true;
            this.txtbadentries.Name = "txtbadentries";
            this.txtbadentries.Size = new System.Drawing.Size(277, 29);
            this.txtbadentries.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Good Entries";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bad Entries";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(87, 104);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(181, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::FDM.Properties.Resources.hd_blain;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 240);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtbadentries);
            this.Controls.Add(this.txtgoodentries);
            this.Controls.Add(this.cbxMember);
            this.Controls.Add(this.rbSelectDonor);
            this.Controls.Add(this.rbSelectMember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtid);
            this.Name = "FrmPerformance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance";
            this.Load += new System.EventHandler(this.FrmPerformance_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cbxMember;
        private System.Windows.Forms.RadioButton rbSelectDonor;
        private System.Windows.Forms.RadioButton rbSelectMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgoodentries;
        private System.Windows.Forms.TextBox txtbadentries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}