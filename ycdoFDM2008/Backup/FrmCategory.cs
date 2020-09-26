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
namespace FDM
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearControls()
        {
            txtCity.Text = "";
            txtid.Text = "";
            frm.CurrentCategory = null;
            txtCity.Focus();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        Category c = new Category();
        private void tsSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCity.Text.Length > 0)
                {
                    c = new Category();
                    c.CategoryName = this.txtCity.Text.Trim();
                    if (frm.CurrentCategory != null)
                    {
                        c.CategoryID = frm.CurrentCategory.CategoryID;
                    }
                    if (new CategoryBLL().SaveCategory(c))
                    {
                        MessageBox.Show("Category Saved Successfully", "Success");
                        ClearControls();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        SchCategory frm = new SchCategory();
        private void tsEdit_Click(object sender, EventArgs e)
        {

            frm.ShowDialog();
            if (frm.CurrentCategory != null)
            {
                this.txtCity.Text = frm.CurrentCategory.CategoryName;
                this.txtid.Text = frm.CurrentCategory.CategoryID.ToString();

            }
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (frm.CurrentCategory != null)
            {
                c.CategoryID = frm.CurrentCategory.CategoryID;
                if (new CategoryBLL().DeleteCategory(c) == true)
                {
                    if (MessageBox.Show("Do You Really Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                        MessageBox.Show("Category Deleted Successfully", "Message");

                    ClearControls();
                }
                else
                    ClearControls();
            }
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            ClearControls();
        }

    }
}
