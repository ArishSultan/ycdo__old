namespace DAL
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using OleDbHelper;
    using System.Data.OleDb;
    using System.Data;

    //public class CustomerDAL
    //{
    //    private Customer customer;
    //    private CustomerList customerList;
    //    private List<Customer> customers;


    //    private OleDbCommand cmd;
    //    private OleDbConnection con;
    //    private OleDbDataAdapter da;
    //    private DataTable dt;
    //    private PeachtreeSingleTon peachObj;
    //    private ReadConfigFile readconfile;
    //    private OleDbTransaction trans;


    //    public Customer SelectCustomerPriceLevels(Customer cus)
    //    {
    //        Customer customer;
    //        try
    //        {
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            this.dt = new DataTable();
    //            int num = 0;
    //            if (this.con.ConnectionString != null)
    //            {
    //                this.peachObj = new PeachtreeSingleTon();
    //                if (this.peachObj.CurrentCompanyGUID == null)
    //                {
    //                    return cus;
    //                }
    //                if (this.peachObj.CurrentCompanyGUID == "")
    //                {
    //                    return cus;
    //                }
    //                this.con.Open();
    //                this.cmd = new OleDbCommand();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.CommandType = CommandType.Text;
    //                    this.cmd.CommandText = "Select PriceLevelID from CustomerPriceLevel where CusGUID ='" + cus.Guid + "' and CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    num = Convert.ToInt32(this.cmd.ExecuteScalar());
    //                    this.con.Close();
    //                }
    //            }
    //            cus.PriceLevel.Id = num;
    //            customer = cus;
    //        }
    //        catch (Exception)
    //        {
    //            if (this.con.State != ConnectionState.Closed)
    //            {
    //                this.con.Close();
    //            }
    //            throw;
    //        }
    //        return customer;
    //    }

    //    public List<Customer> GetCustomersOnly()
    //    {
    //        try
    //        {

    //            customerList = new CustomerList();

    //            if (customerList.ExportCustomerUST() == true)
    //            {

    //                PeachtreeSingleTon peach = new PeachtreeSingleTon();
    //                customers = new List<Customer>();

    //                XElement xdoc = XElement.Load(customerList.FileNameExportXML);
    //                var cusElement = from el in xdoc.Elements("PAW_Customer")
    //                                 select el;
    //                //loop through customer exported data and make list of customers.
    //                foreach (var el in cusElement)
    //                {
    //                    if (el.Element("isInactive").Value == "FALSE")
    //                    {

    //                        customer = new Customer();
    //                        customer.Id = el.Element("ID").Value;

    //                        customer.Name = el.Element("Name") == null ? "" : el.Element("Name").Value;



    //                        customer.BillToAddress.AddressLine1 = el.Element("BillToAddress").Element("Line1") == null ? "" : el.Element("BillToAddress").Element("Line1").Value;
    //                        customer.BillToAddress.AddressLine2 = el.Element("BillToAddress").Element("Line2") == null ? "" : el.Element("BillToAddress").Element("Line2").Value;
    //                        customer.BillToAddress.City = el.Element("BillToAddress").Element("City") == null ? "" : el.Element("BillToAddress").Element("City").Value;
    //                        customer.BillToAddress.State = el.Element("BillToAddress").Element("State") == null ? "" : el.Element("BillToAddress").Element("State").Value;
    //                        customer.BillToAddress.Zip = el.Element("BillToAddress").Element("Zip") == null ? "" : el.Element("BillToAddress").Element("Zip").Value;
    //                        customer.BillToAddress.Country = el.Element("BillToAddress").Element("Country") == null ? "" : el.Element("BillToAddress").Element("Country").Value;
    //                        customer.SalesTaxCode.SalestaxId = el.Element("BillToAddress").Element("Sales_Tax_Code") == null ? "" : el.Element("BillToAddress").Element("Sales_Tax_Code").Value;

    //                        customers.Add(customer);
    //                    }
    //                }
    //            }
    //            return customers;
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetCustomersOnly");
    //            return customers;
    //        }
    //    }

    //    public List<Customer> GetCustomersShiptos()
    //    {
    //        try
    //        {

    //            customerList = new CustomerList();

    //            if (customerList.ExportCustomerUST() == true)
    //            {

    //                PeachtreeSingleTon peach = new PeachtreeSingleTon();
    //                customers = new List<Customer>();

    //                XElement xdoc = XElement.Load(customerList.FileNameExportXML);
    //                var cusElement = from el in xdoc.Elements("PAW_Customer")
    //                                 select el;
    //                //loop through customer exported data and make list of customers.
    //                foreach (var el in cusElement)
    //                {
    //                    if (el.Element("isInactive").Value == "FALSE")
    //                    {

    //                        customer = new Customer();
    //                        customer.Id = el.Element("ID").Value;

    //                        customer.Name = el.Element("Name") == null ? "" : el.Element("Name").Value;

    //                        customer.BillToAddress.AddressLine1 = el.Element("BillToAddress").Element("Line1") == null ? "" : el.Element("BillToAddress").Element("Line1").Value;
    //                        customer.BillToAddress.AddressLine2 = el.Element("BillToAddress").Element("Line2") == null ? "" : el.Element("BillToAddress").Element("Line2").Value;
    //                        customer.BillToAddress.City = el.Element("BillToAddress").Element("City") == null ? "" : el.Element("BillToAddress").Element("City").Value;
    //                        customer.BillToAddress.State = el.Element("BillToAddress").Element("State") == null ? "" : el.Element("BillToAddress").Element("State").Value;
    //                        customer.BillToAddress.Zip = el.Element("BillToAddress").Element("Zip") == null ? "" : el.Element("BillToAddress").Element("Zip").Value;
    //                        customer.BillToAddress.Country = el.Element("BillToAddress").Element("Country") == null ? "" : el.Element("BillToAddress").Element("Country").Value;
    //                        customer.SalesTaxCode.SalestaxId = el.Element("BillToAddress").Element("Sales_Tax_Code") == null ? "" : el.Element("BillToAddress").Element("Sales_Tax_Code").Value;
    //                        //get the shipto addresses.
    //                        customer.ShiptoAddresses = new ShipToDAL().GetShipToAddress(customer);
    //                        customers.Add(customer);
    //                    }
    //                }
    //            }
    //            return customers;
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetCustomersShiptos");
    //            return customers;
    //        }
    //    }


    //    /// <summary>
    //    /// Return customer 's Balance,Credit Status ,Credit Limit of Given Customer.
    //    /// </summary>
    //    /// <param name="cus"></param>
    //    /// <returns></returns>
    //    public Customer GetCustomer(Customer cus)
    //    {
    //        try
    //        {

    //            customerList = new CustomerList();

    //            if (customerList.ExportCustomer(cus.Id) == true)
    //            {



    //                XElement xdoc = XElement.Load(customerList.FileNameExportXML);
    //                var cusElement = from el in xdoc.Elements("PAW_Customer")
    //                                 select el;

    //                customer = new Customer();
    //                foreach (var el in cusElement)
    //                {
    //                    if (el.Element("isInactive").Value == "FALSE")
    //                    {

    //                        customer.Id = el.Element("ID").Value;
    //                        customer.Guid = el.Element("GUID").Value;
    //                        customer.Balance = el.Element("Customer_Balance") == null ? Convert.ToDecimal(0.00) : Convert.ToDecimal(el.Element("Customer_Balance").Value);
    //                        customer.CreditLimit = el.Element("Credit_Limit") == null ? Convert.ToDecimal(0.00) : Convert.ToDecimal(el.Element("Credit_Limit").Value);
    //                        customer.Term.CreditStatus = el.Element("Credit_Status") == null ? (Credit_Status)0 : (Credit_Status)Convert.ToInt32(el.Element("Credit_Status").Value);
    //                        customer.Term.UseFinanceCharge = el.Element("Charge_Finance_Charges") == null ? false : Convert.ToBoolean(el.Element("Charge_Finance_Charges").Value);


    //                    }
    //                }
    //            }
    //            return customer;
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetCustomer");
    //            return customer;
    //        }
    //    }

    //    public List<Customer> GetCustomers()
    //    {
    //        try
    //        {

    //            customerList = new CustomerList();
    //            customers = new List<Customer>();
    //            if (customerList.ExportCustomer() == true)
    //            {
    //                ShipToDAL shiptodal;


    //                XElement xdoc = XElement.Load(customerList.FileNameExportXML);
    //                var cusElement = from el in xdoc.Elements("PAW_Customer")
    //                                 select el;
    //                PeachtreeSingleTon peach = new PeachtreeSingleTon();
    //                foreach (var el in cusElement)
    //                {
    //                    if (el.Element("isInactive").Value == "FALSE")
    //                    {
    //                        customer = new Customer();
    //                        customer.Id = el.Element("ID").Value;

    //                        customer.Name = el.Element("Name") == null ? "" : el.Element("Name").Value;

    //                        customer.CustomerPo = el.Element("Open_Purchase_Order_Number") == null ? "" : el.Element("Open_Purchase_Order_Number").Value;
    //                        customer.Guid = el.Element("GUID").Value;
    //                        customer.BillToAddress.AddressLine1 = el.Element("BillToAddress").Element("Line1") == null ? "" : el.Element("BillToAddress").Element("Line1").Value;
    //                        customer.BillToAddress.AddressLine2 = el.Element("BillToAddress").Element("Line2") == null ? "" : el.Element("BillToAddress").Element("Line2").Value;
    //                        customer.BillToAddress.City = el.Element("BillToAddress").Element("City") == null ? "" : el.Element("BillToAddress").Element("City").Value;
    //                        customer.BillToAddress.State = el.Element("BillToAddress").Element("State") == null ? "" : el.Element("BillToAddress").Element("State").Value;
    //                        customer.BillToAddress.Zip = el.Element("BillToAddress").Element("Zip") == null ? "" : el.Element("BillToAddress").Element("Zip").Value;
    //                        customer.BillToAddress.Country = el.Element("BillToAddress").Element("Country") == null ? "" : el.Element("BillToAddress").Element("Country").Value;
    //                        customer.SalesTaxCode.SalestaxId = el.Element("BillToAddress").Element("Sales_Tax_Code") == null ? "" : el.Element("BillToAddress").Element("Sales_Tax_Code").Value;
    //                        customer.SaleRep.Id = el.Element("Sales_Representative_ID") == null ? "" : el.Element("Sales_Representative_ID").Value;
    //                        customer.SaleRep.Guid = el.Element("Sales_Rep_GUID") == null ? "" : el.Element("Sales_Rep_GUID").Value;
    //                        customer.ShipVia.ShippingMethod = el.Element("Ship_Via_Text") == null ? "" : el.Element("Ship_Via_Text").Value;
    //                        customer.Term.Cod = el.Element("Use_COD_Terms") == null ? false : Convert.ToBoolean(el.Element("Use_COD_Terms").Value);
    //                        customer.Term.Prepaid = el.Element("Use_Prepaid_Terms") == null ? false : Convert.ToBoolean(el.Element("Use_Prepaid_Terms").Value);
    //                        customer.Term.TermsType = Convert.ToBoolean(el.Element("Terms_Type").Value);
    //                        customer.Term.DueDays = Convert.ToInt16(el.Element("Due_Days").Value);
    //                        customer.Term.DiscountDays = Convert.ToInt16(el.Element("Discount_Days").Value);
    //                        customer.Term.DiscountPercent = Convert.ToSingle  (el.Element("Discount_Percent").Value);
    //                        customer.Term.DuemonthendTerms = Convert.ToBoolean(el.Element("Use_Due_Month_End_Terms").Value);

    //                        customer.CustomerType = el.Element("Customer_Type") == null ? "" : el.Element("Customer_Type").Value;
    //                        customer.Term.TermsString = customer.Term.GenerateTermString();
    //                        var shiptoadd = from shi in el.Descendants("ShipToAddresses").Descendants("ShipToAddress")
    //                                        select shi;
    //                        int I = 1;
    //                        foreach (var shi in shiptoadd)
    //                        {
    //                            ShipAddress shipadd = new ShipAddress();
    //                            shipadd.SalesTax = shi.Element("Sales_Tax_Code") == null ? "" : shi.Element("Sales_Tax_Code").Value;
    //                            shipadd.Receipent = shi.Element("Name") == null ? "" : shi.Element("Name").Value;
    //                            shipadd.AddressLine1 = shi.Element("Line1") == null ? "" : shi.Element("Line1").Value;
    //                            shipadd.AddressLine2 = shi.Element("Line2") == null ? "" : shi.Element("Line2").Value;
    //                            shipadd.City = shi.Element("City") == null ? "" : shi.Element("City").Value;
    //                            shipadd.State = shi.Element("State") == null ? "" : shi.Element("State").Value;
    //                            shipadd.Zip = shi.Element("Zip") == null ? "" : shi.Element("Zip").Value;

    //                            shipadd.Country = shi.Element("Country") == null ? "" : shi.Element("Country").Value;
    //                            //if all empty then dont add it.
    //                            if (!(shipadd.Receipent == "" && shipadd.AddressLine1 == "" && shipadd.AddressLine2 == "" && shipadd.City == "" && shipadd.State == "" && shipadd.Zip == "" && shipadd.Country == "" && shipadd.SalesTax == ""))
    //                            {
    //                                shipadd.ShipToID = "Ship To ID" + I;
    //                                customer.ShiptoAddresses.Add(shipadd);
    //                                I++;
    //                            }
    //                        }
    //                        shiptodal = new ShipToDAL();
    //                        shiptodal.SaveShiptoAddress(customer);
    //                        // customer.ShiptoAddresses = new ShipToDAL().GetShipToAddress( customer);
    //                        customers.Add(customer);
    //                    }
    //                }
    //            }
    //            return customers;
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetCustomers");
    //            return customers;
    //        }
    //    }

    //    public bool SaveFinanceCharges(Customer cus)
    //    {
    //        try
    //        {
    //            this.customerList = new CustomerList();
    //            StreamWriter writer = new StreamWriter(this.customerList.FileNameImportCSV);
    //            writer.WriteLine(string.Concat(new object[] { cus.Id, ",", false, ",0" }));
    //            writer.Flush();
    //            writer.Close();
    //            return this.customerList.ImportCustomerFinanceCharges();
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "SaveFinanceCharges");
    //            return false;
    //        }
    //    }

    //    public bool SaveTerm(Customer cus)
    //    {
    //        try
    //        {
    //            this.customerList = new CustomerList();
    //            StreamWriter writer = new StreamWriter(this.customerList.FileNameImportCSV);
    //            int num = 0;
    //            switch (cus.Term.CreditStatus)
    //            {
    //                case Credit_Status.No_credit_limit:
    //                    num = 0;
    //                    break;

    //                case Credit_Status.Notify_over_limit:
    //                    num = 1;
    //                    break;

    //                case Credit_Status.Always_notify:
    //                    num = 2;
    //                    break;

    //                case Credit_Status.Hold_over_limit:
    //                    num = 3;
    //                    break;

    //                case Credit_Status.Always_hold:
    //                    num = 4;
    //                    break;
    //            }
    //            writer.WriteLine(string.Concat(new object[] { 
    //                cus.Id, ",", cus.Term.UseStandardTerm, ",", cus.Term.Cod, ",", cus.Term.Prepaid, ",", cus.Term.DueDays, ",", cus.Term.DiscountDays, ",", cus.Term.DiscountPercent, ",", cus.Term.DuemonthendTerms, ",", 
    //                cus.Term.UseFinanceCharge, ",", num
    //             }));
    //            writer.Flush();
    //            writer.Close();
    //            return this.customerList.ImportCustomerTerm();
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "SaveTerm");
    //            return false;
    //        }
    //    }
    //}
}

