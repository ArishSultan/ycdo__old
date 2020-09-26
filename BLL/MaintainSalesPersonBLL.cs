using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;
using DAL.UpdateDB;

namespace BLL
{
    public class MaintainSalesPersonBLL
    {
        public MaintainSalesPersonBLL() { }

        /// <summary>
        /// will give all sales rep saved by calling Update DB method
        /// </summary>
        /// <returns></returns>
        public List<SalesPerson> GetSalesRep()
        {
           // return new LocalDBDAL().GetSalePersonReps();
            return new List<SalesPerson>();
        }
        /// <summary>
        /// give Sales Persons saved by Maintain Screen.
        /// </summary>
        /// <returns></returns>
        public List<SalesPerson> GetSalesPersons()
        {
            return new MaintainSalesPersonDAL().GetSalesPersons();
        }
        public bool SaveSalesPerson(SalesPerson sp)
        {
            return new MaintainSalesPersonDAL().SaveSalesPerson(sp);
        }

        public bool DeleteSalesPerson(SalesPerson sp)
        {

            return new MaintainSalesPersonDAL().DeleteSalesPerson(sp);
        }

        public List<ChartOfAccount> GetIncomeAccounts()
        {
           // return new LocalDBDAL().GetIncomeAccounts();
            return new List<ChartOfAccount>();
        }
    }
}
