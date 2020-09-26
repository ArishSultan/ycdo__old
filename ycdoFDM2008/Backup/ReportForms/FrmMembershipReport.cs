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
using Common.Enum;
using FDM.Reports;
using System.Configuration;
namespace FDM.ReportForms
{
    public partial class FrmMembershipReport : Form
    {
        public FrmMembershipReport()
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
        Membership mem = new Membership();


        rptMembersData crp = new rptMembersData();
        DSMembership ds = new DSMembership();
        private void PrintPreview(bool Privew)
        {
            if (rbBranchName.Checked == true)
            {
                mem.branch.BranchName = cbxbranches.Text.Trim();
            }
            else if (rbCityName.Checked == true)
            {
                mem.City.CityName = cbxbranches.Text.Trim();
            }
            else if (rbAll.Checked == true)
            {
                rbAll.Checked = true;
            }
            else if (rbCounsil.Checked == true)
            {
                
                mem.Counsil.Add((Counsil)cbxbranches.SelectedItem);
            }
            else if (rbcommitte.Checked == true)
            {
                mem.Committe.Add((Committe)this.cbxbranches.SelectedItem);
            }
            else if (rbBloodgroup.Checked == true)
            {
                mem.BloodGroup = this.cbxbranches.Text.Trim();
            }

            
            ds = new MembershipBLL().GetData(mem, rbBranchName.Checked,rbCityName.Checked,rbAll.Checked,rbBloodgroup.Checked,rbCounsil.Checked,rbcommitte.Checked);
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
            cbxbranches.Text="";
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


    
        private void rbBloodgroup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBranchName.Checked == false || rbCityName.Checked == false)
            {
                cbxbranches.DataSource = null;
                this.cbxbranches.Items.Add(BloodGroup.ANegative.ToString());
                this.cbxbranches.Items.Add(BloodGroup.APositive.ToString());
                this.cbxbranches.Items.Add(BloodGroup.BPositive.ToString());
                this.cbxbranches.Items.Add(BloodGroup.OPositive.ToString());
                this.cbxbranches.Items.Add(BloodGroup.BNegative.ToString());
            
            }
        }
        List<Counsil> counsil;
        private void rbCounsil_CheckedChanged(object sender, EventArgs e)
        {
            cbxbranches.DataSource = null;
            counsil = new CounsilBLL().GetCounsil();
            cbxbranches.DataSource = counsil;
            cbxbranches.DisplayMember = "CounsilName";
        }
        List<Committe> committe;
        private void rbcommitte_CheckedChanged(object sender, EventArgs e)
        {
            cbxbranches.DataSource = null;
            committe = new CommitteBLL().GetCommitte();
            cbxbranches.DataSource = committe;
            cbxbranches.DisplayMember = "CommitteName";

        }



       
    }
}
