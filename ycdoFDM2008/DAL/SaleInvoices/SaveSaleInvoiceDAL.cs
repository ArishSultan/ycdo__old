namespace DAL.SaleInvoices
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using DAL.UpdateDB;
    using DAL.Items;
    using OleDbHelper;
    using System.Data.OleDb;
    using System.Data;
    

    //public class SaveSaleInvoiceDAL
    //{
    //    private OleDbCommand cmd;
    //    private OleDbConnection con;
    //    private OleDbDataAdapter da;
    //    private DataTable dt;
    //    private ReadConfigFile readconfile;

    //    private OleDbTransaction tran;
    //    PeachtreeSingleTon peachObj;


    //    public bool DeleteSaleInvoice(SaleInvoice sai)
    //    {
    //        bool flag2;
    //        try
    //        {
    //            SaveSaleInvoice invoice = new SaveSaleInvoice();
    //            string[] recToDel = new string[] { sai.TransactionGUID };
    //            Exception exception = new Exception();
    //            try
    //            {
    //                invoice.DeleteSaleInvoice(ref recToDel);
    //            }
    //            catch (Exception exception2)
    //            {
    //                exception = exception2;
    //            }
    //            EditSaleInvoiceDAL edal = new EditSaleInvoiceDAL();
    //            if (!edal.GetIsSaleInvoiceExist(sai))
    //            {
    //                return true;
    //            }
    //            flag2 = false;
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return flag2;
    //    }

    //    public string GenerateDiscount(Term term, DateTime dtDate, decimal qtAmount)
    //    {
    //        decimal num = Convert.ToDecimal((double) 0.0);
    //        DateTime date = dtDate;
    //        DateTime time2 = dtDate;
    //        CultureInfo invariantCulture = CultureInfo.InvariantCulture;
    //        if (term.Cod)
    //        {
    //            num = Convert.ToDecimal((double) 0.0);
    //            date = dtDate.Date;
    //            time2 = dtDate.Date;
    //        }
    //        else if (term.Prepaid)
    //        {
    //            num = Convert.ToDecimal((double) 0.0);
    //            date = dtDate.Date;
    //            time2 = dtDate.Date;
    //        }
    //        else
    //        {
    //            string str;
    //            if (!term.TermsType)
    //            {
    //                if (!term.DuemonthendTerms)
    //                {
    //                    num = (qtAmount * Convert.ToDecimal(term.DiscountPercent)) / 100M;
    //                    time2 = dtDate.Date.AddDays((double) term.DiscountDays);
    //                    date = dtDate.Date.AddDays((double) term.DueDays);
    //                }
    //                else
    //                {
    //                    num = (qtAmount * Convert.ToDecimal(term.DiscountPercent)) / 100M;
    //                    time2 = dtDate.Date.AddDays((double) term.DiscountDays);
    //                    date = dtDate.Date.AddDays((double) term.DueDays);
    //                    str = string.Format(dtDate.Date.Date.ToString(), invariantCulture.DateTimeFormat.ShortDatePattern);
    //                    date = Convert.ToDateTime(string.Concat(new object[] { DateTime.DaysInMonth(dtDate.Year, dtDate.Month).ToString(), "/", str.Split(new char[] { '/' }).GetValue(1), "/", str.Split(new char[] { '/' }).GetValue(2) }));
    //                    time2 = dtDate.AddDays((double) term.DiscountDays);
    //                }
    //            }
    //            else if (!term.DuemonthendTerms)
    //            {
    //                num = (qtAmount * Convert.ToDecimal(term.DiscountPercent)) / 100M;
    //                time2 = dtDate.AddDays((double) term.DiscountDays);
    //                str = string.Format(dtDate.AddMonths(1).Date.ToString(), invariantCulture.DateTimeFormat.ShortDatePattern);
    //                if (invariantCulture.DateTimeFormat.ShortDatePattern.ToString().Split(invariantCulture.DateTimeFormat.DateSeparator.ToCharArray()).GetValue(0).ToString().ToLower().StartsWith("d"))
    //                {
    //                    date = Convert.ToDateTime(string.Concat(new object[] { term.DueDays.ToString(), "/", str.Split(new char[] { '/' }).GetValue(1), "/", str.Split(new char[] { '/' }).GetValue(2) }));
    //                }
    //                else if (invariantCulture.DateTimeFormat.ShortDatePattern.ToString().Split(invariantCulture.DateTimeFormat.DateSeparator.ToCharArray()).GetValue(1).ToString().ToLower().StartsWith("d"))
    //                {
    //                    date = Convert.ToDateTime(string.Concat(new object[] { str.Split(new char[] { '/' }).GetValue(1), "/", term.DueDays.ToString(), "/", str.Split(new char[] { '/' }).GetValue(2) }));
    //                }
    //                else
    //                {
    //                    date = Convert.ToDateTime(string.Concat(new object[] { str.Split(new char[] { '/' }).GetValue(1), "/", str.Split(new char[] { '/' }).GetValue(2), "/", term.DueDays.ToString() }));
    //                }
    //            }
    //        }
    //        return (num.ToString() + "ƒ" + date.ToString() + "ƒ" + time2.ToString());
    //    }

    //    private string ISComma(string Value)
    //    {
    //        return ("\"" + Value + "\"");
    //    }

    //    public string[] ProcessSaleInvoice(SaleInvoice sai)
    //    {
    //        string[] strArray3;
    //        try
    //        {

                
    //            string[] strArray = new string[1];

    //             //get frieght Account No. from Items Default.
    //            ChartOfAccount freightAcc = new ChartOfAccount();
    //            if (sai.FreightAmount != 0)
    //            {
    //               sai.FreightAccount   = new DefaultAccountsDAL().GetFreightAccount();
    //               if (sai.FreightAccount.AccountId == null || sai.FreightAccount.AccountId == "")
    //                {
    //                    MessageBox.Show("Freight Account is not Setup ", "Information");
    //                    return strArray;
    //                }
    //            }


    //            if (sai != null)
    //            {
    //                if ((sai.TransactionGUID == null) || (sai.TransactionGUID == ""))
    //                {
    //                    sai.NotePrintsAfterLineItems = false;
    //                    sai.StatementNotePrintsBeforeRef = false;
    //                    sai.CreditMemoType = false;
    //                    sai.ProgressBillingInvoice = false;
    //                    sai.RecurFrequency = 0;
    //                    sai.RecurNumber = 0;
    //                    sai.ApplyToProposal = false;
    //                    sai.ApplyToSalesOrder = false;
    //                    sai.StatementNote = "";
    //                    sai.InternalNote = "";
    //                    sai.CusNote = "";
    //                }
    //                sai = this.RemoveEmptyLines(sai);
    //                SaveSaleInvoice invoice = new SaveSaleInvoice();
    //                string transactionGUID = "";
    //                transactionGUID = sai.TransactionGUID;

    //                //faheem June 06 , 2011 -start

    //                int siLn = 0, soLn=0;
    //                for (int i = 0; i < sai.LineItems.Count; i++)
    //                {
    //                    //i need to save Line numbers of SaleLines without being gaps that may occur
    //                    //due to remove of SaleLine or adding new ones.
    //                    //e.g. line number can be in this sequence 0 ,3 , 5 ,2 for sales Lines
    //                    //and 11,34,42 for sale order lines.
    //                    //we want to save in this pattern 0,1,2,3 for sales lines
    //                    //and 0,1,2 for sale order lines.

    //                    if (sai.LineItems[i].SaleInvoiceLineItemType == SaleInLineItemType.Sales)
    //                        sai.LineItems[i].LineitemNo = siLn++;
    //                    else
    //                        sai.LineItems[i].LineitemNo = soLn++;
    //                }
    //                //end of June 06, 2011 by faheem.

    //                //create CSV for Saleinvoice
    //                //Step -1 Save Sales Tax lines in Sale Invoice CSV
    //                this.SaveSaleTax(sai, sai.DiscountDate, sai.DueDate, sai.DiscountAmount, invoice.FileNameCSV);
    //                //Step -2 Save  line Items in Sale Invoice CSV
    //                this.SaveItems(sai, sai.DiscountDate, sai.DueDate, sai.DiscountAmount, invoice.FileNameCSV);
    //                //Step -3 Save freight line in Sale Invoice CSV
    //                this.SaveFreight(sai, sai.DiscountDate, sai.DueDate, sai.DiscountAmount, invoice.FileNameCSV);



 
    //                try
    //                {
    //                    this.readconfile = new ReadConfigFile();
    //                    this.con = new OleDbConnection();
    //                    this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //                    if (this.con.ConnectionString != "")
    //                    {
    //                        peachObj = new PeachtreeSingleTon();
    //                        string companyGuid = peachObj.CurrentCompanyGUID;
    //                        if (companyGuid != null && companyGuid != "")
    //                        {
    //                            this.con.Open();
    //                            this.cmd = new OleDbCommand();
    //                            if (this.con.State == ConnectionState.Open)
    //                            {
    //                                this.tran = this.con.BeginTransaction();
    //                                this.cmd.Connection = this.con;
    //                                this.cmd.Transaction = this.tran;

    //                                this.cmd.CommandType = CommandType.Text;
                                   
    //                                for (int i = 0; i < sai.LineItems.Count; i++)
    //                                {
    //                                    //this will be updated after saving in Peachtree.
    //                                    //we give temporary GUID say 1 

    //                                    sai.TransactionGUID = "1";
                                      

    //                                    this.cmd.CommandText = "Insert into SaleInvoiceLineItems (CompanyGuid,SaleInvoiceGUID,LineNo,DiscPct,DiscUnitPrice,LineItemPrice,SecAttID,SecAttDes,LineType,Amount,ExtendedAmount)Values('" + companyGuid + "','" + sai.TransactionGUID + "'," + sai.LineItems[i].LineitemNo + "," + sai.LineItems[i].DiscPct +"," +Math.Round( sai.LineItems[i].DiscUnitPrice,2)+ "," +Math.Round( sai.LineItems[i].LineitemPrice,2) + ",'" + sai.LineItems[i].FrameColor.Id + "','" + sai.LineItems[i].FrameColor.Description + "','" + sai.LineItems[i].SaleInvoiceLineItemType + "',"+ sai.LineItems[i].Amount +","+sai.LineItems[i].ExtendedAmount +")";

    //                                    this.cmd.ExecuteNonQuery();

    //                                }

    //                                //save line items in logs

    //                                new LogDAL().SaleInvLineLog(sai);


    //                                CustomerDAL rdal = new CustomerDAL();
    //                                //if invoice is being edited 
    //                                if ((transactionGUID != "1") && (transactionGUID != null))
    //                                {

    //                                    string[] recToDel = new string[] { transactionGUID };
    //                                    Exception exception = new Exception();
    //                                    try
    //                                    {
    //                                        invoice.DeleteSaleInvoice(ref recToDel);
    //                                    }
    //                                    catch (Exception exception2)
    //                                    {
    //                                        exception = exception2;
    //                                    }
    //                                    EditSaleInvoiceDAL edal = new EditSaleInvoiceDAL();
    //                                    if (edal.GetIsSaleInvoiceExist(sai))
    //                                    {
    //                                        throw exception;
    //                                    }


    //                                }

 

    //                                rdal.SaveFinanceCharges(sai.Customer);
    //                                strArray = invoice.ImportSaleInvoice();
    //                                rdal.SaveTerm(sai.Customer);

    //                                if (strArray.Length > 0)
    //                                {
    //                                    if (strArray[0] != null && strArray[0] != "")
    //                                    {
    //                                        this.cmd.CommandText = "Update SaleInvoiceLineItems  set SaleInvoiceGUID='" + strArray[0] + "' where SaleInvoiceGUID='1' and CompanyGuid='" + peachObj.CurrentCompanyGUID + "'";
    //                                        this.cmd.ExecuteNonQuery();

    //                                        this.tran.Commit();
    //                                    }
    //                                    else
    //                                        tran.Rollback();
    //                                }

                                    

 

    //                            }
    //                        }
    //                    }

    //                }
    //                catch (Exception ex)
    //                {
    //                    this.tran.Rollback();
    //                    throw ex;
    //                }
    //                finally
    //                {
    //                    con.Close();
    //                }

    //            }
    //            strArray3 = strArray;
    //            if (strArray.Length > 0)
    //            {
    //                if (strArray[0] != null && strArray[0] != "")
    //                {
    //                    sai.TransactionGUID = strArray[0];
                     
    //                    new SaleInvoiceDB().SaveShipAddressinCityZipStCountry(sai);
    //                    if (sai.Receipt.RefNo  !=null && sai.Receipt.RefNo !="")
    //                    {
    //                        sai.Receipt.RefNo = sai.Receipt.RefNo.Trim();
    //                        new ReceiptDAL().SaveSalesReceipt(sai);
    //                    }

    //                }
    //            }
               
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return strArray3;
    //    }

      
    //    private SaleInvoice RemoveEmptyLines(SaleInvoice si)
    //    {
    //        List<SaleInvoiceLineItem > removedItems=new List<SaleInvoiceLineItem>();
    //        foreach (SaleInvoiceLineItem  siLni in si.LineItems )
    //        {
    //            if (siLni.Amount == 0 && siLni.ExtendedAmount == 0 && (siLni.Item.ItemId == null || siLni.Item.ItemId == "")   && (siLni.LineitemDescription == null || siLni.LineitemDescription == "") && siLni.LineitemPrice == 0 && siLni.Quantity == 0 && (siLni.Job.Id == null || siLni.Job.Id == ""))
    //            {
    //                removedItems.Add(siLni);
    //            }
    //        }
    //        while (removedItems.Count >0)
    //        {
    //            si.LineItems.Remove(removedItems[0]);
    //            removedItems.Remove(removedItems[0]);
    //        }
    //        return si;
    //    }

    //    private bool SaveFreight(SaleInvoice sai, DateTime disDate, DateTime dueDate, decimal disAmount, string FileNameXML)
    //    {
    //        bool flag;
    //        try
    //        {
    //            int num = 0;
    //            if (sai.SalesTaxCode != null)
    //            {
    //                num = sai.SalesTaxCode.SalesTaxAuthority.Count<SalesTaxAuthority>();
    //            }
    //            if (sai.FreightAmount > Convert.ToDecimal((double) 0.0))
    //            {
    //                num++;
    //            }
    //            if (sai.LineItems.Count > 0)
    //            {
    //                foreach (SaleInvoiceLineItem item in sai.LineItems)
    //                {
    //                    if ((item.SaleInvoiceLineItemType == SaleInLineItemType.SO) && (item.Quantity > 0M))
    //                    {
    //                        num++;
    //                    }
    //                    else if (item.SaleInvoiceLineItemType == SaleInLineItemType.Sales)
    //                    {
    //                        num++;
    //                    }
    //                }
    //            }
    //            StreamWriter writer = new StreamWriter(FileNameXML, true);
    //            if (sai.FreightAmount > Convert.ToDecimal((double) 0.0))
    //            {
    //                writer.Write(this.ISComma(sai.Customer.Id) + ",");
    //                writer.Write(this.ISComma(sai.Customer.Name) + ",");
    //                writer.Write(this.ISComma(sai.SaleInvoiceNo) + ",");
    //                writer.Write(sai.TransactionDate.ToShortDateString() + ",");
    //                writer.Write("False,");
    //                writer.Write(sai.QuoteNo + ",");
    //                writer.Write(",");
    //                writer.Write(sai.DropShip + ",");
    //                if (sai.ShipAddress.Receipent != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.Receipent) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.ShipAddress.AddressLine1 != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.AddressLine1) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.ShipAddress.AddressLine2 != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.AddressLine2) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.ShipAddress.City != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.City) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.ShipAddress.State != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.State) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.ShipAddress.Zip != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.Zip) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.ShipAddress.Country != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.Country) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.CustomerPO != "")
    //                {
    //                    writer.Write(this.ISComma(sai.CustomerPO) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                writer.Write(this.ISComma(sai.ShipVia.ShippingMethod) + ",");
    //                if (sai.ShipDate != DateTime.MinValue)
    //                {
    //                    writer.Write(sai.ShipDate.ToShortDateString() + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                writer.Write(sai.DueDate.ToShortDateString() + ",");
    //                writer.Write(Math.Round(sai.DiscountAmount, 2) + ",");
    //                writer.Write(sai.DiscountDate.ToShortDateString() + ",");
    //                writer.Write(this.ISComma(sai.Customer.Term.TermsString) + ",");
    //                writer.Write(this.ISComma(sai.SalesRep.Id) + ",");
    //                writer.Write(sai.ARAccount.AccountId + ",");
    //                writer.Write(Math.Round(sai.TransactionTotal, 2) + ",");
    //                writer.Write(sai.SalesTaxCode.SalestaxId + ",");
    //                writer.Write(this.ISComma(sai.CusNote) + ",");
    //                writer.Write(sai.NotePrintsAfterLineItems + ",");
    //                writer.Write(this.ISComma(sai.StatementNote) + ",");
    //                writer.Write(sai.StatementNotePrintsBeforeRef + ",");
    //                writer.Write(num + ",");
    //                writer.Write("False,");
    //                writer.Write(",");
    //                writer.Write(0 + ",");
    //                writer.Write(0.0 + ",");
    //                writer.Write(",");
    //                writer.Write("Freight Amount,");
    //                writer.Write(sai.FreightAccount.AccountId + ",");
    //                writer.Write("0.00,");
    //                writer.Write("26,");
    //                writer.Write("-" + Math.Round(sai.FreightAmount, 2) + ",");
    //                writer.Write(",");
    //                writer.Write(",");
    //                writer.Write(",");
    //                writer.Write(",");
    //                writer.Write(",");
    //                writer.Write(this.ISComma(sai.InternalNote) + ",");
    //                writer.Write(",");
    //                writer.Write("0.00,");
    //                writer.Write("0,");
    //                writer.Write("0,");
    //                writer.Write("FALSE,");
    //                writer.Write(",");
    //                writer.Write("0.00,");
    //                writer.Write("0.00,");
    //                writer.Write("0.00,");
    //                writer.Write("0.00,");
    //                writer.Write(sai.ProgressBillingInvoice + ",");
    //                writer.Write(sai.ApplyToProposal + ",");
    //                writer.Write(sai.RecurNumber + ",");
    //                writer.WriteLine(sai.RecurFrequency);
    //            }
    //            writer.Flush();
    //            writer.Close();
    //            flag = true;
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return flag;
    //    }

    //    private bool SaveItems(SaleInvoice sai, DateTime disDate, DateTime dueDate, decimal disAmount, string FileNameXML)
    //    {
    //        bool flag;
    //        try
    //        {
    //            int num = 0;
    //            if (sai.SalesTaxCode != null)
    //            {
    //                num = sai.SalesTaxCode.SalesTaxAuthority.Count<SalesTaxAuthority>();
    //            }
    //            if (sai.FreightAmount > Convert.ToDecimal((double) 0.0))
    //            {
    //                num++;
    //            }
    //            if (sai.LineItems.Count > 0)
    //            {
    //                foreach (SaleInvoiceLineItem item in sai.LineItems)
    //                {
    //                    if ((item.SaleInvoiceLineItemType == SaleInLineItemType.SO) && (item.Quantity > 0M))
    //                    {
    //                        num++;
    //                    }
    //                    else if (item.SaleInvoiceLineItemType == SaleInLineItemType.Sales)
    //                    {
    //                        num++;
    //                    }
    //                }
    //            }
    //            PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
    //            StreamReader reader = new StreamReader(Application.StartupPath + @"\Item" + peachObj.CurrentCompanyGUID + ".txt");
    //            Dictionary<string, string> dictionary = new Dictionary<string, string>();
    //            string str = "";
    //            while (!reader.EndOfStream)
    //            {
    //                str = reader.ReadLine();
    //                dictionary.Add(str.Split(new char[] { 'ƒ' }).GetValue(0).ToString(), str.Split(new char[] { 'ƒ' }).GetValue(1).ToString());
    //            }
    //            reader.Close();
    //            StreamWriter writer = new StreamWriter(FileNameXML, true);
    //            int num2 = 1;
    //            foreach (SaleInvoiceLineItem item2 in sai.LineItems)
    //            {
    //                string id;
    //                if (item2.SaleInvoiceLineItemType == SaleInLineItemType.SO)
    //                {
    //                    if (item2.Quantity > 0M)
    //                    {
    //                        writer.Write(this.ISComma(sai.Customer.Id) + ",");
    //                        writer.Write(this.ISComma(sai.Customer.Name) + ",");
    //                        writer.Write(this.ISComma(sai.SaleInvoiceNo) + ",");
    //                        writer.Write(sai.TransactionDate.ToShortDateString() + ",");
    //                        writer.Write("False,");
    //                        writer.Write(sai.QuoteNo + ",");
    //                        writer.Write(",");
    //                        writer.Write(sai.DropShip + ",");
    //                        if (sai.ShipAddress.Receipent != "")
    //                        {
    //                            writer.Write(this.ISComma(sai.ShipAddress.Receipent) + ",");
    //                        }
    //                        else
    //                        {
    //                            writer.Write(",");
    //                        }
    //                        if (sai.ShipAddress.AddressLine1 != "")
    //                        {
    //                            writer.Write(this.ISComma(sai.ShipAddress.AddressLine1) + ",");
    //                        }
    //                        else
    //                        {
    //                            writer.Write(",");
    //                        }
    //                        if (sai.ShipAddress.AddressLine2 != "")
    //                        {
    //                            writer.Write(this.ISComma(sai.ShipAddress.AddressLine2) + ",");
    //                        }
    //                        else
    //                        {
    //                            writer.Write(",");
    //                        }
    //                        if (sai.ShipAddress.City != "")
    //                        {
    //                            writer.Write(this.ISComma(sai.ShipAddress.City) + ",");
    //                        }
    //                        else
    //                        {
    //                            writer.Write(",");
    //                        }
    //                        if (sai.ShipAddress.State != "")
    //                        {
    //                            writer.Write(this.ISComma(sai.ShipAddress.State) + ",");
    //                        }
    //                        else
    //                        {
    //                            writer.Write(",");
    //                        }
    //                        if (sai.ShipAddress.Zip != "")
    //                        {
    //                            writer.Write(this.ISComma(sai.ShipAddress.Zip) + ",");
    //                        }
    //                        else
    //                        {
    //                            writer.Write(",");
    //                        }
    //                        if (sai.ShipAddress.Country != "")
    //                        {
    //                            writer.Write(this.ISComma(sai.ShipAddress.Country) + ",");
    //                        }
    //                        else
    //                        {
    //                            writer.Write(",");
    //                        }
    //                        if (sai.CustomerPO != "")
    //                        {
    //                            writer.Write(this.ISComma(sai.CustomerPO) + ",");
    //                        }
    //                        else
    //                        {
    //                            writer.Write(",");
    //                        }
    //                        writer.Write(this.ISComma(sai.ShipVia.ShippingMethod) + ",");
    //                        if (sai.ShipDate != DateTime.MinValue)
    //                        {
    //                            writer.Write(sai.ShipDate.ToShortDateString() + ",");
    //                        }
    //                        else
    //                        {
    //                            writer.Write(",");
    //                        }
    //                        writer.Write(sai.DueDate.ToShortDateString() + ",");
    //                        writer.Write(Math.Round(sai.DiscountAmount, 2) + ",");
    //                        writer.Write(sai.DiscountDate.ToShortDateString() + ",");
    //                        writer.Write(this.ISComma(sai.Customer.Term.TermsString) + ",");
    //                        writer.Write(this.ISComma(sai.SalesRep.Id) + ",");
    //                        writer.Write(sai.ARAccount.AccountId + ",");
    //                        writer.Write(Math.Round(sai.TransactionTotal, 2) + ",");
    //                        writer.Write(sai.SalesTaxCode.SalestaxId + ",");
    //                        writer.Write(this.ISComma(sai.CusNote) + ",");
    //                        writer.Write(sai.NotePrintsAfterLineItems + ",");
    //                        writer.Write(this.ISComma(sai.StatementNote) + ",");
    //                        writer.Write(sai.StatementNotePrintsBeforeRef + ",");
    //                        writer.Write(num + ",");
    //                        writer.Write("True,");
    //                        writer.Write(this.ISComma(sai.SaleOrderNo) + ",");
    //                        writer.Write(item2.SalesOrderDistributionNumber + ",");
    //                        writer.Write(item2.Quantity + ",");
    //                        if ((item2.Item.GuId == null) || (item2.Item.GuId == ""))
    //                        {
    //                            writer.Write(",");
    //                        }
    //                        else
    //                        {
    //                            writer.Write(this.ISComma(dictionary[item2.Item.GuId]) + ",");
    //                        }

    //                        String des = "";
    //                        des = item2.LineitemDescription;
    //                        if (des != null)
    //                            writer.Write(this.ISComma(des.Replace("\r\n", " ").Replace("\"", "\''")) + ",");
    //                        else
    //                            writer.Write(",");
    //                        writer.Write(item2.LineitemAccount.AccountId + ",");
    //                        writer.Write(Math.Round ( item2.DiscUnitPrice,2) + ",");
    //                        writer.Write(item2.LineitemTax.Number + ",");
    //                        if (item2.ExtendedAmount > 0M)
    //                        {
    //                            writer.Write("-" + Math.Round(item2.ExtendedAmount, 2) + ",");
    //                        }
    //                        else
    //                        {
    //                            writer.Write((Math.Round(item2.ExtendedAmount, 2) * -1M) + ",");
    //                        }

    //                        writer.Write(",");
    //                        writer.Write(",");
                            
    //                        id = "";
    //                        id = item2.Job.Id;
    //                        writer.Write(this.ISComma(id) + ",");
    //                        writer.Write(",");
    //                        writer.Write(",");
    //                        writer.Write(this.ISComma(sai.InternalNote) + ",");
    //                        writer.Write(item2.Item.Upcsku + ",");
    //                        writer.Write(item2.Item.Weight + ",");
    //                        writer.Write(Convert.ToString(num2++) + ",");
    //                        writer.Write("0,");
    //                        writer.Write("FALSE,");
    //                        writer.Write(item2.Item.StockingUMID + ",");
    //                        writer.Write("1.00,");
    //                        writer.Write(item2.Quantity + ",");
    //                        writer.Write(Math.Round(item2.DiscUnitPrice, 2) + ",");
    //                        writer.Write("0.00,");
    //                        writer.Write("False,");
    //                        writer.Write("False,");
    //                        writer.Write(sai.RecurNumber + ",");
    //                        writer.WriteLine(sai.RecurFrequency);
    //                    }
    //                }
    //                else if (item2.SaleInvoiceLineItemType == SaleInLineItemType.Sales)
    //                {
    //                    writer.Write(this.ISComma(sai.Customer.Id) + ",");
    //                    writer.Write(this.ISComma(sai.Customer.Name) + ",");
    //                    writer.Write(this.ISComma(sai.SaleInvoiceNo) + ",");
    //                    writer.Write(sai.TransactionDate.ToShortDateString() + ",");
    //                    writer.Write("False,");
    //                    writer.Write(sai.QuoteNo + ",");
    //                    writer.Write(",");
    //                    writer.Write(sai.DropShip + ",");
    //                    if (sai.ShipAddress.Receipent != "")
    //                    {
    //                        writer.Write(this.ISComma(sai.ShipAddress.Receipent) + ",");
    //                    }
    //                    else
    //                    {
    //                        writer.Write(",");
    //                    }
    //                    if (sai.ShipAddress.AddressLine1 != "")
    //                    {
    //                        writer.Write(this.ISComma(sai.ShipAddress.AddressLine1) + ",");
    //                    }
    //                    else
    //                    {
    //                        writer.Write(",");
    //                    }
    //                    if (sai.ShipAddress.AddressLine2 != "")
    //                    {
    //                        writer.Write(this.ISComma(sai.ShipAddress.AddressLine2) + ",");
    //                    }
    //                    else
    //                    {
    //                        writer.Write(",");
    //                    }
    //                    if (sai.ShipAddress.City != "")
    //                    {
    //                        writer.Write(this.ISComma(sai.ShipAddress.City) + ",");
    //                    }
    //                    else
    //                    {
    //                        writer.Write(",");
    //                    }
    //                    if (sai.ShipAddress.State != "")
    //                    {
    //                        writer.Write(this.ISComma(sai.ShipAddress.State) + ",");
    //                    }
    //                    else
    //                    {
    //                        writer.Write(",");
    //                    }
    //                    if (sai.ShipAddress.Zip != "")
    //                    {
    //                        writer.Write(this.ISComma(sai.ShipAddress.Zip) + ",");
    //                    }
    //                    else
    //                    {
    //                        writer.Write(",");
    //                    }
    //                    if (sai.ShipAddress.Country != "")
    //                    {
    //                        writer.Write(this.ISComma(sai.ShipAddress.Country) + ",");
    //                    }
    //                    else
    //                    {
    //                        writer.Write(",");
    //                    }
    //                    if (sai.CustomerPO != "")
    //                    {
    //                        writer.Write(this.ISComma(sai.CustomerPO) + ",");
    //                    }
    //                    else
    //                    {
    //                        writer.Write(",");
    //                    }
    //                    writer.Write(this.ISComma(sai.ShipVia.ShippingMethod) + ",");
    //                    if (sai.ShipDate != DateTime.MinValue)
    //                    {
    //                        writer.Write(sai.ShipDate.ToShortDateString() + ",");
    //                    }
    //                    else
    //                    {
    //                        writer.Write(",");
    //                    }
    //                    writer.Write(sai.DueDate.ToShortDateString() + ",");
    //                    writer.Write(Math.Round(sai.DiscountAmount, 2) + ",");
    //                    writer.Write(sai.DiscountDate.ToShortDateString() + ",");
    //                    writer.Write(this.ISComma(sai.Customer.Term.TermsString) + ",");
    //                    writer.Write(this.ISComma(sai.SalesRep.Id) + ",");
    //                    writer.Write(sai.ARAccount.AccountId + ",");
    //                    writer.Write(Math.Round(sai.TransactionTotal, 2) + ",");
    //                    writer.Write(sai.SalesTaxCode.SalestaxId + ",");
    //                    writer.Write(this.ISComma(sai.CusNote) + ",");
    //                    writer.Write(sai.NotePrintsAfterLineItems + ",");
    //                    writer.Write(this.ISComma(sai.StatementNote) + ",");
    //                    writer.Write(sai.StatementNotePrintsBeforeRef + ",");
    //                    writer.Write(num + ",");
    //                    writer.Write("False,");
    //                    writer.Write(",");
    //                    writer.Write("0,");
    //                    writer.Write(item2.Quantity + ",");
    //                    if ((item2.Item.GuId == null) || (item2.Item.GuId == ""))
    //                    {
    //                        writer.Write(",");
    //                    }
    //                    else
    //                    {
    //                        writer.Write(this.ISComma(dictionary[item2.Item.GuId]) + ",");
    //                    }

    //                    String des = "";
    //                    des =  item2.LineitemDescription ;
    //                    if (des != null)

    //                        writer.Write(this.ISComma(des.Replace("\r\n", " ").Replace("\"", "\''")) + ",");
    //                    else
    //                        writer.Write(",");
    //                    writer.Write(item2.LineitemAccount.AccountId + ",");
    //                    writer.Write(Math.Round(item2.DiscUnitPrice, 2) + ",");
    //                    writer.Write(item2.LineitemTax.Number + ",");
    //                    if (item2.ExtendedAmount > 0M)
    //                    {
    //                        writer.Write("-" + Math.Round(item2.ExtendedAmount, 2) + ",");
    //                    }
    //                    else
    //                    {
    //                       writer.Write((Math.Round(item2.ExtendedAmount, 2) *-1  ) + ",");
    //                    }
                        
    //                        writer.Write(",");
    //                        writer.Write(",");
                        
    //                    id = "";
    //                    id = item2.Job.Id;
    //                    writer.Write(this.ISComma(id) + ",");
    //                    writer.Write(",");
    //                    writer.Write(",");
    //                    writer.Write(this.ISComma(sai.InternalNote) + ",");
    //                    writer.Write(item2.Item.Upcsku + ",");
    //                    writer.Write(item2.Item.Weight + ",");
    //                    writer.Write(Convert.ToString(num2++) + ",");
    //                    writer.Write("0,");
    //                    writer.Write("FALSE,");
    //                    writer.Write(item2.Item.StockingUMID + ",");
    //                    writer.Write("1.00,");
    //                    writer.Write(item2.Quantity + ",");
    //                    writer.Write(Math.Round(item2.DiscUnitPrice, 2) + ",");
    //                    writer.Write("0.00,");
    //                    writer.Write("False,");
    //                    writer.Write("False,");
    //                    writer.Write(sai.RecurNumber + ",");
    //                    writer.WriteLine(sai.RecurFrequency);
    //                }
    //            }
    //            writer.Flush();
    //            writer.Close();
    //            flag = true;
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return flag;
    //    }

    //    private bool SaveSaleTax(SaleInvoice sai, DateTime disDate, DateTime dueDate, decimal disAmount, string FileNameXML)
    //    {
    //        bool flag;
    //        try
    //        {
    //            int num = 0;
    //            if (sai.SalesTaxCode != null)
    //            {
    //                num = sai.SalesTaxCode.SalesTaxAuthority.Count<SalesTaxAuthority>();
    //            }
    //            if (sai.FreightAmount > Convert.ToDecimal((double) 0.0))
    //            {
    //                num++;
    //            }
    //            if (sai.LineItems.Count > 0)
    //            {
    //                foreach (SaleInvoiceLineItem item in sai.LineItems)
    //                {
    //                    if ((item.SaleInvoiceLineItemType == SaleInLineItemType.SO) && (item.Quantity > 0M))
    //                    {
    //                        num++;
    //                    }
    //                    else if (item.SaleInvoiceLineItemType == SaleInLineItemType.Sales)
    //                    {
    //                        num++;
    //                    }
    //                }
    //            }
    //            StreamWriter writer = new StreamWriter(FileNameXML, false);
    //            foreach (SalesTaxAuthority authority in sai.SalesTaxCode.SalesTaxAuthority)
    //            {
    //                writer.Write(this.ISComma(sai.Customer.Id) + ",");
    //                writer.Write(this.ISComma(sai.Customer.Name) + ",");
    //                writer.Write(this.ISComma(sai.SaleInvoiceNo) + ",");
    //                writer.Write(sai.TransactionDate.ToShortDateString() + ",");
    //                writer.Write("False,");
    //                writer.Write(sai.QuoteNo + ",");
    //                writer.Write(",");
    //                writer.Write(sai.DropShip + ",");
    //                if (sai.ShipAddress.Receipent != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.Receipent) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.ShipAddress.AddressLine1 != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.AddressLine1) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.ShipAddress.AddressLine2 != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.AddressLine2) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.ShipAddress.City != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.City) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.ShipAddress.State != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.State) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.ShipAddress.Zip != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.Zip) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.ShipAddress.Country != "")
    //                {
    //                    writer.Write(this.ISComma(sai.ShipAddress.Country) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                if (sai.CustomerPO != "")
    //                {
    //                    writer.Write(this.ISComma(sai.CustomerPO) + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                writer.Write(this.ISComma(sai.ShipVia.ShippingMethod) + ",");
    //                if (sai.ShipDate != DateTime.MinValue)
    //                {
    //                    writer.Write(sai.ShipDate.ToShortDateString() + ",");
    //                }
    //                else
    //                {
    //                    writer.Write(",");
    //                }
    //                writer.Write(sai.DueDate.ToShortDateString() + ",");
    //                writer.Write(Math.Round(sai.DiscountAmount, 2) + ",");
    //                writer.Write(sai.DiscountDate.ToShortDateString() + ",");
    //                writer.Write(this.ISComma(sai.Customer.Term.TermsString) + ",");
    //                writer.Write(this.ISComma(sai.SalesRep.Id) + ",");
    //                writer.Write(sai.ARAccount.AccountId + ",");
    //                writer.Write(Math.Round(sai.TransactionTotal, 2) + ",");
    //                writer.Write(sai.SalesTaxCode.SalestaxId + ",");
    //                writer.Write(this.ISComma(sai.CusNote) + ",");
    //                writer.Write(sai.NotePrintsAfterLineItems + ",");
    //                writer.Write(this.ISComma(sai.StatementNote) + ",");
    //                writer.Write(sai.StatementNotePrintsBeforeRef + ",");
    //                writer.Write(num + ",");
    //                writer.Write("False,");
    //                writer.Write(",");
    //                writer.Write(0 + ",");
    //                writer.Write(0.0 + ",");
    //                writer.Write(",");
    //                writer.Write(this.ISComma(authority.AuthorityDescription) + ",");
    //                writer.Write(authority.AuthorityaccountId + ",");
    //                writer.Write("0.00,");
    //                writer.Write("0,");
    //                if( authority.GetSalesTaxAtuhorityTotal(sai.TaxableItemAmount) >0)
    //                writer.Write("-" +    authority.GetSalesTaxAtuhorityTotal(sai.TaxableItemAmount)+",");
    //                else
    //                    writer.Write("" + authority.GetSalesTaxAtuhorityTotal(sai.TaxableItemAmount) *-1 + ",");
    //                writer.Write(",");
    //                writer.Write(",");
    //                writer.Write(",");
    //                writer.Write(authority.AuthorityId + ",");
    //                writer.Write(",");
    //                writer.Write(this.ISComma(sai.InternalNote) + ",");
    //                writer.Write(",");
    //                writer.Write("0.00,");
    //                writer.Write("0,");
    //                writer.Write("0,");
    //                writer.Write("FALSE,");
    //                writer.Write(",");
    //                writer.Write("0.00,");
    //                writer.Write("0.00,");
    //                writer.Write("0.00,");
    //                writer.Write("0.00,");
    //                writer.Write("False,");
    //                writer.Write("False,");
    //                writer.Write(sai.RecurNumber + ",");
    //                writer.WriteLine(sai.RecurFrequency);
    //            }
    //            writer.Flush();
    //            writer.Close();
    //            flag = true;
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return flag;
    //    }
    //}
}

