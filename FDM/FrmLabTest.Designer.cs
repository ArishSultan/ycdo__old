namespace FDM
{
    partial class FrmLabTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLabTest));
            this.txtReport = new System.Windows.Forms.TextBox();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.txtPerformed = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.GrdMain = new System.Windows.Forms.DataGridView();
            this.txtGeneral = new System.Windows.Forms.TextBox();
            this.txtPoor = new System.Windows.Forms.TextBox();
            this.txtYCDO = new System.Windows.Forms.TextBox();
            this.txtDeserving = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(358, 34);
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(116, 20);
            this.txtReport.TabIndex = 30;
            this.txtReport.TextChanged += new System.EventHandler(this.MakeCondition);
            // 
            // txtSample
            // 
            this.txtSample.Location = new System.Drawing.Point(159, 34);
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(101, 20);
            this.txtSample.TabIndex = 28;
            this.txtSample.TextChanged += new System.EventHandler(this.MakeCondition);
            // 
            // txtPerformed
            // 
            this.txtPerformed.Location = new System.Drawing.Point(260, 34);
            this.txtPerformed.Name = "txtPerformed";
            this.txtPerformed.Size = new System.Drawing.Size(98, 20);
            this.txtPerformed.TabIndex = 29;
            this.txtPerformed.TextChanged += new System.EventHandler(this.MakeCondition);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(57, 34);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(102, 20);
            this.txtTest.TabIndex = 27;
            this.txtTest.TextChanged += new System.EventHandler(this.MakeCondition);
            // 
            // GrdMain
            // 
            this.GrdMain.AllowUserToAddRows = false;
            this.GrdMain.AllowUserToDeleteRows = false;
            this.GrdMain.AllowUserToResizeColumns = false;
            this.GrdMain.AllowUserToResizeRows = false;
            this.GrdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdMain.Location = new System.Drawing.Point(5, 58);
            this.GrdMain.MultiSelect = false;
            this.GrdMain.Name = "GrdMain";
            this.GrdMain.RowHeadersVisible = false;
            this.GrdMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GrdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GrdMain.Size = new System.Drawing.Size(690, 436);
            this.GrdMain.TabIndex = 31;
            // 
            // txtGeneral
            // 
            this.txtGeneral.Location = new System.Drawing.Point(631, 34);
            this.txtGeneral.Name = "txtGeneral";
            this.txtGeneral.Size = new System.Drawing.Size(50, 20);
            this.txtGeneral.TabIndex = 35;
            this.txtGeneral.TextChanged += new System.EventHandler(this.MakeCondition);
            // 
            // txtPoor
            // 
            this.txtPoor.Location = new System.Drawing.Point(528, 34);
            this.txtPoor.Name = "txtPoor";
            this.txtPoor.Size = new System.Drawing.Size(53, 20);
            this.txtPoor.TabIndex = 33;
            this.txtPoor.TextChanged += new System.EventHandler(this.MakeCondition);
            // 
            // txtYCDO
            // 
            this.txtYCDO.Location = new System.Drawing.Point(581, 34);
            this.txtYCDO.Name = "txtYCDO";
            this.txtYCDO.Size = new System.Drawing.Size(50, 20);
            this.txtYCDO.TabIndex = 34;
            this.txtYCDO.TextChanged += new System.EventHandler(this.MakeCondition);
            // 
            // txtDeserving
            // 
            this.txtDeserving.Location = new System.Drawing.Point(474, 34);
            this.txtDeserving.Name = "txtDeserving";
            this.txtDeserving.Size = new System.Drawing.Size(54, 20);
            this.txtDeserving.TabIndex = 32;
            this.txtDeserving.TextChanged += new System.EventHandler(this.MakeCondition);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsNew,
            this.tsSave,
            this.tsDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(695, 25);
            this.toolStrip1.TabIndex = 36;
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
            this.tsNew.Visible = false;
            // 
            // tsSave
            // 
            this.tsSave.Image = ((System.Drawing.Image)(resources.GetObject("tsSave.Image")));
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(51, 22);
            this.tsSave.Text = "&Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsDelete.Image")));
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(58, 22);
            this.tsDelete.Text = "&Delete";
            this.tsDelete.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(5, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(52, 20);
            this.txtID.TabIndex = 37;
            this.txtID.TextChanged += new System.EventHandler(this.MakeCondition);
            // 
            // FrmLabTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 503);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtGeneral);
            this.Controls.Add(this.txtPoor);
            this.Controls.Add(this.txtYCDO);
            this.Controls.Add(this.txtDeserving);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.txtSample);
            this.Controls.Add(this.txtPerformed);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.GrdMain);
            this.Name = "FrmLabTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Tests";
            this.Load += new System.EventHandler(this.FrmLabTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdMain)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.TextBox txtPerformed;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.DataGridView GrdMain;
        private System.Windows.Forms.TextBox txtGeneral;
        private System.Windows.Forms.TextBox txtPoor;
        private System.Windows.Forms.TextBox txtYCDO;
        private System.Windows.Forms.TextBox txtDeserving;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.TextBox txtID;
    }
}