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
  public   class CounsilDAL
    {

      List<Counsil> Locounsil;

      List<Committe> LoCommitte;
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private OleDbDataReader dr;
        private ReadConfigFile readconfile;
        private OleDbTransaction tran;
        List<Counsil> LoCouncil;
        public bool SaveCounsil(Counsil c)
        {
            try
            {
                string insert;

                if (c.CounsilID == 0)
                {
                    insert = " Insert into Counsil  (CounsilName) values ('" + c.CounsilName + "')";
                }
                else
                    insert = "Update Counsil set CounsilName='" + c.CounsilName + "' where CounsilID=" + c.CounsilID+ "";
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

        public List<Counsil> GetCounsil()
        {
            Locounsil=new List<Counsil>();
            try
            {
                string Get = " Select * from Counsil ";
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
                    Counsil c = new Counsil();
                    c.CounsilID = Convert.ToInt32(dr["CounsilID"]);
                    c.CounsilName = dr["CounsilName"].ToString();
                    Locounsil.Add(c);
                }
                dr.Close();
                tran.Commit();
                return Locounsil;
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

        public bool DeleteCounsil(Counsil c)
        {
            try
            {

                string delete = "Delete from Counsil where CounsilID="+c.CounsilID+"";

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
        public List<Counsil> GetMemberCouncil(Membership MemberID)
        {
            Locounsil = new List<Counsil>();
            try
            {
                string Get = "SELECT mc.CounsilID,c.CounsilName from Counsil c,MemberCouncil mc,MembershipData md" +
                                    " WHERE mc.CounsilID=c.CounsilID AND mc.MID=md.MID AND md.MID=" + MemberID.MID;
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand(Get, con);
                cmd.Transaction = tran;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Counsil c = new Counsil();
                    c.CounsilID = Convert.ToInt32(dr["CounsilID"]);
                    c.CounsilName = dr["CounsilName"].ToString();
                    Locounsil.Add(c);
                }
                dr.Close();
                tran.Commit();
                return Locounsil;
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
        public List<Committe> GetMemberCommitte(Membership MemberID)
        {
            LoCommitte = new List<Committe>();
            try
            {
                string Get = "SELECT mc.CommitteeID,c.CommitteName from Committe c,MemberComittee mc,MembershipData md"+
                                    " WHERE mc.CommitteeID=c.ID AND mc.MID=md.MID AND md.MID="+ MemberID.MID;
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand(Get, con);
                cmd.Transaction = tran;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Committe c = new Committe();
                    c.CommitteID = Convert.ToInt32(dr["CommitteeID"]);
                    c.CommitteName = dr["CommitteName"].ToString();
                   LoCommitte.Add(c);
                }
                dr.Close();
                tran.Commit();
                return LoCommitte;
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
