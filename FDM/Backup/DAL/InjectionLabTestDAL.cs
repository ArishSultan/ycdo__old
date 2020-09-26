using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                   insert = "Insert Into InjectionLabTest(TokenDate,TokenMonthYear,TokenNumber,PatientFirstName,PatientLastName"
                + ",PatientNIC,PatientAddress,TokenAmount,PatientRegistrationNumber,PatientRegistrationDate,ExistingTokenID) "
                + "values (#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + ",'" + pr.Patient.FirstName + "','" + pr.Patient.LastName + "','"
                + pr.Patient.NIC + "','" + pr.Patient.Address + "'," + (int)pr.CashReceived + ",'"
                + pr.Patient.RegistrationNumber + "',#" + pr.Patient.RegistrationDate + "#,'"+ pr.ExistingTokenNo +"')";
                   cmd.CommandText = insert;
                   cmd.ExecuteNonQuery();
               }
               else
               {
                   foreach (LabTest item in pr.Tests)
                   {
                       insert = "Insert Into InjectionLabTest(TokenDate,TokenMonthYear,TokenNumber,PatientFirstName,PatientLastName"
                                       + ",PatientNIC,PatientAddress,TokenAmount,PatientRegistrationNumber,PatientRegistrationDate,LabTestId,PatientPayType,ExistingTokenID) "
                                       + "values (#" + pr.TokenDate + "#," + pr.TokenMonthYear + "," + pr.TokenNumber + ",'" + pr.Patient.FirstName + "','" + pr.Patient.LastName + "','"
                                       + pr.Patient.NIC + "','" + pr.Patient.Address + "'," + (int)item.CurrentAmount + ",'"
                                       + pr.Patient.RegistrationNumber + "',#" + pr.Patient.RegistrationDate + "#," + item.LabTestId + ",'" + pr.Type.ToString() + "','" + pr.ExistingTokenNo + "')";
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
                       if (testid != 0)
                       {
                           inLb.Tests.Add(new LabTest(testid, testname));
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

       public PatientRegistration  GetPatientRegistration(PatientRegistration pr)
       {
           //List<LabTest> labTests = new List<LabTest>();
           try
           {
               string select = "Select * from patientregistration where TokenNumber=" + pr.TokenNumber + " and TokenMonthYear=" + pr.TokenMonthYear + "";
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
   
    }
}
