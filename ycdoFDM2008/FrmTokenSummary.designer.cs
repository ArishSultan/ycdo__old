namespace FDM
{
    partial class FrmTokenSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTokenSummary));
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbCheckup = new System.Windows.Forms.RadioButton();
            this.rbInjection = new System.Windows.Forms.RadioButton();
            this.rbLab = new System.Windows.Forms.RadioButton();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cb50 = new System.Windows.Forms.CheckBox();
            this.rbMedicine = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.tsPreview = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFromToken = new System.Windows.Forms.TextBox();
            this.txtToToken = new System.Windows.Forms.TextBox();
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.cbxShifts = new System.Windows.Forms.ComboBox();
            this.lblShifts = new System.Windows.Forms.Label();
            this.gbTokenRange = new System.Windows.Forms.GroupBox();
            this.rbAllToken = new System.Windows.Forms.RadioButton();
            this.rbRange = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbCheckup = new System.Windows.Forms.GroupBox();
            this.chbPrivate = new System.Windows.Forms.CheckBox();
            this.chbGeneral = new System.Windows.Forms.CheckBox();
            this.chbPoor = new System.Windows.Forms.CheckBox();
            this.chbUsers = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.gbTokenRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCheckup.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(4, 19);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(44, 17);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "&ALL";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbCheckup
            // 
            this.rbCheckup.AutoSize = true;
            this.rbCheckup.Location = new System.Drawing.Point(78, 19);
            this.rbCheckup.Name = "rbCheckup";
            this.rbCheckup.Size = new System.Drawing.Size(68, 17);
            this.rbCheckup.TabIndex = 1;
            this.rbCheckup.Text = "C&heckup";
            this.rbCheckup.UseVisualStyleBackColor = true;
            this.rbCheckup.CheckedChanged += new System.EventHandler(this.rbCheckup_CheckedChanged);
            // 
            // rbInjection
            // 
            this.rbInjection.AutoSize = true;
            this.rbInjection.Location = new System.Drawing.Point(201, 4);
            this.rbInjection.Name = "rbInjection";
            this.rbInjection.Size = new System.Drawing.Size(65, 17);
            this.rbInjection.TabIndex = 2;
            this.rbInjection.Text = "&Injection";
            this.rbInjection.UseVisualStyleBackColor = true;
            this.rbInjection.Visible = false;
            // 
            // rbLab
            // 
            this.rbLab.AutoSize = true;
            this.rbLab.Location = new System.Drawing.Point(161, 19);
            this.rbLab.Name = "rbLab";
            this.rbLab.Size = new System.Drawing.Size(67, 17);
            this.rbLab.TabIndex = 3;
            this.rbLab.Text = "&Lab Test";
            this.rbLab.UseVisualStyleBackColor = true;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(43, 19);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(89, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(161, 19);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(89, 20);
            this.dtpTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.cb50);
            this.groupBox1.Controls.Add(this.rbMedicine);
            this.groupBox1.Controls.Add(this.rbInjection);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Controls.Add(this.rbCheckup);
            this.groupBox1.Controls.Add(this.rbLab);
            this.groupBox1.Location = new System.Drawing.Point(14, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Token Type:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(161, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ultra Sound";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // cb50
            // 
            this.cb50.AutoSize = true;
            this.cb50.Location = new System.Drawing.Point(78, 41);
            this.cb50.Name = "cb50";
            this.cb50.Size = new System.Drawing.Size(72, 17);
            this.cb50.TabIndex = 5;
            this.cb50.Text = "Token 50";
            this.cb50.UseVisualStyleBackColor = true;
            this.cb50.CheckedChanged += new System.EventHandler(this.cb50_CheckedChanged);
            // 
            // rbMedicine
            // 
            this.rbMedicine.AutoSize = true;
            this.rbMedicine.Location = new System.Drawing.Point(4, 40);
            this.rbMedicine.Name = "rbMedicine";
            this.rbMedicine.Size = new System.Drawing.Size(68, 17);
            this.rbMedicine.TabIndex = 4;
            this.rbMedicine.Text = "&Medicine";
            this.rbMedicine.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsPrint,
            this.tsPreview});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(396, 25);
            this.toolStrip1.TabIndex = 3;
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
            // tsPrint
            // 
            this.tsPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsPrint.Image")));
            this.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.Size = new System.Drawing.Size(52, 22);
            this.tsPrint.Text = "&Print";
            this.tsPrint.Click += new System.EventHandler(this.tsPrint_Click);
            // 
            // tsPreview
            // 
            this.tsPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsPreview.Image")));
            this.tsPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPreview.Name = "tsPreview";
            this.tsPreview.Size = new System.Drawing.Size(68, 22);
            this.tsPreview.Text = "Pre&view";
            this.tsPreview.Click += new System.EventHandler(this.tsPreview_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "F&rom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "T&o";
            // 
            // txtFromToken
            // 
            this.txtFromToken.Location = new System.Drawing.Point(43, 42);
            this.txtFromToken.Name = "txtFromToken";
            this.txtFromToken.Size = new System.Drawing.Size(89, 20);
            this.txtFromToken.TabIndex = 3;
            // 
            // txtToToken
            // 
            this.txtToToken.Location = new System.Drawing.Point(161, 41);
            this.txtToToken.Name = "txtToToken";
            this.txtToToken.Size = new System.Drawing.Size(89, 20);
            this.txtToToken.TabIndex = 5;
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.chbUsers);
            this.gbDateRange.Controls.Add(this.cbxUser);
            this.gbDateRange.Controls.Add(this.cbxShifts);
            this.gbDateRange.Controls.Add(this.lblShifts);
            this.gbDateRange.Controls.Add(this.dtpFrom);
            this.gbDateRange.Controls.Add(this.dtpTo);
            this.gbDateRange.Controls.Add(this.label1);
            this.gbDateRange.Controls.Add(this.label2);
            this.gbDateRange.Location = new System.Drawing.Point(14, 97);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(266, 121);
            this.gbDateRange.TabIndex = 0;
            this.gbDateRange.TabStop = false;
            this.gbDateRange.Text = "Date Range:";
            // 
            // cbxUser
            // 
            this.cbxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUser.Enabled = false;
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(87, 80);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(163, 21);
            this.cbxUser.TabIndex = 7;
            // 
            // cbxShifts
            // 
            this.cbxShifts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShifts.FormattingEnabled = true;
            this.cbxShifts.Location = new System.Drawing.Point(87, 54);
            this.cbxShifts.Name = "cbxShifts";
            this.cbxShifts.Size = new System.Drawing.Size(163, 21);
            this.cbxShifts.TabIndex = 5;
            // 
            // lblShifts
            // 
            this.lblShifts.AutoSize = true;
            this.lblShifts.Location = new System.Drawing.Point(11, 57);
            this.lblShifts.Name = "lblShifts";
            this.lblShifts.Size = new System.Drawing.Size(61, 13);
            this.lblShifts.TabIndex = 4;
            this.lblShifts.Text = "Select Shift";
            // 
            // gbTokenRange
            // 
            this.gbTokenRange.Controls.Add(this.txtFromToken);
            this.gbTokenRange.Controls.Add(this.rbAllToken);
            this.gbTokenRange.Controls.Add(this.label3);
            this.gbTokenRange.Controls.Add(this.rbRange);
            this.gbTokenRange.Controls.Add(this.txtToToken);
            this.gbTokenRange.Controls.Add(this.label4);
            this.gbTokenRange.Location = new System.Drawing.Point(14, 238);
            this.gbTokenRange.Name = "gbTokenRange";
            this.gbTokenRange.Size = new System.Drawing.Size(266, 69);
            this.gbTokenRange.TabIndex = 1;
            this.gbTokenRange.TabStop = false;
            this.gbTokenRange.Text = "Token Range:";
            // 
            // rbAllToken
            // 
            this.rbAllToken.AutoSize = true;
            this.rbAllToken.Checked = true;
            this.rbAllToken.Location = new System.Drawing.Point(11, 19);
            this.rbAllToken.Name = "rbAllToken";
            this.rbAllToken.Size = new System.Drawing.Size(70, 17);
            this.rbAllToken.TabIndex = 0;
            this.rbAllToken.TabStop = true;
            this.rbAllToken.Text = "All &Token";
            this.rbAllToken.UseVisualStyleBackColor = true;
            // 
            // rbRange
            // 
            this.rbRange.AutoSize = true;
            this.rbRange.Location = new System.Drawing.Point(87, 19);
            this.rbRange.Name = "rbRange";
            this.rbRange.Size = new System.Drawing.Size(57, 17);
            this.rbRange.TabIndex = 1;
            this.rbRange.Text = "&Range";
            this.rbRange.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::FDM.Properties.Resources.hd_blain;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // gbCheckup
            // 
            this.gbCheckup.Controls.Add(this.chbPrivate);
            this.gbCheckup.Controls.Add(this.chbGeneral);
            this.gbCheckup.Controls.Add(this.chbPoor);
            this.gbCheckup.Enabled = false;
            this.gbCheckup.Location = new System.Drawing.Point(286, 238);
            this.gbCheckup.Name = "gbCheckup";
            this.gbCheckup.Size = new System.Drawing.Size(98, 142);
            this.gbCheckup.TabIndex = 42;
            this.gbCheckup.TabStop = false;
            this.gbCheckup.Text = "Checkup";
            this.gbCheckup.Visible = false;
            // 
            // chbPrivate
            // 
            this.chbPrivate.AutoSize = true;
            this.chbPrivate.Checked = true;
            this.chbPrivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPrivate.Location = new System.Drawing.Point(7, 79);
            this.chbPrivate.Name = "chbPrivate";
            this.chbPrivate.Size = new System.Drawing.Size(59, 17);
            this.chbPrivate.TabIndex = 2;
            this.chbPrivate.Text = "Private";
            this.chbPrivate.UseVisualStyleBackColor = true;
            // 
            // chbGeneral
            // 
            this.chbGeneral.AutoSize = true;
            this.chbGeneral.Checked = true;
            this.chbGeneral.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGeneral.Location = new System.Drawing.Point(7, 49);
            this.chbGeneral.Name = "chbGeneral";
            this.chbGeneral.Size = new System.Drawing.Size(63, 17);
            this.chbGeneral.TabIndex = 1;
            this.chbGeneral.Text = "General";
            this.chbGeneral.UseVisualStyleBackColor = true;
            // 
            // chbPoor
            // 
            this.chbPoor.AutoSize = true;
            this.chbPoor.Checked = true;
            this.chbPoor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPoor.Location = new System.Drawing.Point(7, 20);
            this.chbPoor.Name = "chbPoor";
            this.chbPoor.Size = new System.Drawing.Size(48, 17);
            this.chbPoor.TabIndex = 0;
            this.chbPoor.Text = "Poor";
            this.chbPoor.UseVisualStyleBackColor = true;
            // 
            // chbUsers
            // 
            this.chbUsers.AutoSize = true;
            this.chbUsers.Location = new System.Drawing.Point(14, 84);
            this.chbUsers.Name = "chbUsers";
            this.chbUsers.Size = new System.Drawing.Size(53, 17);
            this.chbUsers.TabIndex = 8;
            this.chbUsers.Text = "Users";
            this.chbUsers.UseVisualStyleBackColor = true;
            this.chbUsers.CheckedChanged += new System.EventHandler(this.chbUsers_CheckedChanged);
            // 
            // FrmTokenSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 400);
            this.Controls.Add(this.gbCheckup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbTokenRange);
            this.Controls.Add(this.gbDateRange);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTokenSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Token Summary";
            this.Load += new System.EventHandler(this.FrmTokenSummary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbDateRange.ResumeLayout(false);
            this.gbDateRange.PerformLayout();
            this.gbTokenRange.ResumeLayout(false);
            this.gbTokenRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCheckup.ResumeLayout(false);
            this.gbCheckup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbCheckup;
        private System.Windows.Forms.RadioButton rbInjection;
        private System.Windows.Forms.RadioButton rbLab;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.ToolStripButton tsPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFromToken;
        private System.Windows.Forms.TextBox txtToToken;
        private System.Windows.Forms.GroupBox gbDateRange;
        private System.Windows.Forms.GroupBox gbTokenRange;
        private System.Windows.Forms.RadioButton rbAllToken;
        private System.Windows.Forms.RadioButton rbRange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbMedicine;
        private System.Windows.Forms.CheckBox cb50;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cbxShifts;
        private System.Windows.Forms.Label lblShifts;
        private System.Windows.Forms.GroupBox gbCheckup;
        private System.Windows.Forms.CheckBox chbPrivate;
        private System.Windows.Forms.CheckBox chbGeneral;
        private System.Windows.Forms.CheckBox chbPoor;
        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.CheckBox chbUsers;
    }
}