using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Common.Datasets;
using DAL;

namespace BLL
{
   public  class DonorBLL
   {
       public bool SaveDonorData(Donor d)
       {
           return new DonorDAL().SaveDonorData(d);
       }

       public List<Donor> GetDonorData()
       {
           return new DonorDAL().GetDonorData();
       }
       public bool DeleteDonorData(Donor d)
       {
           return new DonorDAL().DeleteDonorsData(d);
       }

       public DSDonor GetData(Donor d, bool Branches, bool Cities, bool All,bool Donationtype,string fromdate,string todate,bool datewise)

       {
           return new DonorDAL().GetData(d, Branches, Cities, All,Donationtype,fromdate,todate,datewise);
       }
       public List<Donor> GetDonationType()
       {
           return new DonorDAL().GetDonationType();
       }

       public List<Membership> GetFee(Membership m,bool donor,bool member)
       {
           return new DonorDAL().GetFee(m,donor,member);
       }

       public bool SaveDonorCollection(DonorCollection mem)
       {
           return new DonorDAL().SaveDonorCollection(mem);
       }

       public List<DonorCollection> GetDonorCollectionData()
       {
           return new DonorDAL().GetDonorCollectionData();
       }
       public bool DeleteDonorCollection(DonorCollection mem)
       {
           return new DonorDAL().DeleteDonorCollection(mem);
       }
       public DSDonorCollection GetDonorCollectionData(DonorCollection d,string Fromdate,string Todate,bool All)
       {
           return new DonorDAL().GetDonorCollectionData(d,Fromdate,Todate,All);
       }
       public DSDonorAndMemberCollection GetDonorAndMemberCollection(Donor d, bool All, bool Donationtype, string fromdate, string todate)
       {
           return new DonorDAL().GetDonorAndMemberCollection(d,All,Donationtype,fromdate,todate);
       }
       public DSRefrenceCollection GetRefrenceCollection(bool rbDonor, bool rbMember, Donor d, Membership m, string fromdate, string todate)
       {
           return new DonorDAL().GetRefrenceCollection(rbDonor,rbMember,d,m,fromdate,todate);
       }
    }
}
