namespace DAL.SaleInvoices
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using DAL.Items;
    using DAL.UpdateDB;

    //public class EditSaleInvoiceDAL
    //{
    //    private EditSaleInvoice editSaleInvoice;
    //    private PeachtreeSingleTon peachobj;
    //    private CashReceiptJournal recpt;
    //    private SaleInvoice saleinvoice;
    //    private List<SaleInvoice> saleinvoices;

    //    public bool GetIsSaleInvoiceExist(SaleInvoice si)
    //    {
    //        try
    //        {
    //            this.peachobj = new PeachtreeSingleTon();
    //            this.editSaleInvoice = new EditSaleInvoice();
    //            if (this.editSaleInvoice.ExportSaleInvGuid(si.TransactionDate, si.TransactionDate, si.SaleInvoiceNo, si.Customer.Id))
    //            {
    //                this.saleinvoices = new List<SaleInvoice>();


    //                XDocument xdoc = XDocument.Load(editSaleInvoice.FileNameXML);


    //                var invElement = from el in xdoc.Descendants ("PAW_Invoice")
    //                                 select el;
    //                foreach (XElement element2 in invElement)
    //                {
    //                    if ((((si.TransactionGUID == element2.Element("GUID").Value) && (element2.Element("isQuote").Value.ToString().ToUpper() == "FALSE")) && (element2.Element("CreditMemoType").Value.ToString().ToUpper() == "FALSE")) && (element2.Element("ProgressBillingInvoice").Value.ToUpper() == "FALSE"))
    //                    {
    //                        return true;
    //                    }
    //                }
    //            }
    //            return false;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetIsSaleInvoiceExist");
    //            return false;
    //        }
    //    }

    //    public SaleInvoice GetSaleInvoice(SaleInvoice si)
    //    {
    //        try
    //        {
    //           List<SaleInvoiceLineItem >siLnDB= new TransactionLineItemsDAL().GetSaleInvoiceLineItems(si);
    //            List<Item > itemsinDB =new LocalDBDAL().GetItems();

    //            this.peachobj = new PeachtreeSingleTon();
    //            this.editSaleInvoice = new EditSaleInvoice();

    //            if (this.editSaleInvoice.ExportEditSaleInvoice(si.SaleInvoiceNo, si.Customer.Id, si.TransactionDate, si.TransactionDate))
    //            {
    //                this.saleinvoices = new List<SaleInvoice>();

    //                XDocument xdoc = XDocument.Load(editSaleInvoice.FileNameXML);

    //                var invElement = from el in xdoc.Descendants("PAW_Invoice")
    //                                 select el;

    //                foreach (XElement element2 in invElement)
    //                {
    //                    if ((((si.TransactionGUID == element2.Element("GUID").Value) && (element2.Element("isQuote").Value.ToString().ToUpper() == "FALSE")) && (element2.Element("CreditMemoType").Value.ToString().ToUpper() == "FALSE")) && (element2.Element("ProgressBillingInvoice").Value.ToUpper() == "FALSE"))
    //                    {
    //                        this.saleinvoice = new SaleInvoice();
    //                        IEnumerable<XElement> enumerable2 = element2.Descendants("SalesLine").Select<XElement, XElement>(delegate(XElement saleline)
    //                        {
    //                            return saleline;
    //                        });
                            
    //                        int siLiNo = -1;
    //                        int soLiNo = -1;
    //                        foreach (XElement element3 in enumerable2)
    //                        {
    //                            if (Convert.ToInt32(element3.Element("Tax_Type").Value) == 0)
    //                            {
    //                                if (Math.Round(Convert.ToDecimal(element3.Element("Amount").Value), 2) < 0M)
    //                                {
    //                                    this.saleinvoice.SalesTaxAmount += Convert.ToDecimal((double)-1.0) * Math.Round(Convert.ToDecimal(element3.Element("Amount").Value), 2);
    //                                }
    //                                else
    //                                {
    //                                    this.saleinvoice.SalesTaxAmount -= Convert.ToDecimal((double)1.0) * Math.Round(Convert.ToDecimal(element3.Element("Amount").Value), 2);
    //                                }
    //                            }
    //                            else if (Convert.ToInt32(element3.Element("Tax_Type").Value) == 0x1a)
    //                            {
    //                                if (Math.Round(Convert.ToDecimal(element3.Element("Amount").Value), 2) < 0M)
    //                                {
    //                                    this.saleinvoice.FreightAmount = Math.Round((decimal)(Convert.ToDecimal((double)-1.0) * Convert.ToDecimal(element3.Element("Amount").Value)), 2);
    //                                }
    //                                else
    //                                {
    //                                    this.saleinvoice.FreightAmount = Convert.ToDecimal((double)-1.0) * Math.Round(Convert.ToDecimal(element3.Element("Amount").Value), 2);
    //                                }
    //                            }
    //                            else
    //                            {
    //                                SaleInvoiceLineItem item;

                                   

    //                                if (element3.Element("Apply_To_Sales_Order").Value == "FALSE")
    //                                {
    //                                    item = new SaleInvoiceLineItem(SaleInLineItemType.Sales);
    //                                    item.Quantity = Convert.ToDecimal(element3.Element("Quantity").Value);
    //                                    item.LineitemNo =( element3.Element("InvoiceCMDistribution") == null ? 0 :Convert.ToInt32 ( element3.Element("InvoiceCMDistribution").Value))-1;
    //                                }
    //                                else
    //                                {
    //                                    item = new SaleInvoiceLineItem(SaleInLineItemType.SO);
    //                                    item.Quantity = Convert.ToDecimal(element3.Element("Quantity").Value);
    //                                    item.LineitemNo = (element3.Element("SalesOrderDistributionNumber") == null  ? 0 : Convert.ToInt32(element3.Element("SalesOrderDistributionNumber").Value))-1;
                                        
    //                                }
                                    

    //                                item.SalesOrderDistributionNumber = (element3.Element("SalesOrderDistributionNumber") == null) ? 0 : Convert.ToInt32(element3.Element("SalesOrderDistributionNumber").Value);

    //                                if ((this.saleinvoice.SaleOrderNo == null) || (this.saleinvoice.SaleOrderNo == ""))
    //                                {
    //                                    this.saleinvoice.SaleOrderNo = (element3.Element("SalesOrderNumber") == null) ? "" : element3.Element("SalesOrderNumber").Value;
    //                                }
    //                                if (Convert.ToDecimal(element3.Element("Amount").Value) < 0M)
    //                                {
    //                                    item.ExtendedAmount = (element3.Element("Amount") == null) ? Convert.ToDecimal((double)0.0) : Math.Round((decimal)(Convert.ToDecimal((double)-1.0) * Convert.ToDecimal(element3.Element("Amount").Value)), 2);
    //                                }
    //                                else
    //                                {
    //                                    item.ExtendedAmount = (element3.Element("Amount") == null) ? Convert.ToDecimal((double)0.0) : (Convert.ToDecimal((double)-1.0) * Math.Round(Convert.ToDecimal(element3.Element("Amount").Value), 2));
    //                                }
    //                                item.Item.ItemId = (element3.Element("Item_ID") == null) ? "" : element3.Element("Item_ID").Value;
    //                                item.LineitemDescription = (element3.Element("Description") == null) ? "" : element3.Element("Description").Value;



    //                                item.Item.GuId = (element3.Element("Item_GUID") == null) ? "" : element3.Element("Item_GUID").Value;
    //                                item.LineitemAccount.AccountId = (element3.Element("GL_Account") == null) ? "" : element3.Element("GL_Account").Value;
    //                                item.LineitemAccount.GuId = (element3.Element("GL_Account_GUID") == null) ? "" : element3.Element("GL_Account_GUID").Value;
    //                                item.LineitemPrice = (element3.Element("Unit_Price") == null) ? Convert.ToDecimal((double)0.0) : Convert.ToDecimal(element3.Element("Unit_Price").Value);
    //                                item.LineitemTax.Number = (element3.Element("Tax_Type") == null) ? Convert.ToInt16(1) : Convert.ToInt16(element3.Element("Tax_Type").Value);
    //                                item.Item.Weight = (element3.Element("Weight") == null) ? Convert.ToDecimal((double)0.0) : Convert.ToDecimal(element3.Element("Weight").Value);
    //                                item.Item.StockingUMID = (element3.Element("UM_ID") == null) ? "" : element3.Element("UM_ID").Value;
    //                                item.Job.Id = (element3.Element("Job_ID") == null) ? "" : element3.Element("Job_ID").Value;
    //                                item.Job.GuId = (element3.Element("Job_GUID") == null) ? "" : element3.Element("Job_GUID").Value;

    //                                if (itemsinDB.Contains(item.Item) == true)
    //                                {
    //                                    item.Item.PriceLevels = itemsinDB[itemsinDB.IndexOf(item.Item)].PriceLevels;
    //                                    item.Item.ItemClass = itemsinDB[itemsinDB.IndexOf(item.Item)].ItemClass;
    //                                    item.Item.PrimaryAttribute = itemsinDB[itemsinDB.IndexOf(item.Item)].PrimaryAttribute;
    //                                    item.Item.MasterStockGUID = itemsinDB[itemsinDB.IndexOf(item.Item)].MasterStockGUID;
    //                                    item.Item.SecondaryAttribute = itemsinDB[itemsinDB.IndexOf(item.Item)].SecondaryAttribute;
    //                                }

    //                                //if (item.SaleInvoiceLineItemType == SaleInLineItemType.Sales)
    //                                //{
    //                                //    siLiNo = item.GetNextLineItemNo(item, siLiNo, siLnDB);
    //                                //    item.LineitemNo = siLiNo;

    //                                //}
    //                                //else
    //                                //{
    //                                //    soLiNo = item.GetNextLineItemNo(item, soLiNo, siLnDB);
    //                                //    item.LineitemNo = soLiNo;
    //                                //}

    //                                if (siLnDB.Contains(item) == true)
    //                                {
    //                                    item.DiscPct = siLnDB[siLnDB.IndexOf(item)].DiscPct;
    //                                    item.DiscUnitPrice = siLnDB[siLnDB.IndexOf(item)].DiscUnitPrice;
    //                                    item.LineitemPrice = siLnDB[siLnDB.IndexOf(item)].LineitemPrice;
    //                                    item.FrameColor.Description = siLnDB[siLnDB.IndexOf(item)].FrameColor.Description;
    //                                    item.FrameColor.Id = siLnDB[siLnDB.IndexOf(item)].FrameColor.Id;
    //                                    item.FrameColor.Type = AttributeType.Secondary;
    //                                    item.Amount = siLnDB[siLnDB.IndexOf(item)].Amount;
    //                                    item.ExtendedAmount = siLnDB[siLnDB.IndexOf(item)].ExtendedAmount;
    //                                }
    //                                else
    //                                {
    //                                    //if sale line items does not found data base then
    //                                    //set ExtAmt to amoutn and LinePrice to DiscUnitPrice
    //                                    item.Amount = item.ExtendedAmount;
    //                                    item.DiscUnitPrice = item.LineitemPrice;
    //                                }

    //                                this.saleinvoice.AssignToLineItem(this.saleinvoice);
    //                                if (!this.saleinvoice.IsSameSerialStockLineItemExist(item))
    //                                {
    //                                    this.saleinvoice.LineItemTotalAmount += item.ExtendedAmount;
    //                                    this.saleinvoice.LineItems.Add(item);
    //                                }
    //                                if (element3.Element("Apply_To_Sales_Order").Value == "FALSE")
    //                                {
    //                                    //   num2 = (short)(num2 + 1);
    //                                }
    //                                else
    //                                {
    //                                    // liNo = (short)(liNo + 1);
    //                                }

    //                            }
    //                        }
    //                        this.saleinvoice.QuoteNo = (element2.Element("Quote_Number") == null) ? "" : element2.Element("Quote_Number").Value;
    //                        this.saleinvoice.ShipDate = (element2.Element("Ship_Date") == null) ? DateTime.MinValue : Convert.ToDateTime(element2.Element("Ship_Date").Value);
    //                        this.saleinvoice.DueDate = Convert.ToDateTime(element2.Element("Date_Due").Value);
    //                        this.saleinvoice.DiscountDate = Convert.ToDateTime(element2.Element("Discount_Date").Value);
    //                        this.saleinvoice.DiscountAmount = Convert.ToDecimal(element2.Element("Discount_Amount").Value);
    //                        this.saleinvoice.Customer.Id = element2.Element("Customer_ID").Value;
    //                        this.saleinvoice.Customer.Name = (element2.Element("Customer_Name") == null) ? "" : element2.Element("Customer_Name").Value;
    //                        this.saleinvoice.TransactionDate = Convert.ToDateTime(element2.Element("Date").Value);
    //                        this.saleinvoice.SaleInvoiceNo = (element2.Element("Invoice_Number") == null) ? "" : element2.Element("Invoice_Number").Value;
    //                        this.saleinvoice.DropShip = Convert.ToBoolean(element2.Element("Drop_Ship").Value);
    //                        this.saleinvoice.CustomerPO = (element2.Element("Customer_PO") == null) ? "" : element2.Element("Customer_PO").Value;
    //                        this.saleinvoice.ShipVia.ShippingMethod = (element2.Element("Ship_Via") == null) ? "" : element2.Element("Ship_Via").Value;
    //                        this.saleinvoice.Customer.Term.TermsString = (element2.Element("Displayed_Terms") == null) ? "" : element2.Element("Displayed_Terms").Value;
    //                        this.saleinvoice.ARAccount.AccountId = (element2.Element("Accounts_Receivable_Account") == null) ? "" : element2.Element("Accounts_Receivable_Account").Value;
    //                        this.saleinvoice.SalesRep.Id = (element2.Element("Sales_Representative_ID") == null) ? "" : element2.Element("Sales_Representative_ID").Value;
    //                        if (element2.Element("Accounts_Receivable_Amount") == null)
    //                        {
    //                            this.saleinvoice.TransactionTotal = Convert.ToDecimal((double)0.0);
    //                        }
    //                        else
    //                        {
    //                            this.saleinvoice.TransactionTotal = Math.Round(Convert.ToDecimal(element2.Element("Accounts_Receivable_Amount").Value), 2);
    //                        }
    //                        this.saleinvoice.NotePrintsAfterLineItems = Convert.ToBoolean(element2.Element("Note_Prints_After_Line_Items").Value);
    //                        this.saleinvoice.StatementNotePrintsBeforeRef = Convert.ToBoolean(element2.Element("Statement_Note_Prints_Before_Ref").Value);
    //                        this.saleinvoice.TransactionGUID = element2.Element("GUID").Value;
    //                        this.saleinvoice.CreditMemoType = Convert.ToBoolean(element2.Element("CreditMemoType").Value);
    //                        this.saleinvoice.ProgressBillingInvoice = Convert.ToBoolean(element2.Element("ProgressBillingInvoice").Value);
    //                        this.saleinvoice.RecurNumber = Convert.ToInt32(element2.Element("Recur_Number").Value);
    //                        this.saleinvoice.RecurFrequency = Convert.ToInt32(element2.Element("Recur_Frequency").Value);
    //                        IEnumerable<XElement> enumerable3 = element2.Descendants("ShipToAddress").Select<XElement, XElement>(delegate(XElement shi)
    //                        {
    //                            return shi;
    //                        });
    //                        foreach (XElement element4 in enumerable3)
    //                        {
    //                            this.saleinvoice.SalesTaxCode.SalestaxId = (element4.Element("Sales_Tax_Code") == null) ? "" : element4.Element("Sales_Tax_Code").Value;
    //                            this.saleinvoice.ShipAddress.AddressLine1 = (element4.Element("Line1") == null) ? "" : element4.Element("Line1").Value;
    //                            this.saleinvoice.ShipAddress.AddressLine2 = (element4.Element("Line2") == null) ? "" : element4.Element("Line2").Value;
    //                            this.saleinvoice.ShipAddress.City = (element4.Element("City") == null) ? "" : element4.Element("City").Value;
    //                            this.saleinvoice.ShipAddress.State = (element4.Element("State") == null) ? "" : element4.Element("State").Value;
    //                            this.saleinvoice.ShipAddress.Zip = (element4.Element("Zip") == null) ? "" : element4.Element("Zip").Value;
    //                            this.saleinvoice.ShipAddress.Country = (element4.Element("Country") == null) ? "" : element4.Element("Country").Value;
    //                            this.saleinvoice.ShipAddress.Receipent = (element4.Element("Name") == null) ? "" : element4.Element("Name").Value;
    //                        }
    //                        this.saleinvoice.AssignToLineItem(this.saleinvoice);
    //                    }
    //                }
    //            }
    //            return this.saleinvoice;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSaleInvoice");
    //            return this.saleinvoice;
    //        }
    //    }


    //    public SaleInvoice GetSaleInvoicePrint(SaleInvoice si)
    //    {
    //        try
    //        {
    //            List<SaleInvoiceLineItem> siLnDB = new TransactionLineItemsDAL().GetSaleInvoiceLineItems(si);
    //            List<Item> itemsinDB = new LocalDBDAL().GetItems();

    //            this.peachobj = new PeachtreeSingleTon();
    //            this.editSaleInvoice = new EditSaleInvoice();

    //            if (this.editSaleInvoice.ExportEditSaleInvoice(si.SaleInvoiceNo, si.Customer.Id, si.TransactionDate, si.TransactionDate))
    //            {
    //                this.saleinvoices = new List<SaleInvoice>();

    //                XDocument xdoc = XDocument.Load(editSaleInvoice.FileNameXML);

    //                var invElement = from el in xdoc.Descendants("PAW_Invoice")
    //                                 select el;

    //                foreach (XElement element2 in invElement)
    //                {
    //                    if ((((si.TransactionGUID == element2.Element("GUID").Value) && (element2.Element("isQuote").Value.ToString().ToUpper() == "FALSE")) && (element2.Element("CreditMemoType").Value.ToString().ToUpper() == "FALSE")) && (element2.Element("ProgressBillingInvoice").Value.ToUpper() == "FALSE"))
    //                    {
    //                        this.saleinvoice = new SaleInvoice();
    //                        IEnumerable<XElement> enumerable2 = element2.Descendants("SalesLine").Select<XElement, XElement>(delegate(XElement saleline)
    //                        {
    //                            return saleline;
    //                        });

                         
    //                        foreach (XElement element3 in enumerable2)
    //                        {
    //                            if (Convert.ToInt32(element3.Element("Tax_Type").Value) == 0)
    //                            {
    //                                if (Math.Round(Convert.ToDecimal(element3.Element("Amount").Value), 2) < 0M)
    //                                {
    //                                    this.saleinvoice.SalesTaxAmount += Convert.ToDecimal((double)-1.0) * Math.Round(Convert.ToDecimal(element3.Element("Amount").Value), 2);
    //                                }
    //                                else
    //                                {
    //                                    this.saleinvoice.SalesTaxAmount -= Convert.ToDecimal((double)1.0) * Math.Round(Convert.ToDecimal(element3.Element("Amount").Value), 2);
    //                                }
    //                            }
    //                            else if (Convert.ToInt32(element3.Element("Tax_Type").Value) == 0x1a)
    //                            {
    //                                if (Math.Round(Convert.ToDecimal(element3.Element("Amount").Value), 2) < 0M)
    //                                {
    //                                    this.saleinvoice.FreightAmount = Math.Round((decimal)(Convert.ToDecimal((double)-1.0) * Convert.ToDecimal(element3.Element("Amount").Value)), 2);
    //                                }
    //                                else
    //                                {
    //                                    this.saleinvoice.FreightAmount = Convert.ToDecimal((double)-1.0) * Math.Round(Convert.ToDecimal(element3.Element("Amount").Value), 2);
    //                                }
    //                            }
    //                            else
    //                            {
    //                                SaleInvoiceLineItem item;



    //                                if (element3.Element("Apply_To_Sales_Order").Value == "FALSE")
    //                                {
    //                                    item = new SaleInvoiceLineItem(SaleInLineItemType.Sales);
    //                                    item.Quantity = Convert.ToDecimal(element3.Element("Quantity").Value);
    //                                    item.LineitemNo = (element3.Element("InvoiceCMDistribution") == null ? 0 : Convert.ToInt32(element3.Element("InvoiceCMDistribution").Value)) - 1;
    //                                }
    //                                else
    //                                {
    //                                    item = new SaleInvoiceLineItem(SaleInLineItemType.SO);
    //                                    item.Quantity = Convert.ToDecimal(element3.Element("Quantity").Value);
    //                                    item.LineitemNo = (element3.Element("SalesOrderDistributionNumber") == null ? 0 : Convert.ToInt32(element3.Element("SalesOrderDistributionNumber").Value)) - 1;
    //                                }

    //                                item.SalesOrderDistributionNumber = (element3.Element("SalesOrderDistributionNumber") == null) ? 0 : Convert.ToInt32(element3.Element("SalesOrderDistributionNumber").Value);

    //                                if ((this.saleinvoice.SaleOrderNo == null) || (this.saleinvoice.SaleOrderNo == ""))
    //                                {
    //                                    this.saleinvoice.SaleOrderNo = (element3.Element("SalesOrderNumber") == null) ? "" : element3.Element("SalesOrderNumber").Value;
    //                                }
    //                                if (Convert.ToDecimal(element3.Element("Amount").Value) < 0M)
    //                                {
    //                                    item.ExtendedAmount = (element3.Element("Amount") == null) ? Convert.ToDecimal((double)0.0) : Math.Round((decimal)(Convert.ToDecimal((double)-1.0) * Convert.ToDecimal(element3.Element("Amount").Value)), 2);
    //                                }
    //                                else
    //                                {
    //                                    item.ExtendedAmount = (element3.Element("Amount") == null) ? Convert.ToDecimal((double)0.0) : (Convert.ToDecimal((double)-1.0) * Math.Round(Convert.ToDecimal(element3.Element("Amount").Value), 2));
    //                                }
    //                                item.Item.ItemId = (element3.Element("Item_ID") == null) ? "" : element3.Element("Item_ID").Value;
    //                                item.LineitemDescription = (element3.Element("Description") == null) ? "" : element3.Element("Description").Value;



    //                                item.Item.GuId = (element3.Element("Item_GUID") == null) ? "" : element3.Element("Item_GUID").Value;
    //                                item.LineitemAccount.AccountId = (element3.Element("GL_Account") == null) ? "" : element3.Element("GL_Account").Value;
    //                                item.LineitemAccount.GuId = (element3.Element("GL_Account_GUID") == null) ? "" : element3.Element("GL_Account_GUID").Value;
    //                                item.LineitemPrice = (element3.Element("Unit_Price") == null) ? Convert.ToDecimal((double)0.0) : Convert.ToDecimal(element3.Element("Unit_Price").Value);
    //                                item.LineitemTax.Number = (element3.Element("Tax_Type") == null) ? Convert.ToInt16(1) : Convert.ToInt16(element3.Element("Tax_Type").Value);
    //                                item.Item.Weight = (element3.Element("Weight") == null) ? Convert.ToDecimal((double)0.0) : Convert.ToDecimal(element3.Element("Weight").Value);
    //                                item.Item.StockingUMID = (element3.Element("UM_ID") == null) ? "" : element3.Element("UM_ID").Value;
    //                                item.Job.Id = (element3.Element("Job_ID") == null) ? "" : element3.Element("Job_ID").Value;
    //                                item.Job.GuId = (element3.Element("Job_GUID") == null) ? "" : element3.Element("Job_GUID").Value;

    //                                if (itemsinDB.Contains(item.Item) == true)
    //                                {
    //                                    item.Item.PriceLevels = itemsinDB[itemsinDB.IndexOf(item.Item)].PriceLevels;
    //                                    item.Item.ItemClass = itemsinDB[itemsinDB.IndexOf(item.Item)].ItemClass;
    //                                    item.Item.PrimaryAttribute = itemsinDB[itemsinDB.IndexOf(item.Item)].PrimaryAttribute;
    //                                    item.Item.MasterStockGUID = itemsinDB[itemsinDB.IndexOf(item.Item)].MasterStockGUID;
    //                                    item.Item.SecondaryAttribute = itemsinDB[itemsinDB.IndexOf(item.Item)].SecondaryAttribute;
    //                                }

                                   

    //                                if (siLnDB.Contains(item) == true)
    //                                {
    //                                    item.DiscPct = siLnDB[siLnDB.IndexOf(item)].DiscPct;
    //                                    item.DiscUnitPrice = siLnDB[siLnDB.IndexOf(item)].DiscUnitPrice;
    //                                    item.LineitemPrice = siLnDB[siLnDB.IndexOf(item)].LineitemPrice;
    //                                    item.FrameColor.Description = siLnDB[siLnDB.IndexOf(item)].FrameColor.Description;
    //                                    item.FrameColor.Id = siLnDB[siLnDB.IndexOf(item)].FrameColor.Id;
    //                                    item.FrameColor.Type = AttributeType.Secondary;
    //                                }

    //                                this.saleinvoice.AssignToLineItem(this.saleinvoice);
    //                                if (!this.saleinvoice.IsSameSerialStockLineItemExist(item))
    //                                {
    //                                    this.saleinvoice.LineItemTotalAmount += item.ExtendedAmount;
    //                                    this.saleinvoice.LineItems.Add(item);
    //                                }
                                    

    //                            }
    //                        }
    //                        this.saleinvoice.QuoteNo = (element2.Element("Quote_Number") == null) ? "" : element2.Element("Quote_Number").Value;
    //                        this.saleinvoice.ShipDate = (element2.Element("Ship_Date") == null) ? DateTime.MinValue : Convert.ToDateTime(element2.Element("Ship_Date").Value);
    //                        this.saleinvoice.DueDate = Convert.ToDateTime(element2.Element("Date_Due").Value);
    //                        this.saleinvoice.DiscountDate = Convert.ToDateTime(element2.Element("Discount_Date").Value);
    //                        this.saleinvoice.DiscountAmount = Convert.ToDecimal(element2.Element("Discount_Amount").Value);
    //                        this.saleinvoice.Customer.Id = element2.Element("Customer_ID").Value;
    //                        this.saleinvoice.Customer.Name = (element2.Element("Customer_Name") == null) ? "" : element2.Element("Customer_Name").Value;
    //                        this.saleinvoice.TransactionDate = Convert.ToDateTime(element2.Element("Date").Value);
    //                        this.saleinvoice.SaleInvoiceNo = (element2.Element("Invoice_Number") == null) ? "" : element2.Element("Invoice_Number").Value;
    //                        this.saleinvoice.DropShip = Convert.ToBoolean(element2.Element("Drop_Ship").Value);
    //                        this.saleinvoice.CustomerPO = (element2.Element("Customer_PO") == null) ? "" : element2.Element("Customer_PO").Value;
    //                        this.saleinvoice.ShipVia.ShippingMethod = (element2.Element("Ship_Via") == null) ? "" : element2.Element("Ship_Via").Value;
    //                        this.saleinvoice.Customer.Term.TermsString = (element2.Element("Displayed_Terms") == null) ? "" : element2.Element("Displayed_Terms").Value;
    //                        this.saleinvoice.ARAccount.AccountId = (element2.Element("Accounts_Receivable_Account") == null) ? "" : element2.Element("Accounts_Receivable_Account").Value;
    //                        this.saleinvoice.SalesRep.Id = (element2.Element("Sales_Representative_ID") == null) ? "" : element2.Element("Sales_Representative_ID").Value;
    //                        if (element2.Element("Accounts_Receivable_Amount") == null)
    //                        {
    //                            this.saleinvoice.TransactionTotal = Convert.ToDecimal((double)0.0);
    //                        }
    //                        else
    //                        {
    //                            this.saleinvoice.TransactionTotal = Math.Round(Convert.ToDecimal(element2.Element("Accounts_Receivable_Amount").Value), 2);
    //                        }
    //                        this.saleinvoice.NotePrintsAfterLineItems = Convert.ToBoolean(element2.Element("Note_Prints_After_Line_Items").Value);
    //                        this.saleinvoice.StatementNotePrintsBeforeRef = Convert.ToBoolean(element2.Element("Statement_Note_Prints_Before_Ref").Value);
    //                        this.saleinvoice.TransactionGUID = element2.Element("GUID").Value;
    //                        this.saleinvoice.CreditMemoType = Convert.ToBoolean(element2.Element("CreditMemoType").Value);
    //                        this.saleinvoice.ProgressBillingInvoice = Convert.ToBoolean(element2.Element("ProgressBillingInvoice").Value);
    //                        this.saleinvoice.RecurNumber = Convert.ToInt32(element2.Element("Recur_Number").Value);
    //                        this.saleinvoice.RecurFrequency = Convert.ToInt32(element2.Element("Recur_Frequency").Value);
    //                        IEnumerable<XElement> enumerable3 = element2.Descendants("ShipToAddress").Select<XElement, XElement>(delegate(XElement shi)
    //                        {
    //                            return shi;
    //                        });
    //                        foreach (XElement element4 in enumerable3)
    //                        {
    //                            this.saleinvoice.SalesTaxCode.SalestaxId = (element4.Element("Sales_Tax_Code") == null) ? "" : element4.Element("Sales_Tax_Code").Value;
    //                            this.saleinvoice.ShipAddress.AddressLine1 = (element4.Element("Line1") == null) ? "" : element4.Element("Line1").Value;
    //                            this.saleinvoice.ShipAddress.AddressLine2 = (element4.Element("Line2") == null) ? "" : element4.Element("Line2").Value;
    //                            this.saleinvoice.ShipAddress.City = (element4.Element("City") == null) ? "" : element4.Element("City").Value;
    //                            this.saleinvoice.ShipAddress.State = (element4.Element("State") == null) ? "" : element4.Element("State").Value;
    //                            this.saleinvoice.ShipAddress.Zip = (element4.Element("Zip") == null) ? "" : element4.Element("Zip").Value;
    //                            this.saleinvoice.ShipAddress.Country = (element4.Element("Country") == null) ? "" : element4.Element("Country").Value;
    //                            this.saleinvoice.ShipAddress.Receipent = (element4.Element("Name") == null) ? "" : element4.Element("Name").Value;
    //                        }
    //                        this.saleinvoice.AssignToLineItem(this.saleinvoice);
    //                    }
    //                }
    //            }
    //            return this.saleinvoice;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSaleInvoicePrint");
    //            return this.saleinvoice;
    //        }
    //    }



    //    public List<SaleInvoice> GetSaleInvShipedWithSaleOrder(SaleOrder so)
    //    {
    //        try
    //        {
    //            this.peachobj = new PeachtreeSingleTon();
    //            this.editSaleInvoice = new EditSaleInvoice();
    //            if (this.editSaleInvoice.ExportEditSaleInvoice(so.Customer.Id, this.peachobj.GetFirstDay(), this.peachobj.GetLastDay()))
    //            {
    //                this.saleinvoices = new List<SaleInvoice>();


    //                XDocument xdoc = XDocument.Load(editSaleInvoice.FileNameXML);

    //                var invElement = from el in xdoc.Descendants("PAW_Invoice")
    //                                 select el;

    //                foreach (XElement element2 in invElement)
    //                {
    //                    if (((element2.Element("isQuote").Value.ToString().ToUpper() == "FALSE") && (element2.Element("CreditMemoType").Value.ToString().ToUpper() == "FALSE")) && (element2.Element("ProgressBillingInvoice").Value.ToUpper() == "FALSE"))
    //                    {
    //                        this.saleinvoice = new SaleInvoice();
    //                        IEnumerable<XElement> enumerable2 = element2.Descendants("SalesLine").Select<XElement, XElement>(delegate (XElement saleline) {
    //                            return saleline;
    //                        });
    //                        short liNo = 0;
    //                        //this.saleinvoice.Customer.Id = element2.Element("Customer_ID").Value;
    //                        //this.saleinvoice.TransactionDate = Convert.ToDateTime(element2.Element("Date").Value);
    //                        //this.saleinvoice.SaleInvoiceNo = (element2.Element("Invoice_Number") == null) ? "" : element2.Element("Invoice_Number").Value;
    //                        //this.saleinvoice.TransactionGUID = element2.Element("GUID").Value;
    //                        foreach (XElement element3 in enumerable2)
    //                        {
    //                            //if (Convert.ToInt32(element3.Element("Tax_Type").Value) == 0)
    //                            //{
    //                            //    this.saleinvoice.SalesTaxAmount += Convert.ToDecimal(-1) * Math.Round(Convert.ToDecimal(element3.Element("Amount").Value), 2);
    //                            //}
    //                            //else if (Convert.ToInt32(element3.Element("Tax_Type").Value) == 0x1a)
    //                            //{
    //                            //    this.saleinvoice.FreightAmount = Math.Round((decimal) (Convert.ToDecimal(-1) * Convert.ToDecimal(element3.Element("Amount").Value)), 2);
    //                            //}
    //                            //else
    //                            if(Convert.ToInt32(element3.Element("Tax_Type").Value)!=26 && Convert.ToInt32(element3.Element("Tax_Type").Value)!=0)
    //                            {
    //                                if ((this.saleinvoice.SaleOrderNo == null) || (this.saleinvoice.SaleOrderNo == ""))
    //                                {
    //                                    this.saleinvoice.SaleOrderNo = (element3.Element("SalesOrderNumber") == null) ? "" : element3.Element("SalesOrderNumber").Value;
    //                                }
    //                                if (((this.saleinvoice.SaleOrderNo != "") && (so.SaleOrderNo == this.saleinvoice.SaleOrderNo)) && (element3.Element("Apply_To_Sales_Order").Value == "TRUE"))
    //                                {
    //                                    SaleInvoiceLineItem item = new SaleInvoiceLineItem(SaleInLineItemType.SO, liNo);
    //                                    item.Quantity = Convert.ToDecimal(element3.Element("Quantity").Value);
    //                                    item.SalesOrderDistributionNumber = (element3.Element("SalesOrderDistributionNumber") == null) ? 0 : Convert.ToInt32(element3.Element("SalesOrderDistributionNumber").Value);
    //                                    item.Item.ItemId = (element3.Element("Item_ID") == null) ? "" : element3.Element("Item_ID").Value;
    //                                    item.Item.GuId = (element3.Element("Item_GUID") == null) ? "" : element3.Element("Item_GUID").Value;
    //                                    this.saleinvoice.LineItems.Add(item);
    //                                }
    //                            }
    //                        }
    //                        if (this.saleinvoice.LineItems.Count > 0)
    //                        {
    //                            this.saleinvoices.Add(this.saleinvoice);
    //                        }
    //                    }
    //                }
    //            }
    //            return this.saleinvoices;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSaleInvShipedWithSaleOrder");
    //            return this.saleinvoices;
    //        }
    //    }

    //    public List<SaleInvoice> GetSaleInvShortList(DateTime startdate, DateTime enddate)
    //    {
    //        try
    //        {
    //            this.editSaleInvoice = new EditSaleInvoice();
    //            this.peachobj = new PeachtreeSingleTon();
    //            if (this.editSaleInvoice.ExportEditSaleInvShortList(startdate, enddate))
    //            {
    //                this.saleinvoices = new List<SaleInvoice>();
    //                XDocument xdoc = XDocument.Load(editSaleInvoice.FileNameXML);

    //                var invElement = from el in xdoc.Descendants("PAW_Invoice")
    //                                 select el;

    //                foreach (XElement element2 in invElement)
    //                {
    //                    if (((element2.Element("isQuote").Value.ToString().ToUpper() == "FALSE") && (element2.Element("CreditMemoType").Value.ToString().ToUpper() == "FALSE")) && (element2.Element("ProgressBillingInvoice").Value.ToUpper() == "FALSE"))
    //                    {
    //                        this.saleinvoice = new SaleInvoice();
    //                        this.saleinvoice.Customer.Id = element2.Element("Customer_ID").Value;
    //                        this.saleinvoice.TransactionDate = Convert.ToDateTime(element2.Element("Date").Value);
    //                        this.saleinvoice.SaleInvoiceNo = (element2.Element("Invoice_Number") == null) ? "" : element2.Element("Invoice_Number").Value;
    //                        if (element2.Element("Accounts_Receivable_Amount") == null)
    //                        {
    //                            this.saleinvoice.TransactionTotal = Convert.ToDecimal((double) 0.0);
    //                        }
    //                        else
    //                        {
    //                            this.saleinvoice.TransactionTotal = Math.Round(Convert.ToDecimal(element2.Element("Accounts_Receivable_Amount").Value), 2);
    //                        }
    //                        this.saleinvoice.TransactionGUID = element2.Element("GUID").Value;
    //                        this.saleinvoices.Add(this.saleinvoice);
    //                    }
    //                }
    //            }
    //            return this.saleinvoices;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSaleInvShortList");
    //            return this.saleinvoices;
    //        }
    //    }

    //    public bool SaleInvHasRecept(ref  SaleInvoice si)
    //    {
    //        try
    //        {
    //            this.peachobj = new PeachtreeSingleTon();
    //            this.recpt = new CashReceiptJournal();
    //            if (this.recpt.ExportReceipt(si.Customer.Id, this.peachobj.GetFirstDay(), this.peachobj.GetLastDay()))
    //            {
    //                XDocument xdoc = XDocument.Load(recpt.FileNameXML);

    //                var invElement = from el in xdoc.Descendants("PAW_Receipt")
    //                                 select el;

    //                foreach (XElement element2 in invElement)
    //                {
    //                    if (element2.Element("Customer_ID") != null)
    //                    {
                            
    //                        IEnumerable<XElement> enumerable2 = element2.Descendants("Distributions").Select<XElement, XElement>(delegate(XElement saleline)
    //                        {
    //                            return saleline;
    //                        });
    //                        foreach (XElement element3 in element2.Element("Distributions").Elements())
    //                        {
    //                            //.Element("Distribution")
    //                            if (!(element3.Element("InvoicePaid").Value == ""))
    //                            {
    //                                if (si.Customer.Id == element2.Element("Customer_ID").Value.ToString () && element3.Element("InvoicePaid").Value.ToString () == si.SaleInvoiceNo)
    //                                {
    //                                    si.Receipt.CashAmount =Convert.ToDecimal ( element2.Element("Cash_Amount").Value);
    //                                    return true;}
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //            return false;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "SaleInvHasRecept");
    //            return false;
    //        }
    //    }



    
    //}
}

