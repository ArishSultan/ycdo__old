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
using FDM.SearchForms;
using Common.Enum;

namespace FDM
{
    public partial class frmDiagnosis : Form
    {
        public frmDiagnosis()
        {
            InitializeComponent();
        }
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearControls()
        {
            txtCounsil.Text = "";
            txtid.Text = "";
            frm.CurrentDiagnosis = null;
            txtCounsil.Focus();
        }
        private void tsNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        Diagnosis c = new Diagnosis();
        private void tsSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCounsil.Text.Length > 0)
                {
                    c = new Diagnosis();
                    c.Name= this.txtCounsil.Text.Trim();
                    c.DiagnosisType = (DiagnosisType)cbxType.SelectedItem;
                    if (frm.CurrentDiagnosis != null)
                    {
                        c.Code = frm.CurrentDiagnosis.Code;
                    }
                    if (new DiagnosisBLL().SaveDiagnosis(c))
                    {
                        MessageBox.Show("Diagnosis Saved Successfully", "Success");
                        ClearControls();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        frmSchDiagnosis frm = new frmSchDiagnosis();
        private void tsEdit_Click(object sender, EventArgs e)
        {

            frm.ShowDialog();
            if (frm.CurrentDiagnosis != null)
            {
                this.txtCounsil.Text = frm.CurrentDiagnosis.Name;
                this.txtid.Text = frm.CurrentDiagnosis.Code.ToString();
                this.cbxType.SelectedItem = frm.CurrentDiagnosis.DiagnosisType;

            }
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (frm.CurrentDiagnosis != null)
            {
                c.Code = frm.CurrentDiagnosis.Code;
                if (new DiagnosisBLL().DeleteDiagnosis(c) == true)
                {
                    if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                        MessageBox.Show("Diagnosis Deleted Successfully", "Message");

                    ClearControls();
                }
                else
                    ClearControls();
            }
        }

        private void FrmDiagnosis_Load(object sender, EventArgs e)
        {
            ClearControls();
           // cbxType.Datasource = Enum.GetValues(typeof(DiagnosisType));
            //cbxType.Items.AddRange(Enum.GetNames(typeof(DiagnosisType)));
            cbxType.Items.Add(DiagnosisType.Differential);
            cbxType.Items.Add(DiagnosisType.Provisional);
            
        }

       
    }
}
