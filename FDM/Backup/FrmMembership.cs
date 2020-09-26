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
    public partial class FrmMembership : Form
    {
        public FrmMembership()
        {
            InitializeComponent();
        }

        private bool IsRefresh=false;

        Membership memb = new Membership();
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   


        private void LoadGender()
        {
            this.cbxGender.Items.Add( Gender.Female.ToString());
            this.cbxGender.Items.Add( Gender.Male.ToString());
        }

        private void LoadBloodGroup()
        {
            this.cbxbloodGroup.Items.Add ( BloodGroup.APositive.ToString());
            this.cbxbloodGroup.Items.Add(BloodGroup.ANegative.ToString());
            this.cbxbloodGroup.Items.Add ( BloodGroup.BPositive.ToString());
            this.cbxbloodGroup.Items.Add ( BloodGroup.OPositive.ToString());
        }
        private void LoadStatus()
        {
            this.cbxStatus.Items.Add(Status.Married.ToString());
            this.cbxStatus.Items.Add(Status.Single.ToString());
        
        }

        Branch br = new Branch();
        List<Branch> branchs;
        List<City> cities;
        private void FrmMembership_Load_1(object sender, EventArgs e)
        {



            branchs = new BranchBLL().GetBranchData();
            cbxbranches.DataSource = branchs;
            cbxbranches.DisplayMember = "BranchName";

            cities = new CityBLL().GetCity();
            cbxCities.DataSource = cities;
            cbxCities.DisplayMember = "CityName";


            LoadGender();
            LoadBloodGroup();
            LoadStatus();

            rbselectMembers.Checked=true;

            IsRefresh = true;
          //  SelectReference();
        }

        private void tsSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text.Length > 0)
                {
                    memb = new Membership();
                    memb.branch.BranchName = this.cbxbranches.Text.Trim();
                    memb.MemberName = this.txtname.Text.Trim();
                    memb.MemberLastName = this.txtfathername.Text.Trim();




                    Decimal age;
                    Decimal.TryParse(this.txtAge.Text, out age);
                    memb.AGE = age;


                    memb.Gender = this.cbxGender.Text.Trim();

                    Decimal NicNo;
                    Decimal.TryParse(this.txtNIC.Text, out NicNo);
                    memb.NIC = NicNo;

                  

                    memb.Refrence = cbxReference.Text.Trim();

                    Decimal phon;
                    Decimal.TryParse(this.txtPhoneNumber.Text, out phon);
                    memb.Phone = phon;

                    memb.Email = this.txtEmaiAdress.Text.Trim();
                    memb.BloodGroup = this.cbxbloodGroup.Text.Trim();

                    Decimal memFee;
                    Decimal.TryParse(this.txtMembershipFee.Text, out memFee);
                    memb.MembershipFee = memFee;

                    Decimal memno;
                    Decimal.TryParse(this.txtMembersshipNo.Text, out memno);
                    memb.MembershipNo = memno;

                    memb.Status = this.cbxStatus.Text.Trim();

                    Decimal monthFee;
                    Decimal.TryParse(this.txtMonthlyFee.Text, out monthFee);
                    memb.MonthlyFee = monthFee;

                    Decimal colldate;
                    Decimal.TryParse(this.txtCollectionDate.Text, out colldate);
                    memb.CollectionDate = colldate;
                    
                    memb.Adress = this.txtAdress.Text.Trim();

                    memb.CurrentDate = dtpcurrentdate.Value.Date;
                    memb.City.CityName = cbxCities.Text.Trim();

                    if (frm.CurrentMembership != null)
                    {
                        memb.MID = frm.CurrentMembership.MID;
                    }
                    if (new MembershipBLL().SaveMembersData(memb))
                    {
                        MessageBox.Show("Membership Saved Successfully", "Success");
                        ClearControls();

                    }
                    
                        

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ClearControls()
        {
            txtname.Text = "";
            txtfathername.Text = "";
            txtNIC.Text = "";
            cbxbloodGroup.Text = "";
            cbxGender.Text = "";
            txtPhoneNumber.Text = "";
            cbxReference.Text = "";
            txtAdress.Text = "";
            txtEmaiAdress.Text = "";
            txtMembershipFee.Text = "";
            txtMembersshipNo.Text = "";
            cbxStatus.Text = "";
            txtAge.Text = "";
            cbxbranches.Text = "";
            txtMonthlyFee.Text = "";
            txtCollectionDate.Text = "";
            cbxCities.Text = "";
            dtpcurrentdate.Text = "";
            frm.CurrentMembership = null;
           
        
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        SchMembership frm = new SchMembership();
        private void tsEdit_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            if (frm.CurrentMembership != null)
            {
                txtname.Text = frm.CurrentMembership.MemberName;
                txtfathername.Text = frm.CurrentMembership.MemberLastName;
                txtNIC.Text = frm.CurrentMembership.NIC .ToString();
                cbxbloodGroup.Text = frm.CurrentMembership.BloodGroup;
                cbxGender.Text = frm.CurrentMembership.Gender;
                txtPhoneNumber.Text = frm.CurrentMembership.Phone.ToString();
                cbxReference.Text = frm.CurrentMembership.Refrence;
                txtAdress.Text = frm.CurrentMembership.Adress;
                txtEmaiAdress.Text = frm.CurrentMembership.Email;
                txtMembershipFee.Text = frm.CurrentMembership.MembershipFee.ToString();
                txtMembersshipNo.Text = frm.CurrentMembership.MembershipNo.ToString();
                cbxStatus.Text = frm.CurrentMembership.Status;
                txtAge.Text = frm.CurrentMembership.AGE.ToString();
                cbxbranches.Text = frm.CurrentMembership.branch.BranchName;
                txtMonthlyFee.Text = frm.CurrentMembership.MonthlyFee.ToString();
                txtCollectionDate.Text = frm.CurrentMembership.CollectionDate.ToString();
                cbxCities.Text = frm.CurrentMembership.City.CityName;
                dtpcurrentdate.Text = frm.CurrentMembership.CurrentDate.ToString();
                
            }

        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (frm.CurrentMembership != null)
            {
                memb.MID = frm.CurrentMembership.MID;
                if (new MembershipBLL().DeleteMembershipData(memb) == true)
                {
                    if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                        MessageBox.Show("Membership Deleted Successfully", "Message");

                    ClearControls();
                }
                else
                    ClearControls();
            }
        }
        List<Membership> members;
        List<Donor> doners;
        private void rbselectMembers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbselectDonors.Checked== false)
            {

                members = new MembershipBLL().GetMembershipData();
                cbxReference.DataSource = members;
                cbxReference.DisplayMember = "MemberName";
              
            }
        }

        private void rbselectDonors_CheckedChanged(object sender, EventArgs e)
        {
            if (rbselectMembers.Checked== false)
            {
                doners = new DonorBLL().GetDonorData();
                cbxReference.DataSource = doners;
                cbxReference.DisplayMember = "DonorName";

            }
        }

        

    }
}
