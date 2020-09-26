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
        List<MemberCollection> memberscollc;

        public int GetNextMemberNo()
        {
            int nextMemberNo=0;
            try
            {
                string Select = "SELECT max(MemberShipNo) from MembershipData";
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                cmd = new OleDbCommand(Select, con);
                cmd.Transaction = tran;
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                    nextMemberNo = 1;
                else
                    nextMemberNo = Convert.ToInt32(obj)+1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { con.Close(); }
            return nextMemberNo;
        }
        public int GetMaxMemberID()
        {
            int nextMemberNo = 0;
            try
            {
                string Select = "SELECT max(MID) from MembershipData";
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                cmd = new OleDbCommand(Select, con);
                cmd.Transaction = tran;
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                    nextMemberNo = 1;
                else
                    nextMemberNo = Convert.ToInt32(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { con.Close(); }
            return nextMemberNo;
        }
        public bool SaveMembershipData(Membership mem)
        {
            try
            {
                string insert;
            //    decimal RefrenceNo = mem.Refrence == null ? 0 : mem.Refrence.MembershipNo;
                if (mem.MID == 0)

                    insert = "Insert Into MembershipData(MemberName,MemberLastName,Age,Gender,NIC"
                       + ",Refrence,Phone,Email,Bloodgroup,MemberShipFee,CollectionDate,Adress,BranchName"
                       + ",MembershipNo,Status,MonthlyFee,CurrentDate,City"
                       + ",CountryName,MemberType) "
                       + "values ('" + mem.MemberName + "','" + mem.MemberLastName + "'," + mem.AGE + ",'" + mem.Gender + "','" + mem.NIC
                       + "','" + mem.refrence + "','" + mem.Phone + "','" + mem.Email + "','" + mem.BloodGroup + "'," + mem.MembershipFee + ",'" + mem.CollectionDate.ToShortDateString() + "','" + mem.Adress + "','" + mem.branch.BranchName
                       + "'," + mem.MembershipNo + ",'" + mem.Status + "'," + mem.MonthlyFee + ",'" + mem.CurrentDate.ToShortDateString() + "','" + mem.City.CityName
                       + "','" + mem.Country.CountryName + "','" + mem.MemberType + "')";
                else
                    insert = "Update MembershipData set MemberName='" + mem.MemberName + "',MemberLastName='" + mem.MemberLastName + "',Age=" + mem.AGE 
                        + ", Gender= '" + mem.Gender + "',NIC= '" + mem.NIC + "',Refrence='" + mem.refrence+ "',Phone='" + mem.Phone + "',Email='" + mem.Email + "',"
                        + " Bloodgroup= '" + mem.BloodGroup + "',MemberShipFee=" + mem.MembershipFee + " ,CollectionDate= '" + mem.CollectionDate.ToShortDateString() + "',Adress= '" + mem.Adress + "',BranchName= '" + mem.branch.BranchName + "',"
                        + "Status='" + mem.Status + "' ,MonthlyFee= " + mem.MonthlyFee + ",CurrentDate='" + mem.CurrentDate.ToShortDateString() + "',City='" + mem.City.CityName + "',  "
                        + " CountryName='" + mem.Country.CountryName + "',MemberType='" + mem.MemberType + "' where MID=" + mem.MID;

                
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                cmd = new OleDbCommand(insert, con);
                //  cmd.Transaction = tran;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
             //   tran = con.BeginTransaction();
                ///store councils
                ///
               // int R = GetMaxMemberID();
                //con = new OleDbConnection();
                con.Open();
                OleDbCommand cmdCouncil;
                cmdCouncil = new OleDbCommand();
             
               // cmdCouncil.Transaction = tran;
                cmdCouncil.Connection = con;
                cmdCouncil.CommandText = "delete from MemberCouncil where MID=" + mem.MID;
             
                cmdCouncil.ExecuteNonQuery();
                foreach (var item in mem.Counsil )
	            {
                    cmdCouncil.CommandText = "Insert into MemberCouncil(MID,CounsilID) Values(" + mem.MID + "," + item.CounsilID+ ")";
                    cmdCouncil.ExecuteNonQuery();
                }
                ///store committees
                ///
                OleDbCommand cmdCommittee;
                cmdCommittee = new OleDbCommand();
                cmdCommittee.Connection = con;
              //  cmdCommittee.Transaction = tran;
                cmdCommittee.CommandText = "delete from MemberComittee where MID =" + mem.MID;
             
                cmdCommittee.ExecuteNonQuery();
                foreach (var item in mem.Committe)
                {
                    cmdCommittee.CommandText = "Insert into MemberComittee(MID,CommitteeID) Values(" + mem.MID + "," + item.CommitteID + ")";
                    cmdCommittee.ExecuteNonQuery();
                }
              //  cmd = new OleDbCommand(insert, con);
              ////  cmd.Transaction = tran;
              //  cmd.ExecuteNonQuery();
            //    tran.Commit();
                cmd.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
             //   tran.Rollback();
                throw ex;
            }
            finally
            {
                con.Close();
            }


        }
        public List<Committe> GetCommittes(Membership mem)
        {
            List<Committe> cms = new List<Committe >();
            try
            {
                string insert = "Select mc.*,c.CommitteName from MemberComittee  mc,Committe c where c.ID = mc.CommitteeID and mc.MID=" + mem.MID;
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
                    Committe cm = new Committe();
                    cm.CommitteID = Convert.ToInt32(dr["CommitteeID"]);
                    cm.CommitteName = dr["CommitteName"].ToString();
                    cms.Add(cm);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return cms;
        }
        public List<Counsil> GetCouncils(Membership mem)
        {
            List<Counsil> councils = new List<Counsil>();
            try
            {
                members = new List<Membership>();
                string insert = "Select mc.*,c.CounsilName from MemberCouncil  mc,Counsil c where c.CounsilID = mc.CounsilId and mc.MID=" + mem.MID;
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
                    Counsil c = new Counsil();
                    c.CounsilID = Convert.ToInt32(dr["CounsilID"]);
                    c.CounsilName = dr["CounsilName"].ToString();
                    councils.Add(c);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                con.Close();
            }
            return councils;
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
                    m.NIC = dr["NIC"] == System.DBNull.Value ? string.Empty : Convert.ToString(dr["NIC"]);
                    m.MembershipFee = dr["MemberShipFee"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["MemberShipFee"]);
                    m.BloodGroup = dr["Bloodgroup"] == System.DBNull.Value ? null : Convert.ToString(dr["Bloodgroup"]);
                    m.MemberLastName = dr["MemberLastName"] == System.DBNull.Value ? null : Convert.ToString(dr["MemberLastName"]);
                    m.Gender = dr["Gender"] == System.DBNull.Value ? null : Convert.ToString(dr["Gender"]);
                    m.Phone = dr["Phone"] == System.DBNull.Value ? string.Empty : Convert.ToString(dr["Phone"]);
                //    m.Refrence = new Membership();
                    m.refrence = dr["Refrence"].ToString();
                    m.Adress = dr["Adress"] == System.DBNull.Value ? null : Convert.ToString(dr["Adress"]);
                    m.Email = dr["Email"] == System.DBNull.Value ? null : Convert.ToString(dr["Email"]);
                    m.Status = dr["Status"] == System.DBNull.Value ? null : Convert.ToString(dr["Status"]);
                    m.AGE = dr["Age"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["Age"]);
                    m.MonthlyFee = dr["MonthlyFee"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["MonthlyFee"]);
                    m.CollectionDate = dr["CollectionDate"] == System.DBNull.Value ?new DateTime(): Convert.ToDateTime(dr["CollectionDate"]);
                    m.City.CityName = dr["City"] == System.DBNull.Value ? null : Convert.ToString(dr["City"]);
                    m.CurrentDate = dr["CurrentDate"] == System.DBNull.Value ? new DateTime() : Convert.ToDateTime(dr["CurrentDate"]);
                    m.Country.CountryName = dr["CountryName"] == System.DBNull.Value ? null : Convert.ToString(dr["CountryName"]);
                    m.MemberType = dr["MemberType"] == System.DBNull.Value ? null : Convert.ToString(dr["MemberType"]);
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


        public DSMembership GetData(Membership mem,bool Branches,bool Cities,bool All,bool bloodGroup,bool Counsil,bool Committe)
        {
            DSMembership ds = new DSMembership();
            try
            {


                string branches = "Select * from MembershipData Where BranchName='" + mem.branch.BranchName + "'";
                string all = "Select * from MembershipData";
                string cities = "Select * from MembershipData Where City='" + mem.City.CityName + "'";
                string blodgroup = "Select * from MembershipData Where Bloodgroup='" + mem.BloodGroup + "'";



                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string select = "";
                    if (Branches == true)
                    {
                        select = branches;
                    }
                    else if (Cities == true)
                    {
                        select = cities;
                    }
                    else if (All == true)
                    {
                        select = all;
                    }
                    else if (bloodGroup == true)
                    {
                        select = blodgroup;
                    }
                    else if (Committe == true)
                    {
                        select = "Select *,'" + mem.Committe[0].CommitteName + "'  as Committe from MembershipData md,MemberComittee mc where mc.MID = md.MID and mc.CommitteeId=" + mem.Committe[0].CommitteID;
                    }
                    else if (Counsil == true)
                    {
                        select = "Select *,'" + mem.Counsil[0].CounsilName + "'  as Counsil from MembershipData md,MemberCouncil mc where mc.MID = md.MID and mc.CounsilId=" + mem.Counsil[0].CounsilID;
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

        public List<Membership> GetMembersAndDonors()
        {
            
                try
            {

                

                members = new List<Membership>();
                string Select = "SELECT Mid,MemberName from MembershipData Union All select Mid,DonorName from Donor";

                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand(Select, con);
                cmd.Transaction = tran;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Membership m = new Membership();
                    Donor d = new Donor();

                    m.MemberName = dr["MemberName"] == System.DBNull.Value ? null : Convert.ToString(dr["MemberName"]);
                    m.MembershipNo = dr["Mid"] == System.DBNull.Value ? 0 : Convert.ToInt32(dr["Mid"]);
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
            finally
            {
                con.Close();
            }
           
        
        }


        public List<Membership> GetMembersCollection(MemberCollection mem)
        {

            try
            {



                members = new List<Membership>();
                string Select = "SELECT MonthlyFee from MembershipData where MemberName='"+mem.MemberName+"'";

                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand(Select, con);
                cmd.Transaction = tran;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Membership m = new Membership();
                    Donor d = new Donor();

                    m.MonthlyFee = dr["MonthlyFee"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["MonthlyFee"]);
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
            finally
            {
                con.Close();
            }


        }


        public bool SaveMembershipCollection(MemberCollection mc)
        {
            try
            {
                if (new rtSMSDAL().SaveAndSendSMS(mc))
                {
                    string insert;
                    if (mc.ID == 0)

                        insert = "Insert Into MemberCollection(MemberName,CollectionDate,CollectionFee,ReciptNo,MID,CollectionMonth) "
                           + "values ('" + mc.MemberName + "','" + mc.CollectionDate + "'," + mc.CollectionFee + "," + mc.ReciptNo + "," + mc.Member.MID + ",'" + mc.CollectionMonth + "')";

                    else

                        insert = "Update MemberCollection set MemberName='" + mc.MemberName + "',CollectionDate='" + mc.CollectionDate + "',CollectionFee=" + mc.CollectionFee + " ,ReciptNo=" + mc.ReciptNo + " , MID=" + mc.Member.MID + " , CollectionMonth='" + mc.CollectionMonth + "' where ID=" + mc.ID + "";


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
                else
                {
                    return false;
                }
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

        public List<MemberCollection> GetMemberCollectionData()
        {

            try
            {

                memberscollc = new List<MemberCollection>();
                string insert = "Select * from MemberCollection";

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
                    MemberCollection m = new MemberCollection();


                    m.ID = dr["ID"] == System.DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                    m.MemberName = dr["MemberName"] == System.DBNull.Value ? null : Convert.ToString(dr["MemberName"]);
                    m.CollectionDate = dr["CollectionDate"] == System.DBNull.Value ? new DateTime() : Convert.ToDateTime(dr["CollectionDate"]);
                    m.CollectionFee = dr["CollectionFee"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["CollectionFee"]);
                    m.ReciptNo = dr["ReciptNo"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["ReciptNo"]);
                    memberscollc.Add(m);

                }
                dr.Close();

                tran.Commit();
                return memberscollc;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public bool DeleteMemberCollection(MemberCollection mem)
        {
            try
            {

                string delete = "Delete from MemberCollection where ID=" + mem.ID + "";

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

        public DSMemberCollection GetMemberCollectionData(MemberCollection mem,string fromdate,string todate,bool SeeForPaid)
        {
            DSMemberCollection ds = new DSMemberCollection();
            try
            {
                string Member="";
                    string all= "";
                if (mem.MemberName != null && mem.MemberName!="")
                {
                   // Member = "Select * from MemberCollection Where MemberName='" + mem.MemberName + "' and CollectionDate>='"+fromdate+"' and CollectionDate<='"+todate+"'";
                    if (SeeForPaid)
                    {
                        Member = "select m.* from QryMemberCollectionReport m Where m.MID=" + mem.Member.MID + " and  m.CollectionDate>='" + fromdate + "' and m.CollectionDate<='" + todate + "'";
                    }
                    else { 
                       Member = "Select *  from MembershipData where MID Not in ( select p.MID from  MemberCollection p where p.CollectionMonth='"+fromdate+"')";
                    }
                
                }
                else
                {
                   //  all = "Select * from MemberCollection";
                if(SeeForPaid)
                {    all = "Select * from QryMemberCollectionReport";
                }else
                {
                    all  = "Select *  from MembershipData where MID Not in ( select p.MID from  MemberCollection p where p.CollectionMonth=" + fromdate + ")";
                 
                    }
                
                }

               

                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string select = "";
                    if (mem.MemberName != null && mem.MemberName!="")
                    {
                        select = Member;
                    }
                    else 
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
