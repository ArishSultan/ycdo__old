using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FDM.SearchForms
{
    public partial class FrmResult : Form
    {
        public FrmResult()
        {
            InitializeComponent();
        }

        private void FrmResult_Load(object sender, EventArgs e)
        {

        }

        private void Btnselect_Click(object sender, EventArgs e)
        {
            FrmGrd frm = new FrmGrd();
            frm.ShowDialog();
            if (frm.Currentcity != null)
            {
               
                txtcityid.Text = frm.Currentcity.CityID.ToString();
                txtCityname.Text = frm.Currentcity.CityName;
            }
            }

        
    }
}
