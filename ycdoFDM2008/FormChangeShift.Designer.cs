namespace FDM
{
    partial class FormChangeShift
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
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblShift = new System.Windows.Forms.Label();
            this.cbxShift = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(91, 117);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(121, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Set Active";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(91, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(39, 40);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(81, 13);
            this.lblShift.TabIndex = 7;
            this.lblShift.Text = "Currently Acitve";
            // 
            // cbxShift
            // 
            this.cbxShift.FormattingEnabled = true;
            this.cbxShift.Location = new System.Drawing.Point(91, 81);
            this.cbxShift.Name = "cbxShift";
            this.cbxShift.Size = new System.Drawing.Size(121, 21);
            this.cbxShift.TabIndex = 8;
            // 
            // FormChangeShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 241);
            this.Controls.Add(this.cbxShift);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChange);
            this.Name = "FormChangeShift";
            this.Text = "Change Shift";
            this.Load += new System.EventHandler(this.FormChangeShift_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.ComboBox cbxShift;
    }
}