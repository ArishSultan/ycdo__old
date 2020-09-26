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
using BLL;
using Common.Datasets;
//using SNK.Reports;
using BLL.SaleInvoices;
using FDM.Reports;
using FDM.ReportForms;
using System.Configuration;

namespace FDM
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public static string MachineName { get; set; }
        public User IsLoginUser;
        CommunicationManager cm = new CommunicationManager();
        ProjectDetail prj;
        BackgroundWorker bgWorker = new BackgroundWorker();
        List<UserRight> uRights;
        UserBLL uBll;


        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                lblShift.Text = "Active Shift is " + new BLL.ShiftsBLL().GetActiveShift().ShiftName;
                uBll=new UserBLL();
                uRights = new List<UserRight>();

                this.prj = new ProjectDetail();
                this.Text = this.prj.CompanyName  + " - " + this.prj.ProjectTitle;
                uRights = uBll.GetUserRights(IsLoginUser);
                foreach (UserRight item in uRights)
                {
                    if (item.Screen.ScreenName == "Patient Registration")
                        if (item.CanAccess == true)
                        {
                            tsPatientRegistration.Enabled = true;
                            patientRegistrationToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            tsPatientRegistration.Visible = false;
                            patientRegistrationToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Doctor Checkup")
                        if (item.CanAccess == true)
                        {
                            tsDoctorsCheckup.Enabled = true;
                            doctorCheckupToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            tsDoctorsCheckup.Visible = false;
                            doctorCheckupToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Room")
                        if (item.CanAccess == true)
                        {
                            tsRoom.Enabled = true;
                            roomFormToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            tsRoom.Visible = false;
                            roomFormToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Print Summary")
                        if (item.CanAccess == true)
                        {
                            tsPrintSummaryUserWise.Enabled = true;
                            printSummaryToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            tsPrintSummaryUserWise.Visible = false;
                            printSummaryToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Lab Test")
                        if (item.CanAccess == true)
                        {
                            tsLabTest.Enabled = true;
                            labTestToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            tsLabTest.Visible = false;
                            labTestToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Create /Change User")
                        if (item.CanAccess == true)
                        {
                            tsUser.Enabled = true;
                            createChangeUserToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            tsUser.Visible = false;
                            createChangeUserToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Backup Restore")
                        if (item.CanAccess == true)
                        {
                            tsBackup.Enabled = true;
                            backUpRestoreToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            tsBackup.Visible = false;
                            backUpRestoreToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "User Right")
                        if (item.CanAccess == true)
                        {
                            tsUserRight.Enabled = true;
                            userRightToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            tsUserRight.Visible = false;
                            userRightToolStripMenuItem.Visible = false;
                        }

                    if (item.Screen.ScreenName == "Setup Led")
                        if (item.CanAccess == true)
                        {
                            tsSetupLED.Enabled = true;
                            setupLEDsToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            tsSetupLED.Visible = false;
                            setupLEDsToolStripMenuItem.Visible = false;
                        }

                    if (item.Screen.ScreenName == "LabTest and Medicine")
                        if (item.CanAccess == true)
                        {
                            tsLabtestNames.Enabled = true;
                            labTestAndOtherServicesToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            tsLabtestNames.Visible = false;
                            labTestAndOtherServicesToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Member Collection")
                        if (item.CanAccess == true)
                        {
                            memberCollectionToolStripMenuItem.Enabled = true;
                            tsMemberCollection.Enabled = true;
                        }
                        else
                        {
                            memberCollectionToolStripMenuItem.Visible = false;
                            tsMemberCollection.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Donor Collection")
                        if (item.CanAccess == true)
                        {
                            donationCollectionToolStripMenuItem.Enabled = true;
                            tsDonationCollection.Enabled = true;
                        }
                        else
                        {
                            donationCollectionToolStripMenuItem.Visible = false;
                            tsDonationCollection.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Member Summary")
                        if (item.CanAccess == true)
                        {
                            memberSummaryToolStripMenuItem.Enabled = true;
                            tsMemberSummary.Enabled = true;
                        }
                        else
                        {
                            memberSummaryToolStripMenuItem.Visible = false;
                            tsMemberSummary.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Donor Summary")
                        if (item.CanAccess == true)
                        {
                            donorSummaryToolStripMenuItem.Enabled = true;
                            tsDonorSummary.Enabled = true;
                        }
                        else
                        {
                            donorSummaryToolStripMenuItem.Visible = false;
                            tsDonorSummary.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Country")
                        if (item.CanAccess == true)
                        {
                            countryScreenToolStripMenuItem.Enabled = true;
                            tsCountry.Enabled = true;
                        }
                        else
                        {
                            countryScreenToolStripMenuItem.Visible = false;
                            tsCountry.Visible = false;
                        }
                    if (item.Screen.ScreenName == "City")
                        if (item.CanAccess == true)
                        {
                            cityFormToolStripMenuItem.Enabled = true;
                            tsCity.Enabled = true;
                        }
                        else
                        {
                            cityFormToolStripMenuItem.Visible = false;
                            tsCity.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Branch")
                        if (item.CanAccess == true)
                        {
                            branchFormToolStripMenuItem.Enabled = true;
                            tsBranch.Enabled = true;
                        }
                        else
                        {
                            branchFormToolStripMenuItem.Visible = false;
                            tsBranch.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Performance")
                        if (item.CanAccess == true)
                        {
                            performanceToolStripMenuItem.Enabled = true;
                            tsPerformance.Enabled = true;
                        }
                        else
                        {
                            performanceToolStripMenuItem.Visible = false;
                            tsPerformance.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Member Report")
                        if (item.CanAccess == true)
                        {
                            membersReportToolStripMenuItem.Enabled = true;
                            tsMemberReport.Enabled = true;
                        }
                        else
                        {
                            membersReportToolStripMenuItem.Visible = false;
                            tsMemberReport.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Donor Report")
                        if (item.CanAccess == true)
                        {
                            donorsReportToolStripMenuItem.Enabled = true;
                            tsDonorReport.Enabled = true;
                        }
                        else
                        {
                            donorsReportToolStripMenuItem.Visible = false;
                            tsDonorReport.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Branch Report")
                        if (item.CanAccess == true)
                        {
                            branchReportToolStripMenuItem.Enabled = true;
                            tsBranchReport.Enabled = true;
                        }
                        else
                        {
                            branchReportToolStripMenuItem.Visible = false;
                            tsBranchReport.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Member Progress Report")
                        if (item.CanAccess == true)
                        {
                            memberProgressReportToolStripMenuItem.Enabled = true;
                            tsMemberProgressReport.Enabled = true;
                        }
                        else
                        {
                            memberProgressReportToolStripMenuItem.Visible = false;
                            tsMemberProgressReport.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Donor")
                        if (item.CanAccess == true)
                        {
                            donorFormToolStripMenuItem.Enabled = true;
                            tsDonor.Enabled = true;
                        }
                        else
                        {
                            donorFormToolStripMenuItem.Visible = false;
                            tsDonor.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Member")
                        if (item.CanAccess == true)
                        {
                            membershipFormToolStripMenuItem.Enabled = true;
                            tsMemberShip.Enabled = true;
                        }
                        else
                        {
                            membershipFormToolStripMenuItem.Visible = false;
                            tsMemberShip.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Pharmacy")
                        if (item.CanAccess == true)
                        {
                            pharmacyFormToolStripMenuItem.Enabled = true;
                            tsPharmacy.Enabled = true;
                        }
                        else
                        {
                            pharmacyFormToolStripMenuItem.Visible = false;
                            tsPharmacy.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Council")
                        if (item.CanAccess == true)
                        {
                            //councilScreenToolStripMenuItem.Enabled = true;
                            tsCouncil.Enabled = true;
                        }
                        else
                        {
                         //   councilScreenToolStripMenuItem.Visible = false;
                            tsCouncil.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Committee")
                        if (item.CanAccess == true)
                        {
                            committeToolStripMenuItem.Enabled = true;
                            tsCommittee.Enabled = true;
                        }
                        else
                        {
                            committeToolStripMenuItem.Visible = false;
                            tsCommittee.Visible = false;
                        }
                    
                    if (item.Screen.ScreenName == "Receive Medicine")
                        if (item.CanAccess == true)
                        {
                            
                            receiveMedicineToolStripMenuItem.Enabled = true;
                        }
                        else
                        {

                            receiveMedicineToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Issue Medicine")
                        if (item.CanAccess == true)
                        {

                            issueMedicineToolStripMenuItem.Enabled = true;
                        }
                        else
                        {

                            issueMedicineToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Issued MedicinesWithPrices")
                        if (item.CanAccess == true)
                        {

                            issuedMedicinesWithPriceToolStripMenuItem.Enabled = true;
                        }
                        else
                        {

                            issuedMedicinesWithPriceToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Current Stock")
                        if (item.CanAccess == true)
                        {

                            currentStockToolStripMenuItem.Enabled = true;
                        }
                        else
                        {

                            currentStockToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Member and Donor Collection")
                        if (item.CanAccess == true)
                        {
                            tsDonorAndMemberReport.Enabled = true;
                           donrorNMemberCollectionToolStripMenuItem .Enabled = true;
                        }
                        else
                        {
                            tsDonorAndMemberReport.Visible = false;
                            donrorNMemberCollectionToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Reference Report")
                        if (item.CanAccess == true)
                        {
                            tsRefrenceReport.Enabled = true;
                           refrenceReportToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            tsRefrenceReport.Visible = false;
                            refrenceReportToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Labortory")
                        if (item.CanAccess == true)
                        {
                            tsLabortory.Enabled = true;
                            laboratoryToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            laboratoryToolStripMenuItem.Visible = false;
                            tsLabortory.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Issued Medicines With Prices")
                        if (item.CanAccess == true)
                        {

                           issuedMedicinesWithPriceToolStripMenuItem.Enabled = true;
                        }
                        else
                        {

                            issuedMedicinesWithPriceToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Current Stock With Value")
                        if (item.CanAccess == true)
                        {

                           currentStockWithValueToolStripMenuItem.Enabled = true;
                        }
                        else
                        {

                            currentStockWithValueToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Item Ledger")
                        if (item.CanAccess == true)
                        {

                            itemLedgerToolStripMenuItem.Enabled = true;
                        }
                        else
                        {

                            itemLedgerToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "List Of Medicines")
                        if (item.CanAccess == true)
                        {

                            listOfMedicinesToolStripMenuItem.Enabled = true;
                        }
                        else
                        {

                           listOfMedicinesToolStripMenuItem.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Second Turn")
                        if (item.CanAccess == true)
                        {

                            tbSecondTurn.Visible = true;
                        }
                        else
                        {

                            tbSecondTurn.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Third Turn")
                        if (item.CanAccess == true)
                        {

                            tbThirdTurn.Visible = true;
                        }
                        else
                        {

                            tbThirdTurn.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Fourth Turn")
                        if (item.CanAccess == true)
                        {

                            tsFourthTurn.Visible = true;
                        }
                        else
                        {

                            tsFourthTurn.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Medicine Report")
                        if (item.CanAccess == true)
                        {

                            tsMedicineReport.Visible = true;
                        }
                        else
                        {

                            tsMedicineReport.Visible = false;
                        }
                    if (item.Screen.ScreenName == "Change Shifts")
                    {
                        if (item.CanAccess)
                        {
                            tsChangeShift.Enabled = true;
                        }
                        else
                        {
                            tsChangeShift.Enabled = false;
                        }
                    }

                }

                if (!this.IsLoginUser.IsAdmin)
                {
                    //this.tsUser.Visible  = false;
                    //this.tsLabTest.Visible  = false;
                    
                }
                try
                {
                    this.lblName.Text = ConfigurationManager.AppSettings["Name"].ToString();
                    this.lblAddress.Text = ConfigurationManager.AppSettings["Address"].ToString();
                    this.lblUser.Text = IsLoginUser.UserName;
                }
                finally { }
                this.bgWorker.DoWork += new DoWorkEventHandler(this.bgWorker_DoWork);
                //this.bgWorker.RunWorkerAsync();
                //if (!this.upDdBll.IsDBUpdated())
                //{
                //    MessageBox.Show("Your current company is not setup.\r\nPlease update database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    FrmUpdateDB edb = new FrmUpdateDB();
                //    edb.ShowDialog();
                //    if (!edb.DataBaseUpdated)
                //    {
                //        MessageBox.Show("Your current company is not Setup properly.\r\n Please update database", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      
                //        this.tsPrintLabels.Visible  = false;
                //    }
                //}
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "frmMain_Load");
            }
        }
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.LoadReport();
        }
        private void LoadReport()
        {
            // new QuriesBLL().UpdateQueries();
            Just4LoadDataSet set = new Just4LoadDataSet();
            FrmReportViewer viewer = new FrmReportViewer();
            rptJust4Load load = new rptJust4Load();
            load.SetDataSource(set);
            viewer.crystalReportViewer1.ReportSource = load;
            set.Dispose();
            viewer.Dispose();
            load.Dispose();
        } 
        private void tsBackup_Click(object sender, EventArgs e)
        {
            new FrmBackupRestore().ShowDialog();
        }

        private void tsDoc_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(Application.StartupPath + @"\Label Program.pdf");
        }
        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
           // new FrmReport().ShowDialog();
        }

        private void tsQuote_Click(object sender, EventArgs e)
        {
          //  new FrmQuote().ShowDialog();
        }

        private void tsSaleInvoice_Click(object sender, EventArgs e)
        {

            
        }

        private void tsSaleOrder_Click(object sender, EventArgs e)
        {
           
        }

       

        private void tsUninstall_Click(object sender, EventArgs e)
        {
        }

       

        private void tsUser_Click(object sender, EventArgs e)
        {
            new FrmCreateChangeUser().ShowDialog();
        }

        private void tsVersion_Click(object sender, EventArgs e)
        {
            new FrmVersion().ShowDialog();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            if (this.btnMain.Text == "Minimizeed")
            {
                this.btnMain.Text = "Maximizeed";
                this.tsMenu.Visible = false;
            }
            else
            {
                this.btnMain.Text = "Minimizeed";
                this.tsMenu.Visible = true;
            }
        }

        private void tsDefineItems_Click(object sender, EventArgs e)
        {
            
        }

       
        private void tsPatientRegistration_Click(object sender, EventArgs e)
        {

            frmPatientRegistration prg = new frmPatientRegistration();
            prg.IsLoginUser = IsLoginUser;
            prg.Show();
        }

        private void tsDoctorsCheckup_Click(object sender, EventArgs e)
        {
            frmDoctorCheckup dcp = new frmDoctorCheckup();
            dcp.IsLoginUser = IsLoginUser;
            dcp.Show();
        }

        private void tsPrintSummary_Click(object sender, EventArgs e)
        {
           // new FrmPrintSummary().Show();
            new FrmTokenSummaryUserWise().Show();
        }

        private void tsPatientCategories_Click(object sender, EventArgs e)
        {
            new frmPatientCategories().Show();
        }

        private void tsLabTest_Click(object sender, EventArgs e)
        {
            new FrmLabTest().Show();
        }

        private void tsUserRight_Click(object sender, EventArgs e)
        {
              new FrmUserRight().ShowDialog();
        }

        private void tsSetupLED_Click(object sender, EventArgs e)
        {
            frmSetupLED frmsled = new frmSetupLED(cm);
            frmsled.Show();
        }

        private void tsRoom_Click(object sender, EventArgs e)
        {
            new FrmRoom().Show();
        }

       

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            new FrmMembership().Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            new FrmBranches().Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            new FrmCitiy().Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            new FrmMembershipReport().Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            new FrmDonor().Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            new FrmBranchWithCityReport().Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            new FrmDonorReport().Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            new FrmCountry().Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            new FrmCounsil().Show();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            new FrmCommitte().Show();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            new FrmPerformance().Show();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            new FrmCategory().Show();
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            new FrmLabTestName().Show();
        }

        private void toolStripButton15_Click_1(object sender, EventArgs e)
        {
            new FrmMemberCollectionForm().Show();
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            new FrmDonationCollectionForm().Show();
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            new FrmMembersProgressReport().Show();
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            new FrmMembershipCollectionReport().Show();
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            new FrmDonationCollectionReport().Show();
        }

        private void tsPharmacy_Click(object sender, EventArgs e)
        {
            new frmPharmacyMedicine().Show();
        }

        private void tsDonorAndMemberReport_Click(object sender, EventArgs e)
        {
            new frmDonorAndMemberCollectionReport().Show();
        }

        private void tsDonornMemberData_Click(object sender, EventArgs e)
        {
          //  new FrmDonorPlusMemberReport().Show();
        }

        private void tsRefrenceReport_Click(object sender, EventArgs e)
        {
            new frmRefrenceReport().Show();
        }

        private void exitFDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void receiveMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new s().Show();
        }

        private void issueMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmIssuedMedicine().Show();
        }

        private void pharmacyFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPharmacyMedicine().Show();
        }

        private void branchFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBranches().Show();
        }

        private void cityFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCitiy().Show();
        }

        private void countryScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCountry().Show();
        }

        private void performanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPerformance().Show();
        }

        private void councilScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCounsil().Show();
        }

        private void committeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCommitte().Show();
        }

        private void donationCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDonationCollectionForm().Show();
        }

        private void memberCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMemberCollectionForm().Show();
        }

        private void labTestAndOtherServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLabTestName().Show();
        }

        private void labTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new FrmLabTest().Show();
        }

        private void roomFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRoom().Show();
        }

        private void donorFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDonor().Show();
        }

        private void membershipFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMembership().Show();
        }

        private void doctorCheckupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoctorCheckup dcp = new frmDoctorCheckup();
            dcp.IsLoginUser = IsLoginUser;
            dcp.Show();
        }

        private void patientRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmPatientRegistration().Show();
        }

        private void setupLEDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSetupLED().Show();
        }

        private void printSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPrintSummary().Show();
        }

        private void membersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMembershipReport().Show();
        }

        private void donorsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDonorReport().Show();
        }

 
        private void donrorNMemberCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDonorAndMemberCollectionReport().Show();
        }

        private void refrenceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRefrenceReport().Show();
        }

        private void branchReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBranchWithCityReport().Show();
        }

        private void memberProgressReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMembersProgressReport().Show();
        }

        private void memberSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMembershipCollectionReport().Show();
        }

        private void donorSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDonationCollectionReport().Show();
        }

        private void itemLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmItemLedger().Show();
        }

      

        private void currentStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCurrentStock().Show();
        }

        private void currentStockToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new frmCurrentStock().Show();
        }

        private void currentStockWithValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCurrentStockWithValue().Show();
        }

        private void issuedMedicinesWithPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmIsssuedMedicinePrice().Show();
        }

        private void userRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmUserRight().ShowDialog();
        }

        private void createChangeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCreateChangeUser().Show();
        }

        private void backUpRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBackupRestore().ShowDialog();
        }

        private void tsLabortory_Click(object sender, EventArgs e)
        {
            new frmLabortory().Show();
        }

        private void listOfMedicinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListOfMedicines().Show();
        }

        private void laboratoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLabortory().Show();
        }

        private void firstTurnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPatientRegistration().Show();
        }

        private void secondTurnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecondTurn prg = new frmSecondTurn();
            prg.IsloginUser = IsLoginUser;
            prg.Show();
           
        }

        private void thirdTurnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmThirdTurn prg = new frmThirdTurn();
            prg.IsloginUser = IsLoginUser;
            prg.Show();
        }

        private void tbSecondTurn_Click(object sender, EventArgs e)
        {
            frmSecondTurn prg = new frmSecondTurn();
            prg.IsloginUser = IsLoginUser;
            prg.Show();
        }

        private void tbThirdTurn_Click(object sender, EventArgs e)
        {
            frmThirdTurn prg = new frmThirdTurn();
            prg.IsloginUser = IsLoginUser;
            prg.Show();
        }

        private void tsMedicineReport_Click(object sender, EventArgs e)
        {
            new frmMedicineStatusReport().Show();
        }

        private void tsFourthTurn_Click(object sender, EventArgs e)
        {
            frmFourthTurn prg = new frmFourthTurn();
            prg.IsloginUser = IsLoginUser;
            prg.Show();
        }

        private void clearStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmClearStock().Show();
        }

        private void tsChangeShift_Click(object sender, EventArgs e)
        {
            new FormChangeShift(IsLoginUser).ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new FrmTokenSummary().Show();
        }

        private void diagnosisFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDiagnosis().Show();
        }

       

       

       

       
     

       
       
    }
}
