namespace DAL.SaleOrders
{
    using Common;
   // // using ExportImport;
    using OleDbHelper;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;

    //public class SaleOrderDBDAL
    //{
    //    private OleDbCommand cmd;
    //    private OleDbConnection con;
    //    private OleDbDataAdapter da;
    //    private DataTable dt;
    //    private ReadConfigFile readconfile;
    //    private ShipAddress shipAddress;
    //    private List<ShipAddress> shipAddresses;
    //    private OleDbTransaction tran;
    //    PeachtreeSingleTon peachObj;
        

    //    public SaleOrder GetSaleOrder(SaleOrder so)
    //    {
    //        SaleOrder order;
    //        try
    //        {
    //            this.readconfile = new ReadConfigFile();
    //            PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            this.dt = new DataTable();
    //            if (this.con.ConnectionString != "")
    //            {
    //                if (peachObj.CurrentCompanyGUID == null)
    //                {
    //                    return null;
    //                }
    //                if (peachObj.CurrentCompanyGUID == "")
    //                {
    //                    return null;
    //                }
    //                this.con.Open();
    //                this.cmd = new OleDbCommand();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.CommandText = "Select * from Saleorder where CompanyGuid ='" + peachObj.CurrentCompanyGUID + "' and soGUID='" + so.TransactionGUID + "' Order by ID";
    //                    this.da = new OleDbDataAdapter(this.cmd.CommandText, this.con);
    //                    this.da.Fill(this.dt);
    //                    this.con.Close();
    //                }
    //            }
    //            if (this.dt.Rows.Count > 0)
    //            {
    //                int num = 0;
    //                foreach (DataRow row in this.dt.Rows)
    //                {
    //                    so.ShipAddress.ShipToID = Convert.ToString((row["ShipToID"] == null) ? "" : row["ShipToID"]);
    //                    SaleOrderlineItem qli = so.LineItems[num++];
    //                    so.AddLineItem(qli);
    //                }
    //                so.AssignToLineItem(so);
    //                return so;
    //            }
    //            order = so;
    //        }
    //        catch (Exception)
    //        {
    //            if (this.con.State != ConnectionState.Closed)
    //            {
    //                this.con.Close();
    //            }
    //            throw;
    //        }
    //        return order;
    //    }


        
        
        
        





    //    public bool SaveShipAddressinCityZipStCountry(SaleOrder  so)
    //    {
    //        bool flag;
    //        try
    //        {
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != "")
    //            {
    //                peachObj = new PeachtreeSingleTon();
    //                this.con.Open();
    //                this.cmd = new OleDbCommand();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.tran = this.con.BeginTransaction();
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.Transaction = this.tran;

    //                    this.cmd.CommandType = CommandType.Text;
    //                    this.cmd.CommandText = string.Concat(new object[] { "insert into CityZipSTCountry(City,State,Zip,Country,CompanyGuid) values('", so.ShipAddress.City, "','", so.ShipAddress.State, "','", so.ShipAddress.Zip, "','", so.ShipAddress.Country, "','", peachObj.CurrentCompanyGUID, "')" });
    //                    if (this.cmd.ExecuteNonQuery() == 0)
    //                    {
    //                        this.tran.Rollback();
    //                        return false;
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
    //            throw;
    //        }
    //        return flag;
    //    }

    //}
}

