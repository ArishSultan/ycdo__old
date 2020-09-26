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
    public partial class frmSchDiagnosis : Form
    {
        public frmSchDiagnosis()
        {
            InitializeComponent();
        }


   public     List<Diagnosis> Diagnosis;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.CurrentDiagnosis = null;
            this.Close();
        }

        public void LoadGrid()
        {
            Diagnosis = new DiagnosisBLL().GetDiagnosis();
            DGVCounsil.DataSource = null;
            DGVCounsil.DataSource = Diagnosis;
            FormateGrid();
        }
        public void FormateGrid()
        {
            if (DGVCounsil.DataSource != null)
            {
                DGVCounsil.Columns["Code"].Visible = false;
                DGVCounsil.Columns["Name"].Width = 150;
               
            }

        }


        public Diagnosis CurrentDiagnosis { get; set; }
        private void tsSelect_Click(object sender, EventArgs e)
        {
            if (DGVCounsil.CurrentRow != null)
            {
                if (DGVCounsil.CurrentRow.Cells["Code"].Value != null)
                {
                    int ID = Convert.ToInt32(DGVCounsil.CurrentRow.Cells["Code"].Value);
                    this.CurrentDiagnosis = ((Diagnosis)Diagnosis.Where(c => c.Code == ID).Single<Diagnosis>());
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
            var qry = (from c in Diagnosis
                       where c.Name.ToLower().Contains(SearchValue)
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
