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
    public partial class FrmRoom : Form
    {
        public FrmRoom()
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
            this.txtType.Text = "";
            this.txtLabel.Text = "";
            this.txtCategoryName.Focus();
        }
        RoomBLL pctrl = new RoomBLL();
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
                Room pc = new Room();
                if(txtId.Text.Length >0)
                pc.Number = Convert.ToInt64(txtId.Text);
                pc.Name  = this.txtCategoryName.Text;
                pc.Type  = this.txtType.Text.Trim();
                pc.LabelName = txtLabel.Text;
                pctrl.SaveRoom (pc);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        List<Room> Pcs = new List<Room>();
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
            this.lbxRooms.DataSource = null;
            this.lbxRooms.DataSource = pctrl.GetRooms ();
        }
        private void lbxPatientCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbxRooms.DataSource == null) return;
                Room pc = (Room)this.lbxRooms.SelectedItem;
                this.txtCategoryName.Text = pc.Name ;
                this.txtType.Text = pc.Type;
                this.txtLabel.Text = pc.LabelName;
                txtId.Text = pc.Number.ToString ();
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
                Room  pc = (Room )this.lbxRooms.SelectedItem;
                if (pctrl.DeleteRoom (pc) == true)
                    MessageBox.Show(pc.Name  + "  Deleted, successfully", "Deletion Completed");
                LoadPatientCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
