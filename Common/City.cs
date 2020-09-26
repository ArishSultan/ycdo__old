using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class City
    {
       private int cityid;
       private string cityname;


      
        //cons////
       public City()
       {
       
       }


       public City(string cityname ):this()
       { 
       this.cityname=cityname;
       }
       

       public int CityID
       {
           get { return cityid; }
           set { cityid = value; }
       }

       public string CityName
       {
           get { return cityname; }
           set { cityname = value; }
       }

    }
}
