using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Common;
using BLL;
using System.Windows.Forms;

namespace FDM
{
    public partial class frmdoctorchange : Form
    {
        RoomBLL rbll = new RoomBLL();
        public string frmname;
        public string token;
        public bool show = false;
        public frmdoctorchange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.frmname = cbxRooms.SelectedItem.ToString();
            show = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.frmname = null;
        }

        private void frmdoctorchange_Load(object sender, EventArgs e)
        {
            List<Room> rooms = rbll.GetRooms();
            this.cbxRooms.DataSource = rooms;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmpasschange frm = new frmpasschange();
            frm.ShowDialog();
        }
    }
}
