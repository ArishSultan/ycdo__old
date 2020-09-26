using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public  class InjectionLabTest
    {
        public DateTime TokenDate { get; set; }
        public Patient Patient { get; set; }
        public long TokenNumber { get; set; }
        public Room Room { get; set; }
        //public TokenType TokenType { get; set; }
        public double CashReceived { get; set; }
        public double CashReceivedByUser { get; set; }
        public long TokenMonthYear { get; set; }
        public List<LabTest> Tests { get; set; }
        public PatientPayType Type { get; set; }
        public bool IsInjectionToken { get; set; }
        public Int64 ExistingTokenNo { get; set; }
        public Int64 InjectionId { get; set; }
        public List<LabTest> Injections { get; set; }
        public List<LabTest> AssignedLabTest { get; set; }
        public User TokenBy { get; set; }
        public InjectionLabTest()
        {
            this.Patient = new Patient();
            this.Tests = new List<LabTest>();
            this.Room = new Room();
            this.Injections = new List<LabTest>();
            this.AssignedLabTest = new List<LabTest>();
            this.TokenBy = new User();
        }

        public InjectionLabTest(Int64  TokenNo)
            : this()
        {
            this.TokenNumber = TokenNo;
        }

        public InjectionLabTest(Int64 TokenNo,long tokenMonthYear)
            : this()
        {
            this.TokenNumber = TokenNo;
            this.TokenMonthYear = tokenMonthYear;
        }
    }
}
