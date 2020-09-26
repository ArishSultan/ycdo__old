namespace DAL.SaleOrders
{
    using Common;
   // // using ExportImport;
    using OleDbHelper;
    using System;
    using System.Data;
    using System.Data.OleDb;

    public class SaleOrderNODAL
    {
        private OleDbCommand cmd;
        private OleDbConnection con;
        private ReadConfigFile readconfile;
        private OleDbTransaction tran;

        public string GetShiptoid(SaleOrder so)
        {
            string str2="";
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
            //            return "";
            //        }
            //        if (peachObj.CurrentCompanyGUID == "")
            //        {
            //            return "";
            //        }
            //        this.con.Open();
            //        this.cmd = new OleDbCommand();
            //        if (this.con.State == ConnectionState.Open)
            //        {
            //            this.cmd.Connection = this.con;
            //            this.cmd.CommandType = CommandType.Text;
            //            this.cmd.CommandText = "Select ShipToID from Saleorder  where CompanyGUID='" + peachObj.CurrentCompanyGUID + "' and soGUID='" + so.TransactionGUID + "' ";
            //            string str = Convert.ToString(this.cmd.ExecuteScalar());
            //            this.con.Close();
            //            return str;
            //        }
            //    }
            //    str2 = "";
            //}
            //catch (Exception)
            //{
            //    if (this.con.State != ConnectionState.Closed)
            //    {
            //        this.con.Close();
            //    }
            //    throw;
            //}
            return str2;
        }

        public string GetSOnumber()
        {
            string str2="";
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
            //            return "";
            //        }
            //        if (peachObj.CurrentCompanyGUID == "")
            //        {
            //            return "";
            //        }
            //        this.con.Open();
            //        this.cmd = new OleDbCommand();
            //        if (this.con.State == ConnectionState.Open)
            //        {
            //            this.cmd.Connection = this.con;
            //            this.cmd.CommandType = CommandType.Text;
            //            this.cmd.CommandText = "Select sonumber from SaleOrderNo  where CompanyGUID='" + peachObj.CurrentCompanyGUID + "' ";
            //            string str = Convert.ToString(this.cmd.ExecuteScalar());
            //            this.con.Close();
            //            return str;
            //        }
            //    }
            //    str2 = "";
            //}
            //catch (Exception)
            //{
            //    if (this.con.State != ConnectionState.Closed)
            //    {
            //        this.con.Close();
            //    }
            //    throw;
            //}
            return str2;
        }

        public DateTime GetSystemDate()
        {
            //PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
            //return peachObj.SystemDate;
            return new DateTime();
        }

        public bool SaveSOnumber(SaleOrder so, bool isedit)
        {
            bool flag=false ;
            //try
            //{
            //    this.readconfile = new ReadConfigFile();
            //    this.con = new OleDbConnection();
            //    this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            //    if (!(this.con.ConnectionString != ""))
            //    {
            //        goto Label_02C9;
            //    }
            //    PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
            //    if (peachObj.CurrentCompanyGUID == null)
            //    {
            //        return false;
            //    }
            //    if (peachObj.CurrentCompanyGUID == "")
            //    {
            //        return false;
            //    }
            //    this.con.Open();
            //    this.cmd = new OleDbCommand();
            //    if (this.con.State != ConnectionState.Open)
            //    {
            //        goto Label_02C9;
            //    }
            //    this.tran = this.con.BeginTransaction();
            //    this.cmd.Connection = this.con;
            //    this.cmd.Transaction = this.tran;
            //    this.cmd.CommandType = CommandType.Text;
            //    this.cmd.CommandText = "Select CompanyGUID from SaleOrderNo where CompanyGUID='" + peachObj.CurrentCompanyGUID + "'";
            //    string str = Convert.ToString(this.cmd.ExecuteScalar());
            //    if (str.Length ==0)
            //    {
                    
            //                this.cmd.CommandText = "insert into SaleOrderNo(CompanyGUID,CompanyName,sonumber) values('" + peachObj.CurrentCompanyGUID + "','" + peachObj.CurrentCompanyName.Replace("'", "''") + "','" + so.SaleOrderNo.Replace("'", "''") + "')";
            //                if (this.cmd.ExecuteNonQuery() == 0)
            //                {
            //                    this.tran.Rollback();
            //                    this.con.Close();
            //                    return false;
            //                }
                            
            //    }
            //    else 
            //    {
            //        this.cmd.CommandText = "update  SaleOrderNo set sonumber='" + so.SaleOrderNo.Replace("'", "''") + "' where CompanyGUID ='" + peachObj.CurrentCompanyGUID + "'";
            //        if (this.cmd.ExecuteNonQuery() == 0)
            //        {
            //            this.tran.Rollback();
            //            this.con.Close();
            //            return false;
            //        }
            //    }

            //    //Save shipt to id in saleorders table.
            //    this.cmd.CommandType = CommandType.Text;
            //    this.cmd.CommandText = "insert into SaleOrder(CompanyGUID,CompanyName,CustomerID,soNumber,soGUID,ShipToID) values('" + peachObj.CurrentCompanyGUID + "','" + peachObj.CurrentCompanyName.Replace("'", "''") + "','" + so.Customer.Id.Replace("'", "''") + "','" + so.SaleOrderNo.Replace("'", "''") + "','" + so.TransactionGUID + "','" + so.ShipAddress.ShipToID.Replace("'", "''") + "')";
            //    if (this.cmd.ExecuteNonQuery() == 0)
            //    {
            //        this.tran.Rollback();
            //        this.con.Close();
            //        return false;
            //    }

            //    this.tran.Commit();
            //    this.con.Close();
            //    return true;
            //Label_02C9:
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

