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
    public partial class SchMembership : Form
    {
        public SchMembership()
        {
            InitializeComponent();
        }
        List<Membership> members;
        private void SchMembership_Load(object sender, EventArgs e)
        {
            Membership m=new Membership();
            
            members = new MembershipBLL().GetMembershipData();
            LoadData();

        }

        private void LoadData()
        {
            this.dgvMembership.Rows.Clear();
            foreach(Membership m in members)
            {
                object[] values = { m.MemberName, m.MembershipFee, m.branch.BranchName, m.NIC, m.MonthlyFee, m.MembershipNo };
            this.dgvMembership.Rows.Add(values);
            
            }
            
        }
        public Membership CurrentMembership { get; set; }

        private void tsSelect_Click(object sender, EventArgs e)
        {
            if(dgvMembership.CurrentRow!= null)
                if(dgvMembership.CurrentRow.Cells[0].Value  != null)
                    this.CurrentMembership = members[dgvMembership.CurrentRow.Index];
            this.Close();
        }

        private void dgvMembership_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMembership.CurrentRow != null)
                if (dgvMembership.CurrentRow.Cells[0].Value != null)
                    this.CurrentMembership = members[dgvMembership.CurrentRow.Index];
            this.Close();

        }

        private void tsClose_Click(object sender, EventArgs e)
        {
           this. CurrentMembership = null;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string Condition = this.txtMemberName.Text.Trim();
            //var selectdValues = from m in members
            //                    where m.MemberName.ToString().StartsWith(Condition)
            //                    select m;
        }


    }
}
