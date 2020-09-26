﻿using System;
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
            printds = new TokenSummaryBLL().GetTokenSummary(dtpFrom.Value.Date, dtpTo.Value.Date, rbAll.Checked, rbInjection.Checked, rbCheckup.Checked, rbLab.Checked,rbMedicine.Checked, cb50.Checked);
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

                    string filterExpression = "TokenNumber >= " + from.ToString() + " and TokenNumber <= " + to.ToString();
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
            
            crp.SetDataSource((DataTable)resultTalbe );
            crp.SetParameterValue("TokenType", tokenType);
            crp.SetParameterValue("fromDate", dtpFrom.Value.Date);
            crp.SetParameterValue("toDate", dtpTo.Value.Date);
            crp.SetParameterValue("TokenRange", tokenRange);
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
