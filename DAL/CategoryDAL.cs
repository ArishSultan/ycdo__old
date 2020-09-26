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
  public   class CategoryDAL
    {

      List<Category> citis;


        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private OleDbDataReader dr;
        private ReadConfigFile readconfile;
        private OleDbTransaction tran;

        public bool SaveCategory(Category c)
        {
            try
            {
                string insert;

                if (c.CategoryID == 0)
                {
                    insert = " Insert into Category (CategoryName) values ('" + c.CategoryName + "')";
                }
                else
                    insert = "Update Category set CategoryName='" + c.CategoryName + "' where CategoryID=" + c.CategoryID+ "";
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

        public List<Category> GetCategory()
        {
            citis=new List<Category>();
            try
            {
                string Get = " Select * from Category ";
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
                    Category c = new Category();
                    c.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                    c.CategoryName = dr["CategoryName"].ToString();
                    citis.Add(c);
                }
                dr.Close();
                tran.Commit();
                return citis;
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

        public bool DeleteCategory(Category c)
        {
            try
            {

                string delete = "Delete from Category where CategoryID="+c.CategoryID+"";

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
