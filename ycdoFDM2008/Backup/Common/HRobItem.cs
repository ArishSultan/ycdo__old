namespace Common
{
    using System;
    using System.Collections.Generic;

    public class HRobItem
    {
        private ChartOfAccount cGSAccount;
        private string description;
        private ChartOfAccount invenotryAccount;
        private Item item;
        private int lineNo;
        private ChartOfAccount salesAccount;

        private Decimal percentage;

        public HRobItem()
        {
            this.salesAccount = new ChartOfAccount();
            this.cGSAccount = new ChartOfAccount();
            this.invenotryAccount = new ChartOfAccount();
            this.item = new Item();
        }

        public HRobItem(int lineno) : this()
        {
            this.lineNo = lineno;
        }

        public HRobItem(int lineno, Item itm) : this()
        {
            this.lineNo = lineno;
            this.item = itm;
        }

        public override bool Equals(object obj)
        {
            HRobItem item = obj as HRobItem;
            if (item == null)
            {
                return false;
            }
            return (item.lineNo == this.lineNo);
        }

        public override string ToString()
        {
            return this.description;
        }

        public ChartOfAccount CGSAccount
        {
            get
            {
                return this.cGSAccount;
            }
            set
            {
                this.cGSAccount = value;
            }
        }

        public string CGSAccountID
        {
            get
            {
                return this.cGSAccount.AccountId;
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

        public ChartOfAccount InventoryAccount
        {
            get
            {
                return this.invenotryAccount;
            }
            set
            {
                this.invenotryAccount = value;
            }
        }

        public string InventoryAccountID
        {
            get
            {
                return this.invenotryAccount.AccountId;
            }
        }

        public Item Item
        {
            get
            {
                return this.item;
            }
            set
            {
                this.item = value;
            }
        }

        public Decimal Percentage
        {
            get { return this.percentage; }
            set { this.percentage = value; }
        }

        public int LineNo
        {
            get
            {
                return this.lineNo;
            }
            set
            {
                this.lineNo = value;
            }
        }

        public ChartOfAccount SalesAccount
        {
            get
            {
                return this.salesAccount;
            }
            set
            {
                this.salesAccount = value;
            }
        }

        public string SalesAccountID
        {
            get
            {
                return this.salesAccount.AccountId;
            }
        }

        public int GetIndex(HRobItem chr, List<HRobItem> chrs, Boolean BySalesAcc, Boolean ByInvAcc, Boolean ByCGSAcc)
        {
            if (chr != null)
            {
                for (int i = 0; i < chrs.Count; i++)
                {
                    if (BySalesAcc == true)
                    {
                        if (chrs[i].SalesAccount.AccountId   == chr.SalesAccount.AccountId )
                        {
                            return i;
                        }
                    }
                    else if (ByCGSAcc  == true)
                    {
                        if (chrs[i]. CGSAccount.AccountId   == chr.CGSAccount.AccountId )
                        {
                            return i;
                        }
                    }

                    else if (ByInvAcc  == true)
                    {
                        if (chrs[i].InventoryAccount.AccountId == chr.InventoryAccount.AccountId)
                        {
                            return i;
                        }
                    }

                }
            }
            return -1;
        }

    }
}

