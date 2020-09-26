using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using Common;
using System.Windows.Forms;

namespace FDM
{
    public partial class frmshowcounter : Form
    {
        public string s;
        public int counter;
        StreamReader sr;
        StreamWriter sw;
        public frmshowcounter()
        {
            InitializeComponent();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmshowcounter_Load(object sender, EventArgs e)
        {
            lblCurrentTokenNumber.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to reset records of " + s + " ?", "Reset Counter", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sw = new StreamWriter("C:\\" + s.Trim() + ".txt", false);
                sw.WriteLine("0");
                sw.Close();
            }
            
            lblCurrentTokenNumber.Text = "000";
        }

        private void section2DrSaminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = section2DrSaminaToolStripMenuItem.Text;
            if (s.Contains('/'))
            {
                string[] array = s.Split('/');
                s = array[0] + array[1];
            }
            sr = new StreamReader("C:\\" + s.Trim() + ".txt");
            counter = Convert.ToInt32(sr.ReadLine());
            sr.Close();
            lblCurrentTokenNumber.Visible = true;
            lblCurrentTokenNumber.Text = counter.ToString("000");
        }

        private void section3DrSohailJalilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = section3DrSohailJalilToolStripMenuItem.Text;
            if (s.Contains('/'))
            {
                string[] array = s.Split('/');
                s = array[0] + array[1];
            }
            sr = new StreamReader("C:\\" + s.Trim() + ".txt");
            counter = Convert.ToInt32(sr.ReadLine());
            sr.Close();
            lblCurrentTokenNumber.Text = counter.ToString("000");
            lblCurrentTokenNumber.Visible = true;
        }

        private void section4DrJameelaFaizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = section4DrJameelaFaizaToolStripMenuItem.Text;
            if (s.Contains('/'))
            {
                string[] array = s.Split('/');
                s = array[0] + array[1];
            }
            sr = new StreamReader("C:\\" + s.Trim() + ".txt");
            counter = Convert.ToInt32(sr.ReadLine());
            sr.Close();
            lblCurrentTokenNumber.Text = counter.ToString("000");
            lblCurrentTokenNumber.Visible = true;
        }

        private void section5DrAhmedKhalilAyyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = section5DrAhmedKhalilAyyazToolStripMenuItem.Text;
            if (s.Contains('/'))
            {
                string[] array = s.Split('/');
                s = array[0] + array[1];
            }
            sr = new StreamReader("C:\\" + s.Trim() + ".txt");
            counter = Convert.ToInt32(sr.ReadLine());
            sr.Close();
            lblCurrentTokenNumber.Visible = true;
            lblCurrentTokenNumber.Text = counter.ToString("000");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
