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
using CrystalDecisions.CrystalReports.Engine;
namespace FDM
{
    public partial class frmPatientRegistration : CaptureForm
    {
        public frmPatientRegistration()
        {
            InitializeComponent();
        }
        public User IsLoginUser;

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
                   // pr.TokenDate = System.DateTime.Today;
                    pr.TokenDate = System.DateTime.Now;
                    int num = 0;
                    List<InjectionLabTest> ilt = new List<InjectionLabTest>();
                    ilt=   new InjectionLabTestBLL().GetTokenNum(pr.TokenDate);
                    pr.TokenNumber = Convert.ToInt64(this.lblCurrentTokenNumber.Text.Trim());
                 // pr.TokenNumber = ilt[0].TokenNumber+1;
                    pr.TokenType = (rbGeneral.Checked) ? TokenType.General : (rbPoor.Checked) ? TokenType.Poor : TokenType.Private;
                    //pr.TokenType = (rbGeneral.Checked) ? TokenType.General : TokenType.Private;------------------->>>>>>>>>
                    pr.CashReceived = Convert.ToDouble(this.txtCashRecieved.Text.Trim());
                    pr.Patient.FirstName = this.txtPatientFirstName.Text;
                    pr.Patient.LastName = this.txtPatientLastName.Text;
                    pr.Patient.NIC = this.txtPatientCNIC.Text;
                    pr.Patient.Age = Convert.ToInt16(this.txtPatientAge.Text);
                    pr.Patient.Mobile = this.txtPatientMobile.Text;
                    pr.Patient.RegistrationDate = this.dtpPatientRegistrationDate.Value.Date;
                    pr.Patient.RegistrationNumber = this.txtPateintRegistrationNumber.Text;
                    pr.Patient.Address = this.txtPatientAddress.Text;
                    pr.TokenMonthYear = Convert.ToInt64(DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString());

                    string BranchCode = ConfigurationManager.AppSettings["BranchCode"].ToString();
                    pr.Patient.RegistrationNumber = BranchCode;

                    pr.TokenBy = IsLoginUser;
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
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, item.TestName + " Qty : " + (item.TimesADay * item.TotalDays), pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.Patient.Mobile, item.TestName + " Qty : " + (item.TimesADay * item.TotalDays), pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
                prt.LoadDataRow(values, true);
            }
            foreach (var item in pr.Injections)
            {
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, item.TestName + " Qty : " + (item.TimesADay * item.TotalDays), pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.Patient.Mobile, item.TestName + " Qty : " + (item.TimesADay * item.TotalDays), pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
                prt.LoadDataRow(values, true);
            }
            foreach (var item in pr.AssignedLabTest)
            {
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, item.TestName + " Qty : " + (item.TimesADay * item.TotalDays), pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.Patient.Mobile, item.TestName + " Qty : " + (item.TimesADay * item.TotalDays), pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
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
                //object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, item.TestName + " Qty : " + (item.TimesADay * item.TotalDays), pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
                object[] values = { item.LabTestId, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.Patient.Mobile, item.TestName + " Qty : " + (item.TimesADay * item.TotalDays), pr.IsInjectionToken ? "Injection" : "Lab Test", pr.CashReceived, pr.ExistingTokenNo, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate };
                prt.LoadDataRow(values, true);
            }
            rptLabTestToken crp = new rptLabTestToken();
            crp.SetDataSource((DataTable)prt);
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;
            string BranchName = ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();
            string CompNo = ConfigurationManager.AppSettings["ComplaintNo"].ToString();
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
        DsPatientRegistration.PatientRegistrationDataTable prt;
      
        private void PrintPreview(bool preview, PatientRegistration pr)
        {
            string BranchName = ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();
            string CompNo = ConfigurationManager.AppSettings["ComplaintNo"].ToString();
            prt = new DsPatientRegistration.PatientRegistrationDataTable();///////// Token By Name Added
            pr.TokenBy = IsLoginUser;
            //object[] values = { 0, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Mobile, pr.Patient.Address, pr.TokenType, pr.CashReceived, pr.Room.Name, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, 0, pr.TokenBy.UserName };
            object[] values = { 0, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName + ' ' + pr.Patient.LastName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Age, pr.Patient.Mobile, pr.Patient.Address, pr.TokenType, pr.CashReceived, pr.Room.Name + '-' + pr.Room.LabelName, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, 0, pr.TokenBy.UserName };
            prt.LoadDataRow(values, true);
            rptTokenReceipt crp = new rptTokenReceipt();
            crp.SetDataSource((DataTable)prt);
            crp.SetParameterValue("Duplicate", PrintDuplicate);
            crp.SetParameterValue("Name", BranchName);
            crp.SetParameterValue("Address", BranchAddress);
            crp.SetParameterValue("ComplaintNo", "Complaint #: " + CompNo);
            FrmReportViewer frmViewer = new FrmReportViewer();

            frmViewer.crystalReportViewer1.ReportSource = crp;
            if (preview)
                frmViewer.ShowDialog();
            else
            {
                //frmViewer.crystalReportViewer1.RefreshReport();
                crp.PrintToPrinter(1, false, 0, 0);                 ////    -------- Asif -- 02-06-19   ----- Print Without Showing Print Dialog (Disallow Multiple Copies)
                //frmViewer.crystalReportViewer1.PrintReport();     ////    -------- Asif -- 02-06-19
            }


            //var dialog = new PrintDialog();

            //Nullable<bool> print = dialog.ShowDialog() == System.Windows.Forms.DialogResult.Yes ? true : false; ;
            //// if (print.HasValue && print.Value)
            //{
            //    var rd = new ReportDocument();

            //    //rd.ReportClientDocument
            //    rd.Load(Application.StartupPath + "\\Reports\\rptTokenReceipt.rpt");
            //    rd.SetParameterValue("Duplicate", PrintDuplicate);
            //    rd.SetParameterValue("Name", BranchName);
            //    rd.SetParameterValue("Address", BranchAddress);
            //    rd.SetDataSource((DataTable)prt);
            //    dialog.PrinterSettings.Copies = 1;
            //    rd.PrintOptions.PrinterName = dialog.PrinterSettings.PrinterName;
            //    MessageBox.Show("Printing");
            //    //rd.PrintToPrinter(dialog.PrinterSettings.PrinterName, false, 0, 0);
            //    try
            //    {

            //        rd.PrintToPrinter(1, true, 0, 1);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    try
            //    {

            //        rd.PrintToPrinter(1, true, 0, 0);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }


            //    // rd.PrintToPrinter(1, false, 0, 0);

            //    {

            //        //   System.Drawing.Printing.PrintDocument pDoc = new PrintDocument();
            //        CrystalDecisions.Shared.PrintLayoutSettings PrintLayout = new CrystalDecisions.Shared.PrintLayoutSettings();
            //        System.Drawing.Printing.PrinterSettings printerSettings = new System.Drawing.Printing.PrinterSettings();
            //        printerSettings.PrinterName = dialog.PrinterSettings.PrinterName;
            //        System.Drawing.Printing.PageSettings pSettings = new System.Drawing.Printing.PageSettings(printerSettings);
            //        rd.PrintOptions.DissociatePageSizeAndPrinterPaperSize = true;
            //        rd.PrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Simplex;

            //        //   OnMessageLogged(TraceEventType.Information, "PrePrint " + crReportDocument.PrintOptions.PrinterName);

            //        System.Security.Principal.WindowsImpersonationContext ctx = System.Security.Principal.WindowsIdentity.Impersonate(IntPtr.Zero);
            //        try
            //        {
            //            rd.PrintToPrinter(printerSettings, pSettings, false, PrintLayout);
            //            //   OnMessageLogged(TraceEventType.Information, "Printed " + pq.printerName);
            //        }
            //        catch (Exception eprint)
            //        {
            //            MessageBox.Show("Error" + eprint.Message);
            //            //OnMessageLogged(TraceEventType.Information, "****Failed to Print** to printer " + pq.printerName + " Exception " + eprint.ToString());
            //        }
            //        finally
            //        {
            //            // Resume impersonation
            //            ctx.Undo();
            //            //   OnMessageLogged(TraceEventType.Information, "Success Printing to " + pq.printerName);
            //        }
           // }

            //}
          
            PrintDuplicate = false;
        }
        private void rbPoor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPoor.Checked)
                this.txtCashRecieved.Text = ((int)TokenType.Poor).ToString();
        }
        private void rbGeneral_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbGeneral.Checked)
                this.txtCashRecieved.Text = ((int)TokenType.General).ToString();
        }
        private void rbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrivate.Checked)
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
                AssignPatientRegistrationNumber(pbll.GetNextTokenNumber());

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
                AssignPatientRegistrationNumber(pbll.GetNextTokenNumber());
                this.dtpPatientRegistrationDate.Value = DateTime.Now;
                this.txtPatientAddress.Text = "";
                this.txtPatientCNIC.Text = "";
                this.txtPatientAge.Text = "";
                this.txtPatientMobile.Text = "";
                this.txtPatientFirstName.Text = "";
                this.txtPatientLastName.Text = "";
                this.rbGeneral.Checked = true;
                lstRooms.ClearSelected();
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
      
        private void AssignPatientRegistrationNumber(long tokenNo)
        {
           // string registrationNumber = (DateTime.Now.ToString().Replace("/", "").Replace(":", "")).Replace(" ", "");

           long TokenMonthYear= Convert.ToInt64(DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString());
           string BranchCode = ConfigurationManager.AppSettings["BranchCode"].ToString();

           string registrationNumber = tokenNo + "" + TokenMonthYear + "" + BranchCode;

            this.txtPateintRegistrationNumber.Text = registrationNumber;
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
            this.txtPatientAge.Text = "";
            this.txtPatientMobile.Text = "";
            this.txtPatientFirstName.Text = "";
            this.txtPatientLastName.Text = "";
            lstRooms.SelectedIndex = -1;
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
                        this.txtPatientAge.Text = sp.CurrentPatient.Age.ToString();
                        this.txtPatientMobile.Text = sp.CurrentPatient.Mobile;
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
                        if (sp.CurrentPatient.PatientType == "Poor")
                        {
                            rbPoor.Checked = true;
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmPatients frmp = new frmPatients();
            frmp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstRooms.ClearSelected();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        //////-----------------------
        #region FingerPrint

        public delegate void OnTemplateEventHandler(DPFP.Template template);

        public event OnTemplateEventHandler OnTemplate;

        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Enrollment";
            Enroller = new DPFP.Processing.Enrollment();			// Create an enrollment.
            UpdateStatus();
        }

		protected override void Process(DPFP.Sample Sample)
		{
			base.Process(Sample);

			// Process the sample and create a feature set for the enrollment purpose.
			DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

			// Check quality of the sample and add to enroller if it's good
			if (features != null) try
			{
				MakeReport("The fingerprint feature set was created.");
				Enroller.AddFeatures(features);		// Add feature set to template.
			}
			finally {
				UpdateStatus();

				// Check if template has been created.
				switch(Enroller.TemplateStatus)
				{
					case DPFP.Processing.Enrollment.Status.Ready:	// report success and stop capturing
						OnTemplate(Enroller.Template);
						SetPrompt("Click Close, and then click Fingerprint Verification.");
						Stop();
						break;

					case DPFP.Processing.Enrollment.Status.Failed:	// report failure and restart capturing
						Enroller.Clear();
						Stop();
						UpdateStatus();
						OnTemplate(null);
						Start();
						break;
				}
			}
		}

		private void UpdateStatus()
		{
			// Show number of samples needed.
			SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
        }

        private DPFP.Processing.Enrollment Enroller;

        #endregion





    }



}

