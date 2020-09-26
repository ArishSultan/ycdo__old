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
    public partial class FrmBranches : Form
    {
        public FrmBranches()
        {
            InitializeComponent();
        }
        Branch br = new Branch();
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (txtBranchCode.Text.Length > 0)
                {
                int BRcode;
                int.TryParse(txtBranchCode.Text, out BRcode);
                br.BranchCode = BRcode;

                br.BranchName = this.txtBranchName.Text.Trim();
                
                int phone;
                int.TryParse(txtPhone.Text,out phone);
                br.Phone = phone;

                br.BranchAdress = this.txtadress.Text.Trim();
                br.City.CityName = this.cbxCity.Text.Trim();
                if (rbActive.Checked)
                    br.IsActive = true;
                else
                    br.IsActive = false;

                if (frm.CurrentBranch != null)
                {
                    br.BranchID = frm.CurrentBranch.BranchID;
                }
                    if (new BranchBLL().SaveBranch(br))
                {
                    MessageBox.Show("Branches Saved Successfully","Message");
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
            this.txtBranchCode.Text = "";
            this.txtBranchName.Text = "";
            this.txtPhone.Text = "";
            this.txtadress.Text = "";
            this.cbxCity.Text = "";
            this.cbxCity.Text = "";
            txtid.Text = "";
            rbInactive.Checked = true;
            frm.CurrentBranch = null;
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        SchBranch frm = new SchBranch();
        private void tsEdit_Click(object sender, EventArgs e)
        {
            
            frm.ShowDialog();
            if (frm.CurrentBranch != null)
            {
                this.txtBranchCode.Text = frm.CurrentBranch.BranchCode.ToString();
                this.txtBranchName.Text = frm.CurrentBranch.BranchName;
                this.txtPhone.Text = frm.CurrentBranch.Phone.ToString();
                this.txtadress.Text = frm.CurrentBranch.BranchAdress;
                this.cbxCity.Text = frm.CurrentBranch.City.CityName;
                this.txtid.Text = frm.CurrentBranch.BranchID.ToString();
                if (frm.CurrentBranch.IsActive == true)
                    this.rbActive.Checked = true;
                else
                    rbInactive.Checked = true;
            }

        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (frm.CurrentBranch != null)
               
            {
                br.BranchID = frm.CurrentBranch.BranchID;
                if (new BranchBLL().DeleteBranch(br)==true)
                {
                    if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                        MessageBox.Show("Branch Deleted Successfully", "Message");

                    ClearControls();
                }
                else
                    ClearControls();
            }
        }
       
        List<City> cities;
        private void FrmBranches_Load(object sender, EventArgs e)
        {
            
          
            cities = new CityBLL().GetCity();
            cbxCity.DataSource = cities;
            cbxCity.DisplayMember = "CityName";
            ClearControls();

        }

       

       
        }
      
    }

