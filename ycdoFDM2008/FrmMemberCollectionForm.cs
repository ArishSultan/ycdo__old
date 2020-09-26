using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FDM.SearchForms;
using Common;
using BLL;

namespace FDM
{
    public partial class FrmMemberCollectionForm : Form
    {
        public FrmMemberCollectionForm()
        {
            InitializeComponent();
        }

        MemberCollection mc;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            ClearControll();
        }
        public void ClearControll() 
        {
            dtpCurrentDate.Value = DateTime.Now.Date;
            cbxmemberName.SelectedIndex = -1;
            txtCollection.Text = "";
            txtReciptNo.Text = "";
            frm.CurrentCollection = null;
        }
        List<Membership> memberss;
        private void cbxmemberName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemberCollection mem = new MemberCollection();
            mem.MemberName = cbxmemberName.Text.Trim();
            memberss = new MembershipBLL().GetMembersCollection(mem);
            if (memberss.Count > 0)
            {
                txtCollection.Text = Convert.ToString(memberss[0].MonthlyFee);
            }
            }
        List<Membership> members;
        private void FrmMemberCollectionForm_Load(object sender, EventArgs e)
        {
            members = new MembershipBLL().GetMembershipData();
            cbxmemberName.DataSource = members;
            cbxmemberName.DisplayMember = "MemberName";
            ClearControll();
        }

        public void SaveMemberCollection()
        {
            try
            {
                mc = new MemberCollection();
                mc.Member = (Membership)this.cbxmemberName.SelectedItem;
                
                mc.CollectionDate = dtpCurrentDate.Value.Date;
                mc.MemberName = cbxmemberName.Text.Trim();
                Decimal colfee;
                Decimal.TryParse(this.txtCollection.Text, out colfee);
                mc.CollectionFee = colfee;
                mc.CollectionMonth = this.dtMonths.Value.ToString("MMM-yyyy");
               
                Decimal recno;
                Decimal.TryParse(this.txtReciptNo.Text, out recno);
                mc.ReciptNo = recno;
                
                if (frm.CurrentCollection != null)
                {
                    mc.ID = frm.CurrentCollection.ID;
                }

                if (new MembershipBLL().SaveMembershipCollection(mc))
                {
                    MessageBox.Show("Member Collection Saved Successfully");
                
                }
                ClearControll();
            }
            catch (Exception ex)
            {

                throw ex ;
            }
           
        
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            SaveMemberCollection();
        }
        SchMemberCollection frm = new SchMemberCollection();
        private void tsEdit_Click(object sender, EventArgs e)
        {
          //  ClearControll();
            frm.ShowDialog();
            if (frm.CurrentCollection != null)
            {
                txtID.Text = frm.CurrentCollection.ID.ToString();
                dtpCurrentDate.Value = frm.CurrentCollection.CollectionDate;
                cbxmemberName.Text = frm.CurrentCollection.MemberName;
                txtCollection.Text = frm.CurrentCollection.CollectionFee.ToString();
                txtReciptNo.Text = frm.CurrentCollection.ReciptNo.ToString();
            }
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (frm.CurrentCollection != null)
            {
                mc = new MemberCollection();
                mc.ID=frm.CurrentCollection.ID;
                if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (new MembershipBLL().DeleteMemberCollection(mc) == true)
                    {

                        MessageBox.Show("Member Collection Deleted Successfully", "Message");

                        ClearControll();
                    }
                    else
                        ClearControll();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btnADDMonth_Click(object sender, EventArgs e)
        {
        }

    }
}
