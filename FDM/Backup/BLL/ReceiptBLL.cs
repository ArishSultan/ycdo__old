using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;
using DAL.UpdateDB;
namespace BLL
{
    public  class ReceiptBLL
    {
        public ReceiptBLL() { }

        public List<ChartOfAccount> GetChartofAccounts()
        {
            //return new LocalDBDAL().GetChartofAccounts();
            return new List<ChartOfAccount>();
        }
    }
}
