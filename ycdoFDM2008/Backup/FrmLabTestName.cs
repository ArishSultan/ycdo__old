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
using FDM.SearchForms;
namespace FDM
{
    public partial class FrmLabTestName : Form
    {
        public FrmLabTestName()
        {
            InitializeComponent();
        }
        LabTestName ltn;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearControls()
        {
            txtTestName.Text = "";
            txtsample.Text = "";
            txtreport.Text = "";
            txtPerformed.Text = "";
            txtPoor.Text = "";
            txtgeneral.Text = "";
            txtYCDO.Text = "";
            txtDeserving.Text = "";
            txtshahab.Text = "";
            txtGhori.Text = "";
            txtRetailPrice.Text = "";
            txtPurchasePrice.Text = "";
            txtUnit.Text = "";
            frm.CurrentLabName = null;
            rbAlwaysPaid.Checked = false;
            rbTenInjection.Checked = false;
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            this.txtid.Text = new LabTestNameBLL().GetNextLabTestId().ToString("00000");
            ClearControls();
        }
        
        private void tsSave_Click(object sender, EventArgs e)
        {

        }
        SchLabTestName frm = new SchLabTestName();
        private void tsEdit_Click(object sender, EventArgs e)
        {
            LabTestName ltn = new LabTestName();
            if (this.rbMedicine.Checked == true)
                frm.IsMedicine = true;
            else
                frm.IsMedicine = false;

            if (this.chxOd.Checked == true)
                frm.IsOd = true;
            else
                frm.IsOd = false;

            if (this.rbTenInjection.Checked == true)
                frm.IsTenInjection = true;
            else
                frm.IsTenInjection = false;

            if (this.rbAlwaysPaid.Checked == true)
                frm.IsAlwaysPaid = true;
            else
                frm.IsAlwaysPaid = false;           

            frm.ShowDialog();
            if (frm.CurrentLabName != null)
            {
                this.txtid.Text = frm.CurrentLabName.ID.ToString("00000");
                this.txtTestName.Text = frm.CurrentLabName.TestName;
                txtPurchasePrice.Text = frm.CurrentLabName.PurchasePrice.ToString();
                txtRetailPrice.Text = frm.CurrentLabName.RetailPrice.ToString();
                this.txtPerformed.Text = frm.CurrentLabName.Performed;
                this.txtreport.Text = frm.CurrentLabName.Report;
                this.txtsample.Text = frm.CurrentLabName.Sample;
                this.txtPoor.Text = frm.CurrentLabName.Poor.ToString();
                this.txtDeserving.Text = frm.CurrentLabName.Deserving.ToString();
                this.txtYCDO.Text = frm.CurrentLabName.YCDO.ToString();
                this.txtgeneral.Text = frm.CurrentLabName.General.ToString();
                this.txtshahab.Text = frm.CurrentLabName.Shahab.ToString();
                this.txtGhori.Text = frm.CurrentLabName.Ghori.ToString();
                if (frm.CurrentLabName.IsMedicine)
                    this.rbMedicine.Checked = frm.CurrentLabName.IsMedicine;
                else
                    this.rbLabTest.Checked = true;
                this.txtUnit.Text = frm.CurrentLabName.Unit;

                this.rbAlwaysPaid.Checked = frm.CurrentLabName.IsAlwaysPaid;
                this.rbTenInjection.Checked = frm.CurrentLabName.IsRsTenInjection;
             
            }
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            ltn=new LabTestName();
            if (frm.CurrentLabName != null)
            {
                ltn.ID = frm.CurrentLabName.ID;
                if (new LabTestNameBLL().DeleteLabtestName(ltn) == true)
                {
                    if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                        MessageBox.Show("LabTestName Deleted Successfully", "Message");

                    ClearControls();
                }
                else
                    ClearControls();
            }
        }
       
      

        private void tsSave_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (txtTestName.Text.Length > 0)
                {
                    LabTestName ltn = new LabTestName();
                    ltn.TestName = txtTestName.Text.Trim();
                    ltn.Sample = txtsample.Text.Trim();
                    ltn.Performed = txtPerformed.Text.Trim();
                    ltn.Report = txtreport.Text.Trim();
                    if (rbMedicine.Checked)
                        ltn.IsMedicine = true;
                    ltn.IsOd = this.chxOd.Checked;
                    Decimal poor;
                    Decimal.TryParse(this.txtPoor.Text, out poor);
                    ltn.Poor = poor;

                    Decimal deserving;
                    Decimal.TryParse(this.txtDeserving.Text, out deserving);
                    ltn.Deserving = deserving;

                    Decimal ycdo;
                    Decimal.TryParse(this.txtYCDO.Text, out ycdo);
                    ltn.YCDO = ycdo;

                    Decimal general;
                    Decimal.TryParse(this.txtgeneral.Text, out general);
                    ltn.General = general;

                    Decimal ghori;
                    Decimal.TryParse(this.txtGhori.Text, out ghori);
                    ltn.Ghori = ghori;

                    Decimal shahab;
                    Decimal.TryParse(this.txtshahab.Text, out shahab);
                    ltn.Shahab = shahab;
                    ltn.Unit = this.txtUnit.Text.Trim();
                    ltn.IsRsTenInjection = this.rbTenInjection.Checked;
                    ltn.IsAlwaysPaid = this.rbAlwaysPaid.Checked;
                    ltn.PurchasePrice = Convert.ToDouble(txtPurchasePrice.Text);
                    ltn.RetailPrice = Convert.ToDouble(txtRetailPrice.Text);
                    if (frm.CurrentLabName != null)
                    {
                        ltn.ID = frm.CurrentLabName.ID;
                    }
                    if (new LabTestNameBLL().SaveLabtestname(ltn))
                    {
                        MessageBox.Show("Lab Test Name Saved Successfully", "Success");
                        this.txtid.Text = new LabTestNameBLL().GetNextLabTestId().ToString("00000");
                        ClearControls();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLabTestName_Load(object sender, EventArgs e)
        {
            this.txtid.Text = new LabTestNameBLL().GetNextLabTestId().ToString("00000");
        }

        private void rbMedicine_CheckedChanged(object sender, EventArgs e)
        {
            this.gbMedicineType.Visible = this.rbMedicine.Checked;
        }

      

        

    }
}
