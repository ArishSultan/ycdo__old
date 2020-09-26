namespace Common
{
    using System;

    public class CompanyInformation
    {
        private Address address;
        private string companyName;

        public CompanyInformation()
        {
            this.address = new Address();
        }

        public CompanyInformation(string name, string addres1, string addres2, string city, string state, string zip, string country, string phone, string fax, string email) : this()
        {
            this.address.AddressLine1 = addres1;
            this.address.AddressLine2 = addres2;
            this.address.City = city;
            this.address.Country = country;
            this.address.Email = email;
            this.address.Fax = fax;
            this.address.Phone = phone;
            this.address.State = state;
            this.address.Zip = zip;
            this.companyName = name;
        }

        public Address Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
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
    }
}

