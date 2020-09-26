namespace Common
{
    using System;

    public class Address
    {
        private string addressLine1;
        private string addressLine2;
        private string city;
        private string country;
        private string email;
        private string fax;
        private string phone;
        private string receipent;
        private string shipToID;
        private string state;
        private string zip;

        public Address()
        {
        }

        public Address(string addressline1, string addressline2, string city, string state, string zip, string country) : this()
        {
            this.addressLine1 = addressline1;
            this.addressLine2 = addressline2;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.country = country;
        }

        public Address(string receipent, string addressline1, string addressline2, string city, string state, string zip, string country) : this()
        {
            this.receipent = receipent;
            this.addressLine1 = addressline1;
            this.addressLine2 = addressline2;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.country = country;
        }

        public Address(string shipToID, string receipent, string addressline1, string addressline2, string city, string state, string zip, string country) : this()
        {
            this.shipToID = shipToID;
            this.receipent = receipent;
            this.addressLine1 = addressline1;
            this.addressLine2 = addressline2;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.country = country;
        }

        public string AddressLine1
        {
            get
            {
                return this.addressLine1;
            }
            set
            {
                this.addressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return this.addressLine2;
            }
            set
            {
                this.addressLine2 = value;
            }
        }

        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }

        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                this.country = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string Fax
        {
            get
            {
                return this.fax;
            }
            set
            {
                this.fax = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }

        public string Receipent
        {
            get
            {
                return this.receipent;
            }
            set
            {
                this.receipent = value;
            }
        }

        public string ShipToID
        {
            get
            {
                return this.shipToID;
            }
            set
            {
                this.shipToID = value;
            }
        }

        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        public string Zip
        {
            get
            {
                return this.zip;
            }
            set
            {
                this.zip = value;
            }
        }
    }
}

