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

        public DsTokenSummary GetTokenSummary(DateTime fromDate, DateTime toDate, bool All, bool injection, bool checkup, bool labtest,bool Medicine ,bool rb50)
        {
            return new TokenSummaryDAL().GetTokenSummary(fromDate,toDate, All ,injection ,checkup ,labtest,Medicine,rb50 );
        }

    }
}
