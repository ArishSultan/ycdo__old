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
       public List<Counsil> GetCounsils(Membership mem)
       {
           return new MembershipDAL().GetCouncils(mem);
       }
       public List<Committe> GetCommitte(Membership mem)
       {
           return new MembershipDAL().GetCommittes(mem);
       }
       public List<Membership> GetMembershipData()
       {
           return new MembershipDAL().GetMembershipData();
       }
       public bool DeleteMembershipData(Membership mem)
       {
           return new MembershipDAL().DeleteMembershipData(mem);
       }

       public DSMembership GetData(Membership mem,bool Branches,bool Cities,bool All,bool bloodGroup,bool counsil,bool committe)
       {
           return new MembershipDAL().GetData(mem, Branches, Cities, All, bloodGroup,counsil,committe);
       }
       public int GetNextMemberShipNo()
       {
           return new MembershipDAL().GetNextMemberNo();
       }
       public List<Membership> GetMembersAndDonors()
       {
           return new MembershipDAL().GetMembersAndDonors();
       }
       public List<Membership> GetMembersCollection(MemberCollection member)
       {
           return new MembershipDAL().GetMembersCollection(member);
       }

       public bool SaveMembershipCollection(MemberCollection mem)
       {
           return new MembershipDAL().SaveMembershipCollection(mem);
       }
       public List<MemberCollection> GetMemberCollectionData()
       {
           return new MembershipDAL().GetMemberCollectionData();
       }


       public bool DeleteMemberCollection(MemberCollection mem)
       {
           return new MembershipDAL().DeleteMemberCollection(mem);
       }

       public DSMemberCollection GetMemberCollectionData(MemberCollection mem,string fromdate,string todate)
       {
           return new MembershipDAL().GetMemberCollectionData(mem,fromdate,todate);
       }
   
   }

}
