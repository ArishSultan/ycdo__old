namespace Common
{
    using System;
    using System.Collections.Generic;

    public class AccountPeriods
    {
        private DateTime currentPeriod;
        private List<int> periodNumber;
        private int periodPerYear;
        private List<string> periods;

        public AccountPeriods()
        {
            this.periods = new List<string>();
            this.periodNumber = new List<int>();
        }

        public AccountPeriods(List<int> periodnumber) : this()
        {
            this.periodNumber = periodnumber;
        }

        public DateTime CurrentPeriod
        {
            get
            {
                return this.currentPeriod;
            }
            set
            {
                this.currentPeriod = value;
            }
        }

        public List<int> PeriodNumber
        {
            get
            {
                return this.periodNumber;
            }
            set
            {
                this.periodNumber = value;
            }
        }

        public int PeriodPerYear
        {
            get
            {
                return this.periodPerYear;
            }
            set
            {
                this.periodPerYear = value;
            }
        }

        public List<string> Periods
        {
            get
            {
                return this.periods;
            }
            set
            {
                this.periods = value;
            }
        }
    }
}

