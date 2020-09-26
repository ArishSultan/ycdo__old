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
    public partial class SchIssuedMedicine : Form
    {
        public SchIssuedMedicine()
        {
            InitializeComponent();
        }
        List<RecieveMedicine> LoRec;
        public RecieveMedicine Current;
        public void LoadGrid()
        {
            LoRec = new InjectionLabTestBLL().GetIssuedMedicine();
            dgvMedicines.Rows.Clear();
            foreach (var item in LoRec)
            {
                object[] values = { item.RefRec.LineItem.LabTestId, item.RefRec.LineItem.TestName, item.RecieveNumber,item.RecieveDate.ToShortDateString() ,item.RefRec.LineItem.MedIssuedID };
                dgvMedicines.Rows.Add(values);
            }
        }
        public void ClearControlls()
        {
            txtIssueNo.Text = "";
            txtMedName.Text = "";
            txtSearchMedicineID.Text = "";
            this.Current = null;
        }
     

        private void SchIssuedMedicine_Load(object sender, EventArgs e)
        {
            ClearControlls();
            LoadGrid();
            dgvMedicines.ClearSelection();
        }

     

        private void txtSearchMedicineID_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtSearchMedicineID.Text.Trim();

            var qry = (from p in LoRec
                       where p.RefRec.LineItem.LabTestId.ToString().StartsWith(searchValue)
                       select p).ToList();
            this.dgvMedicines.Rows.Clear();
            foreach (var item in qry)
            {
                object[] values = { item.RefRec.LineItem.LabTestId, item.RefRec.LineItem.TestName, item.RecieveNumber,item.RecieveDate.ToShortDateString(), item.RefRec.LineItem.MedIssuedID };
                dgvMedicines.Rows.Add(values);

            }
        }

        private void txtMedName_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtMedName.Text.ToString().ToLower().Trim();

            var qry = (from p in LoRec
                       where p.RefRec.LineItem.TestName.ToString().ToLower().StartsWith(searchValue)
                       select p).ToList();
            this.dgvMedicines.Rows.Clear();
            foreach (var item in qry)
            {
                object[] values = { item.RefRec.LineItem.LabTestId, item.RefRec.LineItem.TestName, item.RecieveNumber, item.RecieveDate.ToShortDateString(), item.RefRec.LineItem.MedIssuedID };
                dgvMedicines.Rows.Add(values);

            }
        }

        private void txtIssueNo_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtIssueNo.Text.ToString().ToLower().Trim();

            var qry = (from p in LoRec
                       where p.RecieveNumber.ToString().StartsWith(searchValue)
                       select p).ToList();
            this.dgvMedicines.Rows.Clear();
            foreach (var item in qry)
            {
                object[] values = { item.RefRec.LineItem.LabTestId, item.RefRec.LineItem.TestName, item.RecieveNumber, item.RecieveDate.ToShortDateString(), item.RefRec.LineItem.MedIssuedID };
                dgvMedicines.Rows.Add(values);

            }
        }

        private void dgvMedicines_DoubleClick(object sender, EventArgs e)
        {
            lblSelect_Click(sender, e);
        }

        private void txtIssueDate_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtIssueDate.Text.ToString().ToLower().Trim();

            var qry = (from p in LoRec
                       where p.RecieveDate.ToShortDateString().StartsWith(searchValue)
                       select p).ToList();
            this.dgvMedicines.Rows.Clear();
            foreach (var item in qry)
            {
                object[] values = { item.RefRec.LineItem.LabTestId, item.RefRec.LineItem.TestName, item.RecieveNumber, item.RecieveDate.ToShortDateString(), item.RefRec.LineItem.MedIssuedID };
                dgvMedicines.Rows.Add(values);

            }
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            ClearControlls();
            this.Close();
        }

        private void lblSelect_Click(object sender, EventArgs e)
        {
            int L = Convert.ToInt32(dgvMedicines.CurrentRow.Cells["ID"].Value);
            if (dgvMedicines.CurrentRow != null)
                if (dgvMedicines.CurrentRow.Cells[0].Value != null)
                    this.Current = (RecieveMedicine)LoRec.Where(g => g.RefRec.LineItem.MedIssuedID == L).Single<RecieveMedicine>();
            this.Close();
        }
    }
}
