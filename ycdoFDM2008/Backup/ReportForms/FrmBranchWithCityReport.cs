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

namespace FDM.ReportForms
{
    public partial class FrmBranchWithCityReport : Form
    {
        public FrmBranchWithCityReport()
        {
            InitializeComponent();
        }
        List<City> cities;
        private void FrmBranchWithCityReport_Load(object sender, EventArgs e)
        {
            cities = new CityBLL().GetCity();
            cbxCity.DataSource = cities;
            cbxCity.DisplayMember = "CityName";

        }

      

        private void tsPreview_Click(object sender, EventArgs e)
        {
            PrintPreview(true);
        }
        DSBranches ds = new DSBranches();
        rptBranchwithCity crp = new rptBranchwithCity();

        Branch br = new Branch();

        private void PrintPreview(bool Preview)
        {
            br.City.CityName = cbxCity.Text.Trim();
            ds = new BranchBLL().GetData(br);
            crp.SetDataSource(ds);
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

        private void tsClear_Click(object sender, EventArgs e)
        {
            cbxCity.Text = "";
            PrintPreview(true);
        }
    }
}
