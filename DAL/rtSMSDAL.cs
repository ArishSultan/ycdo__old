using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.IO;
using System.Web;
using Common;
using System.Data.OleDb;
using OleDbHelper;
using System.Data;




namespace DAL
{
   internal class rtSMSDAL
    {
        private OleDbCommand cmd;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        private ReadConfigFile readconfile;
        private OleDbDataReader dr;
        private OleDbTransaction tran;


       public string SendSMS(string username, string password, string no, string from, string message)
       {
           try
           {
               HttpWebRequest myReq = (HttpWebRequest)System.Net.WebRequest.Create("http://lifetimesms.com/api.php?username=" + username + "&password=" + password + "&to=" + no + "&from=" + from + "&message=" + message);
               HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
               StreamReader respStreamReader = new StreamReader(myResp.GetResponseStream());
               string responseString = respStreamReader.ReadToEnd();
               respStreamReader.Close();
               myResp.Close();
               return responseString;
           }
           catch (WebException wex)
           {
               throw wex;
           }
       }
       public bool SaveAndSendSMS(MemberCollection mc)
       {
           
          
             string username =  "Emran";
            string password = "MonaKiran11";
            string no = mc.Member.Phone;
            string from =  "AAMPOWER";
       
            string msg = "Dear Member "+mc.Member.MemberName+" ! \n Your Collection @("+mc.CollectionFee.ToString("00,000")+")ReciptNo "+mc.ReciptNo+" of Month "+mc.CollectionMonth+" has been Collected AT YCDO \n Thanks for your Kind Co-operation";
           try
           {
                   string smsID=SendSMS(username,password,no,from,msg);
               string insert;
              

                  insert = "insert into SMSOUT (Sender,Reciever,Message,Status,Dated,SendDate,MemberID,CollectionID,SMSID)" +
                       "values('" + from + "','" + no + "','" + msg + "','Collected','" + mc.CollectionMonth + "','" + mc.CollectionDate + "'," + mc.Member.MID + "," + mc.ID + ",'" + smsID + "')";


               con = new OleDbConnection();
               this.readconfile = new ReadConfigFile();
               con.ConnectionString = this.readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
               con.Open();
               tran = con.BeginTransaction();
               cmd = new OleDbCommand(insert, con);
               cmd.Transaction = tran;
               cmd.ExecuteNonQuery();
               tran.Commit();
               return true;
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
