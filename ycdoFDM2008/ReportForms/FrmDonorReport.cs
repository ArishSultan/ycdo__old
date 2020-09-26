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
using Common.Enum;
using System.Configuration;
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
            string fromdate = "";
            string todate = "";

            if (rbCityName.Checked == true)
            {
                d.branch.BranchName = cbxbranches.Text.Trim();
            }
            else if (rbBranchName.Checked == true)
            {
                d.City.CityName = cbxbranches.Text.Trim();
            }
            else if (rbDonationtype.Checked == true)
                d.FundType = cbxbranches.Text.Trim();
            else if (rbDateWise.Checked == true)
            {
                
                fromdate = dtpfromDate.Value.Date.ToString();
                todate = dtpTodate.Value.Date.ToString();
            }



            else
                rbAll.Checked = true;
            ds = new DonorBLL().GetData(d, rbBranchName.Checked, rbCityName.Checked, rbAll.Checked,rbDonationtype.Checked,fromdate,todate,rbDateWise.Checked);
            crp.SetDataSource(ds);
            string BranchName = ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();
            crp.SetParameterValue("Name", BranchName);
            crp.SetParameterValue("Address", BranchAddress);
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
            rbDonationtype.Checked = false;
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
        List<Donor> doners;
        private void rbDonationtype_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBranchName.Checked == false && rbCityName.Checked == false)
            {
                //doners = new DonorBLL().GetDonationType();
                //cbxbranches.DataSource = doners;
                //cbxbranches.DisplayMember = "FundType";
                cbxbranches.DataSource = null;
                this.cbxbranches.Items.Add(FundsType.SimpleDonation);
                this.cbxbranches.Items.Add(FundsType.Monthly);
                this.cbxbranches.Items.Add(FundsType.Zakat);
                this.cbxbranches.Items.Add(FundsType.Sadkat);
                this.cbxbranches.Items.Add(FundsType.Kharat);
                this.cbxbranches.Items.Add(FundsType.Others);
            }
        }

        private void rbDateWise_CheckedChanged(object sender, EventArgs e)
        {

        }

      

    }
}
