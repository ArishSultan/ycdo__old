using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Common.Datasets;
using DAL;


namespace BLL
{
   public class PerformanceBLL
    {
       public bool SavePerformance(Performance c)
       {
           return new PerformanceDAL().SavePerformance(c);
       }

       public List<Performance> GetPerformance()
       {
           return new PerformanceDAL().GetPerformance();
       }

       public bool DeletePerformance(Performance c)
       {
           return new PerformanceDAL().DeletePerformance(c);
       }

       //public DSMemberProgress get(Performance p, string fromdate, string todate)
       //{ 
       
       //}
    }
}
