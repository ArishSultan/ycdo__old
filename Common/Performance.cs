using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class Performance
    {
       private int performanceid;
       private string membername;
       private string goodentries;
       private string badentries;
       public DateTime PerformanceDate { get; set; }

      
        //cons////
       public Performance()
       {
         
       }


       public Performance(string membername)
           : this()
       {
           this.membername = membername;
       }
       

       public int PerformanceID
       {
           get { return performanceid; }
           set { performanceid = value; }
       }

       public string MemberName
       {
           get { return membername; }
           set { membername = value; }
       }


       public string GoodEntries
       {
           get { return goodentries; }
           set { goodentries = value; }
       }

       public string BadEntries
       {
           get { return badentries; }
           set { badentries = value; }
       }
    }
}
