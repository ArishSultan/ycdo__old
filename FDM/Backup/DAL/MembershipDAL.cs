using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Common;
using System.Data.OleDb;
using System.Data;
using OleDbHelper;
using Common.Enum;
using Common.Datasets;

namespace DAL
{
   public  class MembershipDAL
    {

        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbDataReader dr;
        private OleDbTransaction tran;

        List<Membership> members;
        
        public bool SaveMembershipData(Membership mem)
        {
            try
            {
                string insert;
                if (mem.MID == 0)

                    insert = "Insert Into MembershipData(MemberName,MemberLastName,Age,Gender,NIC"
                       + ",Refrence,Phone,Email,Bloodgroup,MemberShipFee,CollectionDate,Adress,BranchName,MembershipNo,Status,MonthlyFee,CurrentDate,City) "
                       + "values ('" + mem.MemberName + "','" + mem.MemberLastName + "'," + mem.AGE + ",'" + mem.Gender + "','" + mem.NIC + "','"
                       + mem.Refrence + "'," + mem.Phone + ",'" + mem.Email + "','" + mem.BloodGroup + "','"
                       + mem.MembershipFee + "'," + mem.CollectionDate + ",'" + mem.Adress + "','" + mem.branch.BranchName + "',"
                       + "" + mem.MembershipNo + ",'" + mem.Status + "'," + mem.MonthlyFee + ",#"+mem.CurrentDate+"#,'"+mem.City.CityName+"' )";

                else

                    insert = "Update MembershipData set MemberName='" + mem.MemberName + "',MemberLastName='" + mem.MemberLastName + "',Age=" + mem.AGE + ""
                        + ", Gender= '" + mem.Gender + "',NIC= '" + mem.NIC + "',Refrence='" + mem.Refrence + "',Phone='" + mem.Phone + "',Email='" + mem.Email + "',"
                        + " Bloodgroup= '" + mem.BloodGroup + "',MemberShipFee='" + mem.MembershipFee + "' ,CollectionDate= " + mem.CollectionDate + ",Adress= '" + mem.Adress + "',BranchName= '" + mem.branch.BranchName + "',"
                + " MembershipNo=" + mem.MembershipNo + " ,Status='" + mem.Status + "' ,MonthlyFee= " + mem.MonthlyFee + ",CurrentDate=#" + mem.CurrentDate + "#,City='" + mem.City.CityName + "' where MID=" + mem.MID + "";
                
                
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

        public List<Membership> GetMembershipData()
        {

            try
            {

                members = new List<Membership>();
                string insert = "Select * from MembershipData";

                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand(insert, con);
                cmd.Transaction = tran;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Membership m = new Membership();
                    m.MID = dr["MID"] == System.DBNull.Value ? 0 : Convert.ToInt32(dr["MID"]);
                    m.branch.BranchName = dr["BranchName"] == System.DBNull.Value ? null : Convert.ToString(dr["BranchName"]);
                    m.MembershipNo = dr["MembershipNo"]==System.DBNull.Value? 0 :Convert.ToDecimal(dr["MembershipNo"]);
                    m.MemberName = dr["MemberName"] == System.DBNull.Value ? null : Convert.ToString(dr["MemberName"]);
                    m.NIC = dr["NIC"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["NIC"]);
                    m.MembershipFee = dr["MemberShipFee"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["MemberShipFee"]);
                    m.BloodGroup = dr["Bloodgroup"] == System.DBNull.Value ? null : Convert.ToString(dr["Bloodgroup"]);
                    m.MemberLastName = dr["MemberLastName"] == System.DBNull.Value ? null : Convert.ToString(dr["MemberLastName"]);
                    m.Gender = dr["Gender"] == System.DBNull.Value ? null : Convert.ToString(dr["Gender"]);
                    m.Phone = dr["Phone"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["Phone"]);
                    m.Refrence = dr["Refrence"] == System.DBNull.Value ? null : Convert.ToString(dr["Refrence"]);
                    m.Adress = dr["Adress"] == System.DBNull.Value ? null : Convert.ToString(dr["Adress"]);
                    m.Email = dr["Email"] == System.DBNull.Value ? null : Convert.ToString(dr["Email"]);
                    m.Status = dr["Status"] == System.DBNull.Value ? null : Convert.ToString(dr["Status"]);
                    m.AGE = dr["Age"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["Age"]);
                    m.MonthlyFee = dr["MonthlyFee"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["MonthlyFee"]);
                    m.CollectionDate = dr["CollectionDate"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["CollectionDate"]);
                    m.City.CityName = dr["City"] == System.DBNull.Value ? null : Convert.ToString(dr["City"]);
                    m.CurrentDate = dr["CurrentDate"] == System.DBNull.Value ? new DateTime(2012,11,06) : Convert.ToDateTime(dr["CurrentDate"]);

                    members.Add(m);

                }
                dr.Close();

                tran.Commit();
                return members;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool DeleteMembershipData(Membership mem)
        { 
           try
            {

                string delete = "Delete from MembershipData where MID=" + mem.MID + "";

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


        public DSMembership GetData(Membership mem,bool Branches,bool Cities,bool All)
        {
            DSMembership ds = new DSMembership();
            try
            {
                
                
                    string branches = "Select * from MembershipData Where BranchName='" + mem.branch.BranchName + "'";
                
                
                string all = "Select * from MembershipData";
            
           
                  string  cities ="Select * from MembershipData Where City='"+mem.City.CityName+"'";

                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
               if (con.State == ConnectionState.Open)
                {
                    string select="" ;
                    if (Branches == true)
                    {
                        select = branches;
                    }
                    else if (Cities == true)
                    {
                        select = cities;
                    }
                    else  if (All == true)
                    {
                        select = all;
                    }

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
