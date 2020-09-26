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
using System.IO;
using FDM.SearchForms;
namespace FDM
{
    public partial class frmDoctorCheckup : Form
    {
        public int counter;
        StreamReader sr;
        StreamWriter sw;
        //CommunicationManager comm;
        PatientBLL pbll = new PatientBLL();
        public frmDoctorCheckup()
        {
            InitializeComponent();

            pendingStyle.BackColor = Color.Yellow;
            pendingStyle.ForeColor = Color.Purple;
        }
        //public frmDoctorCheckup(CommunicationManager cm)
        //{
        //    InitializeComponent();
        //    this.comm = cm;
        //}
        public Room CurrentRoom { get; set; }
        PatientRegistration pr;
        RoomBLL rbll = new RoomBLL();
        List<LabTest> labtests = new List<LabTest>();
        List<LabTest> pathology = new List<LabTest>();
        List<PatientRegistration> patients;
        DataGridViewCellStyle pendingStyle = new DataGridViewCellStyle();
        
        private void LoadRoomTokens()
        {
            sr = new StreamReader("C:\\" + this.name.Trim() + ".txt");
            counter = Convert.ToInt32(sr.ReadLine());
            sr.Close();
            //this.dgvTokens.Rows.Clear();
            patients = new PatientBLL().GetPatientDetails();
            this.dgvTokens.DataSource = null;
            this.dgvTokens.DataSource = patients;
            for (int i = 0; i < dgvTokens.Columns.Count; i++)
            {
                if (dgvTokens.Columns[i].Name != "TokenNumber" && dgvTokens.Columns[i].Name != "TokenDate")
                { dgvTokens.Columns[i].Visible = false; }
                else
                    dgvTokens.Columns[i].Width = 80;
            }
            if (patients.Count > 0)
                LoadLabTests(patients[0]);
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
        public string name;
        frmshowcounter fr = new frmshowcounter();
        private void frmDoctorCheckup_Load(object sender, EventArgs e)
        {
            try
            {
                
                frmdoctorchange fdcr = new frmdoctorchange();
                fdcr.ShowDialog();
                if (fdcr.frmname == null)
                {
                    this.Close();
                    return;
                }
                string[] an = fdcr.frmname.Split(' ');
                name = an[0] + " " +an[1];
                fr.s = name;
                if (name.Contains('/'))
                {
                    string[] array = name.Split('/');
                    name = array[0] + "-" + array[1];
                
                }
                if (fdcr.show)
                {
                    this.Text = name;
                    LoadRoomTokens();
                    //load medicines
                    labtests = new LabTestBLL().GetMedicines();
                    cbxLabTest.DataSource = labtests;
                    cbxLabTest.DisplayMember = "TestName";
                    cbxLabTest.ValueMember = "LabTestId";
                    //load pathology test
                    pathology = new LabTestBLL().GetLabTest();
                    cbxPathologyTest.DataSource = pathology;
                    cbxPathologyTest.DisplayMember = "TestName";
                    cbxPathologyTest.ValueMember = "LabTestId";
                }
                else
                {
                    this.Close();
                    return;
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
            this.txtPatientDetails.Text = "";
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
            long nextTokenNumber = pbll.GetNextTokenNumber();
            pr = pbll.GetPatientDetail(nextTokenNumber);
            this.lblCurrentTokenNumber.Text = nextTokenNumber.ToString("00000");
            PopulatePatientDetails(pr);
            LoadLabTests(pr);
           // comm.WriteDataWithoutDisplay("*" + this.lblCurrentTokenNumber.Text + "#");
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want to see the Next Patient", "See Next",MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            HideShowLoading(true);
            //System.Threading.Thread.Sleep(2000);
            //Application.DoEvents();
            List<LabTest> meds = new List<LabTest>();
            frmdoctorchange fdcr = new frmdoctorchange();
            for (int i = 0; i < lstLabTestId.Items.Count ; i++)
            {
                LabTest med = new LabTest();
                med.LabTestId =Convert.ToInt32(lstLabTestId.Items[i].ToString().Split(',').GetValue(0).ToString ());
                med.TimesADay = Convert.ToDecimal(lstLabTestId.Items[i].ToString().Split(',').GetValue(1).ToString());
                meds.Add(med);
            }
            counter++;
            sw = new StreamWriter("C:\\"+this.name+".txt",false);
            sw.Write(counter);
            sw.Close();
            pbll.PatientChecked(pr,meds);
            LoadRoomTokens();
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
            ListBox lbx = sender as ListBox;
            if (e.KeyCode == Keys.Delete)
            {
                if (lbx.SelectedIndex >= 0)
                {
                    int deleteIndex = lbx.SelectedIndex;
                    lbx.Items.RemoveAt(deleteIndex);
                    if(lbx.Name == lstLabTest.Name)
                    lstLabTestId.Items.RemoveAt(deleteIndex);
                    //CalculateCashRecv2nd();
                }

            }
        }

        private void LoadLabTests(PatientRegistration pr)
        {
            this.lbxLabTest.Items.Clear();
            List<LabTest> labs = new InjectionLabTestBLL().GetLabTestAssigned(pr);
            pr.LabTests = labs;
            if (pr.LabTests.Count > 0)
            {
                foreach (LabTest lbt in pr.LabTests)
                {
                    this.lbxLabTest.Items.Add(lbt);
                }
            }
        }
        private void dgvTokens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTokens.RowCount > 0)
            {
                pr = patients[e.RowIndex];
                long nextTokenNumber = pr.TokenNumber;
                this.lblCurrentTokenNumber.Text = nextTokenNumber.ToString("00000");
                this.lblToDate.Text = pr.TokenDate.ToShortDateString();
                PopulatePatientDetails(pr);
                this.lbxLabTest.Items.Clear();
                LoadLabTests(pr);
            }
        }

        private void dgvTokens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        List<PatientRegistration> prs = new List<PatientRegistration>();

        private void tsRefresh_Click_1(object sender, EventArgs e)
        {
            try
            {
                LoadRoomTokens();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tsSearch_Click(object sender, EventArgs e)
        {
            new SchPatient().ShowDialog();
        }

        private void btnAddPathology_Click(object sender, EventArgs e)
        {
            if (cbxPathologyTest.SelectedValue != null)
            {
                LabTest lbt = (LabTest)cbxPathologyTest.SelectedItem;
                lbt = pathology[pathology.IndexOf(lbt)];
                if (lbxLabTest.Items.Contains(lbt) == false)
                {
                    this.lbxLabTest.Items.Add((LabTest)this.cbxPathologyTest.SelectedItem);
                }
            }
        }

      

        private void btnDoTest_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do want to send LabTest to Reception", "See Next", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            List<LabTest> labs = new List<LabTest>();

            for (int i = 0; i < lbxLabTest.Items.Count; i++)
            {
                LabTest lab = (LabTest)this.lbxLabTest.Items[i];
                if(pr.LabTests.Contains(lab) != true)
                    labs.Add(lab);
            }
            pbll.LabTestAssigned(pr, labs);
            LoadRoomTokens();
            NextTokenData();
        }

        private void cbxLabTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLabTest.SelectedItem != null)
            {
                LabTest currentTest = (LabTest)this.cbxLabTest.SelectedItem;
                //if (currentTest.IsMedicine == false || currentTest.IsRsTenInjection == true)
                //{
                //    this.rbThreeDay.Enabled = false;
                //    this.rbTwoDay.Enabled = false;
                //    rbOneDay.Enabled = false;
                //}
                //else
                //{
                //    this.rbThreeDay.Enabled =true;
                //    this.rbTwoDay.Enabled = true;
                //    rbOneDay.Enabled = true;
                //}
                if (currentTest.IsOd)
                {
                    this.rbThreeDay.Enabled = false;
                    this.rbTwoDay.Enabled = false;
                    this.rbOneDay.Focus();
                }
                else
                {
                    this.rbTwoDay.Enabled = true;
                    this.rbThreeDay.Enabled = true;
                }
            }
        }

        private void tsViewHistory_Click(object sender, EventArgs e)
        {
            new SchMedicinesIssued().ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new frmdoctortoken().Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmshowcounter frm = new frmshowcounter();
            frm.ShowDialog();
        }


        

       

        

       

       
        //private void RefreshTokens()
        //{
        //    prs = new PatientBLL().GetPatientDetails(CurrentRoom);
        //    dgvTokens.DataSource = null;
        //    dgvTokens.DataSource = prs;
        //    for (int i = 0; i < dgvTokens.Columns.Count; i++)
        //    {
        //        if (dgvTokens.Columns[i].Name != "TokenNumber" && dgvTokens.Columns[i].Name != "TokenDate")
        //        { dgvTokens.Columns[i].Visible = false; }
        //        else
        //        {
        //            dgvTokens.Columns[i].Width = 100;
        //        }
        //    }

        //}

       
    }
}
