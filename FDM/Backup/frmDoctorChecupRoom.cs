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
    public partial class frmDoctorChecupRoom : Form
    {
        public frmDoctorChecupRoom()
        {
            InitializeComponent();
        }
        RoomBLL rbll = new RoomBLL();
        public Room CurrentRoom { get; set; }
        List<Room> Rs = new List<Room>();
        private void frmDoctorChecupRoom_Load(object sender, EventArgs e)
        {
            try
            {
                Rs = rbll.GetRooms();
                cbxRooms.DataSource = Rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Load Error");
            }
        }

        private void tsSelect_Click(object sender, EventArgs e)
        {
            if (cbxRooms.Items.Count > 0)
            {
                CurrentRoom = (Room)this.cbxRooms.SelectedItem;
                this.DialogResult = DialogResult.Yes;
            }
            else
                this.DialogResult = DialogResult.No;
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
