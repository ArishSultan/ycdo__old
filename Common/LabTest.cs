using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public  class LabTest
    {
        public LabTest() { TimesADay = 1; TotalDays = 1; }
        public LabTest(int TestId) : this() { this.LabTestId = TestId; }

        public LabTest(int TestId, string TestName):this(TestId)
        {
            this.TestName = TestName;
        }
        public LabTest(int TestId, string TestName, int timesaday, int totaldays)
        {
            this.LabTestId = TestId;
            this.TestName = TestName;
            this.TimesADay = timesaday;
            this.TotalDays = totaldays;
        }
        public LabTest(int TestId, string TestName, int timesaday, int totaldays, bool ismedicine)
        {
            this.LabTestId = TestId;
            this.TestName = TestName;
            this.TimesADay = timesaday;
            this.TotalDays = totaldays;
            this.IsMedicine = ismedicine;
        }
        public static string Condition;
        public InjectionLabTest inlt { get; set; }
        /// <summary>
        /// Temporary(Ahsan)
        /// </summary>
        /// 
        public long TokenNo { get; set; }
        public DateTime TokenDate { get; set; }
        /// <summary>
        /// Temporary
        /// </summary>
        public int LabTestId { get; set; }
        public string TestName { get; set; }
        public string SampleName { get; set; }
        public string Performed { get; set; }
        public string Report { get; set; }
        private Decimal desrving;
        public Decimal Deserving { get { return (desrving); } set { desrving = (value); } }
        private Decimal poor;
        public Decimal Poor { get { return (poor); } set { poor = (value); } }
        public Decimal ycdo;
        public Decimal YCDO { get { return (ycdo); } set { ycdo = (value); } }
        public Decimal general;
        public Decimal General { get { return (general); } set { general = (value); } }
        public Decimal Shahab { get; set; }
        public Decimal Ghori { get; set; }
        private Decimal currentamount;
        public Decimal CurrentAmount { get { return (currentamount); } set { currentamount = (value); } }
        public decimal TimesADay { get; set; }
        public decimal TotalDays { get; set; }
        public bool IsMedicine { get; set; }
        public int MedIssuedID { get; set; }
        public decimal OpeningQty { get; set; }
        public string Unit { get; set; }
        public bool IsRsTenInjection { get; set; }
        public bool IsAlwaysPaid { get; set; }
        public double Price { get; set; }
        public double RetailPrice { get; set; }

        public string TimesADayUrdu
        {
            get
            {
                if(this.TimesADay==1)
                {
                    return "دن میں ایک دفحہ";
                }
                else if (this.TimesADay == 2)
                {
                    return "صبح , شام";
                }
                else if (this.TimesADay == 3)
                {
                    return "صبح, دوپہر, شام";
                }
                else
                {
                    return "";
                }
            }
        }
        // Asif 02-04-2019
        public string TimesADayNumber
        {
            get
            {
                if (this.TimesADay == 1)
                {
                    //return "\n ایک روزانہ";
                    return " ایک روزانہ";
                }
                else if (this.TimesADay == 2)
                {
                    return "1 + 1";
                }
                else if (this.TimesADay == 3)
                {
                    return "1 + 1 + 1";
                }
                else
                {
                    return "";
                }
            }
        }
        // Asif 02-04-2019

        //Omer Aziz March 9 2013
        //Added this additional field becasue of Not a Valid Bookmark Error

        public int MedicineIssuedSerialID { get; set; }
        public bool IsTestPerformed
        {
            get;
            set;
        }
        public bool IsOd { get; set; }
        public decimal GetLineTotal()
        {
            return this.TimesADay * this.TotalDays * this.CurrentAmount;
        }
      
        public override string ToString()
        {
            return this.TestName;
        }
        public override bool Equals(object obj)
        {
            LabTest lb = obj as LabTest;
            if (lb == null)
                return false;
            return lb.LabTestId == this.LabTestId;
        }
    
    }
}
