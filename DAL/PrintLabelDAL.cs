using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Common.Datasets;
using System.Data;
using System.Data.OleDb;
using OleDbHelper;
namespace DAL
{
    public class PrintLabelDAL
    {
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataReader reader;
        private OleDbDataAdapter da;
        ReadConfigFile readconfile;
        //Set Pri Id to True or False
        public void SetCompanyCheck(bool value)
        {
            bool xyz=GetCompanyCheck();
            try
            {

                this.readconfile = new ReadConfigFile();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                if (this.con.ConnectionString != null)
                {
                    this.con.Open();
                    this.cmd = new OleDbCommand();
                    this.cmd.Connection = this.con;
                    this.cmd.CommandType = CommandType.Text;
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.cmd.Connection = this.con;
                        if (rowCount == 0)
                            this.cmd.CommandText = "Insert into Attributes(PriID) Values('" + value.ToString().ToUpper() + "')" ;
                        else
                            this.cmd.CommandText = "Update Attributes set PriID='" + value.ToString().ToUpper() + "'";
                        this.cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();


            }
        }
        int rowCount = 0; 
        public bool GetCompanyCheck()
        {
            //we have used PriID field of Attributes Table for Show Company Name and Address on Print Label Screen
            string strText = "";
            try
            {
                 this.readconfile = new ReadConfigFile();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                if (this.con.ConnectionString != null)
                {
                    this.con.Open();
                    this.cmd = new OleDbCommand();
                    this.cmd.Connection = this.con;
                    this.cmd.CommandType = CommandType.Text;
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.cmd.Connection = this.con;
                        this.cmd.CommandText = "Select PriID from Attributes";
                        reader = this.cmd.ExecuteReader();
                        rowCount= reader.RecordsAffected;
                        while (reader.Read())
                        {
                            strText = reader["PriID"].ToString();
                        }
                    }
                }
                if (strText.ToUpper() == "TRUE")
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
                throw;
                
            }
            finally
            {
                con.Close();
                
                
            }
        }
        public DsPrintedInvoices GetPrintedInvoices(DateTime fromDate, DateTime toDate)
        {
            try
            {
                //load the current Company Information
                DataTable dt = new DataTable();// new CompanyInfoDAL().GetCompanyInfo();
                //Declare DataSet to contain Printed Invoice Data
                DsPrintedInvoices dspi = new DsPrintedInvoices();
                //Setup a connection to database and Retrieve Data.
                this.readconfile = new ReadConfigFile();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                if (this.con.ConnectionString != null)
                {
                    this.con.Open();
                    this.cmd = new OleDbCommand();
                    this.cmd.Connection = this.con;
                    this.cmd.CommandType = CommandType.Text;
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.cmd.Connection = this.con;
                        this.cmd.CommandText = "Select * from SaleInvoice where sinumber<>'' and siDate >='" + fromDate.ToShortDateString() + "' and siDate <= '" + toDate.ToShortDateString() + "'";
                        reader = this.cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            object[] values = new object[21];
                            values[0] = Convert.ToDateTime(reader["siDate"]);
                            values[1] = reader["sinumber"].ToString();
                            values[2] = reader["CustomerName"].ToString();
                            values[3] = false;
                            values[4] = 0;
                            values[5] = reader["Recipient"].ToString();
                            values[6] = reader["Line1"].ToString();
                            values[7] = reader["Line2"].ToString();
                            values[8] = reader["City"].ToString();
                            values[9] = reader["State"].ToString();
                            values[10] = reader["ZIP"].ToString();
                            values[11] = reader["CustomerPO"].ToString();
                            values[12] = reader["ShipVia"].ToString();
                            values[13] = dt.Rows[0].ItemArray[0];
                            values[14] = dt.Rows[0].ItemArray[1];
                            values[15] = dt.Rows[0].ItemArray[2];
                            values[16] = dt.Rows[0].ItemArray[3];
                            values[17] = dt.Rows[0].ItemArray[4];
                            values[18] = dt.Rows[0].ItemArray[5];
                            values[19] = dt.Rows[0].ItemArray[7];
                            values[20] = dt.Rows[0].ItemArray[8];
                            dspi.PrintedInvoices.Rows.Add(values);
                        }
                        reader.Close();
                    }
                }
                return dspi;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
