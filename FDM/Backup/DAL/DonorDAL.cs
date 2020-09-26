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
                       + d.DonorFee + "'," + d.CollectionDate + ",'" + d.Adress + "','" + d.branch.BranchName + "',"
                       + "" + d.DonorNo + ",'" + d.Status + "','" + d.FundType + "','"+d.City.CityName+"',#"+d.CurrentDate+"# )";

                else

                    insert = "Update Donor set DonorName='" + d.DonorName + "',DonorLastName='" + d.DonorLastName + "',Age=" + d.AGE + ""
                        + ", Gender= '" + d.Gender + "',NIC= '" + d.NIC + "',Refrence='" + d.Refrence + "',Phone='" + d.Phone + "',Email='" + d.Email + "',"
                        + " Bloodgroup= '" + d.BloodGroup + "',DonorFee='" + d.DonorFee + "' ,CollectionDate= " + d.CollectionDate + ",Adress= '" + d.Adress + "',BranchName= '" + d.branch.BranchName + "',"
                + " DonorNo=" + d.DonorNo + " ,Status='" + d.Status + "' ,FundType= '" + d.FundType + "',City= '" + d.City.CityName + "',CurrentDate=#" + d.CurrentDate + "# where MID=" + d.MID + "";


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
                    m.CollectionDate = dr["CollectionDate"] == System.DBNull.Value ? 0 : Convert.ToDecimal(dr["CollectionDate"]);
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

        public DSDonor GetData(Donor d, bool Branches, bool Cities, bool All)
        {
            DSDonor ds = new DSDonor();
            try
            {


                string branches = "Select * from Donor Where BranchName='" + d.branch.BranchName + "'";


                string all = "Select * from Donor";


                string cities = "Select * from Donor Where City='" + d.City.CityName + "'";

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
