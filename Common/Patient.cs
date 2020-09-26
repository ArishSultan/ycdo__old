using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Patient
    {
        public string RegistrationNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NIC { get; set; }
        public Int16 Age { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string PatientType { get; set; }
        public string Member { get; set; }
    }
}
