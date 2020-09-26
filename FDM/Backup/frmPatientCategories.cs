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

namespace FDM
{
    public partial class frmPatientCategories : Form
    {
        public frmPatientCategories()
        {
            InitializeComponent();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            NewCategory();
        }
        public void NewCategory()
        {
            this.txtId.Text = "";
            this.txtCategoryName.Text = "";
            this.txtDiscountPercentage.Text = "";
            this.txtCategoryName.Focus();
        }
        PatientBLL pctrl = new PatientBLL();
        private void tsSave_Click(object sender, EventArgs e)
        {
            SavePatientCategory();
            LoadPatientCategories();
            NewCategory();
        }
        public void SavePatientCategory()
        {
            try
            {
                PatientCategory pc = new PatientCategory();
                if (txtId.Text.Length > 0)
                    pc.CategoryID = Convert.ToInt32 (txtId.Text);
                pc.CategoryName = this.txtCategoryName.Text;
                pc.DiscountPercentage = Convert.ToDouble(this.txtDiscountPercentage.Text.Trim());
                pctrl.SavePatientCategory(pc);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        List<PatientCategory> Pcs = new List<PatientCategory>();
        private void frmPatientCategories_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPatientCategories();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        public void LoadPatientCategories()
        {
            this.lbxPatientCategories.DataSource = null;
            this.lbxPatientCategories.DataSource = pctrl.GetPatientCategories();
        }
        private void lbxPatientCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbxPatientCategories.DataSource == null) return;
                PatientCategory pc = (PatientCategory)this.lbxPatientCategories.SelectedItem;
                this.txtCategoryName.Text  = pc.CategoryName;
                this.txtDiscountPercentage.Text  = pc.DiscountPercentage.ToString("0.00");
                this.txtId.Text = pc.CategoryID.ToString ();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                PatientCategory pc = (PatientCategory)this.lbxPatientCategories.SelectedItem;
                if (pctrl.DeletePatientCategory(pc) == true)
                    MessageBox.Show(pc.CategoryName + " Catgory Deleted, successfully","Deletion Completed" );
                LoadPatientCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            
        }
    }
}
