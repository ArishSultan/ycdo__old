namespace BLL.Quotes
{
    using Common;
    using DAL.Quotes;
    using DAL;
    using DAL.UpdateDB;
    using System;
    using System.Collections.Generic;

    //public class QuotesBLL
    //{
    //    public bool DeleteQuote(Quote qt)
    //    {
    //        return new SaveQuoteDAL().DeleteQuote(qt);
    //    }

    //    public AccountPeriods GetAccountingPeriod()
    //    {
    //       // return new AccountingPeriods().GetAccountingPeriods();

    //    }

    //    public List<ChartOfAccount> GetChartofAccounts()
    //    {
    //        return new LocalDBDAL().GetChartofAccounts();
    //    }

    //    public List<CostCode> GetCostCode()
    //    {
    //        return new LocalDBDAL().GetCostCodes();
    //    }

    //    public Customer GetCustomerPriceLevel(Customer cus)
    //    {
    //        return new PriceLevel99DAL().SelectCustomerPriceLevels(cus);
    //    }

    //    public List<Customer> GetCustomers()
    //    {
    //        return new LocalDBDAL().GetCustomers();
    //    }

       

    //    public List<Item> GetItem()
    //    {
    //        return new LocalDBDAL().GetItems();
    //    }

    //    public List<ItemTaxesType> GetItemTaxType()
    //    {
    //        return new LocalDBDAL().GetItemTaxTypes();
    //    }

    //    public List<Job> GetJob()
    //    {
    //        return new LocalDBDAL().GetJobs();
    //    }

    //    public QuoteLineItem GetLineTotal(QuoteLineItem qli)
    //    {
    //        ICalculationPolicy policy = new DefaultCalculationPolicy();
    //        return policy.GetLineItemTotal(qli);
    //    }

    //    public List<Phase> GetPhase()
    //    {
    //        return new LocalDBDAL().GetPhases();
    //    }

    //    public Quote GetQuote(Quote qt)
    //    {
    //        return new EditQuoteDAL().GetQuote(qt);
    //    }

    //    public List<Quote> GetQuoteShortList(DateTime fromdate, DateTime enddate)
    //    {
    //        return new EditQuoteDAL().GetQuotesShortList(fromdate, enddate);
    //    }

    //    public List<SalesPerson> GetSaleRep()
    //    {
    //        return new LocalDBDAL().GetSaleReps();
    //    }

    //    public List<SalesTaxCode> GetSalesTaxCodes()
    //    {
    //        return new LocalDBDAL().GetSalesTaxCodes();
    //    }

    //    public string GetShiptoid(Quote qt)
    //    {
    //        return new QuoteNODAL().GetShiptoid(qt);
    //    }

    //    public List<ShipVia> GetShipVia()
    //    {
    //        return new LocalDBDAL().GetShipVias();
    //    }

    //    public bool QuoteNoAlreadyExist(Quote qt)
    //    {
    //        return new QuoteNODAL().QuoteNoAlreadyExist(qt);
    //    }

    //    public List<Quote> QuoteNoList()
    //    {
    //        return new LocalDBDAL().GetQuoteNumbers();
    //    }

    //    public string[] SaveQuote(Quote qt)
    //    {
    //        return new SaveQuoteDAL().ProcessQuote(qt);
    //    }

    //    public bool SaveQuoteNumber(Quote qt)
    //    {
    //        return new QuoteNODAL().SaveQTnumber(qt);
    //    }

    //    public bool SaveQuotenumbers(List<Quote> qts)
    //    {
    //        return new QuoteNODAL().SaveQuotenumbers(qts);
    //    }

    //    public DateTime SystemDate
    //    {
    //        get
    //        {
    //            return new QuoteNODAL().GetSystemDate();
    //        }
    //    }
    //}
}

