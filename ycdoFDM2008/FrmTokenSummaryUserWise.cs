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
    public partial class FrmTokenSummaryUserWise : Form
    {
        TokenSummaryDAL ts = new TokenSummaryDAL();
        public FrmTokenSummaryUserWise()
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
            DSTTokenSummryUserWise printds = new DSTTokenSummryUserWise();
         //   DsTokenSummary.PatientRegistrationDataTable resultTalbe = new DsTokenSummary.PatientRegistrationDataTable();
            DSTTokenSummryUserWise.TokenSummeryUserWiseDataTable resultTalbe = new DSTTokenSummryUserWise.TokenSummeryUserWiseDataTable();
            rptTokensUserWise crp = new rptTokensUserWise();
            string BranchName= ConfigurationManager.AppSettings["Name"].ToString();
            string BranchAddress = ConfigurationManager.AppSettings["Address"].ToString();
          //  string shifttime="";

            /////////   ---------------------------     Asif - 04-05-19 - Disable if & send time flag as parameter
            printds = new TokenSummaryBLL().GetTokenSummaryUserWise(dtpFrom.Value, dtpTo.Value, chkSelectTime.Checked);
            //if (chkSelectTime.Checked==true)
            //{
            //    printds = new TokenSummaryBLL().GetTokenSummaryUserWise(dtpFrom.Value, dtpTo.Value);
            //}
            //else
            //{
            //    printds = new TokenSummaryBLL().GetTokenSummaryUserWise(dtpFrom.Value.Date, dtpTo.Value.Date);
            //}
            /////////   ---------------------------     Asif - 04-05-19 - Disable

         //   printds = new TokenSummaryBLL().GetTokenSummaryUserWise(dtpFrom.Value, dtpTo.Value);
           

            //if (cbxShifts.SelectedIndex == 0 || cbxShifts.SelectedIndex == -1)
            //    printds = new TokenSummaryBLL().GetTokenSummary(dtpFrom.Value.Date, dtpTo.Value.Date, rbAll.Checked, rbInjection.Checked, rbCheckup.Checked, rbLab.Checked, rbMedicine.Checked, cb50.Checked);
            //else
            //{
             //    Shift shift = (Shift)cbxShifts.SelectedItem;
            //    shift = new BLL.ShiftsBLL().GetShiftStartEndTime(shift,this.dtpFrom.Value.Date);
            //    shifttime = shift.ChangeDateTime.ToString("hh:mm:ss");

            //}
            
            //string tokenType = "";
            //string tokenRange = "";
            //if (rbAll.Checked == true)
            //    tokenType = "All tokens";
            //else if (rbCheckup.Checked == true)
            //    tokenType = "Checkup only";
            //else if (rbInjection.Checked == true)
            //    tokenType = "Injection only";
            //else if (rbLab.Checked == true)
            //    tokenType = "Lab test only";
            //else if (rbMedicine.Checked == true)
            //    tokenType = "Medicines";

            //tokenType += " - " + cbxShifts.Text+shifttime;
            //if (rbRange.Checked == true)
            //{
            //    try
            //    {
            //        int to = 0, from = 0;
            //        bool r;
            //        if (txtToToken.Text.Trim() != string.Empty)
            //            r = int.TryParse(txtToToken.Text.Trim(), out to);
            //        if (txtFromToken.Text.Trim() != string.Empty)
            //            r = int.TryParse(txtFromToken.Text.Trim(), out from);

            //        if (to == 0)
            //        {
            //            MessageBox.Show("Please Enter the Valid Token Number");
            //            this.txtToToken.Focus();
            //            return;
            //        }
            //        if (from == 0)
            //        {
            //            MessageBox.Show("Please Enter the Valid Token Number");
            //            this.txtFromToken.Focus();
            //            return;
            //        }

            //        string filterExpression = "TokenNumber >= " + from.ToString() + " and TokenNumber <= " + to.ToString();
            //        DataRow[] TokenRows = ((DataTable)printds.PatientRegistration).Select(filterExpression);

            //        foreach (DataRow row in TokenRows)
            //        {
            //            resultTalbe.ImportRow(row);
            //        }
            //        tokenRange = from.ToString() + "  to  " + to.ToString();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Token Range Invalid");
            //        return;
            //    }

            //}
            //else
            //{
            //    resultTalbe = printds.PatientRegistration;
            //    tokenRange = "All Tokens";
            //}
            resultTalbe = printds.TokenSummeryUserWise;
            crp.SetDataSource((DataTable)resultTalbe );
          //  crp.SetParameterValue("TokenType", tokenType);
            
            if (chkSelectTime.Checked == true)
            {
                crp.SetParameterValue("fromDate", dtpFrom.Value.ToString("dd/MM/yyyy HH:mm"));
                crp.SetParameterValue("toDate", dtpTo.Value.ToString("dd/MM/yyyy HH:mm"));
            }
            else
            {
                crp.SetParameterValue("fromDate", dtpFrom.Value.ToString("dd/MM/yyyy"));
                crp.SetParameterValue("toDate", dtpTo.Value.ToString("dd/MM/yyyy"));
            }
            
            //crp.SetParameterValue("TokenRange", tokenRange);
            crp.SetParameterValue("BranchName",BranchName);
            crp.SetParameterValue("BranchAddress", BranchAddress);
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;
            if (preview)
                frmViewer.ShowDialog();
            else
            {
                frmViewer.crystalReportViewer1.RefreshReport();
                frmViewer.crystalReportViewer1.PrintReport();
            }

        }

        private void FrmTokenSummary_Load(object sender, EventArgs e)
        {
           // List<Shift> shifts = new BLL.ShiftsBLL().GetShifts();
           // Shift s = new Shift(0, "All Shifts", false);
            //cbxShifts.Items.Add(s);
            //foreach (Shift item in shifts)
            //{
            //    cbxShifts.Items.Add(item);
            //}
            //cbxShifts.DisplayMember = "ShiftName";

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
    }
}
