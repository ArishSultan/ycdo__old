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
using Common.Enum;
using DAL;
namespace FDM
{
    public partial class frmPatientAdmission : Form
    {
        public frmPatientAdmission()
        {
            InitializeComponent();
        }
        List<PatientRegistration> patients;
        DataGridViewCellStyle pendingStyle = new DataGridViewCellStyle();
        public User IsLoginUser;
        public PatientAdmission CurrentAdmission = new PatientAdmission();
     
        PatientRegistration pr;

        private void LoadRoomTokens()
        {
            //sr = new StreamReader("C:\\" + this.name.Trim() + ".txt");
            //counter = Convert.ToInt32(sr.ReadLine());
            //sr.Close();
            //this.dgvTokens.Rows.Clear();
            patients = new PatientBLL().GetCheckedPatientDetails();
            this.dgvTokens.DataSource = null;
            this.dgvTokens.DataSource = patients;
            for (int i = 0; i < dgvTokens.Columns.Count; i++)
            {
                if (dgvTokens.Columns[i].Name != "TokenNumber" && dgvTokens.Columns[i].Name != "TokenDate")
                { dgvTokens.Columns[i].Visible = false; }
                else
                    dgvTokens.Columns[i].Width = 80;
            }
           // if (patients.Count > 0)
             //   LoadLabTests(patients[0]);
            //for (int j = 0; j < patients.Count; j++)
            //{
            //    //object[] values = { patients[j].TokenNumber, patients[j].TokenDate.ToShortDateString(), patients[j].TokenMonthYear };
            //    //this.dgvTokens.Rows.Add(values);
            //    List<LabTest> labs = new InjectionLabTestBLL().GetLabTestAssigned(patients[j]);
            //    if (labs.Count > 0)
            //    {
            //        this.dgvTokens.Rows[j].Cells["TokenNumber"].Style = pendingStyle;
            //        this.dgvTokens.Rows[j].Cells["TokenDate"].Style = pendingStyle;
            //        patients[j].LabTests = labs;
            //    }
            //}
        }

        private void ClearControls()
        {
           this.txtDiffDiag.Text="";
            this.txtProvDiag.Text="";
          this.txtPluse.Text="";
            this.txtTemp.Text="";
           this.txtRR.Text="";
            this.txtBPsys.Text="";
            this.txtBPdia.Text = "";
            CurrentAdmission = new PatientAdmission();

        }
        private void dgvTokens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTokens.RowCount > 0)
            {
                pr = patients[e.RowIndex];
                long nextTokenNumber = pr.TokenNumber;
                PopulatePatientDetails(pr);
                CurrentAdmission.PatientRegistration = pr;
             
            }
        }
        private void PopulatePatientDetails(PatientRegistration pr)
        {

            this.txtPatientName.Text = pr.Patient.FirstName + " " + pr.Patient.LastName;
            this.txtPatientRegistrationNumber.Text = pr.Patient.RegistrationNumber;
            this.txtPatientDetails.Text = "";
            this.txtPatientDetails.Text += "CNIC #:" + pr.Patient.NIC + Environment.NewLine;
            this.txtPatientDetails.Text += "Address :" + pr.Patient.Address + Environment.NewLine;
            this.txtPatientDetails.Text += "Type :" + pr.TokenType.ToString() + Environment.NewLine;
        }
      public  List<Diagnosis> listDiagnosis;
        
        private void frmPatientAdmission_Load(object sender, EventArgs e)
        {
            try
            {

               
               
                    //this.Text = name;
                    LoadRoomTokens();
                    //load medicines
                    listDiagnosis = new DiagnosisBLL().GetDiagnosis();
                  //  cbxDiffDiag.DataSource = listDiagnosis.Where(c => c.DiagnosisType == DiagnosisType.Differential);
                    List<Diagnosis> diff = listDiagnosis.Where(c => c.DiagnosisType == DiagnosisType.Differential).ToList<Diagnosis>();
                    cbxDiffDiag.DataSource = diff;
                cbxDiffDiag.DisplayMember = "Name";
                   cbxDiffDiag.ValueMember = "Code";

                   cbxProvDiag.DataSource = listDiagnosis.Where(c => c.DiagnosisType == DiagnosisType.Provisional).ToList<Diagnosis>();
                   cbxProvDiag.DisplayMember = "Name";
                   cbxProvDiag.ValueMember = "Code";
                    //load pathology test
                  //  pathology = new LabTestBLL().GetLabTest();
                  //  cbxPathologyTest.DataSource = pathology;
                  //  cbxPathologyTest.DisplayMember = "TestName";
                  //  cbxPathologyTest.ValueMember = "LabTestId";
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Doctor Checup Load");
            }
            
        }

        

        private void btnAddDiffDiag_Click(object sender, EventArgs e)
        {

            if (cbxDiffDiag.SelectedValue != null)
            {
                Diagnosis lbt = (Diagnosis)cbxDiffDiag.SelectedItem;
               
                string existing = this.txtDiffDiag.Text;
                this.txtDiffDiag.Text = existing + "," + lbt.Name;

            }
        }

        private void btnAddProveDiag_Click(object sender, EventArgs e)
        {
            if (cbxProvDiag.SelectedValue != null)
            {
                Diagnosis lbt = (Diagnosis)cbxProvDiag.SelectedItem;
               
                string existing = this.txtProvDiag.Text;
                this.txtProvDiag.Text = existing + "," + lbt.Name;

            }
        }

        private void cbxDiffDiag_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        
        private void tsSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                CurrentAdmission.DiffDiag = this.txtDiffDiag.Text;
                CurrentAdmission.provDiag = this.txtProvDiag.Text;
                CurrentAdmission.Pluse = Convert.ToInt32(this.txtPluse.Text);
                CurrentAdmission.Temp = Convert.ToDouble(this.txtTemp.Text);
                CurrentAdmission.RR = this.txtRR.Text;
                CurrentAdmission.BPsys = Convert.ToInt32(this.txtBPsys.Text);
                CurrentAdmission.BPdia = Convert.ToInt32(this.txtBPdia.Text);
                CurrentAdmission.AdmissoinDate = DateTime.Now;
                if (CurrentAdmission.PatientRegistration.PatientRegistrationNumber != null)
                {
                    PatientAdmissionDAL pdal = new PatientAdmissionDAL();
                    pdal.SavePatientAdmission(CurrentAdmission);
                    PrintPreview(true, CurrentAdmission);
                    ClearControls();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void PrintPreview(bool preview, PatientAdmission pa)
        {
            string BranchName = ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();

            DsPatientRegistration.PatientRegistrationDataTable prt = new DsPatientRegistration.PatientRegistrationDataTable();
            PatientRegistration pr = new PatientRegistration();
            pr = pa.PatientRegistration;
            pr.TokenBy = IsLoginUser;
            object[] values = { 0, pr.TokenDate, pr.TokenMonthYear, pr.TokenNumber, pr.Patient.FirstName, pr.Patient.LastName, pr.Patient.NIC, pr.Patient.Address, pr.TokenType, pr.CashReceived, pr.Room.Name, pr.Patient.RegistrationNumber, pr.Patient.RegistrationDate, 0, pr.TokenBy.UserName };
            prt.LoadDataRow(values, true);
            DSPatientAdmission.PatientAdmissionDataTable pat = new DSPatientAdmission.PatientAdmissionDataTable();
            object[] PAvalues = { pa.Pluse, pa.BP, pa.RR, pa.AdmissoinDate, pa.DiffDiag, pa.provDiag };

            pat.LoadDataRow(PAvalues, true);

            rptPatientClinicalRoport crp = new rptPatientClinicalRoport();
          //  crp.SetDataSource((DataTable)prt);
            crp.Database.Tables[0].SetDataSource((DataTable)pat); 
            crp.Database.Tables[1].SetDataSource((DataTable)prt); 

            crp.SetDataSource((DataTable)pat);
            crp.SetParameterValue("Name", BranchName);
            crp.SetParameterValue("Address", BranchAddress);
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;
            if (true)
                frmViewer.ShowDialog();
            else
            {
                frmViewer.crystalReportViewer1.RefreshReport();
                frmViewer.crystalReportViewer1.PrintReport();
            }


           

            
        }


    }
}
