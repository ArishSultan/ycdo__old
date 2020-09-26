using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data.OleDb;
using System.Data;
using OleDbHelper;
using Common.Enum;
using Common.Datasets;

namespace DAL
{
  public   class PerformanceDAL
    {

      List<Performance> performance;


        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private OleDbDataReader dr;
        private ReadConfigFile readconfile;
        private OleDbTransaction tran;

        public bool SavePerformance(Performance c)
        {
            try
            {
                string insert;

                if (c.PerformanceID == 0)
                {
                    insert = " Insert into Performance  (MemberName,PerformanceDate,GoodEntries,BadEntries) values ('" + c.MemberName + "' ,#"+c.PerformanceDate+"#,'"+c.GoodEntries+"','"+c.BadEntries+"')  ";
                }
                else
                    insert = "Update Performance set MemberName='" + c.MemberName + "',PerformanceDate=#"+c.PerformanceDate+"#,GoodEntries='"+c.GoodEntries+"',BadEntries='"+c.BadEntries+"'   where ID=" + c.PerformanceID+ "";
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
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

        public List<Performance> GetPerformance()
        {
            performance=new List<Performance>();
            try
            {
                string Get = " Select * from Performance ";
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
                    Performance c = new Performance();
                    c.PerformanceID = Convert.ToInt32(dr["ID"]);
                    c.MemberName = dr["MemberName"]==System.DBNull.Value?null:Convert.ToString(dr["MemberName"]);
                    c.PerformanceDate = dr["PerformanceDate"] == System.DBNull.Value ? new DateTime() : Convert.ToDateTime(dr["PerformanceDate"]);
                    c.GoodEntries = dr["GoodEntries"] == System.DBNull.Value ? null : Convert.ToString(dr["GoodEntries"]);
                    c.BadEntries = dr["BadEntries"] == System.DBNull.Value ? null : Convert.ToString(dr["BadEntries"]);
                    performance.Add(c);
                }
                dr.Close();
                tran.Commit();
                return performance;
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

        public bool DeletePerformance(Performance c)
        {
            try
            {

                string delete = "Delete from Performance where ID="+c.PerformanceID+"";

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


        public DSMemberProgress  GetMemberProgress(Performance d, string fromdate, string todate)
        {
            DSMemberProgress ds = new DSMemberProgress();
            try
            {

                string Donors = "";
                string all = "";
                if (d.MemberName != null && d.MemberName != "")
                {

                    Donors = "Select * from Performance Where MemberName='" + d.MemberName + "' and PerformanceDate>=#" + fromdate + "# and PerformanceDate<=#" + todate + "#";
                }
                else
                    all = "Select * from Performance";



                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string select = "";
                    if (d.MemberName != null && d.MemberName != "")
                    {
                        select = Donors;
                    }
                    else
                        select = all;

                    da = new OleDbDataAdapter(select, con);
                    da.Fill(ds, ds.Tables[0].TableName);

                }


                return ds;
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
