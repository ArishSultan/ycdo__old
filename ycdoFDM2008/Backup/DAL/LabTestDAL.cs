using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Common;
using System.Data.OleDb;
using System.Data;
using OleDbHelper;
using Common.Datasets;
namespace DAL
{
    public class LabTestDAL
    {

        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbDataReader dr;
        private OleDbTransaction tran;


        public LabTestDAL() { }
        public LabTest GetSyring()
        {
            LabTest syring = new LabTest();
            try
            {
                string select = "Select * from Syring where ID=1";
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
                     
                        syring.TestName = Convert.ToString(row["SyringeName"] == DBNull.Value ? "" : row["SyringeName"]);
                        syring.LabTestId = Convert.ToInt32(row["SyringeCode"] == DBNull.Value ? 0 : row["SyringeCode"]);
                    }
                }
                return syring;
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
        #region Faheem Work
        public List<LabTest> GetLabTest()
        {
            List<LabTest> labTests = new List<LabTest>();
            try
            {
                string select = "Select * from LabTest where IsMedicine=No";
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
                        LabTest labTest = new LabTest();
                        labTest.TestName = Convert.ToString(row["Test (A-Z)"] == DBNull.Value ? "" : row["Test (A-Z)"]);
                        labTest.SampleName = Convert.ToString(row["Sample"] == DBNull.Value ? "" : row["Sample"]);
                        labTest.Performed = Convert.ToString(row["Performed"] == DBNull.Value ? "" : row["Performed"]);
                        labTest.LabTestId = Convert.ToInt32(row["ID"]);
                        labTest.Report = Convert.ToString(row["Report"] == DBNull.Value ? "" : row["Report"]);
                        labTest.Deserving = Convert.ToDecimal(row["Deserving"] == DBNull.Value ? 0 : row["Deserving"]);
                        labTest.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                        labTest.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                        labTest.General = Convert.ToDecimal(row["Generall"] == DBNull.Value ? 0 : row["Generall"]);
                        labTest.Shahab = Convert.ToDecimal(row["Shahab"] == DBNull.Value ? 0 : row["Shahab"]);
                        labTest.Ghori = Convert.ToDecimal(row["Ghori"] == DBNull.Value ? 0 : row["Ghori"]);
                        labTests.Add(labTest);
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
        public List<LabTest> GetMedicines()
        {
            List<LabTest> labTests = new List<LabTest>();
            try
            {
                string select = "Select * from LabTest where IsMedicine=Yes";
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
                        LabTest labTest = new LabTest();
                        labTest.TestName = Convert.ToString(row["Test (A-Z)"] == DBNull.Value ? "" : row["Test (A-Z)"]);
                        labTest.SampleName = Convert.ToString(row["Sample"] == DBNull.Value ? "" : row["Sample"]);
                        labTest.Performed = Convert.ToString(row["Performed"] == DBNull.Value ? "" : row["Performed"]);
                        labTest.LabTestId = Convert.ToInt32(row["ID"]);
                        labTest.Report = Convert.ToString(row["Report"] == DBNull.Value ? "" : row["Report"]);
                        labTest.IsMedicine = Convert.ToBoolean(row["IsMedicine"]);
                        labTest.IsRsTenInjection = Convert.ToBoolean(row["IsRsTenInjection"]);
                        labTest.Deserving = Convert.ToDecimal(row["Deserving"] == DBNull.Value ? 0 : row["Deserving"]);
                        labTest.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                        labTest.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                        labTest.General = Convert.ToDecimal(row["Generall"] == DBNull.Value ? 0 : row["Generall"]);
                        labTest.Shahab = Convert.ToDecimal(row["Shahab"] == DBNull.Value ? 0 : row["Shahab"]);
                        labTest.Ghori = Convert.ToDecimal(row["Ghori"] == DBNull.Value ? 0 : row["Ghori"]);
                        labTest.IsOd = Convert.ToBoolean(row["IsOd"]);
                        labTests.Add(labTest);
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
        #endregion
        public long GetNextReceiptNumber()
        {
            try
            {
                string select = "select max(RecievedNumber) from ReceiveMedicine";
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
        public bool SaveRecieveMedicine(RecieveMedicine rm)
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
                cmd.CommandText = "delete from ReceiveMedicine where RecievedNumber=" + rm.RecieveNumber;
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
                        cmdSave.CommandText = "Insert into ReceiveMedicine(RecieveDate,RecievedNumber,ItemNumber,ItemName,Qty,Price,GrossAmount,NetAmount) values (#" +
                                             rm.RecieveDate + "#," + rm.RecieveNumber + "," + item.LineItem.LabTestId + ",'" +
                                             item.LineItem.TestName + "'," + item.Quantity + "," + item.Price + "," + item.GrossAmount + "," + rm.RefRec.NetAmount + ")";
                    }
                    cmdSave.ExecuteNonQuery();

                }
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
        public DSIssueBill.DTIssueBillDataTable PrintRecMedBill(RecieveMedicine Obj)
        {
            DSIssueBill.DTIssueBillDataTable dt = new DSIssueBill.DTIssueBillDataTable();
            try
            {


                string Qry = "select RecievedNumber as IssueNumber,RecieveDate as IssueDate,ItemName as MedicineName,Qty as Quantity,lt.PurchasePrice as Price,GrossAmount,NetAmount from ReceiveMedicine,LabTest lt" +
                             " where lt.ID=ReceiveMedicine.ItemNumber and ReceiveMedicine.RecievedNumber=" + Obj.RecieveNumber;
                //string Qry2 = "select RecievedNumber,RecieveDate,ItemName as MedicineName,Qty as Quantity,lt.RetailPrice as Price,GrossAmount,NetAmount from ReceiveMedicine,LabTest lt"+
                //             " where lt.ID=ReceiveMedicine.ItemNumber and ReceiveMedicine.RecievedNumber=" + Obj.RecieveNumber;

                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (con.State == ConnectionState.Open)
                {

                    //if (Retail == true)
                    //    da = new OleDbDataAdapter(Qry2, con);
                  //  else if (Purchase == true)
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
        public List<RecieveMedicine> GetRecieveMedicines()
        {
            List<RecieveMedicine> LoRec = new List<RecieveMedicine>();
            try
            {
                string select = "Select * from ReceiveMedicine";
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
                        ObjRec.RefRec.LineItem.LabTestId = Convert.ToInt32(row["ItemNumber"]);
                        ObjRec.RefRec.LineItem.TestName = row["ItemName"].ToString();
                        ObjRec.RefRec.LineItem.MedIssuedID = Convert.ToInt32(row["ID"]);
                        ObjRec.RefRec.Quantity = Convert.ToDecimal(row["Qty"]);
                        ObjRec.RecieveDate = Convert.ToDateTime(row["RecieveDate"]);
                        ObjRec.RecieveNumber = Convert.ToInt64(row["RecievedNumber"]);
                        ObjRec.RefRec.Price = row["Price"] == DBNull.Value ? 0 : Convert.ToDouble(row["Price"]);
                        ObjRec.RefRec.GrossAmount = row["GrossAmount"] == DBNull.Value ? 0 : Convert.ToDouble(row["GrossAmount"]);
                        ObjRec.RefRec.NetAmount = row["NetAmount"] == DBNull.Value ? 0 : Convert.ToDouble(row["NetAmount"]);
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
        public List<RecieveMedicine> GetRecieveMedicines(string RecieveNumber)
        {
            List<RecieveMedicine> LoRec = new List<RecieveMedicine>();
            try
            {
                string select = "Select * from ReceiveMedicine where RecievedNumber=" + RecieveNumber;
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
                        ObjRec.RefRec.LineItem.LabTestId = Convert.ToInt32(row["ItemNumber"]);
                        ObjRec.RefRec.LineItem.TestName = row["ItemName"].ToString();
                        //ObjRec.RefRec.LineItem.MedIssuedID = Convert.ToInt32(row["ID"]);
                        ObjRec.RefRec.Quantity = Convert.ToDecimal(row["Qty"]);
                        //ObjRec.RecieveDate = Convert.ToDateTime(row["RecieveDate"]);
                        //ObjRec.RecieveNumber = Convert.ToInt64(row["RecievedNumber"]);
                        ObjRec.RefRec.Price = row["Price"] == DBNull.Value ? 0 : Convert.ToDouble(row["Price"]);
                        ObjRec.RefRec.GrossAmount = row["GrossAmount"] == DBNull.Value ? 0 : Convert.ToDouble(row["GrossAmount"]);
                        ObjRec.RefRec.NetAmount = row["NetAmount"] == DBNull.Value ? 0 : Convert.ToDouble(row["NetAmount"]);
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
        public DSMedicinesIssuedAndReceived GetItemLedger(DateTime From, DateTime To, string Name)
        {
            DSMedicinesIssuedAndReceived ds = new DSMedicinesIssuedAndReceived();
            try
            {

                string Qry = "";

                // Qry = "SELECT RecieveDate,ItemName,Qty from ReceiveMedicine where   RecieveDate >=#" + fromdate + "#  and  RecieveDate <=#" + todate + "# and Qty >0";

                Qry = "select RecieveDate as [Date],RecievedNumber as RefrenceNo,ItemNumber,ItemName,TotalRecieved,TotalConsumed, (TotalRecieved-TotalConsumed) as NetQty from ( " +

               " SELECT  RecieveDate,RecievedNumber, ItemNumber,ItemName, 0 as TotalRecieved,sum(Qty) as TotalConsumed from QryOutStockLatest" +
               " where RecieveDate>=#" + From + "# and  RecieveDate<=#" + To + "# and ItemName='" + Name +
               "' group by  RecieveDate,RecievedNumber,ItemNumber,ItemName" +
               " union all" +
            " select  RecieveDate,RecievedNumber,ItemNumber,ItemName,sum(Qty) as TotalReceived,0 as TotalConsumed from QryInStockLatest" +
             " where RecieveDate>=#" + From + "# and  RecieveDate<=#" + To + "# and ItemName='" + Name +
         "' group by  RecieveDate,RecievedNumber,ItemNumber,ItemName) as Final";  



                // Qry = "SELECT RecieveDate,ItemName,Qty from ReceiveMedicine where   RecieveDate >=#" + fromdate + "#  and  RecieveDate <=#" + todate + "# and Qty >0";

                string Qry2 = "select RecieveDate as [Date],RecievedNumber,ItemNumber,ItemName,TotalRecieved,TotalConsumed, (TotalRecieved-TotalConsumed) as NetQty from (" +

           " SELECT  RecieveDate,RecievedNumber, ItemNumber,ItemName, 0 as TotalRecieved,sum(Qty) as TotalConsumed from QryOutStockLatest" +

           " group by  RecieveDate,RecievedNumber,ItemNumber,ItemName" +
           " union all" +
        " select  RecieveDate,RecievedNumber,ItemNumber,ItemName,sum(Qty) as TotalReceived,0 as TotalConsumed from QryInStockLatest" +

     " group by  RecieveDate,RecievedNumber,ItemNumber,ItemName) as Final";



                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string select = "";
                    if (Name == "")
                    {
                        select = Qry2;
                    }
                    else
                    {

                        select = Qry;
                    }
                    da = new OleDbDataAdapter(select, con);
                    da.Fill(ds, ds.Tables[0].TableName);

                }


                return ds;
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
        public DSCurrentStockWithValue.dtCurrentStockWithValueDataTable GetCurrentStockWithValue(bool LabTest,bool Medicine,bool All)
        {
            DSCurrentStockWithValue.dtCurrentStockWithValueDataTable dt = new DSCurrentStockWithValue.dtCurrentStockWithValueDataTable();
            try
            {
                string select = "";
                if (All == true)
                    select = "Select * from QryCurrentStockWithValue";
                else if (Medicine == true)
                    select = "Select * from QryCurrentStockWithValueWithoutLabTest";
                else if (LabTest == true)
                select = "Select * from QryCurrentStockWithValueLabTest";
                con = new OleDbConnection();
                readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    da = new OleDbDataAdapter(select, con);
                    da.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public bool DeleteReceiveMedicine(int ReceiveNumber)
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



                cmd.CommandText = "delete from ReceiveMedicine where RecievedNumber=" + ReceiveNumber;
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
        public bool SaveSyring(LabTest syring)
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
                cmd.CommandText = "Update Syring set SyringeCode=" + syring.LabTestId + ",SyringeName='" + syring.TestName + "' where ID=1";
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
        public bool SaveLabTests(List<LabTest> labTests)
        {
            try
            {
                int VID = 0;
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();

                cmd = new OleDbCommand("",con );
                //cmd.Connection = con;
                cmd.Transaction = tran;
                //cmd.CommandType = CommandType.Text;
                foreach (LabTest item in labTests)
                {
                    if (item.LabTestId > 0)
                    {
                        cmd.CommandText = "Update LabTest set [Test (A-Z)]='" + item.TestName + "', Sample='" + item.SampleName + "', Performed='" + item.Performed + "', Report='" + item.Report + "', Poor=" + item.Poor + ", YCDO=" + item.YCDO + ", Generall=" + item.General + ",OpeningQty=" + item.OpeningQty + ",Unit ='" + item.Unit + "' where ID=" + item.LabTestId;
                        cmd.ExecuteNonQuery();
                    }
                }

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

        public DsCurrentStock.CurrentStockDataTable GetCurrentStock(bool LabTestnMedicine, bool WithoutLabTest,bool LabTest)
        {
            DsCurrentStock.CurrentStockDataTable  dt = new DsCurrentStock.CurrentStockDataTable ();
            try
            { string select="";
            if (LabTestnMedicine == true)
                select = "Select * from QryCurrentStockWithIM";
                else if (WithoutLabTest == true)
                select = "Select * from QryCurrentStockWithoutLabTest";
                else if (LabTest == true)
                select = "Select * from QryCurrentStockLabTest";
                con = new OleDbConnection();
                readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    da = new OleDbDataAdapter(select, con);
                    da.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public DSIssuedMedPur.dtIssuedMedPurDataTable GetIssuedMedPur(bool All,bool Purchase,bool Retail,LabTest MedID,DateTime From,DateTime To )
        {
          
            DSIssuedMedPur.dtIssuedMedPurDataTable dt = new DSIssuedMedPur.dtIssuedMedPurDataTable();
            try
            {
                string Pur = "select ilt.TokenDate as IssueDate, ilt.LabTestID as MedicineID,lt.[Test (A-Z)]  as MedicineName,lt.PurchasePrice as PurchasePrice,'' as BranchName,ilt.DosePerDay*ilt.Days as Quantity from InjectionLabTest ilt,LabTest lt where ilt.LabTestID=lt.ID and lt.ID=" + MedID.LabTestId +
                               " and ilt.TokenDate>=#"+From+"# and ilt.TokenDate<=#"+To+"#  union all" +
                                " select mi.TokenDate as IsssueDate,mi.ID as MedicineID,lt.[Test (A-Z)] as MedicineName,lt.PurchasePrice as PurchasePrice,'' as BranchName,mi.DosePerDay as Quantity  from MedicineIssued mi,LabTest lt where mi.ID=lt.ID and mi.MedicinesIssued=True and" +
                               " lt.ID=" + MedID.LabTestId +
                                " and mi.TokenDate>=#"+From+"# and mi.TokenDate<=#"+To+"# union all " +
                              " select im.IssueDate as IssueDate,im.MedicineID as MedicineID,im.MedicineName,lt.PurchasePrice as PurchasePrice,im.BranchName as BranchName,im.Qty as Quantity from IssuedMedicine im,LabTest lt where im.MedicineID=lt.ID and lt.ID=" + MedID.LabTestId+
                              "and im.Issuedate>=#"+From+"# and im.Issuedate<=#"+To+"#";
                //string PurAll = "select ilt.TokenDate as IssueDate, ilt.LabTestID as MedicineID,lt.[Test (A-Z)]  as MedicineName,lt.PurchasePrice as Price,ilt.DosePerDay*ilt.Days as Quantity from InjectionLabTest ilt,LabTest lt where ilt.LabTestID=lt.ID "+
                //              "  union all" +
                //               " select mi.TokenDate as IsssueDate,mi.ID as MedicineID,lt.[Test (A-Z)] as MedicineName,lt.PurchasePrice as Price,mi.DosePerDay as Quantity  from MedicineIssued mi,LabTest lt where mi.ID=lt.ID and mi.MedicinesIssued=True" +
                //               " union all " +
                //             " select im.IssueDate as IssueDate,im.MedicineID as MedicineID,im.MedicineName,lt.PurchasePrice as Price,im.Qty as Quantity from IssuedMedicine im,LabTest lt where im.MedicineID=lt.ID";
                string Ret = "select ilt.TokenDate as IssueDate, ilt.LabTestID as MedicineID,lt.[Test (A-Z)]  as MedicineName,lt.RetailPrice as RetailPrice,'' as BranchName,ilt.DosePerDay*ilt.Days as Quantity from InjectionLabTest ilt,LabTest lt where ilt.LabTestID=lt.ID and lt.ID=" + MedID.LabTestId +
                " and ilt.TokenDate>=#" + From + "# and ilt.TokenDate<=#" + To + "# union all" +
                " select mi.TokenDate as IssueDate, mi.ID as MedicineID,lt.[Test (A-Z)] as MedicineName,lt.RetailPrice as RetailPrice,''as BranchName,mi.DosePerDay as Quantity  from MedicineIssued mi,LabTest lt where mi.ID=lt.ID and mi.MedicinesIssued=True and" +
                " lt.ID=" + MedID.LabTestId +
               " and mi.TokenDate>=#" + From + "# and mi.TokenDate<=#" + To + "# union all" +
              " select im.IssueDate as IssueDate,im.MedicineID as MedicineID,im.MedicineName,lt.RetailPrice as RetailPrice,im.Branchname as BranchName,im.Qty as Quantity from IssuedMedicine im,LabTest lt where im.MedicineID=lt.ID and lt.ID=" + MedID.LabTestId+
              " and im.Issuedate>=#"+From+"# and im.Issuedate<=#"+To+"#";
            //    string RetAll = "select ilt.TokenDate as IssueDate, ilt.LabTestID as MedicineID,lt.[Test (A-Z)]  as MedicineName,lt.RetailPrice as Price,ilt.DosePerDay*ilt.Days as Quantity from InjectionLabTest ilt,LabTest lt where ilt.LabTestID=lt.ID"+
            //  " union all" +
            //  " select mi.TokenDate as IssueDate, mi.ID as MedicineID,lt.[Test (A-Z)] as MedicineName,lt.RetailPrice as Price,mi.DosePerDay as Quantity  from MedicineIssued mi,LabTest lt where mi.ID=lt.ID and mi.MedicinesIssued=True" +
            // " union all" +
            //" select im.IssueDate as IssueDate,im.MedicineID as MedicineID,im.MedicineName,lt.RetailPrice as Price,im.Qty as Quantity from IssuedMedicine im,LabTest lt where im.MedicineID=lt.ID";
                string all = "select ilt.TokenDate as IssueDate,ilt.LabTestID as MedicineID,lt.[Test (A-Z)]  as MedicineName,lt.PurchasePrice as PurchasePrice,lt.RetailPrice as RetailPrice,'' as Branchname,ilt.DosePerDay*ilt.Days as Quantity  from InjectionLabTest ilt,LabTest lt where ilt.LabTestID=lt.ID " +
               " and ilt.TokenDate>=#" + From + "# and ilt.TokenDate<=#" + To + "# union all" +
               " select mi.TokenDate as IssueDate, mi.ID as MedicineID,lt.[Test (A-Z)] as MedicineName,lt.PurchasePrice as PurchasePrice,lt.RetailPrice as RetailPrice,'' as Branchname,mi.DosePerDay as Quantity  from MedicineIssued mi,LabTest lt where mi.ID=lt.ID and mi.MedicinesIssued=True" +
              " and mi.Tokendate>=#" + From + "# and mi.TokenDate<=#" + To + "# union all" +
             " select im.IssueDate as IssueDate,im.MedicineID as MedicineID,im.MedicineName,lt.PurchasePrice as PurchasePrice,lt.RetailPrice as RetailPrice,im.BranchName as Branchname,im.Qty as Quantity from IssuedMedicine im,LabTest lt where im.MedicineID=lt.ID"+
             " and im.IssueDate>=#" + From + "# and im.IssueDate<=#" + To + "#";

                con = new OleDbConnection();
                readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    if(Purchase==true)
                    da = new OleDbDataAdapter(Pur, con);
                    else if(Retail==true)
                        da = new OleDbDataAdapter(Ret, con);
                    //else if(Purchase==true&&All==true)
                    //    da = new OleDbDataAdapter(PurAll, con);
                    //else if (Retail== true && All == true)
                    //    da = new OleDbDataAdapter(RetAll, con);
                      //  da = new OleDbDataAdapter(all, con);
                    else if (All == true)
                        da = new OleDbDataAdapter(all, con);
                    da.Fill(dt);
                   

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public List<LabTest> GetLabTests()
        {
            List<LabTest> labTests  = new List<LabTest>();
            try
            {
                string select = "Select * from LabTest";
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
                        LabTest labTest = new LabTest();
                        labTest.TestName = Convert.ToString(row["Test (A-Z)"] == DBNull.Value ? "" : row["Test (A-Z)"]);
                        labTest.SampleName = Convert.ToString(row["Sample"] == DBNull.Value ? "" : row["Sample"]);
                        labTest.Performed = Convert.ToString(row["Performed"] == DBNull.Value ? "" : row["Performed"]);
                        labTest.LabTestId = Convert.ToInt32(row["ID"]);
                        labTest.Report = Convert.ToString(row["Report"] == DBNull.Value ? "" : row["Report"]);

                        labTest.Deserving = Convert.ToDecimal(row["Deserving"] == DBNull.Value ? 0 : row["Deserving"]);
                        labTest.Poor = Convert.ToDecimal(row["Poor"] == DBNull.Value ? 0 : row["Poor"]);
                        labTest.YCDO = Convert.ToDecimal(row["YCDO"] == DBNull.Value ? 0 : row["YCDO"]);
                        labTest.General = Convert.ToDecimal(row["Generall"] == DBNull.Value ? 0 : row["Generall"]);
                        labTest.Shahab = Convert.ToDecimal(row["Shahab"] == DBNull.Value ? 0 : row["Shahab"]);
                        labTest.Ghori = Convert.ToDecimal(row["Ghori"] == DBNull.Value ? 0 : row["Ghori"]);
                        labTest.Unit = row["Unit"].ToString();
                        labTest.OpeningQty =  Convert.ToDecimal(row["OpeningQty"] == DBNull.Value ? 0.0 : row["OpeningQty"]);
                        labTest.IsAlwaysPaid = Convert.ToBoolean(row["IsAlwaysPaid"]);
                        labTest.IsMedicine = Convert.ToBoolean(row["IsMedicine"]);
                        labTest.IsRsTenInjection = Convert.ToBoolean(row["IsRsTenInjection"]);
                        labTest.Price = row["PurchasePrice"] == DBNull.Value ? 0 : Convert.ToDouble(row["PurchasePrice"]);
                        labTest.RetailPrice = row["RetailPrice"] == DBNull.Value ? 0 : Convert.ToDouble(row["RetailPrice"]);
                        labTest.IsOd = Convert.ToBoolean(row["IsOd"]);
                        labTests.Add(labTest);
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
        public DSMedicines GetListOfMed()
        {

            DSMedicines ds = new DSMedicines();
            try
            {
                
                con = new OleDbConnection();
                readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                string Pur = "select lt.ID as MedicineID, lt.[Test (A-Z)] as  MedicineName from LabTest lt where lt.IsMedicine=Yes";
                if (con.State == ConnectionState.Open)
                {
                    
                    da = new OleDbDataAdapter(Pur, con);
             
                    da.Fill(ds,ds.Tables[0].TableName);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

    }
}
