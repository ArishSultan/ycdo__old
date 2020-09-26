using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;
using Common.Datasets;
using System.Data;

namespace BLL
{
   public  class BranchBLL
    {
       public bool SaveBranch(Branch br)
       {
           return new BranchesDAL().SaveBranches(br);
       }

       public List<Branch> GetBranchData()
           {
               return new BranchesDAL().GetBranchData();
           }

       public bool DeleteBranch(Branch br)
       {
           return new BranchesDAL().DeleteBranch(br);
       }

       public DSBranches GetData(Branch br)
       {
           return new BranchesDAL().GetData(br);
       }
    }
}
