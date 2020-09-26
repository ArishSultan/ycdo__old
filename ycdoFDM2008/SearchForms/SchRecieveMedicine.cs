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
    public partial class SchRecieveMedicine : Form
    {
        public SchRecieveMedicine()
        {
            InitializeComponent();
        }
        List<RecieveMedicine> LoRec,SubLoRec;
        public RecieveMedicine Current;
        private void tsClose_Click(object sender, EventArgs e)
        {

        }

        private void SchRecieveMedicine_Load(object sender, EventArgs e)
        {
            LoadGrid();
            ClearControlls();
        }
        public void LoadGrid()
        {
            LoRec = new LabTestBLL().GetRecieveMedicines();
           // SubLoRec=LoRec.Where(p=>p.RecieveNumber.)
            dgvMedicines.Rows.Clear();
            foreach (var item in LoRec)
            {
                object[] values = { item.RefRec.LineItem.LabTestId, item.RefRec.LineItem.TestName, item.RecieveNumber, item.RecieveDate.ToShortDateString(), item.RefRec.LineItem.MedIssuedID };
                dgvMedicines.Rows.Add(values);
            }
            dgvMedicines.ClearSelection();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            int L = Convert.ToInt32(dgvMedicines.CurrentRow.Cells["ID"].Value);
            if (dgvMedicines.CurrentRow != null)
                if (dgvMedicines.CurrentRow.Cells[0].Value != null)
                    this.Current = (RecieveMedicine)LoRec.Where(g => g.RefRec.LineItem.MedIssuedID == L).Single<RecieveMedicine>();
            this.Close();
        }

        private void txtSearchItemNumber_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtSearchItemNumber.Text.Trim();

            var qry = (from p in LoRec
                       where p.RefRec.LineItem.LabTestId.ToString().StartsWith(searchValue)
                       select p).ToList();
            this.dgvMedicines.Rows.Clear();
            foreach (var item in qry)
            {
                object[] values = { item.RefRec.LineItem.LabTestId, item.RefRec.LineItem.TestName, item.RecieveNumber, item.RecieveDate.ToShortDateString(), item.RefRec.LineItem.MedIssuedID };
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

        private void txtRecieveNo_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtRecieveNo.Text.ToString().ToLower().Trim();

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
        private void txtReceiveDate_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtReceiveDate.Text.ToString().Trim();

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
        private void tsSelect_Click(object sender, EventArgs e)
        {
           
        }

       
        public void ClearControlls()
        {
            txtRecieveNo.Text = "";
            txtMedName.Text = "";
            txtSearchItemNumber.Text = "";
            txtReceiveDate.Text = "";
            this.Current = null;
        }
        private void dgvMedicines_DoubleClick(object sender, EventArgs e)
        {
            lblSelect_Click(sender, e);
        }

        private void lblSelect_Click(object sender, EventArgs e)
        {
            int L = Convert.ToInt32(dgvMedicines.CurrentRow.Cells["ID"].Value);
            if (dgvMedicines.CurrentRow != null)
                if (dgvMedicines.CurrentRow.Cells[0].Value != null)
                    this.Current = (RecieveMedicine)LoRec.Where(g => g.RefRec.LineItem.MedIssuedID == L).Single<RecieveMedicine>();
            this.Close();
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            ClearControlls();
            this.Close();
        }

     

      
       
    }
}
