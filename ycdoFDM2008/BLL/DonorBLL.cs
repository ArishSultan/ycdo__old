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

       public DSDonor GetData(Donor d, bool Branches, bool Cities, bool All)

       {
           return new DonorDAL().GetData(d, Branches, Cities, All);
       }
    }
}
