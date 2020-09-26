namespace Common
{
    using System;

    public class SalesTaxAuthority
    {
        private string authorityaccountId;
        private string authorityDescription;
        private string authorityGuid;
        private string authorityId;
        private decimal authorityRate;
        private decimal authorityRate2;
        private decimal salesTaxAmount;
        private TaxBasis taxBasis;
        private decimal taxLimit;
        private bool useFormula;

        public SalesTaxAuthority()
        {
        }

        public SalesTaxAuthority(string authorityid) : this()
        {
            this.authorityId = authorityid;
        }

        public SalesTaxAuthority(string authorityid, decimal authorityrate, string authorityaccountid) : this()
        {
            this.authorityId = authorityid;
            this.authorityRate = authorityrate;
            this.authorityaccountId = authorityaccountid;
        }

        public SalesTaxAuthority(string authorityid, decimal authorityrate, string authorityaccountid, string authorityguid, bool useformula, decimal rate2, TaxBasis taxbasis, decimal taxlimit) : this()
        {
            this.authorityId = authorityid;
            this.authorityRate = authorityrate;
            this.authorityaccountId = authorityaccountid;
            this.authorityGuid = authorityguid;
            this.useFormula = useformula;
            this.authorityRate2 = rate2;
            this.taxBasis = taxbasis;
            this.taxLimit = taxlimit;
        }
        public override int GetHashCode()
        {
                return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            SalesTaxAuthority authority = obj as SalesTaxAuthority;
            if (null == authority)
            {
                return false;
            }
            return (authority.authorityId == this.authorityId);
        }

        public decimal GetReverseAtuhorityWithSingleRate(decimal amount, decimal totalrate)
        {
            decimal num = 0M;
            if (!this.useFormula)// && (amount > Convert.ToDecimal((double) 0.0))
            {
                num = amount / (totalrate / Convert.ToDecimal(this.authorityRate));
            }
            return num;
        }

        public decimal GetSalesTaxAtuhorityTotal(decimal amount)
        {
            decimal num = 0M;
            if (!this.useFormula)
            {
               // if (amount > Convert.ToDecimal((double) 0.0))
                {
                    num = (amount * Convert.ToDecimal(this.authorityRate)) / 100M;
                }
                return num;
            }
           // if (amount > Convert.ToDecimal((double) 0.0))
            {
                num = ((((this.authorityRate / 100M) * this.taxLimit) > 0M) ? ((this.authorityRate / 100M) * this.taxLimit) : 0M) + (((amount - this.taxLimit) * this.authorityRate2) / 100M);
            }
            return num;
        }

        public string AuthorityaccountId
        {
            get
            {
                return this.authorityaccountId;
            }
            set
            {
                this.authorityaccountId = value;
            }
        }

        public string AuthorityDescription
        {
            get
            {
                return this.authorityDescription;
            }
            set
            {
                this.authorityDescription = value;
            }
        }

        public string AuthorityGuid
        {
            get
            {
                return this.authorityGuid;
            }
            set
            {
                this.authorityGuid = value;
            }
        }

        public string AuthorityId
        {
            get
            {
                return this.authorityId;
            }
            set
            {
                this.authorityId = value;
            }
        }

        public decimal AuthorityRate
        {
            get
            {
                return this.authorityRate;
            }
            set
            {
                this.authorityRate = value;
            }
        }

        public decimal AuthorityRate2
        {
            get
            {
                return this.authorityRate2;
            }
            set
            {
                this.authorityRate2 = value;
            }
        }

        public decimal SalesTaxAmount
        {
            get
            {
                return this.salesTaxAmount;
            }
            set
            {
                this.salesTaxAmount = value;
            }
        }

        public TaxBasis TaxBasis
        {
            get
            {
                return this.taxBasis;
            }
            set
            {
                this.taxBasis = value;
            }
        }

        public decimal TaxLimit
        {
            get
            {
                return this.taxLimit;
            }
            set
            {
                this.taxLimit = value;
            }
        }

        public bool UseFormula
        {
            get
            {
                return this.useFormula;
            }
            set
            {
                this.useFormula = value;
            }
        }
    }
}

