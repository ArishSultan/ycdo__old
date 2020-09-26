using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class PatientRegistration
    {
        public DateTime TokenDate { get; set; }
        public Patient Patient { get; set; }
        public long TokenNumber { get; set; }
        public Room Room { get; set; }
        public TokenType TokenType { get; set; }
        public double CashReceived { get; set; }
        public long TokenMonthYear { get; set; }
        public string PatientRegistrationNumber{get{return this.Patient.RegistrationNumber;}}
        public string PatientFirstName{ get { return this.Patient.FirstName; } }
        public List<LabTest> LabTests;
        
        public PatientRegistration()
        {
            this.Patient = new Patient();
            this.Room = new Room();
            this.LabTests = new List<LabTest>();
        }
        public PatientRegistration(long tokenNumber, long tokenMonthYear)
            : this()
        {
            this.TokenNumber = tokenNumber;
            this.TokenMonthYear = tokenMonthYear;
        }
    }
}
