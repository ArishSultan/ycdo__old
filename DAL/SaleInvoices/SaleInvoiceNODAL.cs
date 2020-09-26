namespace DAL.SaleInvoices
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

    //public class SaleInvoiceNODAL
    //{
    //    private OleDbCommand cmd;
    //    private OleDbConnection con;
    //    private EditSaleInvoice editSaleInvoice;
    //    private PeachtreeSingleTon peachobj;
    //    private ReadConfigFile readconfile;
    //    private OleDbTransaction tran;

    //    public string GetShiptoid(SaleInvoice si)
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
    //                    this.cmd.CommandText = "Select ShipToID from SaleInvoice  where CompanyGUID='" + peachObj.CurrentCompanyGUID + "' and siGUID='" + si.TransactionGUID + "' ";
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

    //    public bool SalInvNoAlreadyExist(SaleInvoice si)
    //    {
    //        try
    //        {
    //            this.peachobj = new PeachtreeSingleTon();
    //            this.editSaleInvoice = new EditSaleInvoice();
    //            if (this.editSaleInvoice.ExportEditSaleInvNumber(this.peachobj.GetFirstDay(), this.peachobj.GetLastDay(), si.SaleInvoiceNo))
    //            {
    //                IEnumerable<XElement> enumerable = XElement.Load(this.editSaleInvoice.FileNameXML).Descendants("PAW_Invoice").Select<XElement, XElement>(delegate (XElement el) {
    //                    return el;
    //                });
    //                string str = "";
    //                string str2 = "";
    //                int num = 0;
    //                foreach (XElement element2 in enumerable)
    //                {
    //                    if (((element2.Element("isQuote").Value.ToString().ToUpper() == "FALSE") && (element2.Element("CreditMemoType").Value.ToString().ToUpper() == "FALSE")) && (element2.Element("ProgressBillingInvoice").Value.ToUpper() == "FALSE"))
    //                    {
    //                        str = (element2.Element("Invoice_Number") == null) ? "" : element2.Element("Invoice_Number").Value;
    //                        str2 = element2.Element("GUID").Value;
    //                        if ((str != "") && (str == si.SaleInvoiceNo))
    //                        {
    //                            if ((si.TransactionGUID == null) || (si.TransactionGUID == ""))
    //                            {
    //                                num++;
    //                            }
    //                            else if (si.TransactionGUID != str2)
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
    //            MessageBox.Show(exception.Message, "SalInvNoAlreadyExist");
    //            return false;
    //        }
    //    }

    //    public bool SaveSInumber(SaleInvoice si)
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
    //                    this.cmd.CommandText = "insert into SaleInvoice(CompanyGUID,CompanyName,CustomerID,sinumber,siGUID,ShipToID) values('" + peachObj.CurrentCompanyGUID.Replace("'", "''") + "','" + peachObj.CurrentCompanyName.Replace("'", "''") + "','" + si.Customer.Id.Replace("'", "''") + "','" + si.SaleInvoiceNo.Replace("'", "''") + "','" + si.TransactionGUID + "','" + si.ShipAddress.ShipToID.Replace("'", "''") + "')";
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
    //}
}

