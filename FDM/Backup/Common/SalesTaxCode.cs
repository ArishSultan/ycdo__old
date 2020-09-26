namespace Common
{
    using System;
    using System.Collections.Generic;

    public class SalesTaxCode
    {
        private string aRaccountGuid;
        private List<SalesTaxAuthority> salestaxAuthority;
        private string salestaxDescription;
        private string salestaxGuid;
        private string salestaxId;
        private string saletaxRate;

        public SalesTaxCode()
        {
            this.salestaxAuthority = new List<SalesTaxAuthority>();
        }

        public SalesTaxCode(string id) : this()
        {
            this.salestaxId = id;
        }

        public override bool Equals(object obj)
        {
            SalesTaxCode code = obj as SalesTaxCode;
            if (null == code)
            {
                return false;
            }
            return (code.salestaxGuid == this.salestaxGuid);
        }

        public decimal GetTotalSaleTaxAmount(decimal amount)
        {
            decimal num = 0M;
            foreach (SalesTaxAuthority authority in this.salestaxAuthority)
            {
                num += authority.GetSalesTaxAtuhorityTotal(amount);
            }
            return num;
        }

        public override string ToString()
        {
            return this.salestaxId;
        }

        public decimal TotalHasFormulaFalseRate()
        {
            decimal num = 0M;
            foreach (SalesTaxAuthority authority in this.salestaxAuthority)
            {
                if (!authority.UseFormula)
                {
                    num += authority.AuthorityRate;
                }
            }
            return num;
        }

        public string ARaccountGuid
        {
            get
            {
                return this.aRaccountGuid;
            }
            set
            {
                this.aRaccountGuid = value;
            }
        }

        public List<SalesTaxAuthority> SalesTaxAuthority
        {
            get
            {
                return this.salestaxAuthority;
            }
            set
            {
                this.salestaxAuthority = value;
            }
        }

        public string SalestaxDescription
        {
            get
            {
                return this.salestaxDescription;
            }
            set
            {
                this.salestaxDescription = value;
            }
        }

        public string SalestaxGuid
        {
            get
            {
                return this.salestaxGuid;
            }
            set
            {
                this.salestaxGuid = value;
            }
        }

        public string SalestaxId
        {
            get
            {
                return this.salestaxId;
            }
            set
            {
                this.salestaxId = value;
            }
        }

        public string SaletaxRate
        {
            get
            {
                return this.saletaxRate;
            }
            set
            {
                this.saletaxRate = value;
            }
        }
    }
}

