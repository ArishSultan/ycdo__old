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
    public partial class SchDonorCollection : Form
    {
        public SchDonorCollection()
        {
            InitializeComponent();
        }
        List<DonorCollection> memCollection;
        List<DonorCollection> SubmemCollection;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadGrid()
        {
            memCollection = new DonorBLL().GetDonorCollectionData();
            DGVCountry.DataSource = null;
            DGVCountry.DataSource = memCollection;
            FormateGrid();
        }
        public void FormateGrid()
        {
            if (DGVCountry.DataSource != null)
            {
                DGVCountry.Columns["ID"].Visible = false;
                DGVCountry.Columns["CollectionFee"].Visible = false;
                DGVCountry.Columns["CollectionDate"].Visible = false;
                DGVCountry.Columns["Donationtype"].Visible = false;
                DGVCountry.Columns["Others"].Visible = false;
                DGVCountry.Columns["CheckDetail"].Visible = false;
                DGVCountry.Columns["DonorName"].Width = 150;
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
            SubmemCollection = new List<DonorCollection>();
            SubmemCollection = (from c in memCollection
                                where c.DonorName.ToLower().StartsWith(SearchValue)
                                select c).ToList();
            DGVCountry.DataSource = SubmemCollection;
        }

        public DonorCollection CurrentCollection { get; set; }
        private void tsSelect_Click(object sender, EventArgs e)
        {
            if (memCollection.Count == DGVCountry.Rows.Count)
            {
                this.CurrentCollection = memCollection[DGVCountry.CurrentRow.Index];
                this.Close();
            }
            else
            {
                this.CurrentCollection = SubmemCollection[DGVCountry.CurrentRow.Index];
                this.Close();
            }
        }

        private void DGVCountry_DoubleClick(object sender, EventArgs e)
        {
            if (memCollection.Count == DGVCountry.Rows.Count)
            {
                this.CurrentCollection = memCollection[DGVCountry.CurrentRow.Index];
                this.Close();
            }
            else
            {
                this.CurrentCollection = SubmemCollection[DGVCountry.CurrentRow.Index];
                this.Close();
            }
        }

        private void txtReciptNo_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchCountry.Text.Trim();
            SubmemCollection = new List<DonorCollection>();
            SubmemCollection = (from c in memCollection
                                where c.ReciptNo.ToString().StartsWith(SearchValue)
                                select c).ToList();
            DGVCountry.DataSource = SubmemCollection;
        }


    }
}
