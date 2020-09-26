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
using BLL;
using System.Configuration;
using FDM.Reports;

namespace FDM
{
    public partial class frmMedicineStatusReport : Form
    {
        public frmMedicineStatusReport()
        {
            InitializeComponent();
        }
        List<LabTest> labtests;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMedicineStatusReport_Load(object sender, EventArgs e)
        {
            labtests = new LabTestBLL().GetLabTests();
            cbxLabTest.DataSource = labtests;
            cbxLabTest.DisplayMember = "TestName";
        }

        private void tsClear_Click(object sender, EventArgs e)
        {
            all = true;
            PrintPreview(true);
            all = false;
        }

        private void tsPreview_Click(object sender, EventArgs e)
        {
            PrintPreview(true);
        }
        bool all = false;
        DSMedicineStatus ds;
        rptMedicineStatus crp;
        private void PrintPreview(bool Privew)
        {
            crp = new rptMedicineStatus();
            if (all == false)
            {
                if (this.cbxLabTest.SelectedItem != null)
                {
                    LabTest lt = (LabTest)this.cbxLabTest.SelectedItem;
                    ds = new MedicineBLL().GetMedicinesData(lt, false);
                }
            }
            else
            {
                ds = new MedicineBLL().GetMedicinesData(new LabTest(), true);
            }
            crp.SetDataSource(ds);
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
                frmViewer.crystalReportViewer1.PrintReport();
            }

        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            PrintPreview(false);
        }
    }
}
