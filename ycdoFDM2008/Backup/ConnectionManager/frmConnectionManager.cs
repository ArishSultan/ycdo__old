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
            this.provider = "Provider=Microsoft.Jet.OLEDB.4.0;";
            this.userinfo = "User ID=Admin;Jet OLEDB:Database Password=pw;";
            this.startupfileName = Application.StartupPath + @"\" + "FDM.Config";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Database Files | *.mdb";
            ofd.ShowDialog();
            this.txtFilePath.Text = ofd.FileName;
            if (ofd.FileName.Length > 0)
            {
                this.DestinatinationfileName = this.txtFilePath.Text;
                this.datasource = "Data Source=" + this.DestinatinationfileName + ";";
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = this.provider + this.datasource + this.userinfo;

            try
            {
                con.Open();
                MessageBox.Show("Connection Successful", "Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Failed");
            }
        }

        private void btnSaveConnection_Click(object sender, EventArgs e)
        {
            try
            {
                writer = new StreamWriter(this.startupfileName);
                writer.WriteLine(this.provider + this.datasource + this.userinfo);
                writer.Close();
                MessageBox.Show("Connection Saved", "Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Connection");
            }
            
        }
    }
}
