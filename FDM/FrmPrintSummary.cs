using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
using Common.Datasets;
using FDM.Reports;
namespace FDM
{
    public partial class FrmPrintSummary : Form
    {
        public FrmPrintSummary()
        {
            InitializeComponent();
        }
        PrintLabelBLL plbll= new PrintLabelBLL();
        DsPrintedInvoices pds = new DsPrintedInvoices();
        DsPrintedInvoices printds = new DsPrintedInvoices();
        private void btnPrintedInvoice_Click(object sender, EventArgs e)
        {
            pds = plbll.GetPrintedInvoices(this.dtpFromDate.Value.Date ,this.dtpToDate.Value.Date) ;
            this.dgvPrintedInvoices.DataSource = pds.PrintedInvoices;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PrintPreview(true);
        }

        private void PrintPreview(bool preview)
        {
            printds = new DsPrintedInvoices();
            foreach (var item in pds.PrintedInvoices)
            {
                if (item.Exclude != true)
                {
                    for (int i = 1; i <= item.NoOfBoxes; i++)
                    {
                        item.NumberOfTotal = i;
                        item.CVisible = !this.chkPrintCompanyDetail.Checked;
                        object[] values = item.ItemArray;
                        printds.PrintedInvoices.Rows.Add(values);
                    }
                }
            }
            rptLabels crp = new rptLabels();
            //crp.SetDataSource((DataTable)printds.PrintedInvoices);
            FrmReportViewer frmViewer = new FrmReportViewer();
            //frmViewer.crystalReportViewer1.ReportSource = crp;
            if (preview)
                frmViewer.ShowDialog();
            else 
            {
                //frmViewer.crystalReportViewer1.RefreshReport();
                //frmViewer.crystalReportViewer1.PrintReport();
            }
            
        }
        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in pds.PrintedInvoices )
            {
                item.Exclude = this.chkSelectAll.Checked;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreview(false);
        }

        private void chkPrintCompanyDetail_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                plbll.SetCompanyCheck(this.chkPrintCompanyDetail.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Print Comapny Name Error");
            }
        }

        private void FrmPrintLabels_Load(object sender, EventArgs e)
        {
            try
            {
                this.chkPrintCompanyDetail.Checked = plbll.GetCompanyCheck();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check Company Name Load Error");                
            }
        }
    }
}
