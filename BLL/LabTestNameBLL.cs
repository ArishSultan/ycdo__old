using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;


namespace BLL
{
   public class LabTestNameBLL
    {
       public bool SaveLabtestname(LabTestName c)
       {
           return new LabTestNameDAL().SaveLabtestname(c);
       }
       public int GetNextLabTestId()
       {
           return new LabTestNameDAL().GetNextLabTestID();
       }
       public List<LabTestName> GetLAbTestName()
       {
           return new LabTestNameDAL().GetLabTestNames();
       }

       public bool DeleteLabtestName(LabTestName c)
       {
           return new LabTestNameDAL().DeleteLabtestName(c) ;
       }
    }
}
