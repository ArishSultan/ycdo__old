using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class Shift
    {
    

       public Shift(int p, string p_2, bool p_3)
       {
           // TODO: Complete member initialization
           this.ID = p;
           this.ShiftName = p_2;
           this.Active = p_3;
       }
        public int ID { get; set; }
        public string ShiftName { get; set; }
        public bool Active { get; set; }
        public DateTime ChangeDateTime { get; set; }
    }
}
