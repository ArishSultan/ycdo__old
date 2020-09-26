namespace DAL
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
    

    //public class CompanyInfoDAL
    //{
    //    private ClientRegistration clreg;
    //    private OleDbCommand cmd;
    //    private CompanyInformation compinfo;
    //    private OleDbConnection con;
    //    private OleDbDataAdapter da;
    //    private DataTable dt;
        
    //    private ReadConfigFile readconfile;
    //    private OleDbTransaction tran;

    //    public DataTable GetCompanyInfo()
    //    {
    //        try
    //        {
    //            this.clreg = new ClientRegistration();
    //            if (this.clreg.ExportClientRegistration())
    //            {
    //                this.compinfo = new CompanyInformation();
                    

    //                    XElement xe = XElement.Load(clreg.FileNameXML);
    //                    var shipElement = from el in xe.Elements("PAW_Company_Info")
    //                                      select el;
                     
    //                this.dt = new DataTable();
    //                this.dt.Columns.Add("Name");
    //                this.dt.Columns.Add("Address1");
    //                this.dt.Columns.Add("Address2");
    //                this.dt.Columns.Add("City");
    //                this.dt.Columns.Add("State");
    //                this.dt.Columns.Add("Zip");
    //                this.dt.Columns.Add("Country");
    //                this.dt.Columns.Add("Fax");
    //                this.dt.Columns.Add("Telephone");
    //                DataRow row = this.dt.NewRow();
    //                foreach (XElement element2 in shipElement)
    //                {
    //                    row["Name"] = (element2.Element("Name") == null) ? "" : element2.Element("Name").Value;
    //                    row["Address1"] = (element2.Element("Address1") == null) ? "" : element2.Element("Address1").Value;
    //                    row["Address2"] = (element2.Element("Address2") == null) ? "" : element2.Element("Address2").Value;
    //                    row["City"] = (element2.Element("City") == null) ? "" : element2.Element("City").Value;
    //                    row["State"] = (element2.Element("State") == null) ? "" : element2.Element("State").Value;
    //                    row["Zip"] = (element2.Element("Zip") == null) ? "" : element2.Element("Zip").Value;
    //                    row["Country"] = (element2.Element("Country") == null) ? "" : element2.Element("Country").Value;
    //                    row["Fax"] = (element2.Element("Fax") == null) ? "" : element2.Element("Fax").Value;
    //                    row["Telephone"] = (element2.Element("Telephone") == null) ? "" : element2.Element("Telephone").Value;
    //                    this.dt.Rows.Add(row);
    //                }
    //            }
    //            return this.dt;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message);
    //            return this.dt;
    //        }
    //    }

    //    public DataTable GetCusInfo()
    //    {
    //        DataTable dt;
    //        try
    //        {
    //            this.readconfile = new ReadConfigFile();
    //            string selectCommandText = "";
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != "")
    //            {
    //                this.con.Open();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.dt = new DataTable();
    //                    selectCommandText = "SELECT Name,Address1,Address2,City,State,Zip,Country,Telephone,Fax,CompanyEmail,SerialNumber,CustomerNumber,SysRegNumber  FROM CustInfo;";
    //                    this.da = new OleDbDataAdapter(selectCommandText, this.con);
    //                    this.da.Fill(this.dt);
    //                    this.con.Close();
    //                    return this.dt;
    //                }
    //            }
    //            dt = this.dt;
    //        }
    //        catch (Exception)
    //        {
    //            if (this.con.State != ConnectionState.Closed)
    //            {
    //                this.con.Close();
    //            }
    //            throw;
    //        }
    //        return dt;
    //    }

    //    public string GetPeachCustomerNumber()
    //    {
    //        string customerNumber;
    //        try
    //        {
    //            PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
    //            customerNumber = peachObj.CustomerNumber;
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return customerNumber;
    //    }

    //    public string GetPeachSerialNo()
    //    {
    //        string serialNumber;
    //        try
    //        {
    //            PeachtreeSingleTon peachObj = new PeachtreeSingleTon();
    //            serialNumber = peachObj.SerialNumber;
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        return serialNumber;
    //    }

    //    public bool SaveCusInfo(CompanyInformation comp, string regno, string srno, string cusno)
    //    {
    //        bool flag;
    //        try
    //        {
    //            this.readconfile = new ReadConfigFile();
    //            string str = "";
    //            this.con = new OleDbConnection();
    //            this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
    //            if (this.con.ConnectionString != "")
    //            {
    //                this.con.Open();
    //                this.cmd = new OleDbCommand();
    //                if (this.con.State == ConnectionState.Open)
    //                {
    //                    this.tran = this.con.BeginTransaction();
    //                    this.cmd.Connection = this.con;
    //                    this.cmd.Transaction = this.tran;
    //                    this.cmd.CommandType = CommandType.Text;
    //                    this.cmd.CommandText = "Select Count(Name) from CustInfo ";
    //                    if (Convert.ToInt32(this.cmd.ExecuteScalar()) == 0)
    //                    {
    //                        str = "INSERT INTO CustInfo(Name,Address1,Address2,City,State,Zip,Country,Telephone,Fax,CompanyEmail,SerialNumber,CustomerNumber,SysRegNumber)Values('" + comp.CompanyName + "','" + comp.Address.AddressLine1 + "','" + comp.Address.AddressLine2 + "','" + comp.Address.City + "','" + comp.Address.State + "','" + comp.Address.Zip + "','" + comp.Address.Country + "','" + comp.Address.Phone + "','" + comp.Address.Fax + "','" + comp.Address.Email + "','" + srno + "','" + cusno + "','" + regno + "' ) ";
    //                    }
    //                    else
    //                    {
    //                        string str2 = "UPDATE CustInfo SET Address1='" + comp.Address.AddressLine1 + "',Address2='" + comp.Address.AddressLine2 + "', City='" + comp.Address.City + "', ";
    //                        str2 = str2 + " State= '" + comp.Address.State + "',Zip='" + comp.Address.Zip + "',Country= '" + comp.Address.Country + "', Telephone= '" + comp.Address.Phone + "' ,";
    //                        str = str2 + " Fax= '" + comp.Address.Fax + "',CompanyEmail='" + comp.Address.Email + "'";
    //                    }
    //                    this.cmd.CommandText = str;
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

