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
            long nextTokenNumber = pbll.GetNextTokenNumber(CurrentRoom);
            //pr = pbll.GetPatientDetail(nextTokenNumber, CurrentRoom);
            pr = pbll.GetPatientDetail(nextTokenNumber);
            this.lblCurrentTokenNumber.Text = nextTokenNumber.ToString("0000");
            PopulatePatientDetails(pr);
           // comm.WriteDataWithoutDisplay("*" + this.lblCurrentTokenNumber.Text + "#");
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            HideShowLoading(true);
            System.Threading.Thread.Sleep(5000);
            Application.DoEvents();
            pbll.PatientChecked(pr);
            NextTokenData();
            HideShowLoading(false);
        }
        private void HideShowLoading(bool b)
        {
            this.pbxLoading.Visible = b;
            this.lblLoadingNextToken.Visible = b;
        }
    }
}
