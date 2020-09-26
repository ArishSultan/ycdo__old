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

namespace FDM
{
    public partial class FrmUpdateDB : Form
    {
        public FrmUpdateDB()
        {
            InitializeComponent();
        }
        public Boolean DataBaseUpdated;
        List<UpdateFields  > ufs;


        private void tsUpdate_Click(object sender, EventArgs e)
        {

            try
            {


                ufs = new List<UpdateFields>();

                if (chkSalesInvoice.Checked == true)
                    ufs.Add(UpdateFields.Sales_Invoice);

                //if (chkChart_Of_Accounts.Checked == true)
                //    ufs.Add(UpdateFields.Chart_Of_Accounts);

                //if (chkCostCodes.Checked == true)
                //    ufs.Add(UpdateFields.CostCodes);

                //if (chkCustomers.Checked == true)
                //    ufs.Add(UpdateFields.Customers);

                //if (chkInventory_Item.Checked == true)
                //    ufs.Add(UpdateFields.Inventory_Item);

                //if (chkinventory_Item_TaxType.Checked == true)
                //    ufs.Add(UpdateFields.inventory_Item_TaxType);

                //if (chkJobs.Checked == true)
                //    ufs.Add(UpdateFields.Jobs);

                //if (chkPhases.Checked == true)
                //    ufs.Add(UpdateFields.Phases);

                //if (chkQuote_Numbers.Checked == true)
                //    ufs.Add(UpdateFields.Quote_Numbers);

                //if (chkSales_Rep.Checked == true)
                //    ufs.Add(UpdateFields.Sales_Rep);

                //if (chkSales_Tax_Authority.Checked == true)
                //    ufs.Add(UpdateFields.Sales_Tax_Authority);

                //if (chkSales_Tax_Code.Checked == true)
                //    ufs.Add(UpdateFields.Sales_Tax_Code);

                //if (chkShip_Via.Checked == true)
                //    ufs.Add(UpdateFields.Ship_Via);

                this.lblLoad.Visible = true;
                this.bgWorker.RunWorkerAsync();
                this.tsUpdate.Enabled = false;
                this.tsClose.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "tsUpdate_Click");
            }

        }

        private void FrmUpdateDB_Load(object sender, EventArgs e)
        {
            lblLoad.Visible = false;
        }
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
               // new UpdateDBBLL().ProcessData(this.bgWorker, ufs);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "bgWorker_DoWork");
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            if (e.ProgressPercentage == 100)
            {
                this.bgWorker.Dispose();
               // this.DataBaseUpdated = new UpdateDBBLL().IsDBUpdated();
                this.Close();
            }
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsAll_Click(object sender, EventArgs e)
        {
            chkSalesInvoice.Checked = true;
        }

        private void tsNone_Click(object sender, EventArgs e)
        {
            chkSalesInvoice.Checked = false;
        }

        private void chkShip_Via_CheckedChanged(object sender, EventArgs e)
        {
        }

    }
}
