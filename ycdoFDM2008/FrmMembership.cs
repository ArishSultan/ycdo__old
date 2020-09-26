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
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Win32;

namespace FDM
{
    public partial class FrmMembership : Form
    {
        public FrmMembership()
        {
            InitializeComponent();
        }

        private bool IsRefresh=false;
        List<Committe> LoCommitte;
        List<Counsil> LoCouncil;
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
            
            this.cbxbloodGroup.Items.Add(BloodGroup.BNegative.ToString());
            this.cbxbloodGroup.Items.Add(BloodGroup.OPositive.ToString());
        }
        private void LoadStatus()
        {
            this.cbxStatus.Items.Add(Status.Married.ToString());
            this.cbxStatus.Items.Add(Status.Single.ToString());
        
        }

        private void LoadMember()
        {
            this.cbxMembertype.Items.Add(MemberType.Honery.ToString());
            this.cbxMembertype.Items.Add(MemberType.Administrativ.ToString());
        }

        Branch br = new Branch();
        List<Branch> branchs;
        List<City> cities;
        List<Country> country;
        List<Counsil> counsil;
        List<Committe> committe;
        private void FrmMembership_Load_1(object sender, EventArgs e)
        {
            this.txtMembersshipNo.Text = new MembershipBLL().GetNextMemberShipNo().ToString("000000");
            branchs = new BranchBLL().GetBranchData();
            cbxbranches.DataSource = branchs;
            cbxbranches.DisplayMember = "BranchName";

            cities = new CityBLL().GetCity();
            cbxCities.DataSource = cities;
            cbxCities.DisplayMember = "CityName";

            country = new CountryBLL().GetCountry();
            cbxCountry.DataSource = country;
            cbxCountry.DisplayMember = "CountryName";

            counsil = new CounsilBLL().GetCounsil();
            cbxCounsil.DataSource = counsil;
            cbxCounsil.DisplayMember = "CounsilName";
            cbxCounsil.SelectedIndex = -1;

            committe = new CommitteBLL().GetCommitte();
            cbxCommitte.DataSource = committe;
            cbxCommitte.DisplayMember = "CommitteName";
            cbxCommitte.SelectedIndex = -1;


            LoadGender();
            LoadBloodGroup();
            LoadStatus();
            LoadMember();

            IsRefresh = true;
            rbselectMembers.Checked = true;
            rbselectMembers_CheckedChanged(sender, e);
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


                    memb.NIC = this.txtNIC.Text.Trim();

                   // memb.Refrence = cbxReference.SelectedItem as Membership;
                    memb.refrence = cbxReference.Text.Trim();
                    memb.Phone = this.txtPhoneNumber.Text;

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

                    DateTime colldate;
                    DateTime.TryParse(this.dtpCollectionDate.Text, out colldate);
                    memb.CollectionDate = colldate;
                    
                    memb.Adress = this.txtAdress.Text.Trim();

                    memb.CurrentDate = dtpcurrentdate.Value.Date;
                    memb.City.CityName = cbxCities.Text.Trim();

                    memb.Country.CountryName = cbxCountry.Text.Trim();
                    memb.MemberType = cbxMembertype.Text.Trim();

                    foreach (var item in cbxCounsil.CheckedItems )
                    {
                        Counsil cl = (Counsil)item;
                        memb.Counsil.Add(cl);
                    }
                    foreach (var item in cbxCommitte.CheckedItems)
                    {
                        Committe  cm = (Committe)item;
                        memb.Committe.Add(cm);
                    }

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
            dtpCollectionDate.Text = "";
            cbxCities.Text = "";
            dtpcurrentdate.Text = "";
            cbxCountry.Text = "";
            cbxMembertype.Text="";
            this.txtMembersshipNo.Text = new MembershipBLL().GetNextMemberShipNo().ToString("000000");
            for (int i = 0; i < cbxCommitte.Items.Count; i++)
            {
                cbxCommitte.SetItemChecked(i, false);
            }
            for (int i = 0; i < cbxCounsil.Items.Count; i++)
            {
                cbxCounsil.SetItemChecked(i, false);
            }
            
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            ClearControls();
            frm.CurrentMembership = null;
            this.txtMembersshipNo.Text = new MembershipBLL().GetNextMemberShipNo().ToString("000000");
        }
        SchMembership frm = new SchMembership();
        public static string strfn;
        private void tsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frm.ShowDialog();
                if (frm.CurrentMembership != null)
                {
                    ClearControls();
                    frm.CurrentMembership.Committe = new MembershipBLL().GetCommitte(frm.CurrentMembership);
                    frm.CurrentMembership.Counsil = new MembershipBLL().GetCounsils(frm.CurrentMembership);
                    txtname.Text = frm.CurrentMembership.MemberName;
                    txtfathername.Text = frm.CurrentMembership.MemberLastName;
                    txtNIC.Text = frm.CurrentMembership.NIC.ToString();
                    cbxbloodGroup.Text = frm.CurrentMembership.BloodGroup;
                    cbxGender.Text = frm.CurrentMembership.Gender;
                    txtPhoneNumber.Text = frm.CurrentMembership.Phone.ToString();
                  //  Membership mRef = members.Where(mr => mr.MembershipNo == frm.CurrentMembership.Refrence.MembershipNo).Single<Membership>();

                  //  cbxReference.Text = mRef.ToString();
                    cbxReference.Text = frm.CurrentMembership.refrence.ToString();
                    txtAdress.Text = frm.CurrentMembership.Adress;
                    txtEmaiAdress.Text = frm.CurrentMembership.Email;
                    txtMembershipFee.Text = frm.CurrentMembership.MembershipFee.ToString();
                    txtMembersshipNo.Text = frm.CurrentMembership.MembershipNo.ToString("000000");
                    cbxStatus.Text = frm.CurrentMembership.Status;
                    txtAge.Text = Convert.ToString(frm.CurrentMembership.AGE);
                    cbxbranches.Text = frm.CurrentMembership.branch.BranchName;
                    txtMonthlyFee.Text = frm.CurrentMembership.MonthlyFee.ToString();
                    dtpCollectionDate.Value = frm.CurrentMembership.CollectionDate;
                    cbxCities.Text = frm.CurrentMembership.City.CityName;
                    dtpcurrentdate.Value = frm.CurrentMembership.CurrentDate;
                    cbxCountry.Text = frm.CurrentMembership.Country.CountryName;
                    cbxMembertype.Text = frm.CurrentMembership.MemberType;
                    frm.CurrentMembership.Counsil= new CounsilBLL().GetMemberCouncil(frm.CurrentMembership);
                    //for (int i = 0; i < frm.CurrentMembership.Counsil.Count; i++)
                    //{
                    //    if (this.counsil.Contains((Counsil)frm.CurrentMembership.Counsil[i]))
                    //        cbxCounsil.SetItemChecked(i, true);
                    //}
                    //for (int i = 0; i < frm.CurrentMembership.Committe.Count; i++)
                    //{
                    //    if (this.committe.Contains((Committe)frm.CurrentMembership.Committe[i]))
                    //        cbxCommitte.SetItemChecked(i, true);
                    //}
                    int j = 0;
                    for (int i = 0; i < frm.CurrentMembership.Counsil.Count; i++)
                    {
                        if (this.counsil.Contains((Counsil)frm.CurrentMembership.Counsil[i]))
                            j = counsil.IndexOf(frm.CurrentMembership.Counsil[i]);
                        cbxCounsil.SetItemChecked(j, true);
                    }
                    int k = 0;
                    frm.CurrentMembership.Committe= new CounsilBLL().GetMemberCommitte(frm.CurrentMembership);
                    for (int i = 0; i < frm.CurrentMembership.Committe.Count; i++)
                    {
                        if (this.committe.Contains((Committe)frm.CurrentMembership.Committe[i]))
                            k = committe.IndexOf(frm.CurrentMembership.Committe[i]);
                        cbxCommitte.SetItemChecked(k, true);
                    }
                

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (frm.CurrentMembership != null)
            {
                memb.MID = frm.CurrentMembership.MID;
                if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (new MembershipBLL().DeleteMembershipData(memb) == true)
                    {

                        MessageBox.Show("Membership Deleted Successfully", "Message");

                        ClearControls();
                        frm.CurrentMembership = null;
                        this.txtMembersshipNo.Text = new MembershipBLL().GetNextMemberShipNo().ToString("000000");
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

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbselectMembers.Checked == false || rbselectDonors.Checked == false)
            {
                members = new MembershipBLL().GetMembersAndDonors();
                cbxReference.DataSource = members;
                //cbxReference.DisplayMember = "MemberName";

            
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            LoadImage();
        }
        private long m_lImageFileLength = 0;
        private byte[] m_barrImg;
        protected void LoadImage()
        {

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Jpeg|*.jpg|Bitmap|*.bmp";
                ofd.ShowDialog();
                string strFn = ofd.FileName;
                if (strFn != string.Empty)
                {
                    FileInfo fiImage = new FileInfo(strFn);
                    this.m_lImageFileLength = fiImage.Length;
                    FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                    m_barrImg = new byte[Convert.ToInt32(this.m_lImageFileLength)];
                    int iBytesRead = fs.Read(m_barrImg, 0, Convert.ToInt32(this.m_lImageFileLength));
                    fs.Close();
                }
                else
                    m_barrImg = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnLoadImage_Click(object sender, EventArgs e)
        {
            
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cbxCounsil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCollectionDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        
           
        
             
    
        

    }
}
