using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using Common.Enum;
using BLL;
using FDM.SearchForms;

namespace FDM
{
    public partial class FrmDonationCollectionForm : Form
    {
        public FrmDonationCollectionForm()
        {
            InitializeComponent();
        }


        DonorCollection DC;

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearControll()
        {
            dtpCollectionDate.Value = DateTime.Now.Date;
            cbxName.SelectedIndex = -1;
            txtCollectionfee.Text = "";
            txtID.Text = "";
            frm.CurrentCollection = null;
            //cbxDonationtype.Visible = false;
            txtOtherDonation.Visible = false;
            lblotherDonation.Visible = false;
            txtCheckDetails.Visible = false;
            lblCheckDetails.Visible = false;

            txtReciptNo.Text = "";
            txtOtherDonation.Text = "";
            cbxDonationtype.Text = "";

            cbxDonationtype.SelectedIndex = -1;
            txtCheckDetails.Text = "";
            
            dtpCollectionDate.Focus();

        }
        List<Membership> members;
        private void rbmembers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbdonor.Checked == false)
            {


                members = new MembershipBLL().GetMembershipData();
                cbxName.DataSource = members;
                cbxName.DisplayMember = "MemberName";
                ClearControll();
            }
        }
        List<Donor> donors;
        private void rbdonor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmembers.Checked == false)
            {
                donors = new DonorBLL().GetDonorData();
                cbxName.DataSource = donors;
                cbxName.DisplayMember = "DonorName";
                ClearControll();
            }
        }
         List<Membership> memberss;
        private void cbxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Membership mem = new Membership();
            if (rbmembers.Checked == true)
                mem.MemberName = cbxName.Text.Trim();
            else
            {
                mem.Donor.DonorName = cbxName.Text.Trim();
            }
            memberss = new DonorBLL().GetFee(mem, rbdonor.Checked, rbmembers.Checked);
            if (memberss.Count > 0)
            {
                if (rbmembers.Checked==true)
                txtCollectionfee.Text = Convert.ToString(memberss[0].MonthlyFee);
                else
                    txtCollectionfee.Text = Convert.ToString(memberss[0].Donor.DonorFee);
            }
            }

        private void tsSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void Save()
        {
            try
            {
                DC = new DonorCollection();
                DC.CollectionDate = dtpCollectionDate.Value.Date;
                DC.DonorName = cbxName.Text.Trim();
                Decimal colfee;
                Decimal.TryParse(this.txtCollectionfee.Text, out colfee);

                DC.CollectionFee = colfee;

                Decimal recno;
                Decimal.TryParse(this.txtReciptNo.Text, out recno);

                DC.ReciptNo = recno;


                Decimal chkdetail;
                Decimal.TryParse(this.txtCheckDetails.Text, out chkdetail);

                DC.CheckDetail = chkdetail;


                DC.DonationType = cbxDonationtype.Text.Trim();
                DC.Others = txtOtherDonation.Text.Trim();

                if (frm.CurrentCollection != null)
                {
                    DC.ID = frm.CurrentCollection.ID;
                }

                if (new DonorBLL().SaveDonorCollection(DC))
                {
                    MessageBox.Show("Donor Collection Saved Successfully");
                }
                ClearControll();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        SchDonorCollection frm = new SchDonorCollection();
        private void tsEdit_Click(object sender, EventArgs e)
        {
            ClearControll();
            try
            {
                frm.ShowDialog();
                if (frm.CurrentCollection != null)
                {
                    
                    
                    if (frm.CurrentCollection.CheckDetail != 0 && frm.CurrentCollection.DonationType != null)
                    {
                        txtOtherDonation.Visible = false;
                        lblotherDonation.Visible = false;
                        txtCheckDetails.Visible = true;
                        lblCheckDetails.Visible = true;
                        rbCheck.Checked = true;
                        txtCheckDetails.Text = frm.CurrentCollection.CheckDetail.ToString();
                     //   cbxDonationtype.Visible = true;
                    }
                    else if (frm.CurrentCollection.Others != "" && frm.CurrentCollection.Others != null)
                    {
                     //   cbxDonationtype.Visible = false;
                        txtOtherDonation.Visible = true;
                        lblotherDonation.Visible = true;
                        txtCheckDetails.Visible = false;
                        lblCheckDetails.Visible = false;

                        rbOther.Checked = true;
                        txtOtherDonation.Text = frm.CurrentCollection.Others;
                    }
                    
                    txtID.Text = frm.CurrentCollection.ID.ToString();
                    dtpCollectionDate.Value = frm.CurrentCollection.CollectionDate;
                    cbxName.Text = frm.CurrentCollection.DonorName;
                    txtCollectionfee.Text = frm.CurrentCollection.CollectionFee.ToString();
                    txtReciptNo.Text = frm.CurrentCollection.ReciptNo.ToString();
                    
                    cbxDonationtype.Text = frm.CurrentCollection.DonationType;
                    
                }
            }
            catch (Exception ex)
            {
                
                throw ex; 
            }
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
            if (frm.CurrentCollection != null)
            {
                DC = new DonorCollection();
                DC.ID=frm.CurrentCollection.ID;
                if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (new DonorBLL().DeleteDonorCollection(DC) == true)
                    {

                        MessageBox.Show("Donor Collection Deleted Successfully", "Message");

                        ClearControll();
                    }
                    else
                        ClearControll();
                }
            }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            try
            {
                ClearControll();
            }
            catch (Exception ex)
            {
                
                throw ex; 
            }
        }

        private void rbCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCash.Checked == false && rbOther.Checked == false)
            {
               // cbxDonationtype.Visible = true;
                txtOtherDonation.Visible = false;
                lblotherDonation.Visible = false;
                txtCheckDetails.Visible = true;
                lblCheckDetails.Visible = true;
                cbxDonationtype.Items.Clear();

                //this.cbxDonationtype.Items.Add("Simple Donation".ToString());
               
                //this.cbxDonationtype.Items.Add("Zakat".ToString());
             
                //this.cbxDonationtype.Items.Add("Sadkat".ToString());

                this.cbxDonationtype.Items.Add(FundsType.SimpleDonation);
                this.cbxDonationtype.Items.Add(FundsType.Monthly);
                this.cbxDonationtype.Items.Add(FundsType.Zakat);
                this.cbxDonationtype.Items.Add(FundsType.Sadkat);
                this.cbxDonationtype.Items.Add(FundsType.Kharat);
                this.cbxDonationtype.Items.Add(FundsType.Others);

            }
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCheck.Checked == false && rbOther.Checked == false)
            {
               // cbxDonationtype.Visible = true;
                txtOtherDonation.Visible = false;
                lblotherDonation.Visible = false;
                txtCheckDetails.Visible = false;
                lblCheckDetails.Visible = false;

                cbxDonationtype.Items.Clear();
                //this.cbxDonationtype.Items.Add("Simple Donation".ToString());
                //this.cbxDonationtype.Items.Add("Zakat".ToString());
                //this.cbxDonationtype.Items.Add("Sadkat".ToString());
                this.cbxDonationtype.Items.Add(FundsType.SimpleDonation);
                this.cbxDonationtype.Items.Add(FundsType.Monthly);
                this.cbxDonationtype.Items.Add(FundsType.Zakat);
                this.cbxDonationtype.Items.Add(FundsType.Sadkat);
                this.cbxDonationtype.Items.Add(FundsType.Kharat);
                this.cbxDonationtype.Items.Add(FundsType.Others);
            }
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCash.Checked == false && rbCash.Checked == false)
            {
            //  cbxDonationtype.Visible = false;
                txtOtherDonation.Visible = true;
                lblotherDonation.Visible = true;
                txtCheckDetails.Visible = false;
                lblCheckDetails.Visible = false;
            }
        }

        private void FrmDonationCollectionForm_Load(object sender, EventArgs e)
        {
         // cbxDonationtype.Visible = false;
            txtOtherDonation.Visible = false;
            lblotherDonation.Visible = false;
            rbmembers.Checked = true;
            rbCash.Checked = true;

        }

      

       

        }
    }

