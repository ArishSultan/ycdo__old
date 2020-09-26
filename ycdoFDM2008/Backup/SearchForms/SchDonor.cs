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
    public partial class SchDonor : Form
    {
        public SchDonor()
        {
            InitializeComponent();
        }
        List<Donor> members;
        Donor d;
        private void SchMembership_Load(object sender, EventArgs e)
        {
            Membership m = new Membership();

            members = new DonorBLL().GetDonorData();
             LoadData();

        }

        private void LoadData()
        {
            this.dgvMembership.Rows.Clear();
            foreach (Donor m in members)
            {
                object[] values = { m.DonorName, m.DonorFee, m.branch.BranchName, m.NIC, m.FundType, m.DonorNo };
                this.dgvMembership.Rows.Add(values);

            }

        }
        public Donor CurrentDonor { get; set; }

        private void tsSelect_Click(object sender, EventArgs e)
        {
            this.CurrentDonor = members[dgvMembership.CurrentRow.Index];
            this.Close();
        }

        private void dgvMembership_DoubleClick(object sender, EventArgs e)
        {
            this.CurrentDonor = members[dgvMembership.CurrentRow.Index];
            this.Close();

        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.CurrentDonor = null;
            this.Close();
        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {
            //var searchValue = txtMemberName.Text.Trim();
            //var qry = (from p in members
            //           where p.DonorName.StartsWith(searchValue)
            //           select p).ToList();
           
            
           
            //dgvMembership.DataSource = qry;
        }

      


    }
}
