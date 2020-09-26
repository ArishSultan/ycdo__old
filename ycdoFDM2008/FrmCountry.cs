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
    public partial class FrmCountry : Form
    {
        public FrmCountry()
        {
            InitializeComponent();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearControls()
        {
            txtCountry.Text = "";
            txtid.Text = "";
            frm.CurrentCountry = null;
            txtCountry.Focus();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        Country c = new Country();
        private void tsSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCountry.Text.Length > 0)
                {
                    c = new Country();
                    c.CountryName = this.txtCountry.Text.Trim();
                    if (frm.CurrentCountry != null)
                    {
                        c.CountryID = frm.CurrentCountry.CountryID;
                    }
                    if (new CountryBLL().SaveCountry(c))
                    {
                        MessageBox.Show("Country Saved Successfully", "Success");
                        ClearControls();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        SchCountry frm = new SchCountry();
        private void tsEdit_Click(object sender, EventArgs e)
        {

            frm.ShowDialog();
            if (frm.CurrentCountry != null)
            {
                this.txtCountry.Text = frm.CurrentCountry.CountryName;
                this.txtid.Text = frm.CurrentCountry.CountryID.ToString();

            }
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (frm.CurrentCountry != null)
            {
                c.CountryID = frm.CurrentCountry.CountryID;
                if (new CountryBLL().DeleteCountry(c) == true)
                {
                    if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                        MessageBox.Show("Country Deleted Successfully", "Message");

                    ClearControls();
                }
                else
                    ClearControls();
            }
        }

        private void FrmCountry_Load(object sender, EventArgs e)
        {
            ClearControls();
        }

    }
}
