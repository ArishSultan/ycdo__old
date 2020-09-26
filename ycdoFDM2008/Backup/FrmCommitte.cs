using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using BLL;
using FDM.SearchForms;
namespace FDM
{
    public partial class FrmCommitte : Form
    {
        public FrmCommitte()
        {
            InitializeComponent();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearControls()
        {
            txtCommitte.Text = "";
            txtid.Text = "";
            frm.CurrentCommitte = null;
            txtCommitte.Focus();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        Committe c = new Committe();
        private void tsSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCommitte.Text.Length > 0)
                {
                    c = new Committe();
                    c.CommitteName = this.txtCommitte.Text.Trim();
                    if (frm.CurrentCommitte != null)
                    {
                        c.CommitteID = frm.CurrentCommitte.CommitteID;
                    }
                    if (new CommitteBLL().SaveCommitte(c))
                    {
                        MessageBox.Show("Committe Saved Successfully", "Success");
                        ClearControls();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        SchCommitte frm = new SchCommitte();
        private void tsEdit_Click(object sender, EventArgs e)
        {

            frm.ShowDialog();
            if (frm.CurrentCommitte != null)
            {
                this.txtCommitte.Text = frm.CurrentCommitte.CommitteName;
                this.txtid.Text = frm.CurrentCommitte.CommitteID.ToString();

            }
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (frm.CurrentCommitte != null)
            {
                c.CommitteID = frm.CurrentCommitte.CommitteID;
                if (new CommitteBLL().DeleteCommitte(c) == true)
                {
                    if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                        MessageBox.Show("Committe Deleted Successfully", "Message");

                    ClearControls();
                }
                else
                    ClearControls();
            }
        }

        private void FrmCommitte_Load(object sender, EventArgs e)
        {
            ClearControls();
        }

    }
}
