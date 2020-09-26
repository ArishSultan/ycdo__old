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
    public partial class frmCurrentStockWithValue : Form
    {
        public frmCurrentStockWithValue()
        {
            InitializeComponent();
        }
        private void PrintPreviewInjection(bool preview)
        {
            //string BranchName = ConfigurationManager.AppSettings["Name"].ToString();
            //string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();

            rptCurrentStockWithValue crp = new rptCurrentStockWithValue();
            DSCurrentStockWithValue.dtCurrentStockWithValueDataTable prt = new LabTestBLL().GetCurrentStockWithValue(rbLabTest.Checked,rbWithoutLabTest.Checked,rbLabTestnMedicine.Checked);
            crp.SetDataSource((DataTable)prt);
            if(rbLabTestnMedicine.Checked==true)
                crp.SetParameterValue("Type", "LabTest&Medicine");
            else if(rbWithoutLabTest.Checked==true)
            crp.SetParameterValue("Type","Medicines");
            else if (rbLabTest.Checked == true)
                crp.SetParameterValue("Type", "LabTests");
            FrmReportViewer frmViewer = new FrmReportViewer();
            string BranchName = ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();
            crp.SetParameterValue("Name", BranchName);
            crp.SetParameterValue("Address", BranchAddress);
            frmViewer.crystalReportViewer1.ReportSource = crp;
            //crp.SetParameterValue("Name", BranchName);
            //crp.SetParameterValue("Address", BranchAddress);
            if (preview)
                frmViewer.ShowDialog();
            else
            {
                frmViewer.crystalReportViewer1.RefreshReport();
                frmViewer.crystalReportViewer1.PrintReport();
            }
        }
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewInjection(true);
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewInjection(false);
        }

        private void frmCurrentStockWithValue_Load(object sender, EventArgs e)
        {
            rbLabTestnMedicine.Checked = true;
        }

       

       

      
    }
}
