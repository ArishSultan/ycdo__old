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
    public partial class SchCounsil : Form
    {
        public SchCounsil()
        {
            InitializeComponent();
        }
        List<Counsil> Counsil;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.CurrentCounsil = null;
            this.Close();
        }

        public void LoadGrid()
        {
            Counsil = new CounsilBLL().GetCounsil();
            DGVCounsil.DataSource = null;
            DGVCounsil.DataSource = Counsil;
            FormateGrid();
        }
        public void FormateGrid()
        {
            if (DGVCounsil.DataSource != null)
            {
                DGVCounsil.Columns["Counsilid"].Visible = false;
                DGVCounsil.Columns["CounsilName"].Width = 150;
            }

        }

      
        public Counsil CurrentCounsil { get; set; }
        private void tsSelect_Click(object sender, EventArgs e)
        {
            if (DGVCounsil.CurrentRow != null)
            {
                if (DGVCounsil.CurrentRow.Cells["CounsilID"].Value != null)
                {
                    int ID = Convert.ToInt32(DGVCounsil.CurrentRow.Cells["CounsilID"].Value);
                    this.CurrentCounsil = ((Counsil)Counsil.Where(c => c.CounsilID == ID).Single<Counsil>());
                }
            }
            this.Close();
        }

        private void DGVCounsil_DoubleClick(object sender, EventArgs e)
        {
            tsSelect_Click(sender, e);
        }

       

        private void txtSearchCounsil_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchCounsil.Text.ToString().Trim().ToLower();
            var qry = (from c in Counsil
                       where c.CounsilName.ToLower().StartsWith(SearchValue)
                       select c).ToList();
            DGVCounsil.DataSource = qry;
        }

        private void SchCounsil_Load_1(object sender, EventArgs e)
        {

            LoadGrid();
            FormateGrid();
            txtSearchCounsil.Clear();
            txtSearchCounsil.Focus();
        }


       

      


    }
}
