using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Common;
using System.Data.OleDb;
using System.Data;
using OleDbHelper;
namespace DAL
{
    public class PatientDAL
    {
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbDataReader dr;
        private OleDbTransaction tran;
        List<PatientCategory> Pcs;

        public bool PatientChecked(PatientRegistration pr)
        { 
         try
            {

                string update = "Update PatientRegistration set Checked = " + true + " where TokenMonthYear="
                    + pr.TokenMonthYear + " and TokenNumber=" + pr.TokenNumber; 
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand(update, con);
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            { con.Close(); }
        }
        public PatientRegistration GetPatientDetail(long tokenNumber,Room r)
        {
            PatientRegistration pr = new PatientRegistration();
            try
            {
                string select = "select * from patientregistration where TokenMonthYear=" + System.DateTime.Today.Month.ToString()
                + System.DateTime.Today.Year.ToString() + " and TokenNumber=" + tokenNumber + " and Room='"
                + r.Name + "'";
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                cmd = new OleDbCommand();
                cmd.CommandText = select;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pr.Patient.FirstName = (string)dr["PatientFirstName"];
                    pr.Patient.LastName = (string)dr["PatientLastName"];
                    pr.Patient.NIC = (string)dr["PatientNIC"];
                    pr.Patient.RegistrationDate = Convert.ToDateTime(dr["PatientRegistrationDate"]);
                    pr.Patient.RegistrationNumber = (string)dr["PatientRegistrationNumber"];
                    pr.Patient.Address = (string)dr["PatientAddress"];
                    pr.CashReceived = Convert.ToDouble(dr["TokenAmount"]);
                    pr.TokenType = (TokenType)Convert.ToInt32(dr["TokenAmount"]);
                    pr.Room.Name = (string)dr["Room"];
                    pr.TokenDate = Convert.ToDateTime(dr["TokenDate"]);
                    pr.TokenMonthYear = Convert.ToInt64(dr["TokenMonthYear"]);
                    pr.TokenNumber = Convert.ToInt64(dr["TokenNumber"]);
                }
                dr.Close();
                return pr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { con.Close(); }
            
        }
        public int GetNextTokenNumber(Room r)
        {
            PatientRegistration pr = new PatientRegistration();
            try
            {
                string select = "select min(tokenNumber) from patientregistration where TokenMonthYear=" 
                    + System.DateTime.Today.Month.ToString() + System.DateTime.Today.Year.ToString()
                    + " and Room='" + r.Name + "' and Checked=" + false;
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                cmd = new OleDbCommand(select, con);
                if (DBNull.Value != (cmd.ExecuteScalar()))
                {
                    int NextTokenNumber=Convert.ToInt32(cmd.ExecuteScalar());
                    return NextTokenNumber;
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetNextTokenNumber()
        {
            try
            {
                string select = "select max(tokenNumber) from patientregistration where TokenMonthYear=" + Convert.ToInt64(DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString()); 
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                cmd = new OleDbCommand(select, con);
                object obj = cmd.ExecuteScalar();
                if(DBNull.Value != obj)
                {
                    return Convert.ToInt32(obj) + 1;
                }
                else
                    return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        public bool SavePatientToken(PatientRegistration pr)
        {
            try
            {

                string insert = "Insert Into PatientRegistration(TokenDate,TokenMonthYear,TokenNumber,PatientFirstName,PatientLastName"
                    + ",PatientNIC,PatientAddress,PatientType,TokenAmount,Room,PatientRegistrationNumber,PatientRegistrationDate) " 
                    + "values (#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + ",'" + pr.Patient.FirstName + "','" + pr.Patient.LastName + "','" 
                    + pr.Patient.NIC + "','" + pr.Patient.Address + "','" + pr.TokenType.ToString() + "'," + (int) pr.TokenType + ",'" 
                    + pr.Room.Name +  "','" + pr.Patient.RegistrationNumber  + "',#" + pr.Patient.RegistrationDate  + "#)";
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
                tran.Rollback();
                throw ex;
            }
            finally
            { con.Close(); }
        }
        public bool DeletePatientCategory(PatientCategory  Pc)
        {
            try
            {
                
                string delete = "Delete From PatientCategories where PatientCategoryID=" + Pc.CategoryID;
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
                tran.Rollback();
                throw ex;
            }
            finally
            { con.Close(); }
        }

        public List<PatientCategory> GetPatientCategories()
        {
            if (Pcs == null) Pcs = new List<PatientCategory>();
            try
            {
                string select = "Select * from PatientCategories";

                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                cmd = new OleDbCommand(select, con);

                dr = cmd.ExecuteReader();


                //Add Pateint Categories to Collection
                AddPatientCategories();

                con.Close();
                return Pcs;
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

        public void AddPatientCategories()
        {
            try
            {
                PatientCategory  newPc;

                while (dr.Read())
                {
                    newPc = new PatientCategory(Convert.ToInt32(dr["PatientCategoryID"]), (string)dr["PatientCategoryName"], Convert.ToDouble(dr["DiscountPercentage"]));
                    Pcs.Add(newPc);
                }
                dr.Close();
                con.Close();
            }

            catch (Exception ex) { throw ex; }

            finally { dr.Close(); }

        }

        public bool SavePatientCategory(PatientCategory pc) 
        {
            try
            {
                int VID = 0;
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                if (pc.CategoryID == 0)
                {
                    cmd = new OleDbCommand("Select IsNull(Max(PatientCategoryID),0) +1 From PatientCategories", con);
                    cmd.Transaction = tran;
                    VID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                else
                {
                    VID = pc.CategoryID;
                }
                string insert = "if exists(select * from PatientCategories where PatientCategoryID=" + VID + ")Begin Update PatientCategories set PatientCategoryName='" + pc.CategoryName + "',DiscountPercentage=" + pc.DiscountPercentage + " where PatientCategoryID=" + VID + " End Else Begin Insert into PatientCategories(PatientCategoryName,DiscountPercentage) Values(" + "'" + pc.CategoryName + "\'," + pc.DiscountPercentage + " )End";
                cmd = new OleDbCommand(insert, con);
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            { con.Close(); }
            return true;
        }
    }
}
