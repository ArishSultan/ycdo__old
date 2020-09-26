using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class Category
    {
       private int categoryid;
       private string categoryname;


      
        //cons////
       public Category()
       {
       
       }


       public Category(string CategoryName)
           : this()
       {
           this.categoryname = CategoryName;
       }
       

       public int CategoryID
       {
           get { return categoryid; }
           set { categoryid = value; }
       }

       public string CategoryName
       {
           get { return categoryname; }
           set { categoryname = value; }
       }

    }
}
