using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
using Common.Datasets;
using FDM.Reports;
using FDM.SearchForms;
using System.Media;
using FDM.ReportForms;
namespace FDM
{
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }

        List<LabTest> labtests;
        RecieveMedicine rm;
        SchRecieveMedicine frm = new SchRecieveMedicine();
        List<RecieveMedicine> LoRec;

        private void frmRecieveMedicine_Load(object sender, EventArgs e)
        {
            labtests = new LabTestBLL().GetLabTests();
            rm = new RecieveMedicine();
            //List<LabTest> medicines = labtests.Where(m => m.IsMedicine == true || m.IsRsTenInjection ==true || m.IsAlwaysPaid ==true).ToList<LabTest>();
            //labtests = null;
            //labtests = medicines;
            cbxLabTest.DataSource = labtests;
            cbxLabTest.DisplayMember = "TestName";
            cbxLabTest.ValueMember = "LabTestId";
       
            cbxbranches.DataSource = new BranchBLL().GetBranchData();
            cbxbranches.DisplayMember = "BranchName";
            cbxbranches.ValueMember = "BranchID";
            NewRecipt();
        }
        private void GetNextReceiptNumber()
        {
            long receiptNumber = new LabTestBLL().GetNextReceiptNumber();
            this.txtRecieveNumber.Text = receiptNumber.ToString("0000");
            rm.RecieveNumber = receiptNumber;
        }
        RecieveLineItem rli = new RecieveLineItem();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQty.Text.Length > 0)
            {
                object[] values = { (LabTest)this.cbxLabTest.SelectedItem, this.txtQty.Text };
                RecieveLineItem rli = new RecieveLineItem();
                rli.LineItem.LabTestId = ((LabTest)(this.cbxLabTest.SelectedItem)).LabTestId;
                rli.LineItem.TestName = ((LabTest)(this.cbxLabTest.SelectedItem)).TestName;
                rli.Quantity = Convert.ToInt32(this.txtQty.Text);
                rli.Price = Convert.ToDouble(txtPrice.Text);
                rli.GrossAmount = Convert.ToDouble(txtGrossAmount.Text);
                if (!rm.Lines.Contains(rli))
                {
                    rm.Lines.Add(rli);
                }
                else
                {
                    RecieveLineItem rtemp = rm.Lines[rm.Lines.IndexOf(rli)];
                    rtemp = rli;
                    rm.Lines[rm.Lines.IndexOf(rli)] = rtemp;
                }
                rm.RecieveDate = this.dtpReceiveDate.Value.Date;
                this.dgvRecieveMedicine.DataSource = null;
                this.dgvRecieveMedicine.DataSource = rm.Lines;

                for (int i = 0; i <= dgvRecieveMedicine.Rows.Count; i++)
                {
                    dgvRecieveMedicine.Columns["NetAmount"].Visible = false;
                }
                this.dgvRecieveMedicine.Columns[0].Width = 160;
                this.dgvRecieveMedicine.Columns[0].HeaderText = "Medicine Name";
            }
            txtQty.Text = "";
            txtPrice.Text = "";
            txtGrossAmount.Text = "";
            // 
            txtNetAmount.Text = GetNetTotal().ToString();
            dgvRecieveMedicine.ClearSelection();
            cbxLabTest.Focus();
        }
        public double GetNetTotal()
        {
            double sum = 0;
            for (int i = 0; i < dgvRecieveMedicine.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgvRecieveMedicine.Rows[i].Cells["GrossAmount"].Value);
            }
            return sum;
        }
        private void NewRecipt()
        {
            rm = new RecieveMedicine();
            this.dgvRecieveMedicine.DataSource = null;
            txtQty.Text = "";
            //cbxLabTest.Text = "";
            txtPrice.Text = "";
            txtID.Text = "";
            txtNetAmount.Text = "";
            cbxbranches.Text = "";
            frm.Current = null;
            GetNextReceiptNumber();
        }      
        private void txtQty_Leave(object sender, EventArgs e)
        {
            if (txtQty.Text.Length > 0 && txtPrice.Text.Length > 0)
                txtGrossAmount.Text = ((Convert.ToInt32(txtQty.Text)) * (Convert.ToDouble(txtPrice.Text))).ToString();
        }
        private void cbxLabTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (labtests.Count > 0)
            {
                rli.LineItem.LabTestId = ((LabTest)(this.cbxLabTest.SelectedItem)).LabTestId;
                txtPrice.Text = labtests.Where(p => p.TestName == cbxLabTest.Text).Single<LabTest>().Price.ToString();
            }
        }
        private void tsDel_Click(object sender, EventArgs e)
        {
            if (frm.Current != null)
            {
                int ReceiveNmber = Convert.ToInt32(txtRecieveNumber.Text);
                if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (new LabTestBLL().DeleteReceivedMedicine(ReceiveNmber) == true)
                    {
                        System.Media.SystemSounds.Asterisk.Play();
                        MessageBox.Show("Medicine Has Been Deleted Successfully", "Deleted ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NewRecipt();

                    }
                }
            }
        }
        private void tsClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frm.Current = null;
        }
        private void tsNew_Click_1(object sender, EventArgs e)
        {
            NewRecipt();
        }
        Branch b;
        private void tsSave_Click_1(object sender, EventArgs e)
        {
            b = new Branch();
            if (rm != null && rm.Lines.Count > 0 && this.cbxbranches.SelectedIndex!=-1)
            {
                if (frm.Current != null)
                {
                    rm.RefRec.LineItem.MedIssuedID = Convert.ToInt32(txtID.Text);
                }
                rm.RecieveDate = this.dtpReceiveDate.Value.Date;
                rm.RefRec.NetAmount = Convert.ToDouble(txtNetAmount.Text);
                //rm.RefBranch.BranchID = Convert.ToInt16(cbxbranches.ValueMember);
                rm.RefBranch.BranchID = Convert.ToInt16(cbxbranches.SelectedValue);

                b = (Branch)cbxbranches.SelectedItem;
                if (new LabTestBLL().SaveReceivedMedicine(rm) == true)
                {
                    MessageBox.Show("Medicine Has Been Saved Successfully");
                    if ((MessageBox.Show("Do You Want To Print Out The Invoice?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                    {
                        PrintPreview(false);
                        NewRecipt();
                    }
                    NewRecipt();
                }
            }
        }
        rptReceiveBill crp = new rptReceiveBill();
        private void PrintPreview(bool Privew)
        {
            DSIssueBill.DTIssueBillDataTable ds = new LabTestBLL().PrintRecMedBill(rm);
            crp.SetDataSource((DataTable)ds);
            FrmReportViewer frmViewer = new FrmReportViewer();
            frmViewer.crystalReportViewer1.ReportSource = crp;
            crp.SetParameterValue("BranchName", this.b.BranchName);
            if (Privew)
                frmViewer.ShowDialog();
            else
            {
                //frmViewer.crystalReportViewer1.RefreshReport();
                frmViewer.crystalReportViewer1.PrintReport();
            }




        }
        private void tsEdit_Click_1(object sender, EventArgs e)
        {
           
            frm.ShowDialog();
            rm.Lines.Clear();
            dgvRecieveMedicine.DataSource = null;
            dgvRecieveMedicine.DataSource = rm.Lines;
            if (frm.Current != null)
            {
          
                dtpReceiveDate.Text = frm.Current.RecieveDate.ToShortDateString();
                txtRecieveNumber.Text = frm.Current.RecieveNumber.ToString();
              
                txtNetAmount.Text = frm.Current.RefRec.NetAmount.ToString();
                txtID.Text = frm.Current.RefRec.LineItem.MedIssuedID.ToString();
                LoRec = new LabTestBLL().GetRecieveMedicines(txtRecieveNumber.Text.ToString());
                rm = new RecieveMedicine();
                rm.RecieveNumber = Convert.ToInt64(txtRecieveNumber.Text); 
                foreach (var item in LoRec)
                {
                    RecieveLineItem rli = new RecieveLineItem();
                    rli.LineItem.LabTestId = item.RefRec.LineItem.LabTestId;
                    rli.LineItem.TestName = item.RefRec.LineItem.TestName;
                    rli.Quantity = item.Quantity;
                    rli.Price = item.RefRec.Price;
                    rli.GrossAmount = item.RefRec.GrossAmount;

                    cbxbranches.SelectedValue = item.RefBranch.BranchID;
                    
                    if (!rm.Lines.Contains(rli))
                    {
                        rm.Lines.Add(rli);
                    }
                    else
                    {
                        RecieveLineItem rtemp = rm.Lines[rm.Lines.IndexOf(rli)];
                        rtemp = rli;
                        rm.Lines[rm.Lines.IndexOf(rli)] = rtemp;
                    }
                    dgvRecieveMedicine.DataSource = null;
                    dgvRecieveMedicine.DataSource = rm.Lines;
                    for (int i = 0; i < dgvRecieveMedicine.Columns.Count; i++)
                    {
                       
                        dgvRecieveMedicine.Columns[i].Visible = true;
                        dgvRecieveMedicine.Columns["LineItem"].HeaderText = "Medicine Name";
                        dgvRecieveMedicine.Columns["LineItem"].Width = 160;
                        dgvRecieveMedicine.Columns["Quantity"].Width = 100;
                        dgvRecieveMedicine.Columns["NetAmount"].Visible = false;
                    }

                    dgvRecieveMedicine.ClearSelection();
                }

            }
        }
        private void dgvRecieveMedicine_DoubleClick(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
            if (MessageBox.Show("Do You Really Want To Remove This Row?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (dgvRecieveMedicine.CurrentRow != null)
                {
                    if (rm.Lines.Count > 0)
                    {
                        rm.Lines.RemoveAt(dgvRecieveMedicine.CurrentRow.Index);
                        btnAdd_Click(sender, e);
                        dgvRecieveMedicine.DataSource = null;
                        dgvRecieveMedicine.DataSource = rm.Lines;
                        dgvRecieveMedicine.Columns["LineItem"].HeaderText = "Medicine Name";
                        dgvRecieveMedicine.Columns["LineItem"].Width = 160;
                        dgvRecieveMedicine.Columns["Quantity"].Width = 100;
                        dgvRecieveMedicine.Columns["NetAmount"].Visible = false;
                    }
                }
        }


    }
}
