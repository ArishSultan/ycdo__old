using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;


namespace BLL
{
   public class CommitteBLL
    {
       public bool SaveCommitte(Committe c)
       {
           return new CommitteDAL().SaveCommitte(c);
       }

       public List<Committe> GetCommitte()
       {
           return new CommitteDAL().GetCommitte();
       }

       public bool DeleteCommitte(Committe c)
       {
           return new CommitteDAL().DeleteCommitte(c);
       }
    }
}
