namespace Common
{
    using System;

    public class ShipAddress : Address
    {
        private string companyGuid;
        private string companyName;
        private string salesTax;
        private int shipId;
        private int srNo;

        public ShipAddress()
        {
        }

        public ShipAddress(Address address) : this()
        {
            base.ShipToID = address.ShipToID;
            base.AddressLine1 = address.AddressLine1;
            base.AddressLine2 = address.AddressLine2;
            base.City = address.City;
            base.Country = address.Country;
            base.Receipent = address.Receipent;
            base.State = address.State;
            base.Zip = address.Zip;
        }

        public ShipAddress(int shipID, int srno, string salesTaxCode)
        {
            this.shipId = shipID;
            this.srNo = srno;
            this.salesTax = salesTaxCode;
        }

        public string CompanyGuid
        {
            get
            {
                return this.companyGuid;
            }
            set
            {
                this.companyGuid = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                this.companyName = value;
            }
        }

        public string SalesTax
        {
            get
            {
                return this.salesTax;
            }
            set
            {
                this.salesTax = value;
            }
        }

        public int ShipId
        {
            get
            {
                return this.shipId;
            }
            set
            {
                this.shipId = value;
            }
        }

        public int SrNo
        {
            get
            {
                return this.srNo;
            }
            set
            {
                this.srNo = value;
            }
        }
    }
}

