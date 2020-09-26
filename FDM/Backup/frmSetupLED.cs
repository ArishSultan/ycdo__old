using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PCComm;
namespace FDM
{
    public partial class frmSetupLED : Form
    {
        public CommunicationManager comm;
        string transType = string.Empty;
        public frmSetupLED()
        {
            InitializeComponent();
        }
        public frmSetupLED(CommunicationManager cm)
        {
            InitializeComponent();
            comm = cm;
        }
        private void frmSetupLED_Load(object sender, EventArgs e)
        {
            try
            {
                LoadValues();
                SetDefaults();
                SetControlState();
                if (comm.comPort.IsOpen)
                {
                    this.rtbDisplay.SelectionFont = new Font(this.rtbDisplay.SelectionFont, FontStyle.Bold);
                    this.rtbDisplay.Text = CommunicationManager.PortMessage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "L E D Load Error");
            }
           
        }

        /// <summary>
        /// Method to initialize serial port
        /// values to standard defaults
        /// </summary>
        private void SetDefaults()
        {
            cboPort.SelectedIndex = 0;
            cboBaud.SelectedText = "1200";
            cboParity.SelectedIndex = 0;
            cboStop.SelectedIndex = 1;
            cboData.SelectedIndex = 1;
        }

        /// <summary>
        /// methos to load our serial
        /// port option values
        /// </summary>
        private void LoadValues()
        {
            comm.SetPortNameValues(cboPort);
            comm.SetParityValues(cboParity);
            comm.SetStopBitValues(cboStop);
        }

        /// <summary>
        /// method to set the state of controls
        /// when the form first loads
        /// </summary>
        private void SetControlState()
        {
            rdoText.Checked = true;
            cmdSend.Enabled = false;
            cmdClose.Enabled = false;
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            comm.Parity = cboParity.Text;
            comm.StopBits = cboStop.Text;
            comm.DataBits = cboData.Text;
            comm.BaudRate = cboBaud.Text;
            comm.PortName = this.cboPort.Text;
            comm.DisplayWindow = rtbDisplay;
            comm.OpenPort();
            cmdOpen.Enabled = false;
            cmdClose.Enabled = true;
            cmdSend.Enabled = true;
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            comm.WriteData("*" + txtSend.Text + "#");
        }

    }
}
