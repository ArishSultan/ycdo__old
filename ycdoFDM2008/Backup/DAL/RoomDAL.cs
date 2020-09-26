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
    public class RoomDAL
    {
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbDataReader dr;
        private OleDbTransaction tran;
        List<Room> Pcs;
        public bool DeleteRoom(Room Pc)
        {
            try
            {

                string delete = "Delete From Rooms where ID=" + Pc.Number ;
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                cmd = new OleDbCommand(delete, con);
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
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
        public List<Room> GetRooms()
        {
            if (Pcs == null) Pcs = new List<Room>();
            try
            {
                string select = "Select * from Rooms";

                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                cmd = new OleDbCommand(select, con);

                dr = cmd.ExecuteReader();


                //Add Pateint Categories to Collection
                AddRooms();

                con.Close();
                return Pcs;
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

        private  void AddRooms()
        {
            try
            {
                Room newPc;

                while (dr.Read())
                {
                    newPc = new Room(Convert.ToInt32(dr["ID"]), (string)dr["RoomName"],Convert.ToString (dr["LabelName"]), Convert.ToString (dr["RoomType"]));
                    Pcs.Add(newPc);
                }
                dr.Close();
                con.Close();
            }

            catch (Exception ex) { throw ex; }

            finally { dr.Close(); }

        }

        public bool SaveRoom(Room pc)
        {
            try
            {
                int VID = 0;
                con = new OleDbConnection();
                this.readconfile = new ReadConfigFile();
                con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
                con.Open();
                tran = con.BeginTransaction();
                if (pc.Number == 0)
                {

                    string insert = " Insert into Rooms(RoomName,RoomType,LabelName) Values(" + "'" + pc.Name  + "','" + pc.Type + "','"+ pc.LabelName +"' )";
                    cmd = new OleDbCommand(insert, con);
                }
                else
                {
                    string update = "  Update Rooms set RoomName='" + pc.Name + "',RoomType='" + pc.Type + "',LabelName='" + pc.LabelName + "' where ID=" + pc.Number + " ";
                    
                    cmd = new OleDbCommand(update, con);
                }



                cmd.Transaction = tran;
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
    }
}
