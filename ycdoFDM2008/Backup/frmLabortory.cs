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
namespace FDM
{
    public partial class frmLabortory : Form
    {
        public frmLabortory()
        {
            InitializeComponent();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsGetNewTokens_Click(object sender, EventArgs e)
        {
            LoadTokens();
            this.txtRemarks.Text = string.Empty;
        }

        private void dgvTokens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        List<PatientRegistration> patients;
        PatientRegistration pr;
        private void dgvTokens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTokens.RowCount > 0)
            {
                pr = patients[e.RowIndex];
                DataGridViewPopulate(pr);               
            }
        }
        LabTest lt = new LabTest();
       // LabTestRemarks ltRem = new LabTestRemarks();
        private void DataGridViewPopulate(PatientRegistration pr)
        {
         
            long nextTokenNumber = pr.TokenNumber;
            this.lblCurrentTokenNumber.Text = nextTokenNumber.ToString("00000");
            this.lblToDate.Text = pr.TokenDate.ToShortDateString();
            PatientRegistration prNew = new InjectionLabTestBLL().GetPatientRegistrationLab(pr);
            PopulatePatientDetails(prNew);
            this.lstLabTest.Items.Clear();
            List<LabTest> labs = new InjectionLabTestBLL().GetLabTestAssigned(prNew);
            prNew.LabTests = labs;
            if (prNew.LabTests.Count > 0)
            {
                foreach (LabTest lbt in prNew.LabTests)
                {
                    this.lstLabTest.Items.Add(lbt);
                   
                }
            }

        }
        private void LoadTokens()
        {
            //this.dgvTokens.Rows.Clear();
            patients = new PatientBLL().GetPatientLabTestDetail();
            this.dgvTokens.DataSource = null;
            this.dgvTokens.DataSource = patients;
            for (int i = 0; i < dgvTokens.Columns.Count; i++)
            {
                if (dgvTokens.Columns[i].Name != "TokenNumber" && dgvTokens.Columns[i].Name != "TokenDate")
                { dgvTokens.Columns[i].Visible = false; }
                else
                    dgvTokens.Columns[i].Width = 80;
            }
          
            //for (int j = 0; j < patients.Count; j++)
            //{
            //    object[] values = { patients[j].TokenNumber, patients[j].TokenDate.ToShortDateString() };
            //    this.dgvTokens.Rows.Add(values);
            //    List<LabTest> labs = new InjectionLabTestBLL().GetLabTestAssigned(patients[j]);
            //    if (labs.Count > 0)
            //    {
            //        patients[j].LabTests = labs.Where(unperformed=>unperformed .IsTestPerformed == false).ToList<LabTest>();
            //    }
            //}
            if (patients.Count > 0)
            {
                pr = patients[0];
                DataGridViewPopulate(pr);
            }
        }

        private void frmLabortory_Load(object sender, EventArgs e)
        {
            LoadTokens();
        }
       
        private void btnSaveRemarks_Click(object sender, EventArgs e)
        {
            LabTestRemarks ltr = new LabTestRemarks();
            if (lstLabTest.Items.Count > 0)
            {
                if (this.lstLabTest.SelectedItem == null)
                {
                    MessageBox.Show("Please Select the Test to Give Remarks", "Remarks");
                    return;
                }
                ltr.LabTest = (LabTest)this.lstLabTest.SelectedItem;
                ltr.Remarks = this.txtRemarks.Text.Trim();
                ltr.IsTestPerformed = true;
                if (MessageBox.Show("Do you want to Save Remarks? ", "Save Remarks", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                if (new PatientBLL().SaveLabTestRemarks(pr, ltr) == true)
                {
                    MessageBox.Show("Congratulations Remarks Saved Successfully!!!", "Remarks Saved");
                    lstLabTest.Items.RemoveAt(lstLabTest.SelectedIndex);
                    this.txtRemarks.Text = string.Empty;
                }
               
              
            }
            if (lstLabTest.Items.Count==0)
            {
                LoadTokens();
                this.txtRemarks.Text = string.Empty;
            }
        }

      
    }
}
