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
using Common.Datasets;
using FDM.Reports;
namespace FDM.ReportForms
{
    public partial class frmRefrenceReport : Form
    {
        public frmRefrenceReport()
        {
            InitializeComponent();
        }
        List<Membership> members;
        List<Donor> doners;
        Donor d = new Donor();
        Membership m = new Membership();
        DSRefrenceCollection ds = new DSRefrenceCollection();
        rptRefrenceCollection crp = new rptRefrenceCollection();
        private void rbselectMembers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbselectDonors.Checked == false)
            {

                members = new MembershipBLL().GetMembershipData();
                cbxReference.DataSource = members;
                cbxReference.DisplayMember = "MemberName";

            }
        }

        private void rbselectDonors_CheckedChanged(object sender, EventArgs e)
        {
            if (rbselectMembers.Checked == false)
            {
                doners = new DonorBLL().GetDonorData();
                cbxReference.DataSource = doners;
                cbxReference.DisplayMember = "DonorName";

            }
        }

        private void frmRefrenceReport_Load(object sender, EventArgs e)
        {
            rbselectMembers.Checked = true;
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsPreview_Click(object sender, EventArgs e)
        {
            PrintPreview(true);

        }
        private void PrintPreview(bool Privew)
        {
            string fromdate = "";
            string todate = "";


            if (rbselectDonors.Checked == true)
            {
              d.DonorName = cbxReference.Text.Trim();
                //fromdate = dtpfromDate.Value.Date.ToString();
                //todate = dtpTodate.Value.Date.ToString();
            }
            else if (rbselectMembers.Checked == true)
            {
               
                m.MemberName = cbxReference.Text.Trim();
                //fromdate = dtpfromDate.Value.Date.ToString();
                //todate = dtpTodate.Value.Date.ToString();
            }

           
            ds = new DonorBLL().GetRefrenceCollection(rbselectDonors.Checked,rbselectMembers.Checked,d,m, fromdate, todate);

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
    }
}
