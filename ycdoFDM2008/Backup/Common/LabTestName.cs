using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public   class LabTestName
    {
     public int ID { get; set; }
     public string TestName { get; set; }
     public string Sample { get; set; }
     public string Performed { get; set; }
     public string Report { get; set;}
     public decimal Poor { get; set; }
     public decimal Deserving { get; set; }
     public decimal YCDO { get; set; }
     public decimal General { get; set; }
     public decimal Shahab { get; set; }
     public decimal Ghori { get; set; }
     public bool IsMedicine { get; set; }
     public string Unit { get; set; }
     public decimal OpeningQty { get; set; }
     public bool IsRsTenInjection { get; set; }
     public bool IsAlwaysPaid { get; set; }
     public bool IsOd { get; set; }
     public double PurchasePrice { get; set; }
     public double RetailPrice { get; set; }
    }
}
