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
    public partial class SchPatient : Form
    {
        public SchPatient()
        {
            InitializeComponent();
        }
        List<Patient> patients;
        List<Patient> Subpatients;
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadGrid()
        {
            DGVCountry.DataSource = null;
            patients = new PatientBLL().GetPatientData();  
            DGVCountry.DataSource = patients;
            FormateGrid();
        }
        public void FormateGrid()
        {
            if (DGVCountry.DataSource != null)
            {
              //  DGVCountry.Columns["LastName"].Visible = false;
               // DGVCountry.Columns["Address"].Visible = false;
               // DGVCountry.Columns["NIC"].Visible = false;
               // DGVCountry.Columns["PatientType"].Visible = false;
               // DGVCountry.Columns["RegistrationDate"].Visible = false;
                DGVCountry.Columns["Member"].Visible = false;
               // DGVCountry.Columns["RegistrationNumber"].Width = 135;
                txtSearchbyFName.Focus();
            }

        }

        private void SchCountry_Load(object sender, EventArgs e)
        {
            LoadGrid();
          FormateGrid();
          txtSearchbyRegNo.Text = "";
          txtSearchbyRegDate.Text = "";
          txtSearchbyFName.Text = "";
          txtSearchbyLName.Text = "";
          txtSearchByNIC.Text = "";
          txtSearchByAdddress.Text="";
          txtSearchByPType.Text = "";
          txtSearchbyRegNo.Focus();
        }



        public Patient CurrentPatient { get; set; }
      
        private void txtSearchbyRegNo_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchbyRegNo.Text.Trim().ToLower();
            Subpatients = new List<Patient>();
            Subpatients = (from c in patients
                           where c.RegistrationNumber.ToLower().StartsWith(SearchValue)
                           select c).ToList();
            DGVCountry.DataSource = Subpatients;
        }

        private void txtSearchbyRegDate_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchbyRegDate.Text.Trim().ToLower();
            Subpatients = new List<Patient>();
            Subpatients = (from c in patients
                           where c.RegistrationDate.ToShortDateString().StartsWith(SearchValue)
                           select c).ToList();
            DGVCountry.DataSource = Subpatients;
        }
        private void txtSearchbyFName_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchbyFName.Text.Trim().ToLower();
            Subpatients = new List<Patient>();
            Subpatients = (from c in patients
                           where c.FirstName.ToLower().StartsWith(SearchValue)
                           select c).ToList();
            DGVCountry.DataSource = Subpatients;
        }

        private void txtSearchbyLName_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchbyLName.Text.Trim().ToLower();
            Subpatients = new List<Patient>();
            Subpatients = (from c in patients
                           where c.LastName.ToLower().StartsWith(SearchValue)
                           select c).ToList();
            DGVCountry.DataSource = Subpatients;
        }

        private void txtSearchByNIC_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchByNIC.Text.Trim().ToLower();
            Subpatients = new List<Patient>();
            Subpatients = (from c in patients
                           where c.NIC.ToLower().StartsWith(SearchValue)
                           select c).ToList();
            DGVCountry.DataSource = Subpatients;
        }

        private void txtSearchByAdddress_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchByAdddress.Text.Trim().ToLower();
            Subpatients = new List<Patient>();
            Subpatients = (from c in patients
                           where c.Address.ToLower().StartsWith(SearchValue)
                           select c).ToList();
            DGVCountry.DataSource = Subpatients;
        }

        private void txtSearchByPType_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchByPType.Text.Trim().ToLower();
            Subpatients = new List<Patient>();
            Subpatients = (from c in patients
                           where c.PatientType.ToLower().StartsWith(SearchValue)
                           select c).ToList();
            DGVCountry.DataSource = Subpatients;
        }

        private void Select_Click(object sender, EventArgs e)
        {
            if (DGVCountry.CurrentRow != null)
                if (DGVCountry.CurrentRow.Cells[0].Value != null)
                {
                    if (Subpatients != null)
                        this.CurrentPatient = Subpatients [DGVCountry.CurrentRow.Index];
                    else
                        this.CurrentPatient = patients[DGVCountry.CurrentRow.Index];
                }
            this.Close();
        }

        private void DGVCountry_DoubleClick(object sender, EventArgs e)
        {
            if (DGVCountry.CurrentRow != null)
                if (DGVCountry.CurrentRow.Cells[0].Value != null)
                {
                    if (Subpatients != null)
                        this.CurrentPatient = Subpatients[DGVCountry.CurrentRow.Index];
                    else
                        this.CurrentPatient = patients[DGVCountry.CurrentRow.Index];
                }
            this.Close();
          
        }
    }
}
