namespace Common
{
    using System;
    using System.Collections.Generic;

    public class Customer : Person
    {
        private decimal balance;
        private Address billtoAddress;
        private decimal creditLimit;
        private CustomerDefault customerDefault;
        private string customerPo;
        private string customerType;
        private PriceLevel priceLevel;
        private SalesPerson saleRep;
        private SalesTaxCode saletaxCode;
        private List<ShipAddress> shiptoAddresses;
        private ShipVia shipVia;
        private Term term;

        private string phone1;
        public List<Contact> Contacts { get; set; }

        public Customer()
        {
            this.priceLevel = new PriceLevel();
            this.billtoAddress = new Address();
            this.shiptoAddresses = new List<ShipAddress>();
            this.customerDefault = new CustomerDefault();
            this.saletaxCode = new SalesTaxCode();
            this.saleRep = new SalesPerson();
            this.shipVia = new ShipVia();
            this.term = new Term();
            this.Contacts = new List<Contact>();
        }

        public Customer(string id) : this()
        {
            base.Id = id;
        }

        public Customer(string id, string name) : this()
        {
            base.Id = id;
            base.Name = name;
        }

        public Customer(string id, string name, string customerpo) : this()
        {
            base.Id = id;
            base.Name = name;
            this.customerPo = customerpo;
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;
            if (customer == null)
            {
                return false;
            }
            return (customer.Id == base.Id);
        }

        public override string ToString()
        {
            return base.Id;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public Address BillToAddress
        {
            get
            {
                return this.billtoAddress;
            }
            set
            {
                this.billtoAddress = value;
            }
        }

        public string Phone1
        {
            get { return phone1; }
            set { phone1 = value; }
        }

        public decimal CreditLimit
        {
            get
            {
                return this.creditLimit;
            }
            set
            {
                this.creditLimit = value;
            }
        }

        public CustomerDefault CustomerDefault
        {
            get
            {
                return this.customerDefault;
            }
            set
            {
                this.customerDefault = value;
            }
        }

        public string CustomerPo
        {
            get
            {
                return this.customerPo;
            }
            set
            {
                this.customerPo = value;
            }
        }

        public string CustomerType
        {
            get
            {
                return this.customerType;
            }
            set
            {
                this.customerType = value;
            }
        }

        public PriceLevel PriceLevel
        {
            get
            {
                return this.priceLevel;
            }
            set
            {
                this.priceLevel = value;
            }
        }

        public SalesPerson SaleRep
        {
            get
            {
                return this.saleRep;
            }
            set
            {
                this.saleRep = value;
            }
        }

        public SalesTaxCode SalesTaxCode
        {
            get
            {
                return this.saletaxCode;
            }
            set
            {
                this.saletaxCode = value;
            }
        }

        public List<ShipAddress> ShiptoAddresses
        {
            get
            {
                return this.shiptoAddresses;
            }
            set
            {
                this.shiptoAddresses = value;
            }
        }

        public ShipVia ShipVia
        {
            get
            {
                return this.shipVia;
            }
            set
            {
                this.shipVia = value;
            }
        }

        public Term Term
        {
            get
            {
                return this.term;
            }
            set
            {
                this.term = value;
            }
        }
    }
}

