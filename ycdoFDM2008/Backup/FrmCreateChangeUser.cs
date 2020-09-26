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
    public partial class FrmCreateChangeUser : Form
    {
        public FrmCreateChangeUser()
        {
            InitializeComponent();
        }

        UserBLL usercontrol;
        User user;
        private void Delete()
        {
            try
            {
                if ((this.user != null) && this.usercontrol.DeleteUser(this.user))
                {
                    this.user = null;
                    MessageBox.Show("User deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.txtUserName.Text = "";
                    this.txtOldPassword.Text = "";
                    this.txtPassword.Text = "";
                    this.txtRetypePassword.Text = "";
                    this.txtOldPassword.Visible = false;
                    this.chkAdmin.Checked = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Delete");
            }
        }
        private void Save()
        {
            try
            {
                if (this.txtUserName.Text.Trim() == "")
                {
                    MessageBox.Show("User Name not valid ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtUserName.Focus();
                }
                else if (this.txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Password not valid ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtPassword.Focus();
                }
                else if (this.txtRetypePassword.Text.Trim() == "")
                {
                    MessageBox.Show("ReType Password not valid ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtRetypePassword.Focus();
                }
                else if (this.txtRetypePassword.Text.Trim() != this.txtPassword.Text.Trim())
                {
                    MessageBox.Show("Password and Retype Password does not match ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtPassword.Focus();
                }
                else
                {
                    if (this.txtOldPassword.Visible)
                    {
                        if (this.txtOldPassword.Text == "")
                        {
                            MessageBox.Show(" Old Password is invalid ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.txtOldPassword.Focus();
                            return;
                        }
                        if (this.user.UserPassword != this.txtOldPassword.Text.Trim())
                        {
                            MessageBox.Show(" Old Password is invalid ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.txtOldPassword.Focus();
                            return;
                        }
                    }
                    if (((this.txtUserName.Text != "") && (this.txtPassword.Text != "")) && (this.txtRetypePassword.Text != ""))
                    {
                        if (!this.txtOldPassword.Visible)
                        {
                            if (this.usercontrol.SaveUser(new User(this.txtUserName.Text.Trim(), this.txtPassword.Text.Trim(), this.chkAdmin.Checked)))
                            {
                                this.txtPassword.Text = "";
                                this.txtRetypePassword.Text = "";
                                this.txtUserName.Text = "";
                                this.chkAdmin.Checked = false;
                                MessageBox.Show("User saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                        else if (this.usercontrol.EditUser(new User(this.user.Userno, this.txtUserName.Text.Trim(), this.txtPassword.Text.Trim(), this.chkAdmin.Checked)))
                        {
                            this.user = null;
                            this.txtUserName.Text = "";
                            this.txtOldPassword.Text = "";
                            this.txtPassword.Text = "";
                            this.txtRetypePassword.Text = "";
                            this.txtOldPassword.Visible = false;
                            this.lblOldPassword.Visible = false;
                            this.chkAdmin.Checked = false;
                            MessageBox.Show("User updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Save");
            }
        }

        private void Search()
        {
            try
            {
                FrmSearchUser user = new FrmSearchUser();
                user.ShowDialog();
                if (user.user != null)
                {
                    this.txtUserName.Text = user.user.UserName;
                    this.txtOldPassword.Visible = true;
                    this.lblOldPassword.Visible = true;
                    this.txtOldPassword.Focus();
                    this.user = user.user;
                    this.chkAdmin.Checked = this.user.IsAdmin;
                }
                else
                {
                    this.txtOldPassword.Visible = false;
                    this.lblOldPassword.Visible = false;
                    this.chkAdmin.Checked = false;
                    this.user = null;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Search");
            }
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void tsSearch_Click(object sender, EventArgs e)
        {
            this.Search();
        }

        private void txtOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtRetypePassword.Focus();
            }
        }

        private void txtRetypePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.chkAdmin.Focus();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txtOldPassword.Visible)
                {
                    this.txtOldPassword.Focus();
                }
                else
                {
                    this.txtPassword.Focus();
                }
            }
        }


        private void chkAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtUserName.Focus();
        }


        private void FrmCreateChangeUser_Load(object sender, EventArgs e)
        {
            usercontrol = new UserBLL();
        }

    }
}
