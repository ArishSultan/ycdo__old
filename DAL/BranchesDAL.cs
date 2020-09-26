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
   public  class BranchesDAL
    {
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbDataReader dr;
        private OleDbTransaction tran;

        List<Branch> branch;


        public bool SaveBranches(Branch br)
        {
            try
            {
                
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                
                string insert;
                if (br.BranchID == 0)
                {
                    //  New Field IsActive to get Current Branch Name & Address
                    //insert = @"Insert Into Branches(BranchCode,BranchName,Phone,Adress,City) 
                    //        values (" + br.BranchCode + ",'" + br.BranchName + "'," + br.Phone + ",'" + br.BranchAdress + "','" + br.City.CityName + "')";
                    insert = @"Insert Into Branches(BranchCode,BranchName,Phone,Adress,City,IsActive) 
                            values (" + br.BranchCode + ",'" + br.BranchName + "'," + br.Phone + ",'" + br.BranchAdress + "','" + br.City.CityName + "'," + Convert.ToInt16(br.IsActive) + ")";
                }
                else
                {

                    //insert = @"Update Branches set BranchCode=" + br.BranchCode + ",BranchName='" + br.BranchName + "', "
                    //    + " Phone=" + br.Phone + ",Adress='" + br.BranchAdress + "',City='" + br.City.CityName + "' where ID=" + br.BranchID + "";
                    insert = @"Update Branches set BranchCode=" + br.BranchCode + ",BranchName='" + br.BranchName + "', "
                        + " Phone=" + br.Phone + ",Adress='" + br.BranchAdress + "',City='" + br.City.CityName + "', IsActive=" + Convert.ToInt16(br.IsActive) + " where ID=" + br.BranchID + "";
                }
               // string insert = @"if exist (select * from Branches where BranchCode='" + vid + "')Begin "
               //+ " Update Branches set BranchCode='" + br.BranchCode + "',BranchName='"+br.BranchName+"', "
               // + " Phone='" + br.Phone + "',Adress='" + br.BranchAdress + "',City='"+br.City+"'"
               // + " end else Begin  Insert Into Branches(BranchCode,BranchName,Phone,Adress,City) "
               // +"  values ('" + br.BranchCode + "','" + br.BranchName + "','" + br.Phone+ "','" + br.BranchAdress+ "','"+br.City+"')";
               
                    
                
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

        public List<Branch> GetBranchData()
        {
            try
            {
                
                branch = new List<Branch>();
                 string insert ="Select * from Branches";
                    
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand(insert, con);
                cmd.Transaction = tran;
                dr=cmd.ExecuteReader();
                while (dr.Read())
                {
                   
                    Branch br =new Branch();
                    br.BranchID = Convert.ToInt32(dr["ID"]);
                    br.BranchCode = Convert.ToInt32(dr["BranchCode"]);
                    br.BranchName = dr["BranchName"].ToString();
                    br.Phone = Convert.ToInt32(dr["Phone"]);
                    br.BranchAdress = dr["Adress"].ToString();
                    br.City.CityName = dr["City"] == System.DBNull.Value ? null : Convert.ToString(dr["City"]);
                   // c = new City(dr["City"]==System.DBNull.Value ?null:Convert.ToString(dr["CityName"]));
                    br.IsActive = Convert.ToBoolean(dr["IsActive"]);
                   
                 //   br = new Branch(Convert.ToInt32(dr["ID"]), Convert.ToInt32(dr["BranchCode"]), (string)dr["BranchName"], Convert.ToInt32(dr["Phone"]), (string)dr["Adress"],c);
                    branch.Add(br);
                }
                dr.Close();

                tran.Commit();
                return branch;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        
        
        }

        public bool DeleteBranch(Branch br)
        {
            try
            {

                string delete = "Delete from Branches where ID=" + br.BranchID + "";

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


        public DSBranches GetData(Branch br)
        {
           // DSBranch ds = new DSBranch();
            DSBranches ds = new DSBranches();
            try
            {
                string select;
                if (br.City.CityName != "")
                {
                    select = "Select * from Branches Where City='" + br.City.CityName + "'";
                }
                else
                    select = "Select * from Branches ";
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
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
