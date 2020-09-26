using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class Counsil
    {
       private int counsilid;
       private string counsilname;


      
        //cons////
       public Counsil()
       {
       
       }


       public Counsil(string counsilname ):this()
       { 
       this.counsilname=counsilname;
       }
       

       public int CounsilID
       {
           get { return counsilid; }
           set { counsilid = value; }
       }

       public string CounsilName
       {
           get { return counsilname; }
           set { counsilname = value; }
       }
       public override bool Equals(object obj)
       {
           Counsil cl = obj as Counsil;
           if (cl == null) return false;

           return cl.CounsilID == this.CounsilID;
       }
    }
}
