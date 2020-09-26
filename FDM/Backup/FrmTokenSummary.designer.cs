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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.tsPreview = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFromToken = new System.Windows.Forms.TextBox();
            this.txtToToken = new System.Windows.Forms.TextBox();
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.gbTokenRange = new System.Windows.Forms.GroupBox();
            this.rbRange = new System.Windows.Forms.RadioButton();
            this.rbAllToken = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.gbTokenRange.SuspendLayout();
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
            this.rbCheckup.Location = new System.Drawing.Point(54, 19);
            this.rbCheckup.Name = "rbCheckup";
            this.rbCheckup.Size = new System.Drawing.Size(68, 17);
            this.rbCheckup.TabIndex = 1;
            this.rbCheckup.Text = "C&heckup";
            this.rbCheckup.UseVisualStyleBackColor = true;
            // 
            // rbInjection
            // 
            this.rbInjection.AutoSize = true;
            this.rbInjection.Location = new System.Drawing.Point(122, 19);
            this.rbInjection.Name = "rbInjection";
            this.rbInjection.Size = new System.Drawing.Size(65, 17);
            this.rbInjection.TabIndex = 2;
            this.rbInjection.Text = "&Injection";
            this.rbInjection.UseVisualStyleBackColor = true;
            // 
            // rbLab
            // 
            this.rbLab.AutoSize = true;
            this.rbLab.Location = new System.Drawing.Point(193, 19);
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
            this.groupBox1.Controls.Add(this.rbInjection);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Controls.Add(this.rbCheckup);
            this.groupBox1.Controls.Add(this.rbLab);
            this.groupBox1.Location = new System.Drawing.Point(14, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Token Type:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsPrint,
            this.tsPreview});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(301, 25);
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
            this.label3.TabIndex = 0;
            this.label3.Text = "F&rom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "T&o";
            // 
            // txtFromToken
            // 
            this.txtFromToken.Location = new System.Drawing.Point(43, 42);
            this.txtFromToken.Name = "txtFromToken";
            this.txtFromToken.Size = new System.Drawing.Size(89, 20);
            this.txtFromToken.TabIndex = 1;
            // 
            // txtToToken
            // 
            this.txtToToken.Location = new System.Drawing.Point(161, 41);
            this.txtToToken.Name = "txtToToken";
            this.txtToToken.Size = new System.Drawing.Size(89, 20);
            this.txtToToken.TabIndex = 3;
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.dtpFrom);
            this.gbDateRange.Controls.Add(this.dtpTo);
            this.gbDateRange.Controls.Add(this.label1);
            this.gbDateRange.Controls.Add(this.label2);
            this.gbDateRange.Location = new System.Drawing.Point(14, 28);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(266, 53);
            this.gbDateRange.TabIndex = 0;
            this.gbDateRange.TabStop = false;
            this.gbDateRange.Text = "Date Range:";
            // 
            // gbTokenRange
            // 
            this.gbTokenRange.Controls.Add(this.txtFromToken);
            this.gbTokenRange.Controls.Add(this.rbAllToken);
            this.gbTokenRange.Controls.Add(this.label3);
            this.gbTokenRange.Controls.Add(this.rbRange);
            this.gbTokenRange.Controls.Add(this.txtToToken);
            this.gbTokenRange.Controls.Add(this.label4);
            this.gbTokenRange.Location = new System.Drawing.Point(14, 87);
            this.gbTokenRange.Name = "gbTokenRange";
            this.gbTokenRange.Size = new System.Drawing.Size(266, 69);
            this.gbTokenRange.TabIndex = 1;
            this.gbTokenRange.TabStop = false;
            this.gbTokenRange.Text = "Token Range:";
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
            // FrmTokenSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 222);
            this.Controls.Add(this.gbTokenRange);
            this.Controls.Add(this.gbDateRange);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTokenSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Token Summary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbDateRange.ResumeLayout(false);
            this.gbDateRange.PerformLayout();
            this.gbTokenRange.ResumeLayout(false);
            this.gbTokenRange.PerformLayout();
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
    }
}