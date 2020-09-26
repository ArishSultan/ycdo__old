using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using Common.Datasets;
using System.Configuration;
using FDM.Reports;
using BLL;
namespace FDM.ReportForms
{
    public partial class frmCurrentStock : Form
    {
        public frmCurrentStock()
        {
            InitializeComponent();
        }

      
        private void PrintPreviewInjection(bool preview)
        {
            string BranchName = ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();
            rptCurrentStock crp = new rptCurrentStock();
            DsCurrentStock.CurrentStockDataTable prt = new LabTestBLL().GetCurrentStock(rbLabTestnMedicines.Checked, rbWithoutLabTest.Checked,rbLabTests.Checked);
            crp.SetDataSource((DataTable)prt);
            if(rbLabTestnMedicines.Checked==true)
            crp.SetParameterValue("Type","LabTests&Medicines");
            else if(rbWithoutLabTest.Checked==true)
                crp.SetParameterValue("Type","Medicines ");
            else if (rbLabTests.Checked == true)
                crp.SetParameterValue("Type", "LabTests");
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;
            //crp.SetParameterValue("Name", BranchName);
            //crp.SetParameterValue("Address", BranchAddress);
            if (preview)
                frmViewer.ShowDialog();
            else
            {
                //frmViewer.crystalReportViewer1.RefreshReport();
                frmViewer.crystalReportViewer1.PrintReport();
            }
        }

      

        private void tsPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewInjection(false);
        }

        private void tsPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewInjection(true);
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCurrentStock_Load(object sender, EventArgs e)
        {
            rbLabTestnMedicines.Checked = true;
        }
    }
}
