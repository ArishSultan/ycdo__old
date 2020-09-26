using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Datasets;
using Common;
using System.Data.OleDb;
using System.Data;
using OleDbHelper;

namespace DAL
{
   public  class InjectionLabTestDAL
    {


        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbDataReader dr;
        private OleDbTransaction tran;
        List<PatientCategory> Pcs;

       public int GetNextTokenNumber()
       {
           try
           {
               string select = "select max(tokenNumber) from InjectionLabTest where TokenMonthYear=" + System.DateTime.Today.Month.ToString() + System.DateTime.Today.Year.ToString();
               con = new OleDbConnection();
               this.readconfile = new ReadConfigFile();
               con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
               con.Open();
               cmd = new OleDbCommand(select, con);
               if (DBNull.Value != (cmd.ExecuteScalar()))
               {
                   return Convert.ToInt32(cmd.ExecuteScalar()) + 1;
               }

               else
                   return 1;
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
       public bool UpdateLabTestToken(InjectionLabTest inLb)
       {
           try
           {


               con = new OleDbConnection();
               this.readconfile = new ReadConfigFile();
               con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
               con.Open();
               string update = "";
               tran = con.BeginTransaction();
               cmd = new OleDbCommand(update, con);
               cmd.Transaction = tran;

               if (inLb.IsInjectionToken == false)
               {
                   update = "update injectionlabtest set TokenAmount=" + inLb.CashReceived + " where TokenNumber=" + inLb.TokenNumber + " and LabTestId = " + inLb.Tests[0].LabTestId   ;
                   cmd.CommandText = update;
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
       public bool SavePatientTokenInjandLabTest(InjectionLabTest pr)
       {
           try
           {


               con = new OleDbConnection();
               this.readconfile = new ReadConfigFile();
               con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
               con.Open();
               string insert = "";
               tran = con.BeginTransaction();
               cmd = new OleDbCommand(insert, con);
               cmd.Transaction = tran;

               if (pr.Injections.Count > 0)
               {
                   foreach (LabTest item in pr.Injections)
                   {
                       insert = "Insert Into InjectionLabTest(TokenDate,TokenMonthYear,TokenNumber,PatientFirstName,PatientLastName"
                    + ",PatientNIC,PatientAddress,TokenAmount,PatientRegistrationNumber,PatientRegistrationDate,ExistingTokenID,InjectionId) "
                    + "values (#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + ",'" + pr.Patient.FirstName + "','" + pr.Patient.LastName + "','"
                    + pr.Patient.NIC + "','" + pr.Patient.Address + "'," + (decimal)item.GetLineTotal() + ",'"
                    + pr.Patient.RegistrationNumber + "',#" + pr.Patient.RegistrationDate + "#,'" + pr.ExistingTokenNo + "'," + item.LabTestId  + ")";
                       cmd.CommandText = insert;
                       cmd.ExecuteNonQuery();
                   }
               }

               if(pr.Tests.Count > 0)
               {
                   foreach (LabTest item in pr.Tests)
                   {
                       insert = "Insert Into InjectionLabTest(TokenDate,TokenMonthYear,TokenNumber,PatientFirstName,PatientLastName"
                                       + ",PatientNIC,PatientAddress,TokenAmount,PatientRegistrationNumber,PatientRegistrationDate,LabTestId,PatientPayType,ExistingTokenID,DosePerDay,Days) "
                                       + "values (#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + ",'" + pr.Patient.FirstName + "','" + pr.Patient.LastName + "','"
                                       + pr.Patient.NIC + "','" + pr.Patient.Address + "'," + (decimal)item.GetLineTotal() + ",'"
                                       + pr.Patient.RegistrationNumber + "',#" + pr.Patient.RegistrationDate + "#," + item.LabTestId + ",'" + pr.Type.ToString() + "','" + pr.ExistingTokenNo + "'," + item.TimesADay + "," + item.TotalDays + ")";
                       cmd.CommandText = insert;
                       cmd.ExecuteNonQuery();
                   }
               }
               if (pr.AssignedLabTest.Count > 0)
               {
                   foreach (LabTest item in pr.AssignedLabTest)
                   {
                       insert = "Insert Into InjectionLabTest(TokenDate,TokenMonthYear,TokenNumber,PatientFirstName,PatientLastName"
                                       + ",PatientNIC,PatientAddress,TokenAmount,PatientRegistrationNumber,PatientRegistrationDate,LabTestId,PatientPayType,ExistingTokenID,DosePerDay,Days) "
                                       + "values (#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + ",'" + pr.Patient.FirstName + "','" + pr.Patient.LastName + "','"
                                       + pr.Patient.NIC + "','" + pr.Patient.Address + "'," + (decimal)item.GetLineTotal() + ",'"
                                       + pr.Patient.RegistrationNumber + "',#" + pr.Patient.RegistrationDate + "#," + item.LabTestId + ",'" + pr.Type.ToString() + "','" + pr.ExistingTokenNo + "'," + item.TimesADay + "," + item.TotalDays + ")";
                       cmd.CommandText = insert;
                       cmd.ExecuteNonQuery();
                   }
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
       public bool SavePatientToken(InjectionLabTest  pr)
       {
           try
           {


               con = new OleDbConnection();
               this.readconfile = new ReadConfigFile();
               con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
               con.Open();
               string insert = "";
               tran = con.BeginTransaction();
               cmd = new OleDbCommand(insert, con);
               cmd.Transaction = tran;

               if (pr.IsInjectionToken == true)
               {
                   foreach (LabTest item in pr.Injections)
                   {
                       insert = "Insert Into InjectionLabTest(TokenDate,TokenMonthYear,TokenNumber,PatientFirstName,PatientLastName"
                    + ",PatientNIC,PatientAddress,TokenAmount,PatientRegistrationNumber,PatientRegistrationDate,ExistingTokenID,InjectionId,SecondTurn) "
                    + "values (#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + ",'" + pr.Patient.FirstName + "','" + pr.Patient.LastName + "','"
                    + pr.Patient.NIC + "','" + pr.Patient.Address + "'," + (int)item.CurrentAmount + ",'"
                    + pr.Patient.RegistrationNumber + "',#" + pr.Patient.RegistrationDate + "#,'" + pr.ExistingTokenNo + "'," + item.LabTestId  + ",true)";
                       cmd.CommandText = insert;
                       cmd.ExecuteNonQuery();    
                   }
                   
               }
               else
               {
                   foreach (LabTest item in pr.Tests)
                   {
                       insert = "Insert Into InjectionLabTest(TokenDate,TokenMonthYear,TokenNumber,PatientFirstName,PatientLastName"
                                       + ",PatientNIC,PatientAddress,TokenAmount,PatientRegistrationNumber,PatientRegistrationDate,LabTestId,PatientPayType,ExistingTokenID,DosePerDay,Days,SecondTurn) "
                                       + "values (#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + ",'" + pr.Patient.FirstName + "','" + pr.Patient.LastName + "','"
                                       + pr.Patient.NIC + "','" + pr.Patient.Address + "'," + (decimal)item.GetLineTotal() + ",'"
                                       + pr.Patient.RegistrationNumber + "',#" + pr.Patient.RegistrationDate + "#," + item.LabTestId + ",'" + pr.Type.ToString() + "','" + pr.ExistingTokenNo + "',"+ item.TimesADay +"," + item.TotalDays   + ",true)";
                       cmd.CommandText = insert;
                       cmd.ExecuteNonQuery();
                   }
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
       public bool SetPaidLabTest(List<LabTest> medicines)
       {
           try
           {


               con = new OleDbConnection();
               this.readconfile = new ReadConfigFile();
               con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
               con.Open();
               tran = con.BeginTransaction();
               cmd = new OleDbCommand("", con);
               cmd.Transaction = tran;

               foreach (LabTest med in medicines)
               {
                   string update = "Update LabTestPerformed set TestPaid = " + true + " where LabTestID=" + med.LabTestId;
                   cmd.CommandText = update;
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
       #region Faheem Work
       public bool SetPharmacyIssued(List<LabTest> medicines)
       {
           try
           {


               con = new OleDbConnection();
               this.readconfile = new ReadConfigFile();
               con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
               con.Open();
               tran = con.BeginTransaction();
               cmd = new OleDbCommand("", con);
               cmd.Transaction = tran;

               foreach (LabTest med in medicines)
               {
                   string update = "Update MedicineIssued set MedicinesIssued = " + true + " where ID=" + med.MedIssuedID;
                   cmd.CommandText = update;
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
       public List<LabTest> GetLabTestAssignedUnPaid(PatientRegistration pr)
       {
           List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "select labtestperformed.*,lt.[Test (A-Z)] as TestName,lt.Generall,lt.Poor,lt.YCDO from labtestperformed ,labtest lt where  lt.ID=labtestperformed.LabTestID and TokenDate=#" + pr.TokenDate.ToShortDateString() + "# and TokenNumber=" + pr.TokenNumber + " and TokenMonthYear=" + pr.TokenMonthYear + " and TestPaid=false";
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
                       LabTest med = new LabTest();
                       med.IsMedicine = true;
                       med.LabTestId = Convert.ToInt32(row["LabTestId"] == DBNull.Value ? 0 : row["LabTestId"]);
                       med.TestName = Convert.ToString(row["TestName"] == DBNull.Value ? string.Empty : row["TestName"]);
                       med.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                       med.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                       med.General = Convert.ToDecimal(row["Generall"] == DBNull.Value ? 0 : row["Generall"]);
                       labTests.Add(med);
                   }
               }

               return labTests;
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
       public List<LabTest> GetLabTestAssignedUnPaid2(PatientRegistration pr)
       {
           List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "select labtestperformed.*,lt.[Test (A-Z)] as TestName,lt.Generall,lt.Poor,lt.YCDO from labtestperformed ,labtest lt where  lt.ID=labtestperformed.LabTestID and TokenNumber=" + pr.TokenNumber + " and TokenMonthYear=" + pr.TokenMonthYear + "";
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
                       LabTest med = new LabTest();
                       med.IsMedicine = true;
                       med.LabTestId = Convert.ToInt32(row["LabTestId"] == DBNull.Value ? 0 : row["LabTestId"]);
                       med.TestName = Convert.ToString(row["TestName"] == DBNull.Value ? string.Empty : row["TestName"]);
                       med.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                       med.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                       med.General = Convert.ToDecimal(row["Generall"] == DBNull.Value ? 0 : row["Generall"]);
                       labTests.Add(med);
                   }
               }

               return labTests;
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
       public List<LabTest> GetLabTestAssignedPerformed(PatientRegistration pr)
       {
           List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "select labtestperformed.*,lt.[Test (A-Z)] as TestName,lt.Generall,lt.Poor,lt.YCDO from labtestperformed ,labtest lt where  lt.ID=labtestperformed.LabTestID and TokenDate=#" + pr.TokenDate.ToShortDateString() + "# and TokenNumber=" + pr.TokenNumber + " and TokenMonthYear=" + pr.TokenMonthYear + " and TestPerform=false";
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
                       LabTest med = new LabTest();
                       med.IsMedicine = true;
                       med.LabTestId = Convert.ToInt32(row["LabTestId"] == DBNull.Value ? 0 : row["LabTestId"]);
                       med.TestName = Convert.ToString(row["TestName"] == DBNull.Value ? string.Empty : row["TestName"]);
                       med.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                       med.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                       med.General = Convert.ToDecimal(row["Generall"] == DBNull.Value ? 0 : row["Generall"]);
                       labTests.Add(med);
                   }
               }

               return labTests;
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
       public List<LabTest> GetLabTestCanceled(PatientRegistration pr)
       {
           List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "select labtestperformed_Canceled.*,lt.[Test (A-Z)] as TestName,lt.Generall,lt.Poor,lt.YCDO from labtestperformed_Canceled ,labtest lt where  lt.ID=labtestperformed_Canceled.LabTestID and TokenDate=#" + pr.TokenDate.ToShortDateString() + "# and TokenNumber=" + pr.TokenNumber + " and TokenMonthYear=" + pr.TokenMonthYear + "";
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
                       LabTest med = new LabTest();
                       med.IsMedicine = true;
                       med.LabTestId = Convert.ToInt32(row["LabTestId"] == DBNull.Value ? 0 : row["LabTestId"]);
                       med.TestName = Convert.ToString(row["TestName"] == DBNull.Value ? string.Empty : row["TestName"]);
                       med.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                       med.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                       med.General = Convert.ToDecimal(row["Generall"] == DBNull.Value ? 0 : row["Generall"]);
                       labTests.Add(med);
                   }
               }

               return labTests;
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
       public List<LabTest> GetLabTestPerformed(PatientRegistration pr)
       {
           List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "select labtestperformed.*,lt.[Test (A-Z)] as TestName,lt.Generall,lt.Poor,lt.YCDO from labtestperformed ,labtest lt where  lt.ID=labtestperformed.LabTestID and TokenDate=#" + pr.TokenDate.ToShortDateString() + "# and TokenNumber=" + pr.TokenNumber + " and TokenMonthYear=" + pr.TokenMonthYear + " and TestPerformed=Yes";
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
                       LabTest med = new LabTest();
                       med.IsMedicine = true;
                       med.LabTestId = Convert.ToInt32(row["LabTestId"] == DBNull.Value ? 0 : row["LabTestId"]);
                       med.TestName = Convert.ToString(row["TestName"] == DBNull.Value ? string.Empty : row["TestName"]) + Environment.NewLine + Convert.ToString(row["Remarks"] == DBNull.Value ? string.Empty : row["Remarks"]);
                       labTests.Add(med);
                   }
               }

               return labTests;
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
       public List<LabTest> GetLabTestAssigned(PatientRegistration pr)
       {
           List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "select labtestperformed.*,lt.[Test (A-Z)] as TestName,lt.Generall,lt.Poor,lt.YCDO from labtestperformed ,labtest lt where  lt.ID=labtestperformed.LabTestID and TokenDate=#" + pr.TokenDate.ToShortDateString() + "# and TokenNumber=" + pr.TokenNumber + " and TokenMonthYear=" + pr.TokenMonthYear + " and TestPerformed=No";
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
                       LabTest med = new LabTest();
                       med.IsMedicine = true;
                       med.LabTestId = Convert.ToInt32(row["LabTestId"] == DBNull.Value ? 0 : row["LabTestId"]);
                       med.TestName = Convert.ToString(row["TestName"] == DBNull.Value ? string.Empty : row["TestName"]);
                       med.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                       med.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                       med.General = Convert.ToDecimal(row["Generall"] == DBNull.Value ? 0 : row["Generall"]);
                       med.IsTestPerformed = Convert.ToBoolean(row["TestPerformed"]);
                       labTests.Add(med);
                   }
               }

               return labTests;
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
       public List<LabTest> GetMedicineIssued(PatientRegistration pr)
       {
           List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "SELECT MedicineIssued.*, lt.[Test (A-Z)],lt.IsAlwaysPaid,lt.IsRsTenInjection,lt.Poor,lt.YCDO,lt.Deserving,lt.Generall FROM MedicineIssued, LabTest lt where lt.ID=MedicineIssued.MedicineID and MedicinesIssued=No and TokenNumber=" + pr.TokenNumber + " and TokenMonthYear=" + pr.TokenMonthYear + "";
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
                       LabTest med = new LabTest();
                       med.MedicineIssuedSerialID = Convert.ToInt32(row["ID"]== DBNull.Value ? 0 : row["ID"]);
                       med.IsMedicine = true;
                       med.LabTestId = Convert.ToInt32(row["MedicineID"] == DBNull.Value ? 0 : row["MedicineID"]);
                       med.TimesADay = Convert.ToDecimal(row["DosePerDay"] == DBNull.Value ? 0 : row["DosePerDay"]);
                       med.TestName = Convert.ToString(row["Test (A-Z)"] == DBNull.Value ? "" : row["Test (A-Z)"]);
                       med.MedIssuedID = Convert.ToInt32(row["ID"] == DBNull.Value ? 0 : row["ID"]);
                       med.IsAlwaysPaid = Convert.ToBoolean(row["IsAlwaysPaid"]);
                       med.IsRsTenInjection = Convert.ToBoolean(row["IsRsTenInjection"]);
                       med.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                       med.Deserving = Convert.ToDecimal(row["Deserving"] == DBNull.Value ? 0 : row["Deserving"]);
                       med.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                       med.General = Convert.ToDecimal(row["Generall"] == DBNull.Value ? 0 : row["Generall"]);
                       labTests.Add(med);
                   }
               }

               return labTests;
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
       public List<LabTest> GetMedicineIssued3(PatientRegistration pr)
       {
           List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "SELECT MedicineIssued.*, lt.[Test (A-Z)],lt.IsAlwaysPaid,lt.IsRsTenInjection,lt.Poor,lt.YCDO,lt.Deserving,lt.Generall FROM MedicineIssued, LabTest lt where lt.ID=MedicineIssued.MedicineID and TokenNumber=" + pr.TokenNumber + " and TokenMonthYear=" + pr.TokenMonthYear + "";
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
                       LabTest med = new LabTest();
                       med.MedicineIssuedSerialID = Convert.ToInt32(row["ID"] == DBNull.Value ? 0 : row["ID"]);
                       med.IsMedicine = true;
                       med.LabTestId = Convert.ToInt32(row["MedicineID"] == DBNull.Value ? 0 : row["MedicineID"]);
                       med.TimesADay = Convert.ToDecimal(row["DosePerDay"] == DBNull.Value ? 0 : row["DosePerDay"]);
                       med.TestName = Convert.ToString(row["Test (A-Z)"] == DBNull.Value ? "" : row["Test (A-Z)"]);
                       med.MedIssuedID = Convert.ToInt32(row["ID"] == DBNull.Value ? 0 : row["ID"]);
                       med.IsAlwaysPaid = Convert.ToBoolean(row["IsAlwaysPaid"]);
                       med.IsRsTenInjection = Convert.ToBoolean(row["IsRsTenInjection"]);
                       med.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                       med.Deserving = Convert.ToDecimal(row["Deserving"] == DBNull.Value ? 0 : row["Deserving"]);
                       med.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                       med.General = Convert.ToDecimal(row["Generall"] == DBNull.Value ? 0 : row["Generall"]);
                       labTests.Add(med);
                   }
               }

               return labTests;
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
       public List<PatientRegistration> GetAllMedicineNotIssued()
       {
           List<LabTest> labTests = new List<LabTest>();
           List<PatientRegistration> prs = new List<PatientRegistration>();
           try
           {
               string select ="SELECT Distinct TokenDate,TokenMonthYear,TokenNumber from MedicineIssued where MedicinesIssued=No and tokennumber <>0 ";
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
       public List<PatientRegistration> GetAllMedicinesIssued()
       {

           List<PatientRegistration> prs = new List<PatientRegistration>();
           try
           {
               string select = "select distinct lt.ID,lt.[Test (A-Z)],m.TokenNumber,m.TokenDate,m.TokenMonthYear,pr.PatientRegistrationNumber,pr.PatientFirstName from LabTest lt,MedicineIssued m,PatientRegistration pr where m.TokenNumber=pr.TokenNumber and m.TokenDate=pr.TokenDate and  lt.ID in(select mi.MedicineID from MedicineIssued mi where MedicinesIssued=Yes)";
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
                       pr.Patient.RegistrationNumber = (row["PatientRegistrationNumber"] == DBNull.Value ? "" : row["PatientRegistrationNumber"]).ToString();
                       pr.Patient.FirstName = row["PatientFirstName"] == DBNull.Value ? "" : row["PatientFirstName"].ToString();
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
       #endregion
       public InjectionLabTest GetInjectionLabTest(InjectionLabTest inLb)
       {
           //List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "Select ilt.* ,(select [Test (A-Z)]  from LabTest lt where ilt.Labtestid=lt.id) as TestName   from InjectionLabTest ilt where TokenNumber=" + inLb.TokenNumber + " and TokenMonthYear=" + inLb.TokenMonthYear + "";
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
                   double cashRecieved = 0;
                   foreach (DataRow row in dt.Rows)
                   {
                       
                       inLb.Patient.FirstName = Convert.ToString(row["PatientFirstName"] == DBNull.Value ? "" : row["PatientFirstName"]);
                       inLb.Patient.LastName = Convert.ToString(row["PatientLastName"] == DBNull.Value ? "" : row["PatientLastName"]);
                       inLb.Patient.NIC = Convert.ToString(row["PatientNIC"] == DBNull.Value ? "" : row["PatientNIC"]);
                       inLb.Patient.RegistrationNumber = Convert.ToString(row["PatientRegistrationNumber"] == DBNull.Value ? "" : row["PatientRegistrationNumber"]);
                       inLb.Patient.RegistrationDate = Convert.ToDateTime(row["PatientRegistrationDate"]);
                       inLb.Patient.Address = Convert.ToString(row["PatientAddress"] == DBNull.Value ? "" : row["PatientAddress"]);
                       inLb.CashReceived = Convert.ToDouble(row["TokenAmount"] == DBNull.Value ? "" : row["TokenAmount"]);
                       if (row["PatientPayType"] != DBNull.Value)
                           inLb.Type = (PatientPayType)Enum.Parse(typeof(PatientPayType), row["PatientPayType"].ToString());
                       inLb.TokenDate = Convert.ToDateTime(row["TokenDate"] == DBNull.Value ? DateTime.MinValue : row["TokenDate"]);
                       inLb.ExistingTokenNo = Convert.ToInt64(row["ExistingTokenID"] == DBNull.Value ? 0 : row["ExistingTokenID"]);
                       
                       int testid = Convert.ToInt32(row["LabTestId"] == DBNull.Value ? 0 : row["LabTestId"]);
                       string testname = Convert.ToString(row["TestName"] == DBNull.Value ? "" : row["TestName"]);
                       int totaldays = Convert.ToInt32(row["Days"] == DBNull.Value ? 0 : row["Days"]);
                       int timesaday = Convert.ToInt32(row["DosePerDay"] == DBNull.Value ? 0 : row["DosePerDay"]);
                       if (testid != 0)
                       {
                           inLb.Tests.Add(new LabTest(testid, testname,timesaday,totaldays));
                           cashRecieved += Convert.ToDouble(row["TokenAmount"] == DBNull.Value ? "" : row["TokenAmount"]);
                           inLb.CashReceived = cashRecieved;
                       }
                       inLb.IsInjectionToken = Convert.ToBoolean(testid ==0 ? true : false);
                       //return inLb;
                       //LabTest labTest = new LabTest();
                       //labTest.TestName = Convert.ToString(row["Test (A-Z)"] == DBNull.Value ? "" : row["Test (A-Z)"]);
                       //labTest.SampleName = Convert.ToString(row["Sample"] == DBNull.Value ? "" : row["Sample"]);
                       //labTest.Performed = Convert.ToString(row["Performed"] == DBNull.Value ? "" : row["Performed"]);
                       //labTest.LabTestId = Convert.ToInt32(row["ID"]);
                       //labTest.Report = Convert.ToString(row["Report"] == DBNull.Value ? "" : row["Report"]);

                       //labTest.Deserving = Convert.ToDecimal(row["Deserving"] == DBNull.Value ? 0 : row["Deserving"]);
                       //labTest.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                       //labTest.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                       //labTest.General = Convert.ToDecimal(row["General"] == DBNull.Value ? 0 : row["General"]);
                       //labTest.Shahab = Convert.ToDecimal(row["Shahab"] == DBNull.Value ? 0 : row["Shahab"]);
                       //labTest.Ghori = Convert.ToDecimal(row["Ghori"] == DBNull.Value ? 0 : row["Ghori"]);
                       //labTests.Add(labTest);
                       
                   }
               }

               return inLb;
               // return labTests;
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
       public List<RecieveMedicine> GetIssuedMedicines()
       {
           List<RecieveMedicine> LoRec = new List<RecieveMedicine>();
           try
           {
               string select = "Select * from IssuedMedicine";
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
                       RecieveMedicine ObjRec = new RecieveMedicine();
                       ObjRec.RefRec.LineItem.LabTestId = Convert.ToInt32(row["MedicineID"]==DBNull.Value?0:row["MedicineID"]);
                       ObjRec.RefRec.LineItem.TestName = row["MedicineName"]==DBNull.Value?"":row["MedicineName"].ToString();
                       ObjRec.RefRec.LineItem.MedIssuedID = Convert.ToInt32(row["ID"]==DBNull.Value?0:row["ID"]);
                       ObjRec.RefRec.Quantity = Convert.ToDecimal(row["Qty"]==DBNull.Value?0:row["Qty"]);
                       ObjRec.RecieveDate = Convert.ToDateTime(row["IssueDate"]==DBNull.Value?new DateTime():row["IssueDate"]);
                       ObjRec.RecieveNumber = Convert.ToInt64(row["IssueNumber"]==DBNull.Value?0:row["IssueNumber"]);
                       ObjRec.RefBranch.BranchName = (row["BranchName"] == DBNull.Value ? "" : row["BranchName"]).ToString();
                       ObjRec.RefRec.Price = Convert.ToDouble(row["Price"]==DBNull.Value?0:row["Price"]);
                       ObjRec.RefRec.GrossAmount = Convert.ToDouble(row["GrossAmount"]==DBNull.Value?0:row["GrossAmount"]);
                       ObjRec.RefRec.NetAmount = Convert.ToDouble(row["NetAmount"]==DBNull.Value?0:row["NetAmount"]);
                       LoRec.Add(ObjRec);
                   }
               }


               return LoRec;
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
       public List<RecieveMedicine> GetIssuedMedicines(string IssueNumber)
       {
           List<RecieveMedicine> LoRec = new List<RecieveMedicine>();
           try
           {
               string select = "Select * from IssuedMedicine where IssueNumber=" + IssueNumber;
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
                       RecieveMedicine ObjRec = new RecieveMedicine();
                       ObjRec.RefRec.LineItem.LabTestId = Convert.ToInt32(row["MedicineID"]);
                       ObjRec.RefRec.LineItem.TestName = row["MedicineName"].ToString();
                       //ObjRec.RefRec.LineItem.MedIssuedID = Convert.ToInt32(row["ID"]);
                       ObjRec.RefRec.Quantity = Convert.ToDecimal(row["Qty"]);
                       //ObjRec.RecieveDate = Convert.ToDateTime(row["RecieveDate"]);
                       //ObjRec.RecieveNumber = Convert.ToInt64(row["RecievedNumber"]);
                       ObjRec.RefRec.Price = Convert.ToDouble(row["Price"]);
                       ObjRec.RefRec.GrossAmount = Convert.ToDouble(row["GrossAmount"]);
                       ObjRec.RefRec.NetAmount = Convert.ToDouble(row["NetAmount"]);
                       LoRec.Add(ObjRec);
                   }
               }


               return LoRec;
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
       public long GetNextReceiptNumber()
       {
           try
           {
               string select = "select max(IssueNumber) from IssuedMedicine";
               con = new OleDbConnection();
               this.readconfile = new ReadConfigFile();
               con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
               con.Open();
               cmd = new OleDbCommand(select, con);
               object obj = cmd.ExecuteScalar();
               if (DBNull.Value != obj)
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
       public bool SaveIssuedMedicine(RecieveMedicine rm)
       {
           try
           {
               int VID = 0;
               con = new OleDbConnection();
               this.readconfile = new ReadConfigFile();
               con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
               con.Open();
               tran = con.BeginTransaction();
               cmd = new OleDbCommand("", con);
               //cmd.Connection = con;
               cmd.Transaction = tran;
               //cmd.CommandType = CommandType.Text;
               cmd.CommandText = "delete from IssuedMedicine where IssueNumber=" + rm.RecieveNumber;
               cmd.ExecuteNonQuery();
               OleDbCommand cmdSave = new OleDbCommand();
               cmdSave.Connection = con;
               cmdSave.Transaction = tran;
               foreach (RecieveLineItem item in rm.Lines)
               {
                   //if (rm.RefRec.LineItem.MedIssuedID == 0)
                   //{
                   if (item.LineItem.LabTestId > 0)
                   {
                       cmdSave.CommandText = "Insert into IssuedMedicine(IssueDate,IssueNumber,MedicineID,MedicineName,Qty,Price,GrossAmount,NetAmount,BranchName) values (#" +
                                       rm.RecieveDate + "#," + rm.RecieveNumber + "," + item.LineItem.LabTestId + ",'" +
                                       item.LineItem.TestName + "'," + item.Quantity + "," + item.Price + "," + item.GrossAmount + "," + rm.RefRec.NetAmount +",'" +rm.RefBranch.BranchName+"' )";
                   }
                   cmdSave.ExecuteNonQuery();

               }
               //else
               //{
               //    if (item.LineItem.LabTestId > 0)
               //    {
               //        cmd.CommandText = "update IssuedMedicine set IssueDate=#" + rm.RecieveDate + "#" + "," + "IssueNumber=" + rm.RecieveNumber + "," + "MedicineID=" + item.LineItem.LabTestId + "," + "MedicineName='" + item.LineItem.TestName + "'," +
               //        "Qty=" + item.Quantity + " where ID=" + rm.RefRec.LineItem.MedIssuedID;

               //    }
               //}

               //}
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
       public DSIssueBill.DTIssueBillDataTable PrintIssueMedBill(RecieveMedicine Obj,bool Retail,bool Purchase)
       {
           DSIssueBill.DTIssueBillDataTable dt = new DSIssueBill.DTIssueBillDataTable();
           try
           {


               string Qry = "select IssueDate,IssueNumber,MedicineName,Qty as Quantity,lt.PurchasePrice as Price,GrossAmount,NetAmount from IssuedMedicine,LabTest lt where "+
                           "  lt.ID=IssuedMedicine.MedicineID and IssuedMedicine.IssueNumber="+Obj.RecieveNumber;
               string Qry2 = "select IssueDate,IssueNumber,MedicineName,Qty as Quantity,lt.RetailPrice as Price,GrossAmount,NetAmount from IssuedMedicine,LabTest lt where " +
            "  lt.ID=IssuedMedicine.MedicineID and IssuedMedicine.IssueNumber=" + Obj.RecieveNumber;

               con = new OleDbConnection();
               this.readconfile = new ReadConfigFile();
               con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
               con.Open();
               if (con.State == ConnectionState.Open)
               {

                   if (Retail == true)
                       da = new OleDbDataAdapter(Qry2, con);
                   else if(Purchase==true)
                       da = new OleDbDataAdapter(Qry, con);
                   da.Fill(dt);
               }


               return dt;
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
       public bool DeleteIssuedMedicine(int IssueNumber)
       {
           try
           {
               int VID = 0;
               con = new OleDbConnection();
               this.readconfile = new ReadConfigFile();
               con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
               con.Open();
               tran = con.BeginTransaction();

               cmd = new OleDbCommand("", con);
               //cmd.Connection = con;
               cmd.Transaction = tran;
               //cmd.CommandType = CommandType.Text;



               cmd.CommandText = "delete from IssuedMedicine where IssueNumber=" + IssueNumber;
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
       public List<LabTest> GetInjectionLabTests(int tokenNumber,DateTime tokenDate)
       {
           List<LabTest> inLbs = new List<LabTest>();
           LabTest inLb;
           try
           {
               string select = "Select * from InjectionLabTest where tokenNumber=" + tokenNumber.ToString() + " and TokenDate >=#" + tokenDate.Date.AddDays(-1).ToShortDateString() + "#" ;
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
                       inLb = new LabTest();
                       //inLb.TokenNumber = Convert.ToInt64(row["TokenNumber"]);
                       //inLb.Patient.FirstName = Convert.ToString(row["PatientFirstName"] == DBNull.Value ? "" : row["PatientFirstName"]);
                       //inLb.Patient.LastName = Convert.ToString(row["PatientLastName"] == DBNull.Value ? "" : row["PatientLastName"]);
                       //inLb.Patient.NIC = Convert.ToString(row["PatientNIC"] == DBNull.Value ? "" : row["PatientNIC"]);
                       //inLb.Patient.RegistrationNumber = Convert.ToString(row["PatientRegistrationNumber"] == DBNull.Value ? "" : row["PatientRegistrationNumber"]);
                       //inLb.Patient.RegistrationDate = Convert.ToDateTime(row["PatientRegistrationDate"]);
                       //inLb.Patient.Address = Convert.ToString(row["PatientAddress"] == DBNull.Value ? "" : row["PatientAddress"]);
                       //inLb.CashReceived = Convert.ToDouble(row["TokenAmount"] == DBNull.Value ? "" : row["TokenAmount"]);
                       //if (row["PatientPayType"] != DBNull.Value)
                       //    inLb.Type = (PatientPayType)Enum.Parse(typeof(PatientPayType), row["PatientPayType"].ToString());
                       //inLb.TokenDate = Convert.ToDateTime(row["TokenDate"] == DBNull.Value ? DateTime.MinValue : row["TokenDate"]);
                       //inLb.ExistingTokenNo = Convert.ToInt64(row["ExistingTokenID"] == DBNull.Value ? 0 : row["ExistingTokenID"]);
                       int testid = Convert.ToInt32(row["LabTestId"] == DBNull.Value ? 0 : row["LabTestId"]);
                       int injectionid = Convert.ToInt32(row["InjectionId"] == DBNull.Value ? 0 : row["InjectionId"]);
                       if (testid != 0)
                           inLb.LabTestId = testid;
                       else
                       {
                           inLb.LabTestId = injectionid;
                       }
                               
                       inLbs.Add(inLb);
                   }
               }
               return inLbs;
               // return labTests;
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
       List<InjectionLabTest> inLbs;
       public List<InjectionLabTest> GetInjectionLabTests()
       {
           inLbs = new List<InjectionLabTest>();
           InjectionLabTest inLb;
           try
           {
               string select = "Select * from InjectionLabTest ";
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
                       inLb = new InjectionLabTest();
                       inLb.TokenNumber = Convert.ToInt64(row["TokenNumber"]);
                       inLb.Patient.FirstName = Convert.ToString(row["PatientFirstName"] == DBNull.Value ? "" : row["PatientFirstName"]);
                       inLb.Patient.LastName = Convert.ToString(row["PatientLastName"] == DBNull.Value ? "" : row["PatientLastName"]);
                       inLb.Patient.NIC = Convert.ToString(row["PatientNIC"] == DBNull.Value ? "" : row["PatientNIC"]);
                       inLb.Patient.RegistrationNumber = Convert.ToString(row["PatientRegistrationNumber"] == DBNull.Value ? "" : row["PatientRegistrationNumber"]);
                       inLb.Patient.RegistrationDate = Convert.ToDateTime(row["PatientRegistrationDate"]);
                       inLb.Patient.Address = Convert.ToString(row["PatientAddress"] == DBNull.Value ? "" : row["PatientAddress"]);
                       inLb.CashReceived = Convert.ToDouble(row["TokenAmount"] == DBNull.Value ? "" : row["TokenAmount"]);
                       if (row["PatientPayType"] != DBNull.Value)
                           inLb.Type = (PatientPayType)Enum.Parse(typeof(PatientPayType), row["PatientPayType"].ToString());
                       inLb.TokenDate = Convert.ToDateTime(row["TokenDate"] == DBNull.Value ? DateTime.MinValue : row["TokenDate"]);
                       inLb.ExistingTokenNo = Convert.ToInt64(row["ExistingTokenID"] == DBNull.Value ? 0 : row["ExistingTokenID"]);
                       int testid = Convert.ToInt32(row["LabTestId"] == DBNull.Value ? 0 : row["LabTestId"]);
                       if (testid != 0)
                           inLb.Tests.Add(new LabTest(testid));
                       inLb.IsInjectionToken = Convert.ToBoolean(testid == 0 ? true : false);
                       inLbs.Add(inLb);
                   }
               }
               return inLbs;
               // return labTests;
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
       public PatientRegistration GetPatientRegistrationLab(PatientRegistration pr)
       {
           //List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "Select * from patientregistration where TokenNumber=" + pr.TokenNumber + " and TokenMonthYear=" + pr.TokenMonthYear + " and TokenDate=#" + pr.TokenDate + "#";
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
                       pr.Patient.FirstName = Convert.ToString(row["PatientFirstName"] == DBNull.Value ? "" : row["PatientFirstName"]);
                       pr.Patient.LastName = Convert.ToString(row["PatientLastName"] == DBNull.Value ? "" : row["PatientLastName"]);
                       pr.Patient.NIC = Convert.ToString(row["PatientNIC"] == DBNull.Value ? "" : row["PatientNIC"]);
                       pr.Patient.RegistrationNumber = Convert.ToString(row["PatientRegistrationNumber"] == DBNull.Value ? "" : row["PatientRegistrationNumber"]);
                       pr.Patient.RegistrationDate = Convert.ToDateTime(row["PatientRegistrationDate"]);
                       pr.Patient.Address = Convert.ToString(row["PatientAddress"] == DBNull.Value ? "" : row["PatientAddress"]);
                       pr.CashReceived = Convert.ToDouble(row["TokenAmount"] == DBNull.Value ? "" : row["TokenAmount"]);
                       pr.TokenType = (TokenType)Enum.Parse(typeof(TokenType), Convert.ToString(row["PatientType"] == DBNull.Value ? "" : row["PatientType"]));
                       pr.Room.Name = Convert.ToString(row["Room"] == DBNull.Value ? "" : row["Room"]);
                       pr.TokenDate = Convert.ToDateTime(row["TokenDate"] == DBNull.Value ? DateTime.MinValue : row["TokenDate"]);
                       return pr;
                       //LabTest labTest = new LabTest();
                       //labTest.TestName = Convert.ToString(row["Test (A-Z)"] == DBNull.Value ? "" : row["Test (A-Z)"]);
                       //labTest.SampleName = Convert.ToString(row["Sample"] == DBNull.Value ? "" : row["Sample"]);
                       //labTest.Performed = Convert.ToString(row["Performed"] == DBNull.Value ? "" : row["Performed"]);
                       //labTest.LabTestId = Convert.ToInt32(row["ID"]);
                       //labTest.Report = Convert.ToString(row["Report"] == DBNull.Value ? "" : row["Report"]);

                       //labTest.Deserving = Convert.ToDecimal(row["Deserving"] == DBNull.Value ? 0 : row["Deserving"]);
                       //labTest.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                       //labTest.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                       //labTest.General = Convert.ToDecimal(row["General"] == DBNull.Value ? 0 : row["General"]);
                       //labTest.Shahab = Convert.ToDecimal(row["Shahab"] == DBNull.Value ? 0 : row["Shahab"]);
                       //labTest.Ghori = Convert.ToDecimal(row["Ghori"] == DBNull.Value ? 0 : row["Ghori"]);
                       //labTests.Add(labTest);
                   }
               }

               return pr;
               // return labTests;
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
       public PatientRegistration  GetPatientRegistration(PatientRegistration pr)
       {
           //List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "Select * from patientregistration where TokenNumber=" + pr.TokenNumber + " and TokenMonthYear=" + pr.TokenMonthYear;
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
                       pr.Patient.FirstName = Convert.ToString(row["PatientFirstName"] ==DBNull.Value ?"": row["PatientFirstName"]);
                       pr.Patient.LastName = Convert.ToString(row["PatientLastName"]==DBNull.Value ?"": row["PatientLastName"]);
                       pr.Patient.NIC = Convert.ToString(row["PatientNIC"] == DBNull.Value ?"": row["PatientNIC"]);
                       pr.Patient.RegistrationNumber = Convert.ToString(row["PatientRegistrationNumber"] ==DBNull.Value ?"": row["PatientRegistrationNumber"]);
                       pr.Patient.RegistrationDate = Convert.ToDateTime(row["PatientRegistrationDate"]);
                       pr.Patient.Address = Convert.ToString(row["PatientAddress"]== DBNull.Value ?"": row["PatientAddress"]);
                       pr.CashReceived = Convert.ToDouble(row["TokenAmount"] == DBNull.Value ? "" : row["TokenAmount"]);
                       pr.TokenType = (TokenType) Enum.Parse(typeof(TokenType), Convert.ToString(row["PatientType"] == DBNull.Value ? "" : row["PatientType"]));
                       pr.Room.Name = Convert.ToString(row["Room"] == DBNull.Value ? "" : row["Room"]);
                       pr.TokenDate = Convert.ToDateTime(row["TokenDate"] == DBNull.Value ? DateTime.MinValue : row["TokenDate"]);
                       return pr;
                       //LabTest labTest = new LabTest();
                       //labTest.TestName = Convert.ToString(row["Test (A-Z)"] == DBNull.Value ? "" : row["Test (A-Z)"]);
                       //labTest.SampleName = Convert.ToString(row["Sample"] == DBNull.Value ? "" : row["Sample"]);
                       //labTest.Performed = Convert.ToString(row["Performed"] == DBNull.Value ? "" : row["Performed"]);
                       //labTest.LabTestId = Convert.ToInt32(row["ID"]);
                       //labTest.Report = Convert.ToString(row["Report"] == DBNull.Value ? "" : row["Report"]);

                       //labTest.Deserving = Convert.ToDecimal(row["Deserving"] == DBNull.Value ? 0 : row["Deserving"]);
                       //labTest.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                       //labTest.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                       //labTest.General = Convert.ToDecimal(row["General"] == DBNull.Value ? 0 : row["General"]);
                       //labTest.Shahab = Convert.ToDecimal(row["Shahab"] == DBNull.Value ? 0 : row["Shahab"]);
                       //labTest.Ghori = Convert.ToDecimal(row["Ghori"] == DBNull.Value ? 0 : row["Ghori"]);
                       //labTests.Add(labTest);
                   }
               }

               return pr;
              // return labTests;
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
       public List<LabTest> GetMedicineCanceled(PatientRegistration pr)
       {
           List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "SELECT MedicineIssued_Canceled.*, lt.[Test (A-Z)],lt.IsAlwaysPaid,lt.IsRsTenInjection,lt.Poor,lt.YCDO,lt.Deserving,lt.Generall FROM MedicineIssued_Canceled, LabTest lt where lt.ID=MedicineIssued_Canceled.MedicineID and TokenNumber=" + pr.TokenNumber + " and TokenMonthYear=" + pr.TokenMonthYear + "";
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
                       LabTest med = new LabTest();
                       med.IsMedicine = true;
                       med.LabTestId = Convert.ToInt32(row["MedicineID"] == DBNull.Value ? 0 : row["MedicineID"]);
                       med.TimesADay = Convert.ToDecimal(row["DosePerDay"] == DBNull.Value ? 0 : row["DosePerDay"]);
                       med.TestName = Convert.ToString(row["Test (A-Z)"] == DBNull.Value ? "" : row["Test (A-Z)"]);
                       med.MedIssuedID = Convert.ToInt32(row["ID"] == DBNull.Value ? 0 : row["ID"]);
                       med.IsAlwaysPaid = Convert.ToBoolean(row["IsAlwaysPaid"]);
                       med.IsRsTenInjection = Convert.ToBoolean(row["IsRsTenInjection"]);
                       med.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                       med.Deserving = Convert.ToDecimal(row["Deserving"] == DBNull.Value ? 0 : row["Deserving"]);
                       med.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                       med.General = Convert.ToDecimal(row["Generall"] == DBNull.Value ? 0 : row["Generall"]);
                       labTests.Add(med);
                   }
               }

               return labTests;
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
       public List<LabTest> GetMedicineIssued2(PatientRegistration pr)
       {
           List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "SELECT MedicineIssued.*, lt.[Test (A-Z)],lt.IsAlwaysPaid,lt.IsRsTenInjection,lt.Poor,lt.YCDO,lt.Deserving,lt.Generall FROM MedicineIssued, LabTest lt where lt.ID=MedicineIssued.MedicineID and MedicinesIssued=Yes and TokenNumber=" + pr.TokenNumber + " and TokenMonthYear=" + pr.TokenMonthYear + "";
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
                       LabTest med = new LabTest();
                       med.IsMedicine = true;
                       med.LabTestId = Convert.ToInt32(row["MedicineID"] == DBNull.Value ? 0 : row["MedicineID"]);
                       med.TimesADay = Convert.ToDecimal(row["DosePerDay"] == DBNull.Value ? 0 : row["DosePerDay"]);
                       med.TestName = Convert.ToString(row["Test (A-Z)"] == DBNull.Value ? "" : row["Test (A-Z)"]);
                       med.MedIssuedID = Convert.ToInt32(row["ID"] == DBNull.Value ? 0 : row["ID"]);
                       med.IsAlwaysPaid = Convert.ToBoolean(row["IsAlwaysPaid"]);
                       med.IsRsTenInjection = Convert.ToBoolean(row["IsRsTenInjection"]);
                       med.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                       med.Deserving = Convert.ToDecimal(row["Deserving"] == DBNull.Value ? 0 : row["Deserving"]);
                       med.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                       med.General = Convert.ToDecimal(row["Generall"] == DBNull.Value ? 0 : row["Generall"]);
                       labTests.Add(med);
                   }
               }

               return labTests;
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
       List<PatientRegistration> lopr;
       public List<PatientRegistration> GetPatientRegistration2()
       {
           
           try
           {
               lopr = new List<PatientRegistration>();
               string select = "Select * from patientregistration where TokenNumber and TokenDate is not null";
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
                       pr.TokenNumber =Convert.ToInt64(row["TokenNumber"]);
                      
                       pr.TokenType = (TokenType)Enum.Parse(typeof(TokenType), Convert.ToString(row["PatientType"] == DBNull.Value ? "" : row["PatientType"]));
                       pr.Patient.FirstName = Convert.ToString(row["PatientFirstName"] == DBNull.Value ? "" : row["PatientFirstName"]);
                       pr.Patient.LastName = Convert.ToString(row["PatientLastName"] == DBNull.Value ? "" : row["PatientLastName"]);
                       pr.Patient.NIC = Convert.ToString(row["PatientNIC"] == DBNull.Value ? "" : row["PatientNIC"]);
                       pr.Patient.RegistrationNumber = Convert.ToString(row["PatientRegistrationNumber"] == DBNull.Value ? "" : row["PatientRegistrationNumber"]);
                       pr.Patient.RegistrationDate = Convert.ToDateTime(row["PatientRegistrationDate"]);
                       pr.Patient.Address = Convert.ToString(row["PatientAddress"] == DBNull.Value ? "" : row["PatientAddress"]);
                       pr.CashReceived = Convert.ToDouble(row["TokenAmount"] == DBNull.Value ? "" : row["TokenAmount"]);
                       pr.TokenDate = Convert.ToDateTime(row["TokenDate"]);
                       lopr.Add(pr);
                    
                   }
               }

               return lopr;
               // return labTests;
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

       public List<InjectionLabTest> GetTokenNum(DateTime date)
       {
           inLbs = new List<InjectionLabTest>();
           InjectionLabTest inLb;
           try
           {
           //    string select = "SELECT max(tokennumber)as TokenNum from patientRegistration where tokendate=#" + date+ "#";
             
               con = new OleDbConnection();
               readconfile = new ReadConfigFile();
               con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
               con.Open();
               tran = con.BeginTransaction();
               cmd = new OleDbCommand("SELECT max(tokennumber)as TokenNum from patientRegistration where tokendate=#" + date + "#", con);
               cmd.Transaction = tran;
               dr = cmd.ExecuteReader();
               while (dr.Read())
               {
                   inLb = new InjectionLabTest();
                   inLb.TokenNumber = (dr["TokenNum"]) == System.DBNull.Value ? 0 : Convert.ToInt64(dr["TokenNum"]);
                   inLbs.Add(inLb);
               }
             
               dr.Close();
               tran.Commit();
               return inLbs;
               // return labTests;
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
