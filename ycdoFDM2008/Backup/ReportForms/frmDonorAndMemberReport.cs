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
using Common.Enum;
using System.Configuration;
namespace FDM.ReportForms
{
    public partial class frmDonorAndMemberCollectionReport : Form
    {
        public frmDonorAndMemberCollectionReport()
        {
            InitializeComponent();
        }
        Donor d = new Donor();
      
        DSDonorAndMemberCollection ds = new DSDonorAndMemberCollection();
        string fromdate;
        string todate;
        rptDonorAndMember crp = new rptDonorAndMember();
        private void PrintPreview(bool Privew)
        {
           
                d.FundType = Mycbx.Text.Trim();
                fromdate = dtpfromDate.Value.Date.ToString();
                todate = dtpTodate.Value.Date.ToString();
              
              
            
            //else if (rbDateWise.Checked == true)
            //{

            //    fromdate = dtpfromDate.Value.Date.ToString();
            //    todate = dtpTodate.Value.Date.ToString();
            //}

            //else
            //{
            //    rbAll.Checked = true;
            //    fromdate = dtpfromDate.Value.Date.ToString();
            //    todate = dtpTodate.Value.Date.ToString();
            //}
            ds = new DonorBLL().GetDonorAndMemberCollection(d, rbAll.Checked, rbDonationtype.Checked, fromdate, todate);

            crp.SetDataSource(ds);
            if (rbDonationtype.Checked == true)
            {
                crp.SetParameterValue("DType", Mycbx.Text);
                crp.SetParameterValue("FromDate", dtpfromDate.Value.Date.ToString("dd/MM/yyyy"));
                crp.SetParameterValue("ToDate", dtpTodate.Value.Date.ToString("dd/MM/yyyy"));
            }
            else if (rbAll.Checked == true)
            {
                crp.SetParameterValue("DType", "All Donations");
                crp.SetParameterValue("FromDate", "Start");
                crp.SetParameterValue("ToDate", "Till Now");
            }
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

        private void tsPreview_Click(object sender, EventArgs e)
        {
            PrintPreview(true);
        }
        List<Donor> donors;
        private void rbDonationtype_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbAll.Checked == false)
            //{
            //    donors = new DonorBLL().GetDonationType();
            //    Mycbx.DataSource = donors;
            //    Mycbx.DisplayMember = "FundType";
            //}
            this.Mycbx.Items.Add(FundsType.SimpleDonation);
            this.Mycbx.Items.Add(FundsType.Monthly);
            this.Mycbx.Items.Add(FundsType.Zakat);
            this.Mycbx.Items.Add(FundsType.Sadkat);
            this.Mycbx.Items.Add(FundsType.Kharat);
            this.Mycbx.Items.Add(FundsType.Others);
        }

        private void tsPreviewAll_Click(object sender, EventArgs e)
        {
            rbAll.Checked = true;
            PrintPreview(true);
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            PrintPreview(false);
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

       

      
    }
}
