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
        //LabTest defaultSyring;
        //List<LabTest> alwaysPaid;
        //List<LabTest> free;

        List<LabTest> medications;
        InjectionLabTestBLL inLabBll = new InjectionLabTestBLL();
        List<LabTest> assignedLabtest = new List<LabTest>();
        List<LabTest> rs10 = new List<LabTest>();
        FrmExistingToken frm4th;
        PatientRegistration prCancel;
        bool PrintDuplicate;
        DsPatientRegistration.PatientRegistrationDataTable prt;
        private bool p; 
        public User IsloginUser;

        private void frmFourthTurn_Load(object sender, EventArgs e)
        {
            GetNextTokenNumber2nd();
            this.lblTokenDate2nd.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
        }
        public frmFourthTurn(bool p)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.p = p;
            this.txtDays.Visible = false;
            this.lblDays.Visible = false;
            this.Text = "Third turn";

        }
        
        private void btnThirdExistingToken_Click(object sender, EventArgs e)
        {
            frm4th = new FrmExistingToken();
            frm4th.Reprint = true;
            frm4th.ShowDialog();
            if (frm4th.pr != null)
            {
                prCancel = frm4th.pr;
                PopulateExistingToken3rd();
                
            }
        }
        private void PopulateExistingToken3rd()
        {
            txtThirdExistingToken.Text = frm4th.pr.TokenNumber.ToString();
            txtThirdExistingToken.Visible = true;
            txtThirdPatientRegistrationNumber.Text = frm4th.pr.Patient.RegistrationNumber;
            dtpThirdPatientRegistrationDate.Value = frm4th.pr.Patient.RegistrationDate;
            txtThirdFirstName.Text = frm4th.pr.Patient.FirstName;
            txtThirdLastName.Text = frm4th.pr.Patient.LastName;
            txtThirdCNIC.Text = frm4th.pr.Patient.NIC;
            txtThirdMobile.Text = frm4th.pr.Patient.Mobile;
            txtThirdAge.Text = frm4th.pr.Patient.Age.ToString();
            txtThirdAddress.Text = frm4th.pr.Patient.Address;
            medications = new InjectionLabTestBLL().GetMedicineIssued(frm4th.pr);

            // Room & Dr selected from Doctor Checkup                   -------- Asif - 27-05-19
            txtThirdRoom.Text = frm4th.pr.Room.Name + " - " + frm4th.pr.Room.LabelName;

            //assignedLabtest = new InjectionLabTestBLL().GetLabTestAssignedUnPaid(frm4th.pr);
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
             //   this.lbxPaidMedicine.Items.Add(item + ":" + TimesaDay);
                this.lbxPaidMedicine.Items.Add(item);

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
        { lbxPaidMedicine.DataSource = null;
            this.lblCurrentTokenNumber2nd.Text = new InjectionLabTestBLL().GetNextTokenNumber().ToString("00000");
            this.txtCashRecievedByUser.Clear();
            this.txtThirdCashReceived.Clear();
            this.txtThirdAddress.Clear();
            this.txtThirdCNIC.Clear();
            this.txtThirdFirstName.Clear();
            this.txtThirdLastName.Clear();
            this.txtThirdMobile.Clear();
            this.txtThirdAge.Clear();
            this.txtThirdPaidTotal.Clear();
            this.txtThirdPatientRegistrationNumber.Clear();
            this.lbxPaidMedicine.Items.Clear();
            this.txtThirdRoom.Clear();
           
        
        }
        private void tsSave_Click(object sender, EventArgs e)
        {
            if (txtCashRecievedByUser.Text == "")
            {
                MessageBox.Show("First Enter Received Amount");
                return;

            }
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
            inLb.CashReceivedByUser = Convert.ToDouble(this.txtCashRecievedByUser.Text);
            inLb.Patient.FirstName = this.txtThirdFirstName.Text;
            inLb.Patient.LastName = this.txtThirdLastName.Text;
            inLb.Patient.NIC = this.txtThirdCNIC.Text;
            inLb.Patient.Mobile = this.txtThirdMobile.Text;
            inLb.Patient.Age = Convert.ToInt16(this.txtThirdAge.Text);
            inLb.Patient.Address = this.txtThirdAddress.Text;
            inLb.Patient.RegistrationDate = this.dtpThirdPatientRegistrationDate.Value.Date;
            inLb.TokenDate = System.DateTime.Now;
            inLb.Patient.RegistrationNumber = this.txtThirdPatientRegistrationNumber.Text;
            //inLb.Patient.Address = this.txtPatientAddress2nd.Text;
            inLb.TokenMonthYear = Convert.ToInt64(DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString());
            inLb.TokenBy = IsloginUser;

            inLb.Room.Name = frm4th.pr.Room.Name;
            inLb.Room.LabelName = frm4th.pr.Room.LabelName;

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
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, item.TestName + " Qty : " + (item.TimesADay * item.TotalDays), pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.CashReceivedByUser };
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + " " + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.ExistingTokenNo, item.TestName + " (" + item.TotalDays + " Days)\n" + item.TimesADayUrdu, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name + '-' + pr.Room.LabelName, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.CashReceivedByUser, pr.TokenBy };      ------- Asif -- 01-06-19
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + " " + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.ExistingTokenNo, item.TestName + " (" + (item.TimesADay * item.TotalDays) + ")\n" + item.TimesADayUrdu, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name + '-' + pr.Room.LabelName, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, item.TotalDays , pr.TokenBy };
                prt.LoadDataRow(values, true);
            }
            rptLabTestToken crp = new rptLabTestToken();
            crp.SetDataSource((DataTable)prt);
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;
            string BranchName = ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();
            string CompNo = ConfigurationManager.AppSettings["ComplaintNo"].ToString();
            crp.SetParameterValue("Duplicate", PrintDuplicate);
            crp.SetParameterValue("Name", BranchName);
            crp.SetParameterValue("Address", BranchAddress);
            crp.SetParameterValue("ComplaintNo", "Complaint #: " + CompNo);
            crp.SetParameterValue("CashRecievedByUser", pr.CashReceivedByUser);

            if (preview)
                frmViewer.ShowDialog();
            else
            {
                //frmViewer.crystalReportViewer1.RefreshReport();
                crp.PrintToPrinter(1, false, 0, 0);                 ////    -------- Asif -- 02-06-19   ----- Print Without Showing Print Dialog (Disallow Multiple Copies)
                //frmViewer.crystalReportViewer1.PrintReport();     ////    -------- Asif -- 02-06-19
            }
            PrintDuplicate = false;
        }


        private void tsmPaidCancel_Click(object sender, EventArgs e)
        {
            if (lbxPaidMedicine.SelectedItem == null)
            {
                MessageBox.Show("Please Select Medicine To Cancel", "Medicine Not Selected");
                return;
            }

            LabTest cancelfree = medications[this.lbxPaidMedicine.SelectedIndex];
            medications.RemoveAt(this.lbxPaidMedicine.SelectedIndex);
            this.lbxPaidMedicine.Items.RemoveAt(this.lbxPaidMedicine.SelectedIndex);

            if (MessageBox.Show("do you really want to cancel the Medicine? " + cancelfree.TestName, " Cancel Medicine", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (new PatientBLL().MedicineCanceled(prCancel, cancelfree))
                    MessageBox.Show(cancelfree.TestName + " is canceled");
                PopulateExistingToken3rd();
            }
        }

        private void txtCashRecievedByUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9 || e.KeyChar == (char)Keys.Decimal || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            GetNextTokenNumber2nd();
        }

        private void lbxPaidMedicine_KeyDown(object sender, KeyEventArgs e)
        {
            ListBox lbx = sender as ListBox;
            if (e.KeyCode == Keys.Delete)
            {
                if (lbx.SelectedIndex >= 0)
                {
                    int deleteIndex = lbxPaidMedicine.SelectedIndex;
                    //lbx.Items.RemoveAt(deleteIndex);
                    string temp1 = lbxPaidMedicine.SelectedItem.ToString().Substring(0, lbxPaidMedicine.SelectedItem.ToString().Length);
                    medications = medications.Where(inj => inj.TestName != temp1).ToList<LabTest>();
                    if (lbx.Name == lbxPaidMedicine.Name)
                        lbxPaidMedicine.Items.RemoveAt(deleteIndex);
                    //alwaysPaiddel = alwaysPaid.RemoveAt(lbxPaidMedicine.SelectedIndex);
                    CalculateCashRecv3nd();
                }

            }
        }

        
    }
}
