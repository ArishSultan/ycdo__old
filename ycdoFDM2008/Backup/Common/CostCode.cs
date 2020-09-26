namespace Common
{
    using System;

    public class CostCode
    {
        private string costType;
        private string description;
        private string id;

        public CostCode()
        {
        }

        public CostCode(string id) : this()
        {
            this.id = id;
        }

        public override bool Equals(object obj)
        {
            CostCode code = obj as CostCode;
            if (null == obj)
            {
                return false;
            }
            return (code.id == this.id);
        }

        public string CostType
        {
            get
            {
                return this.costType;
            }
            set
            {
                this.costType = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public string Id
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
    }
}

