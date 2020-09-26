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
    public partial class SchCommitte : Form
    {
        public SchCommitte()
        {
            InitializeComponent();
        }
        List<Committe> committe;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.CurrentCommitte = null;
            this.Close();
        }

        public void LoadGrid()
        {
            committe = new CommitteBLL().GetCommitte();
            DGVCountry.DataSource = null;
            DGVCountry.DataSource = committe;
            FormateGrid();
        }
        public void FormateGrid()
        {
            if (DGVCountry.DataSource != null)
            {
                DGVCountry.Columns["Committeid"].Visible = false;
                DGVCountry.Columns["CommitteName"].Width = 150;
            }

        }

        private void SchCountry_Load(object sender, EventArgs e)
        {
            LoadGrid();
            FormateGrid();
            txtSearchCommitte.Clear();
            txtSearchCommitte.Focus();
        }

        private void txtSearchCommitte_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchCommitte.Text.Trim().ToLower();
            var qry = (from c in committe
                       where c.CommitteName.ToLower().StartsWith(SearchValue)
                       select c).ToList();
            DGVCountry.DataSource = qry;
        }

        public Committe CurrentCommitte { get; set; }
        private void tsSelect_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(DGVCountry.CurrentRow.Cells["Committeid"].Value);
                if(DGVCountry.CurrentRow!=null)
                {
            if(DGVCountry.CurrentRow.Cells["Committeid"].Value!=null)
            {
            this.CurrentCommitte =((Committe) committe.Where(c=>c.CommitteID==ID).Single<Committe>());
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
