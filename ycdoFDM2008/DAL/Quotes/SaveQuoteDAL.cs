namespace DAL.Quotes
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public class SaveQuoteDAL
    {
        public bool DeleteQuote(Quote qt)
        {
            bool flag2=false ;
            try
            {
                string[] strArray = new string[1];
                //SaveQuote quote = new SaveQuote();
                //string[] recToDel = new string[] { qt.TransactionGUID };
                //Exception exception = new Exception();
                //try
                //{
                //    quote.DeleteQuote(ref recToDel);
                //}
                //catch (Exception exception2)
                //{
                //    exception = exception2;
                //}
                //EditQuoteDAL edal = new EditQuoteDAL();
                //if (!edal.GetIsQuoteExist(qt))
                //{
                //    return true;
                //}
                flag2 = false;
            }
            catch (Exception)
            {
                throw;
            }
            return flag2;
        }

        public string GenerateDiscount(Term term, DateTime dtDate, decimal qtAmount)
        {
            try
            {
                decimal num = Convert.ToDecimal((double) 0.0);
                DateTime date = dtDate;
                DateTime time2 = dtDate;
                CultureInfo invariantCulture = CultureInfo.InvariantCulture;
                if (term.Cod)
                {
                    num = Convert.ToDecimal((double) 0.0);
                    date = dtDate.Date;
                    time2 = dtDate.Date;
                }
                else if (term.Prepaid)
                {
                    num = Convert.ToDecimal((double) 0.0);
                    date = dtDate.Date;
                    time2 = dtDate.Date;
                }
                else
                {
                    int num2;
                    if (!term.TermsType)
                    {
                        if (!term.DuemonthendTerms)
                        {
                            num = (qtAmount * Convert.ToDecimal(term.DiscountPercent)) / 100M;
                            time2 = dtDate.Date.AddDays((double) term.DiscountDays);
                            date = dtDate.Date.AddDays((double) term.DueDays);
                        }
                        else
                        {
                            num = (qtAmount * Convert.ToDecimal(term.DiscountPercent)) / 100M;
                            time2 = dtDate.Date.AddDays((double) term.DiscountDays);
                            if (time2.Month != dtDate.Month)
                            {
                                time2 = dtDate;
                                time2 = time2.AddDays((double) (DateTime.DaysInMonth(dtDate.Year, dtDate.Month) - dtDate.Day));
                            }
                            date = dtDate.Date;
                            num2 = DateTime.DaysInMonth(dtDate.Year, dtDate.Month) - dtDate.Day;
                            if (num2 > 0)
                            {
                                date = dtDate.AddDays((double) num2);
                            }
                        }
                    }
                    else if (!term.DuemonthendTerms)
                    {
                        num = (qtAmount * Convert.ToDecimal(term.DiscountPercent)) / 100M;
                        time2 = dtDate.AddDays((double) term.DiscountDays);
                        date = dtDate.AddMonths(1);
                        date = date.AddDays((double) (term.DueDays - date.Day));
                    }
                    else
                    {
                        num = (qtAmount * Convert.ToDecimal(term.DiscountPercent)) / 100M;
                        time2 = dtDate.AddDays((double) term.DiscountDays);
                        num2 = DateTime.DaysInMonth(dtDate.Year, dtDate.Month) - dtDate.Day;
                        if (num2 > 0)
                        {
                            date = dtDate.AddDays((double) num2);
                        }
                    }
                }
                return (num.ToString() + "ƒ" + date.ToString() + "ƒ" + time2.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "GenerateDiscount");
                return ("0ƒ" + DateTime.MinValue.ToString() + "ƒ" + DateTime.MinValue.ToString());
            }
        }

        private string ISComma(string Value)
        {
            return ("\"" + Value + "\"");
        }

        public string[] ProcessQuote(Quote qt)
        {
            string[] strArray3;
            try
            {
                string[] strArray = new string[1];
                if (qt != null)
                {
 

                    //get frieght Account No. from Items Default.
                    ChartOfAccount freightAcc = new ChartOfAccount();
                    //if (qt.FreightAmount != 0)
                    //{
                    //    qt.FreightAccount = new DefaultAccountsDAL().GetFreightAccount();
                    //    if (qt.FreightAccount.AccountId == null || qt.FreightAccount.AccountId == "")
                    //    {
                    //        MessageBox.Show("Freight Account is not Setup ", "Information");
                    //        return strArray;
                    //    }
                    //}
                    
                    string str = this.GenerateDiscount(qt.Customer.Term, qt.TransactionDate, qt.TransactionTotal);
                    decimal disAmount = Convert.ToDecimal(str.Split(new char[] { 'ƒ' }).GetValue(0));
                    DateTime dueDate = Convert.ToDateTime(str.Split(new char[] { 'ƒ' }).GetValue(1));
                    DateTime disDate = Convert.ToDateTime(str.Split(new char[] { 'ƒ' }).GetValue(2));
                    if ((qt.TransactionGUID == null) || (qt.TransactionGUID == ""))
                    {
                        qt.NotePrintsAfterLineItems = false;
                        qt.StatementNotePrintsBeforeRef = false;
                        qt.CreditMemoType = false;
                        qt.ProgressBillingInvoice = false;
                        qt.RecurFrequency = 0;
                        qt.RecurNumber = 0;
                        qt.ApplyToProposal = false;
                        qt.ApplyToSalesOrder = false;
                        qt.StatementNote = "";
                        qt.InternalNote = "";
                        qt.CusNote = "";
                    }
                    qt = this.RemoveEmptyLines(qt);
                    //SaveQuote quote = new SaveQuote();
                    string transactionGUID = "";
                    transactionGUID = qt.TransactionGUID;
                    //this.SaveSaleTax(qt, disDate, dueDate, disAmount, quote.FileNameCSV);
                    //this.SaveItems(qt, disDate, dueDate, disAmount, quote.FileNameCSV);
                    //this.SaveFreight(qt, disDate, dueDate, disAmount, quote.FileNameCSV);
                    if ((transactionGUID != "") && (transactionGUID != null))
                    {
                        string[] recToDel = new string[] { transactionGUID };
                        Exception exception = new Exception();
                        try
                        {
                           // quote.DeleteQuote(ref recToDel);
                        }
                        catch (Exception exception2)
                        {
                            exception = exception2;
                        }
                        //EditQuoteDAL edal = new EditQuoteDAL();
                        //if (edal.GetIsQuoteExist(qt))
                        //{
                        //    throw new Exception("Record could not be updated.");
                        //}
                        //strArray = quote.ImportQuote();
                    }
                    else
                    {
                       // strArray = quote.ImportQuote();
                    }
                }
                strArray3 = strArray;
                if (strArray.Length > 0)
                {
                    if (strArray[0] != null && strArray[0] != "")
                    {
                        qt.TransactionGUID = strArray[0];
                        //new TransactionLineItemsDAL().SaveQuoteLineItems (qt);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return strArray3;
        }

        private Quote RemoveEmptyLines(Quote qt)
        {
            List<QuoteLineItem> list = new List<QuoteLineItem>();
            foreach (QuoteLineItem item in qt.LineItems)
            {
                if ((((item.Quantity == 0M) && ((item.Item.ItemId == null) || (item.Item.ItemId == ""))) && (((item.LineitemDescription == null) || (item.LineitemDescription == "")) && (item.LineitemPrice == 0M))) && ((item.Job.Id == null) || (item.Job.Id == "")))
                {
                    list.Add(item);
                }
            }
            if (qt.LineItems.Count == list.Count)
            {
                foreach (QuoteLineItem item2 in list)
                {
                    if (qt.LineItems.Count > 1)
                    {
                        qt.DelLineItem(item2);
                    }
                }
                return qt;
            }
            foreach (QuoteLineItem item2 in list)
            {
                qt.DelLineItem(item2);
            }
            return qt;
        }

        private bool SaveFreight(Quote qt, DateTime disDate, DateTime dueDate, decimal disAmount, string filenameCSV)
        {
            bool flag;
            try
            {
                int num = 0;
                if (qt.SalesTaxCode != null)
                {
                    num = qt.SalesTaxCode.SalesTaxAuthority.Count<SalesTaxAuthority>();
                }
                if (qt.FreightAmount > Convert.ToDecimal((double) 0.0))
                {
                    num++;
                }
                if (qt.LineItems.Count > 0)
                {
                    num += qt.LineItems.Count<QuoteLineItem>();
                }
                StreamWriter writer = new StreamWriter(filenameCSV, true);
                if (qt.FreightAmount > Convert.ToDecimal((double) 0.0))
                {
                    writer.Write(this.ISComma(qt.Customer.Id) + ",");
                    writer.Write(this.ISComma(qt.Customer.Name) + ",");
                    writer.Write(",");
                    writer.Write(qt.TransactionDate.ToShortDateString() + ",");
                    writer.Write(true + ",");
                    writer.Write(this.ISComma(qt.QuoteNo) + ",");
                    if (qt.GoodthruDate != DateTime.MinValue)
                    {
                        writer.Write(qt.GoodthruDate.ToShortDateString() + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    writer.Write(qt.DropShip + ",");
                    if (qt.ShipAddress.Receipent != "")
                    {
                        writer.Write(this.ISComma(qt.ShipAddress.Receipent) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (qt.ShipAddress.AddressLine1 != "")
                    {
                        writer.Write(this.ISComma(qt.ShipAddress.AddressLine1) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (qt.ShipAddress.AddressLine2 != "")
                    {
                        writer.Write(this.ISComma(qt.ShipAddress.AddressLine2) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (qt.ShipAddress.City != "")
                    {
                        writer.Write(this.ISComma(qt.ShipAddress.City) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (qt.ShipAddress.State != "")
                    {
                        writer.Write(this.ISComma(qt.ShipAddress.State) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (qt.ShipAddress.Zip != "")
                    {
                        writer.Write(this.ISComma(qt.ShipAddress.Zip) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (qt.ShipAddress.Country != "")
                    {
                        writer.Write(this.ISComma(qt.ShipAddress.Country) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    if (qt.CustomerPO != "")
                    {
                        writer.Write(this.ISComma(qt.CustomerPO) + ",");
                    }
                    else
                    {
                        writer.Write(",");
                    }
                    writer.Write(this.ISComma(qt.ShipVia.ShippingMethod) + ",");
                    writer.Write(dueDate.Date.ToShortDateString() + ",");
                    writer.Write(Math.Round(disAmount, 2) + ",");
                    writer.Write(disDate.Date.ToShortDateString() + ",");
                    writer.Write(this.ISComma(qt.Customer.Term.TermsString) + ",");
                    writer.Write(this.ISComma(qt.SalesRep.Id) + ",");
                    writer.Write(qt.ARAccount.AccountId + ",");
                    writer.Write(Math.Round(qt.TransactionTotal, 2) + ",");
                    writer.Write(qt.SalesTaxCode.SalestaxId + ",");
                    writer.Write(this.ISComma(qt.CusNote) + ",");
                    writer.Write(qt.NotePrintsAfterLineItems + ",");
                    writer.Write(this.ISComma(qt.StatementNote) + ",");
                    writer.Write(qt.StatementNotePrintsBeforeRef + ",");
                    writer.Write(num + ",");
                    writer.Write(0.0 + ",");
                    writer.Write(",");
                    writer.Write(",");
                    writer.Write("Freight Amount,");
                    writer.Write(qt.FreightAccount.AccountId + ",");
                    writer.Write("0.00,");
                    writer.Write("26,");
                    writer.Write("-" + Math.Round(qt.FreightAmount, 2) + ",");
                    writer.Write(",");
                    writer.Write(",");
                    writer.Write(",");
                    writer.Write(",");
                    writer.Write(",");
                    writer.Write(this.ISComma(qt.InternalNote) + ",");
                    writer.Write(",");
                    writer.Write("0.00,");
                    writer.Write("0,");
                    writer.Write("0,");
                    writer.Write("FALSE,");
                    writer.Write(",");
                    writer.Write("0.00,");
                    writer.Write("0.00,");
                    writer.Write("0.00,");
                    writer.Write("0.00,");
                    writer.Write(qt.ProgressBillingInvoice + ",");
                    writer.Write(qt.ApplyToProposal + ",");
                    writer.Write(qt.RecurNumber + ",");
                    writer.WriteLine(qt.RecurFrequency);
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

        private bool SaveItems(Quote qt, DateTime disDate, DateTime dueDate, decimal disAmount, string filenamecsv)
        {
            bool flag;
            try
            {
                int num = 0;
                if (qt.SalesTaxCode != null)
                {
                    num = qt.SalesTaxCode.SalesTaxAuthority.Count<SalesTaxAuthority>();
                }
                if (qt.FreightAmount > Convert.ToDecimal((double) 0.0))
                {
                    num++;
                }
                if (qt.LineItems.Count > 0)
                {
                    num += qt.LineItems.Count<QuoteLineItem>();
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
                StreamWriter writer = new StreamWriter(filenamecsv, true);
                int num2 = 1;
                foreach (QuoteLineItem item in qt.LineItems)
                {
                    if ((item.Item.ItemClass != ItemClass.SerializedStock) && (item.Item.ItemClass != ItemClass.SerializedAssembly))
                    {
                        writer.Write(this.ISComma(qt.Customer.Id) + ",");
                        writer.Write(this.ISComma(qt.Customer.Name) + ",");
                        writer.Write(",");
                        writer.Write(qt.TransactionDate.ToShortDateString() + ",");
                        writer.Write(true + ",");
                        writer.Write(this.ISComma(qt.QuoteNo) + ",");
                        if (qt.GoodthruDate != DateTime.MinValue)
                        {
                            writer.Write(qt.GoodthruDate.ToShortDateString() + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        writer.Write(qt.DropShip + ",");
                        if (qt.ShipAddress.Receipent != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.Receipent) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.ShipAddress.AddressLine1 != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.AddressLine1) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.ShipAddress.AddressLine2 != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.AddressLine2) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.ShipAddress.City != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.City) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.ShipAddress.State != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.State) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.ShipAddress.Zip != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.Zip) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.ShipAddress.Country != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.Country) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.CustomerPO != "")
                        {
                            writer.Write(this.ISComma(qt.CustomerPO) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        writer.Write(this.ISComma(qt.ShipVia.ShippingMethod) + ",");
                        writer.Write(dueDate.Date.ToShortDateString() + ",");
                        writer.Write(Math.Round(disAmount, 2) + ",");
                        writer.Write(disDate.Date.ToShortDateString() + ",");
                        writer.Write(this.ISComma(qt.Customer.Term.TermsString) + ",");
                        writer.Write(this.ISComma(qt.SalesRep.Id) + ",");
                        writer.Write(qt.ARAccount.AccountId + ",");
                        writer.Write(Math.Round(qt.TransactionTotal, 2) + ",");
                        writer.Write(qt.SalesTaxCode.SalestaxId + ",");
                        writer.Write(this.ISComma(qt.CusNote) + ",");
                        writer.Write(qt.NotePrintsAfterLineItems + ",");
                        writer.Write(this.ISComma(qt.StatementNote) + ",");
                        writer.Write(qt.StatementNotePrintsBeforeRef + ",");
                        writer.Write(num + ",");
                        writer.Write(item.Quantity + ",");
                        if ((item.Item.GuId == null) || (item.Item.GuId == ""))
                        {
                            writer.Write(",");
                        }
                        else
                        {
                           // writer.Write(this.ISComma(dictionary[item.Item.GuId]) + ",");
                        }
                        writer.Write(",");

                        String des = "";
                        des = item.LineitemDescription;

                        //if (item.HRBLineNo > 0)
                        //{
                        //    des = des + "*HRB*" + item.HRBLineNo;
                        //}

                        //if (item.Item.ItemClass  == ItemClass.nonstockItem )
                        //    des = des + "*LC*" + item.NewLastUnitCost;


                        writer.Write(this.ISComma(des) + ",");
                        writer.Write(item.LineitemAccount.AccountId + ",");
                        writer.Write(item.LineitemPrice + ",");
                        writer.Write(item.LineitemTax.Number + ",");
                        if (item.Amount > 0M)
                        {
                            writer.Write("-" + Math.Round(item.Amount, 2) + ",");
                        }
                        else
                        {
                            writer.Write((Math.Round(item.Amount, 2) * -1M) + ",");
                        }
                        if (item.HRBLineNo == 0)
                        {
                            writer.Write(",");
                            writer.Write(",");
                        }
                        else
                        {
                            writer.Write(qt.HRobItems[qt.HRobItems.IndexOf(new HRobItem(item.HRBLineNo))].InventoryAccountID + ",");
                            writer.Write(qt.HRobItems[qt.HRobItems.IndexOf(new HRobItem(item.HRBLineNo))].CGSAccountID + ",");
                        }
                        string id = item.Job.Id;
                        writer.Write(this.ISComma(id) + ",");
                        writer.Write(",");
                        writer.Write(",");
                        writer.Write(this.ISComma(qt.InternalNote) + ",");
                        writer.Write(item.Item.Upcsku + ",");
                        writer.Write(item.Item.Weight + ",");
                        writer.Write(Convert.ToString(num2++) + ",");
                        writer.Write("0,");
                        writer.Write("FALSE,");
                        writer.Write(item.Item.StockingUMID + ",");
                        writer.Write("1.00,");
                        writer.Write(item.Quantity + ",");
                        writer.Write(item.LineitemPrice + ",");
                        writer.Write("0.00,");
                        writer.Write(qt.ProgressBillingInvoice + ",");
                        writer.Write(qt.ApplyToProposal + ",");
                        writer.Write(qt.RecurNumber + ",");
                        writer.WriteLine(qt.RecurFrequency);
                    }
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

        private bool SaveSaleTax(Quote qt, DateTime disDate, DateTime dueDate, decimal disAmount, string filenameCSV)
        {
            bool flag;
            try
            {
                int num = 0;
                if (qt.SalesTaxCode != null)
                {
                    num = qt.SalesTaxCode.SalesTaxAuthority.Count<SalesTaxAuthority>();
                }
                if (qt.FreightAmount > Convert.ToDecimal((double) 0.0))
                {
                    num++;
                }
                if (qt.LineItems.Count > 0)
                {
                    num += qt.LineItems.Count<QuoteLineItem>();
                }
                StreamWriter writer = new StreamWriter(filenameCSV, false);
                if (qt.SalesTaxCode != null)
                {
                    foreach (SalesTaxAuthority authority in qt.SalesTaxCode.SalesTaxAuthority)
                    {
                        writer.Write(this.ISComma(qt.Customer.Id) + ",");
                        writer.Write(this.ISComma(qt.Customer.Name) + ",");
                        writer.Write(",");
                        writer.Write(qt.TransactionDate.ToShortDateString() + ",");
                        writer.Write(true + ",");
                        writer.Write(this.ISComma(qt.QuoteNo) + ",");
                        if (qt.GoodthruDate != DateTime.MinValue)
                        {
                            writer.Write(qt.GoodthruDate.ToShortDateString() + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        writer.Write(qt.DropShip + ",");
                        if (qt.ShipAddress.Receipent != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.Receipent) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.ShipAddress.AddressLine1 != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.AddressLine1) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.ShipAddress.AddressLine2 != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.AddressLine2) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.ShipAddress.City != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.City) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.ShipAddress.State != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.State) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.ShipAddress.Zip != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.Zip) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.ShipAddress.Country != "")
                        {
                            writer.Write(this.ISComma(qt.ShipAddress.Country) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        if (qt.CustomerPO != "")
                        {
                            writer.Write(this.ISComma(qt.CustomerPO) + ",");
                        }
                        else
                        {
                            writer.Write(",");
                        }
                        writer.Write(this.ISComma(qt.ShipVia.ShippingMethod) + ",");
                        writer.Write(dueDate.Date.ToShortDateString() + ",");
                        writer.Write(Math.Round(disAmount, 2) + ",");
                        writer.Write(disDate.Date.ToShortDateString() + ",");
                        writer.Write(this.ISComma(qt.Customer.Term.TermsString) + ",");
                        writer.Write(this.ISComma(qt.SalesRep.Id) + ",");
                        writer.Write(qt.ARAccount.AccountId + ",");
                        writer.Write(Math.Round(qt.TransactionTotal, 2) + ",");
                        writer.Write(qt.SalesTaxCode.SalestaxId + ",");
                        writer.Write(this.ISComma(qt.CusNote) + ",");
                        writer.Write(qt.NotePrintsAfterLineItems + ",");
                        writer.Write(this.ISComma(qt.StatementNote) + ",");
                        writer.Write(qt.StatementNotePrintsBeforeRef + ",");
                        writer.Write(num + ",");
                        writer.Write(0.0 + ",");
                        writer.Write(",");
                        writer.Write(",");
                        writer.Write(",");
                        writer.Write(authority.AuthorityaccountId + ",");
                        writer.Write("0.00,");
                        writer.Write("0,");
                        decimal salesTaxAmount = qt.SalesTaxAmount;
                        writer.Write("-" + Math.Round(authority.GetSalesTaxAtuhorityTotal(qt.TaxableItemAmount), 2) + ",");
                        writer.Write(",");
                        writer.Write(",");
                        writer.Write(",");
                        writer.Write(authority.AuthorityId + ",");
                        writer.Write(",");
                        writer.Write(this.ISComma(qt.InternalNote) + ",");
                        writer.Write(",");
                        writer.Write("0.00,");
                        writer.Write("0,");
                        writer.Write("0,");
                        writer.Write("FALSE,");
                        writer.Write(",");
                        writer.Write("0.00,");
                        writer.Write("0.00,");
                        writer.Write("0.00,");
                        writer.Write("0.00,");
                        writer.Write(qt.ProgressBillingInvoice + ",");
                        writer.Write(qt.ApplyToProposal + ",");
                        writer.Write(qt.RecurNumber + ",");
                        writer.WriteLine(qt.RecurFrequency);
                    }
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

        private bool SaveSerialzeItems(Quote qt, DateTime disDate, DateTime dueDate, decimal disAmount, string filenameCSV)
        {
            bool flag;
            try
            {
                int num = 0;
                if (qt.SalesTaxCode != null)
                {
                    num = qt.SalesTaxCode.SalesTaxAuthority.Count<SalesTaxAuthority>();
                }
                if (qt.FreightAmount > Convert.ToDecimal((double) 0.0))
                {
                    num++;
                }
                if (qt.LineItems.Count > 0)
                {
                    num += qt.LineItems.Count<QuoteLineItem>();
                }
                StreamWriter writer = new StreamWriter(filenameCSV, true);
                int num2 = 1;
                foreach (QuoteLineItem item in qt.LineItems)
                {
                    if ((item.Item.ItemClass == ItemClass.SerializedStock) || (item.Item.ItemClass == ItemClass.SerializedAssembly))
                    {
                        for (int i = 1; i <= item.Quantity; i++)
                        {
                            writer.Write(this.ISComma(qt.Customer.Id) + ",");
                            writer.Write(this.ISComma(qt.Customer.Name) + ",");
                            writer.Write(",");
                            writer.Write(qt.TransactionDate.ToShortDateString() + ",");
                            writer.Write(true + ",");
                            writer.Write(this.ISComma(qt.QuoteNo) + ",");
                            if (qt.GoodthruDate != DateTime.MinValue)
                            {
                                writer.Write(qt.GoodthruDate.ToShortDateString() + ",");
                            }
                            else
                            {
                                writer.Write(",");
                            }
                            writer.Write(qt.DropShip + ",");
                            if (qt.ShipAddress.Receipent != "")
                            {
                                writer.Write(this.ISComma(qt.ShipAddress.Receipent) + ",");
                            }
                            else
                            {
                                writer.Write(",");
                            }
                            if (qt.ShipAddress.AddressLine1 != "")
                            {
                                writer.Write(this.ISComma(qt.ShipAddress.AddressLine1) + ",");
                            }
                            else
                            {
                                writer.Write(",");
                            }
                            if (qt.ShipAddress.AddressLine2 != "")
                            {
                                writer.Write(this.ISComma(qt.ShipAddress.AddressLine2) + ",");
                            }
                            else
                            {
                                writer.Write(",");
                            }
                            if (qt.ShipAddress.City != "")
                            {
                                writer.Write(this.ISComma(qt.ShipAddress.City) + ",");
                            }
                            else
                            {
                                writer.Write(",");
                            }
                            if (qt.ShipAddress.State != "")
                            {
                                writer.Write(this.ISComma(qt.ShipAddress.State) + ",");
                            }
                            else
                            {
                                writer.Write(",");
                            }
                            if (qt.ShipAddress.Zip != "")
                            {
                                writer.Write(this.ISComma(qt.ShipAddress.Zip) + ",");
                            }
                            else
                            {
                                writer.Write(",");
                            }
                            if (qt.ShipAddress.Country != "")
                            {
                                writer.Write(this.ISComma(qt.ShipAddress.Country) + ",");
                            }
                            else
                            {
                                writer.Write(",");
                            }
                            if (qt.CustomerPO != "")
                            {
                                writer.Write(this.ISComma(qt.CustomerPO) + ",");
                            }
                            else
                            {
                                writer.Write(",");
                            }
                            writer.Write(this.ISComma(qt.ShipVia.ShippingMethod) + ",");
                            writer.Write(dueDate.Date.ToShortDateString() + ",");
                            writer.Write(Math.Round(disAmount, 2) + ",");
                            writer.Write(disDate.Date.ToShortDateString() + ",");
                            writer.Write(this.ISComma(qt.Customer.Term.TermsString) + ",");
                            writer.Write(this.ISComma(qt.SalesRep.Id) + ",");
                            writer.Write(qt.ARAccount.AccountId + ",");
                            writer.Write(Math.Round(qt.TransactionTotal, 2) + ",");
                            writer.Write(qt.SalesTaxCode.SalestaxId + ",");
                            writer.Write(this.ISComma(qt.CusNote) + ",");
                            writer.Write(qt.NotePrintsAfterLineItems + ",");
                            writer.Write(this.ISComma(qt.StatementNote) + ",");
                            writer.Write(qt.StatementNotePrintsBeforeRef + ",");
                            writer.Write(num + ",");
                            writer.Write(item.Quantity + ",");
                            writer.Write(item.Item.ItemId + ",");
                            writer.Write("-dummy" + num2++ + ",");
                            writer.Write(this.ISComma(item.LineitemDescription) + ",");
                            writer.Write(item.LineitemAccount.AccountId + ",");
                            writer.Write(item.LineitemPrice + ",");
                            writer.Write(item.LineitemTax.Number + ",");
                            writer.Write("-" + Math.Round(item.Amount, 2) + ",");
                            string id = item.Job.Id;
                            writer.Write(this.ISComma(id) + ",");
                            writer.Write(",");
                            writer.Write(",");
                            writer.Write(this.ISComma(qt.InternalNote) + ",");
                            writer.Write(item.Item.Upcsku + ",");
                            writer.Write(item.Item.Weight + ",");
                            writer.Write(Convert.ToString(num2++) + ",");
                            writer.Write("0,");
                            writer.Write("FALSE,");
                            writer.Write(item.Item.StockingUMID + ",");
                            writer.Write("1.00,");
                            writer.Write(item.Quantity + ",");
                            writer.Write(item.LineitemPrice + ",");
                            writer.Write("0.00,");
                            writer.Write(qt.ProgressBillingInvoice + ",");
                            writer.Write(qt.ApplyToProposal + ",");
                            writer.Write(qt.RecurNumber + ",");
                            writer.WriteLine(qt.RecurFrequency);
                        }
                    }
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

