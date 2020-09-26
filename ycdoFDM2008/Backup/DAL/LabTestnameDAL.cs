using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data.OleDb;
using System.Data;
using OleDbHelper;
using Common.Enum;

namespace DAL
{
  public   class LabTestNameDAL
    {

      List<LabTestName> ltn;


        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private OleDbDataReader dr;
        private ReadConfigFile readconfile;
        private OleDbTransaction tran;

        public int GetNextLabTestID()
        {
            try
            {
                int nextId=0;
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                cmd = new OleDbCommand("Select Max(ID) From LabTest", con);
                object obj = cmd.ExecuteScalar();
                if (obj != DBNull.Value)
                    nextId = Convert.ToInt32(obj) + 1;
                return nextId;
            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public bool SaveLabtestname(LabTestName c)
        {
            try
            {
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();

                string insert;

                
                int VID = 0;
                if (c.ID == 0)
                {
                    cmd = new OleDbCommand("Select Max(ID) From LabTest", con);
                    cmd.Transaction = tran;

                    VID = Convert.ToInt32(cmd.ExecuteScalar());
                    c.ID = VID + 1;
                    insert = " Insert into LabTest (ID,[Test (A-Z)],Sample,Performed,Report,Deserving,Poor,YCDO,Generall,Shahab,Ghori,IsMedicine,Unit,IsRsTenInjection,IsAlwaysPaid,IsOd,PurchasePrice,RetailPrice)"
                    +" values (" + c.ID + ",'" + c.TestName + "','" + c.Sample + "','" + c.Performed + "',"
                   + "'" + c.Report + "'," + c.Deserving + "," + c.Poor + "," + c.YCDO + "," + c.General + ","
                   +" " + c.Shahab + "," + c.Ghori + "," + c.IsMedicine + ",'" + c.Unit  + "'," + c.IsRsTenInjection + "," + c.IsAlwaysPaid + "," + c.IsOd  +","+c.PurchasePrice+","+c.RetailPrice+")";
                }
                else
                    insert = "Update LabTest set [Test (A-Z)]='" + c.TestName + "',Sample='" + c.Sample + "',Performed='" + c.Performed + "',Report='" + c.Report + "',Deserving=" + c.Deserving + ",Poor=" + c.Poor + ",YCDO=" + c.YCDO + ",Generall=" + c.General + ",Shahab=" + c.Shahab + ",Ghori=" + c.Ghori + ",IsMedicine=" + c.IsMedicine + ",Unit='" + c.Unit + "',IsAlwaysPaid=" + c.IsAlwaysPaid + ",IsRsTenInjection=" + c.IsRsTenInjection +",IsOd="+ c.IsOd + ",PurchasePrice="+c.PurchasePrice+",RetailPrice="+c.RetailPrice+" where ID=" + c.ID;
               
                cmd = new OleDbCommand(insert, con);
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public List<LabTestName> GetLabTestNames()
        {
            ltn=new List<LabTestName>();
            try
            {
                string Get = " Select * from LabTest ";
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand(Get, con);
                cmd.Transaction = tran;
                
                dr=cmd.ExecuteReader();
                while (dr.Read())
                {
                    LabTestName c = new LabTestName();
                    c.ID =dr["ID"]==System.DBNull.Value? 0: Convert.ToInt32(dr["ID"]);
                    c.TestName = dr["Test (A-Z)"] == System.DBNull.Value ? "" : Convert.ToString(dr["Test (A-Z)"]);
                    c.Sample = dr["Sample"] == System.DBNull.Value ? "" : Convert.ToString(dr["Sample"]);
                    c.Performed = dr["Performed"] == System.DBNull.Value ? "" : Convert.ToString(dr["Performed"]);
                    c.Report = dr["Report"] == System.DBNull.Value ? "" : Convert.ToString(dr["Report"]);
                    c.Deserving = dr["Deserving"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["Deserving"]);
                    c.Poor = dr["Poor"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["Poor"]);
                    c.YCDO = dr["YCDO"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["YCDO"]);
                    c.General = dr["Generall"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["Generall"]);
                    c.Shahab = dr["Shahab"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["Shahab"]);
                    c.Ghori = dr["Ghori"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["Ghori"]);
                    c.Unit = dr["Unit"] == System.DBNull.Value ? string.Empty : dr["Unit"].ToString();
                    c.IsMedicine = Convert.ToBoolean(dr["IsMedicine"]);
                    c.IsRsTenInjection = Convert.ToBoolean(dr["IsRsTenInjection"]);
                    c.IsAlwaysPaid = Convert.ToBoolean(dr["IsAlwaysPaid"]);
                    c.IsOd = Convert.ToBoolean(dr["IsOd"]);
                    c.PurchasePrice = dr["PurchasePrice"] == DBNull.Value ? 0 : Convert.ToDouble(dr["PurchasePrice"]);
                    c.RetailPrice = dr["RetailPrice"] == DBNull.Value ? 0 : Convert.ToDouble(dr["RetailPrice"]);
                    ltn.Add(c);
                }
                dr.Close();
                tran.Commit();
                return ltn;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public bool DeleteLabtestName(LabTestName c)
        {
            try
            {

                string delete = "Delete from LabTest where ID="+c.ID+"";

                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand(delete, con);
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        
        }


    }
}
