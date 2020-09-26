using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FDM
{
    public partial class FrmStartup : Form
    {
        public FrmStartup()
        {
            InitializeComponent();
        }

        private void FrmStartup_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
            FrmDBOperator frmDB = new FrmDBOperator();
            frmDB.ShowDialog();
            FrmLogin log = new FrmLogin();
            log.ShowDialog();
            this.Close();
        }
    }
}
