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
namespace FDM
{
    public partial class frmPatientRegistration : Form
    {
        public frmPatientRegistration()
        {
            InitializeComponent();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        PatientBLL pbll = new PatientBLL();
        InjectionLabTestBLL inLabBll = new InjectionLabTestBLL();
        List<LabTest> labtests = new List<LabTest>();
        private void tsSave_Click(object sender, EventArgs e)
        {
            if (tcPatientRegistration.SelectedTab == tpSecondTurn)
            {
                InjectionLabTest inLb = new InjectionLabTest();

                inLb.TokenDate = System.DateTime.Today;
                inLb.TokenNumber = Convert.ToInt64(this.lblCurrentTokenNumber2nd.Text.Trim());

                if (rbInjection.Checked == true)
                {
                    inLb.IsInjectionToken = true;
                    inLb.Type = 0;
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
                        }
                    }
                }
                Int64 exTokNo = 0;
                Int64.TryParse(txtExistingToken.Text,out exTokNo);
                inLb.ExistingTokenNo = exTokNo;
                inLb.CashReceived = Convert.ToDouble(this.txtCashRecieved2nd.Text.Trim());
                inLb.Patient.FirstName = this.txtPatientFirstName2nd.Text;
                inLb.Patient.LastName = this.txtPatientLastName2nd.Text;
                inLb.Patient.NIC = this.txtPatientCNIC2nd.Text;
                inLb.Patient.RegistrationDate = this.dtpPatientRegistration2nd.Value.Date;
                inLb.Patient.RegistrationNumber = this.txtPateintRegistrationNumber2nd.Text;
                inLb.Patient.Address = this.txtPatientAddress2nd.Text;
                inLb.TokenMonthYear = Convert.ToInt64(DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString());

                try
                {
                    if (inLabBll.SavePatientToken(inLb))
                    {
                        if (inLb.IsInjectionToken)
                            PrintPreviewInjection(false, inLb);
                        else
                            PrintPreviewLab(false, inLb);
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
            else if (tcPatientRegistration.SelectedTab == tpFirstTurn)
            {
                PatientRegistration pr = new PatientRegistration();
                try
                {
                    pr.TokenDate = System.DateTime.Today;
                    pr.TokenNumber = Convert.ToInt64(this.lblCurrentTokenNumber.Text.Trim());
                    pr.TokenType = (rbGeneral.Checked) ? TokenType.General : TokenType.Private;
                    pr.CashReceived = Convert.ToDouble(this.txtCashRecieved.Text.Trim());
                    pr.Patient.FirstName = this.txtPatientFirstName.Text;
                    pr.Patient.LastName = this.txtPatientLastName.Text;
                    pr.Patient.NIC = this.txtPatientCNIC.Text;
                    pr.Patient.RegistrationDate = this.dtpPatientRegistrationDate.Value.Date;
                    pr.Patient.RegistrationNumber = this.txtPateintRegistrationNumber.Text;
                    pr.Patient.Address = this.txtPatientAddress.Text;
                    pr.TokenMonthYear = Convert.ToInt64(DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString());
                    if (this.lstRooms.SelectedItem != null)
                        pr.Room = (Room)this.lstRooms.SelectedItem;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Patient Registration Data");
                }
                try
                {
                    if (pbll.SavePatientToken(pr))
                    {
                        PrintPreview(false, pr);
                        GetNextTokenNumber();
                        NewPatient();
                        MessageBox.Show("Patient Registered Successfully", "Token Granted");
                        this.txtPatientFirstName.Focus();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save Patient Registration Error");
                }
            }

        }

        private void PrintPreviewLab(bool preview, InjectionLabTest pr)
        {
            prt = new DsPatientRegistration.PatientRegistrationDataTable();
            foreach (var item in pr.Tests)
            {
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, item.TestName , pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
                prt.LoadDataRow(values, true);
            }
            rptLabTestToken crp = new rptLabTestToken();
            //crp.SetDataSource((DataTable)prt);
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
        DsPatientRegistration.PatientRegistrationDataTable prt;
        private void PrintPreviewInjection(bool preview, InjectionLabTest pr)
        {
            prt = new DsPatientRegistration.PatientRegistrationDataTable();
            object[] values = { 0, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Address, pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, this.txtExistingToken.Text , pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
            prt.LoadDataRow(values, true);
            rptInectionToken  crp = new rptInectionToken();
            //crp.SetDataSource((DataTable)prt);
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
        private void PrintPreview(bool preview, PatientRegistration pr)
        {
            prt = new DsPatientRegistration.PatientRegistrationDataTable();
            object[] values = { 0, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Address, pr.TokenType, pr.CashReceived, pr.Room.Name, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
            prt.LoadDataRow(values, true);
            rptTokenReceipt crp = new rptTokenReceipt();
            //crp.SetDataSource((DataTable)prt);
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
        private void rbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGeneral.Checked)
                this.txtCashRecieved.Text = ((int)TokenType.General).ToString();
            else
                this.txtCashRecieved.Text = ((int)TokenType.Private).ToString();
        }
        RoomBLL rbll = new RoomBLL();
        private void frmPatientRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                //initialize the cash received value by token value
                this.txtCashRecieved.Text = ((int)TokenType.General).ToString();

                //load the rooms 
                this.lstRooms.DataSource = rbll.GetRooms();

                //set the current Date
                this.lblTokenDate.Text = System.DateTime.Today.ToString("dd/MM/yyyy");

                //set the current Token Number
                GetNextTokenNumber();

                //Create Unique Patient Registration Number
                AssignPatientRegistrationNumber();

                //assign focus to patient first Name
                this.txtPatientFirstName.Focus();


                labtests = new LabTestBLL().GetLabTests();
                cbxLabTest.DataSource = labtests;
                cbxLabTest.DisplayMember = "TestName";
                cbxLabTest.ValueMember = "LabTestId";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Patient Registration Screen");
            }
        }
        private void NewPatient()
        {
            try
            {
                AssignPatientRegistrationNumber();
                this.dtpPatientRegistrationDate.Value = DateTime.Now;
                this.txtPatientAddress.Text = "";
                this.txtPatientCNIC.Text = "";
                this.txtPatientFirstName.Text = "";
                this.txtPatientLastName.Text = "";
                this.rbGeneral.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Patient Registration");
            }


        }

        private void NewPatient2nd()
        {
            try
            {
                AssignPatientRegistrationNumber2nd();
                this.dtpPatientRegistration2nd.Value = DateTime.Now;
                this.txtPatientAddress2nd.Text = "";
                this.txtPatientCNIC2nd.Text = "";
                this.txtPatientFirstName2nd.Text = "";
                this.txtPatientLastName2nd.Text = "";
                this.rbDeserving  .Checked = true;
                this.rbInjection.Checked = true;
                lstLabTest.Items.Clear();
                this.txtExistingToken.Text = "0";
                this.txtExistingToken.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Patient Registration2");
            }


        }
        private void GetNextTokenNumber()
        {
            this.lblCurrentTokenNumber.Text = pbll.GetNextTokenNumber().ToString("00000");
        }
        private void GetNextTokenNumber2nd()
        {
            this.lblCurrentTokenNumber2nd.Text = new InjectionLabTestBLL().GetNextTokenNumber().ToString("00000");
        }
        private void AssignPatientRegistrationNumber()
        {
            string registrationNumber = (DateTime.Now.ToString().Replace("/", "").Replace(":", "")).Replace(" ", "");
            this.txtPateintRegistrationNumber.Text = registrationNumber.Remove(registrationNumber.Length - 2, 2);
        }
        private void AssignPatientRegistrationNumber2nd()
        {
            string registrationNumber = (DateTime.Now.ToString().Replace("/", "").Replace(":", "")).Replace(" ", "");
            this.txtPateintRegistrationNumber2nd.Text = registrationNumber.Remove(registrationNumber.Length - 2, 2);
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            NewPatient();
        }

        private void tcPatientRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tcPatientRegistration.SelectedTab == tpSecondTurn)
            {
                //set the current Date
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

        }

        private void rbInjection_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInjection.Checked == true)
            {
                txtCashRecieved2nd.Text = "10";
                gbLabTest.Visible = false;
            }
            else
            {
                txtCashRecieved2nd.Text = "0";
                gbLabTest.Visible = true;
            }
        }

        private void btnAddLabTest_Click(object sender, EventArgs e)
        {
            if (cbxLabTest.SelectedValue != null)
            {

                int id =(int) cbxLabTest.SelectedValue;
                LabTest lbt = new LabTest(id);
                lbt =labtests [ labtests.IndexOf(lbt)];
                if(lstLabTest.Items.Contains(lbt)==false )
                    lstLabTest.Items.Add(lbt);

                CalculateCashRecv2nd();
            }
        }
        private void CalculateCashRecv2nd()
        {
            decimal cash = 0;
            if (rbInjection.Checked == false)
            {
                foreach (LabTest  item in lstLabTest.Items )
                {
                    if (rbDeserving.Checked == true)
                    {
                        cash += item.Deserving;
                        item.CurrentAmount = item.Deserving;
                    }
                    else if (rbGeneral2nd.Checked == true)
                    {
                        cash += item.General ;
                        item.CurrentAmount = item.General;
                    }
                    else if (rbPoor.Checked == true)
                    {
                        cash += item.Poor ;
                        item.CurrentAmount = item.Poor;
                    }
                    else if (rbYCOD.Checked == true)
                    {
                        cash += item.YCDO ;
                        item.CurrentAmount = item.YCDO;
                    }
                }
                txtCashRecieved2nd.Text = cash.ToString ();
            }
            else
                txtCashRecieved2nd.Text = "10";
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
        /// <summary>
        /// It is common function of rbDeserving , rbPoor,rbGeneral2nd,rbYOCD in 2nd Turn Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientPayType_Changed(object sender, EventArgs e)
        {

            CalculateCashRecv2nd();
        }

        private void btnExistingToken_Click(object sender, EventArgs e)
        {
            FrmExistingToken frm = new FrmExistingToken();
            frm.Reprint = true;
            frm.ShowDialog();
            if (frm.pr != null)
            {
                txtExistingToken.Text = frm.pr.TokenNumber.ToString () ;

                txtExistingToken.Visible = true;

                txtPateintRegistrationNumber2nd.Text = frm.pr.Patient.RegistrationNumber;
                dtpPatientRegistration2nd.Value = frm.pr.Patient.RegistrationDate;
                txtPatientFirstName2nd.Text = frm.pr.Patient.FirstName;
                txtPatientLastName2nd.Text = frm.pr.Patient.LastName;
                txtPatientCNIC2nd.Text = frm.pr.Patient.NIC;
                txtPatientAddress2nd.Text = frm.pr.Patient.Address;
            }
            else
            {
                txtExistingToken.Text = "0";
                txtExistingToken.Visible = false;
            }
            
        }
        FrmExistingToken frm = new FrmExistingToken();
        private void tsReprintToken_Click(object sender, EventArgs e)
        {
            if (tcPatientRegistration.SelectedTab == tpSecondTurn)
            {
                frm.Reprint = false;
                frm.ShowDialog();
                if (frm.inLb != null)
                {
                    if (frm.inLb.IsInjectionToken == true)
                        PrintPreviewInjection(false, frm.inLb);
                    else
                        PrintPreviewLab(false, frm.inLb);
                }
            }
            else if(tcPatientRegistration.SelectedTab == tpFirstTurn )
            {
                frm.Reprint = true;
                frm.ShowDialog();
                if (frm.pr != null)
                {
                    PrintPreview(false, frm.pr);
                }
            }
        }

      
    }
}
