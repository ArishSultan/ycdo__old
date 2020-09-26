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
   public  class UserRightDAL
      
    {

        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbDataReader dr;
        private OleDbTransaction tran;


        public UserRightDAL() { }


        public bool SaveUserRights(List<UserRight> userRights)
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
                foreach (UserRight item in userRights)
                {
                    if (item.RightId > 0)
                    {
                        cmd.CommandText = "Update UserRight set CanAccess=" + Convert.ToInt16(item.CanAccess) + " where RightID=" + item.RightId;
                        
                    }
                    else
                    {
                        cmd.CommandText = "Insert into  UserRight (UserID,ScreenId,CanAccess) Values(" + userRights[0].User.Userno + "," + item.Screen.ScreenId + "," + Convert.ToInt16(item.CanAccess) + ")";

                    }
                    cmd.ExecuteNonQuery();
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


        public List<UserRight> GetUserRights(User user)
        {
            List<UserRight> userRights = new List<UserRight>();
            try
            {
                //string select = "Select ScreenName,ScreenCatalog.ScreenID,UserId,RightID,CanAccess from UserRight right outer join ScreenCatalog on UserRight.ScreenId =ScreenCatalog.ScreenId where UserID=" + user.Userno;

                //string allSelect = "Select ScreenName,ScreenCatalog.ScreenID,0 as UserId,0 as RightID,false as CanAccess from ScreenCatalog ";
                string select = "Select ScreenName,ScreenCatalog.ScreenID,UserId,RightID,CanAccess from UserRight inner join ScreenCatalog on UserRight.ScreenId =ScreenCatalog.ScreenId  where UserRight.UserID=" + user.Userno
                    + "  Union "
                    + "Select ScreenName,ScreenCatalog.ScreenID,0 as UserId,0 as RightID,0 as CanAccess from ScreenCatalog  "
                    + " where ScreenID not in   ( Select  ScreenID  from UserRight  where UserRight.UserID=" + user.Userno + ") order by ScreenID";

                string allSelect = "Select ScreenName,ScreenCatalog.ScreenID,0 as UserId,0 as RightID,0 as CanAccess from ScreenCatalog Order By ScreenID";
                DataTable dt = new DataTable();
                con = new OleDbConnection();
                readconfile = new ReadConfigFile();
                con.ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    da = new OleDbDataAdapter(select, con);
                    da.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        da = new OleDbDataAdapter(allSelect, con);
                        da.Fill(dt);
                    }

                }

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        UserRight userRight = new UserRight();

                        userRight.Screen.ScreenId = Convert.ToInt32(row["ScreenId"] == DBNull.Value ? 0 : row["ScreenId"]);
                        userRight.Screen.ScreenName = Convert.ToString(row["ScreenName"] == DBNull.Value ? "" : row["ScreenName"]);
                        userRight.User.Userno = Convert.ToInt32(row["UserID"] == DBNull.Value ? 0 : row["UserID"]);
                        userRight.RightId = Convert.ToInt32(row["RightID"] == DBNull.Value ? 0 : row["RightID"]);
                        userRight.CanAccess = Convert.ToBoolean(row["CanAccess"] == DBNull.Value ? false : row["CanAccess"]);


                        userRights.Add(userRight);
                    }
                }


                return userRights;
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
