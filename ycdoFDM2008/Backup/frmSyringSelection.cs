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
    public partial class frmSyringSelection : Form
    {
        public frmSyringSelection()
        {
            InitializeComponent();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<LabTest> labtests;
        private void frmSyringSelection_Load(object sender, EventArgs e)
        {
            labtests = new LabTestBLL().GetLabTests();
            this.cbxSyring.DataSource = null;
            this.cbxSyring.DataSource = labtests;
            this.cbxSyring.DisplayMember = "TestName";
            this.cbxSyring.ValueMember = "LabTestId";
            LoadCurrentSyring();
        }
        private void LoadCurrentSyring()
        {
            LabTest lbt = new LabTestBLL().GetSyring();
            this.cbxSyring.SelectedValue  = lbt.LabTestId;
        }
        private void tsSave_Click(object sender, EventArgs e)
        {
            LabTest syring = (LabTest)this.cbxSyring.SelectedItem;
            if (new LabTestBLL().SaveSyring(syring))
            {
                MessageBox.Show("Congratulations Syring Saved Successfully!!!", "Syring");
            }
        }
    }
}
