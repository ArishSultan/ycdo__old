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
        }

        private void LoadCities()
        {
            this.dgvCities.Rows.Clear();
            foreach (City c in cities)
            {
                object[] values = { c.CityName };
                this.dgvCities.Rows.Add(values);
            }
        }
        public City CurrentCity { get; set; }
        private void tsSelect_Click(object sender, EventArgs e)
        {
            this.CurrentCity = cities[this.dgvCities.CurrentRow.Index];
            this.Close();
        }

        private void dgvCities_DoubleClick(object sender, EventArgs e)
        {
            this.CurrentCity = cities[this.dgvCities.CurrentRow.Index];
            this.Close();
        }
    }
}
