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
    public partial class FrmGrd : Form
    {
        public FrmGrd()
        {
            InitializeComponent();
        }
        List<City> cities;

        private void FormateGrid()
        {
            if (GRD.DataSource != null)
            {
                GRD.Columns["CityName"].HeaderText = "City";
            }
            this.GRD.Columns["Cityid"].Visible = false;
            
        }

        private void FrmGrd_Load(object sender, EventArgs e)
        {
            cities = new CityBLL().GetCity();
            GRD.DataSource = cities;
            
            FormateGrid();

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtCity.Text.Trim().ToLower();
            var qry = (from c in cities
                       where c.CityName.ToLower().StartsWith(searchValue)
                       select c).ToList();


           
            GRD.DataSource = qry;
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public City Currentcity { get; set; }
        private void tsSelect_Click(object sender, EventArgs e)
        {
            this.Currentcity = cities[GRD.CurrentRow.Index];
            this.Close();
        }

    }
}
