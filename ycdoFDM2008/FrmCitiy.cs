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
    public partial class FrmCitiy : Form
    {
        public FrmCitiy()
        {
            InitializeComponent();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearControls()
        {
            txtCity.Text = "";
            txtid.Text = "";
            frm.CurrentCity = null;
            txtCity.Focus();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        City c = new City();
        private void tsSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtCity.Text.Length > 0)
            {
                c = new City();
                c.CityName = this.txtCity.Text.Trim();
                if (frm.CurrentCity != null)
                {
                    c.CityID = frm.CurrentCity.CityID;
                }
                if (new CityBLL().SaveCity(c))
                {
                    MessageBox.Show("City Saved Successfully","Success");
                    ClearControls();
                }
            
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        SchCity frm=new SchCity();
        private void tsEdit_Click(object sender, EventArgs e)
        {
            
            frm.ShowDialog();
            if (frm.CurrentCity != null)
            {
                this.txtCity.Text = frm.CurrentCity.CityName;
                this.txtid.Text = frm.CurrentCity.CityID.ToString();
                
            }
            }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (frm.CurrentCity != null)
            {
                c.CityID = frm.CurrentCity.CityID;
                if (new CityBLL().DeleteCity(c) == true)
                {
                    if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                        MessageBox.Show("City Deleted Successfully", "Message");

                    ClearControls();
                }
                else
                    ClearControls();
            }
        }

        private void FrmCitiy_Load(object sender, EventArgs e)
        {
            ClearControls();
        }



    }
}
