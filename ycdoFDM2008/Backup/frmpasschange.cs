using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Common;
using DAL;
using BLL;
using OleDbHelper;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FDM
{
    public partial class frmpasschange : Form
    {
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbTransaction tran;
        
        public frmpasschange()
        {
            InitializeComponent();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmpasschange_Load(object sender, EventArgs e)
        {
            RoomBLL rbll = new RoomBLL();
            List<Room> rooms = rbll.GetRooms();
            this.cbxDocs.DataSource = rooms;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Select = "Update DC set Password = '" + txtPass.Text + "' where ID ="+Convert.ToInt32(cbxDocs.SelectedIndex + 1)+"";
            con = new OleDbConnection();
            this.readconfile = new ReadConfigFile();
            con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            con.Open();
            cmd = new OleDbCommand(Select, con);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
                
        }
    }
}
