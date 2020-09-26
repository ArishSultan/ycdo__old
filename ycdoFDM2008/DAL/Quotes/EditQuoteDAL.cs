namespace DAL.Quotes
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using DAL.Items;

    //public class EditQuoteDAL
    //{
    //    private EditQuote editQuote;
    //    private PeachtreeSingleTon peachobj;
    //    private Quote quote;
    //    private List<Quote> quotes;

    //    public bool GetIsQuoteExist(Quote qt)
    //    {
    //        try
    //        {
    //            this.peachobj = new PeachtreeSingleTon();
    //            this.editQuote = new EditQuote();
    //            if (this.editQuote.ExportQuoteGUID(qt.TransactionDate, qt.TransactionDate, qt.Customer.Id))
    //            {

    //                XDocument xdoc = XDocument.Load(editQuote.FileNameXML);
    //                var invElement = from el in xdoc.Descendants("PAW_Invoice")
    //                                 select el;

    //                foreach (XElement element2 in invElement)
    //                {
    //                    if ((element2.Element("isQuote").Value.ToString().ToUpper() == "TRUE") && (element2.Element("GUID").Value == qt.TransactionGUID))
    //                    {
    //                        return true;
    //                    }
    //                }
    //            }
    //            return false;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetIsQuoteExist");
    //            return false;
    //        }
    //    }

    //    public Quote GetQuote(Quote qt)
    //    {
    //        try
    //        {
    //            List<QuoteLineItem > qtLnItmsDB = new TransactionLineItemsDAL().GetQuoteLineItems (qt);

    //            this.peachobj = new PeachtreeSingleTon();
    //            this.editQuote = new EditQuote();
    //            if (this.editQuote.ExportEditQuote(qt.Customer.Id, qt.TransactionDate, qt.TransactionDate))
    //            {

    //                XDocument xdoc = XDocument.Load(editQuote.FileNameXML);
    //                var invElement = from el in xdoc.Descendants("PAW_Invoice")
    //                                 select el;

    //                this.quote = new Quote();
    //                foreach (XElement element2 in invElement)
    //                {
    //                    if ((element2.Element("isQuote").Value.ToString().ToUpper() == "TRUE") && (element2.Element("GUID").Value == qt.TransactionGUID))
    //                    {
    //                        this.quote = new Quote();
    //                        this.quote.Customer.Id = element2.Element("Customer_ID").Value;
    //                        this.quote.Customer.Name = (element2.Element("Customer_Name") == null) ? "" : element2.Element("Customer_Name").Value;
    //                        this.quote.TransactionDate = Convert.ToDateTime(element2.Element("Date").Value);
    //                        this.quote.GoodthruDate = (element2.Element("Quote_Good_Thru_Date") == null) ? DateTime.MinValue : Convert.ToDateTime(element2.Element("Quote_Good_Thru_Date").Value);
    //                        this.quote.DropShip = Convert.ToBoolean(element2.Element("Drop_Ship").Value);
    //                        this.quote.CustomerPO = (element2.Element("Customer_PO") == null) ? "" : element2.Element("Customer_PO").Value;
    //                        this.quote.ShipVia.ShippingMethod = (element2.Element("Ship_Via") == null) ? "" : element2.Element("Ship_Via").Value;
    //                        this.quote.QuoteNo = (element2.Element("Quote_Number") == null) ? "" : element2.Element("Quote_Number").Value;
    //                        this.quote.Customer.Term.TermsString = (element2.Element("Displayed_Terms") == null) ? "" : element2.Element("Displayed_Terms").Value;
    //                        this.quote.ARAccount.AccountId = (element2.Element("Accounts_Receivable_Account") == null) ? "" : element2.Element("Accounts_Receivable_Account").Value;
    //                        this.quote.SalesRep.Id = (element2.Element("Sales_Representative_ID") == null) ? "" : element2.Element("Sales_Representative_ID").Value;
    //                        if (element2.Element("Accounts_Receivable_Amount") == null)
    //                        {
    //                            this.quote.TransactionTotal = Convert.ToDecimal((double) 0.0);
    //                        }
    //                        else
    //                        {
    //                            this.quote.TransactionTotal = Math.Round(Convert.ToDecimal(element2.Element("Accounts_Receivable_Amount").Value), 2);
    //                        }
    //                        this.quote.NotePrintsAfterLineItems = Convert.ToBoolean(element2.Element("Note_Prints_After_Line_Items").Value);
    //                        this.quote.StatementNotePrintsBeforeRef = Convert.ToBoolean(element2.Element("Statement_Note_Prints_Before_Ref").Value);
    //                        this.quote.TransactionGUID = element2.Element("GUID").Value;
    //                        this.quote.CreditMemoType = Convert.ToBoolean(element2.Element("CreditMemoType").Value);
    //                        this.quote.ProgressBillingInvoice = Convert.ToBoolean(element2.Element("ProgressBillingInvoice").Value);
    //                        this.quote.RecurNumber = Convert.ToInt32(element2.Element("Recur_Number").Value);
    //                        this.quote.RecurFrequency = Convert.ToInt32(element2.Element("Recur_Frequency").Value);
    //                        IEnumerable<XElement> enumerable2 = element2.Descendants("ShipToAddress").Select<XElement, XElement>(delegate (XElement shi) {
    //                            return shi;
    //                        });
    //                        foreach (XElement element3 in enumerable2)
    //                        {
    //                            this.quote.SalesTaxCode.SalestaxId = (element3.Element("Sales_Tax_Code") == null) ? "" : element3.Element("Sales_Tax_Code").Value;
    //                            this.quote.ShipAddress.Receipent = (element3.Element("Name") == null) ? "" : element3.Element("Name").Value;
    //                            this.quote.ShipAddress.AddressLine1 = (element3.Element("Line1") == null) ? "" : element3.Element("Line1").Value;
    //                            this.quote.ShipAddress.AddressLine2 = (element3.Element("Line2") == null) ? "" : element3.Element("Line2").Value;
    //                            this.quote.ShipAddress.City = (element3.Element("City") == null) ? "" : element3.Element("City").Value;
    //                            this.quote.ShipAddress.State = (element3.Element("State") == null) ? "" : element3.Element("State").Value;
    //                            this.quote.ShipAddress.Zip = (element3.Element("Zip") == null) ? "" : element3.Element("Zip").Value;
    //                            this.quote.ShipAddress.Country = (element3.Element("Country") == null) ? "" : element3.Element("Country").Value;
    //                        }
    //                        IEnumerable<XElement> enumerable3 = element2.Descendants("SalesLine").Select<XElement, XElement>(delegate (XElement saleline) {
    //                            return saleline;
    //                        });


    //                        short liNo = 0;
    //                        foreach (XElement element4 in enumerable3)
    //                        {
    //                            if (Convert.ToInt32(element4.Element("Tax_Type").Value) == 0)
    //                            {
    //                                if (Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2) < 0M)
    //                                {
    //                                    this.quote.SalesTaxAmount += Convert.ToDecimal((double) -1.0) * Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2);
    //                                }
    //                                else
    //                                {
    //                                    this.quote.SalesTaxAmount -= Convert.ToDecimal((double) 1.0) * Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2);
    //                                }
    //                            }
    //                            else if (Convert.ToInt32(element4.Element("Tax_Type").Value) == 0x1a)
    //                            {
    //                                if (Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2) < 0M)
    //                                {
    //                                    this.quote.FreightAmount = Math.Round((decimal) (Convert.ToDecimal((double) -1.0) * Convert.ToDecimal(element4.Element("Amount").Value)), 2);
    //                                }
    //                                else
    //                                {
    //                                    this.quote.FreightAmount = Convert.ToDecimal((double) -1.0) * Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2);
    //                                }
    //                            }
    //                            else
    //                            {
    //                                QuoteLineItem qli = new QuoteLineItem(liNo);
    //                                if (Convert.ToDecimal(element4.Element("Amount").Value) < 0M)
    //                                {
    //                                    qli.Amount = (element4.Element("Amount") == null) ? Convert.ToDecimal((double) 0.0) : Math.Round((decimal) (Convert.ToDecimal((double) -1.0) * Convert.ToDecimal(element4.Element("Amount").Value)), 2);
    //                                }
    //                                else
    //                                {
    //                                    qli.Amount = (element4.Element("Amount") == null) ? Convert.ToDecimal((double) 0.0) : Math.Round((decimal) (Convert.ToDecimal((double) -1.0) * Convert.ToDecimal(element4.Element("Amount").Value)), 2);
    //                                }
    //                                qli.Quantity = Convert.ToDecimal(element4.Element("Quantity").Value);
    //                                qli.Item.ItemId = (element4.Element("Item_ID") == null) ? "" : element4.Element("Item_ID").Value;
    //                                qli.Item.GuId = (element4.Element("Item_GUID") == null) ? "" : element4.Element("Item_GUID").Value;
    //                                qli.Item.StockingUMID = (element4.Element("UM_ID") == null) ? "" : element4.Element("UM_ID").Value;
    //                                qli.LineitemPrice = (element4.Element("Unit_Price") == null) ? Convert.ToDecimal((double) 0.0) : Convert.ToDecimal(element4.Element("Unit_Price").Value);
    //                                qli.LineitemDescription = (element4.Element("Description") == null) ? "" : element4.Element("Description").Value;


    //                                if (qli.LineitemDescription.Contains("*LC*"))
    //                                {
    //                                    qli.NewLastUnitCost  = Convert.ToDecimal (qli.LineitemDescription.Substring(qli.LineitemDescription.IndexOf("*LC*")+4));
    //                                    qli.LineitemDescription = qli.LineitemDescription.Remove (qli.LineitemDescription.IndexOf("*LC*"));
    //                                }

    //                                if (qli.LineitemDescription.Contains("*HRB*"))
    //                                {
    //                                    qli.HRBLineNo = Convert.ToInt32(qli.LineitemDescription.Substring(qli.LineitemDescription.Length - 1, 1));
    //                                    qli.LineitemDescription = qli.LineitemDescription.Replace("*HRB*" + qli.HRBLineNo, "");
    //                                }
    //                                qli.LineitemAccount.AccountId = (element4.Element("GL_Account") == null) ? "" : element4.Element("GL_Account").Value;
    //                                qli.LineitemAccount.GuId = (element4.Element("GL_Account_GUID") == null) ? "" : element4.Element("GL_Account_GUID").Value;
    //                                qli.LineitemTax.Number = (element4.Element("Tax_Type") == null) ? Convert.ToInt16(1) : Convert.ToInt16(element4.Element("Tax_Type").Value);
    //                                qli.Item.Weight = (element4.Element("Weight") == null) ? Convert.ToDecimal((double) 0.0) : Convert.ToDecimal(element4.Element("Weight").Value);
    //                                qli.Job.Id = (element4.Element("Job_ID") == null) ? "" : element4.Element("Job_ID").Value;
    //                                qli.Job.GuId = (element4.Element("Job_GUID") == null) ? "" : element4.Element("Job_GUID").Value;
    //                                ItemPriceLevel level = new ItemPriceLevel();
    //                                if (level.ExportInventoryItemPrices(qli.Item.ItemId))
    //                                {
    //                                    qli.Item.PriceLevels = new ItemPriceLevelsDAL().GetItemPriceLevels(qli.Item);
    //                                }
    //                                Item itemClass = new ItemsDAL().GetItemClass(qli.Item);
    //                                if (itemClass != null)
    //                                {
    //                                    qli.Item.ItemClass = itemClass.ItemClass;
    //                                }


    //                                if (qtLnItmsDB.Contains(qli) == true)
    //                                {
    //                                    qli.NewLastUnitCost = qtLnItmsDB[qtLnItmsDB.IndexOf(qli)].NewLastUnitCost;
    //                                    qli.HRBLineNo = qtLnItmsDB[qtLnItmsDB.IndexOf(qli)].HRBLineNo;
    //                                }

    //                                if (!this.quote.IsSameSerialStockLineItemExist(qli))
    //                                {
    //                                    this.quote.LineItemTotalAmount += qli.Amount;
    //                                    this.quote.LineItems.Add(qli);
    //                                    liNo = (short) (liNo + 1);
    //                                }
    //                            }
    //                        }
    //                        this.quote.AssignToLineItem(this.quote);
    //                    }
    //                }
    //            }
    //            return this.quote;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetQuote");
    //            return this.quote;
    //        }
    //    }

    //    public List<Quote> GetQuotesShortList(DateTime fromdate, DateTime enddate)
    //    {
    //        try
    //        {
    //            this.peachobj = new PeachtreeSingleTon();
    //            this.editQuote = new EditQuote();
    //            if (this.editQuote.ExportEditQuoteShortList(fromdate, enddate))
    //            {
    //                this.quotes = new List<Quote>();

    //                XDocument xdoc = XDocument.Load(editQuote.FileNameXML);
    //                var invElement = from el in xdoc.Descendants("PAW_Invoice")
    //                                 select el;

    //                foreach (XElement element2 in invElement)
    //                {
    //                    if (element2.Element("isQuote").Value.ToString().ToUpper() == "TRUE")
    //                    {
    //                        this.quote = new Quote();
    //                        this.quote.Customer.Id = element2.Element("Customer_ID").Value;
    //                        this.quote.TransactionDate = Convert.ToDateTime(element2.Element("Date").Value);
    //                        this.quote.QuoteNo = (element2.Element("Quote_Number") == null) ? "" : element2.Element("Quote_Number").Value;
    //                        if (element2.Element("Accounts_Receivable_Amount") == null)
    //                        {
    //                            this.quote.TransactionTotal = Convert.ToDecimal((double) 0.0);
    //                        }
    //                        else
    //                        {
    //                            this.quote.TransactionTotal = Math.Round(Convert.ToDecimal(element2.Element("Accounts_Receivable_Amount").Value), 2);
    //                        }
    //                        this.quote.TransactionGUID = element2.Element("GUID").Value;
    //                        this.quotes.Add(this.quote);
    //                    }
    //                }
    //            }
    //            return this.quotes;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetQuotesShortList");
    //            return this.quotes;
    //        }
    //    }
    //}
}

