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
    public partial class SchPerformance : Form
    {
        public SchPerformance()
        {
            InitializeComponent();
        }
        List<Performance> performance;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Currentperformance = null;
            this.Close();
            
        }

        public void LoadGrid()
        {
            performance = new PerformanceBLL().GetPerformance();
            DGVCountry.DataSource = null;
            DGVCountry.DataSource = performance;
            FormateGrid();
        }
        public void FormateGrid()
        {
            if (DGVCountry.DataSource != null)
            {
                DGVCountry.Columns["Performanceid"].Visible = false;
                DGVCountry.Columns["MemberName"].Width = 150;
            }

        }

        private void SchCountry_Load(object sender, EventArgs e)
        {
            LoadGrid();
            txtSearchCountry.Clear();
            txtSearchCountry.Focus();
        }

        private void txtSearchCountry_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchCountry.Text.Trim().ToLower();
            var qry = (from c in performance
                       where c.MemberName.ToLower().StartsWith(SearchValue)
                       select c).ToList();
            DGVCountry.DataSource = qry;
        }

        public Performance Currentperformance { get; set; }
        private void tsSelect_Click(object sender, EventArgs e)
        {
            if (DGVCountry.CurrentRow != null)
            {
                if (DGVCountry.CurrentRow.Cells["Performanceid"].Value != null)
                {
                    int ID = Convert.ToInt32(DGVCountry.CurrentRow.Cells["Performanceid"].Value);
                    this.Currentperformance = ((Performance)performance.Where(p => p.PerformanceID == ID).Single<Performance>());
                }
            }
            this.Close();
        }

        private void DGVCountry_DoubleClick(object sender, EventArgs e)
        {
            tsSelect_Click(sender, e);
        }


    }
}
