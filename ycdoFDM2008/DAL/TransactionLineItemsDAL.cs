  using Common;
   // // using ExportImport;
    using OleDbHelper;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;



namespace DAL
{
    //public class TransactionLineItemsDAL
    //{
    //    public TransactionLineItemsDAL()
    //    {}

    //    private OleDbCommand cmd;
    //    private OleDbConnection con;
    //    private OleDbDataAdapter da;
    //    private DataTable dt;
    //    private ReadConfigFile readconfile;
        
    //    private OleDbTransaction tran;
    //    PeachtreeSingleTon peachObj;

    //    public bool SaveSaleInvoiceLineItems(SaleInvoice  si)
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
    //                        for (int i = 0; i < si.LineItems.Count; i++)
    //                        {
    //                            this.cmd.CommandText = "Insert into SaleInvoiceLineItems (CompanyGuid,SaleInvoiceGUID,LineNo,DiscPct,DiscUnitPrice,LineItemPrice,SecAttID,SecAttDes,LineType)Values('" + companyGuid + "','" + si.TransactionGUID + "'," + si.LineItems[i].LineitemNo + ","+ si.LineItems[i].DiscPct+"," +Math.Round ( si.LineItems[i].DiscUnitPrice,2) +","+Math.Round( si.LineItems[i].LineitemPrice,2)  +",'"+si.LineItems[i].FrameColor.Id +"','"+ si.LineItems[i].FrameColor.Description  + "','" + si.LineItems[i].SaleInvoiceLineItemType + "')";
                                
    //                            if (this.cmd.ExecuteNonQuery() == 0)
    //                            {
    //                                this.tran.Rollback();
    //                                return false;
    //                            }

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


    //    public List<SaleInvoiceLineItem > GetSaleInvoiceLineItems(SaleInvoice si)
    //    {
    //        List<SaleInvoiceLineItem> users;
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
    //                        cmd.CommandText = "Select * from SaleInvoiceLineItems where CompanyGUID='" + companyGUID +"' and SaleInvoiceGUID='" + si.TransactionGUID + "'";
    //                        da = new OleDbDataAdapter(cmd.CommandText, con);
    //                        da.Fill(dt);
    //                        con.Close();
    //                    }
    //                }
    //            }
    //            users = new List<SaleInvoiceLineItem>();
    //            SaleInvoiceLineItem siLn=new SaleInvoiceLineItem(SaleInLineItemType.Sales );
    //            if (dt.Rows.Count > 0)
    //            {
    //                foreach (DataRow row in dt.Rows)
    //                {
    //                    if(Convert.ToString ( row["LineType"])=="Sales")
    //                        siLn=new SaleInvoiceLineItem(SaleInLineItemType.Sales );
    //                    else 
    //                        siLn=new SaleInvoiceLineItem(SaleInLineItemType.SO  );
    //                    siLn. LineitemNo = Convert.ToInt16 (row["LineNo"]);
                        
    //                    siLn.DiscPct  = Convert.ToDecimal (row["DiscPct"]);
    //                    siLn.FrameColor.Id = Convert.ToString(row["SecAttID"]);
    //                    siLn.FrameColor.Description = Convert.ToString(row["SecAttDes"]);
    //                    siLn.DiscUnitPrice = Convert.ToDecimal(row["DiscUnitPrice"]);
    //                    siLn.LineitemPrice = Convert.ToDecimal(row["LineItemPrice"]);
    //                    siLn.ExtendedAmount = Convert.ToDecimal(row["ExtendedAmount"]);
    //                    siLn.Amount = Convert.ToDecimal(row["Amount"]);
    //                    users.Add(siLn );
    //                }
    //            }
                
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return users;
    //    }




    //    public bool SaveSaleOrderLineItems(SaleOrder so)
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
    //                        for (int i = 0; i < so.LineItems.Count; i++)
    //                        {
    //                            this.cmd.CommandText = "Insert into SaleOrderLineItems (CompanyGuid,SaleOrderGUID,LineNo,DiscPct,DiscUnitPrice,LineItemPrice,SecAttID,SecAttDes,Amount,ExtendedAmount)Values('" + companyGuid + "','" + so.TransactionGUID + "'," + so.LineItems[i].LineitemNo + "," + so.LineItems[i].DiscPct + "," + Math.Round(so.LineItems[i].DiscUnitPrice, 2) + "," + Math.Round(so.LineItems[i].LineitemPrice, 2) + ",'" + so.LineItems[i].FrameColor.Id + "','" + so.LineItems[i].FrameColor.Description + "'," + so.LineItems[i].Amount + "," + so.LineItems[i].ExtendedAmount + ")";

    //                            if (this.cmd.ExecuteNonQuery() == 0)
    //                            {
    //                                this.tran.Rollback();
    //                                return false;
    //                            }

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


    //    public List<SaleOrderlineItem > GetSaleOrderLineItems(SaleOrder so)
    //    {
    //        List<SaleOrderlineItem> users;
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
    //                        cmd.CommandText = "Select * from SaleOrderLineItems where CompanyGUID='" + companyGUID + "' and SaleOrderGUID='" + so.TransactionGUID + "'";
    //                        da = new OleDbDataAdapter(cmd.CommandText, con);
    //                        da.Fill(dt);
    //                        con.Close();
    //                    }
    //                }
    //            }
    //            users = new List<SaleOrderlineItem>();
    //            SaleOrderlineItem siLn = new SaleOrderlineItem();
    //            if (dt.Rows.Count > 0)
    //            {
    //                foreach (DataRow row in dt.Rows)
    //                {
    //                    siLn = new SaleOrderlineItem();
    //                    siLn.LineitemNo = Convert.ToInt16(row["LineNo"]);

    //                    siLn.DiscPct = Convert.ToDecimal(row["DiscPct"]);
    //                    siLn.FrameColor.Id = Convert.ToString(row["SecAttID"]);
    //                    siLn.FrameColor.Description = Convert.ToString(row["SecAttDes"]);
    //                    siLn.DiscUnitPrice = Convert.ToDecimal(row["DiscUnitPrice"]);
    //                    siLn.LineitemPrice = Convert.ToDecimal(row["LineItemPrice"]);
    //                    siLn.ExtendedAmount = Convert.ToDecimal(row["ExtendedAmount"]);
    //                    siLn.Amount = Convert.ToDecimal(row["Amount"]);

    //                    users.Add(siLn);
    //                }
    //            }

    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return users;
    //    }

    //    public bool SaveQuoteLineItems(Quote  so)
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
    //                        for (int i = 0; i < so.LineItems.Count; i++)
    //                        {
    //                            this.cmd.CommandText = "Insert into QuoteLineItems (CompanyGuid,QuoteGUID,LineNo,HRBLineNo,LastCost )Values('" + companyGuid + "','" + so.TransactionGUID + "'," + so.LineItems[i].LineitemNo + "," + so.LineItems[i].HRBLineNo + "," + so.LineItems[i].NewLastUnitCost + ")";

    //                            if (this.cmd.ExecuteNonQuery() == 0)
    //                            {
    //                                this.tran.Rollback();
    //                                return false;
    //                            }

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


    //    public List<QuoteLineItem > GetQuoteLineItems(Quote  so)
    //    {
    //        List<QuoteLineItem> users;
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
    //                        cmd.CommandText = "Select * from QuoteLineItems where CompanyGUID='" + companyGUID + "' and QuoteGUID='" + so.TransactionGUID + "'";
    //                        da = new OleDbDataAdapter(cmd.CommandText, con);
    //                        da.Fill(dt);
    //                        con.Close();
    //                    }
    //                }
    //            }
    //            users = new List<QuoteLineItem>();
    //            QuoteLineItem siLn = new QuoteLineItem();
    //            if (dt.Rows.Count > 0)
    //            {
    //                foreach (DataRow row in dt.Rows)
    //                {
    //                    siLn = new QuoteLineItem();
    //                    siLn.LineitemNo = Convert.ToInt16(row["LineNo"]);
    //                    siLn.HRBLineNo = Convert.ToInt32(row["HRBLineNo"]);
    //                    siLn.NewLastUnitCost = Convert.ToDecimal(row["LastCost"]);


    //                    users.Add(siLn);
    //                }
    //            }

    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return users;
    //    }

    //}


}
