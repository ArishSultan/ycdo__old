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
  public   class CommitteDAL
    {

      List<Committe> committe;


        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private OleDbDataReader dr;
        private ReadConfigFile readconfile;
        private OleDbTransaction tran;

        public bool SaveCommitte(Committe c)
        {
            try
            {
                string insert;

                if (c.CommitteID == 0)
                {
                    insert = " Insert into Committe  (CommitteName) values ('" + c.CommitteName + "')";
                }
                else
                    insert = "Update Committe set CommitteName='" + c.CommitteName + "' where ID=" + c.CommitteID+ "";
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

        public List<Committe> GetCommitte()
        {
            committe=new List<Committe>();
            try
            {
                string Get = " Select * from Committe ";
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
                    Committe c = new Committe();
                    c.CommitteID = Convert.ToInt32(dr["ID"]);
                    c.CommitteName = dr["CommitteName"].ToString();
                    committe.Add(c);
                }
                dr.Close();
                tran.Commit();
                return committe;
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

        public bool DeleteCommitte(Committe c)
        {
            try
            {

                string delete = "Delete from Committe where ID="+c.CommitteID+"";

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
