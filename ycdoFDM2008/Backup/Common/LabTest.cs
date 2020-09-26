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
        public LabTest(int TestId, string TestName,int timesaday,int totaldays)
        {
            this.LabTestId = TestId;
            this.TestName = TestName;
            this.TimesADay = timesaday;
            this.TotalDays = totaldays;
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
        public Decimal Deserving { get; set; }
        public Decimal Poor { get; set; }
        public Decimal YCDO { get; set; }
        public Decimal General { get; set; }
        public Decimal Shahab { get; set; }
        public Decimal Ghori { get; set; }
        public Decimal CurrentAmount { get; set; }
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
