using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FDM.SearchForms;
using System.Configuration;
using DAL;
using Common;
using Common.Datasets;
using BLL;
namespace FDM
{
    public partial class frmdoctortoken : Form
    {
        LabTest defaultSyring;
        List<LabTest> alwaysPaid;

        List<LabTest> medications;
        List<LabTest> free;
        InjectionLabTestBLL inLabBll = new InjectionLabTestBLL();
        List<LabTest> assignedLabtest = new List<LabTest>();
        List<LabTest> rs10 = new List<LabTest>();
        PatientRegistration prCancel;
        bool PrintDuplicate;
        DsPatientRegistration.PatientRegistrationDataTable prt;
        
        public frmdoctortoken()
        {
            InitializeComponent();
        }
        FrmExistingToken frm = new FrmExistingToken();
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmdoctortoken_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frm.doctor = true;
            frm.ShowDialog();
            if (frm.pr != null)
            {
                prCancel = frm.pr;
                PopulateExistingToken();
            }
        }
            private void ClearThidTurnControls()
        {
            this.lbxFreeMedicine.Items.Clear();
            this.lbxInjection.Items.Clear();
            this.lbxPaidMedicine.Items.Clear();
            this.lbxLabTest.Items.Clear();
            
        }
            private void PopulateExistingToken3rd()
            {
                txtThirdPatientRegistrationNumber.Text = frm.pr.Patient.RegistrationNumber;
                dtpThirdPatientRegistrationDate.Value = frm.pr.Patient.RegistrationDate;
                txtThirdFirstName.Text = frm.pr.Patient.FirstName;
                txtThirdLastName.Text = frm.pr.Patient.LastName;
                txtThirdCNIC.Text = frm.pr.Patient.NIC;
                txtThirdAddress.Text = frm.pr.Patient.Address;
                alwaysPaid = medications.Where(inj => inj.IsAlwaysPaid == true).ToList<LabTest>();
                medications = new InjectionLabTestBLL().GetMedicineIssued3(frm.pr);
                assignedLabtest = new InjectionLabTestBLL().GetLabTestAssignedUnPaid2(frm.pr);
                rs10 = medications.Where(rs => rs.IsRsTenInjection == true).ToList<LabTest>();
                List<LabTest> free = medications.Where(f => f.IsAlwaysPaid != true && f.IsRsTenInjection != true).ToList<LabTest>();
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
                
            }

            private void PopulateExistingToken()
            {
                txtThirdPatientRegistrationNumber.Text = frm.pr.Patient.RegistrationNumber;
                dtpThirdPatientRegistrationDate.Value = frm.pr.Patient.RegistrationDate;
                txtThirdFirstName.Text = frm.pr.Patient.FirstName;
                txtThirdLastName.Text = frm.pr.Patient.LastName;
                txtThirdCNIC.Text = frm.pr.Patient.NIC;
                txtThirdAddress.Text = frm.pr.Patient.Address;
                medications = new InjectionLabTestBLL().GetMedicineIssued3(frm.pr);
                assignedLabtest = new InjectionLabTestBLL().GetLabTestAssignedUnPaid2(frm.pr);
                alwaysPaid = medications.Where(inj => inj.IsAlwaysPaid == true).ToList<LabTest>();
                rs10 = medications.Where(rs => rs.IsRsTenInjection == true).ToList<LabTest>();
                List<LabTest> free = medications.Where(f => f.IsAlwaysPaid != true && f.IsRsTenInjection != true).ToList<LabTest>();
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
                
            }   

    }
}
