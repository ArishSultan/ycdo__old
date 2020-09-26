using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class PatientCategory
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public double DiscountPercentage { get; set; }
        public PatientCategory() { }

        public PatientCategory(int categoryid, string categoryname, double discountpercentage)
        {
            this.CategoryID = categoryid;
            this.CategoryName = categoryname;
            this.DiscountPercentage = discountpercentage;
        }

        public override string ToString()
        {
            return this.CategoryName + " - Disc = " + this.DiscountPercentage.ToString() + "%";
        }

    }
}
