using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using OleDbHelper;
using System.Windows.Forms;
using BLL;
using Common;


namespace FDM
{
    public partial class FrmClearStock : Form
    {
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbDataReader dr;
        private OleDbTransaction tran;
        public FrmClearStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 10;
            DataTable dt = new DataTable();
            con = new OleDbConnection();
            readconfile = new ReadConfigFile();
            con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                for (int f = 0; f < 5; f++)
                {
                    
                    for (int i = 0; i <= 10000; i++)
                    {
                        
                        tran = con.BeginTransaction();
                        cmd = new OleDbCommand("", con);
                        switch (f)
                        {
                            case 0:
                                cmd.CommandText = "Update InjectionLabTest set SecondTurn=false where InjectionId=" + i;
                                break;
                            case 1:
                                cmd.CommandText = "Update InjectionLabTest set DosePerDay=" + a + " where DosePerDay=" + i;
                                break;
                            case 3:
                                cmd.CommandText = "Update LabTest set OpeningQty=" + a + " where OpeningQty=" + i;
                                break;
                            case 4:
                                cmd.CommandText = "Update MedicineIssued set DosePerDay=" + a + " where DosePerDay=" + i;
                                break;
                            case 2:
                                cmd.CommandText = "Update ReceiveMedicine set Qty=" + a + " where Qty=" + i;
                                break;
                            default:
                                cmd.CommandText = "Update InjectionLabTest set SecondTurn=false where InjectionId=";
                                break;


                        }
                        
                        //cmd.Connection = con;
                        cmd.Transaction = tran;
                        //cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        tran.Commit();

                    }
                }
            }
            MessageBox.Show("congragulation Cleared!");
        }

        private void FrmClearStock_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
