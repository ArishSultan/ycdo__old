using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common ;
using BLL;
using VBCLSUR;
using Microsoft.Win32;

namespace FDM
{
    public partial class FrmWait : Form
    {
        public FrmWait()
        {
            InitializeComponent();
        }
        public User  IsLoginUser;

        private void FrmWait_Load(object sender, EventArgs e)
        {
            try
            {

                VBCLS vbcls = new VBCLS();
                //if (vbcls.LETGO())
                {
                    base.Visible = false;
                    base.Hide();
                    //new UpdateQuriesBLL().UpdateDatabaseQuries();
                    if (this.IsLoginUser.IsAdmin)
                    {
                        ProjectDetail detail = new ProjectDetail();
                        RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\" + detail.ProjectName + "Login");
                        switch (Convert.ToString(key.GetValue(detail.ProjectName + "firstLogin")))
                        {
                            case "":
                            case null:
                                new FrmCreateChangeUser().ShowDialog();
                                key.SetValue(detail.ProjectName + "firstLogin", "NO");
                                break;
                        }
                    }
                    
                    FrmMain main = new FrmMain();
                    FrmMain.MachineName = Environment.MachineName;
                    main.IsLoginUser = this.IsLoginUser;
                    main.ShowDialog();
                    base.Close();
                }
                //else
                {
                    base.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
    }
}
