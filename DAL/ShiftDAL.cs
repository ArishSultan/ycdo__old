using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OleDbHelper;
using System.Data.OleDb;
using Common;
using System.Data;

namespace DAL
{
   public class ShiftDAL
    {

       private ReadConfigFile readconfile;
        public List<Common.Shift> GetShifts()
        {
            OleDbConnection con = new OleDbConnection();


            this.readconfile = new ReadConfigFile();
            con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            string q = "select * from Shifts";
            con.Open();
            OleDbCommand cmd = new OleDbCommand(q, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Shift> shifts = new List<Shift>();
         
            while (reader.Read())
            {
                Shift shift = new Shift((int)reader["ID"], reader["ShiftName"].ToString(), (bool)reader["Status"]);
                shifts.Add(shift);

            
            }
            reader.Close();
            con.Close();
            return shifts;
        }

        public Shift GetActiveShift()
        {
            OleDbConnection con = new OleDbConnection();
            this.readconfile = new ReadConfigFile();
            con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            string q = "select * from Shifts where Status=1";
            con.Open();
            OleDbCommand cmd = new OleDbCommand(q, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            Shift shift = null;
            while (reader.Read())
            {
                shift = new Shift((int)reader["ID"], reader["ShiftName"].ToString(), (bool)reader["Status"]);


            }
            reader.Close();
            con.Close();
            return shift;
        }
        public Shift GetActiveShiftCode()
        {
            OleDbConnection con = new OleDbConnection();
            this.readconfile = new ReadConfigFile();
            con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            string q = "select sl.ID as ID, s.ShiftName as ShiftName, s.Status as Status from ShiftLog sl,Shifts s where s.ID=sl.ShiftChangeTo and s.Status=1 and sl.ShiftChangeTo="+new ShiftDAL().GetActiveShift().ID+" and sl.ChangeDate='"+DateTime.Now.Date.ToString("MM/dd/yyyy")+"'";
            con.Open();
   
            OleDbDataAdapter da=new OleDbDataAdapter(q,con);
            DataTable tb=new DataTable();
            da.Fill(tb);
            Shift shift = null;
            if (tb.Rows.Count > 0)
            {
                shift = new Shift((int)tb.Rows[0]["ID"], tb.Rows[0]["ShiftName"].ToString(), (bool)tb.Rows[0]["Status"]);


            }
            else 
            {
                 q = "select sl.ID as ID, s.ShiftName as ShiftName, s.Status as Status from ShiftLog sl,Shifts s where s.ID=sl.ShiftChangeTo  and sl.ShiftChangeTo=" + new ShiftDAL().GetActiveShift().ID + " and sl.ChangeDate='" + DateTime.Now.Date.AddDays(-1).ToString("MM/dd/yyyy") + "'";
                tb = new DataTable();
                 da = new OleDbDataAdapter(q, con);
            da.Fill(tb);
            shift = new Shift((int)tb.Rows[0]["ID"], tb.Rows[0]["ShiftName"].ToString(), (bool)tb.Rows[0]["Status"]);

            }
            con.Close();
            return shift;
        }
        public Shift GetActiveShiftCode(Shift shift ,DateTime date)
        {
            OleDbConnection con = new OleDbConnection();
            this.readconfile = new ReadConfigFile();
            con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            string q = "select sl.ID as ID, s.ShiftName as ShiftName, s.Status as Status from ShiftLog sl,Shifts s where s.ID=sl.ShiftChangeTo  and sl.ShiftChangeTo=" + shift.ID + " and sl.ChangeDate='" + date.Date.ToString("MM/dd/yyyy") + "'";
            con.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(q, con);
            DataTable tb = new DataTable();
            da.Fill(tb);
      
            if (tb.Rows.Count > 0)
            {
                shift = new Shift((int)tb.Rows[0]["ID"], tb.Rows[0]["ShiftName"].ToString(), (bool)tb.Rows[0]["Status"]);


            }
            
            con.Close();
            return shift;
        }
        public bool SetActiveShift(Shift shift)
        {
            OleDbConnection con = new OleDbConnection();
            this.readconfile = new ReadConfigFile();
            con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            string qq="Update Shifts set Status=0";
            string q = "update Shifts set Status=1 where ID=" + shift.ID; 
            con.Open();
             
            
            OleDbCommand cmd = new OleDbCommand(qq, con);
            cmd.ExecuteNonQuery();
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();

       
            con.Close();
            return true;
        }
        public bool ShiftCanChange(Shift shift)
        {
            OleDbConnection con = new OleDbConnection();
            this.readconfile = new ReadConfigFile();
            con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            string q = "Select Count(*) From  ShiftLog where ShiftChangeTo=" + shift.ID + " and ChangeDate='" + DateTime.Now.Date.ToString("MM/dd/yyyy") + "'";
            con.Open();
            

            OleDbCommand cmd = new OleDbCommand(q, con);
            string value = cmd.ExecuteScalar().ToString();
            cmd.ExecuteNonQuery();
            con.Close();

            if (value == "")
            {
                return true;
            }
            else
            {
                int c = Convert.ToInt32(value);
                if (c > 0)
                {
                    return false;
                }
                else if(c==0)
                {
                    return true;
                }
            }

            return true;
       

      }
        public bool SetActiveShift(Shift shift, User LoginUser)
        {
            
            string qp="insert into ShiftLog (ShiftChangeFrom,ShiftChangeTo,ChangeDate,ChangeTime,ChangeBy) values("+new ShiftDAL().GetActiveShift().ID+","+shift.ID+",'"+DateTime.Now.Date.ToString("MM/dd/yyyy")+"','"+DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")+"',"+LoginUser.Userno+")";
            
            
            OleDbConnection con = new OleDbConnection();
            this.readconfile = new ReadConfigFile();



            con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            string qq = "Update Shifts set Status=0";
            string q = "update Shifts set Status=1 where ID=" + shift.ID;
            con.Open();


            OleDbCommand cmd = new OleDbCommand(qq, con);
            cmd.ExecuteNonQuery();
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
            cmd.CommandText = qp;
            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }

        public Shift GetShiftStartEndTime(Shift shift,DateTime date)
        {

            //string qp = "select ShiftChangeFrom,ShiftChangeTo,ChangeDate,ChangeTime,ChangeBy From ShiftLog where ShiftChangeTo=" + shift.ID + " and ChangeDate='" + date.Date + "'";                      ///////// Asif - 27-05-19
            string qp = "select ShiftChangeFrom,ShiftChangeTo,ChangeDate,ChangeTime,ChangeBy From ShiftLog where ShiftChangeTo=" + shift.ID + " and ChangeDate='" + date.Date.ToString("MM/dd/yyyy") + "'";

            OleDbConnection con = new OleDbConnection();
            this.readconfile = new ReadConfigFile();

            con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            con.Open();


            OleDbCommand cmd = new OleDbCommand(qp, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                shift.ChangeDateTime = Convert.ToDateTime(reader["ChangeTime"]);
            
            
            }
           
          
            con.Close();
            return shift;
        }

        
    }
}
