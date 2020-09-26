using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb ;
using OleDbHelper;
using System.Data;
namespace DAL
{
    public  class UpdateQuriesDAL
    {
        /// <summary>
        /// it will create UserPreferences Table 
        /// </summary>
        public void UpdateV3()
        {
            OleDbConnection con = new OleDbConnection();
            try
            {
                ReadConfigFile readconfile = new ReadConfigFile();

                string conString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);

                OleDbCommand cmd = new OleDbCommand();

                con.ConnectionString = conString;

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    cmd.CommandType = CommandType.Text;

                    OleDbTransaction transaction = con.BeginTransaction();
                    cmd.Connection = con;
                    cmd.Transaction = transaction;
                    try
                    {


                        string qry = "";
                        qry = "Select * from UserPreferences";
                        try
                        {
                            cmd.CommandText = qry;
                            cmd.ExecuteScalar();
                            //error means UserPreferences table does not exist then create it.
                        }
                        catch (Exception)
                        {



                            qry = "Create Table UserPreferences ";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();
                            qry = "Alter Table UserPreferences Add Column InvoiceLookupPeriod text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table UserPreferences Add Column SaleOrderLookupPeriod text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();


                            qry = "Alter Table UserPreferences add Column CompanyGUID text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            transaction.Commit();
                        }
                    }
                    catch (Exception ex1)
                    {
                        transaction.Rollback();
                        throw ex1;
                    }
                }
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// it will create Contacts Table in GEN 's database.
        /// </summary>
        public void UpdateV2()
        {
            OleDbConnection con = new OleDbConnection();
            try
            {
                ReadConfigFile readconfile = new ReadConfigFile();



                string conString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile); ;

                OleDbCommand cmd = new OleDbCommand();

                con.ConnectionString = conString;

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    cmd.CommandType = CommandType.Text;

                    OleDbTransaction transaction = con.BeginTransaction();
                    cmd.Connection = con;
                    cmd.Transaction = transaction;
                    try
                    {


                        string qry = "";
                        qry = "Select * from Contacts";
                        try
                        {
                            cmd.CommandText = qry;
                            cmd.ExecuteScalar();
                            //error means Contacts table does not exist then create it.
                        }
                        catch (Exception)
                        {



                            qry = "Create Table Contacts ";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();
                            qry = "Alter Table Contacts Add Column CustomerID text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table Contacts add Column ContactFirstName text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table Contacts add Column ContactLastName text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            //SecAttDes
                            qry = "Alter Table Contacts add Column CompanyName text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table Contacts add Column isDefaultShipTo text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table Contacts add Column DisplayName text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table Contacts add Column IsBillTo text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table Contacts add Column AttachedAddressNo text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table Contacts add Column CompanyGUID text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            transaction.Commit();
                        }
                    }
                    catch (Exception ex1)
                    {
                        transaction.Rollback();
                        throw ex1;
                    }
                }
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// this will drop SaleOrderLineItems Table in Gen and ReCreate it.
        /// </summary>
        public void UpdateV1()
        {
            OleDbConnection con = new OleDbConnection();
            try
            {
                ReadConfigFile readconfile = new ReadConfigFile();



                string conString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile); ;

                OleDbCommand cmd = new OleDbCommand();

                con.ConnectionString = conString;

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    cmd.CommandType = CommandType.Text;

                    OleDbTransaction transaction = con.BeginTransaction();
                    cmd.Connection = con;
                    cmd.Transaction = transaction;
                    try
                    {


                        string qry = "";
                        qry = "Select ExtendedAmount from SaleOrderLineItems";
                        try
                        {
                            cmd.CommandText = qry;
                            cmd.ExecuteScalar();
                            //error means ExtendedAmount does not exist then create it.
                        }
                        catch (Exception)
                        {
                            
                                                    
                        
                            qry = "Alter Table SaleOrderLineItems Drop HRBLineNo";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();
                            qry = "Alter Table SaleOrderLineItems Drop LastCost";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table SaleOrderLineItems add Column DiscPct Decimal(18,2)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table SaleOrderLineItems add Column SecAttID text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            //SecAttDes
                            qry = "Alter Table SaleOrderLineItems add Column SecAttDes text(255)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table SaleOrderLineItems add Column DiscUnitPrice Decimal(18,2)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table SaleOrderLineItems add Column LineItemPrice Decimal(18,2)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table SaleOrderLineItems add Column Amount Decimal(18,2)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            qry = "Alter Table SaleOrderLineItems add Column ExtendedAmount Decimal(18,2)";
                            cmd.CommandText = qry;
                            cmd.ExecuteNonQuery();

                            transaction.Commit();
                        }
                    }
                    catch (Exception ex1)
                    {
                        transaction.Rollback();
                        throw ex1;
                    }
                }
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            finally
            {
                con.Close();
            }
        }
       
   
    }
}
