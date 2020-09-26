using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using BLL;
namespace FDM
{
    public partial class FrmLabTest : Form
    {
        public FrmLabTest()
        {
            InitializeComponent();
        }
        List<LabTest> quotes, subList;
        LabTestBLL lbtBll;

        private void FrmLabTest_Load(object sender, EventArgs e)
        {
            lbtBll = new LabTestBLL();
            quotes = lbtBll.GetLabTests();
            this.GrdMain.DataSource = this.quotes;
            this.FormatGrid();
        }

        private void MakeCondition(object sender, EventArgs e)
        {
            LabTest lb = new LabTest();
            
            string str = "";

            if (this.txtID.Text.Trim().Length > 0)
            {
                str = str + "[LabTestId] = " + this.txtID.Text.Trim();
            }
            if (this.txtTest.Text.Trim().Length > 0)
            {
                if (str.Length > 0)
                {
                    str = str + " ƒ ";
                }
                str = str + "[TestName] = " + this.txtTest.Text.Trim();
            }
            if (this.txtSample.Text.Trim().Length > 0)
            {
                if (str.Length > 0)
                {
                    str = str + " ƒ ";
                }
                str = str + " [SampleName] = " + this.txtSample.Text.Trim();
            }
            if (this.txtPerformed.Text.Trim().Length > 0)
            {
                if (str.Length > 0)
                {
                    str = str + " ƒ ";
                }
                str = str + " [Performed] = " + this.txtPerformed.Text.Trim();
            }
            if (this.txtReport.Text.Trim().Length > 0)
            {
                if (str.Length > 0)
                {
                    str = str + " ƒ ";
                }
                str = str + " [Report] = " + this.txtReport.Text.Trim();
            }

            if (this.txtDeserving.Text.Trim().Length > 0)
            {
                if (str.Length > 0)
                {
                    str = str + " ƒ ";
                }
                str = str + " [Deserving] = " + this.txtDeserving.Text.Trim();
            }

            if (this.txtPoor.Text.Trim().Length > 0)
            {
                if (str.Length > 0)
                {
                    str = str + " ƒ ";
                }
                str = str + " [Poor] = " + this.txtPoor .Text.Trim();
            }

            if (this.txtYCDO.Text.Trim().Length > 0)
            {
                if (str.Length > 0)
                {
                    str = str + " ƒ ";
                }
                str = str + " [YCDO] = " + this.txtYCDO.Text.Trim();
            }

            if (this.txtGeneral.Text.Trim().Length > 0)
            {
                if (str.Length > 0)
                {
                    str = str + " ƒ ";
                }
                str = str + " [General] = " + this.txtGeneral.Text.Trim();
            }
            
            LabTest.Condition = str;
            if (str.Length > 0)
            {
                this.subList = this.quotes.FindAll(new Predicate<LabTest>(this.FilterBarfun));
                this.GrdMain.DataSource = null;
                this.GrdMain.DataSource = this.subList;
                this.FormatGrid();
            }
            else
            {
                this.GrdMain.DataSource = this.quotes;
                this.FormatGrid();
            }
            this.GrdMain.ClearSelection();
        }

        private void FormatGrid()
        {
            for (int i = 0; i < this.GrdMain.Columns.Count; i++)
            {

                if (this.GrdMain.Columns[i].Name.ToUpper() == "Shahab".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "Ghori".ToUpper())
                {
                    this.GrdMain.Columns[i].Visible = false;
                }
                if (this.GrdMain.Columns[i].Name.ToUpper() == "LabTestId".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "General".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "YCDO".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "Poor".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "Deserving".ToUpper())
                {
                    DataGridViewColumn column1 = this.GrdMain.Columns[i];
                    column1.Width = 50;

                }
                if (this.GrdMain.Columns[i].Name.ToUpper() == "Report".ToUpper())// || this.GrdMain.Columns[i].Name.ToUpper() == "General".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "YCDO".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "Poor".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "Deserving".ToUpper())
                {
                    DataGridViewColumn column1 = this.GrdMain.Columns[i];
                    column1.Width = 120;

                }
                if (this.GrdMain.Columns[i].Name.ToUpper() == "id".ToUpper())// || this.GrdMain.Columns[i].Name.ToUpper() == "YCDO".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "Poor".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "TestName".ToUpper()
                    GrdMain.Columns[i].ReadOnly = true;
                else
                    GrdMain.Columns[i].ReadOnly = false;
            }
        }

        private bool FilterBarfun(LabTest p)
        {
            try
            {
                string[] separator = new string[] { "ƒ" };
                string[] strArray2 = LabTest.Condition.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string str2 = "";
                for (int i = 0; i < strArray2.Length; i++)
                {
                    string str3 = strArray2[i].Split(new char[] { '=' }).GetValue(0).ToString().Trim();
                    string str4 = strArray2[i].Split(new char[] { '=' }).GetValue(1).ToString().Trim().ToUpper();
                    if (str4.ToString().Trim().Length == 0)
                    {
                        str2 = " FALSE";
                    }
                    string str5 = str3;
                    if (str5 != null)
                    {
                        if (str5 == "[LabTestId]")
                            str2 = str2 + " " + Convert.ToString(p.LabTestId.ToString ().ToUpper().StartsWith(str4).ToString().ToUpper());
                        else if (str5 == "[TestName]")
                            str2 = str2 + " " + Convert.ToString(p.TestName.ToUpper().StartsWith(str4).ToString().ToUpper());
                        else if (str5 == "[SampleName]")
                            str2 = str2 + " " + Convert.ToString(p.SampleName.ToUpper().StartsWith(str4).ToString().ToUpper());
                        else if (str5 == "[Performed]")
                            str2 = str2 + " " + Convert.ToString(p.Performed.ToUpper().StartsWith(str4).ToString().ToUpper());
                        else if (str5 == "[Report]")
                            str2 = str2 + " " + Convert.ToString(p.Report.ToUpper().StartsWith(str4).ToString().ToUpper());


                        else if (str5 == "[Deserving]")
                            str2 = str2 + " " + Convert.ToString(p.Deserving.ToString ().ToUpper().StartsWith(str4).ToString().ToUpper());

                        else if (str5 == "[Poor]")
                            str2 = str2 + " " + Convert.ToString(p.Poor.ToString ().ToUpper().StartsWith(str4).ToString().ToUpper());

                        else if (str5 == "[YCDO]")
                            str2 = str2 + " " + Convert.ToString(p.YCDO.ToString().ToUpper().StartsWith(str4).ToString().ToUpper());
                        else if (str5 == "[General]")
                            str2 = str2 + " " + Convert.ToString(p.General.ToString ().ToUpper().StartsWith(str4).ToString().ToUpper());

                    }
                }
                if (str2.Contains(" FALSE"))
                {
                    return false;
                }
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "FilterBarfun ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            try
            {

            

            if (lbtBll.SaveLabTests(quotes) == true)
            {
                quotes = lbtBll.GetLabTests();
                this.GrdMain.DataSource = null;
                this.GrdMain.DataSource = quotes;
                FormatGrid();
                MessageBox.Show("Record saved successfully.", "Inforamtion");
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
