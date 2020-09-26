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
    public partial class FrmExistingToken : Form
    {
        public FrmExistingToken()
        {
            InitializeComponent();
        }

        public PatientRegistration pr;
        public InjectionLabTest inLb;
        public bool doctor = false;
        public bool Reprint = false;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Reprint == true)
            {
                Int64 tNo = 0, mYNo = 0;
                Int64.TryParse(txtTokenNo.Text, out tNo);
                InjectionLabTestBLL inLabBll = new InjectionLabTestBLL();
                PatientRegistration pr = inLabBll.GetPatientRegistration(new PatientRegistration(tNo, Convert.ToInt64(dateTimePicker1.Value.Month + "" + dateTimePicker1.Value.Year)));
                if (pr.Patient.RegistrationNumber != null && pr.Patient.RegistrationNumber != "")
                {
                    this.pr = pr;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid token no. for selected month and year");
                    txtTokenNo.Text = "0";
                }
            }
            else
            {
                Int64 tNo = 0, mYNo = 0;
                Int64.TryParse(txtTokenNo.Text, out tNo);
                InjectionLabTestBLL inLabBll = new InjectionLabTestBLL();
                InjectionLabTest inLb = inLabBll.GetInjectionLabTest(new InjectionLabTest(tNo, Convert.ToInt64(dateTimePicker1.Value.Month + "" + dateTimePicker1.Value.Year)));
                if (inLb.Patient.RegistrationNumber != null && inLb.Patient.RegistrationNumber != "")
                {
                    this.inLb = inLb;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid token no. for selected month and year");
                    
                }
            }
            if (doctor)
            {
                Int64 tNo = 0, mYNo = 0;
                Int64.TryParse(txtTokenNo.Text, out tNo);
                InjectionLabTestBLL inLabBll = new InjectionLabTestBLL();
                InjectionLabTest inLb = inLabBll.GetInjectionLabTest(new InjectionLabTest(tNo, Convert.ToInt32(dateTimePicker1.Value.Month + "" + dateTimePicker1.Value.Year)));
                PatientRegistration pr = inLabBll.GetPatientRegistration(new PatientRegistration(tNo, Convert.ToInt32(dateTimePicker1.Value.Month + "" + dateTimePicker1.Value.Year)));
                if (pr.Patient.RegistrationNumber != null && pr.Patient.RegistrationNumber != "")
                {
                    this.pr = pr;
                    this.inLb = inLb;
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Invalid token no. for selected month and year");
                    txtTokenNo.Text = "0";
                }
            
            
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmExistingToken_Load(object sender, EventArgs e)
        {

        }
    }
}
