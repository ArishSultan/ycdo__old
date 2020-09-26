namespace DAL
{
    using Common;
   // // using ExportImport;
    using OleDbHelper;
    using System;
    using System.Data;
    using System.Data.OleDb;

    //public class PriceLevel99DAL
    //{
    //    private OleDbCommand cmd;
    //    private OleDbConnection con;
    //    private OleDbDataAdapter da;
    //    private DataTable dt;
    //    private PeachtreeSingleTon peachObj;
    //    private ReadConfigFile readconfile;
    //    private OleDbTransaction trans;

    //    public Item Select99PriceLevel(Item itm)
    //    {
    //        Item item;
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
    //                    return itm;
    //                }
    //                if (this.peachObj.CurrentCompanyGUID == "")
    //                {
    //                    return itm;
    //                }
    //                this.con.Open();
    //                this.cmd = new OleDbCommand();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.CommandType = CommandType.Text;
    //                    this.cmd.CommandText = "Select MaxPriceLevel from MaxPriceLevels";
    //                    num = Convert.ToInt32(this.cmd.ExecuteScalar());
    //                    string selectCommandText = string.Concat(new object[] { "SELECT * FROM 99Price where  ItemPriceLevelID <=", PriceLevel.MaxPriceLevel, " and  itemGuid='", itm.GuId, "' and  CompanyGUID='", this.peachObj.CurrentCompanyGUID, "' order by ItemPriceLevelID" });
    //                    this.da = new OleDbDataAdapter(selectCommandText, this.con);
    //                    this.da.Fill(this.dt);
    //                    this.con.Close();
    //                }
    //            }
    //            if (this.dt.Rows.Count > 0)
    //            {
    //                itm.PriceLevels.Clear();
    //                for (int i = 0; i < PriceLevel.MaxPriceLevel; i++)
    //                {
    //                    DataRow row = this.dt.Rows[i];
    //                    PriceLevel level = new PriceLevel();
    //                    level.Id = Convert.ToInt32(row["ItemPriceLevelID"]);
    //                    level.Level = Convert.ToString(row["ItemPriceLevel"]);
    //                    level.Price = Math.Round(Convert.ToDecimal(row["Price"]), 2);
    //                    level.CalculationText = Convert.ToString(row["Calculation"]);
    //                    level.UseLevel = Convert.ToInt32(row["UseLevel"]);
    //                    level.AddSubLevel = Convert.ToInt32(row["AddSubLevel"]);
    //                    level.AddSubValue = Convert.ToDecimal(row["AddSubValue"]);
    //                    level.RoundLevel = Convert.ToInt32(row["RoundLevel"]);
    //                    level.RoundValue = Convert.ToDecimal(row["RoundValue"]);
    //                    level.PriceLevel1 = Math.Round(Convert.ToDecimal(row["PriceLevel1"]), 2);
    //                    level.LastCost = Math.Round(Convert.ToDecimal(row["LastCost"]), 2);
    //                    itm.PriceLevels.Add(level);
    //                }
    //            }
    //            item = itm;
    //        }
    //        catch (Exception)
    //        {
    //            if (this.con.State != ConnectionState.Closed)
    //            {
    //                this.con.Close();
    //            }
    //            throw;
    //        }
    //        return item;
    //    }

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
    //                    this.cmd.CommandText = "Select PriceLevelID from CustomerPriceLevel where CusGUID='" + cus.Guid + "' and CompanyGUID='" + this.peachObj.CurrentCompanyGUID + "'";
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
    //}
}

