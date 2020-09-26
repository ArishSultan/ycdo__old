using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Common.Datasets;
using DAL;

namespace BLL
{
   public  class MembershipBLL
   {
       public bool SaveMembersData(Membership mem)
       {
           return new MembershipDAL().SaveMembershipData(mem);
       }

       public List<Membership> GetMembershipData()
       {
           return new MembershipDAL().GetMembershipData();
       }
       public bool DeleteMembershipData(Membership mem)
       {
           return new MembershipDAL().DeleteMembershipData(mem);
       }

       public DSMembership GetData(Membership mem,bool Branches,bool Cities,bool All)
       {
           return new MembershipDAL().GetData(mem ,Branches,Cities,All);
       }
    }
}
