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
    public partial class frmIsssuedMedicinePrice : Form
    {
        public frmIsssuedMedicinePrice()
        {
            InitializeComponent();
        }
        List<LabTest> labtests;
        RecieveMedicine rm;
        LabTest ObjLt;
        private void frmIsssuedMedicinePrice_Load(object sender, EventArgs e)
        {
            labtests = new LabTestBLL().GetLabTests();
            rm = new RecieveMedicine();
            if (labtests.Count > 0)
            {
                List<LabTest> medicines = labtests.Where(m => m.IsMedicine == true || m.IsRsTenInjection == true || m.IsAlwaysPaid == true).ToList<LabTest>();
                labtests = null;
                labtests = medicines;
                cbxMedicines.DataSource = labtests;
                cbxMedicines.DisplayMember = "TestName";
            }
            rbPurchase.Checked = true;
            rbAll.Checked = false;
        }
        DSIssuedMedPur.dtIssuedMedPurDataTable ds = new DSIssuedMedPur.dtIssuedMedPurDataTable();
        rptIssuedMedPur crp = new rptIssuedMedPur();
        private void PrintPreview(bool Privew)
        {
           

                ObjLt = new LabTest();
                if (cbxMedicines.Text.Length > 0)
                {
                ObjLt.LabTestId = ((LabTest)(cbxMedicines.SelectedItem)).LabTestId;
                }
                ds = new LabTestBLL().GetIssuedMedPur(rbAll.Checked,rbPurchase.Checked,rbRetaiReport.Checked,ObjLt,dtpfromDate.Value.Date,dtpTodate.Value.Date);
                string SummaryType = "";
                string From = "";
                string TO = "";
                if (rbPurchase.Checked == true && rbAll.Checked == false)
                {
                    SummaryType = "Purchase Price";
                    From = dtpfromDate.Value.Date.ToString();
                    TO = dtpTodate.Value.Date.ToString();
                }
                else if (rbRetaiReport.Checked == true && rbAll.Checked == false)
                {
                    SummaryType = "Retail Price";
                    From = dtpfromDate.Value.Date.ToString();
                    TO = dtpTodate.Value.Date.ToString();
                }
                else if (rbAll.Checked == true && rbRetaiReport.Checked == false && rbPurchase.Checked == false)
                {
                    SummaryType = "Purchase&Retail";
                    From ="Start";
                    TO = "Till Now";
                }
                //else if (rbAll.Checked == true && rbPurchase.Checked == true)
                //    SummaryType = "Purchase Price";
                //else if (rbAll.Checked == true && rbRetaiReport.Checked == true)
                //    SummaryType = "Retail Price";
                crp.SetDataSource((DataTable)ds);
                crp.SetParameterValue("SummaryType",SummaryType);
                crp.SetParameterValue("From",From);
                crp.SetParameterValue("TO",TO);
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

        private void tsPrint_Click(object sender, EventArgs e)
        {
            PrintPreview(false);
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsClear_Click(object sender, EventArgs e)
        {
            cbxMedicines.Text = "";
            rbPurchase.Checked = false;
            rbRetaiReport.Checked = false;
            rbAll.Checked = true;
            PrintPreview(true);

        }
    }
}
