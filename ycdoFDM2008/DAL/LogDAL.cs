using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using Common ;

namespace DAL
{
    public  class LogDAL
    {
        StreamWriter sw;
        public void SaleInvLineLog(SaleInvoice sai)
        {
            sw = new StreamWriter("Track" + sai.TransactionDate.ToString("yyyyMMdd") + ".log", true);
            for (int i = 0; i < sai.LineItems.Count ; i++)
            {
                sw.WriteLine(sai.Customer.Id +","+sai.SaleInvoiceNo +","+sai.LineItems[i].Item.ItemId +"," + sai.LineItems[i].DiscPct );    
            }
            sw.Close();
        }
    }
}
