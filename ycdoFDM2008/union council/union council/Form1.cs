using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using union_council.Classes;

namespace union_council
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.SerailNumber =Convert.ToInt32( txtSerialNumber.Text);
            record.Address = txtAddress.Text;
            record.Age =Convert.ToInt32( txtAge.Text);
            record.CNIC = txtCNIC.Text;
            record.GuardianName = txtGuardianName.Text;
            record.HouseNumber = Convert.ToInt32( txtHouseNumber.Text);
            record.Name = txtName.Text;
            if (txtShumariyatCode.Text.Trim() != "")
            {
                record.ShumariyatCode = txtShumariyatCode.Text;
            }

            DAL.RecordDAL rdal = new DAL.RecordDAL();
            if (rdal.Save(record))
            {
                MessageBox.Show("Save");
                PleaseUpdateForm();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PleaseUpdateForm();

        }

        private void PleaseUpdateForm()
        {
            txtAddress.Clear();
            txtAge.Clear();
            txtCNIC.Clear();
            txtGuardianName.Clear();
            txtHouseNumber.Clear();
            txtName.Clear();
            txtSerialNumber.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSerialNumber_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9 || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCNIC.Text != "")
            { 
                Record record=new Record();
                record.CNIC=txtCNIC.Text;
                if (new DAL.RecordDAL().Delete(record))
                {
                    MessageBox.Show("Deleted");
                    PleaseUpdateForm();
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.SerailNumber = Convert.ToInt32(txtSerialNumber.Text);
            record.Address = txtAddress.Text;
            record.Age = Convert.ToInt32(txtAge.Text);
            record.CNIC = txtCNIC.Text;
            record.GuardianName = txtGuardianName.Text;
            record.HouseNumber = Convert.ToInt32(txtHouseNumber.Text);
            record.Name = txtName.Text;
            record.ShumariyatCode = txtShumariyatCode.Text;
            DAL.RecordDAL rdal = new DAL.RecordDAL();
            if (rdal.Update(record))
            {
                MessageBox.Show("Update");
                PleaseUpdateForm();
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            Record record = new Record();
           record.CNIC = txtCNIC.Text;
        
           
            record = new DAL.RecordDAL().GetUser(record);
            txtAddress.Text = record.Address;
            txtAge.Text = record.Age.ToString();
            txtGuardianName.Text = record.GuardianName;
            txtHouseNumber.Text = record.HouseNumber.ToString() ;
            txtName.Text = record.Name;
            txtSerialNumber.Text = record.SerailNumber.ToString() ;
            if(txtShumariyatCode.Text!=null)
            txtShumariyatCode.Text = record.ShumariyatCode.ToString();

        }

        private void rptReport_Click(object sender, EventArgs e)
        {
            DataSets.dsAll ds = new DAL.RecordDAL().FillReport();
            frmReportViewer fr = new frmReportViewer();
            Reports.rptALL rpt = new Reports.rptALL();
            rpt.SetDataSource(ds);
            fr.crystalReportViewer1.ReportSource = rpt;
            fr.Show();
        }
    }
}
