namespace Common
{
    using System;
    using System.Collections.Generic;

    public class Phase
    {
        private List<CostCode> costCode;
        private string costType;
        private string description;
        private string guId;
        private string id;
        private bool usecostCodes;

        public Phase()
        {
            this.costCode = new List<CostCode>();
        }

        public Phase(string id) : this()
        {
            this.id = id;
        }

        public override bool Equals(object obj)
        {
            Phase phase = obj as Phase;
            if (null == obj)
            {
                return false;
            }
            return (this.id == phase.id);
        }

        public List<CostCode> CostCode
        {
            get
            {
                return this.costCode;
            }
            set
            {
                this.costCode = value;
            }
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

        public bool UsecostCodes
        {
            get
            {
                return this.usecostCodes;
            }
            set
            {
                this.usecostCodes = value;
            }
        }
    }
}

