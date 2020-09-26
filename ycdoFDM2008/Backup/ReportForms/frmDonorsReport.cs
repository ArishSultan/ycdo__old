using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using FDM.Reports;
using BLL;

namespace FDM.ReportForms
{
    public partial class frmDonorsReport : Form
    {
        public frmDonorsReport()
        {
            InitializeComponent();
        }
        List<Branch> branchs;
        private void frmDonorsReport_Load(object sender, EventArgs e)
        {
            branchs = new BranchBLL().GetBranchData();
            cbxbranches.DataSource = branchs;
            cbxbranches.DisplayMember = "BranchName";
        }
    }
}
