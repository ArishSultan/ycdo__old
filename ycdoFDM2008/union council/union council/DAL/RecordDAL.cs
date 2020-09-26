using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using union_council.Classes;

namespace union_council.DAL
{
    public class RecordDAL
    {

        string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UC.db.accdb;Persist Security Info=False;";

        internal bool Save(Record record)
        {
            OleDbConnection con = new OleDbConnection(ConnectionString);
            con.Open();


            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select count(CNIC) from Records where CNIC='"+record.CNIC+"'";
            int x;
            try 
	{	        
		 x = Convert.ToInt32(cmd.ExecuteScalar());
	}
	catch (Exception)
	{
	x=0;
	}

            if (x == 0)
            {
                cmd.CommandText = "insert into records(SerialNumber,HouseNumber,OName,GuardianName,CNIC,Age,Address,SCode) values(" + record.SerailNumber + "," + record.HouseNumber + ",'" + record.Name + "','" + record.GuardianName + "','" + record.CNIC + "'," + record.Age + ",'" + record.Address + "',"+record.ShumariyatCode+")";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else 
            {
                con.Close();
                return new DAL.RecordDAL().Update(record);
            
            }
            return true;
        }

        internal bool Update(Record record)
        {
            OleDbConnection con = new OleDbConnection(ConnectionString);
            con.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "update records set SerialNumber="+record.SerailNumber+" , HouseNumber="+record.HouseNumber+" ,OName='"+record.Name+"' , GuardianName='"+record.GuardianName+"',Age="+record.Age+" , Address='"+record.Address+"' , SCode="+record.ShumariyatCode+" where CNIC='"+record.CNIC+"'";
       
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }

        internal bool Delete(Record record)
        {
            OleDbConnection con = new OleDbConnection(ConnectionString);
            con.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from Records where CNIC='" + record.CNIC + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }

        internal Record GetUser(Record record)
        {
            OleDbConnection con = new OleDbConnection(ConnectionString);
            con.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Records where CNIC='" + record.CNIC + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                record.Address = reader["Address"].ToString();
                record.Age = Convert.ToInt32(reader["Age"]);
           //     record.AutoNumber = Convert.ToInt32(reader["AutoNumber"]);
                record.GuardianName = reader["GuardianName"].ToString();
                record.HouseNumber = Convert.ToInt32(reader["HouseNumber"]);
                record.Name = reader["OName"].ToString();
                record.SerailNumber = Convert.ToInt32(reader["SerialNumber"]);
                record.ShumariyatCode = reader["SCode"].ToString();
            
            }
            con.Close();

            return record;
        }

        internal DataSets.dsAll FillReport()
        {
            OleDbConnection con = new OleDbConnection(ConnectionString);
            con.Open();

            OleDbDataAdapter da = new OleDbDataAdapter("select * from Records",con);
            DataSets.dsAll ds = new DataSets.dsAll();
            da.Fill(ds.Tables["Records"]);
            con.Close();

            return ds;
        }
    }
}
