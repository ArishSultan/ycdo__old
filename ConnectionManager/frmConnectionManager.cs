using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace ConnectionManager
{
    public partial class frmConnectionManager : Form
    {
        private string datasource;
        private string DestinatinationfileName;
        private string provider;
        private string sourcefileName;
        private string startupfileName;
        private string userinfo;
        private StreamWriter writer;
        public frmConnectionManager()
        {
            InitializeComponent();
        }

        private void frmConnectionManager_Load(object sender, EventArgs e)
        {
            //code for access database
            //this.provider = "Provider=Microsoft.Jet.OLEDB.4.0;";
            //this.userinfo = "User ID=Admin;Jet OLEDB:Database Password=@@@asdf###;";
            this.startupfileName = Application.StartupPath + @"\" + "FDM.Config";
            txtUser.Hide();
            txtPassword.Hide();
            lblPassword.Hide();
            lblUserid.Hide();
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Database Files | *.mdb";
            ofd.ShowDialog();
            this.txtDBName.Text = ofd.FileName;
            if (ofd.FileName.Length > 0)
            {
                this.DestinatinationfileName = this.txtDBName.Text;
                this.datasource = "Data Source=" + this.DestinatinationfileName + ";";
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();

            //Code to connect SQL Server Database Using OledbConnection
            //"Provider=SQLOLEDB;Data Source=<servername>;Initial Catalog=<dbname>;Integrated Security=SSPI";
            this.provider = "Provider=SQLOLEDB;Data Source=" + this.txtServerName.Text + ";";
          

            if (chkUser.Checked == true)
            {
                this.userinfo = "user id="+txtUser.Text+";password="+txtPassword.Text+";";
            }
            else
            {
                this.userinfo = "Integrated Security=SSPI; ";
            }
             
            
            this.datasource = "Initial Catalog=" + this.txtDBName.Text + ";";
            
            StreamReader reader = new StreamReader(startupfileName);

            con.ConnectionString = Common.DataBasePassword.Decrypt(reader.ReadToEnd());
            reader.Close();
            try
            {
                con.Open();
                MessageBox.Show("Connection Successful", "Connected");
                con.Close();
            }
            catch (Exception ex)
            {
                con.ConnectionString = this.provider + this.datasource + this.userinfo;
                try
                {
                    con.Open();
                    MessageBox.Show("Connection Successful", "Connected");
                    con.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Connection Failed");
                }
            }
        }

        private void btnSaveConnection_Click(object sender, EventArgs e)
        {
            try
            {
                writer = new StreamWriter(this.startupfileName);
                writer.WriteLine(Common.DataBasePassword.Encrypt(this.provider + this.datasource + this.userinfo));
                writer.Close();
                MessageBox.Show("Connection Saved", "Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Connection");
            }
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //if (txtServerName.Text == "adminadmin")
            //{
            //    btnSaveConnection.Visible = true;
            //}
            //else
            //{
            //    btnSaveConnection.Visible = false;
            //}
        }

        private void chkUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUser.Checked == true)
            {
                txtUser.Show();
                txtPassword.Show();
                lblPassword.Show();
                lblUserid.Show();
            }
            else
            {
                txtUser.Hide();
                txtPassword.Hide();
                lblPassword.Hide();
                lblUserid.Hide();
            }
        }
    }
}
