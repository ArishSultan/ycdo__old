namespace DAL.SaleOrders
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public class SaveSaleOrderDAL
    {
        public bool DeleteSaleOrder(SaleOrder so)
        {
            bool flag2=false ;
            try
            {
                //SaveSaleOrder order = new SaveSaleOrder();
                //string[] recToDel = new string[] { so.TransactionGUID };
                //Exception exception = new Exception();
                //try
                //{
                //    order.DeleteSaleOrder(ref recToDel);
                //}
                //catch (Exception exception2)
                //{
                //    exception = exception2;
                //}
                //EditSaleOrderDAL rdal = new EditSaleOrderDAL();
                //if (!rdal.GetIsSaleOrderExist(so))
                //{
                //    return true;
                //}
                //flag2 = false;
            }
            catch (Exception)
            {
                throw;
            }
            return flag2;
        }

        private string ISComma(string Value)
        {
            return ("\"" + Value + "\"");
        }

        public string[] ProcessSaleOrder(SaleOrder so)
        {
            string[] strArray3;
            try
            {
                string[] strArray = new string[1];
                if (so != null)
                {

                  
                    //get frieght Account No. from Items Default.
                    ChartOfAccount freightAcc = new ChartOfAccount();
                    //if (so.FreightAmount != 0)
                    //{
                    //   so.FreightAccount   = new DefaultAccountsDAL().GetFreightAccount();
                    //   if (so.FreightAccount.AccountId == null || so.FreightAccount.AccountId == "")
                    //    {
                    //        MessageBox.Show("Freight Account is not Setup ", "Information");
                    //        return strArray;
                    //    }
                    //}
                    if ((so.TransactionGUID == null) || (so.TransactionGUID == ""))
                    {
                        so.NotePrintsAfterLineItems = false;
                        so.StatementNotePrintsBeforeRef = false;
                        so.StatementNote = "";
                        so.InternalNote = "";
                        so.CusNote = "";
                    }
                    so = this.RemoveEmptyLines(so);

                    for (int i = 0; i < so.LineItems .Count ; i++)
                    {
                         //i need to save Line numbers of SaleOrderLines without being gaps that may occur
                        //due to remove of Line or adding new ones.
                        //e.g. line number can be in this sequence 0 ,3 , 5 ,2 for  Lines
                        
                        //we want to save in this pattern 0,1,2,3 for  lines
                        so.LineItems[i].LineitemNo = i ;
                    }
                    //SaveSaleOrder order = new SaveSaleOrder();
                    string transactionGUID = "";
                    transactionGUID = so.TransactionGUID;
                    //this.SaveSaleTax(so, order.FileNameCSV);
                    //this.SaveItems(so, order.FileNameCSV);
                    //this.SaveFreight(so, order.FileNameCSV);
                    if ((transactionGUID != "") && (transactionGUID != null))
                    {
                        string[] recToDel = new string[] { transactionGUID };
                        Exception exception = new Exception();
                        try
                        {
                           // order.DeleteSaleOrder(ref recToDel);
                        }
                        catch (Exception exception2)
                        {
                            exception = exception2;
                        }
                       // EditSaleOrderDAL rdal = new EditSaleOrderDAL();
                        //if (rdal.GetIsSaleOrderExist(so))
                        //{
                        //    throw exception;
                        //}
                        //strArray = order.ImportSaleOrder();
                    }
                    else
                    {
                       // strArray = order.ImportSaleOrder();
                    }
                }
                strArray3 = strArray;
                if (strArray.Length > 0)
                {
                    if (strArray[0] != null && strArray[0] != "")
                    {
                        so.TransactionGUID = strArray[0];
                        //new SaleOrderDBDAL ().SaveShipAddressinCityZipStCountry(so);
                        //new TransactionLineItemsDAL().SaveSaleOrderLineItems(so);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return strArray3;
        }

        private SaleOrder RemoveEmptyLines(SaleOrder so)
        {
            List<SaleOrderlineItem> removedItems = new List<SaleOrderlineItem>();
            foreach (SaleOrderlineItem soLni in so.LineItems)
            {
                if (soLni.Amount == 0 && soLni.ExtendedAmount == 0 && (soLni.Item.ItemId == null || soLni.Item.ItemId == "") && (soLni.LineitemDescription == null || soLni.LineitemDescription == "") && soLni.LineitemPrice == 0 && soLni.Quantity == 0 && (soLni.Job.Id == null || soLni.Job.Id == ""))
                {
                    removedItems.Add(soLni);
                }
            }
            while (removedItems.Count > 0)
            {
                so.LineItems.Remove(removedItems[0]);
                removedItems.Remove(removedItems[0]);
            }
            return so;
        }

        private bool SaveFreight(SaleOrder so, string FileNameXML)
        {
            bool flag;
            try
            {
                int num = 0;
                if (so.SalesTaxCode != null)
                {
                    num = so.SalesTaxCode.SalesTaxAuthority.Count<SalesTaxAuthority>();
                }
                if (so.FreightAmount > Convert.ToDecimal((double) 0.0))
                {
                    num++;
                }
                if (so.LineItems.Count > 0)
                {
                    num += so.LineItems.Count<SaleOrderlineItem>();
                }
                StreamWriter writer = new StreamWriter(FileNameXML, true);
                if (so.FreightAmount > Convert.ToDecimal((double) 0.0))
                {
                    writer.Write(this.ISComma(so.Customer.Id) + ",");
                    writer.Write(this.ISComma(so.Customer.Name) + ",");
                    writer.Write(this.ISComma(so.SaleOrderNo) + ",");
                    writer.Write(so.TransactionDate.ToShortDateString() + ",");
                    writer.Write(so.CloseSO + ",");
                    if (so.QuoteNo != null)
                    {
                        writer.Write(this.ISComma(so.QuoteNo) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    writer.Write(so.DropShip + ",");
                    if (so.ShipAddress.Receipent != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.Receipent) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.AddressLine1 != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.AddressLine1) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.AddressLine2 != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.AddressLine2) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.City != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.City) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.State != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.State) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.Zip != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.Zip) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.Country != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.Country) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.CustomerPO != "")
                    {
                        writer.Write(this.ISComma(so.CustomerPO) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    writer.Write(this.ISComma(so.ShipVia.ShippingMethod) + ",");
                    writer.Write(Math.Round(so.DiscountAmount, 2) + ",");
                    writer.Write(this.ISComma(so.Customer.Term.TermsString) + ",");
                    writer.Write(this.ISComma(so.SalesRep.Id) + ",");
                    writer.Write(so.ARAccount.AccountId + ",");
                    writer.Write(Math.Round(so.TransactionTotal, 2) + ",");
                    writer.Write(so.SalesTaxCode.SalestaxId + ",");
                    writer.Write(this.ISComma(so.CusNote) + ",");
                    writer.Write(so.NotePrintsAfterLineItems + ",");
                    writer.Write(this.ISComma(so.StatementNote) + ",");
                    writer.Write(so.StatementNotePrintsBeforeRef + ",");
                    writer.Write(num + ",");
                    writer.Write(0 + ",");
                    writer.Write(0.0 + ",");
                    writer.Write(",");
                    writer.Write("Freight Amount,");
                    writer.Write(so.FreightAccount.AccountId + ",");
                    writer.Write("0.00,");
                    writer.Write("26,");
                    writer.Write("-" + Math.Round(so.FreightAmount, 2) + ",");
                    writer.Write(",");
                    writer.Write(",");
                    writer.Write(this.ISComma(so.InternalNote) + ",");
                    if (so.ShipbyDate != DateTime.MinValue)
                    {
                        writer.Write(so.ShipbyDate.ToShortDateString() + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    writer.Write(",");
                    writer.Write("0.00,");
                    writer.Write(",");
                    writer.Write("0.00,");
                    writer.Write("0.00,");
                    writer.Write("0.00,");
                    writer.Write("False,");
                    writer.WriteLine("False");
                }
                writer.Flush();
                writer.Close();
                flag = true;
            }
            catch (Exception)
            {
                throw;
            }
            return flag;
        }

        private bool SaveItems(SaleOrder so, string FileNameXML)
        {
            bool flag;
            try
            {
                int num = 0;
                if (so.SalesTaxCode != null)
                {
                    num = so.SalesTaxCode.SalesTaxAuthority.Count<SalesTaxAuthority>();
                }
                if (so.FreightAmount > Convert.ToDecimal((double) 0.0))
                {
                    num++;
                }
                if (so.LineItems.Count > 0)
                {
                    num += so.LineItems.Count<SaleOrderlineItem>();
                }
                //PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
                //StreamReader reader = new StreamReader(Application.StartupPath + @"\Item" + peachObj.CurrentCompanyGUID + ".txt");
                //Dictionary<string, string> dictionary = new Dictionary<string, string>();
                //string str = "";
                //while (!reader.EndOfStream)
                //{
                //    str = reader.ReadLine();
                //    dictionary.Add(str.Split(new char[] { 'ƒ' }).GetValue(0).ToString(), str.Split(new char[] { 'ƒ' }).GetValue(1).ToString());
                //}
                //reader.Close();
                StreamWriter writer = new StreamWriter(FileNameXML, true);
                int num2 = 1;
                foreach (SaleOrderlineItem item in so.LineItems)
                {
                    writer.Write(this.ISComma(so.Customer.Id) + ",");
                    writer.Write(this.ISComma(so.Customer.Name) + ",");
                    writer.Write(this.ISComma(so.SaleOrderNo) + ",");
                    writer.Write(so.TransactionDate.ToShortDateString() + ",");
                    writer.Write(so.CloseSO + ",");
                    if (so.QuoteNo != null)
                    {
                        writer.Write(this.ISComma(so.QuoteNo) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    writer.Write(so.DropShip + ",");
                    if (so.ShipAddress.Receipent != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.Receipent) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.AddressLine1 != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.AddressLine1) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.AddressLine2 != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.AddressLine2) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.City != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.City) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.State != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.State) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.Zip != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.Zip) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.Country != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.Country) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.CustomerPO != "")
                    {
                        writer.Write(this.ISComma(so.CustomerPO) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    writer.Write(this.ISComma(so.ShipVia.ShippingMethod) + ",");
                    writer.Write(Math.Round(so.DiscountAmount, 2) + ",");
                    writer.Write(this.ISComma(so.Customer.Term.TermsString) + ",");
                    writer.Write(this.ISComma(so.SalesRep.Id) + ",");
                    writer.Write(so.ARAccount.AccountId + ",");
                    writer.Write(Math.Round(so.TransactionTotal, 2) + ",");
                    writer.Write(so.SalesTaxCode.SalestaxId + ",");
                    writer.Write(this.ISComma(so.CusNote) + ",");
                    writer.Write(so.NotePrintsAfterLineItems + ",");
                    writer.Write(this.ISComma(so.StatementNote) + ",");
                    writer.Write(so.StatementNotePrintsBeforeRef + ",");
                    writer.Write(num + ",");
                    writer.Write(Convert.ToString(num2++) + ",");
                    writer.Write(item.QtyOrderd  + ",");
                    if ((item.Item.GuId == null) || (item.Item.GuId == ""))
                    {
                        writer.Write(",");
                    }
                    else
                    {
                      // writer.Write(this.ISComma(dictionary[item.Item.GuId]) + ",");
                    }
                    String des = "";
                    des = item.LineitemDescription;
                    writer.Write(this.ISComma(des) + ",");

                    writer.Write(item.LineitemAccount.AccountId + ",");

                    writer.Write(item.DiscUnitPrice + ",");
                    writer.Write(item.LineitemTax.Number + ",");
                    if (item.ExtendedAmount > 0M)
                    {
                        writer.Write("-" + Math.Round(item.ExtendedAmount, 2) + ",");
                    }
                    else
                    {
                        writer.Write((Math.Round(item.ExtendedAmount, 2) * -1M) + ",");
                    }
                    string id = "";
                    id = item.Job.Id;
                    writer.Write(this.ISComma(id) + ",");
                    writer.Write(",");
                    writer.Write(so.InternalNote + ",");
                    if (so.ShipbyDate.ToShortDateString() != DateTime.MinValue.ToString())
                    {
                        writer.Write(so.ShipbyDate.ToShortDateString() + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    writer.Write(item.Item.Upcsku + ",");
                    writer.Write(item.Item.Weight + ",");
                    writer.Write(item.Item.StockingUMID + ",");
                    writer.Write("1.00,");
                    writer.Write(item.QtyOrderd + ",");
                    writer.Write(item.DiscUnitPrice + ",");
                    writer.Write("False,");
                    writer.WriteLine("False");
                }
                writer.Flush();
                writer.Close();
                flag = true;
            }
            catch (Exception)
            {
                throw;
            }
            return flag;
        }

        private bool SaveSaleTax(SaleOrder so, string FileNameXML)
        {
            bool flag;
            try
            {
                int num = 0;
                if (so.SalesTaxCode != null)
                {
                    num = so.SalesTaxCode.SalesTaxAuthority.Count<SalesTaxAuthority>();
                }
                if (so.FreightAmount > Convert.ToDecimal((double) 0.0))
                {
                    num++;
                }
                if (so.LineItems.Count > 0)
                {
                    num += so.LineItems.Count<SaleOrderlineItem>();
                }
                StreamWriter writer = new StreamWriter(FileNameXML, false);
                foreach (SalesTaxAuthority authority in so.SalesTaxCode.SalesTaxAuthority)
                {
                    writer.Write(this.ISComma(so.Customer.Id) + ",");
                    writer.Write(this.ISComma(so.Customer.Name) + ",");
                    writer.Write(this.ISComma(so.SaleOrderNo) + ",");
                    writer.Write(so.TransactionDate.ToShortDateString() + ",");
                    writer.Write(so.CloseSO + ",");
                    if (so.QuoteNo != null)
                    {
                        writer.Write(this.ISComma(so.QuoteNo) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    writer.Write(so.DropShip + ",");
                    if (so.ShipAddress.Receipent != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.Receipent) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.AddressLine1 != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.AddressLine1) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.AddressLine2 != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.AddressLine2) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.City != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.City) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.State != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.State) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.Zip != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.Zip) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.ShipAddress.Country != "")
                    {
                        writer.Write(this.ISComma(so.ShipAddress.Country) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (so.CustomerPO != "")
                    {
                        writer.Write(this.ISComma(so.CustomerPO) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    writer.Write(this.ISComma(so.ShipVia.ShippingMethod) + ",");
                    writer.Write(Math.Round(so.DiscountAmount, 2) + ",");
                    writer.Write(this.ISComma(so.Customer.Term.TermsString) + ",");
                    writer.Write(this.ISComma(so.SalesRep.Id) + ",");
                    writer.Write(so.ARAccount.AccountId + ",");
                    writer.Write(Math.Round(so.TransactionTotal, 2) + ",");
                    writer.Write(so.SalesTaxCode.SalestaxId + ",");
                    writer.Write(this.ISComma(so.CusNote) + ",");
                    writer.Write(so.NotePrintsAfterLineItems + ",");
                    writer.Write(this.ISComma(so.StatementNote) + ",");
                    writer.Write(so.StatementNotePrintsBeforeRef + ",");
                    writer.Write(num + ",");
                    writer.Write(0 + ",");
                    writer.Write(0.0 + ",");
                    writer.Write(",");
                    writer.Write(",");
                    writer.Write(authority.AuthorityaccountId + ",");
                    writer.Write("0.00,");
                    writer.Write("0,");
                    writer.Write("-" + Math.Round(authority.GetSalesTaxAtuhorityTotal(so.TaxableItemAmount), 2) + ",");
                    writer.Write(",");
                    writer.Write(authority.AuthorityId + ",");
                    writer.Write(this.ISComma(so.InternalNote) + ",");
                    if (so.ShipbyDate.ToShortDateString() != DateTime.MinValue.ToString())
                    {
                        writer.Write(so.ShipbyDate.ToShortDateString() + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    writer.Write(",");
                    writer.Write("0.00,");
                    writer.Write(",");
                    writer.Write("0.00,");
                    writer.Write("0.00,");
                    writer.Write("0.00,");
                    writer.Write("False,");
                    writer.WriteLine("False");
                }
                writer.Flush();
                writer.Close();
                flag = true;
            }
            catch (Exception)
            {
                throw;
            }
            return flag;
        }
    }
}

