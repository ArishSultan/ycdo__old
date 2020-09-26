using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Datasets;
using FDM.Reports;
using BLL;
using DAL;
using System.Configuration;
using Common;
namespace FDM
{
    public partial class FrmTokenSummary : Form
    {
        TokenSummaryDAL ts = new TokenSummaryDAL(); 
        public FrmTokenSummary()
        {
            InitializeComponent();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            PrintPreview(false);
        }

        private void tsPreview_Click(object sender, EventArgs e)
        {
            PrintPreview(true);
        }

        private void PrintPreview(bool preview)
        {
            DsTokenSummary printds = new DsTokenSummary();
            DsTokenSummary.PatientRegistrationDataTable resultTalbe = new DsTokenSummary.PatientRegistrationDataTable();
            rptAllTokenReceipt crp = new rptAllTokenReceipt();
            string BranchName= ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();
            string shifttime="";
            
            int? uNO = 0;
            string UserName = "All Users";
            if (chbUsers.Checked)
            {
                uNO = Convert.ToInt16(cbxUser.SelectedValue.ToString()); 
                List<User> selectedusers = this.users.Where(u => u.Userno == uNO).ToList<User>();
                foreach (var item in selectedusers)
                {
                    UserName = item.UserName;
		        }
                //UserBLL userBLL = new UserBLL();
                //List<User> users = this.userBLL.GetUsers().Where(u => u.Userno == uNO).ToList<User>();
            }
                
            
            if (cbxShifts.SelectedIndex == 0 || cbxShifts.SelectedIndex == -1)
                printds = new TokenSummaryBLL().GetTokenSummary(dtpFrom.Value.Date, dtpTo.Value.Date, rbAll.Checked, rbInjection.Checked, rbCheckup.Checked, rbLab.Checked, rbMedicine.Checked, cb50.Checked, uNO);
            else
            {
                printds = new TokenSummaryBLL().GetTokenSummary(dtpFrom.Value.Date, dtpTo.Value.Date, rbAll.Checked, rbInjection.Checked, rbCheckup.Checked, rbLab.Checked, rbMedicine.Checked, cb50.Checked, (Shift)cbxShifts.SelectedItem, uNO);
                Shift shift = (Shift)cbxShifts.SelectedItem;
                shift = new BLL.ShiftsBLL().GetShiftStartEndTime(shift,this.dtpFrom.Value.Date);
                shifttime = shift.ChangeDateTime.ToString("hh:mm:ss");
            }
            
            string tokenType = "";
            string tokenRange = "";
            if (rbAll.Checked == true)
                tokenType = "All tokens";
            else if (rbCheckup.Checked == true)
                tokenType = "Checkup only";
            else if (rbInjection.Checked == true)
                tokenType = "Injection only";
            else if (rbLab.Checked == true)
                tokenType = "Lab test only";
            else if (rbMedicine.Checked == true)
                tokenType = "Medicines";

            tokenType += " - " + cbxShifts.Text + ' ' + shifttime;
            string filterExpression;
            if (rbRange.Checked == true)
            {
                try
                {
                    int to = 0, from = 0;
                    bool r;
                    if (txtToToken.Text.Trim() != string.Empty)
                        r = int.TryParse(txtToToken.Text.Trim(), out to);
                    if (txtFromToken.Text.Trim() != string.Empty)
                        r = int.TryParse(txtFromToken.Text.Trim(), out from);

                    if (to == 0)
                    {
                        MessageBox.Show("Please Enter the Valid Token Number");
                        this.txtToToken.Focus();
                        return;
                    }
                    if (from == 0)
                    {
                        MessageBox.Show("Please Enter the Valid Token Number");
                        this.txtFromToken.Focus();
                        return;
                    }
                    
                    filterExpression = "TokenNumber >= " + from.ToString() + " and TokenNumber <= " + to.ToString();
                    
                    DataRow[] TokenRows = ((DataTable)printds.PatientRegistration).Select(filterExpression);

                    foreach (DataRow row in TokenRows)
                    {
                        resultTalbe.ImportRow(row);
                    }
                    tokenRange = from.ToString() + "  to  " + to.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Token Range Invalid");
                    return;
                }

            }
            else
            {
                resultTalbe = printds.PatientRegistration;
                tokenRange = "All Tokens";
            }

            //if (rbCheckup.Checked)
            //{
            //    if (chbPoor.Checked)
            //    {
            //        if (String.IsNullOrEmpty(filterExpression))
            //    }
            //}

            
            crp.SetDataSource((DataTable)resultTalbe );
            crp.SetParameterValue("TokenType", tokenType);
            crp.SetParameterValue("fromDate", dtpFrom.Value.Date);
            crp.SetParameterValue("toDate", dtpTo.Value.Date);
            crp.SetParameterValue("TokenRange", tokenRange);
            crp.SetParameterValue("BranchName",BranchName);
            crp.SetParameterValue("BranchAddress", BranchAddress);
            crp.SetParameterValue("UserName", UserName);
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;

            //frmViewer.crystalReportViewer1.SelectionFormula = ""
            if (preview)
                frmViewer.ShowDialog();
            else
            {
                frmViewer.crystalReportViewer1.RefreshReport();
                frmViewer.crystalReportViewer1.PrintReport();
            }

        }
        UserBLL userBLL;
        List<User> users;
        private void FrmTokenSummary_Load(object sender, EventArgs e)
        {
            List<Shift> shifts = new BLL.ShiftsBLL().GetShifts();
            Shift s = new Shift(0, "All Shifts", false);
            cbxShifts.Items.Add(s);
            foreach (Shift item in shifts)
            {
                cbxShifts.Items.Add(item);
            }
            cbxShifts.DisplayMember = "ShiftName";

            try
            {
                this.userBLL = new UserBLL();
                this.users = this.userBLL.GetUsers();
                this.cbxUser.DataSource = this.users;
                this.cbxUser.DisplayMember = "username";
                this.cbxUser.ValueMember = "userno";

                this.cbxUser.SelectedIndex = -1;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "FrmTokenSummary_Load");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void cb50_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCheckup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCheckup.Checked)
                gbCheckup.Enabled = true;
            else
                gbCheckup.Enabled = false;
        }

        private void chbUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (chbUsers.Checked == true)
            {
                cbxUser.Enabled = true;
                cbxUser.SelectedIndex = 0;
            }
            else
            {
                cbxUser.Enabled = false;
                cbxUser.SelectedIndex = -1;
            }     
        }
    }
}

