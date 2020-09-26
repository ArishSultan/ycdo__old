using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Common.Datasets;
using DAL;
using System.Data;
namespace BLL
{
    public class PrintLabelBLL
    {
        public DsPrintedInvoices GetPrintedInvoices(DateTime fromDate, DateTime toDate)
        {
            return new PrintLabelDAL().GetPrintedInvoices(fromDate, toDate);
        }

        public DataTable GetCompanyInfo()
        {
           // return new CompanyInfoDAL().GetCompanyInfo();
            return new DataTable();
        }
        public void SetCompanyCheck(bool value)
        {
            new PrintLabelDAL().SetCompanyCheck(value);
        }
        public bool GetCompanyCheck()
        {
            return new PrintLabelDAL().GetCompanyCheck();
        }
    }
}
