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
    public partial class frmDoctorCheckup : Form
    {
        CommunicationManager comm;
        PatientBLL pbll = new PatientBLL();
        public frmDoctorCheckup()
        {
            InitializeComponent();
        }
        public frmDoctorCheckup(CommunicationManager cm)
        {
            InitializeComponent();
            this.comm = cm;
        }
        public Room CurrentRoom { get; set; }
        PatientRegistration pr;

        List<LabTest> labtests = new List<LabTest>();

        private void frmDoctorCheckup_Load(object sender, EventArgs e)
        {
            try
            {
                frmDoctorChecupRoom fdcr = new frmDoctorChecupRoom();
                fdcr.ShowDialog();
                if (fdcr.DialogResult == DialogResult.Yes)
                {
                    this.CurrentRoom = fdcr.CurrentRoom;
                    this.lblRoom.Text = CurrentRoom.Name;

                    labtests = new LabTestBLL().GetMedicines();
                    cbxLabTest.DataSource = labtests;
                    cbxLabTest.DisplayMember = "TestName";
                    cbxLabTest.ValueMember = "LabTestId";

                }
                else
                {
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Doctor Checup Load");
            }
            
            try
            {
                NextTokenData();
               
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
        private void NextTokenData()
        {
            rbOneDay.Checked = true;
            lstLabTest.Items.Clear();
            lstLabTestId.Items.Clear();
            long nextTokenNumber = pbll.GetNextTokenNumber(CurrentRoom);
            pr = pbll.GetPatientDetail(nextTokenNumber, CurrentRoom);
            this.lblCurrentTokenNumber.Text = nextTokenNumber.ToString("00000");
            PopulatePatientDetails(pr);
           // comm.WriteDataWithoutDisplay("*" + this.lblCurrentTokenNumber.Text + "#");
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            HideShowLoading(true);
            System.Threading.Thread.Sleep(2000);
            Application.DoEvents();
            List<LabTest> meds = new List<LabTest>();

            for (int i = 0; i < lstLabTestId.Items.Count ; i++)
            {
                LabTest med = new LabTest();
                med.LabTestId =Convert.ToInt32(lstLabTestId.Items[i].ToString().Split(',').GetValue(0).ToString ());
                med.TimesADay = Convert.ToDecimal(lstLabTestId.Items[i].ToString().Split(',').GetValue(1).ToString());
                meds.Add(med);
            }
            pbll.PatientChecked(pr,meds);
            NextTokenData();
            HideShowLoading(false);
        }
        private void HideShowLoading(bool b)
        {
            this.pbxLoading.Visible = b;
            this.lblLoadingNextToken.Visible = b;
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
                   
                    lbt.TotalDays = days;
                    lstLabTest.Items.Add(lbt);
                    lstLabTestId.Items.Add(lbt.LabTestId+","+lbt.TimesADay );
                }
           //     CalculateCashRecv2nd();
                cbxLabTest.Focus();
            }
            
        }

        private void lstLabTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lstLabTest.SelectedIndex >= 0)
                {
                    lstLabTest.Items.RemoveAt(lstLabTest.SelectedIndex);
                    lstLabTestId.Items.RemoveAt(lstLabTest.SelectedIndex);
                    //CalculateCashRecv2nd();
                }

            }
        }
    }
}
