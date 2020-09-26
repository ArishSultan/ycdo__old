namespace DAL.SaleInvoices
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
    }
}

