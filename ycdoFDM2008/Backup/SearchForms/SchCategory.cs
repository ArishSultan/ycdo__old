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

namespace FDM.SearchForms
{
    public partial class SchCategory : Form
    {
        public SchCategory()
        {
            InitializeComponent();
        }
        List<Category> category;
        List<Category> subCategory;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadGrid()
        {
            category = new CategoryBLL().GetCategory();
            DGVCountry.DataSource = null;
            DGVCountry.DataSource = category;
            FormateGrid();
        }
        public void FormateGrid()
        {
            if (DGVCountry.DataSource != null)
            {
                DGVCountry.Columns["CategoryID"].Visible = false;
                DGVCountry.Columns["CategoryName"].Width = 150;
            }

        }

        private void SchCountry_Load(object sender, EventArgs e)
        {
            LoadGrid();
            FormateGrid();
            txtSearchCountry.Focus();
        }

        private void txtSearchCountry_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchCountry.Text.Trim().ToLower();
            subCategory = new List<Category>();
            subCategory = (from c in category
                       where c.CategoryName.ToLower().StartsWith(SearchValue)
                       select c).ToList();
            DGVCountry.DataSource = subCategory;
        }


        public Category CurrentCategory { get; set; }

        private void tsSelect_Click(object sender, EventArgs e)
        {
            if (category.Count == DGVCountry.Rows.Count)
            {
                this.CurrentCategory = category[DGVCountry.CurrentRow.Index];
                this.Close();
            }
            else
            {
                this.CurrentCategory = subCategory[DGVCountry.CurrentRow.Index];
                this.Close();

            }
        }

        private void DGVCountry_DoubleClick(object sender, EventArgs e)
        {
            if (category.Count == DGVCountry.Rows.Count)
            {
                this.CurrentCategory = category[DGVCountry.CurrentRow.Index];
                this.Close();
            }
            else
                this.CurrentCategory = subCategory[DGVCountry.CurrentRow.Index];
            this.Close();
        }


    }
}
