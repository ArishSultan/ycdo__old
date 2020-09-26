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
using FDM.ReportForms;
using Common.Datasets;
using FDM.Reports;


namespace FDM.ReportForms
{
    public partial class FrmDonationsSummary : Form
    {
        public FrmDonationsSummary()
        {
            InitializeComponent();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsPreview_Click(object sender, EventArgs e)
        {
            PrintPreview(true);
        }

        Branch br = new Branch();
        MemberCollection mem = new MemberCollection();


        rptMembersCollection crp = new rptMembersCollection();
        DSMemberCollection ds = new DSMemberCollection();
        private void PrintPreview(bool Privew)
        {

            string fromdate = "";
            string todate = "";

            fromdate = dtpFromDate.Value.Date.ToString();
            todate = dtpToDate.Value.Date.ToString();
            mem.MemberName = cbxMemberName.Text.Trim();

            ds = new MembershipBLL().GetMemberCollectionData(mem, fromdate, todate);
            crp.SetDataSource(ds);
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;

            if (Privew)
                frmViewer.ShowDialog();
            else
            {
                frmViewer.crystalReportViewer1.RefreshReport();
                frmViewer.crystalReportViewer1.PrintReport();
            }

        }

        List<Membership> members;
        private void FrmMembershipReport_Load(object sender, EventArgs e)
        {
            members = new MembershipBLL().GetMembershipData();
            cbxMemberName.DataSource = members;
            cbxMemberName.DisplayMember = "MemberName";
            //  ClearControll();
            rbMember.Checked = true;


        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            PrintPreview(false);
        }

        private void tsClear_Click(object sender, EventArgs e)
        {
            cbxMemberName.SelectedIndex = -1;
            cbxMemberName.Text = "";
            //  rbCityName.Checked = false;
            //   rbMembers.Checked = false;
            //    rbAll.Checked = true;
            PrintPreview(true);
        }
        List<Branch> branches;
        private void rbBranchName_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbCityName.Checked == false)
            //{
            //    branches = new BranchBLL().GetBranchData();
            //    cbxMemberName.DataSource = branches;
            //    cbxMemberName.DisplayMember = "BranchName";
            //}
        }
        List<City> cities;
        private void rbCityName_CheckedChanged(object sender, EventArgs e)
        {
            //    if (rbMembers.Checked == false)
            //    {
            //        cities = new CityBLL().GetCity();
            //        cbxMemberName.DataSource = cities;
            //        cbxMemberName.DisplayMember = "CityName";
            //    }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
