namespace DAL.Quotes
{
    using Common;
   // // using ExportImport;
    using OleDbHelper;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;

    //public class QuoteNODAL
    //{
    //    private OleDbCommand cmd;
    //    private OleDbConnection con;
    //    private EditQuote editQuote;
    //    private PeachtreeSingleTon peachobj;
    //    private Quote quote;
    //    private List<Quote> quotes;
    //    private ReadConfigFile readconfile;
    //    private OleDbTransaction tran;

    //    public string GetShiptoid(Quote qt)
    //    {
    //        string str2;
    //        try
    //        {
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != "")
    //            {
    //                PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
    //                if (peachObj.CurrentCompanyGUID == null)
    //                {
    //                    return "";
    //                }
    //                if (peachObj.CurrentCompanyGUID == "")
    //                {
    //                    return "";
    //                }
    //                this.con.Open();
    //                this.cmd = new OleDbCommand();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.CommandType = CommandType.Text;
    //                    this.cmd.CommandText = "Select ShipToID from Quote  where CompanyGUID='" + peachObj.CurrentCompanyGUID + "' and qtGUID='" + qt.TransactionGUID + "' ";
    //                    string str = Convert.ToString(this.cmd.ExecuteScalar());
    //                    this.con.Close();
    //                    return str;
    //                }
    //            }
    //            str2 = "";
    //        }
    //        catch (Exception)
    //        {
    //            if (this.con.State != ConnectionState.Closed)
    //            {
    //                this.con.Close();
    //            }
    //            throw;
    //        }
    //        return str2;
    //    }

    //    public DateTime GetSystemDate()
    //    {
    //        this.peachobj = new PeachtreeSingleTon();
    //        return this.peachobj.SystemDate;
    //    }

    //    public bool QuoteNoAlreadyExist(Quote qt)
    //    {
    //        try
    //        {
    //            this.peachobj = new PeachtreeSingleTon();
    //            this.editQuote = new EditQuote();
    //            int num = 0;
    //            if (this.editQuote.ExportQuoteNumber(this.peachobj.GetFirstDay(), this.peachobj.GetLastDay()))
    //            {
    //                IEnumerable<XElement> enumerable = XElement.Load(this.editQuote.FileNameXML).Descendants("PAW_Invoice").Select<XElement, XElement>(delegate (XElement el) {
    //                    return el;
    //                });
    //                string str = "";
    //                string str2 = "";
    //                foreach (XElement element2 in enumerable)
    //                {
    //                    if (element2.Element("isQuote").Value.ToString().ToUpper() == "TRUE")
    //                    {
    //                        str = (element2.Element("Quote_Number") == null) ? "" : element2.Element("Quote_Number").Value;
    //                        str2 = element2.Element("GUID").Value;
    //                        if ((str != "") && (str == qt.QuoteNo))
    //                        {
    //                            if ((qt.TransactionGUID == null) || (qt.TransactionGUID == ""))
    //                            {
    //                                num++;
    //                            }
    //                            else if (str2 != qt.TransactionGUID)
    //                            {
    //                                num++;
    //                            }
    //                        }
    //                        if (num >= 1)
    //                        {
    //                            return true;
    //                        }
    //                    }
    //                }
    //            }
    //            return false;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "QuoteNoAlreadyExist");
    //            return false;
    //        }
    //    }

    //    public List<Quote> QuoteNoList()
    //    {
    //        try
    //        {
    //            this.quotes = new List<Quote>();
    //            this.peachobj = new PeachtreeSingleTon();
    //            this.editQuote = new EditQuote();
    //            if (this.editQuote.ExportQuoteNumber(this.peachobj.GetFirstDay(), this.peachobj.GetLastDay()))
    //            {
    //                IEnumerable<XElement> enumerable = XElement.Load(this.editQuote.FileNameXML).Descendants("PAW_Invoice").Select<XElement, XElement>(delegate (XElement el) {
    //                    return el;
    //                });
    //                foreach (XElement element2 in enumerable)
    //                {
    //                    if (element2.Element("isQuote").Value.ToString().ToUpper() == "TRUE")
    //                    {
    //                        this.quote = new Quote();
    //                        this.quote.QuoteNo = (element2.Element("Quote_Number") == null) ? "" : element2.Element("Quote_Number").Value;
    //                        this.quote.TransactionGUID = element2.Element("GUID").Value;
    //                        this.quotes.Add(this.quote);
    //                    }
    //                }
    //            }
    //            return this.quotes;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "QuoteNoList");
    //            return this.quotes;
    //        }
    //    }

    //    public bool SaveQTnumber(Quote qt)
    //    {
    //        bool flag;
    //        try
    //        {
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != "")
    //            {
    //                PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
    //                if (peachObj.CurrentCompanyGUID == null)
    //                {
    //                    return false;
    //                }
    //                if (peachObj.CurrentCompanyGUID == "")
    //                {
    //                    return false;
    //                }
    //                this.con.Open();
    //                this.cmd = new OleDbCommand();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.tran = this.con.BeginTransaction();
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.Transaction = this.tran;
    //                    this.cmd.CommandType = CommandType.Text;
    //                    this.cmd.CommandText = "insert into Quote(CompanyGUID,CompanyName,CustomerID,qtnumber,qtGUID,ShipToID) values('" + peachObj.CurrentCompanyGUID + "','" + peachObj.CurrentCompanyName.Replace("'", "''") + "','" + qt.Customer.Id.Replace("'", "''") + "','" + qt.QuoteNo.Replace("'", "''") + "','" + qt.TransactionGUID + "','" + qt.ShipAddress.ShipToID.Replace("'", "''") + "')";
    //                    if (this.cmd.ExecuteNonQuery() == 0)
    //                    {
    //                        this.tran.Rollback();
    //                        this.con.Close();
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
    //            if (this.con.State != ConnectionState.Closed)
    //            {
    //                this.con.Close();
    //            }
    //            throw;
    //        }
    //        return flag;
    //    }

    //    public bool SaveQuotenumbers(List<Quote> qts)
    //    {
    //        bool flag;
    //        try
    //        {
    //            this.readconfile = new ReadConfigFile();
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != "")
    //            {
    //                PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
    //                if (peachObj.CurrentCompanyGUID == null)
    //                {
    //                    return false;
    //                }
    //                if (peachObj.CurrentCompanyGUID == "")
    //                {
    //                    return false;
    //                }
    //                this.con.Open();
    //                int num = 0;
    //                this.cmd = new OleDbCommand();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.tran = this.con.BeginTransaction();
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.Transaction = this.tran;
    //                    this.cmd.CommandType = CommandType.Text;
    //                    this.cmd.CommandText = "Delete * from QuoteNumber where CompanyGUID='" + peachObj.CurrentCompanyGUID + "'";
    //                    num = this.cmd.ExecuteNonQuery();
    //                    for (int i = 0; i < qts.Count; i++)
    //                    {
    //                        this.cmd.CommandText = "insert into QuoteNumber(CompanyGUID,QuoteGUID,QuoteNo) values('" + peachObj.CurrentCompanyGUID + "','" + qts[i].TransactionGUID + "','" + qts[i].QuoteNo.Replace("'", "''") + "')";
    //                        if (this.cmd.ExecuteNonQuery() == 0)
    //                        {
    //                            this.tran.Rollback();
    //                            this.con.Close();
    //                            return false;
    //                        }
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
    //            if (this.con.State != ConnectionState.Closed)
    //            {
    //                this.con.Close();
    //            }
    //            throw;
    //        }
    //        return flag;
    //    }
    //}
}

