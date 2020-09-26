using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using PCComm;
using PCComm.Properties;
using BLL;
namespace FDM
{
    public partial class frmPharmacyMedicine : Form
    {
        CommunicationManager comm;
        PatientBLL pbll = new PatientBLL();
        public frmPharmacyMedicine()
        {
            InitializeComponent();
        }
        //public frmPharmacyMedicine(CommunicationManager cm)
        //{
        //    InitializeComponent();
        //    this.comm = cm;
        //}
        //public Room CurrentRoom { get; set; }
        PatientRegistration pr;

        List<LabTest> labtests = new List<LabTest>();

        private void frmDoctorCheckup_Load(object sender, EventArgs e)
        {
            try
            {
                //frmDoctorChecupRoom fdcr = new frmDoctorChecupRoom();
                //fdcr.ShowDialog();
                //if (fdcr.DialogResult == DialogResult.Yes)
                //{
                //    //this.CurrentRoom = fdcr.CurrentRoom;
                //    //this.lblRoom.Text = CurrentRoom.Name;

                //    //labtests = new LabTestBLL().GetMedicines();
                //    //cbxLabTest.DataSource = labtests;
                //    //cbxLabTest.DisplayMember = "TestName";
                //    //cbxLabTest.ValueMember = "LabTestId";

                //}
                //else
                //{
                //    this.Close();
                //}

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Doctor Checup Load");
            }

            try
            {
               // NextTokenData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connecting L E D");
            }
        }
        private void PopulatePatientDetails(PatientRegistration pr)
        {

            this.txtPatientName.Text = pr.Patient.FirstName + " " + pr.Patient.LastName;
            this.txtPatientRegistrationNumber.Text = pr.Patient.RegistrationNumber;
            this.txtPatientDetails.Text += "CNIC #:" + pr.Patient.NIC + Environment.NewLine;
            this.txtPatientDetails.Text += "Address :" + pr.Patient.Address + Environment.NewLine;
            this.txtPatientDetails.Text += "Type :" + pr.TokenType.ToString() + Environment.NewLine;
        }
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void NextTokenData()
        //{
        //    rbOneDay.Checked = true;
        //    lstLabTest.Items.Clear();
        //    long nextTokenNumber = pbll.GetNextTokenNumber(CurrentRoom);
        //    pr = pbll.GetPatientDetail(nextTokenNumber, CurrentRoom);
        //    this.lblCurrentTokenNumber.Text = nextTokenNumber.ToString("00000");
        //    PopulatePatientDetails(pr);
        //    // comm.WriteDataWithoutDisplay("*" + this.lblCurrentTokenNumber.Text + "#");
        //}
        private void btnNext_Click(object sender, EventArgs e)
        {
            //List<LabTest> meds = new List<LabTest>();

            //for (int i = 0; i < lstLabTestId.Items.Count; i++)
            //{
            //    LabTest med = new LabTest();
            //    med.LabTestId = Convert.ToInt32(lstLabTestId.Items[i].ToString());
            //    meds.Add(med);
            //}
            //pbll.PatientChecked(pr, meds);

            //NextTokenData();
            
        }
        private void HideShowLoading(bool b)
        {
            //this.pbxLoading.Visible = b;
            //this.lblLoadingNextToken.Visible = b;
        }

        private void btnAddLabTest_Click(object sender, EventArgs e)
        {
            

        }

        private void lstLabTest_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Delete)
            //{
            //    if (lstLabTest.SelectedIndex >= 0)
            //    {
            //        lstLabTest.Items.RemoveAt(lstLabTest.SelectedIndex);
            //        lstLabTestId.Items.RemoveAt(lstLabTest.SelectedIndex);
            //        //CalculateCashRecv2nd();
            //    }

            //}
        }

        private void tsExistingToken_Click(object sender, EventArgs e)
        {
            try
            {
                FrmExistingTokenForPharmacy frm = new FrmExistingTokenForPharmacy();
                
                frm.ShowDialog();
                if (frm.pr != null)
                {
                    //rbOneDay.Checked = true;
                    lstLabTest.Items.Clear();
                    this.lblCurrentTokenNumber.Text = frm.pr.TokenNumber.ToString("00000");
                    PopulatePatientDetails(frm.pr);

                    labtests=new List<LabTest>();
                    labtests.AddRange(frm.Medicines);
                    for (int i = 0; i < labtests.Count ; i++)
                    {
                        LabTest lbt = new LabTest();
                        lbt = labtests[i];
                        lstLabTest.Items.Add(lbt + " TimesADay:" + lbt.TimesADay);
                       // lstLabTestId.Items.Add(lbt.LabTestId + "," + lbt.TimesADay + "," + lbt.MedIssuedID);
                        
                    }
                    
                }
                else
                
                {
                    frm.pr = new PatientRegistration();
                    PopulatePatientDetails(frm.pr);
                    labtests.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tsMedicienIssued_Click(object sender, EventArgs e)
        {
            try
            {
                if (labtests.Count > 0)
                {
                    if (new InjectionLabTestBLL().SetPharmacyIssued(labtests) == true)
                    {
                        labtests.Clear();
                        lstLabTest.Items.Clear();
                        
                        PopulatePatientDetails(new PatientRegistration());

                        MessageBox.Show("Record Saved Successfully");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
