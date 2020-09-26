using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

using Common;
// using ExportImport;
using OleDbHelper;


namespace DAL
{
    public class MaintainSalesPersonDAL
    {
        public MaintainSalesPersonDAL() 
        { 
        
        }

        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbTransaction tran;

        public bool DeleteSalesPerson(SalesPerson  sp)
        {
            
            try
            {
                this.readconfile = new ReadConfigFile();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                if (this.con.ConnectionString != "")
                {
                    this.con.Open();
                    this.cmd = new OleDbCommand();
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.tran = this.con.BeginTransaction();
                        this.cmd.Connection = this.con;
                        this.cmd.Transaction = this.tran;

                        this.cmd.CommandType = CommandType.Text;

                        this.cmd.CommandText = "Delete * from HRBSalesAccounts  where SalesPersonID=" + sp.SPId;
                        this.cmd.ExecuteNonQuery();

                        this.cmd.CommandText = "Delete * from SalesPersons  where SalesPersonID=" + sp.SPId;
                        
                        if (this.cmd.ExecuteNonQuery() == 0)
                        {
                            this.tran.Rollback();

                            return false;
                        }

                        

                        this.tran.Commit();
                        this.con.Close();
                        return true;
                    }
                }
                return false;     
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public bool SaveSalesPerson(SalesPerson sp)
        {
            try
            {
                
                this.readconfile = new ReadConfigFile();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                if (this.con.ConnectionString != "")
                {
                    
                    this.con.Open();
                    this.cmd = new OleDbCommand();
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.tran = this.con.BeginTransaction();
                        this.cmd.Connection = this.con;
                        this.cmd.Transaction = this.tran;
                        this.cmd.CommandText = "Select Max(SalesPersonID) from SalesPersons";
                        this.cmd.CommandType = CommandType.Text;
                        int MaxSPID = 0;
                        if (this.cmd.ExecuteScalar() == System.DBNull.Value)
                            MaxSPID = 1;
                        else
                            MaxSPID = Convert.ToInt32(this.cmd.ExecuteScalar()) + 1;

                        if (sp.SPId == 0)
                        {
                            this.cmd.CommandText = "insert into SalesPersons(SalesPersonID,Code,Name,CommissionAmount,YTDCommission,SCommissionDate,PriorYearCommission,TotalCommission,InsertionDate,isInactive) values("
                                + MaxSPID + ",'" + sp.Id + "','" + sp.Name + "'," + sp.CommissionAmount + "," + sp.YTDCommissionAmount + ",'" + sp.SCommissionDate + "'," + sp.PriorCommissionAmount + "," + sp.TotalCommission + ",'" + DateTime.Now.Date + "'," + sp.IsInActive + ")";
                             if(this.cmd.ExecuteNonQuery() ==0)
                             {
                                 this.tran.Rollback();
                                 this.con.Close();
                                 return false;
                            }
                             for (int i = 0; i < sp.HRBAccounts.Count ; i++)
                             {
                                 this.cmd.CommandText = "insert into HRBSalesAccounts(SalesPersonID,Code,Name,CommissionAmount,YTDCommission,SCommissionDate,PriorYearCommission,TotalCommission,InsertionDate,isInactive,AccountNo,CommissionRate) values (" + MaxSPID + ",'" + sp.Id + "','" + sp.Name + "'," + sp.CommissionAmount + "," + sp.YTDCommissionAmount + ",'" + sp.SCommissionDate + "'," + sp.PriorCommissionAmount + "," + sp.TotalCommission + ",'" + DateTime.Now.Date + "'," + sp.IsInActive + ",'" + sp.HRBAccounts[i].SalesAccountID + "'," + sp.HRBAccounts[i].Percentage + ")";
                                 this.cmd.ExecuteNonQuery();
                             }
                        }
                        else
                        {


                            this.cmd.CommandText = "Update SalesPersons set   isInactive=" + sp.IsInActive + " where SalesPersonID=" + sp.SPId;
                            if (this.cmd.ExecuteNonQuery() == 0)
                            {
                                this.tran.Rollback();
                                this.con.Close();
                                return false;
                            }

                            this.cmd.CommandText = "Delete from HRBSalesAccounts where SalesPersonID =" + sp.SPId;
                            this.cmd.ExecuteNonQuery();

                            for (int i = 0; i < sp.HRBAccounts.Count; i++)
                            {
                                this.cmd.CommandText = "insert into HRBSalesAccounts(SalesPersonID,Code,Name,CommissionAmount,YTDCommission,SCommissionDate,PriorYearCommission,TotalCommission,InsertionDate,isInactive,AccountNo,CommissionRate) values (" + sp.SPId  + ",'" + sp.Id + "','" + sp.Name + "'," + sp.CommissionAmount + "," + sp.YTDCommissionAmount + ",'" + sp.SCommissionDate + "'," + sp.PriorCommissionAmount + "," + sp.TotalCommission + ",'" + DateTime.Now.Date + "'," + sp.IsInActive + ",'" + sp.HRBAccounts[i].SalesAccountID + "'," + sp.HRBAccounts[i].Percentage + ")";
                                this.cmd.ExecuteNonQuery();
                            }
                        }
                        
                        this.tran.Commit();
                        this.con.Close();
                        return true;
                    }
                }
                return false ;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<SalesPerson > GetSalesPersons()
        {
            List<SalesPerson> sPersons;
            try
            {
                this.readconfile = new ReadConfigFile();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                this.dt = new DataTable();
                DataTable dtAcc = new DataTable();
                if (this.con.ConnectionString != "")
                {
                    this.con.Open();
                    this.cmd = new OleDbCommand();
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.cmd.Connection = this.con;
                        this.cmd.CommandText = "Select * from SalesPersons";
                        this.da = new OleDbDataAdapter(this.cmd.CommandText, this.con);
                        this.da.Fill(this.dt);
                        this.cmd.CommandText = "Select * from HRBSalesAccounts";
                        this.da = new OleDbDataAdapter(this.cmd.CommandText, this.con);
                        this.da.Fill(dtAcc);
                        this.con.Close();
                    }
                }
                 sPersons = new List<SalesPerson>();
                SalesPerson sp;
                if (this.dt.Rows.Count > 0)
                {
                    foreach (DataRow row in this.dt.Rows)
                    {
                         sp = new SalesPerson();
                        sp.SPId  = Convert.ToInt32 (row["SalesPersonID"]);
                        sp.Id  = Convert.ToString(row["Code"]);
                        sp.Name = Convert.ToString(row["Name"]);
                        sp.CommissionAmount  = Convert.ToDecimal (row["CommissionAmount"]);
                        sp.YTDCommissionAmount = Convert.ToDecimal(row["YTDCommission"]);
                        sp.SCommissionDate  = Convert.ToDateTime (row["SCommissionDate"]);
                        sp.PriorCommissionAmount = Convert.ToDecimal(row["PriorYearCommission"]);
                        sp.TotalCommission  = Convert.ToDecimal(row["TotalCommission"]);
                        sp.InsertionDate = Convert.ToDateTime (row["InsertionDate"]);
                        sp.IsInActive  = Convert.ToBoolean (row["isInactive"]);
                        
                        //get accounts
                        HRobItem hAcc;
                        for (int i = 0; i < dtAcc.Rows.Count ; i++)
                        {
                          

                            if (sp.SPId ==Convert.ToInt64( dtAcc.Rows[i]["SalesPersonID"]))
                            {
                                hAcc = new HRobItem();

                                hAcc.Percentage = Convert.ToDecimal(dtAcc.Rows[i]["CommissionRate"]);
                                hAcc.SalesAccount.AccountId = Convert.ToString(dtAcc.Rows[i]["AccountNo"]);
                                sp.HRBAccounts.Add(hAcc);
                            }
                            
                        }
                        

                        sPersons.Add(sp);
                    }
                }
                sPersons = sPersons;
            }
            catch (Exception)
            {
                throw;
            }
            return sPersons;
        }
  
    }
}
