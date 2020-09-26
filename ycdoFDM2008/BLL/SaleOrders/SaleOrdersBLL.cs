namespace BLL.SaleOrders
{
    using Common;
    using DAL.SaleOrders;
    using DAL.UpdateDB;
    using DAL;
    using System;
    using System.Collections.Generic;
    //using DAL.Items;

    //public class SaleOrdersBLL
    //{
    //    public bool SaveSaleOrderLastPeriod(UserPreference up)
    //    {
    //        return new UserPreferenceDAL().SaveSaleOrderLastPeriod(up);
    //    }

    //    public UserPreference GetSaleOrderLastPeriod()
    //    {
    //        return new UserPreferenceDAL().GetSaleOrderLastPeriod();
    //    }
    //    public string GetMasterStockDescription(Item itm)
    //    {
    //        return new LocalDBDAL().GetMasterStockDescription(itm);
    //    }

    //    public List<AttributeLineItem> GetSecondaryAttributes(Item itm)
    //    {
    //        return new LocalDBDAL().GetSecondaryAttributes(itm);
    //    }

    //    public CityStateZipCountry GetCitySTZipCountry()
    //    {
    //        return new LocalDBDAL().GetCitySTZipCountry();
    //    }


    //    public bool DeleteSaleOrder(SaleOrder so)
    //    {
    //        return new SaveSaleOrderDAL().DeleteSaleOrder(so);
    //    }

    //    public AccountPeriods GetAccountingPeriod()
    //    {
    //        return new AccountingPeriods().GetAccountingPeriods();
    //    }

    //    public List<ChartOfAccount> GetChartofAccounts()
    //    {
    //        return new LocalDBDAL().GetChartofAccounts();
    //    }

    //    public List<CostCode> GetCostCodes()
    //    {
    //        return new LocalDBDAL().GetCostCodes();
    //    }

    //    public Customer GetCustomerPriceLevel(Customer cus)
    //    {
    //        return new CustomerDAL().SelectCustomerPriceLevels(cus);
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
    //        return new ItemTaxTypeDAL().GetItemTaxType();
    //    }

    //    public List<Job> GetJobs()
    //    {
    //        return new LocalDBDAL().GetJobs();
    //    }

    //    public SaleOrderlineItem GetLineTotal(SaleOrderlineItem soli)
    //    {
    //        ICalculationPolicy policy = new ExtendedPriceCalculation ();
    //        return policy.GetLineItemTotal(soli);
    //    }

    //    public List<Phase> GetPhases()
    //    {
    //        return new LocalDBDAL().GetPhases();
    //    }

    //    public decimal GetQtyOnhand(Item it)
    //    {
    //        return new ItemsDAL().GetQTYonHand(it);
    //    }

    //    public SaleOrder GetSaleOrder(SaleOrder so)
    //    {
    //        return new EditSaleOrderDAL().GetSaleOrder(so);
    //    }

    //    public SaleOrder GetSaleOrderfromDB(SaleOrder so)
    //    {
    //        return new SaleOrderDBDAL().GetSaleOrder(so);
    //    }

    //    public String GetShiptoid(SaleOrder so)
    //    {
    //        return new SaleOrderNODAL().GetShiptoid(so);
    //    }

    //    public string GetSaleOrderNumber()
    //    {
    //        return new SaleOrderNODAL().GetSOnumber();
    //    }

    //    public List<SaleOrder> GetSaleOrderShortList(DateTime startdate, DateTime enddate)
    //    {
    //        return new EditSaleOrderDAL().GetSaleOrderShortList(startdate, enddate);
    //    }

    //    public List<SalesPerson> GetSaleRep()
    //    {
    //        return new LocalDBDAL().GetSaleReps();
    //    }

    //    public List<SalesTaxCode> GetSalesTaxCodes()
    //    {
    //        return new LocalDBDAL().GetSalesTaxCodes();
    //    }

    //    public List<ShipVia> GetShipVia()
    //    {
    //        return new LocalDBDAL().GetShipVias();
    //    }

    //    public bool HasSOShip(ref SaleOrder so)
    //    {
    //        return new EditSaleOrderDAL().HasSOShip(ref so);
    //    }

    //    public string[] SaveSaleOrder(SaleOrder so)
    //    {
    //        return new SaveSaleOrderDAL().ProcessSaleOrder(so);
    //    }

    //    public bool SaveSaleOrderNumber(SaleOrder so, bool isedit)
    //    {
    //        return new SaleOrderNODAL().SaveSOnumber(so, isedit);
    //    }

    //    public DateTime SystemDate
    //    {
    //        get
    //        {
    //            return new SaleOrderNODAL().GetSystemDate();
    //        }
    //    }
    //}
}

