namespace Common
{
    using System;

    public class ItemTaxesType
    {
        private bool isTaxable;
        private short number;
        private string taxType;

        public ItemTaxesType()
        {
        }

        public ItemTaxesType(short number) : this()
        {
            this.number = number;
        }

        public override bool Equals(object obj)
        {
            ItemTaxesType type = obj as ItemTaxesType;
            if (type == null)
            {
                return false;
            }
            return (type.GetHashCode() == this.GetHashCode());
        }

        public override int GetHashCode()
        {
            return this.number;
        }

        public bool IsTaxable
        {
            get
            {
                return this.isTaxable;
            }
            set
            {
                this.isTaxable = value;
            }
        }

        public short Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public string TaxType
        {
            get
            {
                return this.taxType;
            }
            set
            {
                this.taxType = value;
            }
        }
    }
}

