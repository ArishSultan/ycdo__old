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
namespace FDM
{
    public partial class FrmUserRight : Form
    {
        public FrmUserRight()
        {
            InitializeComponent();
        }
          User user;
        List<UserRight> uRights;
        List<User> users;
        UserBLL uBll;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUserRight_Load(object sender, EventArgs e)
        {
            uRights = new List<UserRight>();
            users = new List<User>();
            uBll = new UserBLL();
            users = uBll.GetUsers();
            cbxUsers.DataSource = users;
            cbxUsers.DisplayMember = "UserName";
            cbxUsers.ValueMember = "Userno"; 
            
        }
        private void FormatGrid()
        {
            for (int i = 0; i < this.GrdMain.Columns.Count; i++)
            {

                if (this.GrdMain.Columns[i].Name.ToUpper() == "RightId".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "User".ToUpper())
                {
                    this.GrdMain.Columns[i].Visible = false;
                }
                //if (this.GrdMain.Columns[i].Name.ToUpper() == "LabTestId".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "General".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "YCDO".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "Poor".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "Deserving".ToUpper())
                //{
                //    DataGridViewColumn column1 = this.GrdMain.Columns[i];
                //    column1.Width = 50;

                //}
                //if (this.GrdMain.Columns[i].Name.ToUpper() == "Report".ToUpper())// || this.GrdMain.Columns[i].Name.ToUpper() == "General".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "YCDO".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "Poor".ToUpper() || this.GrdMain.Columns[i].Name.ToUpper() == "Deserving".ToUpper())
                //{
                //    DataGridViewColumn column1 = this.GrdMain.Columns[i];
                //    column1.Width = 120;

                //}

            }
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (GrdMain.Rows.Count > 0)
                {
                    cbxUsers.Focus();
                    //GrdMain.CurrentCell = GrdMain[2, 1];
                    //GrdMain.CurrentCell = GrdMain[2, 0];
                    if (uRights.Count > 0)
                    {
                        uRights[0].User.Userno = user.Userno ;
                        if (uBll.SaveUserRights(uRights) == true)
                        {
                            MessageBox.Show("Record saved successfully.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void cbxUsers_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUsers.SelectedValue != null)
            {
                User  id = cbxUsers.SelectedValue as   User ;
                if (id == null)
                    user = new User((int)cbxUsers.SelectedValue);
                else
                    user = id;
                uRights = new List<UserRight>();
                uRights = uBll.GetUserRights(user);
                GrdMain.DataSource = null;
                GrdMain.DataSource = uRights;
                FormatGrid();
            }
        }
    }
}
