﻿using System;
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
        public long TokenMonthYear { get; set; }
        public List<LabTest> Tests { get; set; }
        public PatientPayType Type { get; set; }
        public bool IsInjectionToken { get; set; }
        public Int64 ExistingTokenNo { get; set; }

        public InjectionLabTest()
        {
            this.Patient = new Patient();
            this.Tests = new List<LabTest>();
            this.Room = new Room();

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
