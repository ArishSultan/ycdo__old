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
   public class DonorDAL
    {

        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbDataReader dr;
        private OleDbTransaction tran;

        List<Donor> doners;

        public bool SaveDonorData(Donor d)
        {
            try
            {
                string insert;
                if (d.MID == 0)

                    insert = "Insert Into Donor(DonorName,DonorLastName,Age,Gender,NIC"
                       + ",Refrence,Phone,Email,Bloodgroup,DonorFee,CollectionDate,Adress,BranchName,DonorNo,Status,FundType,City,CurrentDate) "
                       + "values ('" + d.DonorName + "','" + d.DonorLastName + "'," + d.AGE + ",'" + d.Gender + "','" + d.NIC + "','"
                       + d.Refrence + "'," + d.Phone + ",'" + d.Email + "','" + d.BloodGroup + "','"
                       + d.DonorFee + "','" + d.CollectionDate + "','" + d.Adress + "','" + d.branch.BranchName + "',"
                       + "" + d.DonorNo + ",'" + d.Status + "','" + d.FundType + "','"+d.City.CityName+"','"+d.CurrentDate+"' )";

                else

                    insert = "Update Donor set DonorName='" + d.DonorName + "',DonorLastName='" + d.DonorLastName + "',Age=" + d.AGE + ""
                        + ", Gender= '" + d.Gender + "',NIC= '" + d.NIC + "',Refrence='" + d.Refrence + "',Phone='" + d.Phone + "',Email='" + d.Email + "',"
                        + " Bloodgroup= '" + d.BloodGroup + "',DonorFee='" + d.DonorFee + "' ,CollectionDate= '" + d.CollectionDate + "',Adress= '" + d.Adress + "',BranchName= '" + d.branch.BranchName + "',"
                + " DonorNo=" + d.DonorNo + " ,Status='" + d.Status + "' ,FundType= '" + d.FundType + "',City= '" + d.City.CityName + "',CurrentDate='" + d.CurrentDate + "' where MID=" + d.MID + "";


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

        public List<Donor> GetDonorData()
        {

            try
            {

                doners = new List<Donor>();
                string insert = "Select * from Donor";

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
                    Donor m = new Donor();
                    m.MID = dr["MID"] == System.DBNull.Value ? 0 : Convert.ToInt32(dr["MID"]);
                    m.branch.BranchName = dr["BranchName"] == System.DBNull.Value ? null : Convert.ToString(dr["BranchName"]);
                    m.DonorNo = dr["DonorNo"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["DonorNo"]);
                    m.DonorName = dr["DonorName"] == System.DBNull.Value ? null : Convert.ToString(dr["DonorName"]);
                    m.NIC = dr["NIC"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["NIC"]);
                    m.DonorFee = dr["DonorFee"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["DonorFee"]);
                    m.BloodGroup = dr["Bloodgroup"] == System.DBNull.Value ? null : Convert.ToString(dr["Bloodgroup"]);
                    m.DonorLastName = dr["DonorLastName"] == System.DBNull.Value ? null : Convert.ToString(dr["DonorLastName"]);
                    m.Gender = dr["Gender"] == System.DBNull.Value ? null : Convert.ToString(dr["Gender"]);
                    m.Phone = dr["Phone"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["Phone"]);
                    m.Refrence = dr["Refrence"] == System.DBNull.Value ? null : Convert.ToString(dr["Refrence"]);
                    m.Adress = dr["Adress"] == System.DBNull.Value ? null : Convert.ToString(dr["Adress"]);
                    m.Email = dr["Email"] == System.DBNull.Value ? null : Convert.ToString(dr["Email"]);
                    m.Status = dr["Status"] == System.DBNull.Value ? null : Convert.ToString(dr["Status"]);
                    m.AGE = dr["Age"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["Age"]);
                    m.FundType = dr["FundType"] == System.DBNull.Value ? null : Convert.ToString(dr["FundType"]);
                    m.CollectionDate = dr["CollectionDate"] == System.DBNull.Value ? new DateTime() : Convert.ToDateTime(dr["CollectionDate"]);
                    m.City.CityName = dr["City"] == System.DBNull.Value ? null : Convert.ToString(dr["City"]);
                    m.CurrentDate = dr["CurrentDate"] == System.DBNull.Value ? new DateTime(2012,08,10) : Convert.ToDateTime(dr["CurrentDate"]);


                    doners.Add(m);



                }
                dr.Close();

                tran.Commit();
                return doners;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool DeleteDonorsData(Donor d)
        {
            try
            {

                string delete = "Delete from Donor where MID=" + d.MID + "";

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

        public DSDonor GetData(Donor d, bool Branches, bool Cities, bool All,bool Donationtype,string fromdate,string todate,bool Datewise)
        {
            DSDonor ds = new DSDonor();
            try
            {


                string branches = "Select * from Donor Where BranchName='" + d.branch.BranchName + "'";


                string all = "Select * from Donor";


                string cities = "Select * from Donor Where City='" + d.City.CityName + "'";
                string donationtype =" Select * from Donor Where FundType='" + d.FundType + "'";
                string datewise = " SELECT * from donor where CurrentDate>='" + fromdate + "' and CurrentDate<='" +todate + "'";

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
                    else if (Donationtype == true)
                    {
                        select = donationtype;
                    }

                    else if (Datewise == true)
                    {
                        select = datewise;
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

        public List<Donor> GetDonationType()
        {

            try
            {

                doners = new List<Donor>();
                string insert = "Select * from Donor";

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
                    Donor m = new Donor();
                    m.MID = dr["MID"] == System.DBNull.Value ? 0 : Convert.ToInt32(dr["MID"]);
                    m.branch.BranchName = dr["BranchName"] == System.DBNull.Value ? null : Convert.ToString(dr["BranchName"]);
                    m.DonorNo = dr["DonorNo"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["DonorNo"]);
                    m.DonorName = dr["DonorName"] == System.DBNull.Value ? null : Convert.ToString(dr["DonorName"]);
                    m.NIC = dr["NIC"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["NIC"]);
                    m.DonorFee = dr["DonorFee"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["DonorFee"]);
                    m.BloodGroup = dr["Bloodgroup"] == System.DBNull.Value ? null : Convert.ToString(dr["Bloodgroup"]);
                    m.DonorLastName = dr["DonorLastName"] == System.DBNull.Value ? null : Convert.ToString(dr["DonorLastName"]);
                    m.Gender = dr["Gender"] == System.DBNull.Value ? null : Convert.ToString(dr["Gender"]);
                    m.Phone = dr["Phone"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["Phone"]);
                    m.Refrence = dr["Refrence"] == System.DBNull.Value ? null : Convert.ToString(dr["Refrence"]);
                    m.Adress = dr["Adress"] == System.DBNull.Value ? null : Convert.ToString(dr["Adress"]);
                    m.Email = dr["Email"] == System.DBNull.Value ? null : Convert.ToString(dr["Email"]);
                    m.Status = dr["Status"] == System.DBNull.Value ? null : Convert.ToString(dr["Status"]);
                    m.AGE = dr["Age"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["Age"]);
                    m.FundType = dr["FundType"] == System.DBNull.Value ? null : Convert.ToString(dr["FundType"]);
                    m.CollectionDate = dr["CollectionDate"] == System.DBNull.Value ? new DateTime() : Convert.ToDateTime(dr["CollectionDate"]);
                    m.City.CityName = dr["City"] == System.DBNull.Value ? null : Convert.ToString(dr["City"]);
                    m.CurrentDate = dr["CurrentDate"] == System.DBNull.Value ? new DateTime(2012, 08, 10) : Convert.ToDateTime(dr["CurrentDate"]);


                    doners.Add(m);



                }
                dr.Close();

                tran.Commit();
                return doners;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Membership> GetFee(Membership mem,bool donor,bool member)
        {

            try
            {

              //  List<object> obj = new List<object>();

            List<Membership>    members = new List<Membership>();
                string select="";
                if(member==true)
                 select = "SELECT MonthlyFee from MembershipData where MemberName='" + mem.MemberName + "'";
                else if (donor==true)
                 select = "SELECT DonorFee from Donor where DonorName='" + mem.Donor.DonorName + "'";
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand(select, con);
                cmd.Transaction = tran;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Membership m = new Membership();
                    Donor d = new Donor();
                    if(member==true)
                    m.MonthlyFee = dr["MonthlyFee"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["MonthlyFee"]);
                    else
                    m.Donor.DonorFee = dr["DonorFee"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["DonorFee"]);
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

             public bool SaveDonorCollection(DonorCollection mc)
        {
            try
            {
                string insert;
                if (mc.ID == 0)

                    insert = "Insert Into DonorCollection(DonorName,CollectionDate,CollectionFee,ReciptNo,DonationType,Other,CheckDetail) "
                       + "values ('" + mc.DonorName + "','" + mc.CollectionDate + "'," + mc.CollectionFee + "," + mc.ReciptNo + ",'" + mc.DonationType + "','" + mc.Others + "'," + mc.CheckDetail + " )";

                else

                    insert = "Update DonorCollection set DonorName='" + mc.DonorName + "',CollectionDate='" + mc.CollectionDate + "',CollectionFee=" + mc.CollectionFee + " ,ReciptNo=" + mc.ReciptNo + ",DonationType='" + mc.DonationType + "',Other='" + mc.Others + "',CheckDetail="+mc.CheckDetail+"  where ID=" + mc.ID + "";


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
             List<DonorCollection> Donorcollc;

             public List<DonorCollection> GetDonorCollectionData()
             {

                 try
                 {

                     Donorcollc = new List<DonorCollection>();
                     string insert = "Select * from DonorCollection";

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
                         DonorCollection m = new DonorCollection();


                         m.ID = dr["ID"] == System.DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                         m.DonorName = dr["DonorName"] == System.DBNull.Value ? null : Convert.ToString(dr["DonorName"]);
                         m.CollectionDate = dr["CollectionDate"] == System.DBNull.Value ? new DateTime() : Convert.ToDateTime(dr["CollectionDate"]);
                         m.CollectionFee = dr["CollectionFee"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["CollectionFee"]);
                         m.ReciptNo = dr["ReciptNo"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["ReciptNo"]);
                         m.DonationType = dr["DonationType"] == System.DBNull.Value ? null : Convert.ToString(dr["DonationType"]);
                         m.Others = dr["Other"] == System.DBNull.Value ? null : Convert.ToString(dr["Other"]);
                         m.CheckDetail = dr["CheckDetail"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["CheckDetail"]);
                         Donorcollc.Add(m);

                     }
                     dr.Close();

                     tran.Commit();
                     return Donorcollc;
                 }
                 catch (Exception ex)
                 {

                     throw ex;
                 }
             }

             public bool DeleteDonorCollection(DonorCollection mem)
             {
                 try
                 {

                     string delete = "Delete from DonorCollection where ID=" + mem.ID + "";

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

             public DSDonorCollection GetDonorCollectionData(DonorCollection d,string fromdate,string todate,bool All)
             {
                 DSDonorCollection ds = new DSDonorCollection();
                 try
                 {

                     string Donors = "";
                     string all = "";
                     if (All==false)
                     {

                         Donors = "Select * from DonorCollection Where DonorName='" + d.DonorName + "' and CollectionDate>='" + fromdate + "' and CollectionDate<='" + todate + "'";
                     }
                     else if(All==true)
                         all = "Select * from DonorCollection where CollectionDate>='" + fromdate + "' and CollectionDate<='" + todate + "'";


                     
                     con = new OleDbConnection();
                     this.readconfile = new ReadConfigFile();
                     con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                     con.Open();
                     if (con.State == ConnectionState.Open)
                     {
                         string select = "";
                         if (d.DonorName != null && d.DonorName != "")
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
             public DSDonorAndMemberCollection GetDonorAndMemberCollection(Donor d, bool All, bool Donationtype, string fromdate, string todate)
             {
                 DSDonorAndMemberCollection ds = new DSDonorAndMemberCollection();
                 try
                 {



                     string all = "Select DonorName, '' as MemberName,CollectionDate,CollectionFee,ReciptNo,DonationType,Other,CheckDetail"+
                                  " from DonorCollection "+
                                  " union all Select '' as DonorName, MemberName,CollectionDate,CollectionFee,ReciptNo,'' as DonationType, "+
                                  " null as Other, null as CheckDetail from MemberCollection order by ReciptNo desc"; 
                     //where CollectionDate>='" + fromdate +
                                  //" ' and CollectionDate<='" + todate + "'" + " order by ReciptNo desc";


                     string donationtype = "Select DonorName,CollectionDate,CollectionFee,ReciptNo,DonationType,CheckDetail" +
                     " from DonorCollection Where DonationType='" + d.FundType + "'" + " and CollectionDate>='" + fromdate + "' and CollectionDate<='" + todate + "'";
                     string Other = "Select DonorName,CollectionDate,CollectionFee,ReciptNo,DonationType,Other,CheckDetail" +
                     " from DonorCollection Where Len(Other)>0 and CollectionDate>='" + fromdate + "' and CollectionDate<='" + todate + "'";


                     con = new OleDbConnection();
                     this.readconfile = new ReadConfigFile();
                     con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                     con.Open();
                     if (con.State == ConnectionState.Open)
                     {
                         string select = "";

                         if (All == true)
                         {
                             select = all;
                         }
                         else if (Donationtype == true && d.FundType == "Others")
                         {
                             select = Other;
                         }
                         else if (Donationtype == true && d.FundType != "Others")
                         {
                             select = donationtype;
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
             public DSRefrenceCollection GetRefrenceCollection(bool rbDonor, bool rbMember, Donor d, Membership m, string fromdate, string todate)
             {
                 DSRefrenceCollection ds = new DSRefrenceCollection();
                 try
                 {

                     string MyDonorQry = " Select mc.MemberName,'' as DonorName,mc.CollectionFee from MemberCollection mc where mc.MemberName='" + d.DonorName + "'" +
                                        " or mc.MemberName in(select MembershipData.MemberName from MembershipData where" +
                                        " MembershipData.Refrence='" + d.DonorName + "'" + " and CollectionDate>='" + fromdate + "' and CollectionDate<='" + todate + "')" +
                                        " union all" +

                                       " select '' as MemberName,dc.DonorName as DonorName,dc.CollectionFee from DonorCollection dc where dc.DonorName ='" + d.DonorName + "'" +
                                       " or dc.DonorName in(select Donor.Donorname from Donor where" +
                                       " Donor.Refrence='" + d.DonorName + "' and CollectionDate>='" + fromdate + "' and CollectionDate<='" + todate + "')" +
                                        "     union all" +
                                       " Select dc.DonorName as MemberName,'' as DonorName,dc.CollectionFee from DonorCollection dc where" +
                                       " dc.DonorName in(select MembershipData.MemberName from MembershipData where " +
                                        " MembershipData.Refrence='" + d.DonorName + "'  and CollectionDate>='" + fromdate + "' and CollectionDate<='" + todate + "')";
                     String MemberQry = " Select mc.MemberName,'' as DonorName,mc.CollectionFee from MemberCollection mc where mc.MemberName='" +m.MemberName+ "'" +
                                        " or mc.MemberName in(select MembershipData.MemberName from MembershipData where" +
                                        " MembershipData.Refrence='" + m.MemberName+ "'" + " and CollectionDate>='" + fromdate + "' and CollectionDate<='" + todate + "')" +
                                        " union all" +

                                       " select '' as MemberName,dc.DonorName as DonorName,dc.CollectionFee from DonorCollection dc where dc.DonorName ='" + d.DonorName + "'" +
                                       " or dc.DonorName in(select Donor.Donorname from Donor where" +
                                       " Donor.Refrence='" +m.MemberName + "' and CollectionDate>='" + fromdate + "' and CollectionDate<='" + todate + "')" +
                                        "     union all" +
                                       " Select dc.DonorName as MemberName,'' as DonorName,dc.CollectionFee from DonorCollection dc where" +
                                       " dc.DonorName in(select MembershipData.MemberName from MembershipData where " +
                                        " MembershipData.Refrence='" + m.MemberName + "'  and CollectionDate>='" + fromdate + "' and CollectionDate<='" + todate + "')";

                     con = new OleDbConnection();
                     this.readconfile = new ReadConfigFile();
                     con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                     con.Open();
                     if (con.State == ConnectionState.Open)
                     {
                         string select = "";
                         if (rbDonor == true)

                             select = MyDonorQry;
                         else
                             select = MemberQry;
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
