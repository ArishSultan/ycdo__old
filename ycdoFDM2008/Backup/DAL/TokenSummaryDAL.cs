using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data.OleDb;
using System.Data;
using OleDbHelper;
using Common.Datasets;
namespace DAL
{
    public  class TokenSummaryDAL
    {


        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbDataReader dr;
        private OleDbTransaction tran;
        public bool is50 { get; set; }

        public DsTokenSummary  GetTokenSummary(DateTime fromDate,DateTime toDate, bool All,bool injection,bool Checkup,bool labtest,bool Medicine, bool rb50)
        {
            DsTokenSummary ds = new DsTokenSummary();
            try
            {
                string selectCheckup = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount,'' as TestName FROM PatientRegistration where TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + "#";
                string selectInjection = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,'' as TestName FROM InjectionLabtest Where LabtestID is  null and TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + "#";
                string selectLabTest = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=No and TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + "#";
                string MedicineQry = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=True and TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + "#";
                string selectCheckup50 = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount,'' as TestName FROM PatientRegistration where TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + 
                                          "# and TokenAmount = 50";
                string selectInjection50 = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,'' as TestName FROM InjectionLabtest Where LabtestID is  null and TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + "# and TokenAmount = 50";
                string selectLabTest50 = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=No and TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + "# and TokenAmount = 50";
                string MedicineQry50 = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=True and TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + "# and TokenAmount = 50";
                string selectAll50 = selectCheckup50 + " Union ALL " + selectInjection50 + " Union All " + selectLabTest50 + " Union All " + MedicineQry50;  
                
                
                string selectAll = selectCheckup + " Union ALL " + selectInjection + " Union All " + selectLabTest + " Union All " + MedicineQry;  
                DataTable dt = new DataTable();
                con = new OleDbConnection();
                readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    
                    string select = "";
                    if (All == true)
                        select = selectAll;
                    else if (injection == true)
                        select = selectInjection;
                    else if (Checkup == true)
                        select = selectCheckup;
                    else if (labtest == true)
                        select = selectLabTest;
                    else if (Medicine == true)
                        select = MedicineQry;
                    if (All == true && rb50 == true)
                        select = selectAll50;
                    else if (injection == true && rb50 == true)
                        select = selectInjection50;
                    else if (Checkup == true && rb50 == true)
                        select = selectCheckup50;
                    else if (labtest == true && rb50 == true)
                        select = selectLabTest50;
                    else if (Medicine == true && rb50 == true)
                        select = MedicineQry50;
                    da = new OleDbDataAdapter(select, con);
                    da.Fill(ds,ds.Tables[0].TableName );

                }

                

                return ds ;
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
