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
       

        public DsTokenSummary  GetTokenSummary(DateTime fromDate,DateTime toDate, bool All,bool injection,bool Checkup,bool labtest)
        {
            DsTokenSummary ds = new DsTokenSummary();
            try
            {
                string selectCheckup = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount,'' as TestName FROM PatientRegistration where TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + "#";
                string selectInjection = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,'' as TestName FROM InjectionLabtest Where LabtestID is  null and TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + "#";
                string selectLabTest = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + "#";
               
                string selectAll = "        SELECT  'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,'' as TestName FROM PatientRegistration where TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + "#"
                + "Union ALL"
                + " SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount,'' as TestName FROM InjectionLabtest  where  LabtestID is  null and TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + "#"
                + " Union All"
                + " SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount,[Test (A-Z)]  as TestName FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and TokenDate>=#" + fromDate.Date + "# and TokenDate<=#" + toDate.Date + "#";
                //(select Top 1 [Test (A-Z)] from LabTest lt,InjectionLabtest ilt  where lt.ID=ilt.LabTestid)
                
                
                //+ " Union All"

                //+ " SELECT  lt.[Test (A-Z)] as TestName,'LabTest' as TokenType, TokenDate, TokenNumber, PatientFirstName , PatientLastName , PatientNIC, PatientAddress, TokenAmount  FROM LabTest lt ,InjectionLabTest ilt where lt.ID = ilt.LabTestId  ";
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
