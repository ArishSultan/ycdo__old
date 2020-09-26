using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public  class CommissionOptions
    {


        private BaseCommissionOn baseCom;
        private CommissionMethod comMethod;
        private Decimal defaultCommission;
        private bool displayMsg;

        public BaseCommissionOn BaseCom
        {
            get
            {                return baseCom;            }
            set { baseCom = value; }
        }
        public CommissionMethod ComMethod
        {
            get { return comMethod; }
            set { comMethod = value; }
        }
        public Decimal DefaultCommission
        {
            get { return defaultCommission; }
            set { defaultCommission = value; }
        }
        public bool DisplayMsg
        {
            get { return this.displayMsg; }
            set { this.displayMsg = value; }
        }

    }
}
