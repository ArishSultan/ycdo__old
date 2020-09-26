using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using OleDbHelper;
using System.Text;
using System.Windows.Forms;
using Common;
using BLL;
using DAL;
using FDM.SearchForms;
using System.Media;
using FDM.Reports;
using Common.Datasets;

namespace FDM
{
    public partial class frmIssuedMedicine : Form
    {
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbDataReader dr;
        private OleDbTransaction tran;
        
        public frmIssuedMedicine()
        {
            InitializeComponent();
        }
        List<LabTest> labtests;
        RecieveMedicine rm;
        List<Branch> branchs;
        List<RecieveMedicine> LoRec;
        SchIssuedMedicine frm = new SchIssuedMedicine();
        private void frmMedicineIssued_Load(object sender, EventArgs e)
        {
            labtests = new LabTestBLL().GetLabTests();
            rm = new RecieveMedicine();
            //List<LabTest> medicines = labtests.Where(m => m.IsMedicine == true || m.IsRsTenInjection == true || m.IsAlwaysPaid == true).ToList<LabTest>();
            //labtests = null;
            //labtests = medicines;
            cbxLabTest.DataSource = labtests;
            cbxLabTest.DisplayMember = "TestName";
            cbxLabTest.ValueMember = "LabTestId";

            branchs = new BranchBLL().GetBranchData();
            cbxbranches.DataSource = branchs;
            cbxbranches.DisplayMember = "BranchName";
            cbxbranches.ValueMember = "BranchID";
            NewRecipt();
        }
        private void GetNextReceiptNumber()
        {
            long receiptNumber = new InjectionLabTestBLL().GetNexReceiptNumber();
            this.txtIssueNumber.Text = receiptNumber.ToString("0000");
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
                rm.RecieveDate = this.dtpIssueDate.Value.Date;
                this.dgvIssueMedicine.DataSource = null;
                this.dgvIssueMedicine.DataSource = rm.Lines;

                for (int i = 0; i <= dgvIssueMedicine.Rows.Count; i++)
                {
                    dgvIssueMedicine.Columns["NetAmount"].Visible = false;
                }
                this.dgvIssueMedicine.Columns[0].Width = 160;
                this.dgvIssueMedicine.Columns[0].HeaderText = "Medicine Name";
            }

            int qty;
            if (string.IsNullOrEmpty(txtQty.Text))
                qty = 0;
            else
                qty = Convert.ToInt16(txtQty.Text);

            if (medcheck3() < qty)
            {
                MessageBox.Show("Recieved quantity of " + cbxLabTest.SelectedItem.ToString() + " is: " + medcheck().ToString() + Environment.NewLine + "Consumed: " + medcheck2().ToString() + Environment.NewLine + "Net Quantity: " + medcheck3().ToString());
                return;
            } 
            txtQty.Text = "";
            txtPrice.Text = "";
            txtGrossAmount.Text = "";
            cbxLabTest.Text = "";
            txtNetAmount.Text =GetNetTotal().ToString();
           dgvIssueMedicine.ClearSelection();
            cbxLabTest.Focus();
            
        }
        Branch b;
        private void tsSave_Click(object sender, EventArgs e)
        {
            b = new Branch();
            if (rm != null && rm.Lines.Count > 0)
            {
                if (frm.Current != null)
                {
                    rm.RefRec.LineItem.MedIssuedID = Convert.ToInt32(txtID.Text);
                }
                  rm.RecieveDate = this.dtpIssueDate.Value.Date;
                  rm.RefRec.NetAmount = Convert.ToDouble(txtNetAmount.Text);
                  rm.RefBranch.BranchID =Convert.ToInt32(cbxbranches.SelectedValue);
                  rm.RefBranch.BranchName = cbxbranches.Text.ToString();

                  b = (Branch)cbxbranches.SelectedItem;

                if (new InjectionLabTestBLL().SaveIssuedMedicine(rm)==true)
                {
                    MessageBox.Show("Medicine Issued Successfully");
                    if ((MessageBox.Show("Do You Want To Print Out The Invoice?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                    {
                     //   PrintPreview(true);

                        new frmPrintIssueMedByPrices(rm).ShowDialog();
                        NewRecipt();
                    }
                   
                }
                NewRecipt();
            }
            //}
        }
        
        private void NewRecipt()
        {
            rm = new RecieveMedicine();
            this.dgvIssueMedicine.DataSource = null;
            txtQty.Text = "";
            cbxLabTest.Text = "";
            txtPrice.Text = "";
            txtID.Text = "";
            txtNetAmount.Text = "";
            cbxbranches.Text = "";
            frm.Current = null;
            GetNextReceiptNumber();
        }
        private void tsEdit_Click(object sender, EventArgs e)
        {
           
            frm.ShowDialog();
            rm.Lines.Clear();
            dgvIssueMedicine.DataSource = null;
            dgvIssueMedicine.DataSource = rm.Lines;
            if (frm.Current != null)
            {
               
                dtpIssueDate.Text = frm.Current.RecieveDate.ToShortDateString();
                txtIssueNumber.Text = frm.Current.RecieveNumber.ToString();
                cbxbranches.Text = frm.Current.RefBranch.BranchName.ToString();
                txtNetAmount.Text = frm.Current.RefRec.NetAmount.ToString();
                txtID.Text = frm.Current.RefRec.LineItem.MedIssuedID.ToString();
                LoRec = new InjectionLabTestBLL().GetIssuedMedicines(txtIssueNumber.Text.ToString());
                rm = new RecieveMedicine();
                rm.RecieveNumber = Convert.ToInt64(txtIssueNumber.Text);
                foreach (var item in LoRec)
                {
                    RecieveLineItem rli = new RecieveLineItem();
                    rli.LineItem.LabTestId = item.RefRec.LineItem.LabTestId;
                    rli.LineItem.TestName = item.RefRec.LineItem.TestName;
                    rli.Quantity = item.Quantity;
                    rli.Price = item.RefRec.Price;
                    rli.GrossAmount = item.RefRec.GrossAmount;
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
                    dgvIssueMedicine.DataSource = null;
                    dgvIssueMedicine.DataSource = rm.Lines;
                    for (int i = 0; i < dgvIssueMedicine.Columns.Count; i++)
                    {
                            dgvIssueMedicine.Columns[i].Visible = true;
                            dgvIssueMedicine.Columns["LineItem"].HeaderText = "Medicine Name";
                            dgvIssueMedicine.Columns["LineItem"].Width = 160;
                            dgvIssueMedicine.Columns["Quantity"].Width = 100;
                            dgvIssueMedicine.Columns["NetAmount"].Visible = false;
                        }
                    dgvIssueMedicine.ClearSelection();
                  
                }

            }
        }
        private void dgvIssueMedicine_DoubleClick(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
            if (MessageBox.Show("Do You Really Want To Remove This Row?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (dgvIssueMedicine.CurrentRow != null)
                {
                    if (rm.Lines.Count > 0)
                    {
                        rm.Lines.RemoveAt(dgvIssueMedicine.CurrentRow.Index);
                        //btnAdd_Click(sender, e);          ////////// Disable - asif - 06-05-19
                        dgvIssueMedicine.DataSource = null;
                        dgvIssueMedicine.DataSource = rm.Lines;
                        dgvIssueMedicine.Columns["LineItem"].HeaderText = "Medicine Name";
                        dgvIssueMedicine.Columns["LineItem"].Width = 160;
                        dgvIssueMedicine.Columns["Quantity"].Width = 100;
                        dgvIssueMedicine.Columns["NetAmount"].Visible = false;
                        txtNetAmount.Text = GetNetTotal().ToString();
                    }
                }
        }
        private void tsNew_Click(object sender, EventArgs e)
        {
            NewRecipt();
        }
        private void tsClose_Click(object sender, EventArgs e)
        {
            frm.Current = null;
            this.Close();
        }
        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (frm.Current != null)
            {
                int Issuenumber = Convert.ToInt32(txtIssueNumber.Text);
                if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (new InjectionLabTestBLL().DeleteIssuedMedicine(Issuenumber) == true)
                    {
                        System.Media.SystemSounds.Asterisk.Play();
                        MessageBox.Show("Issued Medicine Has Been Deleted Successfully", "Deleted ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NewRecipt();

                    }
                }
            }
        }
        private void cbxLabTest_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if(labtests.Count>0)
                rli.LineItem.LabTestId = ((LabTest)(this.cbxLabTest.SelectedItem)).LabTestId;
                txtPrice.Text = labtests.Where(p => p.LabTestId == rli.LineItem.LabTestId).Single<LabTest>().RetailPrice.ToString();
  
        }
        private void txtQty_Leave(object sender, EventArgs e)
        {
            if(txtQty.Text.Length>0&&txtPrice.Text.Length>0)

            txtGrossAmount.Text = ((Convert.ToInt32(txtQty.Text)) *(Convert.ToDouble(txtPrice.Text))).ToString();
        }
        public double GetNetTotal()
        {
            double sum = 0;     
            for (int i = 0; i < dgvIssueMedicine.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgvIssueMedicine.Rows[i].Cells["GrossAmount"].Value);
            }
            return sum;
        }
        private void cbxbranches_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        
        private int medcheck()
        {
            List<int> iteminfo = new List<int>();
            List<string> medname = new List<string>();
            List<int> medqty = new List<int>();
            List<int> medcons = new List<int>();
            List<int> mednet = new List<int>();
            int itemes = 0;
            try
            {
                DataTable dt = new DataTable();
                con = new OleDbConnection();
                readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();

                foreach (RecieveLineItem item in rm.Lines)
                {
                    string select;
                    //if (rm.RefRec.LineItem.MedIssuedID == 0)
                    //{
                    select = "SELECT ItemNumber, ItemName, sum(ReceivedQuantity) AS TotalRecieved, sum(ConsumedQuantity)*-1 AS TotalConsumed, (sum(ReceivedQuantity) - (sum(ConsumedQuantity)*-1)) AS NetQty FROM (select ItemNumber,ItemName,0 as ReceivedQuantity, sum(Qty)* -1 as ConsumedQuantity from QryOutStockWithIM group by ItemNumber,ItemName union all select ItemNumber,ItemName,sum(Qty) as ReceivedQuantity, 0 as ConsumedQuantity from QryInStock group by ItemNumber,ItemName ) AS final GROUP BY ItemNumber, ItemName;";
                    //cmdSave.ExecuteNonQuery();
                    da = new OleDbDataAdapter(select, con);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            int qty = Convert.ToInt32(row["TotalRecieved"] == DBNull.Value ? 0 : row["TotalRecieved"]);
                            int cons = Convert.ToInt32(row["TotalConsumed"] == DBNull.Value ? 0 : row["TotalConsumed"]);
                            int net = Convert.ToInt32(row["NetQty"] == DBNull.Value ? 0 : row["NetQty"]);
                            string name = Convert.ToString(row["ItemName"] == DBNull.Value ? "" : row["ItemName"]);
                            medqty.Add(qty);
                            medcons.Add(cons);
                            mednet.Add(net);
                            medname.Add(name);
                        }

                    }

                }
                for (int i = 0; i < medname.Count; i++)
                {
                    string s = medname[i];
                    if (s.Equals(cbxLabTest.SelectedItem.ToString()))
                    {
                        itemes = i;
                        break;

                    }


                }
                //else
                //{
                //    if (item.LineItem.LabTestId > 0)
                //    {
                //        cmd.CommandText = "update IssuedMedicine set IssueDate=#" + rm.RecieveDate + "#" + "," + "IssueNumber=" + rm.RecieveNumber + "," + "MedicineID=" + item.LineItem.LabTestId + "," + "MedicineName='" + item.LineItem.TestName + "'," +
                //        "Qty=" + item.Quantity + " where ID=" + rm.RefRec.LineItem.MedIssuedID;

                //    }
                //}

                //}
                //tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            { con.Close(); }
            iteminfo.Add(medqty[itemes]);
            iteminfo.Add(medcons[itemes]);
            iteminfo.Add(mednet[itemes]);
            return medqty[itemes];


        }
        private int medcheck2()
        {
            List<int> iteminfo = new List<int>();
            List<string> medname = new List<string>();
            List<int> medqty = new List<int>();
            List<int> medcons = new List<int>();
            List<int> mednet = new List<int>();
            int itemes = 0;
            try
            {
                DataTable dt = new DataTable();
                con = new OleDbConnection();
                readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();


                foreach (RecieveLineItem item in rm.Lines)
                {
                    string select;
                    //if (rm.RefRec.LineItem.MedIssuedID == 0)
                    //{
                    select = "SELECT ItemNumber, ItemName, sum(ReceivedQuantity) AS TotalRecieved, sum(ConsumedQuantity)*-1 AS TotalConsumed, (sum(ReceivedQuantity) - (sum(ConsumedQuantity)*-1)) AS NetQty FROM (select ItemNumber,ItemName,0 as ReceivedQuantity, sum(Qty)* -1 as ConsumedQuantity from QryOutStockWithIM group by ItemNumber,ItemName union all select ItemNumber,ItemName,sum(Qty) as ReceivedQuantity, 0 as ConsumedQuantity from QryInStock group by ItemNumber,ItemName) AS final GROUP BY ItemNumber, ItemName;";
                    //cmdSave.ExecuteNonQuery();
                    da = new OleDbDataAdapter(select, con);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            int qty = Convert.ToInt32(row["TotalRecieved"] == DBNull.Value ? 0 : row["TotalRecieved"]);
                            int cons = Convert.ToInt32(row["TotalConsumed"] == DBNull.Value ? 0 : row["TotalConsumed"]);
                            int net = Convert.ToInt32(row["NetQty"] == DBNull.Value ? 0 : row["NetQty"]);
                            string name = Convert.ToString(row["ItemName"] == DBNull.Value ? "" : row["ItemName"]);
                            medqty.Add(qty);
                            medcons.Add(cons);
                            mednet.Add(net);
                            medname.Add(name);

                        }


                    }

                }
                for (int i = 0; i < medname.Count; i++)
                {
                    string s = medname[i];
                    if (s.Equals(cbxLabTest.SelectedItem.ToString()))
                    {
                        itemes = i;
                        break;

                    }


                }
                //else
                //{
                //    if (item.LineItem.LabTestId > 0)
                //    {
                //        cmd.CommandText = "update IssuedMedicine set IssueDate=#" + rm.RecieveDate + "#" + "," + "IssueNumber=" + rm.RecieveNumber + "," + "MedicineID=" + item.LineItem.LabTestId + "," + "MedicineName='" + item.LineItem.TestName + "'," +
                //        "Qty=" + item.Quantity + " where ID=" + rm.RefRec.LineItem.MedIssuedID;

                //    }
                //}

                //}
                //tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            { con.Close(); }
            iteminfo.Add(medqty[itemes]);
            iteminfo.Add(medcons[itemes]);
            iteminfo.Add(mednet[itemes]);
            return medcons[itemes];


        }
        private int medcheck3()
        {
            List<int> iteminfo = new List<int>();
            List<string> medname = new List<string>();
            List<int> medqty = new List<int>();
            List<int> medcons = new List<int>();
            List<int> mednet = new List<int>();
            int itemes = 0;
            try
            {
                DataTable dt = new DataTable();
                con = new OleDbConnection();
                readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();


                foreach (RecieveLineItem item in rm.Lines)
                {
                    string select;
                    //if (rm.RefRec.LineItem.MedIssuedID == 0)
                    //{
                    select = "SELECT ItemNumber,ItemName,sum(ReceivedQuantity) AS TotalRecieved,sum(ConsumedQuantity)*-1 AS TotalConsumed,(sum(ReceivedQuantity) - (sum(ConsumedQuantity)*-1)) AS NetQty FROM (select ItemNumber,ItemName,0 as ReceivedQuantity, sum(Qty)* -1 as ConsumedQuantity from QryOutStockWithIM group by ItemNumber,ItemName union all select ItemNumber,ItemName,sum(Qty) as ReceivedQuantity, 0 as ConsumedQuantity from QryInStock group by ItemNumber,ItemName) AS final GROUP BY ItemNumber, ItemName;";
                    
                    //cmdSave.ExecuteNonQuery();
                    da = new OleDbDataAdapter(select, con);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            int qty = Convert.ToInt32(row["TotalRecieved"] == DBNull.Value ? 0 : row["TotalRecieved"]);
                            int cons = Convert.ToInt32(row["TotalConsumed"] == DBNull.Value ? 0 : row["TotalConsumed"]);
                            int net = Convert.ToInt32(row["NetQty"] == DBNull.Value ? 0 : row["NetQty"]);
                            string name = Convert.ToString(row["ItemName"] == DBNull.Value ? "" : row["ItemName"]);
                            medqty.Add(qty);
                            medcons.Add(cons);
                            mednet.Add(net);
                            medname.Add(name);

                        }


                    }

                }
                for (int i = 0; i < medname.Count; i++)
                {
                    string s = medname[i];
                    if (s.Equals(cbxLabTest.SelectedItem.ToString()))
                    {
                        itemes = i;
                        break;
                    }
                }
                //else
                //{
                //    if (item.LineItem.LabTestId > 0)
                //    {
                //        cmd.CommandText = "update IssuedMedicine set IssueDate=#" + rm.RecieveDate + "#" + "," + "IssueNumber=" + rm.RecieveNumber + "," + "MedicineID=" + item.LineItem.LabTestId + "," + "MedicineName='" + item.LineItem.TestName + "'," +
                //        "Qty=" + item.Quantity + " where ID=" + rm.RefRec.LineItem.MedIssuedID;

                //    }
                //}

                //}
                //tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            { con.Close(); }
            iteminfo.Add(medqty[itemes]);
            iteminfo.Add(medcons[itemes]);
            iteminfo.Add(mednet[itemes]);
            return mednet[itemes];
        }
        
    }
}
