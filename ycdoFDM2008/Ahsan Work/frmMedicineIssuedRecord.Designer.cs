namespace FDM
{
    partial class frmMedicineIssuedRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicineIssuedRecord));
            this.lblToken = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.txtPatientDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblPatientRegistrationNumber = new System.Windows.Forms.Label();
            this.gbLabTest = new System.Windows.Forms.GroupBox();
            this.lstLabTest = new System.Windows.Forms.ListBox();
            this.lblReg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.gbLabTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToken.Location = new System.Drawing.Point(16, 50);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(150, 24);
            this.lblToken.TabIndex = 12;
            this.lblToken.Text = "Token Number";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(547, 25);
            this.toolStrip1.TabIndex = 11;
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
            // txtPatientDetails
            // 
            this.txtPatientDetails.BackColor = System.Drawing.Color.White;
            this.txtPatientDetails.Location = new System.Drawing.Point(15, 174);
            this.txtPatientDetails.Multiline = true;
            this.txtPatientDetails.Name = "txtPatientDetails";
            this.txtPatientDetails.ReadOnly = true;
            this.txtPatientDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPatientDetails.Size = new System.Drawing.Size(526, 101);
            this.txtPatientDetails.TabIndex = 18;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(12, 161);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(80, 13);
            this.lblDetails.TabIndex = 17;
            this.lblDetails.Text = "Patient Details:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.White;
            this.txtPatientName.Location = new System.Drawing.Point(15, 135);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(265, 20);
            this.txtPatientName.TabIndex = 16;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(12, 122);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(75, 13);
            this.lblPatientName.TabIndex = 15;
            this.lblPatientName.Text = "Patient Name:";
            // 
            // txtPatientRegistrationNumber
            // 
            this.txtPatientRegistrationNumber.BackColor = System.Drawing.Color.White;
            this.txtPatientRegistrationNumber.Location = new System.Drawing.Point(15, 95);
            this.txtPatientRegistrationNumber.Name = "txtPatientRegistrationNumber";
            this.txtPatientRegistrationNumber.ReadOnly = true;
            this.txtPatientRegistrationNumber.Size = new System.Drawing.Size(265, 20);
            this.txtPatientRegistrationNumber.TabIndex = 14;
            // 
            // lblPatientRegistrationNumber
            // 
            this.lblPatientRegistrationNumber.AutoSize = true;
            this.lblPatientRegistrationNumber.Location = new System.Drawing.Point(12, 80);
            this.lblPatientRegistrationNumber.Name = "lblPatientRegistrationNumber";
            this.lblPatientRegistrationNumber.Size = new System.Drawing.Size(117, 13);
            this.lblPatientRegistrationNumber.TabIndex = 13;
            this.lblPatientRegistrationNumber.Text = "Patient Registration #:";
            // 
            // gbLabTest
            // 
            this.gbLabTest.Controls.Add(this.lstLabTest);
            this.gbLabTest.Location = new System.Drawing.Point(15, 281);
            this.gbLabTest.Name = "gbLabTest";
            this.gbLabTest.Size = new System.Drawing.Size(526, 112);
            this.gbLabTest.TabIndex = 37;
            this.gbLabTest.TabStop = false;
            this.gbLabTest.Text = "Medicine";
            // 
            // lstLabTest
            // 
            this.lstLabTest.FormattingEnabled = true;
            this.lstLabTest.Location = new System.Drawing.Point(6, 11);
            this.lstLabTest.Name = "lstLabTest";
            this.lstLabTest.Size = new System.Drawing.Size(514, 95);
            this.lstLabTest.TabIndex = 10;
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.Location = new System.Drawing.Point(233, 50);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(153, 24);
            this.lblReg.TabIndex = 38;
            this.lblReg.Text = "Registration No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Registration No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Token Number:";
            // 
            // frmMedicineIssuedRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.gbLabTest);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtPatientDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtPatientRegistrationNumber);
            this.Controls.Add(this.lblPatientRegistrationNumber);
            this.Name = "frmMedicineIssuedRecord";
            this.Text = "Medicine Issued Record";
            this.Load += new System.EventHandler(this.frmMedicineIssuedRecord_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbLabTest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.TextBox txtPatientDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientRegistrationNumber;
        private System.Windows.Forms.Label lblPatientRegistrationNumber;
        private System.Windows.Forms.GroupBox gbLabTest;
        private System.Windows.Forms.ListBox lstLabTest;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}