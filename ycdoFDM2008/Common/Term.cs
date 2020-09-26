namespace Common
{
    using System;

    public class Term
    {
        private bool cod;
        private Credit_Status creditStatus;
        private short discountDays;
        private Single  discountPercent;
        private short dueDays;
        private bool dueinnoofDays;
        private bool duemonthendTerms;
        private bool dueondayofnextMonth;
        private bool prepaid;
        private string termsString;
        private bool termsType;
        private bool useFinanceCharge;
        private bool useStandardTerm;

        public Term()
        {
        }

        public Term(bool dueinnoofDays, bool cod, bool prepaid, bool dueondayofnextMonth, bool duemonthendTerms, short dueDays, short discountDays, Single discountPercent, string termsString, bool termsType)
        {
            this.dueinnoofDays = dueinnoofDays;
            this.cod = cod;
            this.prepaid = prepaid;
            this.dueondayofnextMonth = dueondayofnextMonth;
            this.duemonthendTerms = duemonthendTerms;
            this.dueDays = dueDays;
            this.discountDays = discountDays;
            this.discountPercent = discountPercent;
            this.termsString = termsString;
            this.termsType = termsType;
        }

        public string GenerateTermString()
        {
            if (this.cod)
            {
                this.termsString = "C.O.D";
            }
            else if (this.prepaid)
            {
                this.termsString = "Prepaid";
            }
            else if (!this.termsType)
            {
                if (!this.duemonthendTerms)
                {
                    if (this.discountPercent > 0)
                    {
                        this.termsString = this.discountPercent.ToString () + "% ";
                    }
                    if (this.discountDays > 0)
                    {
                        this.termsString = this.termsString + this.discountDays + ",";
                    }
                    if (this.dueDays > 0)
                    {
                        this.termsString = string.Concat(new object[] { this.termsString, " Net ", this.dueDays, " Days" });
                    }
                }
                else
                {
                    if (this.discountPercent > 0)
                    {
                        this.termsString = this.termsString + this.discountPercent + "% ";
                    }
                    if (this.discountDays > 0)
                    {
                        this.termsString = this.termsString + this.discountDays + ",";
                    }
                    this.termsString = this.termsString + "Due at end of Month";
                }
            }
            else if (!this.duemonthendTerms)
            {
                if (this.discountPercent > 0)
                {
                    this.termsString = this.termsString + this.discountPercent + "% ";
                }
                if (this.discountDays > 0)
                {
                    this.termsString = this.termsString + this.discountDays + ",";
                }
                if (this.dueDays > 0)
                {
                    this.termsString = string.Concat(new object[] { this.termsString, " Net ", this.dueDays, "th NextDollar Month" });
                }
            }
            else
            {
                if (this.discountPercent > 0)
                {
                    this.termsString = this.termsString + this.discountPercent + "% ";
                }
                if (this.discountDays > 0)
                {
                    this.termsString = this.termsString + this.discountDays + ",";
                }
                this.termsString = this.termsString + " Due at end of Month";
            }
            return this.termsString;
        }

        public bool Cod
        {
            get
            {
                return this.cod;
            }
            set
            {
                this.cod = value;
            }
        }

        public Credit_Status CreditStatus
        {
            get
            {
                return this.creditStatus;
            }
            set
            {
                this.creditStatus = value;
            }
        }

        public short DiscountDays
        {
            get
            {
                return this.discountDays;
            }
            set
            {
                this.discountDays = value;
            }
        }

        public Single DiscountPercent
        {
            get
            {
                return this.discountPercent;
            }
            set
            {
                this.discountPercent = value;
            }
        }

        public short DueDays
        {
            get
            {
                return this.dueDays;
            }
            set
            {
                this.dueDays = value;
            }
        }

        public bool DueinnoofDays
        {
            get
            {
                return this.dueinnoofDays;
            }
            set
            {
                this.dueinnoofDays = value;
            }
        }

        public bool DuemonthendTerms
        {
            get
            {
                return this.duemonthendTerms;
            }
            set
            {
                this.duemonthendTerms = value;
            }
        }

        public bool DueondayofnextMonth
        {
            get
            {
                return this.dueondayofnextMonth;
            }
            set
            {
                this.dueondayofnextMonth = value;
            }
        }

        public bool Prepaid
        {
            get
            {
                return this.prepaid;
            }
            set
            {
                this.prepaid = value;
            }
        }

        public string TermsString
        {
            get
            {
                return this.termsString;
            }
            set
            {
                this.termsString = value;
            }
        }

        public bool TermsType
        {
            get
            {
                return this.termsType;
            }
            set
            {
                this.termsType = value;
            }
        }

        public bool UseFinanceCharge
        {
            get
            {
                return this.useFinanceCharge;
            }
            set
            {
                this.useFinanceCharge = value;
            }
        }

        public bool UseStandardTerm
        {
            get
            {
                return this.useStandardTerm;
            }
            set
            {
                this.useStandardTerm = value;
            }
        }



    }
}

