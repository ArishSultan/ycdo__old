using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Common;
using OleDbHelper;
// using ExportImport;

namespace DAL.SaleInvoices
{
    //public  class SaleInvoiceDB
    //{
    //    public SaleInvoiceDB() { }

    //    private OleDbCommand cmd;
    //    private OleDbConnection con;
    //    private OleDbDataAdapter da;
    //    private DataTable dt;
    //    private ReadConfigFile readconfile;
    //    PeachtreeSingleTon peachObj; 
    //    private OleDbTransaction tran;
    //    private SaleInvoice saleInvoice;
    //    private List<SaleInvoice> saleInvoices;
 
      
    


    //    public bool SaveShipAddressinCityZipStCountry(SaleInvoice si)
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
    //                    this.cmd.CommandText = string.Concat(new object[] { "insert into CityZipSTCountry(City,State,Zip,Country,CompanyGuid) values('", si.ShipAddress.City, "','", si.ShipAddress.State, "','", si.ShipAddress.Zip, "','", si.ShipAddress.Country, "','", peachObj.CurrentCompanyGUID , "')" });
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
