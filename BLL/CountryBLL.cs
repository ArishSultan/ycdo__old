using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;


namespace BLL
{
   public class CountryBLL
    {
       public bool SaveCountry(Country c)
       {
           return new CountryDAL().SaveCountry(c);
       }

       public List<Country> GetCountry()
       {
           return new CountryDAL().GetCountry();
       }

       public bool DeleteCountry(Country c)
       {
           return new CountryDAL().DeleteCountry(c);
       }
    }
}
