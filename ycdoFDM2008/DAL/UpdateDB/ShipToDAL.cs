namespace DAL.UpdateDB
{
    using Common;
   // // using ExportImport;
    using OleDbHelper;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;

    public class ShipToDAL
    {
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private ShipAddress shipAddress;
        private List<ShipAddress> shipAddresses;
        private OleDbTransaction tran;

        public List<ShipAddress> GetShipToAddress(Customer cus)
        {
            List<ShipAddress> list=new List<ShipAddress>();
            //try
            //{
            //    this.readconfile = new ReadConfigFile();
            //    PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
            //    this.con = new OleDbConnection();
            //    this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            //    this.dt = new DataTable();
            //    if (this.con.ConnectionString != "")
            //    {
            //        if (peachObj.CurrentCompanyGUID == null)
            //        {
            //            return null;
            //        }
            //        if (peachObj.CurrentCompanyGUID == "")
            //        {
            //            return null;
            //        }
            //        this.con.Open();
            //        this.cmd = new OleDbCommand();
            //        if (this.con.State == ConnectionState.Open)
            //        {
            //            this.cmd.Connection = this.con;
            //            this.cmd.CommandText = "Select * from ShipTo where CompanyGuid ='" + peachObj.CurrentCompanyGUID + "' and CustomerID='" + cus.Id.Replace("'", "''") + "' Order by ShipToID";
            //            this.da = new OleDbDataAdapter(this.cmd.CommandText, this.con);
            //            this.da.Fill(this.dt);
            //            this.con.Close();
            //        }
            //    }
            //    if (this.dt.Rows.Count > 0)
            //    {
            //        this.shipAddresses = new List<ShipAddress>();
            //        foreach (DataRow row in this.dt.Rows)
            //        {
            //            if (row["ShipID"] == DBNull.Value)
            //            {
            //                row["ShipID"] = 1;
            //            }
            //            if (row["SRNO"] == DBNull.Value)
            //            {
            //                row["SRNO"] = 1;
            //            }
            //            this.shipAddress = new ShipAddress(Convert.ToInt32(row["ShipID"]), Convert.ToInt32(row["SRNO"]), Convert.ToString(row["SalesTax"]));
            //            this.shipAddress.ShipToID = Convert.ToString((row["ShipToID"] == null) ? "" : row["ShipToID"]);
            //            this.shipAddress.Receipent = Convert.ToString((row["Recipient"] == null) ? "" : row["Recipient"]);
            //            this.shipAddress.AddressLine1 = Convert.ToString((row["Address1"] == null) ? "" : row["Address1"]);
            //            this.shipAddress.AddressLine2 = Convert.ToString((row["Address2"] == null) ? "" : row["Address2"]);
            //            this.shipAddress.City = Convert.ToString((row["City"] == null) ? "" : row["City"]);
            //            this.shipAddress.State = Convert.ToString((row["State"] == null) ? "" : row["State"]);
            //            this.shipAddress.Zip = Convert.ToString((row["ZIP"] == null) ? "" : row["ZIP"]);
            //            this.shipAddress.Country = Convert.ToString((row["Country"] == null) ? "" : row["Country"]);
            //            this.shipAddress.CompanyGuid = peachObj.CurrentCompanyGUID;
            //            this.shipAddress.CompanyName = Convert.ToString(row["CompanyName"]);
            //            this.shipAddresses.Add(this.shipAddress);
            //        }
            //        return this.shipAddresses;
            //    }
            //    list = null;
            //}
            //catch (Exception)
            //{
            //    if (this.con.State != ConnectionState.Closed)
            //    {
            //        this.con.Close();
            //    }
            //    throw;
            //}
            return list;
        }


     

        public bool SaveShiptoAddress(Customer cus)
        {
            bool flag=false ;
            //try
            //{
            //    this.readconfile = new ReadConfigFile();
            //    this.con = new OleDbConnection();
            //    this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            //    if (this.con.ConnectionString != "")
            //    {
            //        PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
            //        if (peachObj.CurrentCompanyGUID == null)
            //        {
            //            return false;
            //        }
            //        if (peachObj.CurrentCompanyGUID == "")
            //        {
            //            return false;
            //        }
            //        this.con.Open();
            //        this.cmd = new OleDbCommand();
            //        if (this.con.State == ConnectionState.Open)
            //        {
            //            this.tran = this.con.BeginTransaction();
            //            this.cmd.Connection = this.con;
            //            this.cmd.Transaction = this.tran;
            //            this.cmd.CommandText = "Delete * from SHipto where CustomerID='" + cus.Id.Replace("'", "''") + "' and CompanyGUID ='" + peachObj.CurrentCompanyGUID + "'";
            //            this.cmd.CommandType = CommandType.Text;
            //            this.cmd.ExecuteNonQuery();
            //            foreach (ShipAddress address in cus.ShiptoAddresses)
            //            {
            //                this.cmd.CommandText = string.Concat(new object[] { 
            //                    "insert into shipto(shiptoid,Address1,Address2,City,Country,Recipient,SalesTax,ShipID,State,Zip,CustomerID,CustomerName,CompanyGUID,CompanyName) values('", address.ShipToID.Replace("'", "''"), "','", address.AddressLine1.Replace("'", "''"), "','", address.AddressLine2.Replace("'", "''"), "','", address.City.Replace("'", "''"), "','", address.Country.Replace("'", "''"), "','", address.Receipent.Replace("'", "''"), "','", address.SalesTax.Replace("'", "''"), "',", address.ShipId, 
            //                    ",'", address.State.Replace("'", "''"), "','", address.Zip.Replace("'", "''"), "','", cus.Id.Replace("'", "''"), "','", cus.Name.Replace("'", "''"), "','", peachObj.CurrentCompanyGUID, "','", peachObj.CurrentCompanyName.Replace("'", "''"), "')"
            //                 });
            //                if (this.cmd.ExecuteNonQuery() == 0)
            //                {
            //                    this.tran.Rollback();
            //                    this.con.Close();
            //                    return false;
            //                }
            //            }
            //            this.tran.Commit();
            //            this.con.Close();
            //            return true;
            //        }
            //    }
            //    flag = false;
            //}
            //catch (Exception)
            //{
            //    if (this.con.State != ConnectionState.Closed)
            //    {
            //        this.con.Close();
            //    }
            //    throw;
            //}
            return flag;
        }
    }
}

