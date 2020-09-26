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
using System.Configuration;

namespace FDM.ReportForms
{
    public partial class FrmDonationCollectionReport : Form
    {
        public FrmDonationCollectionReport()
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
        DonorCollection mem = new DonorCollection();


        rptDonorCollection crp = new rptDonorCollection();
        DSDonorCollection ds = new DSDonorCollection();
        private void PrintPreview(bool Privew)
        {
            if (cbxMemberName.Text == "" && rbAll.Checked == false)
            {
                MessageBox.Show("Plz Select AnyOne");
            }
            else
            {
                string fromdate = "";
                string todate = "";
                fromdate = dtpFromDate.Value.Date.ToString();
                todate = dtpToDate.Value.Date.ToString();
                mem.DonorName = cbxMemberName.Text.Trim();
                ds = new DonorBLL().GetDonorCollectionData(mem, fromdate, todate, rbAll.Checked);
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

        }

      
        private void FrmMembershipReport_Load(object sender, EventArgs e)
        {
            rbDonors.Checked = true;
            rbDonors_CheckedChanged(sender, e);

        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            PrintPreview(false);
        }

        private void tsClear_Click(object sender, EventArgs e)
        {
           
            rbAll.Checked = true;
            PrintPreview(true);
        }
        List<Branch> branches;
        private void rbBranchName_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        List<City> cities;
        private void rbCityName_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        List<Membership> members;
        
        List<Donor> donors;

     

        private void rbMembers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDonors.Checked == false)
            {
                members = new MembershipBLL().GetMembershipData();
                cbxMemberName.DataSource = members;
                cbxMemberName.DisplayMember = "MemberName";
                cbxMemberName.SelectedIndex = -1;
            }
        }

        private void rbDonors_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMembers.Checked == false)
            {
                donors = new DonorBLL().GetDonorData();
                cbxMemberName.DataSource = donors;
                cbxMemberName.DisplayMember = "DonorName";
                cbxMemberName.SelectedIndex = -1;
            }
        }
      


    }
}
