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
    public partial class frmSecondTurn : Form
    {
        public frmSecondTurn()
        {
            InitializeComponent();
        }
        LabTest defaultSyring;
        InjectionLabTestBLL inLabBll = new InjectionLabTestBLL();
        List<LabTest> labtests = new List<LabTest>();
        DsPatientRegistration.PatientRegistrationDataTable prt;
        public User IsloginUser;
        bool PrintDuplicate;
        RoomBLL rbll = new RoomBLL();
        private void tsSave_Click(object sender, EventArgs e)
        {

            if (txtCashRecievedByUser.Text == "")
            {
                MessageBox.Show("First Enter Received Cash");
                return;
            }

            List<LabTest> assignedLabTest2nd = new List<LabTest>();
            InjectionLabTest inLb = new InjectionLabTest();
            //inLb.TokenDate = System.DateTime.Today;
            inLb.TokenDate = System.DateTime.Now;
            GetNextTokenNumber2nd();
            inLb.TokenNumber = Convert.ToInt64(this.lblCurrentTokenNumber2nd.Text.Trim());
            if (rbInjection.Checked == true)
            {
                inLb.IsInjectionToken = true;
                inLb.InjectionId = ((LabTest)this.cbxRs10.SelectedItem).LabTestId;
                inLb.Patient.Address = ((LabTest)this.cbxRs10.SelectedItem).TestName;
                inLb.Type = 0;
                if (chxSyringe.Checked)
                {
                    defaultSyring.CurrentAmount = 0;
                    inLb.Injections.Add(defaultSyring);
                }
                LabTest defaultInjection = ((LabTest)this.cbxRs10.SelectedItem);
                defaultInjection.CurrentAmount = 10;
                inLb.Injections.Add(defaultInjection);
            }
            else
            {
                //lab test token
                inLb.IsInjectionToken = false;
                if (rbDeserving.Checked == true)
                    inLb.Type = PatientPayType.Deserving;
                else if (rbGeneral2nd.Checked == true)
                    inLb.Type = PatientPayType.General;
                else if (rbPoor.Checked == true)
                    inLb.Type = PatientPayType.Poor;
                else if (rbYCOD.Checked == true)
                    inLb.Type = PatientPayType.YCOD;


                if (lstLabTest.Items.Count > 0)
                {
                    foreach (LabTest item in lstLabTest.Items)
                    {
                        inLb.Tests.Add(item);
                        if (item.IsMedicine == false)
                            assignedLabTest2nd.Add(item);
                    }
                }
            }
            Int64 exTokNo = 0;
            Int64.TryParse(txtExistingToken.Text, out exTokNo);
            inLb.ExistingTokenNo = exTokNo;
            inLb.CashReceived = Convert.ToDouble(this.txtCashRecieved2nd.Text.Trim());
            inLb.CashReceivedByUser = Convert.ToDouble(this.txtCashRecievedByUser.Text);
            inLb.Patient.FirstName = this.txtPatientFirstName2nd.Text;
            inLb.Patient.LastName = this.txtPatientLastName2nd.Text;
            inLb.Patient.NIC = this.txtPatientCNIC2nd.Text;
            inLb.Patient.Mobile = this.txtPatientMobile2nd.Text;
            inLb.Patient.Age = Convert.ToInt16(this.txtPatientAge2nd.Text);
            inLb.Patient.RegistrationDate = this.dtpPatientRegistration2nd.Value.Date;

            inLb.Patient.RegistrationNumber = this.txtPateintRegistrationNumber2nd.Text;
            inLb.Patient.Address = this.txtPatientAddress2nd.Text;
            inLb.TokenMonthYear = Convert.ToInt64(DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString());
            // inLb.Patient.Member = cbxmembers.Text.Trim();
            inLb.TokenBy = IsloginUser;

            if (this.cbxRooms.SelectedItem != null)
                inLb.Room = (Room)this.cbxRooms.SelectedItem;

            try
            {
                if (inLabBll.SavePatientToken(inLb))
                {

                    if (assignedLabTest2nd.Count > 0)
                    {
                        PatientBLL pbll = new PatientBLL();
                        pbll.LabTestAssignedPaid(inLb, assignedLabTest2nd);
                    }
                    if (inLb.IsInjectionToken)
                        PrintPreviewInjection(false, inLb);
                    else
                    {
                        inLb.AssignedLabTest = assignedLabTest2nd;
                        inLb.Tests = inLb.Tests.Where(t => t.IsMedicine == true).ToList<LabTest>();
                        PrintPreviewLab(false, inLb);
                    }

                    GetNextTokenNumber2nd();
                    NewPatient2nd();
                    MessageBox.Show("Patient Registered Successfully", "Token Granted");
                    this.txtPatientFirstName2nd.Focus();
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
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, item.TestName + " Qty : " + item.TimesADay + "*" + item.TotalDays+"=" + (item.TimesADay * item.TotalDays) + " " + item.TimesADayUrdu, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.CashReceivedByUser };           ------- Asif - 13-04-19
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.Patient.Mobile, pr.ExistingTokenNo, item.TestName, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.CashReceivedByUser, pr.TokenBy };
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.ExistingTokenNo, item.TestName + " (" + (item.TimesADay * item.TotalDays) + ")\n" + item.TimesADayUrdu, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name + '-' + pr.Room.LabelName, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.CashReceivedByUser, pr.TokenBy };    ------- Asif -- 01-06-19
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.ExistingTokenNo, item.TestName + " (" + (item.TimesADay * item.TotalDays) + ")\n" + item.TimesADayUrdu, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name + '-' + pr.Room.LabelName, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, item.TotalDays, pr.TokenBy };
                prt.LoadDataRow(values, true);
            }
            foreach (var item in pr.AssignedLabTest)
            {
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, item.TestName + " Qty : " + item.TimesADay + "*" + item.TotalDays+"=" + (item.TimesADay * item.TotalDays) + " " + item.TimesADayUrdu, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.CashReceivedByUser };           ------- Asif - 13-04-19
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.Patient.Mobile, pr.ExistingTokenNo, item.TestName, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.CashReceivedByUser, pr.TokenBy };
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.ExistingTokenNo, item.TestName, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.Room.Name + '-' + pr.Room.LabelName, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, pr.CashReceivedByUser, pr.TokenBy };                                  ------- Asif -- 01-06-19
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
        private void PrintPreviewInjection(bool preview, InjectionLabTest pr)
        {
            string BranchName = ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();
            string CompNo = ConfigurationManager.AppSettings["ComplaintNo"].ToString();
            prt = new DsPatientRegistration.PatientRegistrationDataTable();
            if (pr.Injections.Count == 0)
            {
                object[] values = { 0, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.Patient.Mobile, "", pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
                prt.LoadDataRow(values, true);
            }
            else
                foreach (LabTest item in pr.Injections)
                {
                    object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.Patient.Mobile, item.TestName, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, this.txtExistingToken.Text, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
                    prt.LoadDataRow(values, true);
                }



            rptInectionToken crp = new rptInectionToken();
            crp.SetDataSource((DataTable)prt);
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;
            crp.SetParameterValue("Duplicate", PrintDuplicate);
            crp.SetParameterValue("Name", BranchName);
            crp.SetParameterValue("Address", BranchAddress);
            crp.SetParameterValue("ComplaintNo", "Complaint #: " + CompNo);
            if (preview)
                frmViewer.ShowDialog();
            else
            {
                //frmViewer.crystalReportViewer1.RefreshReport();
                frmViewer.crystalReportViewer1.PrintReport();
            }
            PrintDuplicate = false;
        }
        private void GetNextTokenNumber2nd()
        {
            this.lblCurrentTokenNumber2nd.Text = new InjectionLabTestBLL().GetNextTokenNumber().ToString("00000");
        }
        private void AssignPatientRegistrationNumber2nd()
        {
            string registrationNumber = (DateTime.Now.ToString().Replace("/", "").Replace(":", "")).Replace(" ", "");
            this.txtPateintRegistrationNumber2nd.Text = registrationNumber.Remove(registrationNumber.Length - 2, 2);
        }
        private void NewPatient2nd()
        {
            try
            {
                txtCashRecievedByUser.Text = "";
                AssignPatientRegistrationNumber2nd();
                this.dtpPatientRegistration2nd.Value = DateTime.Now;
                this.txtPatientAddress2nd.Text = "";
                this.txtPatientCNIC2nd.Text = "";
                this.txtPatientAge2nd.Text = "";
                this.txtPatientMobile2nd.Text = "";
                this.txtPatientFirstName2nd.Text = "";
                this.txtPatientLastName2nd.Text = "";
                this.rbDeserving.Checked = true;
                this.rbInjection.Checked = true;
                lstLabTest.Items.Clear();
                this.txtExistingToken.Text = "0";
                this.txtExistingToken.Visible = false;
                this.cbxRooms.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Patient Registration2");
            }


        }
        private void CalculateCashRecv2nd()
        {
            decimal cash = 0;
            if (rbInjection.Checked == false)
            {
                foreach (LabTest item in lstLabTest.Items)
                {
                    if (rbDeserving.Checked == true)
                    {
                        item.CurrentAmount = item.Deserving;
                        cash += item.GetLineTotal();
                    }
                    else if (rbGeneral2nd.Checked == true)
                    {
                        item.CurrentAmount = item.General;
                        cash += item.GetLineTotal();
                    }
                    else if (rbPoor.Checked == true)
                    {
                        item.CurrentAmount = item.Poor;
                        cash += item.GetLineTotal();
                    }
                    else if (rbYCOD.Checked == true)
                    {
                        item.CurrentAmount = item.YCDO;
                        cash += item.GetLineTotal();
                    }
                }
                txtCashRecieved2nd.Text = cash.ToString();
            }
            else
                txtCashRecieved2nd.Text = "10";
        }
        private void frmSecondTurn_Load(object sender, EventArgs e)
        {
            try
            {
                List<Room> rooms = rbll.GetRooms();
                this.cbxRooms.DataSource = rooms;

                defaultSyring = new LabTestBLL().GetSyring();

                labtests = new LabTestBLL().GetLabTests();
                cbxLabTest.DataSource = labtests;
                cbxLabTest.DisplayMember = "TestName";
                cbxLabTest.ValueMember = "LabTestId";

                List<LabTest> rs10 = labtests.Where(inj => inj.IsRsTenInjection == true).ToList<LabTest>();
                cbxRs10.DataSource = null;
                cbxRs10.DataSource = rs10;


                this.lblTokenDate2nd.Text = System.DateTime.Today.ToString("dd/MM/yyyy");

                //set the current Token Number for 2nd Turn if not exist.
                Int64 tokenNo = 0;
                Int64.TryParse(lblCurrentTokenNumber2nd.Text, out tokenNo);
                if (tokenNo < 0)
                {
                    GetNextTokenNumber2nd();
                    AssignPatientRegistrationNumber2nd();

                    txtCashRecieved2nd.Text = "10";
                    gbLabTest.Visible = false;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        FrmExistingToken frm = new FrmExistingToken();
        private void btnExistingToken_Click(object sender, EventArgs e)
        {
            FrmExistingToken frm = new FrmExistingToken();
            frm.Reprint = true;
            frm.ShowDialog();
            if (frm.pr != null)
            {
                txtExistingToken.Text = frm.pr.TokenNumber.ToString();
                txtExistingToken.Visible = true;
                txtPateintRegistrationNumber2nd.Text = frm.pr.Patient.RegistrationNumber;
                dtpPatientRegistration2nd.Value = frm.pr.Patient.RegistrationDate;
                txtPatientFirstName2nd.Text = frm.pr.Patient.FirstName;
                txtPatientLastName2nd.Text = frm.pr.Patient.LastName;
                txtPatientCNIC2nd.Text = frm.pr.Patient.NIC;
                txtPatientAge2nd.Text = frm.pr.Patient.Age.ToString();
                txtPatientMobile2nd.Text = frm.pr.Patient.Mobile;
                txtPatientAddress2nd.Text = frm.pr.Patient.Address;
                //Prescribed Medicines
                //  lstLabTest.Items.Clear();
                //  txtCashRecieved.Clear();
                //  medications = new InjectionLabTestBLL().GetMedicineIssued(frm.pr);
                //  assignedLabtest = new InjectionLabTestBLL().GetLabTestAssignedUnPaid(frm.pr);
                //  alwaysPaid = medications.Where(inj => inj.IsAlwaysPaid == true).ToList<LabTest>();
                //  rs10 = medications.Where(rs => rs.IsRsTenInjection == true).ToList<LabTest>();
                //  free = medications.Where(f => f.IsAlwaysPaid != true && f.IsRsTenInjection != true).ToList<LabTest>();
                //  //clear paid medicine from previous entries
                // // this.lbxPaidMedicine.Items.Clear();
                //  foreach (LabTest item in alwaysPaid)
                //  {
                //      lstLabTest.Items.Add(item);
                //      txtSecondPaidTotal.Text += item.CurrentAmount.ToString();
                //  }
                //  //clear rs 10 injection from previous entries
                // // this.lbxInjection.Items.Clear();
                //  foreach (LabTest item in rs10)
                //  {
                //      item.CurrentAmount = 10;
                //      this.lstLabTest.Items.Add(item);
                //      txtSecondInjTotal.Text+=(10 * item.CurrentAmount);
                //  }
                //  //if (this.lbxPrescribedMedicines.Items.Count > 0)
                //  //    this.txtFee.Text = (10 * lbxInjection.Items.Count).ToString();
                //  //else
                //  //    this.txtThirdInjectionTotal.Text = "0";

                //  //clear free medicine previous entries
                //  //this.lbxFreeMedicine.Items.Clear();
                //  foreach (LabTest lt in free)
                //  {
                //      this.lstLabTest.Items.Add(lt);
                //  }

                ////  this.lbxLabTest.Items.Clear();
                //  foreach (LabTest item in assignedLabtest)
                //  {
                //      this.lstLabTest.Items.Add(item);
                //  }
                //CalculateCashRecv2nd2();
                //this.txtThirdFreeTotal.Text = "0";
                //End Of Prescribed Medicines

            }
            else
            {
                txtExistingToken.Text = "0";
                txtExistingToken.Visible = false;
            }
        }

        private void btnAddLabTest_Click(object sender, EventArgs e)
        {
            if (cbxLabTest.SelectedValue != null)
            {
                int id = (int)cbxLabTest.SelectedValue;
                LabTest lbt = new LabTest(id);
                lbt = labtests[labtests.IndexOf(lbt)];
                if (lstLabTest.Items.Contains(lbt) == false)
                {
                    if (rbTwoDay.Checked)
                        lbt.TimesADay = 2;
                    else if (rbThreeDay.Checked)
                        lbt.TimesADay = 3;
                    else if (rbOneDay.Checked)
                        lbt.TimesADay = 1;
                    decimal days = 1;
                    bool r = decimal.TryParse(this.txtDays.Text.Trim(), out days);
                    lbt.TotalDays = days;
                    lstLabTest.Items.Add(lbt);
                }
                CalculateCashRecv2nd();
            }
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbInjection_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInjection.Checked == true)
            {
                txtCashRecieved2nd.Text = "10";
                cbxLabTest.Text = "";
                gbLabTest.Visible = false;
                cbxRs10.Visible = true;
                lblRS10.Visible = true;
                chxSyringe.Checked = false;
                chxSyringe.Visible = true;
            }
            else
            {
                txtCashRecieved2nd.Text = "0";
                gbLabTest.Visible = true;
                cbxRs10.Visible = false;
                lblRS10.Visible = false;
                chxSyringe.Visible = false;
            }
        }
        private void PatientPayType_Changed(object sender, EventArgs e)
        {

            CalculateCashRecv2nd();
        }

        private void tsReprintToken_Click(object sender, EventArgs e)
        {
            PrintDuplicate = true;
            frm.Reprint = false;
            frm.ShowDialog();
            if (frm.inLb != null)
            {
                if (frm.inLb.IsInjectionToken == true)
                {
                    if (ModifierKeys == Keys.Control)
                        PrintPreviewInjection(true, frm.inLb);

                    else
                        PrintPreviewInjection(false, frm.inLb);
                }
                else
                {
                    frm.inLb.TokenBy = IsloginUser;
                    frm.inLb.AssignedLabTest = frm.inLb.Tests.Where(t => t.IsMedicine == false).ToList<LabTest>();
                    frm.inLb.Tests = frm.inLb.Tests.Where(t => t.IsMedicine == true).ToList<LabTest>();
                    
                    if (ModifierKeys == Keys.Control)
                        PrintPreviewLab(true, frm.inLb);
                    else
                        PrintPreviewLab(false, frm.inLb);
                }
            }
        }

        private void tsSyring_Click(object sender, EventArgs e)
        {
            new frmSyringSelection().Show();
        }
        //private void NewPatient2nd()
        //{
        //    try
        //    {
        //        AssignPatientRegistrationNumber2nd();
        //        this.dtpPatientRegistration2nd.Value = DateTime.Now;
        //        this.txtPatientAddress2nd.Text = "";
        //        this.txtPatientCNIC2nd.Text = "";
        //        this.txtPatientFirstName2nd.Text = "";
        //        this.txtPatientLastName2nd.Text = "";
        //        this.rbDeserving.Checked = true;
        //        this.rbInjection.Checked = true;
        //        lstLabTest.Items.Clear();
        //        this.txtExistingToken.Text = "0";
        //        this.txtExistingToken.Visible = false;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "New Patient Registration2");
        //    }


        //}

        private void tsNew_Click(object sender, EventArgs e)
        {
            NewPatient2nd();
        }

        private void cbxLabTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLabTest.SelectedItem != null)
            {
                LabTest currentTest = (LabTest)this.cbxLabTest.SelectedItem;
                if (currentTest.IsMedicine == false || currentTest.IsRsTenInjection == true)
                {
                    this.rbThreeDay.Enabled = false;
                    this.rbTwoDay.Enabled = false;
                    rbOneDay.Enabled = false;
                    txtDays.Enabled = false;
                }
                else
                {
                    txtDays.Enabled = true;
                    this.rbThreeDay.Enabled = true;
                    this.rbTwoDay.Enabled = true;
                    rbOneDay.Enabled = true;
                }
                if (currentTest.IsOd)
                {
                    this.rbThreeDay.Enabled = false;
                    this.rbTwoDay.Enabled = false;
                    this.rbOneDay.Checked = true;
                }
                else
                {
                    this.rbOneDay.Enabled = true;
                    this.rbTwoDay.Enabled = true;
                    this.rbThreeDay.Enabled = true;
                }
            }
        }

        private void lstLabTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lstLabTest.SelectedIndex >= 0)
                {
                    lstLabTest.Items.RemoveAt(lstLabTest.SelectedIndex);
                    CalculateCashRecv2nd();
                }

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

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

        private void txtCashRecievedByUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= (char)Keys.D0 && e.KeyValue <= (char)Keys.D9 || e.KeyValue == (char)Keys.Decimal || e.KeyValue == (char)Keys.Back || e.KeyValue == (char)Keys.Delete)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void lblCurrentTokenNumber2nd_Click(object sender, EventArgs e)
        {

        }
    }
}
