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
    public partial class SchBranch : Form
    {
        public SchBranch()
        {
            InitializeComponent();
        }
        List<Branch> branch;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.CurrentBranch = null;
            this.Close();
        }

        private void SchBranch_Load(object sender, EventArgs e)
        {
            Branch br = new Branch();
            branch = new BranchBLL().GetBranchData();
            LoadBranch();
            txtBranchCode.Text = "";
            txtBranchName.Text = "";
            txtCityName.Text = "";
            txtPhoneNumber.Text = "";
            txtBranchCode.Focus();
        }

        private void LoadBranch()
        {
            this.dgvBranch.Rows.Clear();
            foreach (Branch b in branch)
            {
                //object[] values = { b.BranchCode, b.BranchName, b.City.CityName, b.Phone, b.BranchID };
                object[] values = { b.BranchCode, b.BranchName, b.City.CityName, b.Phone, b.BranchID, b.IsActive };
                this.dgvBranch.Rows.Add(values);
            }
        }
        public Branch CurrentBranch { get; set; }
        private void tsSelect_Click(object sender, EventArgs e)
        {
            if (dgvBranch.CurrentRow != null)
            {
                if (dgvBranch.CurrentRow.Cells["ID"].Value != null)
                {
                    int ID = Convert.ToInt32(dgvBranch.CurrentRow.Cells["ID"].Value);
                    this.CurrentBranch = ((Branch)branch.Where(b => b.BranchID == ID).Single<Branch>());
                }
            }
            this.Close();
        }

        private void dgvBranch_DoubleClick(object sender, EventArgs e)
        {
            tsSelect_Click(sender, e);
        }

        private void txtBranchCode_TextChanged(object sender, EventArgs e)
        {
            string Text = txtBranchCode.Text.ToString().Trim();
            var Qry = from p in branch
                      where
                          p.BranchCode.ToString().StartsWith(Text)
                      select p;
            this.dgvBranch.Rows.Clear();
            foreach (Branch b in Qry)
            {
                object[] values = { b.BranchCode, b.BranchName, b.City.CityName, b.Phone, b.BranchID };
                this.dgvBranch.Rows.Add(values);
            }
        }

        private void txtBranchName_TextChanged(object sender, EventArgs e)
        {
            string Text = txtBranchName.Text.ToLower().ToString().Trim();
            var Qry = from p in branch
                      where
                          p.BranchName.ToString().StartsWith(Text)
                      select p;
            this.dgvBranch.Rows.Clear();
            foreach (Branch b in Qry)
            {
                object[] values = { b.BranchCode, b.BranchName, b.City.CityName, b.Phone, b.BranchID };
                this.dgvBranch.Rows.Add(values);
            }
        }

        private void txtCityName_TextChanged(object sender, EventArgs e)
        {
            string Text = txtCityName.Text.ToLower().ToString().Trim();
            var Qry = from p in branch
                      where
                      p.City.CityName.ToLower().ToString().StartsWith(Text)
                      select p;
            this.dgvBranch.Rows.Clear();
            foreach (Branch b in Qry)
            {
                object[] values = { b.BranchCode, b.BranchName, b.City.CityName, b.Phone, b.BranchID };
                this.dgvBranch.Rows.Add(values);
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string Text = txtPhoneNumber.Text.ToLower().ToString().Trim();
            var Qry = from p in branch
                      where
                          p.Phone.ToString().StartsWith(Text)
                      select p;
            this.dgvBranch.Rows.Clear();
            foreach (Branch b in Qry)
            {
                object[] values = { b.BranchCode, b.BranchName, b.City.CityName, b.Phone, b.BranchID };
                this.dgvBranch.Rows.Add(values);
            }
        }

       
    }
}
