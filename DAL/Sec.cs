namespace DAL
{
    using Common;
    using OleDbHelper;
    using System;
    using System.Data;
    using System.Data.OleDb;

    public class Sec
    {
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ProjectDetail projectdetail;
        private ReadConfigFile readconfile;
        private OleDbTransaction tran;

        public DataTable GetALLUnRegEnh()
        {
            DataTable dt;
            try
            {
                this.readconfile = new ReadConfigFile();
                string selectCommandText = "";
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.MainConfigFile);
                if (this.con.ConnectionString != "")
                {
                    this.con.Open();
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.dt = new DataTable();
                        selectCommandText = "SELECT EnhCode FROM Enhancements WHERE EnhActivationCode='none'";
                        this.da = new OleDbDataAdapter(selectCommandText, this.con);
                        this.da.Fill(this.dt);
                        this.con.Close();
                        return this.dt;
                    }
                }
                dt = this.dt;
            }
            catch (Exception)
            {
                if (this.con.State != ConnectionState.Closed)
                {
                    this.con.Close();
                }
                throw;
            }
            return dt;
        }

        public bool SaveReg(ProjectDetail prjdet)
        {
            bool flag;
            try
            {
                this.readconfile = new ReadConfigFile();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.MainConfigFile);
                if (this.con.ConnectionString != "")
                {
                    this.con.Open();
                    this.cmd = new OleDbCommand();
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.tran = this.con.BeginTransaction();
                        this.cmd.Connection = this.con;
                        this.cmd.Transaction = this.tran;
                        this.cmd.CommandText = "Update Enhancements Set EnhActivationCode='" + prjdet.Active_code + "'where EnhCode='" + prjdet.ProjectName + "' ";
                        this.cmd.CommandType = CommandType.Text;
                        if (this.cmd.ExecuteNonQuery() == 0)
                        {
                            this.tran.Rollback();
                            this.con.Close();
                            return false;
                        }
                        this.tran.Commit();
                        this.con.Close();
                        return true;
                    }
                }
                flag = false;
            }
            catch (Exception)
            {
                if (this.con.State != ConnectionState.Closed)
                {
                    this.con.Close();
                }
                throw;
            }
            return flag;
        }

        public bool VerifyDBUser()
        {
            bool flag;
            string str = "";
            try
            {
                this.readconfile = new ReadConfigFile();
                this.projectdetail = new ProjectDetail();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.MainConfigFile);
                if (this.con.ConnectionString != "")
                {
                    this.con.Open();
                    this.cmd = new OleDbCommand();
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.cmd.Connection = this.con;
                        this.cmd.CommandText = "Select EnhActivationCode from Enhancements where EnhCode='" + this.projectdetail.ProjectName + "'";
                        this.cmd.CommandType = CommandType.Text;
                        str = Convert.ToString(this.cmd.ExecuteScalar());
                        this.con.Close();
                        if ((str != "") && (str != "none"))
                        {
                            return true;
                        }
                    }
                }
                flag = false;
            }
            catch (Exception)
            {
                if (this.con.State != ConnectionState.Closed)
                {
                    this.con.Close();
                }
                throw;
            }
            return flag;
        }
    }
}

