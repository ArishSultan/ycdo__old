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
        }

        private void LoadBranch()
        {
            this.dgvBranch.Rows.Clear();
            foreach (Branch b in branch)
            {
                object[] values = { b.BranchCode,b.BranchName,b.Phone,b.City.CityName };
                this.dgvBranch.Rows.Add(values);
            }
        }
        public Branch CurrentBranch { get; set; }
        private void tsSelect_Click(object sender, EventArgs e)
        {
            this.CurrentBranch = branch[this.dgvBranch.CurrentRow.Index];
            this.Close();
        }

        private void dgvBranch_DoubleClick(object sender, EventArgs e)
        {
            this.CurrentBranch = branch[this.dgvBranch.CurrentRow.Index];
            this.Close();
        }

       
    }
}
