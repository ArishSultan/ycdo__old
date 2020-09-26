namespace DAL.Items
{
    using Common;
   // // using ExportImport;
    using OleDbHelper;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Linq;
    using System.Xml.Linq;
    using System.Windows.Forms;
    using System.ComponentModel ;
    using System.IO;
    using System.Text;


  

    //public class ItemsDAL
    //{


    //    private InventoryItemsList inventoryitesList;
    //    private Item item;
    //    private List<Item> items;

        

    //    private OleDbCommand cmd;
    //    private OleDbConnection con;
    //    private OleDbDataAdapter da;
    //    private DataTable dt;
    //    private PeachtreeSingleTon peachObj;
    //    private ReadConfigFile readconfile;
    //    private OleDbTransaction trans;

    //    private OleDbTransaction tran;

    //    public ItemsDAL()
    //    {
    //        peachObj = new PeachtreeSingleTon();

    //    }

    //    private string ItemFPath
    //    {
    //        get
    //        {
    //            return (this.Path + this.ItemFName);
    //        }
    //    }

    //    private string ItemFName = "Items.txt";
    //    private string Path = (Application.StartupPath + @"\");
        

    //    public int GetHRBItem(Item hrItem)
    //    {
    //        int num2;
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
    //                    return 0;
    //                }
    //                if (this.peachObj.CurrentCompanyGUID == "")
    //                {
    //                    return 0;
    //                }
    //                this.con.Open();
    //                this.cmd = new OleDbCommand();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.cmd.Connection = this.con;
    //                    string str = "Select LineNo from  HRBItems where  ItemGUID='" + hrItem.GuId + "' and CompanyGuid='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    this.cmd.CommandText = str;
    //                    this.cmd.CommandType = CommandType.Text;
    //                    int num = Convert.ToInt32(this.cmd.ExecuteScalar());
    //                    this.con.Close();
    //                    return num;
    //                }
    //            }
    //            num2 = 0;
    //        }
    //        catch (Exception)
    //        {
    //            if (this.con.State != ConnectionState.Closed)
    //            {
    //                this.con.Close();
    //            }
    //            throw;
    //        }
    //        return num2;
    //    }

    //    public List<Item> GetItems()
    //    {
    //        List<Item> list2;
    //        List<Item> list = new List<Item>();
    //        try
    //        {
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            this.dt = new DataTable();
    //            if (this.con.ConnectionString != null)
    //            {
    //                this.peachObj = new PeachtreeSingleTon();
    //                if ((this.peachObj.CurrentCompanyGUID != null) && (this.peachObj.CurrentCompanyGUID != ""))
    //                {
    //                    this.con.Open();
    //                    this.cmd = new OleDbCommand();
    //                    if (this.con.State == ConnectionState.Open)
    //                    {
    //                        this.cmd.Connection = this.con;
    //                        this.cmd.CommandType = CommandType.Text;
    //                        string selectCommandText = "SELECT * from Items where   CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                        this.da = new OleDbDataAdapter(selectCommandText, this.con);
    //                        this.da.Fill(this.dt);
    //                        this.con.Close();
    //                    }
    //                }
    //                if (this.dt.Rows.Count > 0)
    //                {
    //                    Item item = new Item();
    //                    int num = 0;
    //                    while (num < this.dt.Rows.Count)
    //                    {
    //                        HRobItem item2;
    //                        DataRow row = this.dt.Rows[num];
    //                        if (Convert.ToString(row["ItemID"]) != item.ItemId)
    //                        {
    //                            if ((item.ItemId != null) && (item.ItemId != ""))
    //                            {
    //                                list.Add(item);
    //                            }
    //                            item = new Item();
    //                            item.ItemId = Convert.ToString(row["ItemID"]);
    //                            item.GuId = Convert.ToString(row["ItemGUID"]);
    //                            item.ItemDescription = Convert.ToString(row["Description"]);
    //                            item.SalesAccount.AccountId = Convert.ToString(row["AccountNo"]);
    //                            item.SalesAccount.GuId = Convert.ToString(row["SalesAccGUID"]);
    //                            item.InventoryAccount.AccountId = Convert.ToString(row["InventoryAccID"]);
    //                            item.InventoryAccount.GuId = Convert.ToString(row["InventoryAccGUID"]);
    //                            item.CGSAccount.AccountId = Convert.ToString(row["CGSAccID"]);
    //                            item.CGSAccount.GuId = Convert.ToString(row["CGSAccGUID"]);
    //                            item2 = new HRobItem();
    //                            item2.Description = Convert.ToString(row["HRBDescription"]);
    //                            item2.Item.ItemId = Convert.ToString(row["ItemID"]);
    //                            item2.Item.GuId = Convert.ToString(row["ItemGUID"]);
    //                            item2.SalesAccount.AccountId = Convert.ToString(row["AccountNo"]);
    //                            item2.SalesAccount.GuId = Convert.ToString(row["SalesAccGUID"]);
    //                            item2.InventoryAccount.AccountId = Convert.ToString(row["InventoryAccID"]);
    //                            item2.InventoryAccount.GuId = Convert.ToString(row["InventoryAccGUID"]);
    //                            item2.CGSAccount.AccountId = Convert.ToString(row["CGSAccID"]);
    //                            item2.CGSAccount.GuId = Convert.ToString(row["CGSAccGUID"]);
    //                            num++;
    //                        }
    //                        else
    //                        {
    //                            item2 = new HRobItem();
    //                            item2.Item.ItemId = Convert.ToString(row["ItemID"]);
    //                            item2.Description = Convert.ToString(row["HRBDescription"]);
    //                            item2.Item.GuId = Convert.ToString(row["ItemGUID"]);
    //                            item2.SalesAccount.AccountId = Convert.ToString(row["AccountNo"]);
    //                            item2.SalesAccount.GuId = Convert.ToString(row["SalesAccGUID"]);
    //                            item2.InventoryAccount.AccountId = Convert.ToString(row["InventoryAccID"]);
    //                            item2.InventoryAccount.GuId = Convert.ToString(row["InventoryAccGUID"]);
    //                            item2.CGSAccount.AccountId = Convert.ToString(row["CGSAccID"]);
    //                            item2.CGSAccount.GuId = Convert.ToString(row["CGSAccGUID"]);
    //                            num++;
    //                        }
    //                    }
    //                }
    //            }
    //            list2 = list;
    //        }
    //        catch (Exception)
    //        {
    //            if (this.con.State != ConnectionState.Closed)
    //            {
    //                this.con.Close();
    //            }
    //            throw;
    //        }
    //        return list2;
    //    }

    //    public bool SaveHRBAccounts(List<HRobItem> hrItems)
    //    {
    //        bool flag;
    //        try
    //        {
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            int num = 0;
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
    //                    this.trans = this.con.BeginTransaction();
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.Transaction = this.trans;
    //                    string str = "Delete from HRBAccounts where   CompanyGuid='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    this.cmd.CommandText = str;
    //                    this.cmd.CommandType = CommandType.Text;
    //                    this.cmd.ExecuteNonQuery();
    //                    string str2 = "";
    //                    HRobItem item = new HRobItem();
    //                    for (int i = 0; i < hrItems.Count; i++)
    //                    {
    //                        item = new HRobItem();
    //                        item = hrItems[i];
    //                        str2 = string.Concat(new object[] { 
    //                            "Insert into HRBAccounts(LineNo, HRBDescription, AccountNo,SalesAccGUID,InventoryAccID,InventoryAccGUID,CGSAccID,CGSAccGUID,CompanyGuid) values ('", item.LineNo, "','", item.Description.Replace("'", "''"), "','", item.SalesAccount.AccountId, "','", item.SalesAccount.GuId, "','", item.InventoryAccount.AccountId, "','", item.InventoryAccount.GuId, "','", item.CGSAccount.AccountId, "','", item.CGSAccount.GuId, 
    //                            "','", this.peachObj.CurrentCompanyGUID, "')"
    //                         });
    //                        this.cmd.CommandText = str2;
    //                        this.cmd.CommandType = CommandType.Text;
    //                        num = this.cmd.ExecuteNonQuery();
    //                    }
    //                    this.trans.Commit();
    //                    this.con.Close();
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

    //    public bool SaveHRBItem(HRobItem hrItem)
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
    //                    this.trans = this.con.BeginTransaction();
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.Transaction = this.trans;
    //                    string str = "";
    //                    str = "Select LineNo from HRBItems where  ItemGUID='" + hrItem.Item.GuId + "' and CompanyGuid='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    this.cmd.CommandText = str;
    //                    this.cmd.CommandType = CommandType.Text;
    //                    if (Convert.ToInt32(this.cmd.ExecuteScalar()) > 0)
    //                    {
    //                        str = string.Concat(new object[] { "Update  HRBItems set LineNo='", hrItem.LineNo, "' where  ItemGUID='", hrItem.Item.GuId, "' and CompanyGuid='", this.peachObj.CurrentCompanyGUID, "'" });
    //                    }
    //                    else
    //                    {
    //                        str = string.Concat(new object[] { "Insert into  HRBItems  (LineNo,ItemID,ItemGUID,CompanyGUID)values( '", hrItem.LineNo, "','", hrItem.Item.ItemId.Replace("'", "''"), "','", hrItem.Item.GuId, "','", this.peachObj.CurrentCompanyGUID, "')" });
    //                    }
    //                    this.cmd.CommandText = str;
    //                    this.cmd.CommandType = CommandType.Text;
    //                    this.cmd.ExecuteNonQuery();
    //                    this.trans.Commit();
    //                    this.con.Close();
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




    //    public List<Item> GetItem()
    //    {
    //        try
    //        {


    //            inventoryitesList = new InventoryItemsList();
    //            if (inventoryitesList.ExportInventoryItem() == true)
    //            {
    //                items = new List<Item>();
    //                XElement xdoc = XElement.Load(inventoryitesList.FileNameXML);
    //                var invElement = from el in xdoc.Elements("PAW_Item")
    //                                 select el;
    //                List<PriceLevel> defprices = new DefaultPriceLevelDAL().GetDefaultPrices();

    //                List<ItemTaxesType> itemtaxs = new ItemTaxTypeDAL().GetItemTaxType();
    //                foreach (var el in invElement)
    //                {//
    //                    if (el.Element("isInactive").Value == "FALSE" && el.Element("Class").Value != "8")// class 8 is master stock item
    //                    {
    //                        item = new Item();
    //                        item.ItemId = el.Element("ID").Value;
    //                        item.SaleDescription = el.Element("Description_for_Sales") == null ? "" : el.Element("Description_for_Sales").Value;
    //                        item.ItemDescription = el.Element("Description") == null ? "" : el.Element("Description").Value;
    //                        if (el.Element("Tax_Type") != null)
    //                        {
    //                            //  taxes are from 1 to 27 in actual 
    //                            // but saved in item from zero i.e 0 means 1
    //                            // so add a 1 to the value
    //                            item.CurrenttaxType = el.Element("Tax_Type") == null ? Convert.ToInt16(-1) : Convert.ToInt16(Convert.ToInt16(el.Element("Tax_Type").Value) + Convert.ToInt16(1));
    //                        }
    //                        item.TaxType = itemtaxs;
    //                        item.SalesAccount.AccountId = el.Element("GL_Sales_Account") == null ? "" : el.Element("GL_Sales_Account").Value;
    //                        item.SalesAccount.GuId = el.Element("GL_Sales_Account_GUID") == null ? "" : el.Element("GL_Sales_Account_GUID").Value;
    //                        item.StockingUMID = el.Element("Stocking_UM") == null ? "" : el.Element("Stocking_UM").Value;
    //                        item.Weight = el.Element("Weight") == null ? Convert.ToDecimal(0.00) : Convert.ToDecimal(el.Element("Weight").Value);
    //                        item.GuId = el.Element("GUID") == null ? "" : el.Element("GUID").Value;
    //                        item.ItemClass = el.Element("Class") == null ? 0 : (ItemClass)Convert.ToInt16(el.Element("Class").Value);


    //                        item.QuantityonHand = el.Element("QuantityOnHand") == null ? 0 : Convert.ToDecimal(el.Element("QuantityOnHand").Value);
    //                        //This is the default prices that come up from Peachtree 
    //                        //START ***********
    //                        //var priceElement = from priceE in el.Element ("Sales_Prices").Elements ()
    //                        //                   select priceE;
    //                        //int I=1;
    //                        //foreach (var priceE in priceElement)
    //                        //{
    //                        //    if (defprices.Count > 0)
    //                        //    {
    //                        //        PriceLevel prc =new PriceLevel();
    //                        //        prc.Id =I;
    //                        //        //if the price level exist in the Default Prices then
    //                        //        //show it in the price level list.
    //                        //        if (defprices.Contains(prc) == true)
    //                        //        {
    //                        //            prc =defprices[ defprices.IndexOf (prc )];
    //                        //            if (defprices[0].Id ==I) item.CurrentPrice = Convert.ToDecimal (priceE.Value);
    //                        //            item.PriceLevels.Add(new PriceLevel(Convert.ToDecimal (Convert.ToString(priceE.Value).ToString()),prc.Level , I));
    //                        //        }
    //                        //    }
    //                        //    I = I + 1;
    //                        //}

    //                        //*****************
    //                        //End of reading prices from peachtree.



    //                        items.Add(item);
    //                    }
    //                }
    //            }
    //            return items;
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetItem");
    //            return items;
    //        }

    //    }
    //    /// <summary>
    //    /// Return Item's Class of the given Item.
    //    /// </summary>
    //    /// <param name="it"></param>
    //    /// <returns></returns>
    //    public Item GetItemClass(Item it)
    //    {
    //        try
    //        {


    //            inventoryitesList = new InventoryItemsList();
    //            if (inventoryitesList.ExportItemClass(it.ItemId) == true)
    //            {

    //                XElement xdoc = XElement.Load(inventoryitesList.FileNameXML);
    //                var invElement = from el in xdoc.Elements("PAW_Item")
    //                                 select el;


    //                foreach (var el in invElement)
    //                {
    //                    if (el.Element("isInactive").Value == "FALSE" && el.Element("Class").Value != "8" && it.ItemId == el.Element("ID").Value)
    //                    {
    //                        item = new Item();
    //                        item.ItemId = el.Element("ID").Value;

    //                        item.GuId = el.Element("GUID") == null ? "" : el.Element("GUID").Value;
    //                        item.ItemClass = el.Element("Class") == null ? 0 : (ItemClass)Convert.ToInt16(el.Element("Class").Value);

    //                        return item;

    //                    }
    //                }

    //            }
    //            return item;
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetItemClass");
    //            return item;
    //        }

    //    }

    //    public Decimal GetQTYonHand(Item it)
    //    {
    //        try
    //        {


    //            inventoryitesList = new InventoryItemsList();
    //            if (inventoryitesList.ExportItemQtyOnHand() == true)
    //            {

    //                XElement xdoc = XElement.Load(inventoryitesList.FileNameXML);
    //                var invElement = from el in xdoc.Elements("PAW_Item")
    //                                 select el;


    //                foreach (var el in invElement)
    //                {
    //                    if (el.Element("isInactive").Value == "FALSE" && it.ItemId == el.Element("ID").Value)// class 8 is master stock item
    //                    {
    //                        return el.Element("QuantityOnHand") == null ? 0 : Convert.ToDecimal(el.Element("QuantityOnHand").Value);



    //                    }
    //                }

    //            }
    //            return 0;
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetQTYonHand");
    //            return 0;
    //        }

    //    }

    //    public List<Item> GetItemsQTYonHand(List<Item> items)
    //    {
    //        try
    //        {


    //            inventoryitesList = new InventoryItemsList();
    //            if (inventoryitesList.ExportItemQtyOnHand() == true)
    //            {

    //                XElement xdoc = XElement.Load(inventoryitesList.FileNameXML);
    //                var invElement = from el in xdoc.Elements("PAW_Item")
    //                                 select el;


    //                foreach (var el in invElement)
    //                {
    //                   // if (el.Element("isInactive").Value == "FALSE")
    //                    //&& it.ItemId == el.Element("ID").Value)// class 8 is master stock item
    //                    {
    //                        for (int i = 0; i < items.Count; i++)
    //                        {
    //                            if (items[i].ItemId == el.Element("ID").Value)
    //                            {
    //                                items[i].QuantityonHand = el.Element("QuantityOnHand") == null ? 0 : Convert.ToDecimal(el.Element("QuantityOnHand").Value);
    //                                break;
    //                            }
    //                        }

    //                    }
    //                }

    //            }
    //            return items;
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetQTYonHand");
    //            return items;
    //        }

    //    }


    //    public Decimal GetItemLastUnitCost(Item item)
    //    {
    //        try
    //        {


    //            inventoryitesList = new InventoryItemsList();
    //            if (inventoryitesList.ExportItemLastUnitCost(item.ItemId ) == true)
    //            {

    //                XElement xdoc = XElement.Load(inventoryitesList.FileNameXML);
    //                var invElement = from el in xdoc.Elements("PAW_Item")
    //                                 select el;


    //                foreach (var el in invElement)
    //                {
    //                    //if (el.Element("isInactive").Value == "FALSE")
    //                    //&& it.ItemId == el.Element("ID").Value)// class 8 is master stock item
    //                    {
    //                        // for (int i = 0; i < item.Count; i++)
    //                        {
    //                            if (item.GuId == el.Element("GUID").Value)
    //                            {
    //                                return el.Element("Last_Unit_Cost") == null ? 0 : Convert.ToDecimal(el.Element("Last_Unit_Cost").Value);

    //                            }
    //                        }

    //                    }
    //                }

    //            }

    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetItemLastUnitCost");

    //        }
    //        return 0;
    //    }


    //    public bool SaveQtyonHands(List<SaleInvoiceLineItem> siItems)
    //    {
    //        bool flag;
    //        try
    //        {

    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != "")
    //            {
    //                PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
    //                if (peachObj.CurrentCompanyGUID == null)
    //                {
    //                    return false;
    //                }
    //                if (peachObj.CurrentCompanyGUID == "")
    //                {
    //                    return false;
    //                }
    //                this.con.Open();
    //                this.cmd = new OleDbCommand();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.tran = this.con.BeginTransaction();
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.Transaction = this.tran;
    //                    this.cmd.CommandType = CommandType.Text;
    //                    List<Item> items = new List<Item>();
    //                    for (int i = 0; i < siItems.Count; i++)
    //                    {
    //                        items.Add(siItems[i].Item);
    //                    }
    //                    items = this.GetItemsQTYonHand(items);
    //                    for (int i = 0; i < siItems.Count; i++)
    //                    {
    //                        if ((siItems[i].Item.GuId != null) && (siItems[i].Item.GuId != ""))
    //                        {
    //                            this.cmd.CommandText = string.Concat(new object[] { "Update  Items set QuantityOnHand='", siItems[i].Item.QuantityonHand , "' where  CompanyGUID='", peachObj.CurrentCompanyGUID, "' and ItemGUID='", siItems[i].Item.GuId, "'" });
    //                            if (this.cmd.ExecuteNonQuery() == 0)
    //                            {
    //                                this.tran.Rollback();
    //                                this.con.Close();
    //                                return false;
    //                            }
    //                        }
    //                    }
    //                    this.tran.Commit();
    //                    this.con.Close();
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


    //    private  List<Item >  VerifyItemClass(String fromItemId,String toItemId)
    //    {

    //        List<Item> itemsinPt = new List<Item>();
    //        try
    //        {

    //            inventoryitesList = new InventoryItemsList();
    //            if (inventoryitesList.ExportItemID(fromItemId,toItemId  ) == true)
    //            {

    //                XElement xdoc = XElement.Load(inventoryitesList.FileNameXML);
    //                var invElement = from el in xdoc.Elements("PAW_Item")
    //                                 select el;


    //                foreach (var el in invElement)
    //                {
    //                    //if (el.Element("isInactive").Value == "FALSE" && el.Element("Class").Value != "8" && it.ItemId == el.Element("ID").Value)
    //                    {
    //                        item = new Item();
    //                        item.ItemId = el.Element("ID").Value;

    //                        item.GuId = el.Element("GUID") == null ? "" : el.Element("GUID").Value;
    //                        item.ItemClass = el.Element("Class") == null ? 0 : (ItemClass)Convert.ToInt16(el.Element("Class").Value);

    //                        itemsinPt .Add (item);

    //                    }
    //                }

    //            }
    //            return itemsinPt;
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetItemClass");
    //            return itemsinPt;
    //        }

    //    }
         

    //    public bool SaveNewItems(BackgroundWorker bgWorker, Item itm, Int64 noOfItems,Boolean isSingle)
    //    {
    //        Item item;
    //        List<Item> items = new List<Item>();
    //        try
    //        {
                 
    //            InventoryItemsList list = new InventoryItemsList();
    //            StreamWriter writer = new StreamWriter(list.FileNameCSV);
    //            string itmId=itm.ItemId ;
    //            string firstItemID = itm.ItemId, LastItemID = itm.ItemId; ;

    //            List<Item> itminPt = new List<Item>();
    //            if (isSingle == false)
    //            {
    //                itminPt = VerifyItemClass(itm.ItemId,itm.ItemId.Substring(0,3)+ noOfItems.ToString("-000-00-00-00"));
    //            }
    //            else
    //            {
    //                itminPt = VerifyItemClass(itm.ItemId, itm.ItemId);

    //            }
    //            if (itminPt.Count > 0)
    //            {
    //                MessageBox.Show("Item(s) already exist ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //                bgWorker.ReportProgress( 0, "alreadyexist");
    //                return false;
    //            }


    //            if (isSingle == false)
    //            {
                    
    //                Single minPgValue = 50 / noOfItems;//50=total no. of progress values available for this reading invoice

    //                Single repProgress = 40;
    //                for (int itmInd = 0; itmInd < noOfItems; itmInd++)
    //                {

    //                    if (itmInd == 0)
    //                    {

    //                        if (itm.ItemClass == ItemClass.nonstockItem)
    //                        {
    //                            writer.WriteLine(string.Concat(new object[] { "\"", itm.ItemId.Replace("\"", "''"), "\",\"", itm.ItemDescription.Replace("\"", "''"), "\",0,", itm.StockingUMID }));//, itm.LastUnitCost, ",", 0, ","
    //                        }
    //                    }
    //                    else
    //                    {
    //                        //create item id now 
    //                        //-000-00-00-00

    //                        string newIdpart = "";

    //                        //for (int stIndex = 0; stIndex < itmInd.ToString().Length; stIndex++)
    //                        //{

                            
    //                        //    if (stIndex == 2 || stIndex == 4 || stIndex == 6)
    //                        //        newIdpart = "-" + newIdpart;
    //                        //    newIdpart = itmInd.ToString()[itmInd.ToString().Length - 1 - stIndex] + newIdpart;


                            
    //                        //}
    //                        newIdpart = itmInd.ToString("-000-00-00-00");
    //                        itm.ItemId = itmId.Substring(0, itm.ItemId.Length - newIdpart.Length) + newIdpart;

    //                        LastItemID = itm.ItemId;

    //                        if (itm.ItemClass == ItemClass.nonstockItem)
    //                        {
    //                            writer.WriteLine(string.Concat(new object[] { "\"", itm.ItemId.Replace("\"", "''"), "\",\"", itm.ItemDescription.Replace("\"", "''"), "\",0,", itm.StockingUMID }));//, itm.LastUnitCost, ",", 0, ","
    //                        }
    //                        items.Add(itm);

    //                        repProgress = repProgress + minPgValue;
    //                        bgWorker.ReportProgress(Convert.ToInt32(repProgress));


    //                    }
    //                }
    //            }
    //            else
    //            {
    //                writer.WriteLine(string.Concat(new object[] { "\"", itm.ItemId.Replace("\"", "''"), "\",\"", itm.ItemDescription.Replace("\"", "''"), "\",0,", itm.StockingUMID }));//, itm.LastUnitCost, ",", 0, ","
    //            }
    //            writer.Flush();
    //            writer.Close();
    //            if ((((itm.ItemClass != ItemClass.assembly) && (itm.ItemClass != ItemClass.SerializedAssembly)) && (itm.ItemClass != ItemClass.MasterStockItem)) && (itm.ItemClass != ItemClass.SubStockItem))
    //            {
    //                bgWorker.ReportProgress(50);

    //                if (list.ImportNewItem()==true)
    //                {
    //                    bgWorker.ReportProgress(70);
    //                    items = GetItemAndPriceLevels(firstItemID ,LastItemID );
    //                    bgWorker.ReportProgress(90);
    //                    Get99PriceLevels(items);
    //                    bgWorker.ReportProgress(90);
    //                    Boolean res =  SaveNewNonStockitems();
    //                    bgWorker.ReportProgress(100);
    //                    return res;
                        

    //                }
    //            }
               
                
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return false ;
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
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return str2;
    //    }

    //    private  List<Item> GetItemAndPriceLevels(string firstItemID,string lastItemID)
    //    {
    //        List<Item> list = new List<Item>();
    //        try
    //        {
    //            this.inventoryitesList = new InventoryItemsList();
    //            if (!this.inventoryitesList.ExportNonStockNewCreatedItem(firstItemID, lastItemID))
    //            {
    //                return list;
    //            }
    //            StringBuilder builder = new StringBuilder();

    //            XElement xdoc = XElement.Load(inventoryitesList.FileNameXML);
    //            var xmlElement = from el in xdoc.Elements("PAW_Item")
    //                             select el;

             
    //            foreach (XElement element2 in xmlElement)
    //            {
    //                if ((element2.Element("isInactive").Value == "FALSE") && (element2.Element("Class").Value != "8"))
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
    //                }
    //            }
    //            if (File.Exists(this.ItemFPath))
    //            {
    //                File.Delete(this.ItemFPath);
    //            }
    //            File.AppendAllText(this.ItemFPath, "ItemID,SalesDes,Description,TaxType,SAccountID,SAccountGuid,InvAccountID,InvAccountGUID,CgsAccountID,CgsAccountGUID,StockingUMID,Weight,ItemGUID,ItemClass,QuantityOnHand ,CompanyGUID\r\n");

    //            File.AppendAllText(this.ItemFPath, builder.ToString());
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetItemAndPriceLevels");
    //        }
    //        return list;
    //    }


    //    public bool SaveNewNonStockitems( )
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

    //                   // this.cmd.CommandText = "Delete from Items where CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
    //                    //this.cmd.ExecuteNonQuery();
    //                    this.cmd.CommandText = "Insert into [Items](ItemID,SalesDes,Description,TaxType,SAccountID,SAccountGuid,InvAccountID,InvAccountGUID,CgsAccountID,CgsAccountGUID,StockingUMID,Weight,ItemGUID,ItemClass,QuantityOnHand ,CompanyGUID) Select ItemID,SalesDes,Description,TaxType,SAccountID,SAccountGuid,InvAccountID,InvAccountGUID,CgsAccountID,CgsAccountGUID,StockingUMID,Weight,ItemGUID,ItemClass,QuantityOnHand ,CompanyGUID FROM [Text;DATABASE=" + this.Path + ";].[" + this.ItemFName + "]";
    //                    num = this.cmd.ExecuteNonQuery();

    //                   // this.cmd.CommandText = "Delete * from 99Price where   CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";

    //                    //num = this.cmd.ExecuteNonQuery();
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
    //                    //if (File.Exists(this.Path + @"\Item" + currentCompanyGUID + ".txt"))
    //                    //{
    //                    //    File.Delete(this.Path + @"\Item" + currentCompanyGUID + ".txt");
    //                    //}
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

