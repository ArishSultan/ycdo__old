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
using System.IO;
using System.Diagnostics;
using System.Threading;
namespace FDM
{
    public partial class FrmDBOperator : Form
    {
        public FrmDBOperator()
        {
            InitializeComponent();
        }

        private string datasource;
        private DBOperateBLL dbcontrol;
        private string DestinatinationfileName;
       
        private ProjectDetail prj;
         
        private string provider;
        private string sourcefileName;
        private string startupfileName;
        int counter;
        private string userinfo;


        private void FrmDBOperator_Load(object sender, EventArgs e)
        {
            try
            {
                //this.dbcontrol = new DBOperateBLL();
                //this.prj = new ProjectDetail();
                //this.progressBar1.Maximum = 105;
                //this.sourcefileName = Application.StartupPath + @"\DB\" + this.prj.ProjectDBName + ".mdb";
                //this.startupfileName = Application.StartupPath + @"\" + this.prj.ProjectConfigfileName;
                ////March 4,2012 - Sunday
                ////For YCDO Free Dispancary
                //// we will not move our databse to any path it will remain at same Directory
                //this.DestinatinationfileName = Application.StartupPath + @"\DB\" + this.prj.ProjectDBName + ".mdb";// this.dbcontrol.DataPath() + this.prj.ProjectDBName + ".mdb";
                //this.provider = "Provider=Microsoft.Jet.OLEDB.4.0;";
                //this.datasource = "Data Source=" + this.DestinatinationfileName + ";";
                ////this.userinfo = "User ID=Admin;Jet OLEDB:Database Password=pw;";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, sender.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.counter++;
                //if (this.progressBar1.Value == 5)
                //{
                //    StreamWriter writer;
                //    this.timer1.Enabled = false;
                //    if (!File.Exists(this.DestinatinationfileName))
                //    {
                //        if (File.Exists(this.sourcefileName))
                //        {
                //            File.Copy(this.sourcefileName, this.DestinatinationfileName);
                //            writer = new StreamWriter(this.startupfileName);
                //            writer.WriteLine(this.provider + this.datasource + this.userinfo);
                //            writer.Close();
                //            this.timer1.Enabled = true;
                //        }
                //        else
                //        {
                //            MessageBox.Show("Data Files Not Found, Application will be closed", "Data Files Missing", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //            Application.Exit();
                //        }
                //    }
                //    else
                //    {
                //        writer = new StreamWriter(this.startupfileName);
                //        writer.WriteLine(this.provider + this.datasource + this.userinfo);
                //        writer.Close();
                //        this.timer1.Enabled = true;
                //        //if (File.Exists(this.DestinatinationfileName + "1"))
                //        //{
                //        //    File.Delete(this.DestinatinationfileName + "1");
                //        //}
                //        //string str = "jetcomp.exe ";
                //        //string arguments = " -src:" + this.DestinatinationfileName + "  -dest:" + this.DestinatinationfileName + "1 -w pw -v4";
                //        //try
                //        //{
                //        //    Process.Start(Application.StartupPath + @"\" + str, arguments);
                //        //    Thread.Sleep(12000);
                //        //    if (File.Exists(this.DestinatinationfileName + "1"))
                //        //    {
                //        //        File.Delete(this.DestinatinationfileName);
                //        //        File.Copy(this.DestinatinationfileName + "1", this.DestinatinationfileName);
                //        //        File.Delete(this.DestinatinationfileName + "1");
                //        //    }
                //        //    Thread.Sleep(3000);
                //        //}
                //        //catch (Exception)
                //        //{
                //        //}
                //        this.Close();
                //    }
                //}
                if (this.progressBar1.Value < 105)
                {
                    this.progressBar1.Value += 5;
                }
                else
                {

                    this.Close();
                    timer1.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, sender.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
