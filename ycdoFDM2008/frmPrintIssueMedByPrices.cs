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

namespace FDM
{
    public partial class frmPrintIssueMedByPrices : Form
    {
        RecieveMedicine r;
        public frmPrintIssueMedByPrices(RecieveMedicine rm)
        {
            InitializeComponent();
            this.r = rm;
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        rptIssueBill crp = new rptIssueBill();
        private void PrintPreview(bool Privew)
        {
            DSIssueBill.DTIssueBillDataTable ds = new InjectionLabTestBLL().PrintIssueMedBill(r,rbRetail.Checked,rbPurchase.Checked);
           
            crp.SetDataSource((DataTable)ds);
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;
            crp.SetParameterValue("BranchName", this.r.RefBranch.BranchName);
            if (Privew)
                frmViewer.ShowDialog();
            else
            {
                //frmViewer.crystalReportViewer1.RefreshReport();
                frmViewer.crystalReportViewer1.PrintReport();
            }
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            PrintPreview(false);
        }
    }
}
