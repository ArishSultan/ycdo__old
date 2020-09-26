namespace Common
{
    using System;
    using System.Collections.Generic;

    public class ChartOfAccount
    {
        private string accountId;
        private string description;
        private string guId;
        private ChartofAccountType type;
        private string typeDescription;

        public static string Condition;

        public ChartOfAccount()
        {
        }

        public ChartOfAccount(string accId) : this()
        {
            this.accountId = accId;
        }

        public ChartOfAccount(string accId, ChartofAccountType type)
        {
            this.accountId = accId;
            this.type = type;
        }

        public ChartOfAccount(string accId, ChartofAccountType type, string description)
        {
            this.accountId = accId;
            this.type = type;
            this.description = description;
        }

        public override bool Equals(object obj)
        {
            ChartOfAccount account = obj as ChartOfAccount;
            if (account == null)
            {
                return false;
            }
            return ((this.AccountId == account.AccountId) || (this.type == account.type));
        }

        public override string ToString()
        {
            return this.accountId;
        }

        public string AccountId
        {
            get
            {
                return this.accountId;
            }
            set
            {
                this.accountId = value;
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

        public ChartofAccountType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public string TypeDescription
        {
            get
            {
                return this.typeDescription;
            }
            set
            {
                this.typeDescription = value;
            }
        }

        public  int IsAccountExist(ChartOfAccount chr, List<ChartOfAccount> chrs)
        {
            if (chr != null)
            {
                for (int i = 0; i < chrs.Count; i++)
                {
                    if (chrs[i].AccountId == chr.AccountId)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}

