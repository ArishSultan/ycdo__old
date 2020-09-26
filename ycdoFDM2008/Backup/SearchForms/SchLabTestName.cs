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
    public partial class SchLabTestName : Form
    {
        public SchLabTestName()
        {
            InitializeComponent();
        }
        List<LabTestName> Labnames;
        List<LabTestName> SubLabnames;
        public bool IsMedicine;
        public bool IsTenInjection;
        public bool IsAlwaysPaid;
        public bool IsOd;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadGrid()
        {
            Labnames = new LabTestNameBLL().GetLAbTestName();
            if (IsMedicine)
            {
                if (IsOd == true)
                    Labnames = Labnames.Where(od => od.IsOd == true).ToList<LabTestName>();
                if (IsTenInjection == true )
                {
                    SubLabnames = Labnames.Where(ln => ln.IsMedicine == true && ln.IsRsTenInjection ==true ).ToList<LabTestName>();
                }
               
                else if (IsAlwaysPaid == true )
                {
                    SubLabnames = Labnames.Where(ln => ln.IsMedicine == true && ln.IsAlwaysPaid == true ).ToList<LabTestName>();
                }                                 
                else
                    SubLabnames = Labnames.Where(ln => ln.IsMedicine == true ).ToList<LabTestName>();
            }
            else
                SubLabnames = Labnames.Where(ln => ln.IsMedicine == false).ToList<LabTestName>();

            Labnames = null;
            Labnames = SubLabnames;

            DGVCountry.DataSource = null;
            DGVCountry.DataSource = Labnames;
            FormateGrid();
        }
        public void FormateGrid()
        {
            if (DGVCountry.DataSource != null)
            {
                DGVCountry.Columns["ID"].Visible = false;
                DGVCountry.Columns["TestName"].Width = 250;
                DGVCountry.Columns["Sample"].Visible = false;
                DGVCountry.Columns["Performed"].Visible = false;
                DGVCountry.Columns["Report"].Visible = false;
                DGVCountry.Columns["Deserving"].Visible = false;
                DGVCountry.Columns["Poor"].Visible = false;
                DGVCountry.Columns["YCDO"].Visible = false;
                DGVCountry.Columns["General"].Visible = false;
                DGVCountry.Columns["Shahab"].Visible = false;
                DGVCountry.Columns["Ghori"].Visible = false;
                DGVCountry.Columns["IsMedicine"].Visible = false;
                DGVCountry.Columns["OpeningQty"].Visible = false;
                DGVCountry.Columns["IsRsTenInjection"].Visible = false;
                DGVCountry.Columns["IsAlwaysPaid"].Visible = false;
                DGVCountry.Columns["IsOd"].Visible = false;
            }

        }

        private void SchCountry_Load(object sender, EventArgs e)
        {
            LoadGrid();
            FormateGrid();
            txtSearchCountry.Text="";
            txtSearchCountry.Focus();
        }

        private void txtSearchCountry_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchCountry.Text.Trim().ToLower();
            SubLabnames = new List<LabTestName>();
            SubLabnames = (from c in Labnames
                       where c.TestName.ToLower().StartsWith(SearchValue)
                       select c).ToList();
            DGVCountry.DataSource = SubLabnames;
        }

        public LabTestName CurrentLabName { get; set; }
        private void tsSelect_Click(object sender, EventArgs e)
        {
            if (DGVCountry.CurrentRow != null)
                if (DGVCountry.CurrentRow.Cells[0].Value != null)
                {
                    if (SubLabnames != null)
                        this.CurrentLabName = SubLabnames [DGVCountry.CurrentRow.Index];
                    else
                        this.CurrentLabName = Labnames[DGVCountry.CurrentRow.Index];
                }
            this.Close();
            
        }

        private void DGVCountry_DoubleClick(object sender, EventArgs e)
        {
            if (DGVCountry.CurrentRow != null)
                if (DGVCountry.CurrentRow.Cells[0].Value != null)
                {
                    if (SubLabnames!= null)
                        this.CurrentLabName = SubLabnames[DGVCountry.CurrentRow.Index];
                    else
                        this.CurrentLabName = Labnames[DGVCountry.CurrentRow.Index];
                }
            this.Close();
        }

        private void DGVCountry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
