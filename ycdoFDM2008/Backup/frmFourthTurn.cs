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
using FDM.Reports;
using System.Configuration;

namespace FDM
{
    public partial class frmFourthTurn : Form
    {
        public frmFourthTurn()
        {
            InitializeComponent();
        }
        LabTest defaultSyring;
        List<LabTest> alwaysPaid;

        List<LabTest> medications;
        List<LabTest> free;
        InjectionLabTestBLL inLabBll = new InjectionLabTestBLL();
        List<LabTest> assignedLabtest = new List<LabTest>();
        List<LabTest> rs10 = new List<LabTest>();
        FrmExistingToken frm3rd;
        PatientRegistration prCancel;
        bool PrintDuplicate;
        DsPatientRegistration.PatientRegistrationDataTable prt;
        private void btnThirdExistingToken_Click(object sender, EventArgs e)
        {
            frm3rd = new FrmExistingToken();
            frm3rd.Reprint = true;
            frm3rd.ShowDialog();
            if (frm3rd.pr != null)
            {
                prCancel = frm3rd.pr;
                PopulateExistingToken3rd();
                
            }
        }
        private void PopulateExistingToken3rd()
        {
            txtThirdExistingToken.Text = frm3rd.pr.TokenNumber.ToString();
            txtThirdExistingToken.Visible = true;
            txtThirdPatientRegistrationNumber.Text = frm3rd.pr.Patient.RegistrationNumber;
            dtpThirdPatientRegistrationDate.Value = frm3rd.pr.Patient.RegistrationDate;
            txtThirdFirstName.Text = frm3rd.pr.Patient.FirstName;
            txtThirdLastName.Text = frm3rd.pr.Patient.LastName;
            txtThirdCNIC.Text = frm3rd.pr.Patient.NIC;
            txtThirdAddress.Text = frm3rd.pr.Patient.Address;
            medications = new InjectionLabTestBLL().GetMedicineIssued(frm3rd.pr);
            //assignedLabtest = new InjectionLabTestBLL().GetLabTestAssignedUnPaid(frm3rd.pr);
            //alwaysPaid = medications.Where(inj => inj.IsAlwaysPaid == true).ToList<LabTest>();
            //rs10 = medications.Where(rs => rs.IsRsTenInjection == true).ToList<LabTest>();
            //List<LabTest> free = medications.Where(f => f.IsAlwaysPaid != true && f.IsRsTenInjection != true).ToList<LabTest>();
            //clear paid medicine from previous entries
            string TimesaDay = "";
            this.lbxPaidMedicine.Items.Clear();
            foreach (LabTest item in medications)
            {
                if (item.TimesADay == 1)
                    TimesaDay = "od";
                if (item.TimesADay == 2)
                    TimesaDay = "bd";
                if (item.TimesADay == 3)
                    TimesaDay = "td";
                this.lbxPaidMedicine.Items.Add(item + ":" + TimesaDay);

            }
            //clear rs 10 injection from previous entries
            //this.lbxInjection.Items.Clear();
            //foreach (LabTest item in rs10)
            //{
            //    item.CurrentAmount = 10;
            //    this.lbxInjection.Items.Add(item);
            //}
            //if (this.lbxInjection.Items.Count > 0)
            //    this.txtThirdInjectionTotal.Text = (10 * lbxInjection.Items.Count).ToString();
            //else
            //    this.txtThirdInjectionTotal.Text = "0";

            //clear free medicine previous entries
            //this.lbxFreeMedicine.Items.Clear();
            //foreach (LabTest lt in free)
            //{
            //    if (lt.TimesADay == 1)
            //        TimesaDay = "od";
            //    if (lt.TimesADay == 2)
            //        TimesaDay = "bd";
            //    if (lt.TimesADay == 3)
            //        TimesaDay = "td";
            //    this.lbxFreeMedicine.Items.Add(lt + ":" + TimesaDay);

            //}
            //this.lbxLabTest.Items.Clear();
            //foreach (LabTest item in assignedLabtest)
            //{
            //    this.lbxLabTest.Items.Add(item);
            //}
            //this.txtThirdFreeTotal.Text = "0";
            CalculateCashRecv3nd();
        }
        private void PatientPayType3rd_Changed(object sender, EventArgs e)
        {

            CalculateCashRecv3nd();
        }
        private void CalculateCashRecv3nd()
        {
            decimal cash = 0;
            if (lbxPaidMedicine.Items.Count > 0)
            {
                foreach (LabTest item in medications)
                {
                    if (rbThirdGeneral.Checked == true)
                    {
                        item.CurrentAmount = item.General;
                        cash += item.GetLineTotal();
                    }
                    else if (rbThirdPoor.Checked == true)
                    {
                        item.CurrentAmount = item.Poor;
                        cash += item.GetLineTotal();
                    }
                    else if (rbThirdYCDO.Checked == true)
                    {
                        item.CurrentAmount = item.YCDO;
                        cash += item.GetLineTotal();
                    }
                }
            }
            txtThirdPaidTotal.Text = cash.ToString();
            //cash = 0;
            //if (lbxLabTest.Items.Count > 0)
            //{
            //    foreach (LabTest item in lbxLabTest.Items)
            //    {
            //        if (rbThirdGeneral.Checked == true)
            //        {
            //            item.CurrentAmount = item.General;
            //            cash += item.GetLineTotal();
            //        }
            //        else if (rbThirdPoor.Checked == true)
            //        {
            //            item.CurrentAmount = item.Poor;
            //            cash += item.GetLineTotal();
            //        }
            //        else if (rbThirdYCDO.Checked == true)
            //        {
            //            item.CurrentAmount = item.YCDO;
            //            cash += item.GetLineTotal();
            //        }
            //    }
            //}
            //this.txtThirdPaidLabTest.Text = cash.ToString();
            try
            {
                // if(txtThirdCashReceived.Text.Length>0)
                this.txtThirdCashReceived.Text = (Convert.ToDecimal(this.txtThirdPaidTotal.Text)).ToString("0.00");
            }
            finally
            {

            }

        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDays_ValueChanged(object sender, EventArgs e)
        {
            foreach (LabTest item in medications)
            {
                item.TotalDays = txtDays.Value;
            }
            CalculateCashRecv3nd();
        }
        private void GetNextTokenNumber2nd()
        {
            this.lblCurrentTokenNumber2nd.Text = new InjectionLabTestBLL().GetNextTokenNumber().ToString("00000");
        }
        private void tsSave_Click(object sender, EventArgs e)
        {

            InjectionLabTest inLb = new InjectionLabTest();
            inLb.IsInjectionToken = false;
            if (rbThirdGeneral.Checked == true)
                inLb.Type = PatientPayType.General;
            else if (rbThirdPoor.Checked == true)
                inLb.Type = PatientPayType.Poor;
            else if (rbThirdYCDO.Checked == true)
                inLb.Type = PatientPayType.YCOD;
            if (lbxPaidMedicine.Items.Count > 0)
            {
                foreach (LabTest item in medications)
                {
                    inLb.Tests.Add(item);
                }
            }

            Int64 exTokNo = 0;
            Int64.TryParse(txtThirdExistingToken.Text, out exTokNo);
            inLb.ExistingTokenNo = exTokNo;
            inLb.TokenNumber = Convert.ToInt32(this.lblCurrentTokenNumber2nd.Text);
            inLb.CashReceived = Convert.ToDouble(this.txtThirdCashReceived.Text.Trim());
            inLb.Patient.FirstName = this.txtThirdFirstName.Text;
            inLb.Patient.LastName = this.txtThirdLastName.Text;
            inLb.Patient.NIC = this.txtThirdCNIC.Text;
            inLb.Patient.RegistrationDate = this.dtpThirdPatientRegistrationDate.Value.Date;
            inLb.TokenDate = System.DateTime.Now.Date;
            inLb.Patient.RegistrationNumber = this.txtThirdPatientRegistrationNumber.Text;
            //inLb.Patient.Address = this.txtPatientAddress2nd.Text;
            inLb.TokenMonthYear = Convert.ToInt64(DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString());

            try
            {
                if (inLabBll.SavePatientToken(inLb))
                {
                    GetNextTokenNumber2nd();
                    PrintPreviewLab(false, inLb);
                    MessageBox.Show("Second Turn in Days Saved Successfully", "Token Granted");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Patient Registration Error");
            }
        }
        private void PrintPreviewLab(bool preview, InjectionLabTest pr)
        {
            prt = new DsPatientRegistration.PatientRegistrationDataTable();
            foreach (var item in pr.Tests)
            {
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, item.TestName + " Qty : " + (item.TimesADay * item.TotalDays), pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
                prt.LoadDataRow(values, true);
            }
            rptLabTestToken crp = new rptLabTestToken();
            crp.SetDataSource((DataTable)prt);
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;
            string BranchName = ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();
            crp.SetParameterValue("Duplicate", PrintDuplicate);
            crp.SetParameterValue("Name", BranchName);
            crp.SetParameterValue("Address", BranchAddress);

            if (preview)
                frmViewer.ShowDialog();
            else
            {
                //frmViewer.crystalReportViewer1.RefreshReport();
                frmViewer.crystalReportViewer1.PrintReport();
            }
            PrintDuplicate = false;
        }

        private void frmFourthTurn_Load(object sender, EventArgs e)
        {
            GetNextTokenNumber2nd();
            this.lblTokenDate2nd.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void tsmPaidCancel_Click(object sender, EventArgs e)
        {
            if (lbxPaidMedicine.SelectedItem == null)
            {
                MessageBox.Show("Please Select Medicine To Cancel", "Medicine Not Selected");
                return;
            }

            LabTest cancelfree = medications[this.lbxPaidMedicine.SelectedIndex];

            if (MessageBox.Show("do you really want to cancel the Medicine? " + cancelfree.TestName, " Cancel Medicine", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (new PatientBLL().MedicineCanceled(prCancel, cancelfree))
                    MessageBox.Show(cancelfree.TestName + " is canceled");
                PopulateExistingToken3rd();
            }
        }
    }
}
