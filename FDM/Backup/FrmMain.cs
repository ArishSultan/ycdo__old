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
                uBll=new UserBLL();
                uRights = new List<UserRight>();

                this.prj = new ProjectDetail();
                this.Text = this.prj.CompanyName  + " - " + this.prj.ProjectTitle;
                uRights = uBll.GetUserRights(IsLoginUser);
                foreach (UserRight item in uRights)
                {
                    if (item.Screen.ScreenName == "Patient Registration")
                        if (item.CanAccess == true)
                            tsPatientRegistration.Enabled = true;
                        else
                            tsPatientRegistration.Visible  = false;
                    if (item.Screen.ScreenName == "Doctor Checkup")
                        if (item.CanAccess == true)
                            tsDoctorsCheckup.Enabled = true;
                        else
                            tsDoctorsCheckup.Visible  = false;
                    if (item.Screen.ScreenName == "Room")
                        if (item.CanAccess == true)
                            tsRoom.Enabled = true;
                        else
                            tsRoom.Visible  = false;
                    if (item.Screen.ScreenName == "Print Summary")
                        if (item.CanAccess == true)
                            tsPrintSummary.Enabled = true;
                        else
                            tsPrintSummary.Visible  = false;
                    if (item.Screen.ScreenName == "Lab Test")
                        if (item.CanAccess == true)
                            tsLabTest.Enabled = true;
                        else
                            tsLabTest.Visible  = false;
                    if (item.Screen.ScreenName == "Create /Change User")
                        if (item.CanAccess == true)
                            tsUser.Enabled = true;
                        else
                            tsUser.Visible  = false;
                    if (item.Screen.ScreenName == "Backup Restore")
                        if (item.CanAccess == true)
                            tsBackup.Enabled = true;
                        else
                            tsBackup.Visible  = false;
                    if (item.Screen.ScreenName == "User Right")
                        if (item.CanAccess == true)
                            tsUserRight.Enabled = true;
                        else
                            tsUserRight.Visible  = false;

                    if (item.Screen.ScreenName == "Setup Led")
                        if (item.CanAccess == true)
                            tsSetupLED.Enabled = true;
                        else
                            tsSetupLED.Visible = false;

                }
                if (!this.IsLoginUser.IsAdmin)
                {
                    //this.tsUser.Visible  = false;
                    //this.tsLabTest.Visible  = false;
                    
                }
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
            prg.Show();
        }

        private void tsDoctorsCheckup_Click(object sender, EventArgs e)
        {
            frmDoctorCheckup dcp = new frmDoctorCheckup(cm);
            dcp.Show();
        }

        private void tsPrintSummary_Click(object sender, EventArgs e)
        {
           // new FrmPrintSummary().Show();
            new FrmTokenSummary().Show();
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

       
       
    }
}
