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
    public partial class SchCity : Form
    {
        public SchCity()
        {
            InitializeComponent();
        }
        List<City> cities;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.CurrentCity= null;
            this.Close();
        }

        private void SchCity_Load(object sender, EventArgs e)
        {
            City c = new City();
           
            cities = new CityBLL().GetCity();
            LoadCities();
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void LoadCities()
        {
            this.dgvCities.Rows.Clear();
            foreach (City c in cities)
            {
                object[] values = { c.CityName,c.CityID };
                this.dgvCities.Rows.Add(values);
            }
        }
        public City CurrentCity { get; set; }
        private void tsSelect_Click(object sender, EventArgs e)
        {
            if (dgvCities.CurrentRow != null)
            {
                if (dgvCities.CurrentRow.Cells["ID"].Value != null)
                {
                    int ID = Convert.ToInt32(dgvCities.CurrentRow.Cells["ID"].Value);
                    this.CurrentCity = ((City)cities.Where(c => c.CityID == ID).Single<City>());
                }
            }
            this.Close();
        }

        private void dgvCities_DoubleClick(object sender, EventArgs e)
        {
            tsSelect_Click(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string Text = txtSearch.Text.ToString().ToLower().Trim();
            var Qry = from p in cities
                      where
                          p.CityName.ToLower().ToString().StartsWith(Text)
                      select p;
            this.dgvCities.Rows.Clear();
            foreach (City c in Qry)
            {
                object[] values = { c.CityName, c.CityID };
                this.dgvCities.Rows.Add(values);
            }
        }

       
    }
}
