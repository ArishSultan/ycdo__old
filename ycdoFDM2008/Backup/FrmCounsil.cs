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
    public partial class FrmCounsil : Form
    {
        public FrmCounsil()
        {
            InitializeComponent();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearControls()
        {
            txtCounsil.Text = "";
            txtid.Text = "";
            frm.CurrentCounsil = null;
            txtCounsil.Focus();
        }
        private void tsNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        Counsil c = new Counsil();
        private void tsSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCounsil.Text.Length > 0)
                {
                    c = new Counsil();
                    c.CounsilName = this.txtCounsil.Text.Trim();
                    if (frm.CurrentCounsil != null)
                    {
                        c.CounsilID = frm.CurrentCounsil.CounsilID;
                    }
                    if (new CounsilBLL().SaveCounsil(c))
                    {
                        MessageBox.Show("Counsil Saved Successfully", "Success");
                        ClearControls();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        SchCounsil frm = new SchCounsil();
        private void tsEdit_Click(object sender, EventArgs e)
        {

            frm.ShowDialog();
            if (frm.CurrentCounsil != null)
            {
                this.txtCounsil.Text = frm.CurrentCounsil.CounsilName;
                this.txtid.Text = frm.CurrentCounsil.CounsilID.ToString();

            }
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (frm.CurrentCounsil != null)
            {
                c.CounsilID = frm.CurrentCounsil.CounsilID;
                if (new CounsilBLL().DeleteCounsil(c) == true)
                {
                    if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                        MessageBox.Show("Counsil Deleted Successfully", "Message");

                    ClearControls();
                }
                else
                    ClearControls();
            }
        }

        private void FrmCounsil_Load(object sender, EventArgs e)
        {
            ClearControls();
        }

    }
}
