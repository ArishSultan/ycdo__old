using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using OleDbHelper;
using Common.Datasets;
using Common.Enum;
using System.Data;
using System.Data.OleDb;
namespace DAL
{
    public class MedicinesDAL
    {
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbDataReader dr;
        private OleDbTransaction tran;

        public DSMedicineStatus GetData(LabTest lt,bool all)
        {
            DSMedicineStatus ds = new DSMedicineStatus();
            try
            {
                string select = string.Empty;
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (all == true)
                {
                    select = "select * from (select ID, IssueDate as TransactionDate, IssueNumber as Refrence ,MedicineId,MedicineName,Qty as IssueQty,0 as ReceiveQty, GrossAmount, Netamount,BranchName from IssuedMedicine "
                                       + "Union All"
                                       + " select ID, RecieveDate as TransactionDate, RecievedNumber as Refrence,ItemNumber as MedicineId,ItemName as MedicineName,0 as IssueQty,Qty as ReceiveQty,GrossAmount, NetAmount,'' as BranchName from ReceiveMedicine) temp order by transactiondate ";
                
                }
                else
                {
                 select= "select * from (select ID, IssueDate as TransactionDate, IssueNumber as Refrence ,MedicineId,MedicineName,Qty as IssueQty,0 as ReceiveQty, GrossAmount, Netamount,BranchName from IssuedMedicine "
                                    + "Union All"
                                    + " select ID, RecieveDate as TransactionDate, RecievedNumber as Refrence,ItemNumber as MedicineId,ItemName as MedicineName,0 as IssueQty,Qty as ReceiveQty,GrossAmount, NetAmount,'' as BranchName from ReceiveMedicine) temp where MedicineId=" + lt.LabTestId + " order by transactiondate ";
                }

                if (con.State == ConnectionState.Open)
                {

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

    }
}
