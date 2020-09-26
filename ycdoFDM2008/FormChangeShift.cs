using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;

namespace FDM
{
    public partial class FormChangeShift : Form
    {
        private User IsLoginUser;

        public FormChangeShift()
        {
            InitializeComponent();
        }

        public FormChangeShift(User IsLoginUser)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IsLoginUser = IsLoginUser;
        }

        private void FormChangeShift_Load(object sender, EventArgs e)
        {
            this.cbxShift.DataSource = new BLL.ShiftsBLL().GetShifts();
            Shift shift = new BLL.ShiftsBLL().GetActiveShift();
            this.lblShift.Text = "Active Shift is :" + shift.ShiftName;
            cbxShift.DisplayMember = "ShiftName";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            
            
            if (cbxShift.SelectedIndex != -1)
            {
                Shift shift = (Shift)cbxShift.SelectedItem;

                bool canChange = new BLL.ShiftsBLL().ShiftCanChange(shift);
                if (canChange)
                {
                    if (new BLL.ShiftsBLL().SetActiveShift(shift, this.IsLoginUser))
                    {
                        MessageBox.Show("Shift Changed Sussfully");
                        this.cbxShift.DataSource = new BLL.ShiftsBLL().GetShifts();
                        shift = new BLL.ShiftsBLL().GetActiveShift();
                        this.lblShift.Text = "Active Shift is :" + shift.ShiftName;
                    }
                }
                else
                {
                    MessageBox.Show("Shift Can't Update In Current date?", "Error");
                
                }
            }
            else
            {
                MessageBox.Show("Please Select a Shift to Marks As Active");
            
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
