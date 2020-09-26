namespace BLL.SaleInvoices
{
    using System;
    using System.Data;
    using System.ComponentModel;
    using System.Collections.Generic;
    
    using Common;
    using DAL.SaleInvoices;
    using DAL;
    using DAL.UpdateDB;
    //using DAL.Items;
    

    //public class SaleInvoiceBLL
    //{

    //    public bool SaveSaleInvoiceLastPeriod(UserPreference up)
    //    {
    //        return new UserPreferenceDAL().SaveSaleInvoiceLastPeriod(up);
    //    }

    //    public UserPreference GetSaleInvoiceLastPeriod()
    //    {
    //        return new UserPreferenceDAL().GetSaleInvoiceLastPeriod();
    //    }


    //    public CityStateZipCountry  GetCitySTZipCountry()
    //    {
    //        return new LocalDBDAL().GetCitySTZipCountry();
    //    }

       
    //    public bool DeleteSaleInvoice(SaleInvoice sai)
    //    {
    //        return new SaveSaleInvoiceDAL().DeleteSaleInvoice(sai);
    //    }

    //    public AccountPeriods GetAccountingPeriod()
    //    {
    //        return new AccountingPeriods().GetAccountingPeriods();
    //    }

    //    public List<ChartOfAccount> GetChartofAccounts()
    //    {
    //        return new LocalDBDAL().GetChartofAccounts();
    //    }

    //    public List<CostCode> GetCostCode()
    //    {
    //        return new LocalDBDAL().GetCostCodes();
    //    }

    //    public List<SaleOrder> GetCusSaleOrder(Customer cus)
    //    {
    //        return new SaleOrderDAL().GetOpenSaleOrder(cus);
    //    }

    //    public List<SaleOrder> GetOpenSaleOrderNumbers(Customer cus)
    //    {
    //        return new SaleOrderDAL().GetOpenSaleOrderNumbers(cus);
    //    }

    //    public SaleOrder GetOpenSaleOrder(SaleOrder so, Customer cus)
    //    {
    //        return new SaleOrderDAL().GetOpenSaleOrder(so, cus);
    //    }

    //    public SaleOrder GetOriginalSaleOrder(SaleOrder so, Customer cus)
    //    {
    //        return new SaleOrderDAL().GetOriginalSaleOrder (so, cus);
    //    }
        

    //    public Customer GetCustomer(Customer cus)
    //    {
    //        return new CustomerDAL().GetCustomer(cus);
    //    }

    //    public Customer GetCustomerPriceLevel(Customer cus)
    //    {
    //        return new PriceLevel99DAL().SelectCustomerPriceLevels(cus);
    //    }

    //    public List<Customer> GetCustomers()
    //    {
    //        return new LocalDBDAL().GetCustomers();
    //    }

       

    //    public List<Item> GetItems()
    //    {
    //        return new LocalDBDAL().GetItems();
    //    }

    //    public string GetMasterStockDescription(Item itm)
    //    {
    //        return new LocalDBDAL().GetMasterStockDescription(itm);
    //    }
    //    public List<AttributeLineItem  > GetSecondaryAttributes(Item itm)
    //    {
    //        return new LocalDBDAL().GetSecondaryAttributes(itm);
    //    }


    //    public List<Item> GetNonStockItems()
    //    {
    //        return new LocalDBDAL().GetNonStockItems();
    //    }
    //    public Item GetItemPriceLevel(Item itm)
    //    {
    //        return new PriceLevel99DAL().Select99PriceLevel(itm);
    //    }

    //    public List<ItemTaxesType> GetItemTaxType()
    //    {
    //        return new LocalDBDAL().GetItemTaxTypes();
    //    }

    //    public List<Job> GetJob()
    //    {
    //        return new LocalDBDAL().GetJobs();
    //    }

    //    public SaleInvoiceLineItem GetLineTotal(SaleInvoiceLineItem siLi)
    //    {
    //        ICalculationPolicy policy = new ExtendedPriceCalculation ();
    //        return policy.GetLineItemTotal(siLi);
    //    }

    //    public List<Phase> GetPhase()
    //    {
    //        return new LocalDBDAL().GetPhases();
    //    }

    //    public decimal GetQtyOnhand(Item it)
    //    {
    //        return new ItemsDAL().GetQTYonHand(it);
    //    }

    //    public SaleInvoice GetSaleInvoice(SaleInvoice si)
    //    {
    //        return new EditSaleInvoiceDAL().GetSaleInvoice(si);
    //    }

    //    public List<SaleInvoice> GetSaleInvShipewithSaleOrder(SaleOrder so)
    //    {
    //        return new EditSaleInvoiceDAL().GetSaleInvShipedWithSaleOrder(so);
    //    }

    //    public List<SaleInvoice> GetSaleInvShortList(DateTime startdate, DateTime enddate)
    //    {
    //        return new EditSaleInvoiceDAL().GetSaleInvShortList(startdate, enddate);
    //    }

    //    public SaleOrder GetSaleOrder(SaleInvoice so)
    //    {
    //        return new SaleOrderDAL().GetSaleOrder(so);
    //    }

    //    public List<SalesPerson> GetSaleRep()
    //    {
    //        return new LocalDBDAL().GetSaleReps();
    //    }

    //    public List<SalesTaxCode> GetSalesTaxCodes()
    //    {
    //        return new LocalDBDAL().GetSalesTaxCodes();
    //    }

    //    public string GetShiptoid(SaleInvoice SI)
    //    {
    //        return new SaleInvoiceNODAL().GetShiptoid(SI);
    //    }

    //    public string GetShiptoid(SaleOrder SO)
    //    {
    //        return new SaleOrderNODAL().GetShiptoid(SO);
    //    }

    //    public List<ShipVia> GetShipVia()
    //    {
    //        return new LocalDBDAL().GetShipVias();
    //    }

     

    //    public bool HasSaleInvPaid(ref SaleInvoice si)
    //    {
    //        return new EditSaleInvoiceDAL().SaleInvHasRecept(ref si);
    //    }

    //    public bool SalInvNoAlreadyExist(SaleInvoice si)
    //    {
    //        return new SaleInvoiceNODAL().SalInvNoAlreadyExist(si);
    //    }

    //    public bool SaveQtyonHands(List<SaleInvoiceLineItem> Items)
    //    {
    //        return new ItemsDAL().SaveQtyonHands(Items);
    //    }

    //    public string[] SaveSaleInvoice(SaleInvoice si)
    //    {
    //        return new SaveSaleInvoiceDAL().ProcessSaleInvoice(si);
    //    }

    //    public bool SaveSaleInvoiceNumber(SaleInvoice si)
    //    {
    //        return new SaleInvoiceNODAL().SaveSInumber(si);
    //    }

    //    public DateTime SystemDate
    //    {
    //        get
    //        {
    //            return new SaleInvoiceNODAL().GetSystemDate();
    //        }
    //    }
    //}
}

