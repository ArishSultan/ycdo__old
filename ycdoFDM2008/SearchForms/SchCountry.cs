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

namespace FDM.SearchForms
{
    public partial class SchCountry : Form
    {
        public SchCountry()
        {
            InitializeComponent();
        }
        List<Country> country;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadGrid()
        {
            country = new CountryBLL().GetCountry();
            DGVCountry.DataSource = null;
            DGVCountry.DataSource = country;
            FormateGrid();
        }
        public void FormateGrid()
        {
            if (DGVCountry.DataSource != null)
            {
                DGVCountry.Columns["Countryid"].Visible = false;
                DGVCountry.Columns["CountryName"].Width = 150;
            }
        
        }

        private void SchCountry_Load(object sender, EventArgs e)
        {
            LoadGrid();
            FormateGrid();
            txtSearchCountry.Focus();
        }

        private void txtSearchCountry_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchCountry.Text.Trim().ToLower();
            var qry = (from c in country
                       where c.CountryName.ToLower().StartsWith(SearchValue)
                       select c).ToList();
            DGVCountry.DataSource = qry;
        }

        public Country CurrentCountry { get; set; }
        private void tsSelect_Click(object sender, EventArgs e)
        {
            if (DGVCountry.CurrentRow != null)
            {
                if (DGVCountry.CurrentRow.Cells["Countryid"].Value != null)
                {
                    int iID = Convert.ToInt32(DGVCountry.CurrentRow.Cells["Countryid"].Value);
                    this.CurrentCountry = country[DGVCountry.CurrentRow.Index];
                }
            }
            this.Close();
        }

        private void DGVCountry_DoubleClick(object sender, EventArgs e)
        {
            this.CurrentCountry = country[DGVCountry.CurrentRow.Index];
            this.Close();
        }


    }
}
