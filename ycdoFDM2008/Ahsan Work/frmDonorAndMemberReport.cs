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
    public partial class frmDonorAndMemberCollectionReport : Form
    {
        public frmDonorAndMemberCollectionReport()
        {
            InitializeComponent();
        }
        Donor d = new Donor();
      
        DSDonorAndMemberCollection ds = new DSDonorAndMemberCollection();
      
        rptDonorAndMember crp = new rptDonorAndMember();
        private void PrintPreview(bool Privew)
        {
            string fromdate = "";
            string todate = "";


            if (rbDonationtype.Checked == true)
            {
                d.FundType = Mycbx.Text.Trim();
                fromdate = dtpfromDate.Value.Date.ToString();
                todate = dtpTodate.Value.Date.ToString();
            }
            //else if (rbDateWise.Checked == true)
            //{

            //    fromdate = dtpfromDate.Value.Date.ToString();
            //    todate = dtpTodate.Value.Date.ToString();
            //}

            else
            {
                rbAll.Checked = true;
                fromdate = dtpfromDate.Value.Date.ToString();
                todate = dtpTodate.Value.Date.ToString();
            }
            ds = new DonorBLL().GetDonorAndMember(d, rbAll.Checked, rbDonationtype.Checked, fromdate, todate);
         
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

        private void tsPreview_Click(object sender, EventArgs e)
        {
            PrintPreview(true);
        }
        List<Donor> donors;
        private void rbDonationtype_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked == false)
            {
                donors = new DonorBLL().GetDonationType();
                Mycbx.DataSource = donors;
                Mycbx.DisplayMember = "FundType";
            }
        }
    }
}
