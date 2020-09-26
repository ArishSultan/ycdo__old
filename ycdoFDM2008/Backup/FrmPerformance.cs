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
    public partial class FrmPerformance : Form
    {
        public FrmPerformance()
        {
            InitializeComponent();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearControls()
        {
            dtpDate.Value = DateTime.Now;
            cbxMember.Text = "";
            txtbadentries.Text = "";
            txtgoodentries.Text = "";
            txtid.Text = "";
            frm.Currentperformance = null;
            rbSelectMember.Checked = true;
            dtpDate.Focus();
        }
        private void tsNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        Performance c = new Performance();
        private void tsSave_Click(object sender, EventArgs e)
        {

        }
        SchPerformance frm = new SchPerformance();
        private void tsEdit_Click(object sender, EventArgs e)
        {

            frm.ShowDialog();
            if (frm.Currentperformance != null)
            {
                this.cbxMember.Text = frm.Currentperformance.MemberName;
                this.dtpDate.Value = frm.Currentperformance.PerformanceDate;
                this.txtgoodentries.Text = frm.Currentperformance.GoodEntries;
                this.txtbadentries.Text = frm.Currentperformance.BadEntries;
                this.txtid.Text = frm.Currentperformance.PerformanceID.ToString();
            }
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (frm.Currentperformance != null)
            {
                c.PerformanceID = frm.Currentperformance.PerformanceID;
                if (new PerformanceBLL().DeletePerformance(c) == true)
                {
                    if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                        MessageBox.Show("Performance Deleted Successfully", "Message");

                    ClearControls();
                }
                else
                    ClearControls();
            }
        }
        List<Membership> members;
        private void rbSelectMember_CheckedChanged(object sender, EventArgs e)
        {
            cbxMember.DataSource = null;
            members = new MembershipBLL().GetMembershipData();
            cbxMember.DataSource = members;
            cbxMember.DisplayMember = "MemberName";
        }
        List<Donor> donors;
        private void rbSelectDonor_CheckedChanged(object sender, EventArgs e)
        {
            cbxMember.DataSource = null;
            donors = new DonorBLL().GetDonorData();
            cbxMember.DataSource = donors;
            cbxMember.DisplayMember = "DonorName";
        }

        private void tsSave_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (cbxMember.Text.Length > 0)
                {
                    c = new Performance();
                    c.MemberName = this.cbxMember.Text.Trim();
                    c.PerformanceDate = dtpDate.Value.Date;
                    c.GoodEntries = txtgoodentries.Text.Trim();
                    c.BadEntries = txtbadentries.Text.Trim();

                    if (frm.Currentperformance != null)
                    {
                        c.PerformanceID = frm.Currentperformance.PerformanceID;
                    }
                    if (new PerformanceBLL().SavePerformance(c))
                    {
                        MessageBox.Show("Performance Saved Successfully", "Success");
                        ClearControls();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmPerformance_Load(object sender, EventArgs e)
        {
            ClearControls();
        }

    }
}
