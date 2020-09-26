using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;


namespace BLL
{
   public class CityBLL
    {
       public bool SaveCity(City c)
       {
           return new CityDAL().SaveCity(c);
       }

       public List<City> GetCity()
       {
           return new CityDAL().GetCity();
       }

       public bool DeleteCity(City c)
       {
           return new CityDAL().DeleteCity(c);
       }
    }
}
