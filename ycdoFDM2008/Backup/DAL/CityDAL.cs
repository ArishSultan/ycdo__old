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
  public   class CityDAL
    {

      List<City> citis;


        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private OleDbDataReader dr;
        private ReadConfigFile readconfile;
        private OleDbTransaction tran;

        public bool SaveCity(City c)
        {
            try
            {
                string insert;

                if (c.CityID == 0)
                {
                    insert = " Insert into Cities (CityName) values ('" + c.CityName + "')";
                }
                else
                    insert = "Update Cities set CityName='" + c.CityName + "' where CityID=" + c.CityID+ "";
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

        public List<City> GetCity()
        {
            citis=new List<City>();
            try
            {
                string Get = " Select * from Cities ";
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
                    City c = new City();
                    c.CityID = Convert.ToInt32(dr["CityID"]);
                    c.CityName = dr["CityName"].ToString();
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

        public bool DeleteCity(City c)
        {
            try
            {

                string delete = "Delete from Cities where CityID="+c.CityID+"";

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
