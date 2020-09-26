namespace DAL.UpdateDB
{
    using Common;
   // // using ExportImport;
    using OleDbHelper;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Windows.Forms;

    //public class LocalDBDAL
    //{
    //    private OleDbCommand cmd;
    //    private OleDbConnection con;
    //    private OleDbDataAdapter da;
    //   // private PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
    //    private ReadConfigFile readconfile;
    //    private OleDbTransaction trans;

    //    public List<ChartOfAccount> GetChartofAccounts()
    //    {
    //        List<ChartOfAccount> list = new List<ChartOfAccount>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //           // this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != null)
    //            {
    //                this.con.Open();
    //                ChartOfAccount item = new ChartOfAccount();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    //this.da = new OleDbDataAdapter("Select * from ChartofAccounts where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' order by AccountID", this.con);
    //                    //this.da.Fill(dataTable);
    //                    //for (int i = 0; i < dataTable.Rows.Count; i++)
    //                    //{
    //                    //    DataRow row = dataTable.Rows[i];
    //                    //    item = new ChartOfAccount();
    //                    //    item.AccountId = Convert.ToString(row["AccountID"]);
    //                    //    item.Description = Convert.ToString(row["Description"]);
    //                    //    item.GuId = Convert.ToString(row["AccountGUID"]);
    //                    //    item.Type = (ChartofAccountType) Convert.ToInt16(row["Type"]);
    //                    //    item.TypeDescription = ((ChartofAccountType) Convert.ToInt16(row["Type"])).ToString();
    //                    //    list.Add(item);
    //                    //}
    //                    con.Close();
    //                }
    //            }
    //            return list;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetChartofAccounts");
    //            return list;
    //        }
    //    }

    //    public List<ChartOfAccount> GetIncomeAccounts()
    //    {
    //        List<ChartOfAccount> list = new List<ChartOfAccount>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != null)
    //            {
    //                this.con.Open();
    //                ChartOfAccount item = new ChartOfAccount();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.da = new OleDbDataAdapter("Select * from ChartofAccounts where AccountDescription='"  + ChartofAccountType.Income  +"' and  CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' order by AccountID", this.con);
    //                    this.da.Fill(dataTable);
    //                    for (int i = 0; i < dataTable.Rows.Count; i++)
    //                    {
    //                        DataRow row = dataTable.Rows[i];
    //                        item = new ChartOfAccount();
    //                        item.AccountId = Convert.ToString(row["AccountID"]);
    //                        item.Description = Convert.ToString(row["Description"]);
    //                        item.GuId = Convert.ToString(row["AccountGUID"]);
    //                        item.Type = (ChartofAccountType)Convert.ToInt16(row["Type"]);
    //                        item.TypeDescription = ((ChartofAccountType)Convert.ToInt16(row["Type"])).ToString();
    //                        list.Add(item);
    //                    }
    //                    con.Close();
    //                }
    //            }
    //            return list;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetIncomeAccounts");
    //            return list;
    //        }
    //    }

    //    public List<CostCode> GetCostCodes()
    //    {
    //        List<CostCode> list = new List<CostCode>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            this.con.Open();
    //            CostCode item = new CostCode();
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
    //            this.da = new OleDbDataAdapter("Select * from CostCodes where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //            this.da.Fill(dataTable);
    //            if (con.State == ConnectionState.Open)
    //                con.Close();
    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new CostCode();
    //                item.Id = Convert.ToString(row["CostID"]);
    //                item.CostType = Convert.ToString(row["CostType"]);
    //                item.Description = Convert.ToString(row["Description"]);
    //                list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetCostCodes");
    //        }
    //        return list;
    //    }

    //    public List<Customer> GetCustomerPrices()
    //    {
    //        List<Customer> list = new List<Customer>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            this.con.Open();
    //            Customer item = new Customer();
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
    //            this.da = new OleDbDataAdapter("Select * from CustomerPriceLevel where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //            this.da.Fill(dataTable);

    //            if (con.State == ConnectionState.Open)
    //                con.Close();

    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new Customer();
    //                item.Id = Convert.ToString(row["CustomerID"]);
    //                item.Name = Convert.ToString(row["CustomerName"]);
    //                item.Guid = Convert.ToString(row["CusGUID"]);
    //                item.PriceLevel.Id = Convert.ToInt32(row["PriceLevelID"]);
    //                list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetCustomers");
    //        }
    //        return list;
    //    }

    //    public List<Customer> GetCustomers()
    //    {
    //        List<Customer> list = new List<Customer>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            if (this.peachObj.CurrentCompanyGUID == null)
    //            {
    //                MessageBox.Show("Please open company first", "Prosoftmods.com ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    //                return list;
    //            }
    //            if (this.peachObj.CurrentCompanyGUID == "")
    //            {
    //                MessageBox.Show("Please open company first", "Prosoftmods.com ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    //                return list;
    //            }
    //            string CompanyGuid = peachObj.CurrentCompanyGUID;
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            this.con.Open();
    //            Customer cus = new Customer();
    //            if (this.con.State == ConnectionState.Open)
    //            {
    //                this.da = new OleDbDataAdapter("Select * from customers where CompanyGUID='" + CompanyGuid + "' order by ID", this.con);
    //                this.da.Fill(dataTable);
    //                DataTable shipDt = new DataTable();
                    

    //                this.da = new OleDbDataAdapter("Select * from ShipTo where CompanyGuid ='" + CompanyGuid + "'  Order by ShipToID", this.con);

    //                this.da.Fill(shipDt);

    //                DataTable dtContacts = new DataTable();

    //                this.da = new OleDbDataAdapter("Select * from Contacts where CompanyGUID ='" + CompanyGuid + "'  ", this.con);

    //                this.da.Fill(dtContacts);

    //                for (int i = 0; i < dataTable.Rows.Count; i++)
    //                {
    //                    DataRow row = dataTable.Rows[i];
    //                    cus = new Customer();
    //                    cus.Id = Convert.ToString(row["CustomerID"]);
    //                    cus.Name = Convert.ToString(row["CustomerName"]);
    //                    cus.CustomerPo = Convert.ToString(row["PO"]);
    //                    cus.Guid = Convert.ToString(row["CustomerGUID"]);
    //                    cus.BillToAddress.AddressLine1 = Convert.ToString(row["BAddress1"]);
    //                    cus.BillToAddress.AddressLine2 = Convert.ToString(row["BAddress2"]);
    //                    cus.BillToAddress.City = Convert.ToString(row["BCity"]);
    //                    cus.BillToAddress.State = Convert.ToString(row["BState"]);
    //                    cus.BillToAddress.Zip = Convert.ToString(row["BZip"]);
    //                    cus.BillToAddress.Country = Convert.ToString(row["BCountry"]);
    //                    cus.Phone1 = Convert.ToString(row["Phone1"]);
    //                    cus.SalesTaxCode.SalestaxId = Convert.ToString(row["SalesTaxID"]);
    //                    cus.SaleRep.Id = Convert.ToString(row["SalesRepID"]);
    //                    cus.SaleRep.Guid = Convert.ToString(row["SalesRepGUID"]);
    //                    cus.ShipVia.ShippingMethod = Convert.ToString(row["ShipVia"]);
    //                    cus.Term.Cod = Convert.ToBoolean(row["COD"]);
    //                    cus.Term.Prepaid = Convert.ToBoolean(row["PREPAY"]);
    //                    cus.Term.TermsType = Convert.ToBoolean(row["TermType"]);
    //                    cus.Term.DueDays = Convert.ToInt16(row["DueDays"]);
    //                    cus.Term.DiscountDays = Convert.ToInt16(row["DisDays"]);
    //                    cus.Term.DiscountPercent = Convert.ToSingle(row["DisPercent"]);
    //                    cus.Term.DuemonthendTerms = Convert.ToBoolean(row["DueMonthEnd"]);
    //                    cus.CustomerType = Convert.ToString(row["CusType"]);
    //                    cus.Term.TermsString = Convert.ToString(row["TermString"]);
    //                    //cus.ShiptoAddresses = new ShipToDAL().GetShipToAddress(cus);



    //                    DataRow[] rows = dtContacts.Select("CustomerID='" + cus.Id.Replace("'", "''") + "'");
    //                    if (rows.Length > 0)
    //                    {
    //                        foreach (DataRow conRow in rows)
    //                        {
    //                            Contact cont = new Contact();
    //                            cont.CompanyName = Convert.ToString(conRow["CompanyName"]);
    //                            cont.DisplayName = (DisplayName)Enum.Parse(typeof(DisplayName), Convert.ToString(conRow["DisplayName"]));
    //                            cont.FirstName = Convert.ToString(conRow["ContactFirstName"]);
    //                            cont.Id = Convert.ToString(conRow["CustomerID"]);
    //                            cont.IsBillTo = Convert.ToBoolean(conRow["IsBillTo"]);
    //                            cont.IsDefaultShipTo = Convert.ToBoolean(conRow["isDefaultShipTo"]);
    //                            cont.LastName = Convert.ToString(conRow["ContactLastname"]);
    //                            cont.AttachedAddressNumber = Convert.ToInt32(conRow["AttachedAddressNo"]);

    //                            cus.Contacts.Add(cont);
    //                        }
    //                    }
    //                    rows = shipDt.Select("CustomerID='" + cus.Id.Replace("'", "''") + "'");

    //                    if (rows.Length > 0)
    //                    {
    //                        List<ShipAddress> shipAddresses = new List<ShipAddress>();
    //                        ShipAddress shipAddress;
    //                        foreach (DataRow shipRow in rows)
    //                        {
    //                            if (shipRow["ShipID"] == DBNull.Value)
    //                            {
    //                                shipRow["ShipID"] = 1;
    //                            }
    //                            if (shipRow["SRNO"] == DBNull.Value)
    //                            {
    //                                shipRow["SRNO"] = 1;
    //                            }
                               
    //                            shipAddress = new ShipAddress(Convert.ToInt32(shipRow["ShipID"]), Convert.ToInt32(shipRow["SRNO"]), Convert.ToString(shipRow["SalesTax"]));
    //                            shipAddress.ShipToID =  Convert.ToString((shipRow["ShipToID"] == null) ? "" : shipRow["ShipToID"]);


    //                            shipAddress.Receipent = Convert.ToString((shipRow["Recipient"] == null) ? "" : shipRow["Recipient"]);

    //                            shipAddress.AddressLine1 = Convert.ToString((shipRow["Address1"] == null) ? "" : shipRow["Address1"]);
    //                            shipAddress.AddressLine2 = Convert.ToString((shipRow["Address2"] == null) ? "" : shipRow["Address2"]);
    //                            shipAddress.City = Convert.ToString((shipRow["City"] == null) ? "" : shipRow["City"]);
    //                            shipAddress.State = Convert.ToString((shipRow["State"] == null) ? "" : shipRow["State"]);
    //                            shipAddress.Zip = Convert.ToString((shipRow["ZIP"] == null) ? "" : shipRow["ZIP"]);
    //                            shipAddress.Country = Convert.ToString((shipRow["Country"] == null) ? "" : shipRow["Country"]);
    //                            shipAddress.CompanyGuid = CompanyGuid;
    //                            shipAddress.CompanyName = Convert.ToString(shipRow["CompanyName"]);
    //                            shipAddresses.Add(shipAddress);
    //                        }

    //                        //BillTo address is also shown as ShipTo address  in peachtree Sale Invoice
    //                        ShipAddress sa = new ShipAddress();
    //                        int biltoIndex = 0;
    //                        for (biltoIndex = 0; biltoIndex < cus.Contacts.Count; biltoIndex++)
    //                        {
    //                            if (cus.Contacts[biltoIndex].IsBillTo == true)
    //                                break;
    //                        }
    //                        sa.ShipToID = cus.Contacts[biltoIndex].FirstName + " " + cus.Contacts[biltoIndex].LastName;
    //                        sa.Receipent = cus.Contacts[biltoIndex].CompanyName;
    //                        sa.AddressLine1 =cus.BillToAddress.AddressLine1 ;
    //                        sa.AddressLine2 =cus.BillToAddress.AddressLine2 ;
    //                        sa.City =cus.BillToAddress.City;
    //                        sa.Country =cus.BillToAddress.Country ;
    //                        sa.State=cus.BillToAddress.State ;
    //                        sa.Zip =cus.BillToAddress.Zip ;
    //                        sa.SalesTax = cus.SalesTaxCode.SalestaxId;
    //                        cus.ShiptoAddresses.Add(sa);

    //                        //now we have to merge shipaddresses and contacts to yeild the required number of ShipAddresses

    //                        for (int j   = 1; j < cus.Contacts.Count ; j++)
    //                        {

    //                            if (cus.Contacts[j].IsBillTo == false)
    //                            {
    //                                sa = new ShipAddress();
    //                                sa.ShipToID = cus.Contacts[j].FirstName + " " + cus.Contacts[j].LastName;
    //                                if (cus.Contacts[j].DisplayName == DisplayName.CompanyName)
    //                                    sa.Receipent = cus.Contacts[j].CompanyName;
    //                                else
    //                                    sa.Receipent = cus.Contacts[j].FirstName + " " + cus.Contacts[j].LastName;
    //                                if (cus.Contacts[j].AttachedAddressNumber > 0)
    //                                {
    //                                    int rowInd = cus.Contacts[j].AttachedAddressNumber -1;

    //                                    sa.AddressLine1 = shipAddresses[rowInd].AddressLine1;
    //                                    sa.AddressLine2 = shipAddresses[rowInd].AddressLine2;
    //                                    sa.City = shipAddresses[rowInd].City;
    //                                    sa.Country = shipAddresses[rowInd].Country;
    //                                    sa.State = shipAddresses[rowInd].State;
    //                                    sa.Zip = shipAddresses[rowInd].Zip;
    //                                    sa.SalesTax = shipAddresses[rowInd].SalesTax;
                                         
    //                                }
    //                                else
    //                                {
    //                                    //0 AttachedAddressNumber means it is bill to address

                                        
    //                                    sa.AddressLine1 = cus.BillToAddress.AddressLine1;
    //                                    sa.AddressLine2 = cus.BillToAddress.AddressLine2;
    //                                    sa.City = cus.BillToAddress.City;
    //                                    sa.Country = cus.BillToAddress.Country;
    //                                    sa.State = cus.BillToAddress.State;
    //                                    sa.Zip = cus.BillToAddress.Zip;
    //                                    sa.SalesTax = cus.SalesTaxCode.SalestaxId;
    //                                }
    //                                cus.ShiptoAddresses.Add(sa);
    //                            }
    //                        }
    //                        //cus.ShiptoAddresses = shipAddresses;


    //                    }

                       
    //                    list.Add(cus);
    //                }

    //                if (con.State == ConnectionState.Open)
    //                    con.Close();
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetCustomers");
    //        }
    //        return list;
    //    }


    //    public CityStateZipCountry  GetCitySTZipCountry()
    //    {
    //        List<string> Cities = new List<string>();
    //        List<String> States = new List<string>();
    //        List<String> Zips = new List<string>();
    //        List<String> Countries = new List<string>();
             
    //        try
    //        {
                

    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            if (this.peachObj.CurrentCompanyGUID == null)
    //            {
    //                MessageBox.Show("Please open company first", "Prosoftmods.com ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    //                return  new CityStateZipCountry ();
    //            }
    //            if (this.peachObj.CurrentCompanyGUID == "")
    //            {
    //                MessageBox.Show("Please open company first", "Prosoftmods.com ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    //                return new  CityStateZipCountry ();
    //            }
    //            string CompanyGuid = peachObj.CurrentCompanyGUID;
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return new  CityStateZipCountry ();
    //            }
    //            this.con.Open();

               
    //            if (this.con.State == ConnectionState.Open)
    //            {

    //                DataTable shipDt = new DataTable();


    //                this.da = new OleDbDataAdapter("Select City,state,zip,country from CityzipstCountry  where CityzipstCountry.CompanyGuid ='" + CompanyGuid + "' union all Select City,state,zip,country from Shipto where Shipto.CompanyGuid ='" + CompanyGuid + "'   ", this.con);
    //                this.da.Fill(shipDt);


    //                if (con.State == ConnectionState.Open)
    //                    con.Close();

    //                foreach (DataRow shipRow in shipDt.Rows)
    //                {
                        


    //                    string city = Convert.ToString((shipRow["City"] == null) ? "" : shipRow["City"]);

    //                    if (city.Length > 0)
    //                        if (Cities.Contains(city) == false)
    //                        {
    //                            Cities.Add(city);
    //                        };
                         
    //                    String State = Convert.ToString((shipRow["State"] == null) ? "" : shipRow["State"]);
    //                    if (State.Length > 0)
    //                        if (States.Contains(State) == false)
    //                            States.Add(State);

                         
    //                    String Zip = Convert.ToString((shipRow["ZIP"] == null) ? "" : shipRow["ZIP"]);
    //                    if (Zip.Length > 0)
    //                        if (Zips.Contains(Zip) == false)
    //                            Zips.Add(Zip);

                         
    //                    String Country = Convert.ToString((shipRow["Country"] == null) ? "" : shipRow["Country"]);
    //                    if (Country.Length > 0)
    //                        if (Countries.Contains(Country) == false)
    //                            Countries.Add(Country);
                         
    //                }

    //            }
    //            CityStateZipCountry shipData = new CityStateZipCountry();
    //            shipData.Cities = Cities;
    //            shipData.Countries = Countries;
    //            shipData.States = States;
    //            shipData.Zips = Zips;

                
    //            return shipData;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetCitySTZipCountry");
    //        }
    //        return new CityStateZipCountry();
    //    }

  
       

    //    //public List<HRobItem> GetHBRAccounts()
    //    //{
    //    //    List<HRobItem> list = new List<HRobItem>();
    //    //    try
    //    //    {
    //    //        DataTable dataTable = new DataTable();
    //    //        this.peachObj = new PeachtreeSingleTon();
    //    //        this.readconfile = new ReadConfigFile();
    //    //        this.con = new OleDbConnection();
    //    //        this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //    //        if (this.con.ConnectionString == null)
    //    //        {
    //    //            return list;
    //    //        }
    //    //        this.con.Open();
    //    //        HRobItem item = new HRobItem();
    //    //        if (this.con.State != ConnectionState.Open)
    //    //        {
    //    //            return list;
    //    //        }
    //    //        DataTable table2 = new DataTable();
    //    //        this.da = new OleDbDataAdapter("Select * from HRBAccounts where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' Order by AccountNo", this.con);
    //    //        this.da.Fill(dataTable);

    //    //        if (this.con.State == ConnectionState.Open)
    //    //            this.con.Close();

    //    //        for (int i = 0; i < dataTable.Rows.Count; i++)
    //    //        {
    //    //            DataRow row = dataTable.Rows[i];
    //    //            item = new HRobItem();
    //    //            item.Description = Convert.ToString(row["HRBDescription"]);
    //    //            item.SalesAccount.AccountId = Convert.ToString(row["AccountNo"]);
    //    //            item.SalesAccount.GuId = Convert.ToString(row["SalesAccGUID"]);
    //    //            item.InventoryAccount.AccountId = Convert.ToString(row["InventoryAccID"]);
    //    //            item.InventoryAccount.GuId = Convert.ToString(row["InventoryAccGUID"]);
    //    //            item.CGSAccount.AccountId = Convert.ToString(row["CGSAccID"]);
    //    //            item.CGSAccount.GuId = Convert.ToString(row["CGSAccGUID"]);
    //    //            item.LineNo = Convert.ToInt32(row["LineNo"]);
    //    //            list.Add(item);
    //    //        }
    //    //    }
    //    //    catch (Exception exception)
    //    //    {
    //    //        MessageBox.Show(exception.Message, "GetItems");
    //    //    }
    //    //    return list;
    //    //}

    //    public Item GetItem(Item item)
    //    {
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != null)
    //            {
    //                List<ItemTaxesType> itemTaxTypes = this.GetItemTaxTypes();

    //                this.con.Open();
                    
    //                if (this.con.State != ConnectionState.Open)
    //                {
    //                    return item;
    //                }
    //                DataTable table2 = new DataTable();
    //                DataTable dtAttribute = new DataTable();
    //                this.da = new OleDbDataAdapter("Select * from 99Price where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //                this.da.Fill(table2);
    //                this.da = new OleDbDataAdapter("Select * from Items where ItemGUID='" + item.GuId + "' and   CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' order by ID", this.con);
    //                this.da.Fill(dataTable);
    //                this.da = new OleDbDataAdapter("Select * from Attributes where AttributeGuId='"+ item.GuId  + "' and CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' ", con);
    //                    da.Fill(dtAttribute);
                    
    //                if (con.State == ConnectionState.Open)
    //                    con.Close();

    //                for (int i = 0; i < dataTable.Rows.Count; i++)
    //                {
    //                    DataRow row = dataTable.Rows[i];
    //                    item = new Item();
    //                    item.ItemId = Convert.ToString(row["ItemID"]);
    //                    item.SaleDescription = Convert.ToString(row["SalesDes"]);
    //                    item.ItemDescription = Convert.ToString(row["Description"]);
    //                    item.CurrenttaxType = Convert.ToInt16(row["TaxType"]);
    //                    item.TaxType = itemTaxTypes;
    //                    item.SalesAccount.AccountId = Convert.ToString(row["SAccountID"]);
    //                    item.SalesAccount.GuId = Convert.ToString(row["SAccountGuid"]);
    //                    item.InventoryAccount.AccountId = Convert.ToString(row["InvAccountID"]);
    //                    item.InventoryAccount.GuId = Convert.ToString(row["InvAccountGUID"]);
    //                    item.CGSAccount.AccountId = Convert.ToString(row["CgsAccountID"]);
    //                    item.CGSAccount.GuId = Convert.ToString(row["CgsAccountGUID"]);
    //                    item.StockingUMID = Convert.ToString(row["StockingUMID"]);
    //                    item.Weight = Convert.ToDecimal(row["Weight"]);
    //                    item.GuId = Convert.ToString(row["ItemGUID"]);
    //                    item.ItemClass = (ItemClass) Convert.ToInt16(row["ItemClass"]);
    //                    item.QuantityonHand = Convert.ToDecimal(row["QuantityOnHand"]);
    //                    DataRow[] rowArray = table2.Select("ItemGUID='" + item.GuId + "'");
    //                    if (rowArray.Length > 0)
    //                    {
    //                        item.LastUnitCost = Math.Round(Convert.ToDecimal(rowArray[0]["LastCost"]), 2);
    //                        item.CurrentPrice = Math.Round(Convert.ToDecimal(rowArray[0]["PriceLevel1"]), 2);
    //                        for (int j = 0; j < 10; j++)
    //                        {
    //                            PriceLevel level = new PriceLevel();
    //                            DataRow row2 = rowArray[j];
    //                            level.Price = Math.Round(Convert.ToDecimal(row2["Price"]), 2);
    //                            level.Level = Convert.ToString(row2["ItemPriceLevel"]);
    //                            level.Id = Convert.ToInt32(row2["ItemPriceLevelID"]);
    //                            item.PriceLevels.Add(level);
    //                        }
    //                    }

    //                    for (int j      = 0; j < dtAttribute.Rows.Count ; j++)
    //                    {
    //                        DataRow row2 = dtAttribute.Rows[j];

    //                        AttributeLineItem atl = new AttributeLineItem();
    //                        atl.Id = Convert.ToString(row2["PriID"]);
    //                        atl.Description = Convert.ToString(row2["PriDescription"]);
    //                        atl.Type = AttributeType.Primary;
    //                        item.MasterStockGUID = Convert.ToString(row2["ItemGUID"]);

    //                        item.PrimaryAttribute.Name = Convert.ToString(row2["PriAttributeName"]);
    //                        item.PrimaryAttribute.AttributeLines.Add(atl);

    //                        item.SecondaryAttribute.Name = Convert.ToString(row2["SecAttributeName"]);

    //                        if (item.SecondaryAttribute.Name.Length > 0)
    //                        {
    //                            atl = new AttributeLineItem();
    //                            atl.Id = Convert.ToString(row2["SecID"]);
    //                            atl.Description = Convert.ToString(row2["SecDescription"]);
    //                            atl.Type = AttributeType.Secondary;
    //                            item.SecondaryAttribute.AttributeLines.Add(atl);
    //                        }
    //                    }
                        
                           
    //                }
    //            }
    //            return item;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetItem");
    //        }
    //        return item;
    //    }

    //    public List<Item> GetItem(ItemClass itmcls)
    //    {
    //        List<Item> list = new List<Item>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            List<ItemTaxesType> itemTaxTypes = this.GetItemTaxTypes();
    //            this.con.Open();
    //            Item item = new Item();
                
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
    //            this.da = new OleDbDataAdapter(string.Concat(new object[] { "Select * from Items where CompanyGUID='", this.peachObj.CurrentCompanyGUID, "' and ItemClass='", Convert.ToInt16(itmcls), "'" }), this.con);
    //            this.da.Fill(dataTable);

    //            if (con.State == ConnectionState.Open)
    //                con.Close();

    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new Item();
    //                item.ItemId = Convert.ToString(row["ItemID"]);
    //                item.SaleDescription = Convert.ToString(row["SalesDes"]);
    //                item.ItemDescription = Convert.ToString(row["Description"]);
    //                item.CurrenttaxType = Convert.ToInt16(row["TaxType"]);
    //                item.TaxType = itemTaxTypes;
    //                item.SalesAccount.AccountId = Convert.ToString(row["SAccountID"]);
    //                item.SalesAccount.GuId = Convert.ToString(row["SAccountGuid"]);
    //                item.StockingUMID = Convert.ToString(row["StockingUMID"]);
    //                item.Weight = Convert.ToDecimal(row["Weight"]);
    //                item.GuId = Convert.ToString(row["ItemGUID"]);
    //                item.ItemClass = (ItemClass) Convert.ToInt16(row["ItemClass"]);
    //                item.QuantityonHand = Convert.ToDecimal(row["QuantityOnHand"]);
    //                list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetItem");
    //        }
    //        return list;
    //    }

    //    public List<Item> GetItems()
    //    {
    //        List<Item> list = new List<Item>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            List<ItemTaxesType> itemTaxTypes = this.GetItemTaxTypes();

    //            this.con.Open();
    //            Item item = new Item();
                
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
                
    //            DataTable table2 = new DataTable();
    //            DataTable dtAttribute =new DataTable();
    //            this.da = new OleDbDataAdapter("Select * from 99Price where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //            this.da.Fill(table2);
    //            this.da = new OleDbDataAdapter("Select * from Items where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' order by ItemID", this.con);
    //            this.da.Fill(dataTable);
    //            this.da = new OleDbDataAdapter("Select * from Attributes where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' ", con);
    //            da.Fill(dtAttribute);


    //            if (con.State == ConnectionState.Open)
    //                con.Close();

    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new Item();
    //                item.ItemId = Convert.ToString(row["ItemID"]);
    //                item.SaleDescription = Convert.ToString(row["SalesDes"]);
    //                item.ItemDescription = Convert.ToString(row["Description"]);
    //                item.CurrenttaxType = Convert.ToInt16(row["TaxType"]);
    //                item.TaxType = itemTaxTypes;
    //                item.SalesAccount.AccountId = Convert.ToString(row["SAccountID"]);
    //                item.SalesAccount.GuId = Convert.ToString(row["SAccountGuid"]);
    //                item.InventoryAccount.AccountId = Convert.ToString(row["InvAccountID"]);
    //                item.InventoryAccount.GuId = Convert.ToString(row["InvAccountGUID"]);
    //                item.CGSAccount.AccountId = Convert.ToString(row["CgsAccountID"]);
    //                item.CGSAccount.GuId = Convert.ToString(row["CgsAccountGUID"]);
    //                item.StockingUMID = Convert.ToString(row["StockingUMID"]);
    //                item.Weight = Convert.ToDecimal(row["Weight"]);
    //                item.GuId = Convert.ToString(row["ItemGUID"]);
    //                item.ItemClass = (ItemClass) Convert.ToInt16(row["ItemClass"]);
    //                item.QuantityonHand = Convert.ToDecimal(row["QuantityOnHand"]);
    //                DataRow[] rowArray = table2.Select("ItemGUID='" + item.GuId + "'");
    //                if (rowArray.Length > 0)
    //                {
    //                    item.LastUnitCost = Math.Round(Convert.ToDecimal(rowArray[0]["LastCost"]), 2);
                        
    //                    item.CurrentPrice = Math.Round(Convert.ToDecimal(rowArray[0]["PriceLevel1"]), 2);
    //                    for (int j = 0; j < 10; j++)
    //                    {
    //                        PriceLevel level = new PriceLevel();
    //                        DataRow row2 = rowArray[j];
    //                        level.Price = Math.Round(Convert.ToDecimal(row2["Price"]), 2);
    //                        level.Level = Convert.ToString(row2["ItemPriceLevel"]);
    //                        level.Id = Convert.ToInt32(row2["ItemPriceLevelID"]);
    //                        item.PriceLevels.Add(level);
    //                    }
    //                }
    //                if (item.ItemClass == ItemClass.SubStockItem)
    //                {
    //                   rowArray = dtAttribute.Select("AttributeGUID='"+item.GuId +"'" );
    //                   if (rowArray.Length > 0)
    //                   {
    //                       DataRow row2 =rowArray[0];
    //                       AttributeLineItem atl =new AttributeLineItem();
    //                       atl.Id  =Convert.ToString ( row2["PriID"]);
    //                       atl.Description =Convert.ToString ( row2["PriDescription"]);
    //                       atl.Type = AttributeType.Primary;
    //                       item.MasterStockGUID = Convert.ToString(row2["ItemGUID"]);

    //                       item.PrimaryAttribute.Name = Convert.ToString(row2["PriAttributeName"]);
    //                       item.PrimaryAttribute.AttributeLines.Add(atl);

    //                       item.SecondaryAttribute.Name = Convert.ToString(row2["SecAttributeName"]);

    //                       if (item.SecondaryAttribute.Name.Length > 0)
    //                       {
    //                           atl =new AttributeLineItem();
    //                           atl.Id = Convert.ToString(row2["SecID"]);
    //                           atl.Description =Convert.ToString(row2 ["SecDescription"]);
    //                           atl.Type =AttributeType.Secondary;
    //                           item.SecondaryAttribute .AttributeLines.Add(atl);
    //                       }
                           


    //                   }

    //                }

    //                 if(item.ItemClass !=ItemClass.MasterStockItem )
    //                list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetItems");
    //        }
    //        return list;
    //    }


    //    public List<AttributeLineItem> GetSecondaryAttributes(Item itm)
    //    {
    //        List<AttributeLineItem> list = new List<AttributeLineItem>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
               
    //            this.con.Open();
    //            AttributeLineItem item = new AttributeLineItem();

    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }

    //            DataTable table2 = new DataTable();
    //            DataTable dtAttribute = new DataTable();


    //            this.da = new OleDbDataAdapter("Select Distinct SecDescription,SecID,SecAttributeName from Attributes where ItemGUID='" + itm.MasterStockGUID + "' and CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' ", con);
    //            da.Fill(dtAttribute);


    //            if (con.State == ConnectionState.Open)
    //                con.Close();

    //            for (int i = 0; i < dtAttribute.Rows.Count; i++)
    //            {
    //                DataRow row = dtAttribute.Rows[i];

    //                AttributeLineItem atl = new AttributeLineItem();

    //                if (Convert.ToString(row["SecAttributeName"]).Length > 0)
    //                {
    //                    atl = new AttributeLineItem();
    //                    atl.Id = Convert.ToString(row["SecID"]);
    //                    atl.Description = Convert.ToString(row["SecDescription"]);
    //                    atl.Type = AttributeType.Secondary;
    //                    list.Add(atl);
    //                }
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSecondaryAttributes");
    //        }
    //        return list;
    //    }

    //    public String GetMasterStockDescription(Item itm)
    //    {
    //        List<Item> list = new List<Item>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return "";
    //            }


    //            this.con.Open();
    //            Item item = new Item();

    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return "";
    //            }

    //            DataTable table2 = new DataTable();
    //            DataTable dtAttribute = new DataTable();

    //            cmd = new OleDbCommand("Select Description from Items where ItemGUID='" + itm.MasterStockGUID + "' and CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' order by ItemID", this.con);
    //            if (cmd.ExecuteScalar() == null)
    //                return "";
    //            else
    //                return Convert.ToString(cmd.ExecuteScalar());

    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetMasterStockDescription");
    //        }
    //        finally
    //        {
    //            if (con.State == ConnectionState.Open)
    //                con.Close();

    //        }
    //        return "";
    //    }

    //    public List<Item> GetNonStockItems()
    //    {
    //        List<Item> list = new List<Item>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            List<ItemTaxesType> itemTaxTypes = this.GetItemTaxTypes();

    //            this.con.Open();
    //            Item item = new Item();
                
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
    //            DataTable table2 = new DataTable();
    //            this.da = new OleDbDataAdapter("Select * from 99Price where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //            this.da.Fill(table2);
    //            this.da = new OleDbDataAdapter("Select * from Items where ItemClass='0' and CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' order by ItemID", this.con);
    //            this.da.Fill(dataTable);

    //            if (con.State == ConnectionState.Open)
    //                con.Close();

    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new Item();
    //                item.ItemId = Convert.ToString(row["ItemID"]);
    //                item.SaleDescription = Convert.ToString(row["SalesDes"]);
    //                item.ItemDescription = Convert.ToString(row["Description"]);
    //                item.CurrenttaxType = Convert.ToInt16(row["TaxType"]);
    //                item.TaxType = itemTaxTypes;
    //                item.SalesAccount.AccountId = Convert.ToString(row["SAccountID"]);
    //                item.SalesAccount.GuId = Convert.ToString(row["SAccountGuid"]);
    //                item.InventoryAccount.AccountId = Convert.ToString(row["InvAccountID"]);
    //                item.InventoryAccount.GuId = Convert.ToString(row["InvAccountGUID"]);
    //                item.CGSAccount.AccountId = Convert.ToString(row["CgsAccountID"]);
    //                item.CGSAccount.GuId = Convert.ToString(row["CgsAccountGUID"]);
    //                item.StockingUMID = Convert.ToString(row["StockingUMID"]);
    //                item.Weight = Convert.ToDecimal(row["Weight"]);
    //                item.GuId = Convert.ToString(row["ItemGUID"]);
    //                item.ItemClass = (ItemClass)Convert.ToInt16(row["ItemClass"]);
    //                item.QuantityonHand = Convert.ToDecimal(row["QuantityOnHand"]);
    //                DataRow[] rowArray = table2.Select("ItemGUID='" + item.GuId + "'");
    //                if (rowArray.Length > 0)
    //                {
    //                    item.LastUnitCost = Math.Round(Convert.ToDecimal(rowArray[0]["LastCost"]), 2);

    //                    item.CurrentPrice = Math.Round(Convert.ToDecimal(rowArray[0]["PriceLevel1"]), 2);
    //                    for (int j = 0; j < 10; j++)
    //                    {
    //                        PriceLevel level = new PriceLevel();
    //                        DataRow row2 = rowArray[j];
    //                        level.Price = Math.Round(Convert.ToDecimal(row2["Price"]), 2);
    //                        level.Level = Convert.ToString(row2["ItemPriceLevel"]);
    //                        level.Id = Convert.ToInt32(row2["ItemPriceLevelID"]);
    //                        item.PriceLevels.Add(level);
    //                    }
    //                }
    //                list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetNonStockItems");
    //        }
    //        return list;
    //    }



    //    public List<Item> GetNonStockServiceStockItems()
    //    {
    //        List<Item> list = new List<Item>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            List<ItemTaxesType> itemTaxTypes = this.GetItemTaxTypes();

    //            this.con.Open();
    //            Item item = new Item();

    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
                
    //            DataTable table2 = new DataTable();
    //            this.da = new OleDbDataAdapter("Select * from 99Price where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //            this.da.Fill(table2);
    //            this.da = new OleDbDataAdapter("Select * from Items where (ItemClass ='0' or itemclass ='1' or itemclass ='4') and CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' order by ID", this.con);
    //            this.da.Fill(dataTable);

    //            if (con.State == ConnectionState.Open)
    //                con.Close();

    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new Item();
    //                item.ItemId = Convert.ToString(row["ItemID"]);
    //                item.SaleDescription = Convert.ToString(row["SalesDes"]);
    //                item.ItemDescription = Convert.ToString(row["Description"]);
    //                item.CurrenttaxType = Convert.ToInt16(row["TaxType"]);
    //                item.TaxType = itemTaxTypes;
    //                item.SalesAccount.AccountId = Convert.ToString(row["SAccountID"]);
    //                item.SalesAccount.GuId = Convert.ToString(row["SAccountGuid"]);
    //                item.InventoryAccount.AccountId = Convert.ToString(row["InvAccountID"]);
    //                item.InventoryAccount.GuId = Convert.ToString(row["InvAccountGUID"]);
    //                item.CGSAccount.AccountId = Convert.ToString(row["CgsAccountID"]);
    //                item.CGSAccount.GuId = Convert.ToString(row["CgsAccountGUID"]);
    //                item.StockingUMID = Convert.ToString(row["StockingUMID"]);
    //                item.Weight = Convert.ToDecimal(row["Weight"]);
    //                item.GuId = Convert.ToString(row["ItemGUID"]);
    //                item.ItemClass = (ItemClass)Convert.ToInt16(row["ItemClass"]);
    //                item.QuantityonHand = Convert.ToDecimal(row["QuantityOnHand"]);
    //                DataRow[] rowArray = table2.Select("ItemGUID='" + item.GuId + "'");
    //                if (rowArray.Length > 0)
    //                {
    //                    item.LastUnitCost = Math.Round(Convert.ToDecimal(rowArray[0]["LastCost"]), 2);
    //                    item.CurrentPrice = Math.Round(Convert.ToDecimal(rowArray[0]["PriceLevel1"]), 2);
    //                    for (int j = 0; j < 10; j++)
    //                    {
    //                        PriceLevel level = new PriceLevel();
    //                        DataRow row2 = rowArray[j];
    //                        level.Price = Math.Round(Convert.ToDecimal(row2["Price"]), 2);
    //                        level.Level = Convert.ToString(row2["ItemPriceLevel"]);
    //                        level.Id = Convert.ToInt32(row2["ItemPriceLevelID"]);
    //                        item.PriceLevels.Add(level);
    //                    }
    //                }

    //                if (item.ItemClass == ItemClass.nonstockItem || item.ItemClass == ItemClass.stockItem || item.ItemClass == ItemClass.service)
    //                    list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetNonStockServiceStockItems");
    //        }
    //        return list;
    //    }

    //    public List<ItemTaxesType> GetItemTaxTypes()
    //    {
    //        List<ItemTaxesType> list = new List<ItemTaxesType>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            this.con.Open();
    //            ItemTaxesType item = new ItemTaxesType();
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
    //            this.da = new OleDbDataAdapter("Select * from ItemTaxes where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //            this.da.Fill(dataTable);

    //            if (con.State == ConnectionState.Open)
    //                con.Close();

    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new ItemTaxesType();
    //                item.IsTaxable = Convert.ToBoolean(row["IsTaxable"]);
    //                item.Number = Convert.ToInt16(row["TaxNumber"]);
    //                item.TaxType = Convert.ToString(row["ItemTaxType"]);
    //                list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetItemTaxTypes");
    //        }
    //        return list;
    //    }

    //    public List<Job> GetJobs()
    //    {
    //        List<Job> list = new List<Job>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            this.con.Open();
    //            Job item = new Job();
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
    //            this.da = new OleDbDataAdapter("Select * from Jobs where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //            this.da.Fill(dataTable);
                
    //            if (con.State == ConnectionState.Open)
    //                con.Close();

    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new Job();
    //                item.Id = Convert.ToString(row["JobID"]);
    //                item.UsePhases = Convert.ToBoolean(row["UsePhases"]);
    //                item.GuId = Convert.ToString(row["JobGUID"]);
    //                if (item.UsePhases)
    //                {
    //                    item.Phases = this.GetPhases();
    //                }
    //                list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetJobs");
    //        }
    //        return list;
    //    }

    //    public List<Phase> GetPhases()
    //    {
    //        List<Phase> list = new List<Phase>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            this.con.Open();
    //            Phase item = new Phase();
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
    //            this.da = new OleDbDataAdapter("Select * from Phases where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //            this.da.Fill(dataTable);

    //            if (con.State == ConnectionState.Open)
    //                con.Close();

    //            List<CostCode> costCodes = this.GetCostCodes();
    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new Phase();
    //                item.Id = Convert.ToString(row["PhaseID"]);
    //                item.Description = Convert.ToString(row["Description"]);
    //                item.CostType = Convert.ToString(row["CostType"]);
    //                item.UsecostCodes = Convert.ToBoolean(row["UseCostCodes"]);
    //                if (item.UsecostCodes)
    //                {
    //                    item.CostCode = costCodes;
    //                }
    //                list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetPhases");
    //        }
    //        return list;
    //    }

    //    public List<Quote> GetQuoteNumbers()
    //    {
    //        List<Quote> list = new List<Quote>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            this.con.Open();
    //            Quote item = new Quote();
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
    //            this.da = new OleDbDataAdapter("Select * from QuoteNumber where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //            this.da.Fill(dataTable);

    //            if (con.State == ConnectionState.Open)
    //                con.Close();

    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new Quote();
    //                item.QuoteNo = Convert.ToString(row["QuoteNo"]);
    //                item.TransactionGUID = Convert.ToString(row["QuoteGUID"]);
    //                list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message);
    //        }
    //        return list;
    //    }

    
   
    //    public List<SalesPerson> GetSalePersonReps()
    //    {
    //        List<SalesPerson> list = new List<SalesPerson>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            this.con.Open();
    //            SalesPerson item = new SalesPerson();
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
    //            this.da = new OleDbDataAdapter("Select * from SalesReps where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' order by ID", this.con);
    //            this.da.Fill(dataTable);

    //            if (this.con.State == ConnectionState.Open)
    //                this.con.Close();


    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new SalesPerson();
    //                item.Id = Convert.ToString(row["SalesRepID"]);
    //                item.Name = Convert.ToString(row["SalesRepName"]);
    //                item.Guid = Convert.ToString(row["SalesRepGUID"]);
    //                item.EmployeeType = EmployeeType.SalesRep;
    //                item.IsInActive = Convert.ToBoolean(row["IsInActive"]);
    //                list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSaleReps");
    //        }
    //        return list;
    //    }

    //    public List<SalesPerson> GetSaleReps()
    //    {
    //        List<SalesPerson> list = new List<SalesPerson>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            this.con.Open();
    //            SalesPerson item = new SalesPerson();
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
    //            this.da = new OleDbDataAdapter("Select * from SalesReps where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' order by ID", this.con);
    //            this.da.Fill(dataTable);

    //            if (this.con.State == ConnectionState.Open)
    //                this.con.Close();

    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new SalesPerson();
    //                item.Id = Convert.ToString(row["SalesRepID"]);
    //                item.Name = Convert.ToString(row["SalesRepName"]);
    //                item.Guid = Convert.ToString(row["SalesRepGUID"]);
    //                item.EmployeeType = EmployeeType.SalesRep;
    //                item.Address.AddressLine1 = Convert.ToString(row["Address1"]);
    //                list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSaleRep");
    //        }
    //        return list;
    //    }

    //    public List<SalesTaxAuthority> GetSalesTaxAuthorities()
    //    {
    //        List<SalesTaxAuthority> list = new List<SalesTaxAuthority>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            this.con.Open();
    //            SalesTaxAuthority item = new SalesTaxAuthority();
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
    //            this.da = new OleDbDataAdapter("Select * from Authoritys where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //            this.da.Fill(dataTable);

    //            if (this.con.State == ConnectionState.Open)
    //                this.con.Close();

    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new SalesTaxAuthority(Convert.ToString(row["AuthID"]), Convert.ToDecimal(row["Rate"]), Convert.ToString(row["AccountID"]), Convert.ToString(row["AuthGUID"]), Convert.ToBoolean(row["UseFormula"]), Convert.ToDecimal(row["Rate2"]), (TaxBasis) Convert.ToInt16(row["TaxBasis"]), Convert.ToDecimal(row["TaxLimit"]));
    //                list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSalesTaxAuthorities");
    //        }
    //        return list;
    //    }

    //    public List<SalesTaxCode> GetSalesTaxCodes()
    //    {
    //        List<SalesTaxCode> list = new List<SalesTaxCode>();
    //        try
    //        {
    //            int num;
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            this.con.Open();
    //            SalesTaxCode item = new SalesTaxCode();
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
    //            this.da = new OleDbDataAdapter("Select * from TaxCodes where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //            this.da.Fill(dataTable);

    //            if (this.con.State == ConnectionState.Open)
    //                this.con.Close();


    //            List<SalesTaxAuthority> salesTaxAuthorities = this.GetSalesTaxAuthorities();
    //            item = new SalesTaxCode();
    //            for (num = 0; num < dataTable.Rows.Count; num++)
    //            {
    //                DataRow row = dataTable.Rows[num];
    //                if (item.SalestaxId != Convert.ToString(row["CodeID"]))
    //                {
    //                    item = new SalesTaxCode();
    //                    item.SalestaxId = Convert.ToString(row["CodeID"]);
    //                    item.SalestaxDescription = Convert.ToString(row["Description"]);
    //                    item.SalestaxGuid = Convert.ToString(row["CodeGUID"]);
    //                }
    //                item.SalesTaxAuthority.Add(new SalesTaxAuthority(Convert.ToString(row["AuthID"])));
    //                if (!list.Contains(item))
    //                {
    //                    list.Add(item);
    //                }
    //                else
    //                {
    //                    list[list.IndexOf(item)] = item;
    //                }
    //            }
    //            for (num = 0; num < list.Count; num++)
    //            {
    //                for (int i = 0; i < list[num].SalesTaxAuthority.Count; i++)
    //                {
    //                    list[num].SalesTaxAuthority[i] = salesTaxAuthorities[salesTaxAuthorities.IndexOf(list[num].SalesTaxAuthority[i])];
    //                }
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSalesTaxCodes");
    //        }
    //        return list;
    //    }

    //    public List<ShipVia> GetShipVias()
    //    {
    //        List<ShipVia> list = new List<ShipVia>();
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString == null)
    //            {
    //                return list;
    //            }
    //            this.con.Open();
    //            ShipVia item = new ShipVia();
    //            if (this.con.State != ConnectionState.Open)
    //            {
    //                return list;
    //            }
    //            this.da = new OleDbDataAdapter("Select * from Shipvias where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "' order by ID", this.con);
    //            this.da.Fill(dataTable);

    //            if (this.con.State == ConnectionState.Open)
    //                this.con.Close();

    //            for (int i = 0; i < dataTable.Rows.Count; i++)
    //            {
    //                DataRow row = dataTable.Rows[i];
    //                item = new ShipVia();
    //                item.Number = Convert.ToInt16(row["ShipNumber"]);
    //                item.ShippingMethod = Convert.ToString(row["ShippingMethod"]);
    //                item.GuId = Convert.ToString(row["ShipGUID"]);
    //                list.Add(item);
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetShipVias");
    //        }
    //        return list;
    //    }

    //    public bool IsDBUpdated()
    //    {
    //        try
    //        {
    //            DataTable dataTable = new DataTable();
    //            this.peachObj = new PeachtreeSingleTon();
    //            if (this.peachObj.CurrentCompanyGUID == null)
    //            {
    //                MessageBox.Show("Please open company first", "Prosoftmods.com ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    //            }
    //            if (this.peachObj.CurrentCompanyGUID == "")
    //            {
    //                MessageBox.Show("Please open company first", "Prosoftmods.com ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    //            }
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != null)
    //            {
    //                this.con.Open();
    //                Customer customer = new Customer();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.da = new OleDbDataAdapter("Select * from SaleInvoice where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'", this.con);
    //                    this.da.Fill(dataTable);
    //                    this.con.Close();
    //                    return (dataTable.Rows.Count > 0);
    //                }
    //            }
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "IsDBUpdated");
    //        }
    //        return false;
    //    }
    //}
}

