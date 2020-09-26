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
using FDM.SearchForms;
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
        List<LabTest> pendings = new List<LabTest>();
        List<LabTest> freemedicines = new List<LabTest>();
        private void frmDoctorCheckup_Load(object sender, EventArgs e)
        {
            try
            {
                normalStyle = new DataGridViewCellStyle();
                pendingStyle = new DataGridViewCellStyle();
                normalStyle.ForeColor = Color.Black;
                normalStyle.BackColor = Color.White;

                pendingStyle.ForeColor = Color.Red;
                pendingStyle.BackColor = Color.SkyBlue;

                RefreshTokens();
                GetNextToken();
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

            }
        }
        private void PopulatePatientDetails(PatientRegistration pr)
        {
            this.lblCurrentTokenNumber.Text = pr.TokenNumber.ToString("00000");
            this.lblToDate.Text = pr.TokenDate.ToShortDateString();
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
            //try
            //{
            //    FrmExistingTokenForPharmacy frm = new FrmExistingTokenForPharmacy();
                
            //    frm.ShowDialog();
            //    if (frm.pr != null)
            //    {
            //        //rbOneDay.Checked = true;
            //        lstLabTest.Items.Clear();
            //        this.lblCurrentTokenNumber.Text = frm.pr.TokenNumber.ToString("00000");
            //        PopulatePatientDetails(frm.pr);

            //        labtests=new List<LabTest>();
            //        labtests.AddRange(frm.Medicines);
            //        for (int i = 0; i < labtests.Count ; i++)
            //        {
            //            LabTest lbt = new LabTest();
            //            lbt = labtests[i];
            //            int switchCase = Convert.ToInt32(lbt.TimesADay);
            //            string caseString = "";
            //            switch (switchCase)
            //            {
            //                case 1:
            //                    caseString = "od";
            //                    break;
            //                case 2:
            //                    caseString = "bd";
            //                    break;
            //                case 3:
            //                    caseString = "tds";
            //                    break;
            //                default:
            //                    break;
            //            }
            //            if (lbt.IsAlwaysPaid == true)
            //                caseString += " : " + strAlwaysPaid;
            //            else if (lbt.IsRsTenInjection == true)
            //                caseString += " : " + strInjection;
            //            lstLabTest.Items.Add(lbt + " : " + caseString );
            //           // lstLabTestId.Items.Add(lbt.LabTestId + "," + lbt.TimesADay + "," + lbt.MedIssuedID);
                        
            //        }
                    
            //    }
            //    else
                
            //    {
            //        frm.pr = new PatientRegistration();
            //        PopulatePatientDetails(frm.pr);
            //        labtests.Clear();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }
        List<PatientRegistration> prs = new List<PatientRegistration>();
        List<PatientRegistration> PendingPatients = new List<PatientRegistration>();
        DataGridViewCellStyle normalStyle;
        DataGridViewCellStyle pendingStyle;

        private void tsMedicienIssued_Click(object sender, EventArgs e)
        {
            try
            {
                if (freemedicines.Count > 0 )
                {
                    if (new InjectionLabTestBLL().SetPharmacyIssued(freemedicines) == true)
                    {
                        //prs = new InjectionLabTestBLL().GetAllMedicineNotIssued();
                        //dgvTokens.DataSource = null;
                        //dgvTokens.DataSource = prs;
                        //for (int i = 0; i < dgvTokens.Columns.Count; i++)
                        //{
                        //    if (dgvTokens.Columns[i].Name != "TokenNumber" && dgvTokens.Columns[i].Name != "TokenDate")
                        //    { dgvTokens.Columns[i].Visible = false; }
                        //    else
                        //    {
                        //        dgvTokens.Columns[i].Width = 80;
                        //    }
                        //}
                        RefreshTokens();
                        txtPatientName.Text = "";
                        txtPatientRegistrationNumber.Text = "";
                        txtPatientDetails.Text = "";
                        lstLabTest.Items.Clear();
                        MessageBox.Show("Record Saved Successfully");
                        Verified = false;
                        if (prs.Count != 0)
                            GetNextToken();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void RefreshTokens()
         {
            prs = new InjectionLabTestBLL().GetAllMedicineNotIssued();
            dgvTokens.DataSource = null;
            dgvTokens.DataSource = prs;
            //this.dgvTokens.Rows.Clear();
            for (int i = 0; i < dgvTokens.Columns.Count; i++)
            {
                if (dgvTokens.Columns[i].Name != "TokenNumber" && dgvTokens.Columns[i].Name != "TokenDate")
                { dgvTokens.Columns[i].Visible = false; }
                else
                    dgvTokens.Columns[i].Width = 80;
            }
            GetNextToken();
            //for (int j = 0; j < prs.Count; j++)
            //{
            //    object[] values = { prs[j].TokenNumber, prs[j].TokenDate.ToShortDateString(),prs[j].TokenMonthYear };
            //    //PatientRegistration patient = new InjectionLabTestBLL().GetPatientRegistration(new PatientRegistration(prs[j].TokenNumber, prs[j].TokenMonthYear));
            //    this.dgvTokens.Rows.Add(values);
            //    if (new InjectionLabTestBLL().GetMedicineIssued(prs[j]).Where(color => color.IsAlwaysPaid == true || color.IsRsTenInjection == true).ToList<LabTest>().Count > 0)
            //    {
            //        this.dgvTokens.Rows[j].Cells["TokenNumber"].Style = pendingStyle;
            //        this.dgvTokens.Rows[j].Cells["TokenDate"].Style = pendingStyle;
            //    }
            //}
        }
        private void tsGetNewTokens_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshTokens();
               //prs= new InjectionLabTestBLL().GetAllMedicineNotIssued();
               //dgvTokens.DataSource = null; 
               //dgvTokens.DataSource = prs;
               //for (int i = 0; i < dgvTokens.Columns.Count ; i++)
               //{
               //    if (dgvTokens.Columns[i].Name != "TokenNumber" && dgvTokens.Columns[i].Name != "TokenDate" )
               //    { dgvTokens.Columns[i].Visible = false; }
               //    else
               //    {
               //        dgvTokens.Columns[i].Width = 100;
               //    }
               //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTokens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dgvTokens.RowCount > 0)
                {
                    GetNextToken();
                    //txtPatientName.Text = "";
                    //txtPatientRegistrationNumber.Text = "";
                    //txtPatientDetails.Text = "";
                    //lstLabTest.Items.Clear();


                    //PatientRegistration pr = new InjectionLabTestBLL().GetPatientRegistration(new PatientRegistration(Convert.ToInt64(dgvTokens["TokenNumber", dgvTokens.CurrentRow.Index].Value), Convert.ToInt64(dgvTokens["TokenMonthYear", dgvTokens.CurrentRow.Index].Value)));
                    //if (pr.Patient.RegistrationNumber != null && pr.Patient.RegistrationNumber != "")
                    //{
                    //    PopulatePatientDetails(pr);

                    //    labtests = new List<LabTest>();
                    //    labtests = new InjectionLabTestBLL().GetMedicineIssued(pr);

                        
                    //    for (int i = 0; i < labtests.Count; i++)
                    //    {
                    //        LabTest lbt = new LabTest();
                    //        lbt = labtests[i];
                    //        lstLabTest.Items.Add(lbt + " : " + lbt.TimesADay + " : Times A Day ");
                    //        // lstLabTestId.Items.Add(lbt.LabTestId + "," + lbt.TimesADay + "," + lbt.MedIssuedID);

                    //    }

                    //}
                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        PatientRegistration nextPatient;
        string strAlwaysPaid = " (Always Paid)";
        string strInjection = " (Rs.10 Injection)";
        private void GetNextToken()
        {
            txtPatientName.Text = "";
            txtPatientRegistrationNumber.Text = "";
            txtPatientDetails.Text = "";
            lstLabTest.Items.Clear();
            lstPaidandInjection.Items.Clear();
            if (dgvTokens.RowCount > 0)
            {
                nextPatient = new InjectionLabTestBLL().GetPatientRegistration(new PatientRegistration(Convert.ToInt64(dgvTokens["TokenNumber", dgvTokens.CurrentRow.Index].Value), Convert.ToInt64(dgvTokens["TokenMonthYear", dgvTokens.CurrentRow.Index].Value)));
                if (nextPatient.Patient.RegistrationNumber != null && nextPatient.Patient.RegistrationNumber != "")
                {
                    PopulatePatientDetails(nextPatient);

                    labtests = new List<LabTest>();
                    labtests = new InjectionLabTestBLL().GetMedicineIssued(nextPatient);

                    pendings = labtests.Where(pen => pen.IsRsTenInjection == true || pen.IsAlwaysPaid == true).ToList<LabTest>();
                    freemedicines = labtests.Where(lab => lab.IsAlwaysPaid == false && lab.IsRsTenInjection == false).ToList<LabTest>();

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
                        if (lbt.IsAlwaysPaid == true || lbt.IsRsTenInjection == true)
                        {
                            if (lbt.IsAlwaysPaid)
                            {
                                caseString += " : " + strAlwaysPaid;
                                Verified = false;
                            }
                            if (lbt.IsRsTenInjection)
                            {
                                caseString += " : " + strInjection;
                                Verified = false;
                            }
                            lstPaidandInjection.Items.Add(lbt.TestName + " : " + caseString);
                        }
                        else
                            lstLabTest.Items.Add(lbt.TestName + " : " + caseString);
                        // lstLabTestId.Items.Add(lbt.LabTestId + "," + lbt.TimesADay + "," + lbt.MedIssuedID);

                    }

                }
            }
        }
        private void dgvTokens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool Verified = false;
        private void btnAlwaysPaid_Click(object sender, EventArgs e)
        {
            //List<LabTest> verifyable = labtests.Where(v => v.IsRsTenInjection == true || v.IsAlwaysPaid == true).ToList<LabTest>();
            //DateTime date = DateTime.Now.Date;
            //int tokenId = 0;
            //bool r = int.TryParse(this.txtPaidToken.Text, out tokenId);
            //List<LabTest> dbValues = new InjectionLabTestBLL().GetPaidTokens(tokenId,date);
            //if (dbValues.Count == verifyable.Count)
            //{
            //    int count = 0;
            //    for (int j = 0; j < dbValues.Count; j++)
            //    {
                    
            //        if (verifyable.Contains(dbValues[j]))
            //        {
            //            count++;
            //        }
            //    }
            //    if (dbValues.Count == count)
            //        Verified = true;
            //    else
            //        Verified = false;

            //    if (Verified)
            //        for (int i = 0; i < this.lstPaidandInjection.Items.Count; i++)
            //        {
            //            string item = lstPaidandInjection.Items[i].ToString();

            //            if (item.EndsWith(strAlwaysPaid) || item.EndsWith(strInjection))
            //            {
            //                this.lstPaidandInjection.Items.RemoveAt(i);
            //                this.lstPaidandInjection.Items.Insert(i, item + " verified");
            //            }
            //        }
            //    else
            //        MessageBox.Show("Please Pay the Token First");
            //}
        }
        //SchMedicinesIssued schmed = new SchMedicinesIssued();
        private void Search_Click(object sender, EventArgs e)
        {
             new SchMedicinesIssued().ShowDialog();
          

            
        }

        private void btnAlwaysPaidCancel_Click(object sender, EventArgs e)
        {
            if (lstPaidandInjection.SelectedItem == null)
            {
                MessageBox.Show("Please Select Always Paid Medicine To Cancel", "Medicine Not Selected");
                return;
            }

            LabTest cancelAlwaysPaid = pendings[this.lstPaidandInjection.SelectedIndex];

            if (MessageBox.Show("do you really want to cancel the medicine? " + cancelAlwaysPaid.TestName , " Cancel Medicine", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (new PatientBLL().MedicineCanceled(nextPatient, cancelAlwaysPaid))
                    MessageBox.Show(cancelAlwaysPaid.TestName + " is canceled");
                RefreshTokens();
            }

        }

        private void btnFreeCancel_Click(object sender, EventArgs e)
        {
            if (lstLabTest.SelectedItem == null)
            {
                MessageBox.Show("Please Select Free Medicine To Cancel", "Medicine Not Selected");
                return;
            }

            LabTest cancelfree = freemedicines[this.lstLabTest.SelectedIndex];

            if (MessageBox.Show("do you really want to cancel the medicine? " + cancelfree.TestName, " Cancel Medicine", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (new PatientBLL().MedicineCanceled(nextPatient, cancelfree))
                    MessageBox.Show(cancelfree.TestName + " is canceled");
                RefreshTokens();
            }
        }

        private void btnFreeMedicineCancelAll_Click(object sender, EventArgs e)
        {
            if (lstLabTest.Items.Count == 0)
            {
                MessageBox.Show("There is no Free Medicine To Cancel", "Medicine Not in List");
                return;
            }

            if (MessageBox.Show("do you really want to cancel all the medicine? " , " Cancel All Free Medicine", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (LabTest cancelfree in freemedicines)
                {
                    new PatientBLL().MedicineCanceled(nextPatient, cancelfree);
                        
                }
                MessageBox.Show("All Free Medicines are canceled Successfully!");
                RefreshTokens();
            }
        }

        private void btnAlwaysPaidCancelAll_Click(object sender, EventArgs e)
        {
            if (lstPaidandInjection.Items.Count == 0)
            {
                MessageBox.Show("There is no Always Paid Medicine To Cancel", "Medicine Not in List");
                return;
            }
            if (MessageBox.Show("do you really want to cancel all the medicine? ", "Cancel All Paid Medicines", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (LabTest cancelAlwaysPaid in pendings)
                {
                    new PatientBLL().MedicineCanceled(nextPatient, cancelAlwaysPaid);
                }
                MessageBox.Show("All Paid Medicines are Canceled Successfully!");
                RefreshTokens();
            }
        }

       
    }
}
