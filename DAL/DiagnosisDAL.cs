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
    public class DiagnosisDAL
    {

        List<Diagnosis> LoDiagnosis;

      //List<Committe> LoCommitte;
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private OleDbDataReader dr;
        private ReadConfigFile readconfile;
        private OleDbTransaction tran;
       // List<Diagnosis> LoDiagnosis;
        public bool SaveDiagnosis(Diagnosis c)
        {
            try
            {
                string insert;

                if (c.Code == 0)
                {
                    insert = " Insert into Diagnosis  (Name,Type) values ('" + c.Name + "','"+Convert.ToInt32(c.DiagnosisType)+"')";
                }
                else
                    insert = "Update Diagnosis set Name='" + c.Name + "',Type='" + Convert.ToInt32(c.DiagnosisType) + "' where Code=" + c.Code + "";
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

        public List<Diagnosis> GetDiagnosis()
        {
            LoDiagnosis = new List<Diagnosis>();
            try
            {
                string Get = " Select * from Diagnosis ";
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
                    Diagnosis c = new Diagnosis();
                    c.Code = Convert.ToInt32(dr["Code"]);
                    c.Name = dr["Name"].ToString();
                    c.DiagnosisType = dr["Type"] == DBNull.Value ? DiagnosisType.Differential : (DiagnosisType)Convert.ToInt32(dr["Type"]);
                    LoDiagnosis.Add(c);
                }
                dr.Close();
                tran.Commit();
                return LoDiagnosis;
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

        public bool DeleteDiagnosis(Diagnosis c)
        {
            try
            {

                string delete = "Delete from Diagnosis where Code=" + c.Code + "";

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
