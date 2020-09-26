using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public  class LabTest
    {
        public LabTest() { }
        public LabTest(int TestId) : this() { this.LabTestId = TestId; }
        public LabTest(int TestId, string TestName):this(TestId)
        {
            this.TestName = TestName;
        }
        public static string Condition;

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
