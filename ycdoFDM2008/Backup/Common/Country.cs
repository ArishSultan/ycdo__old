﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class Country
    {
       private int countryid;
       private string countryname;


      
        //cons////
       public Country()
       {
       
       }


       public Country(string countryname ):this()
       {
           this.countryname = countryname;
       }
       

       public int CountryID
       {
           get { return countryid; }
           set { countryid = value; }
       }

       public string CountryName
       {
           get { return countryname; }
           set { countryname = value; }
       }

    }
}