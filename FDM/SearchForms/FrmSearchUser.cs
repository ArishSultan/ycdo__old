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
    public partial class FrmSearchUser : Form
    {
        public FrmSearchUser()
        {
            InitializeComponent();
        }
        List<User> users;
        UserBLL usercontroller;
        public User user;
        private void FrmSearchUser_Load(object sender, EventArgs e)
        {
            try
            {
                this.usercontroller = new UserBLL();
                this.users = this.usercontroller.GetUsers();
                this.Grd.DataSource = this.users;
                Grd.Columns["UserName"].Width = 160;
                Grd.Columns["UserNo"].Width = 160;
                if (this.Grd.Rows.Count > 0)
                {
                    this.Grd.CurrentCell = this.Grd[0, 0];
                }
                this.Grd.Columns["userpassword"].Visible = false;
                this.Grd.Columns["isadmin"].Visible = false;
                this.Grd.Columns["islogin"].Visible = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "FrmSearchUser_Load");
            }
         
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsSelect_Click(object sender, EventArgs e)
        {
            try
            {
                this.user = this.users[this.Grd.CurrentRow.Index];
                base.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "tsSelect_Click");
            }
        }
    }
}
