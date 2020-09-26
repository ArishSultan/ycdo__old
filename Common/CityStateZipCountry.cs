using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public  class CityStateZipCountry
    {
        private List<String> cities;
        private List<String> states;
        private List<String> zips;
        private List<String> countries;

        public CityStateZipCountry()
        {
            this.countries = new List<string>();
            this.cities = new List<string>();
            this.states = new List<string>();
            this.zips = new List<string>();
        }

        public List<String> Cities
        {
            get { return this.cities; }
            set { this.cities = value; }
        }
        public List<String> States
        {
            get { return this.states; }
            set { this.states = value; }
        }
        public List<String> Zips
        {
            get { return this.zips; }
            set { this.zips = value; }
        }
        public List<String> Countries
        {
            get { return this.countries; }
            set { this.countries = value; }
        }
    }
}
