using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public  class Contact 
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string CompanyName { get; set; }
        public bool IsBillTo { get; set; }
        public bool IsDefaultShipTo { get; set; }
        public DisplayName DisplayName { get; set; }
        public int AttachedAddressNumber { get; set; }

    }
}
