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
        public PatientRegistration()
        {
            this.Patient = new Patient();
            this.Room = new Room();
        }
        public PatientRegistration(long tokenNumber, long tokenMonthYear)
            : this()
        {
            this.TokenNumber = tokenNumber;
            this.TokenMonthYear = tokenMonthYear;
        }
    }
}
