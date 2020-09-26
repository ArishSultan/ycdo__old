namespace DAL.UpdateDB
{
    using Common;
   // // using ExportImport;
    using OleDbHelper;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml.Linq;

    //public class UpdateDBDAL
    //{

    //    private OleDbCommand cmd;
    //    private OleDbConnection con;
    //    private OleDbDataAdapter da;

    //    private DataTable hrbItemsDT = new DataTable();

    //    private AccountPeriods accountperiod;
    //    private AccountingPeriodsList accountperiodList;
    //    private ChartofAccount chartofAccount;
    //    private string ChartofAccountFName = "ChartofAccount.txt";
    //    private CostCodeList costcodeList;
    //    private string CostFName = "CostCode.txt";
    //    private string CusFName = "Customers.txt";
    //    private string CusConFName = "CustomerContacts.txt";
    //    private DataTable cusPriceDT = new DataTable();
    //    private string CusPriceFName = "CustomerPrice.txt";
    //    private CustomerList customerList;
    //    private CustomerContactList cusContList;
    //    //Added by Omer Aziz september 22,2011
    //    private EditSaleInvoice siLit;
    //    private string siFileName = "sis.txt";
    //    //--end--
    //    private EditQuote editQuote;
    //    private EmployeeAsSaleRep employeasaleRep;


    //    private InventoryItemsList inventoryitesList;

    //    private string ItemFName = "Items.txt";
    //    private string ItemAttFName = "ItemsAttributes.txt";
    //    private string Path = (Application.StartupPath + @"\");

    //    private string ItemTaxFname = "itemtaxType.txt";
    //    private ItemTaxType itemtaxType;
    //    private string JobFName = "Jobs.txt";
    //    private JobList jobList;

    //    private PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
    //    private string PhaseFName = "Phase.txt";
    //    private PhaseList phaseList;
    //    private string QuoteNoFname = "QuoteNo.txt";
    //    private ReadConfigFile readconfile;
    //    private string SaleRepFName = "SalesRep.txt";
    //    private string SalesTaxAuthFName = "SalesTaxAuth.txt";
    //    private SalesTaxAuthorities salestaxAuthorties;
    //    private SalesTaxCodes salestaxCode;
    //    private string SalesTaxCodeFName = "SalesTaxCode.txt";
    //    private ShippingMethod shippingMethod;
    //    private string ShipViaFName = "ShipVia.txt";

    //    //Added by Omer Aziz
    //    //September 22,2011
    //    private string SaleInvoiceFPath
    //    {
    //        get 
    //        {
    //            return (this.Path + this.siFileName);
    //        }
    //    }
    //    //--end--
    //    private string ChartofAccountFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.ChartofAccountFName);
    //        }
    //    }

    //    private string CostFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.CostFName);
    //        }
    //    }

    //    private string CusFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.CusFName);
    //        }
    //    }

    //    private string CusPriceFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.CusPriceFName);
    //        }
    //    }

    //    //private string HRBItemFPath
    //    //{
    //    //    get
    //    //    {
    //    //        return (this.Path + this.HRBItemFName);
    //    //    }
    //    //}

    //    private string ItemFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.ItemFName);
    //        }
    //    }

    //    private string ItemAttFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.ItemAttFName);
    //        }
    //    }
    //    private string ItemTaxFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.ItemTaxFname);
    //        }
    //    }

    //    private string JobFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.JobFName);
    //        }
    //    }

    //    private string PhaseFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.PhaseFName);
    //        }
    //    }

    //    private string QuoteNoFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.QuoteNoFname);
    //        }
    //    }

    //    private string SaleRepFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.SaleRepFName);
    //        }
    //    }

    //    private string SalesTaxAuthFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.SalesTaxAuthFName);
    //        }
    //    }

    //    private string SalesTaxCodeFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.SalesTaxCodeFName);
    //        }
    //    }

    //    private string ShipViaFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.ShipViaFName);
    //        }
    //    }
    //    private string CusConFPath
    //    {
    //        get { return this.Path + this.CusConFName ; }
    //    }

    //    //Added by Omer Aziz September 22,2011 
    //    private bool GetSalesInvoices()
    //    {
    //        DateTime fromDate, toDate;
    //        try
    //        {
            
    //            //To Get all the Invoice, we need to get all the accounting periods first.
    //            string str,str2;
    //            accountperiod  = new AccountingPeriods().GetAccountingPeriods();
    //            str = this.accountperiod.Periods[1].Remove(this.accountperiod.Periods[1].IndexOf("to"));
    //            str2 = this.accountperiod.Periods[this.accountperiod.Periods.Count - 1].Substring(this.accountperiod.Periods[this.accountperiod.Periods.Count - 1].IndexOf("to") + 2);
    //            fromDate = Convert.ToDateTime(str);
    //            toDate = Convert.ToDateTime(str2);
    //        }
    //        catch (Exception)
    //        {
                
    //            throw;
    //        }
    //        int recrodnumber = 1;
    //        try
    //        {
    //            this.siLit = new EditSaleInvoice();
    //            if (this.siLit.ExportSaleInvoice(fromDate ,toDate))
    //            {
    //                StringBuilder builder = new StringBuilder();
    //                XElement xdoc = XElement.Load(siLit.FileNameXML);
    //                var siElement = from el in xdoc.Elements("PAW_Invoice")
    //                                  select el;
    //                foreach (XElement element2 in siElement)
    //                {
    //                    if (element2.Element("isQuote").Value == "FALSE")
    //                    {
    //                        if (recrodnumber == 42)
    //                        {
    //                            int x = 009;
    //                        }
    //                        builder.Append("\"").Append(this.peachObj.CurrentCompanyGUID).Append("\",\"").Append(this.peachObj.CurrentCompanyName).Append("\",\"").Append(element2.Element("Customer_ID").Value).Append("\",\"").Append((element2.Element("Customer_Name")) == null ? "" : (element2.Element("Customer_Name").Value)).Append("\",\"").Append((element2.Element("Invoice_Number") == null) ? "" : element2.Element("Invoice_Number").Value).Append("\",\"").Append(element2.Element("Date").Value).Append("\",\"").Append((element2.Element("GUID") == null) ? "" : element2.Element("GUID").Value).Append("\",\"").Append((element2.Element("ShipToAddress").Element("Name") == null) ? "" : element2.Element("ShipToAddress").Element("Name").Value).Append("\",\"").Append((element2.Element("ShipToAddress").Element("Line1") == null) ? "" : element2.Element("ShipToAddress").Element("Line1").Value).Append("\",\"").Append((element2.Element("ShipToAddress").Element("Line2") == null) ? "" : element2.Element("ShipToAddress").Element("Line2").Value).Append("\",\"").Append((element2.Element("ShipToAddress").Element("City") == null) ? "" : element2.Element("ShipToAddress").Element("City").Value).Append("\",\"").Append((element2.Element("ShipToAddress").Element("State") == null) ? "" : element2.Element("ShipToAddress").Element("State").Value).Append("\",\"").Append((element2.Element("ShipToAddress").Element("Zip") == null) ? "" : element2.Element("ShipToAddress").Element("Zip").Value).Append("\",\"").Append((element2.Element("Customer_PO") == null) ? "" : element2.Element("Customer_PO").Value).Append("\",\"").Append((element2.Element("Ship_Via")) == null ? "" : element2.Element("Ship_Via").Value).Append("\"").AppendLine();
    //                    }
    //                    recrodnumber++;
    //                }
    //                if (File.Exists(this.SaleInvoiceFPath))
    //                {
    //                    File.Delete(this.SaleInvoiceFPath);
    //                }
    //                File.AppendAllText(this.SaleInvoiceFPath, "CompanyGUID,CompanyName,CustomerID,CustomerName,siNumber,siDate,siGuid,Recipient,Line1,Line2,City,State,Zip,CustomerPO,ShipVia\r\n");
    //                File.AppendAllText(this.SaleInvoiceFPath, builder.ToString());
    //            }
    //            return true;
    //        }
    //        catch (Exception exception)
    //        {

    //            MessageBox.Show(exception.Message + recrodnumber.ToString());
    //            return false;
    //        }
    //    }
    //    //--end--
    //    private bool GetChartofAccounts()
    //    {
    //        try
    //        {
    //            this.chartofAccount = new ChartofAccount();
    //            if (this.chartofAccount.ExportChartofAccount())
    //            {
    //                StringBuilder builder = new StringBuilder();



    //                XElement xdoc = XElement.Load(chartofAccount.FileNameXML);
    //                var charElement = from el in xdoc.Elements("PAW_Account")
    //                                  select el;

    //                foreach (XElement element2 in charElement)
    //                {
    //                    if (element2.Element("isInactive").Value == "FALSE")
    //                    {
    //                        builder.Append("\"").Append(element2.Element("ID").Value).Append("\",").Append((element2.Element("Description") == null) ? "" : this.Parse(element2.Element("Description").Value)).Append(",\"").Append(element2.Element("Acct_Type_Description").Value).Append("\",\"").Append(element2.Element("GUID").Value).Append("\",\"").Append(element2.Element("Type").Value).Append("\",\"").Append(this.peachObj.CurrentCompanyGUID).Append("\"").AppendLine();
    //                    }
    //                }
    //                if (File.Exists(this.ChartofAccountFPath))
    //                {
    //                    File.Delete(this.ChartofAccountFPath);
    //                }
    //                File.AppendAllText(this.ChartofAccountFPath, "AccountID,Description,AccountDescription,AccountGUID,Type,CompanyGUID\r\n");

    //                File.AppendAllText(this.ChartofAccountFPath, builder.ToString());
    //            }
    //            return true;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message);
    //            return false;
    //        }
    //    }

    //    private bool GetCostCode()
    //    {
    //        try
    //        {
    //            this.costcodeList = new CostCodeList();
    //            if (this.costcodeList.ExportCostCode())
    //            {
    //                StringBuilder builder = new StringBuilder();



    //                XElement xdoc = XElement.Load(costcodeList.FileNameXML);
    //                var xmlElement = from el in xdoc.Elements("PAW_Cost")
    //                                 select el;


    //                foreach (XElement element2 in xmlElement)
    //                {
    //                    builder.Append("").Append(this.Parse(element2.Element("ID").Value)).Append(",\"").Append((element2.Element("CostType") == null) ? "" : element2.Element("CostType").Value).Append("\",").Append((element2.Element("Description") == null) ? "" : this.Parse(element2.Element("Description").Value)).Append(",\"").Append(this.peachObj.CurrentCompanyGUID).Append("\"").AppendLine();
    //                }
    //                if (File.Exists(this.CostFPath))
    //                {
    //                    File.Delete(this.CostFPath);
    //                }
    //                File.AppendAllText(this.CostFPath, "CostID,CostType,Description,CompanyGUID\r\n");
    //                File.AppendAllText(this.CostFPath, builder.ToString());
    //            }
    //            return true;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetCostCode");
    //            return false;
    //        }
    //    }

    //    //private void GetCustomerPriceData()
    //    //{
    //    //    try
    //    //    {
    //    //        this.readconfile = new ReadConfigFile();
    //    //        this.con = new OleDbConnection();
    //    //        this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //    //        if (this.con.ConnectionString != null)
    //    //        {
    //    //            this.con.Open();
    //    //            this.cmd = new OleDbCommand();
    //    //            if (this.con.State == ConnectionState.Open)
    //    //            {
    //    //                this.da = new OleDbDataAdapter("Select * from CustomerPriceLevel  where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //    //                this.da.Fill(this.cusPriceDT);
    //    //                this.con.Close();
    //    //            }
    //    //        }
    //    //    }
    //    //    catch (Exception)
    //    //    {
    //    //        throw;
    //    //    }
    //    //}

    //    private bool GetCustomers()
    //    {
    //        try
    //        {
    //            this.customerList = new CustomerList();
    //            if (this.customerList.ExportCustomer())
    //            {



    //                XElement xdoc = XElement.Load(customerList.FileNameExportXML);
    //                var xmlElement = from el in xdoc.Elements("PAW_Customer")
    //                                 select el;



    //                this.peachObj = new PeachtreeSingleTon();
    //                StringBuilder builder = new StringBuilder();
    //                StringBuilder builder2 = new StringBuilder();

    //                foreach (XElement element2 in xmlElement)
    //                {
    //                    if (element2.Element("isInactive").Value == "FALSE")
    //                    {
    //                        Customer cus = new Customer();
    //                        cus.Id = element2.Element("ID").Value;
    //                        cus.Id = cus.Id.Replace("'", "''");

    //                        cus.Name = (element2.Element("Name") == null) ? "" : element2.Element("Name").Value;
    //                        cus.Name = cus.Name.Replace("'", "''");
    //                        cus.CustomerPo = (element2.Element("Open_Purchase_Order_Number") == null) ? "" : element2.Element("Open_Purchase_Order_Number").Value;
    //                        cus.Guid = element2.Element("GUID").Value;
    //                        cus.BillToAddress.AddressLine1 = (element2.Element("BillToAddress").Element("Line1") == null) ? "" : element2.Element("BillToAddress").Element("Line1").Value;
    //                        cus.BillToAddress.AddressLine2 = (element2.Element("BillToAddress").Element("Line2") == null) ? "" : element2.Element("BillToAddress").Element("Line2").Value;
    //                        cus.BillToAddress.City = (element2.Element("BillToAddress").Element("City") == null) ? "" : element2.Element("BillToAddress").Element("City").Value;
    //                        cus.BillToAddress.State = (element2.Element("BillToAddress").Element("State") == null) ? "" : element2.Element("BillToAddress").Element("State").Value;
    //                        cus.BillToAddress.Zip = (element2.Element("BillToAddress").Element("Zip") == null) ? "" : element2.Element("BillToAddress").Element("Zip").Value;
    //                        cus.BillToAddress.Country = (element2.Element("BillToAddress").Element("Country") == null) ? "" : element2.Element("BillToAddress").Element("Country").Value;

    //                        cus.Phone1 = element2.Element("PhoneNumbers").Element("PhoneNumber") == null ? "" : Convert.ToString(element2.Element("PhoneNumbers").Element("PhoneNumber").Value);
    //                        cus.SalesTaxCode.SalestaxId = (element2.Element("BillToAddress").Element("Sales_Tax_Code") == null) ? "" : element2.Element("BillToAddress").Element("Sales_Tax_Code").Value;
    //                        cus.SaleRep.Id = (element2.Element("Sales_Representative_ID") == null) ? "" : element2.Element("Sales_Representative_ID").Value;
    //                        cus.SaleRep.Guid = (element2.Element("Sales_Rep_GUID") == null) ? "" : element2.Element("Sales_Rep_GUID").Value;
    //                        cus.ShipVia.ShippingMethod = (element2.Element("Ship_Via_Text") == null) ? "" : element2.Element("Ship_Via_Text").Value;
    //                        cus.Term.Cod = (element2.Element("Use_COD_Terms") != null) && Convert.ToBoolean(element2.Element("Use_COD_Terms").Value);
    //                        cus.Term.Prepaid = (element2.Element("Use_Prepaid_Terms") != null) && Convert.ToBoolean(element2.Element("Use_Prepaid_Terms").Value);
    //                        cus.Term.TermsType = Convert.ToBoolean(element2.Element("Terms_Type").Value);
    //                        cus.Term.DueDays = Convert.ToInt16(element2.Element("Due_Days").Value);
    //                        cus.Term.DiscountDays = Convert.ToInt16(element2.Element("Discount_Days").Value);
    //                        cus.Term.DiscountPercent = Convert.ToSingle(element2.Element("Discount_Percent").Value);
    //                        cus.Term.DuemonthendTerms = Convert.ToBoolean(element2.Element("Use_Due_Month_End_Terms").Value);
    //                        cus.CustomerType = (element2.Element("Customer_Type") == null) ? "" : element2.Element("Customer_Type").Value;

    //                        cus.Term.TermsString = cus.Term.GenerateTermString();

    //                        cus.PriceLevel.Id = (element2.Element("Pricing_Level") == null) ? 1 : Convert.ToInt32(element2.Element("Pricing_Level").Value);
    //                        PriceLevel priceLevel = cus.PriceLevel;
    //                        priceLevel.Id++;
    //                        builder2.Append(this.Parse(cus.Id)).Append(",").Append(this.Parse(cus.Name)).Append(",\"").Append(cus.Guid).Append("\",").Append(cus.PriceLevel.Id).Append(",\"").Append(this.peachObj.CurrentCompanyGUID).Append("\",").Append(this.Parse(this.peachObj.CurrentCompanyName)).AppendLine();
    //                        builder.Append(this.Parse(cus.Id)).Append(",").Append(this.Parse(cus.Name)).Append(",\"").Append(cus.CustomerPo).Append("\",\"").Append(cus.Guid).Append("\",").Append(this.Parse(cus.BillToAddress.AddressLine1)).Append(",").Append(this.Parse(cus.BillToAddress.AddressLine2)).Append(",").Append(this.Parse(cus.BillToAddress.City)).Append(",").Append(this.Parse(cus.BillToAddress.State)).Append(",").Append(this.Parse(cus.BillToAddress.Zip)).Append(",").Append(this.Parse(cus.BillToAddress.Country)).Append(",").Append(cus.Phone1).Append(",").Append(this.Parse(cus.SalesTaxCode.SalestaxId)).Append(",").Append(this.Parse(cus.SaleRep.Id)).Append(",\"").Append(cus.SaleRep.Guid).Append("\",").Append(this.Parse(cus.ShipVia.ShippingMethod)).Append(",\"").Append(cus.Term.Cod).Append("\",\"").Append(cus.Term.Prepaid).Append("\",\"").Append(cus.Term.TermsType).Append("\",\"").Append(cus.Term.DueDays).Append("\",\"").Append(cus.Term.DiscountDays).Append("\",\"").Append(cus.Term.DiscountPercent).Append("\",\"").Append(cus.Term.DuemonthendTerms).Append("\",\"").Append(cus.CustomerType).Append("\",\"").Append(cus.Term.TermsString).Append("\",\"").Append(this.peachObj.CurrentCompanyGUID).Append("\"").AppendLine();
    //                        IEnumerable<XElement> enumerable2 = element2.Descendants("ShipToAddresses").Descendants<XElement>("ShipToAddress").Select<XElement, XElement>(delegate(XElement shi)
    //                        {
    //                            return shi;
    //                        });
    //                        int num = 1;
    //                        foreach (XElement element3 in enumerable2)
    //                        {
    //                            ShipAddress item = new ShipAddress();
    //                            item.SalesTax = (element3.Element("Sales_Tax_Code") == null) ? "" : element3.Element("Sales_Tax_Code").Value;
    //                            item.Receipent = (element3.Element("Name") == null) ? "" : element3.Element("Name").Value;
    //                            item.AddressLine1 = (element3.Element("Line1") == null) ? "" : element3.Element("Line1").Value;
    //                            item.AddressLine2 = (element3.Element("Line2") == null) ? "" : element3.Element("Line2").Value;
    //                            item.City = (element3.Element("City") == null) ? "" : element3.Element("City").Value;
    //                            item.State = (element3.Element("State") == null) ? "" : element3.Element("State").Value;
    //                            item.Zip = (element3.Element("Zip") == null) ? "" : element3.Element("Zip").Value;
    //                            item.Country = (element3.Element("Country") == null) ? "" : element3.Element("Country").Value;
    //                            if (((((item.Receipent != "") || (item.AddressLine1 != "")) || ((item.AddressLine2 != "") || (item.City != ""))) || (((item.State != "") || (item.Zip != "")) || (item.Country != ""))) || (item.SalesTax != ""))
    //                            {
    //                                item.ShipToID = "Ship To ID" + num;
    //                                cus.ShiptoAddresses.Add(item);
    //                                num++;
    //                            }
    //                        }
    //                        new ShipToDAL().SaveShiptoAddress(cus);
    //                    }
    //                }
    //                if (File.Exists(this.CusFPath))
    //                {
    //                    File.Delete(this.CusFPath);
    //                }
    //                if (File.Exists(this.CusPriceFPath))
    //                {
    //                    File.Delete(this.CusPriceFPath);
    //                }
    //                File.AppendAllText(this.CusFPath, "CustomerID,CustomerName,PO,CustomerGUID,BAddress1,BAddress2,BCity,BState,BZip,BCountry,Phone1,SalesTaxID,SalesRepID,SalesRepGUID,ShipVia,COD,PREPAY,TermType,DueDays,DisDays,DisPercent,DueMonthEnd,CusType,TermString,CompanyGUID\r\n");
    //                File.AppendAllText(this.CusPriceFPath, "CustomerID,CustomerName,CusGUID,PriceLevelID,CompanyGUID,CompanyName\r\n");
    //                File.AppendAllText(this.CusFPath, builder.ToString());
    //                File.AppendAllText(this.CusPriceFPath, builder2.ToString());
    //                return true;
    //            }
    //            return false;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetCustomers");
    //            return false;
    //        }
    //    }



    //    private bool GetCustomersContacts()
    //    {
    //        try
    //        {
    //            this.cusContList = new CustomerContactList();
    //            StringBuilder builder = new StringBuilder();
    //            if (this.cusContList.ExportContacts())
    //            {



    //                XElement xdoc = XElement.Load(cusContList.FileNameExportXML);
    //                var xmlElement = from el in xdoc.Elements("PAW_Contact")
    //                                 select el;



    //                this.peachObj = new PeachtreeSingleTon();



    //                foreach (XElement element2 in xmlElement)
    //                {


    //                    Contact cus = new Contact();
    //                    cus.Id = element2.Element("ID").Value;
    //                    cus.Id = cus.Id.Replace("'", "''");

    //                    cus.FirstName = (element2.Element("ContactFName") == null) ? "" : element2.Element("ContactFName").Value;
    //                    cus.FirstName = cus.FirstName.Replace("'", "''");
    //                    cus.LastName = (element2.Element("ContactLName") == null) ? "" : element2.Element("ContactLName").Value;
    //                    cus.LastName = cus.LastName.Replace("'", "''");

    //                    cus.CompanyName = (element2.Element("CompanyName") == null) ? "" : element2.Element("CompanyName").Value;
    //                    cus.CompanyName = cus.CompanyName.Replace("'", "''");
    //                    cus.IsBillTo = (element2.Element("isBillToContact") == null) ? false : Convert.ToBoolean(element2.Element("isBillToContact").Value);
    //                    cus.IsDefaultShipTo = (element2.Element("isDefaultShipTo") == null) ? false : Convert.ToBoolean(element2.Element("isDefaultShipTo").Value);
    //                    if (element2.Element("DisplayName") == null)
    //                        cus.DisplayName = DisplayName.ContactName;
    //                    else
    //                        cus.DisplayName =(DisplayName ) Enum.Parse (typeof (DisplayName ), Convert.ToString(element2.Element("DisplayName").Value).Replace(" ",""));

    //                    cus.AttachedAddressNumber = Convert.ToInt32(element2.Element("Address").Value);

    //                    builder.Append(this.Parse ( cus.Id)).Append(",").Append(this.Parse( cus.FirstName)).Append(",").Append(this.Parse ( cus.LastName)).Append(",").Append(this.Parse( cus.CompanyName)).Append(",")
    //                        .Append(cus.IsDefaultShipTo ).Append(",").Append(cus.IsBillTo ).Append(",").Append(cus.DisplayName.ToString()).Append(",").Append(cus.AttachedAddressNumber ).Append(",").AppendLine(peachObj.CurrentCompanyGUID);


    //                }
    //            }
    //            if (File.Exists(this.CusConFPath  ))
    //            {
    //                File.Delete(this.CusConFPath);
    //            }

    //            File.AppendAllText(this.CusConFPath, "CustomerID,FirstName,LastName,CompanyName,IsDefaultShipto,IsBillTo,DisplayName,AttachedAddressNo,CompanyGUID\r\n");

    //            File.AppendAllText(this.CusConFPath, builder.ToString());

    //            return true;

              

    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetCustomersContacts");
    //            return false;
    //        }
    //    }

    //    public List<Item> GetItemAndPriceLevels()
    //    {
    //        List<Item> list = new List<Item>();
    //        try
    //        {
    //            this.inventoryitesList = new InventoryItemsList();
    //            if (!this.inventoryitesList.ExportInventoryItemGEN())
    //            {
    //                return list;
    //            }
    //            StringBuilder builder = new StringBuilder();
    //            StringBuilder sbAtrribute = new StringBuilder();

    //            XElement xdoc = XElement.Load(inventoryitesList.FileNameXML);
    //            var xmlElement = from el in xdoc.Elements("PAW_Item")
    //                             select el;



    //            foreach (XElement element2 in xmlElement)
    //            {
    //                if ((element2.Element("isInactive").Value == "FALSE"))
    //                {
    //                    Item item = new Item();
    //                    item.ItemId = element2.Element("ID").Value;
    //                    item.ItemDescription = (element2.Element("Description") == null) ? "" : element2.Element("Description").Value;
    //                    item.SaleDescription = (element2.Element("Description_for_Sales") == null) ? "" : element2.Element("Description_for_Sales").Value;
    //                    item.GuId = (element2.Element("GUID") == null) ? "" : element2.Element("GUID").Value;
    //                    item.ItemClass = (element2.Element("Class") == null) ? ItemClass.nonstockItem : ((ItemClass)Convert.ToInt16(element2.Element("Class").Value));
    //                    item.SalesAccount.AccountId = (element2.Element("GL_Sales_Account") == null) ? "" : element2.Element("GL_Sales_Account").Value;
    //                    item.SalesAccount.GuId = (element2.Element("GL_Sales_Account_GUID") == null) ? "" : element2.Element("GL_Sales_Account_GUID").Value;
    //                    item.InventoryAccount.AccountId = (element2.Element("GL_Inventory_Account") == null) ? "" : element2.Element("GL_Inventory_Account").Value;
    //                    item.InventoryAccount.GuId = (element2.Element("GL_Inventory_Account_GUID") == null) ? "" : element2.Element("GL_Inventory_Account_GUID").Value;
    //                    item.CGSAccount.AccountId = (element2.Element("GL_COGSSalary_Acct") == null) ? "" : element2.Element("GL_COGSSalary_Acct").Value;
    //                    item.CGSAccount.GuId = (element2.Element("GL_COGSSalary_Acct_GUID") == null) ? "" : element2.Element("GL_COGSSalary_Acct_GUID").Value;
    //                    item.QuantityonHand = (element2.Element("QuantityOnHand") == null) ? 0M : Convert.ToDecimal(element2.Element("QuantityOnHand").Value);
    //                    item.LastUnitCost = (element2.Element("Last_Unit_Cost") == null) ? 0M : Convert.ToDecimal(element2.Element("Last_Unit_Cost").Value);
    //                    item.MasterStockId = element2.Element("Master_Stock_ID") == null ? "" : Convert.ToString(element2.Element("Master_Stock_ID").Value);
    //                    item.MasterStockGUID = element2.Element("Master_Stock_GUID") == null ? "" : Convert.ToString(element2.Element("Master_Stock_GUID").Value);
    //                    item.PrimaryAttribute.Name = element2.Element("Primary_Attribute_Name") == null ? "" : Convert.ToString(element2.Element("Primary_Attribute_Name").Value);
    //                    string attId = "", attDes = "";
    //                    attId = element2.Element("Substock_Primary_Attributes").Element("Substock_Primary_Attribute_ID") == null ? "" : element2.Element("Substock_Primary_Attributes").Element("Substock_Primary_Attribute_ID").Value;
    //                    attDes = element2.Element("Substock_Primary_Attributes").Element("Substock_Primary_Attribute_Description") == null ? "" : element2.Element("Substock_Primary_Attributes").Element("Substock_Primary_Attribute_Description").Value;
    //                    AttributeLineItem atl = new AttributeLineItem(attId, attDes);
    //                    if (attId.Length > 0)
    //                    {
    //                        atl.Type = AttributeType.Primary;
    //                        item.PrimaryAttribute.AttributeLines.Add(atl);
    //                    }


    //                    item.SecondaryAttribute.Name = element2.Element("Secondary_Attribute_Name") == null ? "" : Convert.ToString(element2.Element("Secondary_Attribute_Name").Value);
    //                    attId = element2.Element("Substock_Secondary_Attributes").Element("Substock_Secondary_Attribute_ID") == null ? "" : element2.Element("Substock_Secondary_Attributes").Element("Substock_Secondary_Attribute_ID").Value;
    //                    attDes = element2.Element("Substock_Secondary_Attributes").Element("Substock_Secondary_Attribute_Description") == null ? "" : element2.Element("Substock_Secondary_Attributes").Element("Substock_Secondary_Attribute_Description").Value;
    //                    atl = new AttributeLineItem(attId, attDes);
    //                    if (attId.Length > 0)
    //                    {
    //                        atl.Type = AttributeType.Secondary;
    //                        item.SecondaryAttribute.AttributeLines.Add(atl);
    //                    }


    //                    IEnumerable<XElement> enumerable2 = element2.Element("Sales_Prices").Elements().Select<XElement, XElement>(delegate(XElement priceE)
    //                    {
    //                        return priceE;
    //                    });



    //                    int id = 1;
    //                    foreach (XElement element3 in enumerable2)
    //                    {
    //                        PriceLevel level;
    //                        if (id == 1)
    //                        {
    //                            level = new PriceLevel(Math.Round(Convert.ToDecimal(element3.Element("Sales_Price").Value), 2), "Price Level " + id, id, Math.Round(Convert.ToDecimal(element3.Element("Sales_Price").Value), 2), element3.Element("Sales_Price_Calc").Value, Convert.ToInt32(element3.Element("Sales_Price_Rounding").Value), Math.Round(Convert.ToDecimal(element3.Element("Sales_Price_Rounding_Cent").Value), 2), Math.Round(item.LastUnitCost, 2));
    //                        }
    //                        else
    //                        {
    //                            level = new PriceLevel(Math.Round(Convert.ToDecimal(element3.Element("Sales_Price").Value), 2), "Price Level " + id, id, Math.Round(item.PriceLevels[0].Price, 2), element3.Element("Sales_Price_Calc").Value, Convert.ToInt32(element3.Element("Sales_Price_Rounding").Value), Math.Round(Convert.ToDecimal(element3.Element("Sales_Price_Rounding_Cent").Value), 2), Math.Round(item.LastUnitCost, 2));
    //                        }
    //                        level.ConvertfromPTpriceCalc(level);
    //                        item.PriceLevels.Add(level);
    //                        id++;
    //                    }


    //                    list.Add(item);
    //                    builder.Append(this.Parse(item.ItemId)).Append(",").Append(this.Parse(item.SaleDescription)).Append(" , ").Append(this.Parse(item.ItemDescription)).Append(",\"").Append((element2.Element("Tax_Type") == null) ? Convert.ToInt16(-1) : Convert.ToInt16((int)(Convert.ToInt16(element2.Element("Tax_Type").Value) + Convert.ToInt16(1)))).Append("\",").Append(this.Parse(item.SalesAccount.AccountId)).Append(",").Append(this.Parse(item.SalesAccount.GuId)).Append(",").Append(this.Parse(item.InventoryAccount.AccountId)).Append(",").Append(this.Parse(item.InventoryAccount.GuId)).Append(",").Append(this.Parse(item.CGSAccount.AccountId)).Append(",").Append(this.Parse(item.CGSAccount.GuId)).Append(",").Append((element2.Element("Stocking_UM") == null) ? "" : this.Parse(element2.Element("Stocking_UM").Value)).Append(" ,\"").Append((element2.Element("Weight") == null) ? Convert.ToDecimal((double)0.0) : Convert.ToDecimal(element2.Element("Weight").Value)).Append("\",\"").Append((element2.Element("GUID") == null) ? "" : element2.Element("GUID").Value).Append("\",\"").Append((element2.Element("Class") == null) ? 0 : Convert.ToInt16(element2.Element("Class").Value)).Append("\",\"").Append((element2.Element("QuantityOnHand") == null) ? 0M : Convert.ToDecimal(element2.Element("QuantityOnHand").Value)).Append("\",\"").Append(this.peachObj.CurrentCompanyGUID).Append("\"").AppendLine();
    //                    if (item.ItemClass == ItemClass.SubStockItem)
    //                    {
    //                        sbAtrribute.Append(this.Parse(item.PrimaryAttribute.AttributeLines[0].Id)).Append(",").Append(this.Parse(item.PrimaryAttribute.Name)).Append(",").Append(this.Parse(item.PrimaryAttribute.AttributeLines[0].Description)).Append(",");

    //                        if (item.SecondaryAttribute.AttributeLines.Count > 0)
    //                            sbAtrribute.Append(this.Parse(item.SecondaryAttribute.AttributeLines[0].Id)).Append(",").Append(this.Parse(item.SecondaryAttribute.Name)).Append(",").Append(this.Parse(item.SecondaryAttribute.AttributeLines[0].Description)).Append(",");
    //                        else
    //                            sbAtrribute.Append(",,,");//id ,name ,des, of secondary attributes. 
    //                        sbAtrribute.Append(item.MasterStockGUID).Append(",").Append(item.GuId).Append(",").Append(peachObj.CurrentCompanyGUID).AppendLine();
    //                    }
    //                }
    //            }
    //            if (File.Exists(this.ItemFPath))
    //            {
    //                File.Delete(this.ItemFPath);
    //            }
    //            File.AppendAllText(this.ItemFPath, "ItemID,SalesDes,Description,TaxType,SAccountID,SAccountGuid,InvAccountID,InvAccountGUID,CgsAccountID,CgsAccountGUID,StockingUMID,Weight,ItemGUID,ItemClass,QuantityOnHand ,CompanyGUID\r\n");

    //            File.AppendAllText(this.ItemFPath, builder.ToString());

    //            if (File.Exists(this.ItemAttFPath))
    //            {
    //                File.Delete(this.ItemAttFPath);
    //            }

    //            File.AppendAllText(this.ItemAttFPath, "PrimaryID,PrimaryAttributeName,PrimaryDescription,SecondaryID,SecondaryAttributeName,SecondaryDescription,ItemGUID,AttributeGUID,CompanyGUID\r\n");
    //            File.AppendAllText(this.ItemAttFPath, sbAtrribute.ToString());
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetItemPriceLevels");
    //        }
    //        return list;
    //    }

    //    private bool GetItemTaxType()
    //    {
    //        try
    //        {
    //            this.itemtaxType = new ItemTaxType();
    //            if (this.itemtaxType.ExportItemTaxType())
    //            {
    //                StringBuilder builder = new StringBuilder();


    //                XElement xdoc = XElement.Load(itemtaxType.FileNameXML);
    //                var xmlElement = from el in xdoc.Elements("PAW_Item_Tax_Type")
    //                                 select el;

    //                foreach (XElement element2 in xmlElement)
    //                {
    //                    if ((Convert.ToInt32(element2.Element("Number").Value) != 0x1a) && (Convert.ToInt32(element2.Element("Number").Value) != 0x1b))
    //                    {
    //                        builder.Append("\"").Append(Convert.ToBoolean(element2.Element("IsTaxable").Value)).Append("\",\"").Append(element2.Element("Number").Value).Append("\",\"").Append((element2.Element("ItemTaxType") == null) ? "" : element2.Element("ItemTaxType").Value).Append("\",\"").Append(this.peachObj.CurrentCompanyGUID).Append("\"").AppendLine();
    //                    }
    //                }
    //                if (File.Exists(this.ItemTaxFPath))
    //                {
    //                    File.Delete(this.ItemTaxFPath);
    //                }
    //                File.AppendAllText(this.ItemTaxFPath, "IsTaxable,TaxNumber,ItemTaxType ,CompanyGUID\r\n");

    //                File.AppendAllText(this.ItemTaxFPath, builder.ToString());
    //            }
    //            return true;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetItemTaxType");
    //            return false;
    //        }
    //    }

    //    private bool GetJob()
    //    {
    //        try
    //        {
    //            this.jobList = new JobList();
    //            if (this.jobList.ExportJob())
    //            {
    //                StringBuilder builder = new StringBuilder();

    //                XElement xdoc = XElement.Load(jobList.FileNameXML);
    //                var xmlElement = from el in xdoc.Elements("PAW_Job")
    //                                 select el;

    //                foreach (XElement element2 in xmlElement)
    //                {
    //                    if (element2.Element("isInactive").Value == "FALSE")
    //                    {
    //                        builder.Append(" ").Append(this.Parse(element2.Element("ID").Value)).Append(" ,\"").Append(Convert.ToBoolean(element2.Element("UsePhases").Value)).Append("\",\"").Append(element2.Element("GUID").Value).Append("\",\"").Append(this.peachObj.CurrentCompanyGUID).Append("\"").AppendLine();
    //                    }
    //                }
    //                if (File.Exists(this.JobFPath))
    //                {
    //                    File.Delete(this.JobFPath);
    //                }
    //                File.AppendAllText(this.JobFPath, "JobID,UsePhases,JobGUID,CompanyGUID\r\n");


    //                File.AppendAllText(this.JobFPath, builder.ToString());
    //            }
    //            return true;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetJob");
    //            return false;
    //        }
    //    }

    //    private bool GetPhase()
    //    {
    //        try
    //        {
    //            this.phaseList = new PhaseList();
    //            if (this.phaseList.ExportPhase())
    //            {
    //                StringBuilder builder = new StringBuilder();


    //                XElement xdoc = XElement.Load(phaseList.FileNameXML);
    //                var xmlElement = from el in xdoc.Elements("PAW_Phase")
    //                                 select el;


    //                foreach (XElement element2 in xmlElement)
    //                {
    //                    if (element2.Element("isInactive").Value == "FALSE")
    //                    {
    //                        builder.Append("").Append(this.Parse(element2.Element("ID").Value)).Append(",").Append((element2.Element("Description") == null) ? "" : this.Parse(element2.Element("Description").Value)).Append(",\"").Append((element2.Element("CostType") == null) ? "" : element2.Element("CostType").Value).Append("\",\"").Append(element2.Element("UseCostCodes") != null).Append("\",\"").Append(this.peachObj.CurrentCompanyGUID).Append("\"").AppendLine();
    //                    }
    //                }
    //                if (File.Exists(this.PhaseFPath))
    //                {
    //                    File.Delete(this.PhaseFPath);
    //                }
    //                File.AppendAllText(this.PhaseFPath, "PhaseID,Description,CostType,UseCostCodes,CompanyGUID\r\n");

    //                File.AppendAllText(this.PhaseFPath, builder.ToString());
    //            }
    //            return true;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetPhase");
    //            return false;
    //        }
    //    }

    //    public bool GetQuoteNumbers()
    //    {
    //        try
    //        {
    //            this.editQuote = new EditQuote();
    //            this.peachObj = new PeachtreeSingleTon();
    //            if (this.editQuote.ExportQuoteNumber(this.peachObj.GetFirstDay(), this.peachObj.GetLastDay()))
    //            {
    //                StringBuilder builder = new StringBuilder();



    //                XElement xdoc = XElement.Load(editQuote.FileNameXML);
    //                var xmlElement = from el in xdoc.Descendants("PAW_Invoice")
    //                                 select el;

    //                foreach (XElement element2 in xmlElement)
    //                {
    //                    if (element2.Element("isQuote").Value.ToString().ToUpper() == "TRUE")
    //                    {
    //                        builder.Append("").Append((element2.Element("Quote_Number") == null) ? "" : this.Parse(element2.Element("Quote_Number").Value)).Append(",\"").Append(element2.Element("GUID").Value).Append("\",\"").Append(this.peachObj.CurrentCompanyGUID).Append("\"").AppendLine();
    //                    }
    //                }
    //                if (File.Exists(this.QuoteNoFPath))
    //                {
    //                    File.Delete(this.QuoteNoFPath);
    //                }
    //                File.AppendAllText(this.QuoteNoFPath, "QuoteNo,QuoteGUID,CompanyGUID\r\n");

    //                File.AppendAllText(this.QuoteNoFPath, builder.ToString());
    //            }
    //            return true;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetQuoteNumbers");
    //            return false;
    //        }
    //    }

    //    private bool GetSaleRep()
    //    {
    //        try
    //        {
    //            this.employeasaleRep = new EmployeeAsSaleRep();
    //            if (this.employeasaleRep.ExportEmployeeAsSaleRep())
    //            {
    //                StringBuilder builder = new StringBuilder();

    //                XElement xdoc = XElement.Load(employeasaleRep.FileNameXML);
    //                var xmlElement = from el in xdoc.Elements("PAW_Employee")
    //                                 select el;


    //                foreach (XElement element2 in xmlElement)
    //                {
    //                    if (element2.Element("isSalesRep").Value == "TRUE")
    //                    {
    //                        builder.Append("").Append(this.Parse(element2.Element("ID").Value)).Append(",").Append((element2.Element("Name") == null) ? "" : this.Parse(element2.Element("Name").Value)).Append(",\"").Append(element2.Element("EmployeeGUID").Value).Append("\",").Append((element2.Element("Address").Element("Line1") == null) ? "" : this.Parse(element2.Element("Address").Element("Line1").Value)).Append(",").Append(element2.Element("isInactive").Value).Append(",\"").Append(this.peachObj.CurrentCompanyGUID).Append("\"").AppendLine();
    //                    }
    //                }
    //                if (File.Exists(this.SaleRepFPath))
    //                {
    //                    File.Delete(this.SaleRepFPath);
    //                }
    //                File.AppendAllText(this.SaleRepFPath, "SalesRepID,SalesRepName,SalesRepGUID,Address1,isInactive,CompanyGUID\r\n");

    //                File.AppendAllText(this.SaleRepFPath, builder.ToString());
    //            }
    //            return true;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSaleRep");
    //            return false;
    //        }
    //    }

    //    private bool GetSalesTaxAuthorities()
    //    {
    //        try
    //        {
    //            this.salestaxAuthorties = new SalesTaxAuthorities();
    //            if (this.salestaxAuthorties.ExportSalesTaxAuthorities())
    //            {
    //                StringBuilder builder = new StringBuilder();

    //                XElement xdoc = XElement.Load(salestaxAuthorties.FileNameXML);
    //                var xmlElement = from el in xdoc.Elements("PAW_Sales_Tax_Authority")
    //                                 select el;

    //                foreach (XElement element2 in xmlElement)
    //                {
    //                    builder.Append("\"").Append(element2.Element("ID").Value.Replace("\"", "''")).Append("\",\"").Append(Convert.ToDecimal(element2.Element("Rate").Value)).Append("\",\"").Append(element2.Element("AccountID").Value).Append("\",\"").Append(element2.Element("GUID").Value).Append("\",\"").Append(Convert.ToBoolean(element2.Element("UsesFormula").Value)).Append("\",\"").Append(element2.Element("Rate2").Value).Append("\",\"").Append(Convert.ToInt16(element2.Element("TaxBasis").Value)).Append("\",\"").Append(element2.Element("TaxLimit").Value).Append("\",\"").Append(this.peachObj.CurrentCompanyGUID).Append("\"").AppendLine();
    //                }
    //                if (File.Exists(this.SalesTaxAuthFPath))
    //                {
    //                    File.Delete(this.SalesTaxAuthFPath);
    //                }
    //                File.AppendAllText(this.SalesTaxAuthFPath, "AuthID,Rate,AccountID,AuthGUID,UseFormula,Rate2,TaxBasis,TaxLimit,CompanyGUID\r\n");

    //                File.AppendAllText(this.SalesTaxAuthFPath, builder.ToString());
    //            }
    //            return true;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSalesTaxAuthorities");
    //            return false;
    //        }
    //    }

    //    private bool GetSalesTaxCodes()
    //    {
    //        try
    //        {
    //            this.salestaxCode = new SalesTaxCodes();
    //            if (this.salestaxCode.ExportSalesTaxCode())
    //            {
    //                StringBuilder builder = new StringBuilder();


    //                XElement xdoc = XElement.Load(salestaxCode.FileNameXML);
    //                var xmlElement = from el in xdoc.Elements("PAW_Sales_Tax_Code")
    //                                 select el;


    //                foreach (XElement element2 in xmlElement)
    //                {
    //                    IEnumerable<XElement> enumerable2 = element2.Descendants("Authority").Select<XElement, XElement>(delegate(XElement autl)
    //                    {
    //                        return autl;
    //                    });
    //                    foreach (XElement element3 in enumerable2)
    //                    {
    //                        builder.Append("\"").Append(element2.Element("ID").Value.ToString()).Append("\",\"").Append((element2.Element("Description") == null) ? "" : element2.Element("Description").Value).Append("\",\"").Append((element2.Element("GUID") == null) ? "" : element2.Element("GUID").Value).Append("\",\"").Append(element3.Element("ID").Value).Append("\",\"").Append(this.peachObj.CurrentCompanyGUID).Append("\"").AppendLine();
    //                    }
    //                }
    //                if (File.Exists(this.SalesTaxCodeFPath))
    //                {
    //                    File.Delete(this.SalesTaxCodeFPath);
    //                }
    //                File.AppendAllText(this.SalesTaxCodeFPath, "CodeID,Description,CodeGUID,AuthID,CompanyGUID\r\n");

    //                File.AppendAllText(this.SalesTaxCodeFPath, builder.ToString());
    //            }
    //            return true;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSalesTaxCodes");
    //            return false;
    //        }
    //    }

    //    private bool GetShipVia()
    //    {
    //        try
    //        {
    //            this.shippingMethod = new ShippingMethod();
    //            if (this.shippingMethod.ExportShippingMethod())
    //            {
    //                StringBuilder builder = new StringBuilder();




    //                XElement xdoc = XElement.Load(shippingMethod.FileNameXML);
    //                var xmlElement = from el in xdoc.Elements("PAW_Shipping_Method")
    //                                 select el;
    //                foreach (XElement element2 in xmlElement)
    //                {
    //                    builder.Append("\"").Append(element2.Element("Number").Value).Append("\", ").Append(this.Parse(element2.Element("ShippingMethod").Value)).Append(",\"").Append(element2.Element("GUID").Value).Append("\",\"").Append(this.peachObj.CurrentCompanyGUID).Append("\"").AppendLine();
    //                }

    //                if (File.Exists(this.ShipViaFPath))
    //                {
    //                    File.Delete(this.ShipViaFPath);
    //                }
    //                File.AppendAllText(this.ShipViaFPath, "ShipNumber,ShippingMethod,ShipGUID,CompanyGUID\r\n");
    //                File.AppendAllText(this.ShipViaFPath, builder.ToString());
    //            }
    //            return true;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetShipVia");
    //            return false;
    //        }
    //    }

    //    private string Parse(string value)
    //    {
    //        string str2;
    //        try
    //        {
    //            string str = value;
    //            switch (str)
    //            {
    //                case null:
    //                case "":
    //                    return ("\"" + str + "\"");
    //            }
    //            str = str.Replace("\"", "''");
    //            str2 = "\"" + str + "\"";
    //            //str2 = str;
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return str2;
    //    }

    //    public bool ProcessData(BackgroundWorker bgWorker, List<UpdateFields> ufs)
    //    {

    //        try
    //        {

    //            bgWorker.ReportProgress(2);
    //            this.cusPriceDT = new DataTable();
    //            if (ufs.Contains(UpdateFields.Sales_Invoice))
    //            {
    //                this.GetSalesInvoices();
    //            }
    //            bgWorker.ReportProgress(95);
    //            //if (ufs.Contains(UpdateFields.Customers))
    //            //{
    //            //    this.GetCustomers();
    //            //    this.GetCustomersContacts();
    //            //}
    //            //bgWorker.ReportProgress(10);
    //            //if (ufs.Contains(UpdateFields.Sales_Rep))
    //            //    this.GetSaleRep();
    //            //bgWorker.ReportProgress(20);

    //            //if (ufs.Contains(UpdateFields.Chart_Of_Accounts))

    //            //    this.GetChartofAccounts();
    //            //bgWorker.ReportProgress(30);
    //            //if (ufs.Contains(UpdateFields.Sales_Tax_Authority))
    //            //    this.GetSalesTaxAuthorities();
    //            //bgWorker.ReportProgress(40);
    //            //if (ufs.Contains(UpdateFields.Sales_Tax_Code))
    //            //    this.GetSalesTaxCodes();
    //            //bgWorker.ReportProgress(50);
    //            //if (ufs.Contains(UpdateFields.inventory_Item_TaxType))
    //            //    this.GetItemTaxType();
    //            //bgWorker.ReportProgress(60);
    //            //if (ufs.Contains(UpdateFields.Ship_Via))
    //            //    this.GetShipVia();
    //            //bgWorker.ReportProgress(70);
    //            //if (ufs.Contains(UpdateFields.Jobs))
    //            //    this.GetJob();
    //            //if (ufs.Contains(UpdateFields.Phases))
    //            //    this.GetPhase();
    //            //if (ufs.Contains(UpdateFields.CostCodes))
    //            //    this.GetCostCode();
    //            //bgWorker.ReportProgress(80);
    //            //if (ufs.Contains(UpdateFields.Quote_Numbers))
    //            //    this.GetQuoteNumbers();
    //            //bgWorker.ReportProgress(90);
    //            //if (ufs.Contains(UpdateFields.Inventory_Item))
    //            //    this.Get99PriceLevels(this.GetItemAndPriceLevels());
    //            //bgWorker.ReportProgress(95);
    //            bool flag = this.Save(ufs);
    //            if (flag)
    //            {
    //                bgWorker.ReportProgress(100);
    //            }
    //            return flag;


    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }

    //    }

    //    private bool Save(List<UpdateFields> ufs)
    //    {
    //        bool flag;
    //        try
    //        {
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != null)
    //            {
    //                this.con.Open();
    //                this.cmd = new OleDbCommand();
    //                this.cmd.Connection = this.con;
    //                this.cmd.CommandType = CommandType.Text;
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    int num = 0;
    //                    OleDbTransaction transaction = this.con.BeginTransaction();
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.Transaction = transaction;
    //                    if (ufs.Contains(UpdateFields.Sales_Invoice))
    //                    {
    //                        this.cmd.CommandText = "Delete from SaleInvoice where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                        this.cmd.ExecuteNonQuery();
    //                        this.cmd.CommandText = "Insert into [SaleInvoice](CompanyGUID,CompanyName,CustomerID,CustomerName,siNumber,siDate,siGuid,Recipient,Line1,Line2,City,State,Zip,CustomerPO,ShipVia) Select CompanyGUID,CompanyName,CustomerID,CustomerName,siNumber,siDate,siGuid,Recipient,Line1,Line2,City,State,Zip,CustomerPO,ShipVia FROM [Text;DATABASE=" + this.Path + ";].[" + this.siFileName + "]";
    //                        num = this.cmd.ExecuteNonQuery();
    //                    }
    //                    //if (ufs.Contains(UpdateFields.Inventory_Item))
    //                    //{
    //                    //    this.cmd.CommandText = "Delete from Items where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [Items](ItemID,SalesDes,Description,TaxType,SAccountID,SAccountGuid,InvAccountID,InvAccountGUID,CgsAccountID,CgsAccountGUID,StockingUMID,Weight,ItemGUID,ItemClass,QuantityOnHand ,CompanyGUID) Select ItemID,SalesDes,Description,TaxType,SAccountID,SAccountGuid,InvAccountID,InvAccountGUID,CgsAccountID,CgsAccountGUID,StockingUMID,Weight,ItemGUID,ItemClass,QuantityOnHand ,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.ItemFName + "]";
    //                    //    this.cmd.ExecuteNonQuery();

    //                    //    this.cmd.CommandText = "Delete from Attributes where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [Attributes](PriID,PriAttributeName,PriDescription,SecID,SecAttributeName,SecDescription,ItemGUID,AttributeGUID,CompanyGUID) Select PrimaryID,PrimaryAttributeName,PrimaryDescription,SecondaryID,SecondaryAttributeName,SecondaryDescription,ItemGUID,AttributeGUID,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.ItemAttFName + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();

    //                    //    this.cmd.CommandText = "Delete * from 99Price where   CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";

    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [99Price](companyName,companyGUID,ItemGUID,ItemId,ItemDescription,ItemPriceLevelID,ItemPriceLevel,Price,Calculation,UseLevel,AddSubLevel,AddSubValue,RoundLevel,RoundValue,PriceLevel1,LastCost) Select companyName,companyGUID,ItemGUID,ItemId,ItemDescription,ItemPriceLevelID,ItemPriceLevel,Price,Calculation,UseLevel,AddSubLevel,AddSubValue,RoundLevel,RoundValue,PriceLevel1,LastCost FROM [Text;DATABASE=" + Application.StartupPath + @"\;].[SaveItems.txt]";
    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //}
    //                    //if (ufs.Contains(UpdateFields.Sales_Rep))
    //                    //{
    //                    //    this.cmd.CommandText = "Delete from SalesReps where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [SalesReps](SalesRepID,SalesRepName,SalesRepGUID,Address1,isInactive,CompanyGUID) Select SalesRepID,SalesRepName,SalesRepGUID,Address1,isInactive,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.SaleRepFName + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //}
    //                    //if (ufs.Contains(UpdateFields.Chart_Of_Accounts))
    //                    //{
    //                    //    this.cmd.CommandText = "Delete from ChartofAccounts where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [ChartofAccounts](AccountID,Description,AccountDescription,AccountGUID,Type,CompanyGUID) Select AccountID,Description,AccountDescription,AccountGUID,Type,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.ChartofAccountFName + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //}
    //                    //if (ufs.Contains(UpdateFields.Sales_Tax_Authority))
    //                    //{
    //                    //    this.cmd.CommandText = "Delete from Authoritys where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [Authoritys](AuthID,Rate,AccountID,AuthGUID,UseFormula,Rate2,TaxBasis,TaxLimit,CompanyGUID) Select AuthID,Rate,AccountID,AuthGUID,UseFormula,Rate2,TaxBasis,TaxLimit,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.SalesTaxAuthFName + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //}
    //                    //if (ufs.Contains(UpdateFields.Sales_Tax_Code))
    //                    //{
    //                    //    this.cmd.CommandText = "Delete from TaxCodes where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [TaxCodes](CodeID,Description,CodeGUID,AuthID,CompanyGUID) Select CodeID,Description,CodeGUID,AuthID,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.SalesTaxCodeFName + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //}
    //                    //if (ufs.Contains(UpdateFields.inventory_Item_TaxType))
    //                    //{
    //                    //    this.cmd.CommandText = "Delete from ItemTaxes where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [ItemTaxes](IsTaxable,TaxNumber,ItemTaxType ,CompanyGUID) Select IsTaxable,TaxNumber,ItemTaxType,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.ItemTaxFname + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //}
    //                    //if (ufs.Contains(UpdateFields.Ship_Via))
    //                    //{
    //                    //    this.cmd.CommandText = "Delete from Shipvias where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [Shipvias](ShipNumber,ShippingMethod,ShipGUID,CompanyGUID) Select ShipNumber,ShippingMethod,ShipGUID,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.ShipViaFName + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //}
    //                    //if (ufs.Contains(UpdateFields.Jobs))
    //                    //{
    //                    //    this.cmd.CommandText = "Delete from Jobs where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [Jobs](JobID,UsePhases,JobGUID,CompanyGUID) Select JobID,UsePhases,JobGUID,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.JobFName + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //}
    //                    //if (ufs.Contains(UpdateFields.Phases))
    //                    //{
    //                    //    this.cmd.CommandText = "Delete from Phases where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [Phases](PhaseID,Description,CostType,UseCostCodes,CompanyGUID) Select PhaseID,Description,CostType,UseCostCodes,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.PhaseFName + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //}
    //                    //if (ufs.Contains(UpdateFields.CostCodes))
    //                    //{
    //                    //    this.cmd.CommandText = "Delete from CostCodes where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [CostCodes](CostID,CostType,Description,CompanyGUID) Select CostID,CostType,Description,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.CostFName + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //}
    //                    //if (ufs.Contains(UpdateFields.Quote_Numbers))
    //                    //{
    //                    //    this.cmd.CommandText = "Delete from QuoteNumber where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [QuoteNumber](QuoteNo,QuoteGUID,CompanyGUID) Select QuoteNo,QuoteGUID,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.QuoteNoFname + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //}
    //                    //if (ufs.Contains(UpdateFields.Customers))
    //                    //{
    //                    //    this.cmd.CommandText = "Delete from CustomerPriceLevel where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [CustomerPriceLevel](CustomerID,CustomerName,CusGUID,PriceLevelID,CompanyGUID,CompanyName) Select CustomerID,CustomerName,CusGUID,PriceLevelID,CompanyGUID,CompanyName FROM [Text;DATABASE=" + this.Path + ";].[" + this.CusPriceFName + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Delete from Customers where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [Customers](CustomerID,CustomerName,PO,CustomerGUID,BAddress1,BAddress2,BCity,BState,BZip,BCountry,Phone1,SalesTaxID,SalesRepID,SalesRepGUID,ShipVia,COD,PREPAY,TermType,DueDays,DisDays,DisPercent,DueMonthEnd,CusType,TermString,CompanyGUID) Select CustomerID,CustomerName,PO,CustomerGUID,BAddress1,BAddress2,BCity,BState,BZip,BCountry,Phone1,SalesTaxID,SalesRepID,SalesRepGUID,ShipVia,COD,PREPAY,TermType,DueDays,DisDays,DisPercent,DueMonthEnd,CusType,TermString,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.CusFName + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();

    //                    //    this.cmd.CommandText = "Delete from Contacts where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //    this.cmd.ExecuteNonQuery();
    //                    //    this.cmd.CommandText = "Insert into [Contacts](CustomerID,ContactFirstName,ContactLastName,CompanyName,isDefaultShipTo,IsBillTo,DisplayName,AttachedAddressNo,CompanyGUID) Select CustomerID,FirstName,LastName,CompanyName,IsDefaultShipto,IsBillTo,DisplayName,AttachedAddressNo,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.CusConFName + "]";
    //                    //    num = this.cmd.ExecuteNonQuery();
    //                    //}
                        
    //                    transaction.Commit();
    //                    this.con.Close();
    //                    return true;
    //                }
    //                return false;
    //            }
    //            flag = false;
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return flag;
    //    }



    //    public bool SaveNewNonStockitems()
    //    {
    //        bool flag;
    //        try
    //        {
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != null)
    //            {
    //                this.con.Open();
    //                this.cmd = new OleDbCommand();
    //                this.cmd.Connection = this.con;
    //                this.cmd.CommandType = CommandType.Text;
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    int num = 0;
    //                    OleDbTransaction transaction = this.con.BeginTransaction();
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.Transaction = transaction;

    //                    this.cmd.CommandText = "Delete from Items where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    this.cmd.ExecuteNonQuery();
    //                    this.cmd.CommandText = "Insert into [Items](ItemID,SalesDes,Description,TaxType,SAccountID,SAccountGuid,InvAccountID,InvAccountGUID,CgsAccountID,CgsAccountGUID,StockingUMID,Weight,ItemGUID,ItemClass,QuantityOnHand ,CompanyGUID) Select ItemID,SalesDes,Description,TaxType,SAccountID,SAccountGuid,InvAccountID,InvAccountGUID,CgsAccountID,CgsAccountGUID,StockingUMID,Weight,ItemGUID,ItemClass,QuantityOnHand ,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.ItemFName + "]";
    //                    num = this.cmd.ExecuteNonQuery();

    //                    this.cmd.CommandText = "Delete * from 99Price where   CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";

    //                    num = this.cmd.ExecuteNonQuery();
    //                    this.cmd.CommandText = "Insert into [99Price](companyName,companyGUID,ItemGUID,ItemId,ItemDescription,ItemPriceLevelID,ItemPriceLevel,Price,Calculation,UseLevel,AddSubLevel,AddSubValue,RoundLevel,RoundValue,PriceLevel1,LastCost) Select companyName,companyGUID,ItemGUID,ItemId,ItemDescription,ItemPriceLevelID,ItemPriceLevel,Price,Calculation,UseLevel,AddSubLevel,AddSubValue,RoundLevel,RoundValue,PriceLevel1,LastCost FROM [Text;DATABASE=" + Application.StartupPath + @"\;].[SaveItems.txt]";
    //                    num = this.cmd.ExecuteNonQuery();

    //                    transaction.Commit();
    //                    this.con.Close();
    //                    return true;
    //                }
    //                return false;
    //            }
    //            flag = false;
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return flag;
    //    }


    //    public bool Get99PriceLevels(List<Item> itms)
    //    {
    //        bool flag;
    //        try
    //        {
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != null)
    //            {
    //                this.peachObj = new PeachtreeSingleTon();
    //                if (this.peachObj.CurrentCompanyGUID == null)
    //                {
    //                    return false;
    //                }
    //                if (this.peachObj.CurrentCompanyGUID == "")
    //                {
    //                    return false;
    //                }
    //                this.con.Open();
    //                this.cmd = new OleDbCommand();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.CommandType = CommandType.Text;
    //                    DataTable dataTable = new DataTable();
    //                    dataTable.TableName = "99Price";
    //                    this.da = new OleDbDataAdapter();
    //                    this.cmd.CommandText = "Select * from 99Price where CompanyGuid='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    this.da.SelectCommand = this.cmd;

    //                    this.da.Fill(dataTable);
    //                    this.con.Close();

    //                    PriceLevel level = new PriceLevel();

    //                    StringBuilder builder = new StringBuilder();
    //                    string path = this.Path + @"\SaveItems.txt";
    //                    string contents = "";
    //                    StringBuilder priceData = new StringBuilder();
    //                    string currentCompanyName = this.peachObj.CurrentCompanyName;
    //                    string currentCompanyGUID = this.peachObj.CurrentCompanyGUID;
    //                    Array array = Array.CreateInstance(System.Type.GetType("System.String"), itms.Count);
    //                    int index = -1;
    //                    foreach (Item item in itms)
    //                    {
    //                        builder.Append(item.GuId).Append("ƒ").Append(item.ItemId).AppendLine();
    //                        contents = "";
    //                        level = new PriceLevel();
    //                        int num2 = 0;
    //                        while (num2 < item.PriceLevels.Count)
    //                        {
    //                            level = item.PriceLevels[num2];
    //                            object obj2 = contents;
    //                            obj2 = string.Concat(new object[] { obj2, this.Parse(currentCompanyName), ",", currentCompanyGUID, ",", item.GuId, ",", this.Parse(item.ItemId), ",", this.Parse(item.ItemDescription), ",", ++num2 });
    //                            contents = string.Concat(new object[] { 
    //                                obj2, ",", level.Level, ",", level.Price, ",", level.CalculationText, ",", level.UseLevel, ",", level.AddSubLevel, ",", level.AddSubValue, ",", level.RoundLevel, ",", 
    //                                level.RoundValue, ",", item.PriceLevels[0].PriceLevel1, ",", item.PriceLevels[0].LastCost, "\r\n"
    //                             });
    //                        }
    //                        index++;
    //                        array.SetValue(item.GuId, index);
    //                        priceData.Append(contents);
    //                    }
    //                    if (File.Exists(this.Path + @"\Item" + currentCompanyGUID + ".txt"))
    //                    {
    //                        File.Delete(this.Path + @"\Item" + currentCompanyGUID + ".txt");
    //                    }
    //                    File.AppendAllText(this.Path + @"\Item" + currentCompanyGUID + ".txt", builder.ToString());

    //                    if (File.Exists(path))
    //                    {
    //                        File.Delete(path);
    //                    }
    //                    File.AppendAllText(path, "companyName,companyGUID,ItemGUID,ItemId,ItemDescription,ItemPriceLevelID,ItemPriceLevel,Price,Calculation,UseLevel,AddSubLevel,AddSubValue,RoundLevel,RoundValue,PriceLevel1,LastCost\r\n");
    //                    File.AppendAllText(path, priceData.ToString());



    //                    return true;
    //                }
    //            }
    //            flag = false;
    //        }
    //        catch (Exception)
    //        {
    //            if (this.con.State != ConnectionState.Closed)
    //            {
    //                this.con.Close();
    //            }
    //            throw;
    //        }
    //        return flag;
    //    }

      
    //}
}

