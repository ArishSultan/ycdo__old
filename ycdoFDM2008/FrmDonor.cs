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
    public partial class FrmDonor : Form
    {
        public FrmDonor()
        {
            InitializeComponent();
        }

        Donor memb = new Donor();
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void LoadGender()
        {
            this.cbxGender.Items.Add(Gender.Female.ToString());
            this.cbxGender.Items.Add(Gender.Male.ToString());
        }

        private void LoadBloodGroup()
        {
            this.cbxbloodGroup.Items.Add(BloodGroup.APositive.ToString());
            this.cbxbloodGroup.Items.Add(BloodGroup.ANegative.ToString());
            this.cbxbloodGroup.Items.Add(BloodGroup.BPositive.ToString());
            this.cbxbloodGroup.Items.Add(BloodGroup.OPositive.ToString());
        }
        private void LoadStatus()
        {
            this.cbxStatus.Items.Add(Status.Married.ToString());
            this.cbxStatus.Items.Add(Status.Single.ToString());

        }

        private void LoadFundTypes()
        {
            this.cbxFundType.Items.Add(FundsType.SimpleDonation.ToString());
            this.cbxFundType.Items.Add(FundsType.Monthly.ToString());
            this.cbxFundType.Items.Add(FundsType.Zakat.ToString());
            this.cbxFundType.Items.Add(FundsType.Kharat.ToString());
            this.cbxFundType.Items.Add(FundsType.Sadkat.ToString());
            this.cbxFundType.Items.Add(FundsType.Others.ToString());
        }


        Branch br = new Branch();
        List<Branch> branchs;
        List<City> cities;
        List<Country> country;
        private void FrmMembership_Load_1(object sender, EventArgs e)
        {

            branchs = new BranchBLL().GetBranchData();
            cbxbranches.DataSource = branchs;
            cbxbranches.DisplayMember = "BranchName";

            cities = new CityBLL().GetCity();
            cbxCities.DataSource = cities;
            cbxCities.DisplayMember = "CityName";

            country = new CountryBLL().GetCountry();
            cbxCountry.DataSource = country;
            cbxCountry.DisplayMember = "CountryName";


            LoadGender();
            LoadBloodGroup();
            LoadStatus();
            LoadFundTypes();

            rbselectMembers.Checked = true;
        }

        private void tsSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text.Length > 0)
                {
                    memb = new Donor();
                    memb.branch.BranchName = this.cbxbranches.Text.Trim();
                    memb.DonorName = this.txtname.Text.Trim();
                    memb.DonorLastName = this.txtfathername.Text.Trim();




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
                    memb.DonorFee = memFee;

                    Decimal memno;
                    Decimal.TryParse(this.txtMembersshipNo.Text, out memno);
                    memb.DonorNo = memno;

                    memb.Status = this.cbxStatus.Text.Trim();

                    memb.FundType = this.cbxFundType.Text.Trim();

                   DateTime colldate;
                    DateTime.TryParse(this.dtpCollectionDate.Text, out colldate);
                    memb.CollectionDate = colldate;

                    memb.Adress = this.txtAdress.Text.Trim();

                    memb.City.CityName = this.cbxCities.Text.Trim();

                    memb.CurrentDate = dtpCurrentDate.Value.Date;

                    if (frm.CurrentDonor != null)
                    {
                        memb.MID = frm.CurrentDonor.MID;
                    }
                    if (new DonorBLL().SaveDonorData(memb))
                    {
                        MessageBox.Show("Donor Saved Successfully", "Success");
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
            cbxFundType.Text = "";
            dtpCollectionDate.Text = "";
            cbxCities.Text = "";
            dtpCurrentDate.Text = "";
            frm.CurrentDonor = null;


        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        SchDonor frm = new SchDonor();
        private void tsEdit_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            if (frm.CurrentDonor != null)
            {
                txtname.Text = frm.CurrentDonor.DonorName;
                txtfathername.Text = frm.CurrentDonor.DonorLastName;
                txtNIC.Text = frm.CurrentDonor.NIC.ToString();
                cbxbloodGroup.Text = frm.CurrentDonor.BloodGroup;
                cbxGender.Text = frm.CurrentDonor.Gender;
                txtPhoneNumber.Text = frm.CurrentDonor.Phone.ToString();
                cbxReference.Text = frm.CurrentDonor.Refrence;
                txtAdress.Text = frm.CurrentDonor.Adress;
                txtEmaiAdress.Text = frm.CurrentDonor.Email;
                txtMembershipFee.Text = frm.CurrentDonor.DonorFee.ToString();
                txtMembersshipNo.Text = frm.CurrentDonor.DonorNo.ToString("000000");
                cbxStatus.Text = frm.CurrentDonor.Status;
                txtAge.Text = frm.CurrentDonor.AGE.ToString();
                cbxbranches.Text = frm.CurrentDonor.branch.BranchName;
                cbxFundType.Text = frm.CurrentDonor.FundType;
                dtpCollectionDate.Text = frm.CurrentDonor.CollectionDate.ToString();
                cbxCities.Text = frm.CurrentDonor.City.CityName;
                dtpCurrentDate.Text = frm.CurrentDonor.CurrentDate.ToString();
           
            }

        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (frm.CurrentDonor != null)
            {
                memb.MID = frm.CurrentDonor.MID;
                if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (new DonorBLL().DeleteDonorData(memb) == true)
                    {

                        MessageBox.Show("Donor Deleted Successfully", "Message");

                        ClearControls();
                    }
                }
                else
                ClearControls();
            }
        }

        List<Membership> members;
        List<Donor> doners;

        private void rbselectMembers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbselectDonors.Checked == false)
            {

                members = new MembershipBLL().GetMembershipData();
                cbxReference.DataSource = members;
                cbxReference.DisplayMember = "MemberName";

            }
        }

        private void rbselectDonors_CheckedChanged(object sender, EventArgs e)
        {
            if (rbselectMembers.Checked == false)
            {
                doners = new DonorBLL().GetDonorData();
                cbxReference.DataSource = doners;
                cbxReference.DisplayMember = "DonorName";

            }
        }

      

      
        

    }
}
