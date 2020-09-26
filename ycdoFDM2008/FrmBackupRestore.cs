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
    public partial class FrmBackupRestore : Form
    {
        public FrmBackupRestore()
        {
            InitializeComponent();
        }
        ProjectDetail prj;
        DBOperateBLL dbcontrol;
        string sDBFile="", tempFile="";
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Application.StartupPath.ToString() + @"\DB\Backup";
            dialog.Filter = "Supported Files|*.mdb";
            dialog.RestoreDirectory = true;
            dialog.ShowDialog();
            this.txtRestoreFileNameandPath.Text = dialog.FileName;
            string fileName = dialog.FileName;
            dialog.InitialDirectory = Application.StartupPath.ToString();
            dialog.Dispose();
        }
        private void btnselectpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (dialog.SelectedPath != string.Empty)
            {
                this.txtBackupPath.Text = dialog.SelectedPath.ToString() + @"\" +this.prj.ProjectName + this.GetBackupFilename();
                dialog.Dispose();
            }
        }

        private void frmBackupRestore_Load(object sender, EventArgs e)
        {
            this.prj = new ProjectDetail();
            this.dbcontrol = new DBOperateBLL();
            if (!Directory.Exists(Application.StartupPath.ToString() + @"\DB\Backup"))
            {
                Directory.CreateDirectory(Application.StartupPath.ToString() + @"\DB\Backup");
            }
            this.sDBFile = this.dbcontrol.DataPath();
            this.tempFile = Application.StartupPath.ToString() + @"\DB\tempDbBackup.mdb";
            this.txtBackupPath.Text = Application.StartupPath.ToString() + @"\DB\Backup\" + this.prj.ProjectName + this.GetBackupFilename();
        }

        private string GetBackupFilename()
        {
            try
            {
                return (DateTime.Now.ToString("yyyy/MM/d") + "time" + DateTime.Now.ToString("hh:mm:ss") + ".mdb").Replace("/", string.Empty).Replace(":", string.Empty);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                return string.Empty;
            }
        }



        private void tsBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string path = this.txtBackupPath.Text.Trim();
                if (File.Exists(path))
                {
                    MessageBox.Show(path + "back already Exist");
                }
                else if (File.Exists(this.sDBFile))
                {
                    string str2 = "jetcomp.exe";
                    string arguments = " -src:" + this.sDBFile + "  -dest:" + this.sDBFile + "1 -w pw -v4";
                    try
                    {
                        Process.Start(Application.StartupPath + @"\" + str2, arguments);
                        Thread.Sleep(1200);
                        if (File.Exists(this.sDBFile + "1"))
                        {
                            File.Delete(this.sDBFile);
                            File.Copy(this.sDBFile + "1", this.sDBFile);
                            File.Delete(this.sDBFile + "1");
                        }
                    }
                    catch (Exception)
                    {
                    }
                    File.Copy(this.sDBFile, path, true);
                    MessageBox.Show("backup competed...");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void tsRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtRestoreFileNameandPath.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("please select a file to restore...");
                }
                if (File.Exists(this.txtRestoreFileNameandPath.Text.Trim()))
                {
                    File.Copy(this.txtRestoreFileNameandPath.Text.Trim(), this.sDBFile, true);
                    MessageBox.Show("restore completed...");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
        }

    }
}
