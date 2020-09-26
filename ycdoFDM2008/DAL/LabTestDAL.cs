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
                        cmd.CommandText = "Update LabTest set [Test (A-Z)]='" + item.TestName + "', Sample='" + item.SampleName + "', Performed='" + item.Performed + "', Report='" + item.Report + "', Poor=" + item.Poor + ", YCDO=" + item.YCDO + ", [General]=" + item.General + " where ID=" + item.LabTestId;
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
                        labTest.General = Convert.ToDecimal(row["General"] == DBNull.Value ? 0 : row["General"]);
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

    }
}
