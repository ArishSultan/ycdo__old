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
    public class PatientAdmissionDAL
    {

        List<PatientAdmission> PatientAdmissions;


        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private OleDbDataReader dr;
        private ReadConfigFile readconfile;
        private OleDbTransaction tran;


        public bool SavePatientAdmission(PatientAdmission pa)
        {
            try
            {
                string insert;

                
                    insert = "INSERT INTO   PatientAdmission(PatientRegistrationNumber, DiffDiag, ProvDiag,  AdmissionDateTime, Status, Pluse, Temp, BPsys, BPdia, RR) " +
                            " VALUES        ('"+pa.PatientRegistration.PatientRegistrationNumber+"','"+pa.DiffDiag+"','"+pa.provDiag+"','"+DateTime.Now+"','"+0+"','"+pa.Pluse+"','"+pa.Temp+"','"+pa.BPsys+"','"+pa.BPdia+"','"+pa.RR+"')";
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

        public List<PatientAdmission> GetPatientAdmissionAdmit()
        {
            PatientAdmissions = new List<PatientAdmission>();
            try
            {
                string Get = " Select * from PatientAdmission where status=0 ";
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
                    PatientAdmission c = new PatientAdmission();
                   // c. = Convert.ToInt32(dr["CityID"]);
                    c.PatientRegistration.Patient.RegistrationNumber = dr["PatientRegistrationNumber"].ToString();
                    c.PatientRegistration.Patient = new PatientDAL().GetPatientByNo(c.PatientRegistration.Patient.RegistrationNumber);      
                    c.DiffDiag= dr["DiffDiag"].ToString();
                            c.provDiag= dr["ProvDiag"].ToString();
                            c.AdmissoinDate = dr["AdmissionDateTime"] == DBNull.Value ? DateTime.Now.Date : Convert.ToDateTime(dr["AdmissionDateTime"]);                          
                            c.Pluse = Convert.ToInt32(dr["Pluse"]);
                            c.Temp = Convert.ToInt32(dr["Temp"]);
                            c.BPsys = Convert.ToInt32(dr["BPsys"]);
                           c.BPdia = Convert.ToInt32(dr["BPdia"]);
                            c.RR = dr["RR"].ToString();
                  //  c.CityName = dr["CityName"].ToString();
                    PatientAdmissions.Add(c);
                }
                dr.Close();
                tran.Commit();
                

                return PatientAdmissions;
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

        public bool DeletePatientAdmission(PatientAdmission c)
        {
            try
            {

                string delete = "Delete from PatientAdmission where PatientRegistrationNumber=" + c.PatientRegistration.PatientRegistrationNumber + "";

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
