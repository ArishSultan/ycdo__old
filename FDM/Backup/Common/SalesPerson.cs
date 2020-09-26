using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class SalesPerson : Person
    {
        public SalesPerson() {
            saleAccounts = new List<HRobItem>();
            address = new Address();
        }

        public SalesPerson(string id):this()
        {
            this.Id = id;
        }

        public override bool Equals(object obj)
        {
            SalesPerson item = obj as SalesPerson;
            if (item == null)
            {
                return false;
            }
            return (item.Id  == this.Id);
        }

        public  int GetSalesPersonIndex(SalesPerson chr, List<SalesPerson> chrs,Boolean BySPID,Boolean ByName)
        {
            if (chr != null)
            {
                for (int i = 0; i < chrs.Count; i++)
                {
                    if (ByName == true)
                    {
                        if (chrs[i].Name == chr.Name)
                        {
                            return i;
                        }
                    }
                    else if(BySPID  ==true )
                    {   if (chrs[i].SPId  == chr.SPId )
                        {
                            return i;
                        }
                    }

                }
            }
            return -1;
        }



        public static string Condition;


        private Address address;
        private EmployeeType employeeType;
        private Boolean isInActive;



        private Decimal commissionAmount;
        private Decimal yTDCommissionAmount;
        private Decimal priorCommissionAmount;
        private Decimal totalCommission;
        private List<HRobItem> saleAccounts;
        private DateTime sCommissionDate;
        private Int64 spId;
        private DateTime insertionDate;
        private DateTime lastFinalizedDate;

        private Decimal commissionRate;

        private Int64 detailID;

        public Boolean IsInActive
        {
            get { return this.isInActive; }
            set { this.isInActive = value; }
        }

        public Address Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public EmployeeType EmployeeType
        {
            get
            {
                return this.employeeType;
            }
            set
            {
                this.employeeType = value;
            }
        }

        public Int64 DetailID
        {
            get { return this.detailID; }
            set { this.detailID = value; }
        }


        public Decimal CommmissionRate
        {
            get { return this.commissionRate; }
            set { commissionRate = value; }
        }


        public DateTime LastFinalizedDate
        {
            get { return this.lastFinalizedDate; }
            set { this.lastFinalizedDate = value; }
        }
        


        public DateTime InsertionDate
        {
            get { return this.insertionDate; }
            set { this.insertionDate = value; }
        }

        public Int64  SPId
        {
            get { return this.spId; }
            set { this.spId = value; }
        }
        public DateTime SCommissionDate
        {
            get { return this.sCommissionDate; }
            set { this.sCommissionDate = value; }
        }

        public Decimal CommissionAmount
        {
            get { return this.commissionAmount; }
            set { this.commissionAmount = value; }
        }
        public Decimal YTDCommissionAmount
        {
            get { return this.yTDCommissionAmount; }
            set { this.yTDCommissionAmount = value; }
        }
        public Decimal PriorCommissionAmount
        {
            get { return this.priorCommissionAmount; }
            set { this.priorCommissionAmount = value; }
        }
        public Decimal TotalCommission
        {
            get { return this.totalCommission; }
            set { this.totalCommission = value; }
        }
        public List<HRobItem> HRBAccounts
        {
            get { return this.saleAccounts; }
            set { this.saleAccounts = value; }
        }

    }
}
