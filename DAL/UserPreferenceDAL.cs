using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Common;
// using ExportImport;
using OleDbHelper;

using System.Data;
using System.Data.OleDb;



namespace DAL
{
    //public class UserPreferenceDAL
    //{
    //    public UserPreferenceDAL()
    //    { }

    //    private OleDbCommand cmd;
    //    private OleDbConnection con;
    //    private OleDbDataAdapter da;
    //    private DataTable dt;
    //    private ReadConfigFile readconfile;

    //    private OleDbTransaction tran;
    // //   PeachtreeSingleTon peachObj;

    //    public bool SaveSaleInvoiceLastPeriod(UserPreference up)
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
    //                string companyGuid = peachObj.CurrentCompanyGUID;
    //                if (companyGuid != null && companyGuid != "")
    //                {
    //                    this.con.Open();
    //                    this.cmd = new OleDbCommand();
    //                    if (this.con.State == ConnectionState.Open)
    //                    {
    //                        this.tran = this.con.BeginTransaction();
    //                        this.cmd.Connection = this.con;
    //                        this.cmd.Transaction = this.tran;

    //                        this.cmd.CommandType = CommandType.Text;

    //                        this.cmd.CommandText = "Select * from UserPreferences  where CompanyGuid='" + companyGuid + "'";
    //                        if(this.cmd.ExecuteScalar ()==null )

    //                        this.cmd.CommandText = "Insert into UserPreferences (CompanyGuid,InvoiceLookupPeriod )Values('" + companyGuid + "','" +  up.InvoiceLookupPeriod + "')";
    //                        else 
    //                        this.cmd.CommandText = "Update UserPreferences set InvoiceLookupPeriod='" + up.InvoiceLookupPeriod + "' where CompanyGuid='"+companyGuid +"'";

    //                        if (this.cmd.ExecuteNonQuery() == 0)
    //                        {
    //                            this.tran.Rollback();
    //                            return false;
    //                        }

                            

    //                        this.tran.Commit();
    //                        this.con.Close();
    //                        return true;
    //                    }
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


    //    public UserPreference GetSaleInvoiceLastPeriod()
    //    {
    //        UserPreference up = new UserPreference();
    //        try
    //        {
    //            readconfile = new ReadConfigFile();
    //            con = new OleDbConnection();
    //            con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            dt = new DataTable();
    //            if (con.ConnectionString != "")
    //            {
    //                peachObj = new PeachtreeSingleTon();
    //                string companyGUID = peachObj.CurrentCompanyGUID;
    //                if (companyGUID != null && companyGUID != "")
    //                {
    //                    con.Open();
    //                    cmd = new OleDbCommand();
    //                    if (con.State == ConnectionState.Open)
    //                    {
    //                        cmd.Connection = con;
    //                        cmd.CommandText = "Select InvoiceLookupPeriod from UserPreferences where CompanyGUID='" + companyGUID + "'";
    //                        if (cmd.ExecuteScalar() != null)
    //                            up.InvoiceLookupPeriod = Convert.ToString(cmd.ExecuteScalar());
    //                        con.Close();
                            
    //                    }
    //                }
    //            }


    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return up;
    //    }


    //    public bool SaveSaleOrderLastPeriod(UserPreference up)
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
    //                string companyGuid = peachObj.CurrentCompanyGUID;
    //                if (companyGuid != null && companyGuid != "")
    //                {
    //                    this.con.Open();
    //                    this.cmd = new OleDbCommand();
    //                    if (this.con.State == ConnectionState.Open)
    //                    {
    //                        this.tran = this.con.BeginTransaction();
    //                        this.cmd.Connection = this.con;
    //                        this.cmd.Transaction = this.tran;

    //                        this.cmd.CommandType = CommandType.Text;

    //                        this.cmd.CommandText = "Select * from UserPreferences  where CompanyGuid='" + companyGuid + "'";
    //                        if (this.cmd.ExecuteScalar() == null)

    //                            this.cmd.CommandText = "Insert into UserPreferences (CompanyGuid,SaleOrderLookupPeriod )Values('" + companyGuid + "','" + up.InvoiceLookupPeriod + "')";
    //                        else
    //                            this.cmd.CommandText = "Update UserPreferences set SaleOrderLookupPeriod='" + up.InvoiceLookupPeriod + "' where CompanyGuid='" + companyGuid + "'";

    //                        if (this.cmd.ExecuteNonQuery() == 0)
    //                        {
    //                            this.tran.Rollback();
    //                            return false;
    //                        }



    //                        this.tran.Commit();
    //                        this.con.Close();
    //                        return true;
    //                    }
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


    //    public UserPreference GetSaleOrderLastPeriod()
    //    {
    //        UserPreference up = new UserPreference();
    //        try
    //        {
    //            readconfile = new ReadConfigFile();
    //            con = new OleDbConnection();
    //            con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            dt = new DataTable();
    //            if (con.ConnectionString != "")
    //            {
    //                peachObj = new PeachtreeSingleTon();
    //                string companyGUID = peachObj.CurrentCompanyGUID;
    //                if (companyGUID != null && companyGUID != "")
    //                {
    //                    con.Open();
    //                    cmd = new OleDbCommand();
    //                    if (con.State == ConnectionState.Open)
    //                    {
    //                        cmd.Connection = con;
    //                        cmd.CommandText = "Select SaleOrderLookupPeriod from UserPreferences where CompanyGUID='" + companyGUID + "'";
    //                        if (cmd.ExecuteScalar() != null)
    //                            up.InvoiceLookupPeriod = Convert.ToString(cmd.ExecuteScalar());
    //                        con.Close();

    //                    }
    //                }
    //            }


    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return up;
    //    }

 
    //}


}
