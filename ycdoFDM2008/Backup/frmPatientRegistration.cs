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
            
                PatientRegistration pr = new PatientRegistration();
                try
                {
                    pr.TokenDate = System.DateTime.Today;
                    //pr.TokenDate = System.DateTime.Now;
                    int num = 0;
                    List<InjectionLabTest> ilt = new List<InjectionLabTest>();
                    ilt=   new InjectionLabTestBLL().GetTokenNum(pr.TokenDate);
                    pr.TokenNumber = Convert.ToInt64(this.lblCurrentTokenNumber.Text.Trim());
                 // pr.TokenNumber = ilt[0].TokenNumber+1;
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
           // }

        }
        private void PrintPreviewLabandInj(bool preview, InjectionLabTest pr)
        {
            prt = new DsPatientRegistration.PatientRegistrationDataTable();
            foreach (var item in pr.Tests)
            {
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, item.TestName + " Qty : " + (item.TimesADay * item.TotalDays), pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
                prt.LoadDataRow(values, true);
            }
            foreach (var item in pr.Injections)
            {
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, item.TestName + " Qty : " + (item.TimesADay * item.TotalDays), pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
                prt.LoadDataRow(values, true);
            }
            foreach (var item in pr.AssignedLabTest)
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
        private void PrintPreviewLab(bool preview, InjectionLabTest pr)
        {
            prt = new DsPatientRegistration.PatientRegistrationDataTable();
            foreach (var item in pr.Tests)
            {
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, item.TestName + " Qty : " + (item.TimesADay * item.TotalDays)   , pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
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
        DsPatientRegistration.PatientRegistrationDataTable prt;
      
        private void PrintPreview(bool preview, PatientRegistration pr)
        {
            string BranchName = ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();
            prt = new DsPatientRegistration.PatientRegistrationDataTable();
            object[] values = { 0, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Address, pr.TokenType, pr.CashReceived, pr.Room.Name, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
            prt.LoadDataRow(values, true);
            rptTokenReceipt crp = new rptTokenReceipt();
            crp.SetDataSource((DataTable)prt);
            crp.SetParameterValue("Duplicate", PrintDuplicate);
            crp.SetParameterValue("Name", BranchName);
            crp.SetParameterValue("Address", BranchAddress);
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;
            if (preview)
                frmViewer.ShowDialog();
            else
            {
                //frmViewer.crystalReportViewer1.RefreshReport();
                frmViewer.crystalReportViewer1.PrintReport();
            }
            PrintDuplicate = false;
        }
        private void rbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGeneral.Checked)
                this.txtCashRecieved.Text = ((int)TokenType.General).ToString();
            else
                this.txtCashRecieved.Text = ((int)TokenType.Private).ToString();
        }
        RoomBLL rbll = new RoomBLL();
        List<Membership> members;
        LabTest defaultSyring;
        private void frmPatientRegistration_Load(object sender, EventArgs e)
        {
            defaultSyring = new LabTestBLL().GetSyring();
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

       
        private void GetNextTokenNumber()
        {
            this.lblCurrentTokenNumber.Text = pbll.GetNextTokenNumber().ToString("00000");
        }
      
        private void AssignPatientRegistrationNumber()
        {
            string registrationNumber = (DateTime.Now.ToString().Replace("/", "").Replace(":", "")).Replace(" ", "");
            this.txtPateintRegistrationNumber.Text = registrationNumber.Remove(registrationNumber.Length - 2,2);
        }
        

        private void tsNew_Click(object sender, EventArgs e)
        {
            NewPatient();
        }

        FrmExistingToken frm = new FrmExistingToken();
        bool PrintDuplicate;
        private void tsReprintToken_Click(object sender, EventArgs e)
        {
            PrintDuplicate = true;
        
                frm.Reprint = true;
                frm.ShowDialog();
                if (frm.pr != null)
                {
                    PrintPreview(false, frm.pr);
                }
         
        }
        public void ClearControls()
        {
            this.txtPatientAddress.Text = "";
            this.txtPatientCNIC.Text = "";
            this.txtPatientFirstName.Text = "";
            this.txtPatientLastName.Text = "";
        }
        SchPatient sp = new SchPatient();
        private void txtPateintRegistrationNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ClearControls();
                
                sp.ShowDialog();
                if (sp.CurrentPatient != null)
                {
                    //if (tcPatientRegistration.SelectedTab == tpFirstTurn)
                    //{
                        this.txtPatientFirstName.Text = sp.CurrentPatient.FirstName;
                        this.txtPatientLastName.Text = sp.CurrentPatient.LastName;
                        this.txtPatientCNIC.Text = sp.CurrentPatient.NIC;
                        this.txtPatientAddress.Text = sp.CurrentPatient.Address;
                        this.txtPateintRegistrationNumber.Text = sp.CurrentPatient.RegistrationNumber;
                        this.dtpPatientRegistrationDate.Value = sp.CurrentPatient.RegistrationDate;
                        if (sp.CurrentPatient.PatientType == "General")
                        {
                            rbGeneral.Checked = true;

                        }
                        if (sp.CurrentPatient.PatientType == "Private")
                        {
                            rbPrivate.Checked = true;
                        }
                
                }
                
            }
        }

        List<LabTest> assignedLabtest = new List<LabTest>();
        List<LabTest> rs10 = new List<LabTest>();
       

       

        private void tsSyring_Click(object sender, EventArgs e)
        {
            new frmSyringSelection().Show();
        }

        private void rbGeneral_CheckedChanged_1(object sender, EventArgs e)
        {

        }

      

     
        }

      
     

     

        
      

      
    }

