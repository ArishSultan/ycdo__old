namespace Common
{
    using System;

    public class PriceLevel
    {
        private int addSubLevel;
        private decimal addSubValue;
        private string calculationText;
        private decimal currentPrice;
        public static int DefaultPriceLevel;
        private int id;
        private decimal lastCost;
        private string level;
        public static int MaxPriceLevel;
        private decimal price;
        private decimal priceLevel1;
        private bool reCalculateLastCost;
        private bool reCalculatePricelevel1;
        private int roundLevel;
        private decimal roundValue;
        private int useLevel;

        public PriceLevel()
        {
        }

        public PriceLevel(decimal price) : this()
        {
            this.price = price;
        }

        public PriceLevel(string level) : this()
        {
            this.level = level;
        }

        public PriceLevel(decimal price, int id) : this()
        {
            this.price = price;
            this.id = id;
        }

        public PriceLevel(string level, int id) : this()
        {
            this.level = level;
            this.id = id;
        }

        public PriceLevel(decimal price, string level, int id) : this()
        {
            this.price = price;
            this.id = id;
            this.level = level;
        }

        public PriceLevel(string level, int id, string CalcText, int uselvl) : this()
        {
            this.id = id;
            this.level = level;
            this.useLevel = uselvl;
            this.calculationText = CalcText;
        }

        public PriceLevel(decimal price, string level, int id, decimal pricelvl1, string CalcText, int roundlvl, decimal roundvalue) : this()
        {
            this.price = price;
            this.id = id;
            this.level = level;
            this.priceLevel1 = pricelvl1;
            this.calculationText = CalcText;
            this.roundLevel = roundlvl;
            this.roundValue = roundvalue;
        }

        public PriceLevel(decimal price, string level, int id, decimal pricelvl1, string CalcText, int roundlvl, decimal roundvalue, decimal lastcost) : this()
        {
            this.price = price;
            this.id = id;
            this.level = level;
            this.priceLevel1 = pricelvl1;
            this.calculationText = CalcText;
            this.roundLevel = roundlvl;
            this.roundValue = roundvalue;
            this.lastCost = lastcost;
        }

        public PriceLevel ConvertfromPTpriceCalc(PriceLevel prlvl)
        {
            string str = "";
            if (prlvl.calculationText == "NC")
            {
                prlvl.calculationText = "No Calculation";
                prlvl.addSubLevel = 0;
                prlvl.addSubValue = 0M;
                if (prlvl.id > 1)
                {
                    prlvl.useLevel = 3;
                    return prlvl;
                }
                prlvl.useLevel = 2;
                return prlvl;
            }
            if (prlvl.calculationText.StartsWith("PL1"))
            {
                str = "Price Level 1 " + prlvl.calculationText.Substring(3, 1) + " ";
                prlvl.useLevel = 0;
                if (str.Trim().EndsWith("+"))
                {
                    prlvl.addSubLevel = 1;
                    prlvl.addSubValue = Convert.ToDecimal(prlvl.calculationText.Substring(4));
                    prlvl.calculationText = str + prlvl.addSubValue.ToString("0.00");
                    return prlvl;
                }
                if (str.Trim().EndsWith("-"))
                {
                    prlvl.addSubLevel = 3;
                    prlvl.addSubValue = Convert.ToDecimal(prlvl.calculationText.Substring(4));
                    prlvl.calculationText = str + prlvl.addSubValue.ToString("0.00");
                    return prlvl;
                }
                if (str.Trim().EndsWith("*"))
                {
                    if (Convert.ToDecimal(prlvl.calculationText.Substring(4)) >= 1M)
                    {
                        prlvl.addSubLevel = 0;
                        prlvl.addSubValue = (100M * Convert.ToDecimal(prlvl.calculationText.Substring(4))) - 100M;
                        prlvl.calculationText = str + Convert.ToDecimal(prlvl.calculationText.Substring(4)).ToString("0.00");
                        return prlvl;
                    }
                    prlvl.addSubLevel = 2;
                    prlvl.addSubValue = 100M - (100M * Convert.ToDecimal(prlvl.calculationText.Substring(4)));
                    prlvl.calculationText = str + Convert.ToDecimal(prlvl.calculationText.Substring(4)).ToString("0.00");
                }
                return prlvl;
            }
            if (prlvl.calculationText.StartsWith("LC"))
            {
                str = "Last Cost " + prlvl.calculationText.Substring(2, 1) + " ";
                if (prlvl.id > 1)
                {
                    prlvl.useLevel = 3;
                }
                else
                {
                    prlvl.useLevel = 2;
                }
                if (str.Trim().EndsWith("+"))
                {
                    prlvl.addSubLevel = 1;
                    prlvl.addSubValue = Convert.ToDecimal(prlvl.calculationText.Substring(3));
                    prlvl.calculationText = str + prlvl.addSubValue.ToString("0.00");
                    return prlvl;
                }
                if (str.Trim().EndsWith("-"))
                {
                    prlvl.addSubLevel = 3;
                    prlvl.addSubValue = Convert.ToDecimal(prlvl.calculationText.Substring(3));
                    prlvl.calculationText = str + prlvl.addSubValue.ToString("0.00");
                    return prlvl;
                }
                if (!str.Trim().EndsWith("*"))
                {
                    return prlvl;
                }
                if (Convert.ToDecimal(prlvl.calculationText.Substring(3)) >= 1M)
                {
                    prlvl.addSubLevel = 0;
                    prlvl.addSubValue = Convert.ToDecimal(prlvl.calculationText.Substring(3));
                    prlvl.calculationText = str + prlvl.addSubValue.ToString("0.00");
                    return prlvl;
                }
                prlvl.addSubLevel = 2;
                prlvl.addSubValue = Convert.ToDecimal(prlvl.calculationText.Substring(3));
                prlvl.calculationText = str + prlvl.addSubValue.ToString("0.00");
            }
            return prlvl;
        }

        public override bool Equals(object obj)
        {
            PriceLevel level = obj as PriceLevel;
            if (level == null)
            {
                return false;
            }
            return (this.id == level.id);
        }

        public override string ToString()
        {
            return this.Level;
        }

        public int AddSubLevel
        {
            get
            {
                return this.addSubLevel;
            }
            set
            {
                this.addSubLevel = value;
            }
        }

        public decimal AddSubValue
        {
            get
            {
                return this.addSubValue;
            }
            set
            {
                this.addSubValue = value;
            }
        }

        public string CalculationText
        {
            get
            {
                return this.calculationText;
            }
            set
            {
                this.calculationText = value;
            }
        }

        public decimal CurrentPrice
        {
            get
            {
                return this.currentPrice;
            }
            set
            {
                this.currentPrice = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public decimal LastCost
        {
            get
            {
                return this.lastCost;
            }
            set
            {
                this.lastCost = value;
            }
        }

        public string Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public decimal PriceLevel1
        {
            get
            {
                return this.priceLevel1;
            }
            set
            {
                this.priceLevel1 = value;
            }
        }

        public bool ReCalculateLastCost
        {
            get
            {
                return this.reCalculateLastCost;
            }
            set
            {
                this.reCalculateLastCost = value;
            }
        }

        public bool ReCalculatePricelevel1
        {
            get
            {
                return this.reCalculatePricelevel1;
            }
            set
            {
                this.reCalculatePricelevel1 = value;
            }
        }

        public int RoundLevel
        {
            get
            {
                return this.roundLevel;
            }
            set
            {
                this.roundLevel = value;
            }
        }

        public decimal RoundValue
        {
            get
            {
                return this.roundValue;
            }
            set
            {
                this.roundValue = value;
            }
        }

        public string UnitPrice
        {
            get
            {
                return this.price.ToString("0.00");
            }
        }

        public int UseLevel
        {
            get
            {
                return this.useLevel;
            }
            set
            {
                this.useLevel = value;
            }
        }
    }
}

