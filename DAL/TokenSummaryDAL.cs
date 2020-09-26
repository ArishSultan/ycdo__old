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

        string selectCheckup;
        string selectInjection;
        string selectLabTest;
        string MedicineQry;
        string selectCheckup50;
        string selectInjection50;
        string selectLabTest50;
        string MedicineQry50;
        string selectAll50;
        string selectAll;
                

        //public DSTTokenSummryUserWise GetTokenSummaryUserWise(DateTime fromDate, DateTime toDate)
        public DSTTokenSummryUserWise GetTokenSummaryUserWise(DateTime fromDate, DateTime toDate, Boolean isTime)
        {
            DSTTokenSummryUserWise ds = new DSTTokenSummryUserWise();
            try
            {
                string select;
                if (isTime == true)
                    select = "select (Select u.UName from unames u where u.UNo=TokenBy) as UserName , COUNT(ID) as TotalTokens,SUM(TokenAmount) as TotalAmount from PatientRegistration    where TokenDate>='" + fromDate.ToString("MM/dd/yyyy HH:mm") + "' and TokenDate<='" + toDate.ToString("MM/dd/yyyy HH:mm") + "' GROUP by tokenby";
                else
                    select = "select (Select u.UName from unames u where u.UNo=TokenBy) as UserName , COUNT(ID) as TotalTokens,SUM(TokenAmount) as TotalAmount from PatientRegistration    where Convert(date, TokenDate) >='" + fromDate.ToString("MM/dd/yyyy") + "' and Convert(date, TokenDate) <='" + toDate.ToString("MM/dd/yyyy") + "' GROUP by tokenby";
                    
                DataTable dt = new DataTable();
                con = new OleDbConnection();
                readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    da = new OleDbDataAdapter(select, con);
                    da.Fill(ds, ds.Tables[0].TableName);
                }
                return ds;
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


        public DsTokenSummary  GetTokenSummary(DateTime fromDate,DateTime toDate, bool All,bool injection,bool Checkup,bool labtest,bool Medicine, bool rb50, int? uNo)
        {
            DsTokenSummary ds = new DsTokenSummary();
            try
            {                                                                                                       //IIF(ISNULL(CashRecievedByUser),0,CashRecievedByUser)
               

                //string selectCheckup = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount,'' as TestName,TokenAmount as CashRecievedByUser FROM PatientRegistration where TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "'";
                //string selectInjection = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,'' as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM InjectionLabtest Where LabtestID is  null and TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "'";
                //string selectLabTest = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=0 and TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "'";
                //string MedicineQry = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=1 and TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "'";
                //string selectCheckup50 = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount,'' as TestName,IIF((TokenAmount)IS NULL,0,TokenAmount) as CashRecievedByUser FROM PatientRegistration where TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date +
                //                          "' and TokenAmount = 50";
                //string selectInjection50 = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,'' as TestName,IIF((TokenAmount)IS NULL,0,TokenAmount) as CashRecievedByUser FROM InjectionLabtest Where LabtestID is  null and TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "' and TokenAmount = 50";
                //string selectLabTest50 = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((InjectionLabtest.CashRecievedByUser)IS NULL,0,InjectionLabtest.CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=0 and TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "' and TokenAmount = 50";
                //string MedicineQry50 = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((InjectionLabtest.CashRecievedByUser)IS NULL,0,InjectionLabtest.CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=1 and TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "' and TokenAmount = 50";
                //string selectAll50 = selectCheckup50 + " Union ALL " + selectInjection50 + " Union All " + selectLabTest50 + " Union All " + MedicineQry50;  

                if (uNo == 0)
                {
                    selectCheckup = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount,'' as TestName,TokenAmount as CashRecievedByUser FROM PatientRegistration where CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "'";
                    selectInjection = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,'' as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM InjectionLabtest Where LabtestID is  null and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "'";
                    selectLabTest = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=0 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "'";
                    MedicineQry = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=1 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "'";
                    selectCheckup50 = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount,'' as TestName,IIF((TokenAmount)IS NULL,0,TokenAmount) as CashRecievedByUser FROM PatientRegistration where CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") +
                                              "' and TokenAmount = 50";
                    selectInjection50 = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,'' as TestName,IIF((TokenAmount)IS NULL,0,TokenAmount) as CashRecievedByUser FROM InjectionLabtest Where LabtestID is  null and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenAmount = 50";
                    selectLabTest50 = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((InjectionLabtest.CashRecievedByUser)IS NULL,0,InjectionLabtest.CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=0 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenAmount = 50";
                    MedicineQry50 = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((InjectionLabtest.CashRecievedByUser)IS NULL,0,InjectionLabtest.CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=1 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenAmount = 50";
                }
                else
                    if (uNo > 0)
                    {
                        selectCheckup = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount,'' as TestName,TokenAmount as CashRecievedByUser FROM PatientRegistration where CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenBy = " + uNo + "";
                        selectInjection = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,'' as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM InjectionLabtest Where LabtestID is  null and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenBy = " + uNo + "";
                        selectLabTest = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=0 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenBy = " + uNo + "";
                        MedicineQry = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=1 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenBy = " + uNo + "";
                        selectCheckup50 = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount,'' as TestName,IIF((TokenAmount)IS NULL,0,TokenAmount) as CashRecievedByUser FROM PatientRegistration where CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") +
                                                  "' and TokenAmount = 50 and TokenBy = " + uNo + "";
                        selectInjection50 = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,'' as TestName,IIF((TokenAmount)IS NULL,0,TokenAmount) as CashRecievedByUser FROM InjectionLabtest Where LabtestID is  null and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenAmount = 50 and TokenBy = " + uNo + "";
                        selectLabTest50 = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((InjectionLabtest.CashRecievedByUser)IS NULL,0,InjectionLabtest.CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=0 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenAmount = 50 and TokenBy = " + uNo + "";
                        MedicineQry50 = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((InjectionLabtest.CashRecievedByUser)IS NULL,0,InjectionLabtest.CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=1 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenAmount = 50 and TokenBy = " + uNo + "";
                    }
                
                selectAll50 = selectCheckup50 + " Union ALL " + selectInjection50 + " Union All " + selectLabTest50 + " Union All " + MedicineQry50;  
                selectAll = selectCheckup + " Union ALL " + selectInjection + " Union All " + selectLabTest + " Union All " + MedicineQry;  

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

        /// <summary>
        /// Shift Wise Summary a new Shift Parameter is added to Function to get shift Wise Data
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="All"></param>
        /// <param name="injection"></param>
        /// <param name="Checkup"></param>
        /// <param name="labtest"></param>
        /// <param name="Medicine"></param>
        /// <param name="rb50"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        public DsTokenSummary GetTokenSummary(DateTime fromDate, DateTime toDate, bool All, bool injection, bool Checkup, bool labtest, bool Medicine, bool rb50, Shift shift, int? uNo)
        {
            DsTokenSummary ds = new DsTokenSummary();
            try
            {
                shift = new ShiftDAL().GetActiveShiftCode(shift,fromDate);
                //string selectCheckup = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount,'' as TestName FROM PatientRegistration where TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "' and PatientRegistration.Shift=" + shift.ID;
                //string selectInjection = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,'' as TestName FROM InjectionLabtest Where LabtestID is  null and TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "' and InjectionLabtest.Shift=" + shift.ID;
                //string selectLabTest = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=No and TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "' and InjectionLabtest.Shift=" + shift.ID;
                //string MedicineQry = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=True and TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "' and InjectionLabtest.Shift=" + shift.ID;
                //string selectCheckup50 = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount,'' as TestName FROM PatientRegistration where TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date +
                //                          "' and TokenAmount = 50";
                //string selectInjection50 = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,'' as TestName FROM InjectionLabtest Where LabtestID is  null and TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "' and TokenAmount = 50 and InjectionLabtest.Shift=" + shift.ID;
                //string selectLabTest50 = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=No and TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "' and TokenAmount = 50 and InjectionLabtest.Shift=" + shift.ID;
                //string MedicineQry50 = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=True and TokenDate>='" + fromDate.Date + "' and TokenDate<='" + toDate.Date + "' and TokenAmount = 50 and InjectionLabtest.Shift=" + shift.ID;
                //string selectAll50 = selectCheckup50 + " Union ALL " + selectInjection50 + " Union All " + selectLabTest50 + " Union All " + MedicineQry50;
                if (uNo == 0)
                {
                    selectCheckup = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount,'' as TestName,TokenAmount as CashRecievedByUser FROM PatientRegistration where CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and PatientRegistration.Shift=" + shift.ID;
                    selectInjection = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,'' as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM InjectionLabtest Where LabtestID is  null and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "'  and InjectionLabtest.Shift=" + shift.ID;
                    selectLabTest = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=0 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "'  and InjectionLabtest.Shift=" + shift.ID;
                    MedicineQry = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=1 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "'  and InjectionLabtest.Shift=" + shift.ID;
                    selectCheckup50 = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount,'' as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM PatientRegistration where CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") +
                            "' and TokenAmount = 50";
                    selectInjection50 = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,'' as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM InjectionLabtest Where LabtestID is  null and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenAmount = 50  and InjectionLabtest.Shift=" + shift.ID;
                    selectLabTest50 = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=0 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenAmount = 50  and InjectionLabtest.Shift=" + shift.ID;
                    MedicineQry50 = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=1 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenAmount = 50  and InjectionLabtest.Shift=" + shift.ID;
                }
                else
                    if (uNo > 0)
                    {
                        selectCheckup = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount,'' as TestName,TokenAmount as CashRecievedByUser FROM PatientRegistration where CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenBy = " + uNo + " and PatientRegistration.Shift=" + shift.ID;
                        selectInjection = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,'' as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM InjectionLabtest Where LabtestID is  null and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenBy = " + uNo + " and InjectionLabtest.Shift=" + shift.ID;
                        selectLabTest = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=0 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenBy = " + uNo + " and InjectionLabtest.Shift=" + shift.ID;
                        MedicineQry = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=1 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenBy = " + uNo + " and InjectionLabtest.Shift=" + shift.ID;
                        selectCheckup50 = "SELECT   'Checkup' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount,'' as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM PatientRegistration where CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") +
                                "' and TokenAmount = 50 and TokenBy = " + uNo + " ";
                        selectInjection50 = "SELECT  'Injection' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,'' as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM InjectionLabtest Where LabtestID is  null and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenAmount = 50 and TokenBy = " + uNo + " and InjectionLabtest.Shift=" + shift.ID;
                        selectLabTest50 = "SELECT  'LabTest' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0 and LabTest.IsMedicine=0 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenAmount = 50 and TokenBy = " + uNo + " and InjectionLabtest.Shift=" + shift.ID;
                        MedicineQry50 = "SELECT  'Medicines' as TokenType,TokenDate,TokenNumber,PatientFirstName,PatientLastName,PatientNIC,PatientAge,PatientMobile,PatientAddress,TokenAmount ,[Test (A-Z)]  as TestName,IIF((CashRecievedByUser)IS NULL,0,CashRecievedByUser) as CashRecievedByUser FROM LabTest ,InjectionLabtest   where LabTest.ID=InjectionLabtest.LabTestid   and  LabtestID >0  and LabTest.IsMedicine=1 and CONVERT(date, TokenDate) >='" + fromDate.Date.ToString("MM/dd/yyyy") + "' and CONVERT(date, TokenDate) <='" + toDate.Date.ToString("MM/dd/yyyy") + "' and TokenAmount = 50 and TokenBy = " + uNo + " and InjectionLabtest.Shift=" + shift.ID; 
                    }

                
                
                selectAll50 = selectCheckup50 + " Union ALL " + selectInjection50 + " Union All " + selectLabTest50 + " Union All " + MedicineQry50;  
                selectAll = selectCheckup + " Union ALL " + selectInjection + " Union All " + selectLabTest + " Union All " + MedicineQry;

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
                    da.Fill(ds, ds.Tables[0].TableName);

                }



                return ds;
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
