namespace Common
{
    using System;

    public class ShipVia
    {
        private string guId;
        private short number;
        private string shippingMethod;

        public override string ToString()
        {
            return this.shippingMethod;
        }

        public string GuId
        {
            get
            {
                return this.guId;
            }
            set
            {
                this.guId = value;
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

        public string ShippingMethod
        {
            get
            {
                return this.shippingMethod;
            }
            set
            {
                this.shippingMethod = value;
            }
        }
    }
}

