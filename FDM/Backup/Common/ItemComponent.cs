namespace Common
{
    using System;

    public class ItemComponent
    {
        private Item componentID = new Item();
        private int componentNumber;
        private DateTime effectiveDate;
        private decimal quantityNeeded;
        private int reviosionNumber;

        public Item ComponentID
        {
            get
            {
                return this.componentID;
            }
            set
            {
                this.componentID = value;
            }
        }

        public int ComponentNumber
        {
            get
            {
                return this.componentNumber;
            }
            set
            {
                this.componentNumber = value;
            }
        }

        public DateTime EffectiveDate
        {
            get
            {
                return this.effectiveDate;
            }
            set
            {
                this.effectiveDate = value;
            }
        }

        public decimal QuantityNeeded
        {
            get
            {
                return this.quantityNeeded;
            }
            set
            {
                this.quantityNeeded = value;
            }
        }

        public int ReviosionNumber
        {
            get
            {
                return this.reviosionNumber;
            }
            set
            {
                this.reviosionNumber = value;
            }
        }
    }
}

