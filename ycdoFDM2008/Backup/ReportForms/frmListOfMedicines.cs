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
using FDM.ReportForms;
using FDM.Reports;
using BLL;
using System.Configuration;
namespace FDM.ReportForms
{
    public partial class frmListOfMedicines : Form
    {
        public frmListOfMedicines()
        {
            InitializeComponent();
        }
        DSMedicines ds = new DSMedicines();
        rptMedicines crp = new rptMedicines();
        private void PrintPreview(bool Preview)
        {
            ds = new  LabTestBLL().GetListOfMed();
            crp.SetDataSource(ds);
            string BranchName = ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();
            crp.SetParameterValue("Name", BranchName);
            crp.SetParameterValue("Address", BranchAddress);
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;

            if (Preview)
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

        private void tsPrint_Click(object sender, EventArgs e)
        {
            PrintPreview(false);
        }

        private void tsPreview_Click(object sender, EventArgs e)
        {
            PrintPreview(true);
        }
    }
}
