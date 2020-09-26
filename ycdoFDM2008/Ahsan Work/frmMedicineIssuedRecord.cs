﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
using FDM.SearchForms;
namespace FDM
{
    public partial class frmMedicineIssuedRecord : Form
    {
        public PatientRegistration Current { get; set; }
        List<LabTest> labtests = new List<LabTest>();
          string strAlwaysPaid = " (Always Paid)";
        string strInjection = " (Rs.10 Injection)";
        bool  Verified =false;
        public frmMedicineIssuedRecord(PatientRegistration current)
        {
            InitializeComponent();
            this.Current = current;
        }

        private void frmMedicineIssuedRecord_Load(object sender, EventArgs e)
        {
            if (Current != null)
            {
                PatientRegistration pr = new InjectionLabTestBLL().GetPatientRegistration(Current);
                txtPatientRegistrationNumber.Text = pr.Patient.RegistrationNumber;
                txtPatientName.Text = pr.Patient.FirstName;
                this.txtPatientName.Text = pr.Patient.FirstName + " " + Current.Patient.LastName;
                this.txtPatientRegistrationNumber.Text = pr.Patient.RegistrationNumber;
                this.txtPatientDetails.Text += "CNIC #:" +pr.Patient.NIC + Environment.NewLine;
                this.txtPatientDetails.Text += "Address :" +pr.Patient.Address + Environment.NewLine;
                this.txtPatientDetails.Text += "Type :" + pr.TokenType.ToString() + Environment.NewLine;
                lblToken.Text = pr.TokenNumber.ToString();
                lblReg.Text = pr.Patient.RegistrationNumber.ToString();
                labtests = new InjectionLabTestBLL().GetMedicineIssued2(pr);


                for (int i = 0; i < labtests.Count; i++)
                {
                    LabTest lbt = new LabTest();
                    lbt = labtests[i];

                    int switchCase = Convert.ToInt32(lbt.TimesADay);
                    string caseString = "";
                    switch (switchCase)
                    {
                        case 1:
                            caseString = "od";
                            break;
                        case 2:
                            caseString = "bd";
                            break;
                        case 3:
                            caseString = "tds";
                            break;
                        default:
                            break;
                    }
                    if (lbt.IsAlwaysPaid == true)
                    {
                        caseString += " : " + strAlwaysPaid;
                        Verified = false;
                    }
                    else if (lbt.IsRsTenInjection == true)
                    {
                        caseString += " : " + strInjection;
                        Verified = false;
                    }
                    lstLabTest.Items.Add(lbt.TestName + " : " + caseString);
                }
            }
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
