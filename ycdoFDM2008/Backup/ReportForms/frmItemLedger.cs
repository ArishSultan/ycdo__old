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
    public partial class frmItemLedger : Form
    {
        public frmItemLedger()
        {
            InitializeComponent();
        }
        List<LabTest> labtests;
        RecieveMedicine rm;
        DSMedicinesIssuedAndReceived ds = new DSMedicinesIssuedAndReceived();
        rptMedicinesIssuedAndReceived crp = new rptMedicinesIssuedAndReceived();
        private void frmItemLedger_Load(object sender, EventArgs e)
        {
            labtests = new LabTestBLL().GetLabTests();
            rm = new RecieveMedicine();
            List<LabTest> medicines = labtests.Where(m => m.IsMedicine == true || m.IsRsTenInjection == true || m.IsAlwaysPaid == true).ToList<LabTest>();
            labtests = null;
            labtests = medicines;
            cbxLabTest.DataSource = labtests;
            cbxLabTest.DisplayMember = "TestName";
        }
        public void PrintPreview(bool Preview)
        {
            DateTime From = Convert.ToDateTime(dtpfromDate.Value.Date.ToShortDateString());
            DateTime To = Convert.ToDateTime(dtpTodate.Value.Date.ToShortDateString());

            ds = new LabTestBLL().GetItemLedger(From, To, cbxLabTest.Text.ToString().Trim());

            crp.SetDataSource(ds);
            if(cbxLabTest.Text.Length>0)
            {
                crp.SetParameterValue("FromDate", dtpfromDate.Value.Date.ToString("dd/MM/yyyy"));
                crp.SetParameterValue("ToDate", dtpTodate.Value.Date.ToString("dd/MM/yyyy"));
                crp.SetParameterValue("ItemName",(cbxLabTest.Text.ToString().Trim()));
            }
            else
            {
                crp.SetParameterValue("FromDate", "Start");
                crp.SetParameterValue("ToDate", "Till Now");
                crp.SetParameterValue("ItemName","Entire Stock");
            }
            string BranchName = ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();
            crp.SetParameterValue("Name", BranchName);
            crp.SetParameterValue("Address", BranchAddress);
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;
            if(Preview)
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

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsPreviewAll_Click(object sender, EventArgs e)
        {
            cbxLabTest.Text = "";
            PrintPreview(true);
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            PrintPreview(false);
        }

        
    }
}
