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
    public partial class FrmDonorReport : Form
    {
        public FrmDonorReport()
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
        Donor d = new Donor();


        rptDonorsData crp = new rptDonorsData();
        DSDonor ds = new DSDonor();
        private void PrintPreview(bool Privew)
        {


            if (rbCityName.Checked == false && rbAll.Checked == false)
            {
                d.branch.BranchName = cbxbranches.Text.Trim();
            }
            if (rbBranchName.Checked == false && rbAll.Checked == false)
            {
                d.City.CityName = cbxbranches.Text.Trim();
            }
            if (rbCityName.Checked == false && rbBranchName.Checked == false)
                rbAll.Checked = true;
            //ds = new DonorBLL().GetData(d, rbBranchName.Checked, rbCityName.Checked, rbAll.Checked);
            ds = new DonorBLL().GetData(d, rbBranchName.Checked, rbCityName.Checked, rbAll.Checked, true, dtpFrom.Value.Date.ToString(), dtpTo.Value.Date.ToString(), true);
            //crp.SetDataSource(ds);
            FrmReportViewer frmViewer = new FrmReportViewer();
            //frmViewer.crystalReportViewer1.ReportSource = crp;

            if (Privew)
                frmViewer.ShowDialog();
            else
            {
                //frmViewer.crystalReportViewer1.RefreshReport();
                //frmViewer.crystalReportViewer1.PrintReport();
            }

        }


        private void FrmMembershipReport_Load(object sender, EventArgs e)
        {

            rbBranchName.Checked = true;


        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            PrintPreview(false);
        }

        private void tsClear_Click(object sender, EventArgs e)
        {
            cbxbranches.Text = "";
            rbCityName.Checked = false;
            rbBranchName.Checked = false;
            rbAll.Checked = true;
            PrintPreview(true);
        }
        List<Branch> branches;
        private void rbBranchName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCityName.Checked == false)
            {
                branches = new BranchBLL().GetBranchData();
                cbxbranches.DataSource = branches;
                cbxbranches.DisplayMember = "BranchName";
            }
        }
        List<City> cities;
        private void rbCityName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBranchName.Checked == false)
            {
                cities = new CityBLL().GetCity();
                cbxbranches.DataSource = cities;
                cbxbranches.DisplayMember = "CityName";
            }
        }


    }
}
