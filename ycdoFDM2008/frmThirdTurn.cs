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
using FDM.SearchForms;
using System.Configuration;
namespace FDM
{
    public partial class frmThirdTurn : Form
    {
        public frmThirdTurn()
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
        public User IsloginUser;
        private void frmThirdTurn_Load(object sender, EventArgs e)
         {
            defaultSyring = new LabTestBLL().GetSyring();

            //set the current Date
            this.lblThirdTokenDate.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
            GetNextTokenNumber3nd();
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
                foreach (LabTest item in alwaysPaid)
                //foreach (LabTest item in lbxPaidMedicine.Items)
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
            cash = 0;
            if (lbxLabTest.Items.Count > 0)
            {
                //foreach (LabTest item in lbxLabTest.Items)
                foreach (LabTest item in assignedLabtest)
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
            this.txtThirdPaidLabTest.Text = cash.ToString();
            try
            {
                // if(txtThirdCashReceived.Text.Length>0)
                this.txtThirdCashReceived.Text = (Convert.ToDecimal(this.txtThirdPaidLabTest.Text) + Convert.ToDecimal(this.txtThirdFreeTotal.Text) + Convert.ToDecimal(this.txtThirdInjectionTotal.Text) + Convert.ToDecimal(this.txtThirdPaidTotal.Text)).ToString("0.00");
            }
            finally
            {

            }

        }
        private void tsSave_Click(object sender, EventArgs e)
        {
            if (txtCashRecievedByUser.Text == "")
            {
                MessageBox.Show("First Enter Received Amount");
                return;

            }
            InjectionLabTest inLb = new InjectionLabTest();
            //inLb.TokenDate = System.DateTime.Today;
            inLb.TokenDate = System.DateTime.Now;
            GetNextTokenNumber3nd();
            inLb.TokenNumber = Convert.ToInt64(this.lblThirdMainToken.Text.Trim());
            inLb.IsInjectionToken = false;

            if (rbThirdGeneral.Checked == true)
                inLb.Type = PatientPayType.General;
            else if (rbThirdPoor.Checked == true)
                inLb.Type = PatientPayType.Poor;
            else if (rbThirdYCDO.Checked == true)
                inLb.Type = PatientPayType.YCOD;
            if (lbxPaidMedicine.Items.Count > 0)
            {
                // foreach (LabTest item in this.lbxPaidMedicine.Items)
                foreach (LabTest item in alwaysPaid)
                {
                    inLb.Tests.Add(item);
                }
            }
            if (lbxInjection.Items.Count > 0)
            {
                foreach (LabTest item in this.lbxInjection.Items)
                {
                    inLb.Injections.Add(item);
                }
                if (chxSyringThird.Checked)
                {
                    defaultSyring.CurrentAmount = 0;
                    inLb.Injections.Add(defaultSyring);
                }
            }
            if (lbxLabTest.Items.Count > 0)
            {
                foreach (LabTest item in this.lbxLabTest.Items)
                {
                    inLb.AssignedLabTest.Add(item);
                }
            } if (lbxFreeMedicine.Items.Count > 0)
            {
                foreach (LabTest item in free)
                {
                    inLb.Tests.Add(item);
                }            
            }
            Int64 exTokNo = 0;
            Int64.TryParse(txtThirdExistingToken.Text, out exTokNo);
            inLb.ExistingTokenNo = exTokNo;
            inLb.CashReceived = Convert.ToDouble(this.txtThirdCashReceived.Text.Trim());
            inLb.CashReceivedByUser = Convert.ToDouble(this.txtCashRecievedByUser.Text);
            inLb.Patient.FirstName = this.txtThirdFirstName.Text;
            inLb.Patient.LastName = this.txtThirdLastName.Text;
            inLb.Patient.NIC = this.txtThirdCNIC.Text;
            inLb.Patient.Mobile = this.txtThirdMobile.Text;
            inLb.Patient.Age = Convert.ToInt16(this.txtThirdAge.Text);
            inLb.Patient.RegistrationDate = this.dtpThirdPatientRegistrationDate.Value.Date;
            inLb.Patient.RegistrationNumber = this.txtThirdPatientRegistrationNumber.Text;
            inLb.Patient.Address = this.txtThirdAddress.Text;
            inLb.TokenMonthYear = Convert.ToInt64(DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString());
            inLb.TokenBy = IsloginUser;

            inLb.Room.Name = frm3rd.pr.Room.Name;
            inLb.Room.LabelName = frm3rd.pr.Room.LabelName;
            
            try
            {
                GetNextTokenNumber3nd();
                //if (inLabBll.SavePatientTokenInjandLabTest(inLb))
              //  if (inLabBll.SavePatientTokenInjandLabTest(inLb))
                {
                  //  if (inLb.Injections.Count > 0)
                      //  new InjectionLabTestBLL().SetPharmacyIssued(inLb.Injections);
                    //if (inLb.Tests.Count > 0)
                    //    new InjectionLabTestBLL().SetPharmacyIssued(inLb.Tests);
                   // if (inLb.AssignedLabTest.Count > 0)
                    //    new InjectionLabTestBLL().SetPaidLabTest(inLb.AssignedLabTest);
              

                    //GetNextTokenNumber3nd();
                    //ClearThidTurnControls();
                    //MessageBox.Show("Patient Registered Successfully", "Token Granted");
                    ///new code starts
                    ///

                  //  InjectionLabTest inLb = new InjectionLabTest();
                    inLb.IsInjectionToken = false;
                    if (rbThirdGeneral.Checked == true)
                        inLb.Type = PatientPayType.General;
                    else if (rbThirdPoor.Checked == true)
                        inLb.Type = PatientPayType.Poor;
                    else if (rbThirdYCDO.Checked == true)
                        inLb.Type = PatientPayType.YCOD;
                    //if (lbxPaidMedicine.Items.Count > 0)
                    //{
                    //    foreach (LabTest item in medications)
                    //    {
                    //        inLb.Tests.Add(item);
                    //    }
                    //}

                    //Int64 exTokNo = 0;
                    Int64.TryParse(txtThirdExistingToken.Text, out exTokNo);
                    inLb.ExistingTokenNo = exTokNo;
                    inLb.TokenNumber = Convert.ToInt32(this.lblThirdMainToken.Text);
                    inLb.CashReceived = Convert.ToDouble(this.txtThirdCashReceived.Text.Trim());
                    inLb.Patient.FirstName = this.txtThirdFirstName.Text;
                    inLb.Patient.LastName = this.txtThirdLastName.Text;
                    inLb.Patient.NIC = this.txtThirdCNIC.Text;
                    inLb.Patient.Mobile = this.txtThirdMobile.Text;
                    inLb.Patient.Age = Convert.ToInt16(this.txtThirdAge.Text);
                    inLb.Patient.RegistrationDate = this.dtpThirdPatientRegistrationDate.Value.Date;
                    inLb.TokenDate = System.DateTime.Now;
                    inLb.Patient.RegistrationNumber = this.txtThirdPatientRegistrationNumber.Text;
                    //inLb.Patient.Address = this.txtPatientAddress2nd.Text;
                    inLb.TokenMonthYear = Convert.ToInt64(DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString());
                    inLb.TokenBy = IsloginUser;

                    inLb.Room.Name = frm3rd.pr.Room.Name;
                    inLb.Room.LabelName = frm3rd.pr.Room.LabelName;

                    //if (inLabBll.SavePatientToken(inLb))                  ----------- Disable/Change  -- Asif - 29-04-19
                    if (inLabBll.SavePatientTokenInjandLabTest(inLb))
                    {
                        inLabBll.SetPaidLabTest(inLb.AssignedLabTest);

                        List<LabTest> labtests=new List<LabTest>();
                        List<LabTest> pendings = new List<LabTest>();
                        labtests = new InjectionLabTestBLL().GetMedicineIssued(prCancel);

                        pendings = labtests.Where(pen => pen.IsRsTenInjection == true || pen.IsAlwaysPaid == true).ToList<LabTest>();
                        //new InjectionLabTestBLL().SetPaidLabTest(pendings);
                        if (new InjectionLabTestBLL().SetPharmacyIssued(pendings) == true)
                   
                       // pendings = labtests.Where(pen => pen.IsRsTenInjection == true || pen.IsAlwaysPaid == true).ToList<LabTest>();
                  
                        //foreach (LabTest cancelAlwaysPaid in pendings)
                        //{
                        //    new PatientBLL().MedicineCanceled(prCancel, cancelAlwaysPaid);
                        //}
                        ClearThidTurnControls();
                        ////////////////---------------------------- Asif - 13-04-19
                        //foreach (LabTest item in free)
                        //{
                        //    inLb.Tests.Remove(item);
                        //}
                        ////////////////---------------------------- Asif - 13-04-19
                        PrintPreviewLabandInj(False, inLb);
                        MessageBox.Show("Patient Registered Successfully", "Token Granted");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Patient Registration Error");
            }

        }
        private void PrintPreviewLabandInj(bool preview, InjectionLabTest pr)
        {
            prt = new DsPatientRegistration.PatientRegistrationDataTable();
            foreach (var item in pr.Tests)
            {
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Mobile, item.TestName + " Qty : " + item.TimesADay + "*" + item.TotalDays + "=" + (item.TimesADay * item.TotalDays) + " " + item.TimesADayUrdu, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.CashReceivedByUser };                              ------- Asif -- 02-04-19
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Mobile, item.TestName + " " + item.TimesADayNumber, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.CashReceivedByUser };                                                                                                                          ------- Asif -- 08-04-19
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, pr.ExistingTokenNo, item.TestName + " \n" + item.TimesADayNumber, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.CashReceivedByUser, pr.TokenBy };                                                                                                                 ------- Asif -- 20-04-19
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.ExistingTokenNo, item.TestName + " (" + (item.TimesADay * item.TotalDays) + ")\n" + item.TimesADayUrdu, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name + '-' + pr.Room.LabelName, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.CashReceivedByUser, pr.TokenBy };  ------- Asif -- 01-06-19
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.ExistingTokenNo, item.TestName + " (" + (item.TimesADay * item.TotalDays) + ")\n" + item.TimesADayUrdu, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name + '-' + pr.Room.LabelName, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, item.TotalDays, pr.TokenBy };
                prt.LoadDataRow(values, true);
            }
            foreach (var item in pr.Injections)
            {
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Mobile, item.TestName + " Qty : " + item.TimesADay + "*" + item.TotalDays + "=" + (item.TimesADay * item.TotalDays) + " " + item.TimesADayUrdu, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };                              ------- Asif -- 02-04-19
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Mobile, item.TestName + " " + item.TimesADayNumber, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };                                                                                                                          ------- Asif -- 08-04-19
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, pr.ExistingTokenNo, item.TestName + " \n" + item.TimesADayNumber, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.TokenBy };                                                                                                                 ------- Asif -- 20-04-19
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.ExistingTokenNo, item.TestName + " (" + (item.TimesADay * item.TotalDays) + ")\n" + item.TimesADayUrdu, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name + '-' + pr.Room.LabelName, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.TokenBy };  ------- Asif -- 01-06-19
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.ExistingTokenNo, item.TestName + " (" + (item.TimesADay * item.TotalDays) + ")\n" + item.TimesADayUrdu, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name + '-' + pr.Room.LabelName, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, item.TotalDays, pr.TokenBy };
                prt.LoadDataRow(values, true);
            }
            foreach (var item in pr.AssignedLabTest)
            {
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Mobile, item.TestName + " Qty : " + item.TimesADay + "*" + item.TotalDays + "=" + (item.TimesADay * item.TotalDays) + " " + item.TimesADayUrdu, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };     ------- Asif -- 02-04-19
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Mobile, item.TestName + " " + item.TimesADayNumber, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };                                                                                                 ------- Asif -- 11-04-19
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.ExistingTokenNo, item.TestName, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name + '-' + pr.Room.LabelName, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.CashReceivedByUser, pr.TokenBy };                          ------- Asif -- 01-06-19
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.ExistingTokenNo, item.TestName, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name + '-' + pr.Room.LabelName, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, item.TotalDays, pr.TokenBy };
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
            crp.SetParameterValue("CashRecievedByUser", pr.CashReceivedByUser);
            crp.SetParameterValue("ComplaintNo", "Complaint #: " + CompNo);
            
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
        private void tsSyring_Click(object sender, EventArgs e)
        {
            new frmSyringSelection().Show();
        }
        private void GetNextTokenNumber3nd()
        {
            this.lblThirdMainToken.Text = new InjectionLabTestBLL().GetNextTokenNumber().ToString("00000");   
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnThirdExistingToken_Click(object sender, EventArgs e)
        {
            frm3rd = new FrmExistingToken();
            frm3rd.Reprint = true;
            frm3rd.ShowDialog();
            if (frm3rd.pr != null)
            {
                prCancel = frm3rd.pr;
                PopulateExistingToken3rd();
                if (lbxInjection.Items.Count > 0)
                {
                    chxSyringThird.Checked = false;
                    chxSyringThird.Visible = true;
                }
                //txtThirdExistingToken.Text = frm.pr.TokenNumber.ToString();
                //txtThirdExistingToken.Visible = true;
                //txtThirdPatientRegistrationNumber.Text = frm.pr.Patient.RegistrationNumber;
                //dtpThirdPatientRegistrationDate.Value = frm.pr.Patient.RegistrationDate;
                //txtThirdFirstName.Text = frm.pr.Patient.FirstName;
                //txtThirdLastName.Text = frm.pr.Patient.LastName;
                //txtThirdCNIC.Text = frm.pr.Patient.NIC;
                //txtThirdAddress.Text = frm.pr.Patient.Address;
                //medications = new InjectionLabTestBLL().GetMedicineIssued(frm.pr);
                //assignedLabtest = new InjectionLabTestBLL().GetLabTestAssignedUnPaid(frm.pr);
                //alwaysPaid = medications.Where(inj => inj.IsAlwaysPaid == true).ToList<LabTest>();
                //rs10= medications.Where(rs => rs.IsRsTenInjection == true).ToList<LabTest>();
                //List<LabTest> free = medications.Where(f => f.IsAlwaysPaid != true && f.IsRsTenInjection != true).ToList<LabTest>();
                ////clear paid medicine from previous entries
                //this.lbxPaidMedicine.Items.Clear();
                //foreach (LabTest item in alwaysPaid)
                //{
                //    this.lbxPaidMedicine.Items.Add(item);
                //}
                ////clear rs 10 injection from previous entries
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

                ////clear free medicine previous entries
                //this.lbxFreeMedicine.Items.Clear();
                //foreach (LabTest lt in free)
                //{
                //    this.lbxFreeMedicine.Items.Add(lt);
                //}

                //this.lbxLabTest.Items.Clear();
                //foreach (LabTest item in assignedLabtest)
                //{
                //    this.lbxLabTest.Items.Add(item);
                //}
                //this.txtThirdFreeTotal.Text = "0";
                //CalculateCashRecv3nd();
            }
        }

        private void ClearThidTurnControls()
        {
            this.txtThirdPatientRegistrationNumber.Clear();
            this.txtThirdFirstName.Clear();
            this.txtThirdLastName.Clear();
            this.txtThirdCNIC.Clear();
            this.txtThirdAge.Clear();
            this.txtThirdAddress.Clear();
            this.lbxFreeMedicine.Items.Clear();
            this.lbxInjection.Items.Clear();
            this.lbxPaidMedicine.Items.Clear();
            this.lbxLabTest.Items.Clear();
            this.txtThirdPaidLabTest.Text = "0";
            this.txtThirdPaidTotal.Text = "0";
            this.txtThirdInjectionTotal.Text = "0";
            this.txtThirdFreeTotal.Text = "0";
            this.txtThirdCashReceived.Text = "0";
            txtCashRecievedByUser.Clear();
            this.txtThirdRoom.Clear();
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
            txtThirdMobile.Text = frm3rd.pr.Patient.Mobile;
            txtThirdAge.Text = frm3rd.pr.Patient.Age.ToString();
            txtThirdAddress.Text = frm3rd.pr.Patient.Address;
            medications = new InjectionLabTestBLL().GetMedicineIssued(frm3rd.pr);
            assignedLabtest = new InjectionLabTestBLL().GetLabTestAssignedUnPaid(frm3rd.pr);
            alwaysPaid = medications.Where(inj => inj.IsAlwaysPaid == true).ToList<LabTest>();
            rs10 = medications.Where(rs => rs.IsRsTenInjection == true).ToList<LabTest>();
            free= medications.Where(f => f.IsAlwaysPaid != true && f.IsRsTenInjection != true).ToList<LabTest>();

            // Room & Dr selected from Doctor Checkup                   -------- Asif - 01-05-19
            txtThirdRoom.Text = frm3rd.pr.Room.Name + " - " + frm3rd.pr.Room.LabelName;
            
            //clear paid medicine from previous entries
            
            string TimesaDay = "";
            this.lbxPaidMedicine.Items.Clear();
            foreach (LabTest item in alwaysPaid)
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
            this.lbxInjection.Items.Clear();
            foreach (LabTest item in rs10)
            {
                item.CurrentAmount = 10;
                this.lbxInjection.Items.Add(item);
            }
            if (this.lbxInjection.Items.Count > 0)
                this.txtThirdInjectionTotal.Text = (10 * lbxInjection.Items.Count).ToString();
            else
                this.txtThirdInjectionTotal.Text = "0";

            //clear free medicine previous entries
            this.lbxFreeMedicine.Items.Clear();
            foreach (LabTest lt in free)
            {
                if (lt.TimesADay == 1)
                    TimesaDay = "od";
                if (lt.TimesADay == 2)
                    TimesaDay = "bd";
                if (lt.TimesADay == 3)
                    TimesaDay = "td";
                this.lbxFreeMedicine.Items.Add(lt + ":" + TimesaDay);

            }
            this.lbxLabTest.Items.Clear();
            foreach (LabTest item in assignedLabtest)
            {
                this.lbxLabTest.Items.Add(item);
            }
            this.txtThirdFreeTotal.Text = "0";
            CalculateCashRecv3nd();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            ClearThidTurnControls();
        }

        private void tsmInjectionCancel_Click(object sender, EventArgs e)
        {
            if (lbxInjection.SelectedItem == null)
            {
                MessageBox.Show("Please Select Rs.10 Injection To Cancel", "Injection Not Selected");
                return;
            }

            LabTest cancelfree = rs10[this.lbxInjection.SelectedIndex];

            if (MessageBox.Show("do you really want to cancel the Rs.10 Injection? " + cancelfree.TestName, " Cancel Injection", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (new PatientBLL().MedicineCanceled(prCancel, cancelfree))
                    MessageBox.Show(cancelfree.TestName + " is canceled");
                PopulateExistingToken3rd();
            }
        }

        private void tsmPaidCancel_Click(object sender, EventArgs e)
        {
            if (lbxPaidMedicine.SelectedItem == null)
            {
                MessageBox.Show("Please Select Medicine To Cancel", "Medicine Not Selected");
                return;
            }

            LabTest cancelfree = alwaysPaid[this.lbxPaidMedicine.SelectedIndex];

            if (MessageBox.Show("do you really want to cancel the Medicine? " + cancelfree.TestName, " Cancel Medicine", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (new PatientBLL().MedicineCanceled(prCancel, cancelfree))
                    MessageBox.Show(cancelfree.TestName + " is canceled");
                PopulateExistingToken3rd();
            }
        }

        private void tsmLabtestCancel_Click(object sender, EventArgs e)
        {
            if (lbxLabTest.SelectedItem == null)
            {
                MessageBox.Show("Please Select LabTest To Cancel", "LabTest Not Selected");
                return;
            }

            LabTest cancelfree = assignedLabtest[this.lbxLabTest.SelectedIndex];

            if (MessageBox.Show("do you really want to cancel the LabTest? " + cancelfree.TestName, " Cancel LabTest", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (new PatientBLL().LabTestCanceled(prCancel, cancelfree))
                    MessageBox.Show(cancelfree.TestName + " is canceled");
                PopulateExistingToken3rd();
            }
        }

        FrmExistingToken frm3rdreprnt = new FrmExistingToken();
        private void tsReprintToken_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////////////////
            InjectionLabTest inLb = new InjectionLabTest();
            PrintDuplicate = true;

            //frm3rdreprnt.Reprint = true;
            frm3rdreprnt.ShowDialog();
            if (frm3rdreprnt.inLb != null)
            {
            //    assignedLabtest = new InjectionLabTestBLL().GetLabTestAssignedUnPaid3(frm3rdreprnt.inLb);
            //    foreach (var item in assignedLabtest)
            //    {
            //        if (frm3rdreprnt.inLb.Type == PatientPayType.General)
            //            frm3rdreprnt.inLb.CashReceived += Convert.ToDouble(item.General);
            //        if (frm3rdreprnt.inLb.Type == PatientPayType.YCOD)
            //            frm3rdreprnt.inLb.CashReceived += Convert.ToDouble(item.YCDO);
            //        if (frm3rdreprnt.inLb.Type == PatientPayType.Poor)
            //            frm3rdreprnt.inLb.CashReceived += Convert.ToDouble(item.Poor);
            //        if (frm3rdreprnt.inLb.Type == PatientPayType.Deserving)
            //            frm3rdreprnt.inLb.CashReceived += Convert.ToDouble(item.Deserving);
            //    }
                //frm3rdreprnt.inLb.AssignedLabTest = assignedLabtest;
                //assignedLabtest = frm3rdreprnt.inLb.Tests.Where(t => t.IsMedicine == false).ToList<LabTest>();

                frm3rdreprnt.inLb.AssignedLabTest = frm3rdreprnt.inLb.Tests.Where(t => t.IsMedicine == false).ToList<LabTest>(); 
                frm3rdreprnt.inLb.Tests = frm3rdreprnt.inLb.Tests.Where(t => t.IsMedicine == true).ToList<LabTest>();
                
                PrintPreviewLabandInj(false, frm3rdreprnt.inLb);
            }
            //////////////////////////////////////////////////////////////////////////////////////
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




        public bool False { get; set; }

        private void lbxPaidMedicine_KeyDown(object sender, KeyEventArgs e)
        {
            ListBox lbx = sender as ListBox;
            if (e.KeyCode == Keys.Delete)
            {
                if (lbx.SelectedIndex >= 0)
                {
                    int deleteIndex = lbxPaidMedicine.SelectedIndex;
                    //lbx.Items.RemoveAt(deleteIndex);
                    string temp1 = lbxPaidMedicine.SelectedItem.ToString().Substring(0, lbxPaidMedicine.SelectedItem.ToString().Length - 3);
                    alwaysPaid = medications.Where(inj => inj.IsAlwaysPaid == true && inj.TestName != temp1).ToList<LabTest>();
                    if (lbx.Name == lbxPaidMedicine.Name)
                        lbxPaidMedicine.Items.RemoveAt(deleteIndex);
                    //alwaysPaiddel = alwaysPaid.RemoveAt(lbxPaidMedicine.SelectedIndex);
                    CalculateCashRecv3nd();
                }

            }
        }
        //List<LabTest> alwaysPaiddel;
        private void lbxLabTest_KeyDown(object sender, KeyEventArgs e)
        {
            ListBox lbx = sender as ListBox;
            if (e.KeyCode == Keys.Delete)
            {
                if (lbx.SelectedIndex >= 0)
                {
                    int deleteIndex = lbxLabTest.SelectedIndex;
                    //lbx.Items.RemoveAt(deleteIndex);
                    string temp1 = lbxLabTest.SelectedItem.ToString().Substring(0, lbxLabTest.SelectedItem.ToString().Length);
                    assignedLabtest = assignedLabtest.Where(inj => inj.TestName != temp1).ToList<LabTest>();
                    if (lbx.Name == lbxLabTest.Name)
                        lbxLabTest.Items.RemoveAt(deleteIndex);
                    CalculateCashRecv3nd();
                }

            }
        }

        private void lbxFreeMedicine_KeyDown(object sender, KeyEventArgs e)
        {
                        ListBox lbx = sender as ListBox;
                        if (e.KeyCode == Keys.Delete)
                        {
                            if (lbx.SelectedIndex >= 0)
                            {
                                int deleteIndex = lbxFreeMedicine.SelectedIndex;
                                //lbx.Items.RemoveAt(deleteIndex);
                                if (lbx.Name == lbxFreeMedicine.Name)
                                    lbxFreeMedicine.Items.RemoveAt(deleteIndex);
                                CalculateCashRecv3nd();
                            }
                        }

        }



    }
}
