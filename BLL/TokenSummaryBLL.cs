using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Common.Datasets ;
using DAL;
namespace BLL
{
    public  class TokenSummaryBLL
    {
        public TokenSummaryBLL() { }

        public DsTokenSummary GetTokenSummary(DateTime fromDate, DateTime toDate, bool All, bool injection, bool checkup, bool labtest,bool Medicine ,bool rb50, int? uNo)
        {
            return new TokenSummaryDAL().GetTokenSummary(fromDate, toDate, All, injection, checkup, labtest, Medicine, rb50, uNo);
        }
        public DsTokenSummary GetTokenSummary(DateTime fromDate, DateTime toDate, bool All, bool injection, bool checkup, bool labtest, bool Medicine, bool rb50, Shift shift, int? uNo)
        {
            return new TokenSummaryDAL().GetTokenSummary(fromDate, toDate, All, injection, checkup, labtest, Medicine, rb50, shift, uNo);
        }
        //public DSTTokenSummryUserWise GetTokenSummaryUserWise(DateTime fromDate, DateTime toDate)
        //{
        //    return new TokenSummaryDAL().GetTokenSummaryUserWise(fromDate, toDate);      
        //}
        public DSTTokenSummryUserWise GetTokenSummaryUserWise(DateTime fromDate, DateTime toDate, Boolean isTime)
        {
            return new TokenSummaryDAL().GetTokenSummaryUserWise(fromDate, toDate, isTime);
        }

    }
}
