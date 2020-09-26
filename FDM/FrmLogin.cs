using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
namespace FDM
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        UserBLL userBLL;
        public User IsLoginUser;
        List<User> users;
        ProjectDetail prj;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.userBLL = new UserBLL();
                this.users = this.userBLL.GetUsers();
                this.cbxLogin.DataSource = this.users;
                this.cbxLogin.DisplayMember = "username";
                this.cbxLogin.ValueMember = "userno";
                this.prj = new ProjectDetail();
                this.Text = this.Text + " " + this.prj.ProjectName;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "FrmLogin_Load");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try { 

            User user = new User(this.cbxLogin.Text, this.txtpassword.Text);
            if (this.userBLL.VerifyUser(user))
            {
                user = this.users[this.users.IndexOf(user)];
                this.Visible = false;
                    FrmWait wait = new FrmWait();
            wait.IsLoginUser = user;
            wait.Show();
                    this.Close();
                    Application.Exit();
            }
            else
            {
                MessageBox.Show("Invalid password ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "btnLogin_Click");
            }
        }
    }
}
