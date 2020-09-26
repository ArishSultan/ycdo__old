namespace FDM.SearchForms
{
    partial class FrmResult
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
            this.txtcityid = new System.Windows.Forms.TextBox();
            this.txtCityname = new System.Windows.Forms.TextBox();
            this.Btnselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcityid
            // 
            this.txtcityid.Location = new System.Drawing.Point(70, 103);
            this.txtcityid.Name = "txtcityid";
            this.txtcityid.Size = new System.Drawing.Size(100, 20);
            this.txtcityid.TabIndex = 0;
            // 
            // txtCityname
            // 
            this.txtCityname.Location = new System.Drawing.Point(70, 152);
            this.txtCityname.Name = "txtCityname";
            this.txtCityname.Size = new System.Drawing.Size(100, 20);
            this.txtCityname.TabIndex = 1;
            // 
            // Btnselect
            // 
            this.Btnselect.Location = new System.Drawing.Point(79, 195);
            this.Btnselect.Name = "Btnselect";
            this.Btnselect.Size = new System.Drawing.Size(75, 23);
            this.Btnselect.TabIndex = 2;
            this.Btnselect.Text = "button1";
            this.Btnselect.UseVisualStyleBackColor = true;
            this.Btnselect.Click += new System.EventHandler(this.Btnselect_Click);
            // 
            // FrmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.Btnselect);
            this.Controls.Add(this.txtCityname);
            this.Controls.Add(this.txtcityid);
            this.Name = "FrmResult";
            this.Text = "FrmResult";
            this.Load += new System.EventHandler(this.FrmResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcityid;
        private System.Windows.Forms.TextBox txtCityname;
        private System.Windows.Forms.Button Btnselect;
    }
}