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

namespace FDM.SearchForms
{
    public partial class SchMedicinesIssued : Form
    {
        public SchMedicinesIssued()
        {
            InitializeComponent();
        }
     
        
      
        List<PatientRegistration> pr,subpr;
        public PatientRegistration current { get; set; }
        public void LoadGrid()
        {
            dgvMedicines.DataSource = null;

         
          //  pr = new InjectionLabTestBLL().GetAllMedicinesIssued();
            pr = new InjectionLabTestBLL().GetAllMedicinesIssued();
            dgvMedicines.DataSource = pr;
            for (int i = 0; i < dgvMedicines.Columns.Count; i++)
            {
                if (dgvMedicines.Columns[i].Name != "TokenNumber" && dgvMedicines.Columns[i].Name != "TokenDate" && dgvMedicines.Columns[i].Name != "TokenMonthYear" && dgvMedicines.Columns[i].Name != "PatientRegistrationNumber" && dgvMedicines.Columns[i].Name != "PatientFirstName")
                { dgvMedicines.Columns[i].Visible = false; }
                else
                {
                 
                    dgvMedicines.Columns["TokenMonthYear"].Width = 90;                  
                    dgvMedicines.Columns["TokenDate"].Width = 80;
                    dgvMedicines.Columns["TokenNumber"].Width = 80;
                    dgvMedicines.Columns["PatientRegistrationNumber"].Width = 90;
                    dgvMedicines.Columns["PatientRegistrationNumber"].HeaderText = "RegistrationNO";
                    dgvMedicines.Columns["PatientFirstName"].Width = 90;
                }
            }
        }
     
        private void SchMedicinesIssued_Load(object sender, EventArgs e)
        {
            LoadGrid();
          
            txtSearchTokenDate.Text = "";
            txtSearchTokenNo.Text = "";
        }

        private void txtSearchTokenNo_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchTokenNo.Text.Trim().ToLower();
            subpr = new List<PatientRegistration>();
            subpr = (from c in pr
                          where c.TokenNumber.ToString().StartsWith(SearchValue)
                          select c).ToList();
            dgvMedicines.DataSource = subpr;
        }

        private void txtSearchTokenDate_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchTokenDate.Text.Trim().ToLower();
            subpr = new List<PatientRegistration>();
            subpr = (from c in pr
                     where c.TokenDate.ToShortDateString().StartsWith(SearchValue)
                     select c).ToList();
            dgvMedicines.DataSource = subpr;
        }

        private void txtSearchTokenMonthYear_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchTokenMonthYear.Text.Trim().ToLower();
            subpr = new List<PatientRegistration>();
            subpr = (from c in pr
                     where c.TokenMonthYear.ToString().StartsWith(SearchValue)
                     select c).ToList();
            dgvMedicines.DataSource = subpr;
        }
        private void txtSearchRegNO_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchRegNO.Text.Trim().ToLower();
            subpr = new List<PatientRegistration>();
            subpr = (from c in pr
                     where c.Patient.RegistrationNumber.ToString().StartsWith(SearchValue)
                     select c).ToList();
            dgvMedicines.DataSource = subpr;
        }
        private void txtSearchFirsName_TextChanged(object sender, EventArgs e)
        {
            var SearchValue = this.txtSearchFirsName.Text.Trim().ToLower();
            subpr = new List<PatientRegistration>();
            subpr = (from c in pr
                     where c.Patient.FirstName.ToString().StartsWith(SearchValue)
                     select c).ToList();
            dgvMedicines.DataSource = subpr;
        }
        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            if (dgvMedicines.CurrentRow != null)
                if (dgvMedicines.CurrentRow.Cells["TokenNumber"].Value != null)
                {
                    if (subpr != null)
                        this.current=subpr[dgvMedicines.CurrentRow.Index];
                    else
                        this.current = pr[dgvMedicines.CurrentRow.Index];
                }
            this.Close();
            frmMedicineIssuedRecord mir = new frmMedicineIssuedRecord(this.current);
            mir.ShowDialog();
        }

        private void dgvMedicines_DoubleClick(object sender, EventArgs e)
        {
             if (dgvMedicines.CurrentRow != null)
                if (dgvMedicines.CurrentRow.Cells["TokenNumber"].Value != null)
                {
                    if (subpr != null)
                        this.current=subpr[dgvMedicines.CurrentRow.Index];
                    else
                        this.current = pr[dgvMedicines.CurrentRow.Index];
                }
            this.Close();
            frmMedicineIssuedRecord mir = new frmMedicineIssuedRecord(this.current);
            mir.ShowDialog();
        }

       

       
        }

       

     
       
    }

