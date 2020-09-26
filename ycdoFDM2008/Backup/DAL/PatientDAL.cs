using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Common;
using System.Data.OleDb;
using System.Data;
using OleDbHelper;
using System.Threading;
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
        public bool SaveLabTestRemarks(PatientRegistration pr, LabTestRemarks Remarks)
        {
            try
            {
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.Transaction = tran;
                cmd.CommandText = "Update LabTestPerformed set Remarks='"+ Remarks.Remarks  +"',TestPerformed = " + Remarks.IsTestPerformed + " where TokenNumber=" + pr.TokenNumber + " and TokenDate=#" + pr.TokenDate.ToShortDateString() + "# and TokenMonthYear=" + pr.TokenMonthYear + " and LabTestID=" + Remarks.LabTest.LabTestId  ;
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
        public bool LabTestAssignedPaid(InjectionLabTest pr, List<LabTest> labs)
        {
            try
            {

                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.Transaction = tran;
                foreach (LabTest lab in labs)
                {
                    cmd.CommandText = "insert into LabTestPerformed (TokenDate,TokenMonthYear,TokenNumber,LabTestID,TestPerformed,TestPaid) values(#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + "," + lab.LabTestId + "," + false + ","+true+")";
                    cmd.ExecuteNonQuery();
                }

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
        public bool LabTestAssigned(PatientRegistration pr, List<LabTest> labs)
        {
            try
            {

                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.Transaction = tran;
                foreach (LabTest lab in labs)
                {
                    cmd.CommandText = "insert into LabTestPerformed (TokenDate,TokenMonthYear,TokenNumber,LabTestID,TestPerformed) values(#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + "," + lab.LabTestId + "," + false + ")";
                    cmd.ExecuteNonQuery();
                }

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
        public bool LabTestCanceled(PatientRegistration pr, LabTest medicine)
        {
            try
            {
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                string delete = "delete from LabTestPerformed where TokenDate=#" + pr.TokenDate + "# and TokenMonthYear=" + pr.TokenMonthYear + " and TokenNumber=" + pr.TokenNumber + " and LabTestID=" + medicine.LabTestId;
                cmd = new OleDbCommand(delete, con);
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into LabTestPerformed_Canceled(TokenDate,TokenMonthYear,TokenNumber,LabTestID,TestCanceled) values(#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + "," + medicine.LabTestId + ",true)";
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
        public bool MedicineCanceled(PatientRegistration pr, LabTest medicine)
        {
            try
            {
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                //string delete = "delete from MedicineIssued where TokenDate=#" + pr.TokenDate + "# and TokenMonthYear=" + pr.TokenMonthYear + " and TokenNumber=" + pr.TokenNumber + " and ID=" + medicine.MedicineIssuedSerialID ;
                //cmd = new OleDbCommand(delete, con);
                //cmd.Transaction = tran;
                //cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into MedicineIssued_Canceled(TokenDate,TokenMonthYear,TokenNumber,MedicineID,DosePerDay,MedicineCanceled) values(#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + "," + medicine.LabTestId + "," + medicine.TimesADay + ",true)";
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
        #region Faheem Work
        public bool PatientChecked(PatientRegistration pr, List<LabTest> medicines)
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
                foreach (LabTest med in medicines)
                {
                    cmd.CommandText = "insert into MedicineIssued (TokenDate,TokenMonthYear,TokenNumber,MedicineID,DosePerDay) values(#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + "," + med.LabTestId + "," + med.TimesADay + ")";
                    cmd.ExecuteNonQuery();
                }

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
        #endregion
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
        List<PatientRegistration> roomPatients = new List<PatientRegistration>();
        public List<PatientRegistration> GetPatientLabTestDetail()
        {

            try
            {
                string select = "select distinct TokenNumber,TokenDate,TokenMonthYear from LabTestPerformed ltp where TestPaid=true and TestPerformed = false";
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
                    PatientRegistration pr = new PatientRegistration();
                    pr.TokenDate = Convert.ToDateTime(dr["TokenDate"]);
                    pr.TokenMonthYear = Convert.ToInt64(dr["TokenMonthYear"]);
                    pr.TokenNumber = Convert.ToInt64(dr["TokenNumber"]);
                    roomPatients.Add(pr);
                }
                dr.Close();
                return roomPatients;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { con.Close(); }

        }
        public List<PatientRegistration> GetPatientDetails()
        {
            
            try
            {
                string select = "select * from patientregistration where TokenMonthYear=" + System.DateTime.Today.Month.ToString()
                + System.DateTime.Today.Year.ToString() + " and Checked=" + false + "";
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
                    PatientRegistration pr = new PatientRegistration();
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
                    roomPatients.Add(pr);
                }
                dr.Close();
                return roomPatients;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { con.Close(); }

        }
        public PatientRegistration GetPatientDetail(long tokenNumber)
        {
            PatientRegistration pr = new PatientRegistration();
            try
            {
                string select = "select * from patientregistration where TokenMonthYear=" + System.DateTime.Today.Month.ToString()
                + System.DateTime.Today.Year.ToString() + " and TokenNumber=" + tokenNumber;
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

                con = new OleDbConnection();
                 this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
       
                tran = con.BeginTransaction();
                int VID = 0;
                cmd = new OleDbCommand("Select Max(tokennumber) From patientregistration where TokenMonthYear=" + pr.TokenMonthYear + "", con);
                cmd.Transaction = tran;

                if (DBNull.Value != (cmd.ExecuteScalar()))
                {
                    VID = Convert.ToInt32(cmd.ExecuteScalar());
                    pr.TokenNumber = VID + 1;
                }
                else
                    pr.TokenNumber = 1;

               
                string insert = "Insert Into PatientRegistration(TokenDate,TokenMonthYear,TokenNumber,PatientFirstName,PatientLastName"
                    + ",PatientNIC,PatientAddress,PatientType,TokenAmount,Room,PatientRegistrationNumber,PatientRegistrationDate) " 
                    + "values (#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + ",'" + pr.Patient.FirstName + "','" + pr.Patient.LastName + "','" 
                    + pr.Patient.NIC + "','" + pr.Patient.Address + "','" + pr.TokenType.ToString() + "'," + (int) pr.TokenType + ",'"
                    + pr.Room.Name + "','" + pr.Patient.RegistrationNumber + "',#" + pr.Patient.RegistrationDate + "# )";
             
               
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

        public List<Patient> GetPatientData()
        {
            Patient pr = new Patient();
            try
            {
                List<Patient> preg = new List<Patient>();
                string select = "select * from patientRegistration ";
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
                    pr = new Patient();
                    pr.FirstName = dr["PatientFirstName"] == System.DBNull.Value ? "" : Convert.ToString(dr["PatientFirstName"]);
                    pr.LastName = dr["PatientLastName"] == System.DBNull.Value ? "" : Convert.ToString(dr["PatientLastName"]);
                    pr.NIC = dr["PatientNIC"] == System.DBNull.Value ? "" : Convert.ToString(dr["PatientNIC"]);
                    pr.RegistrationDate = dr["PatientRegistrationDate"] == System.DBNull.Value ? new DateTime() : Convert.ToDateTime(dr["PatientRegistrationDate"]);
                    pr.RegistrationNumber = dr["PatientRegistrationNumber"] == System.DBNull.Value ? "" : Convert.ToString(dr["PatientRegistrationNumber"]);
                    pr.Address = dr["PatientAddress"] == System.DBNull.Value ? "" : Convert.ToString(dr["PatientAddress"]);
                    pr.PatientType = dr["PatientType"] == System.DBNull.Value ? "" : Convert.ToString(dr["PatientType"]);
                    //pr.CashReceived =dr["TokenAmount"]==System.DBNull.Value?0: Convert.ToDouble(dr["TokenAmount"]);
                    //pr.TokenType = dr["TokenAmount"]==System.DBNull.Value? 0 : (TokenType)Convert.ToInt32(dr["TokenAmount"]);
                    //pr.Room.Name = dr["Room"] == System.DBNull.Value ? "" : Convert.ToString(dr["Room"]);
                    //pr.TokenDate = dr["TokenDate"] == System.DBNull.Value ? new DateTime() : Convert.ToDateTime(dr["TokenDate"]);
                    //pr.TokenMonthYear = dr["TokenMonthYear"] == System.DBNull.Value ? 0 : Convert.ToInt64(dr["TokenMonthYear"]);
                    //pr.TokenNumber = dr["TokenNumber"]==System.DBNull.Value?0: Convert.ToInt64(dr["TokenNumber"]);
                    preg.Add(pr);
                }
                dr.Close();
                return preg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { con.Close(); }

        }
        public List<PatientRegistration> GetAllPatientNotChecked()
        {
            List<LabTest> labTests = new List<LabTest>();
            List<PatientRegistration> prs = new List<PatientRegistration>();
            try
            {
                string select = "SELECT Distinct TokenDate,TokenMonthYear,TokenNumber from PatientRegistration where Checked=No ";
                DataTable dt = new DataTable();
                con = new OleDbConnection();
                readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    da = new OleDbDataAdapter(select, con);
                    da.Fill(dt);

                }

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        PatientRegistration pr = new PatientRegistration();

                        pr.TokenNumber = Convert.ToInt64(row["TokenNumber"] == DBNull.Value ? 0 : row["TokenNumber"]);
                        pr.TokenMonthYear = Convert.ToInt64(row["TokenMonthYear"] == DBNull.Value ? 0 : row["TokenMonthYear"]);
                        pr.TokenDate = Convert.ToDateTime(row["TokenDate"] == DBNull.Value ? DateTime.MinValue : row["TokenDate"]);

                        prs.Add(pr);

                    }
                }

                return prs;
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
        //public List<PatientRegistration> GetAllPatientsNotChecked(Room r)
        //{

        //    try
        //    {
        //        string select = "select * from patientregistration where TokenMonthYear=" + System.DateTime.Today.Month.ToString()
        //        + System.DateTime.Today.Year.ToString() + " and Checked=" + false + " and Room='" + r.Name + "'";
        //        con = new OleDbConnection();
        //        this.readconfile = new ReadConfigFile();
        //        con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
        //        con.Open();
        //        cmd = new OleDbCommand();
        //        cmd.CommandText = select;
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = con;
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            PatientRegistration pr = new PatientRegistration();
        //            pr.Patient.FirstName = (string)dr["PatientFirstName"];
        //            pr.Patient.LastName = (string)dr["PatientLastName"];
        //            pr.Patient.NIC = (string)dr["PatientNIC"];
        //            pr.Patient.RegistrationDate = Convert.ToDateTime(dr["PatientRegistrationDate"]);
        //            pr.Patient.RegistrationNumber = (string)dr["PatientRegistrationNumber"];
        //            pr.Patient.Address = (string)dr["PatientAddress"];
        //            pr.CashReceived = Convert.ToDouble(dr["TokenAmount"]);
        //            pr.TokenType = (TokenType)Convert.ToInt32(dr["TokenAmount"]);
        //            pr.Room.Name = (string)dr["Room"];
        //            pr.TokenDate = Convert.ToDateTime(dr["TokenDate"]);
        //            pr.TokenMonthYear = Convert.ToInt64(dr["TokenMonthYear"]);
        //            pr.TokenNumber = Convert.ToInt64(dr["TokenNumber"]);
        //            roomPatients.Add(pr);
        //        }
        //        dr.Close();
        //        return roomPatients;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally { con.Close(); }

        //}
    }
}
