namespace BLL
{
    using Common;
 
    using DAL;
    using System;
    using System.Collections.Generic;
    using System.Data;

    public class ShipToBLL
    {
        public List<Customer> GetCustomersOnly()
        {
            //return new CustomerDAL().GetCustomersOnly();
            return new List<Customer>();
        }

        public List<Customer> GetCustomersShiptos()
        {
            //return new CustomerDAL().GetCustomersShiptos();
            return new List<Customer>();
        }

        public List<SalesTaxCode> GetSalesTaxCodes()
        {
            //return new SalesTaxCodeDAL().GetSalesTaxCodes();
            return new List<SalesTaxCode>();
        }

        public DataTable GetShipAdress(Customer cus)
        {
            //return new ShipToDAL().GetShipToAdress(cus);
            return new DataTable();
        }

        public bool SaveShiptoAddress(Customer cus)
        {
            //return new ShipToDAL().SaveShiptoAddress(cus);
            return false;
        }
    }
}

