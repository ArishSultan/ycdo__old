using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class Committe
    {
       private int committeid;
       private string committename;


      
        //cons////
       public Committe()
       {
       
       }


       public Committe(string committename ):this()
       { 
       this.committename=committename;
       }
       

       public int CommitteID
       {
           get { return committeid; }
           set { committeid = value; }
       }

       public string CommitteName
       {
           get { return committename; }
           set { committename = value; }
       }
       public override bool Equals(object obj)
       {
           Committe cm = obj as Committe;
           if (cm == null) return false;

           return cm.CommitteID == this.CommitteID;
       }
    }
}
