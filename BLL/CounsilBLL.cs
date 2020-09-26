using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;


namespace BLL
{
   public class CounsilBLL
    {
       public bool SaveCounsil(Counsil c)
       {
           return new CounsilDAL().SaveCounsil(c);
       }

       public List<Counsil> GetCounsil()
       {
           return new CounsilDAL().GetCounsil();
       }

       public bool DeleteCounsil(Counsil c)
       {
           return new CounsilDAL().DeleteCounsil(c);
       }
       public List<Counsil> GetMemberCouncil(Membership M)
       {
           return new CounsilDAL().GetMemberCouncil(M);
       }
       public List<Committe> GetMemberCommitte(Membership M)
       {
           return new CounsilDAL().GetMemberCommitte(M);
       }
    }
}
