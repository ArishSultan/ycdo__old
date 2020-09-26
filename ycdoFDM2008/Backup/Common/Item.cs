namespace Common
{
    using System;
    using System.Collections.Generic;

    public class Item
    {

        public static  string Condition;

        private ChartOfAccount cGSAccount;
        private Item componentID;
        private decimal currentPrice;
        private short currenttaxType;
        private string guId;
        private int hRBLineNo;
        private ChartOfAccount inventoryAccount;
        private ItemClass itemClass;
        private List<ItemComponent> itemComponents;
        private string itemDescription;
        private string itemId;
        private string itemPricelevel;
        private decimal lastUnitCost;


        
        private int numberofComponents;
        private int priceLevelId99;
        private List<PriceLevel> priceLevels;
        
        private decimal quantityNeeded;
        private decimal quantityonHand;
        private string saleDescription;
        private ChartOfAccount salesAccount;
        private string stockingUMID;
        
        private List<ItemTaxesType> taxType;
        private string upcsku;
        private Decimal weight;
        
      
        public Item()
        {
            this.priceLevels = new List<PriceLevel>();
            this.salesAccount = new ChartOfAccount();
            this.taxType = new List<ItemTaxesType>();
            this.cGSAccount = new ChartOfAccount();
            this.inventoryAccount = new ChartOfAccount();
            this.itemComponents = new List<ItemComponent>();
            this.PrimaryAttribute = new ItemAttribute();
            this.SecondaryAttribute = new ItemAttribute();
        }

        public Item(string itemid) : this()
        {
            this.itemId = itemid;
        }

        public Item(string itemid, ItemClass itemClass) : this()
        {
            this.itemId = itemid;
            this.itemClass = itemClass;
        }

        public Item(string itemid, string description) : this()
        {
            this.itemId = itemid;
            this.itemDescription = description;
        }

        public Item(string itemid, string description, ItemClass itemClass) : this()
        {
            this.itemId = itemid;
            this.itemDescription = description;
            this.itemClass = itemClass;
        }

        public Item(string itemid, string description, ItemClass itemClass, Item componentid) : this()
        {
            this.itemId = itemid;
            this.itemDescription = description;
            this.itemClass = itemClass;
            this.componentID = componentid;
        }

        public Item(string itemid, string saleDes, string stockUM, decimal curPrice, short curtax) : this()
        {
            this.itemId = itemid;
            this.saleDescription = saleDes;
            this.stockingUMID = stockUM;
            this.currentPrice = curPrice;
            this.currenttaxType = curtax;
        }

        public Item(string itemid, string saleDes, string upcsku, string stockUM, Decimal weight, string guid, ItemClass itClass) : this()
        {
            this.itemId = itemid;
            this.saleDescription = saleDes;
            this.upcsku = upcsku;
            this.stockingUMID = stockUM;
            this.weight = weight;
            this.guId = guid;
            this.itemClass = itClass;
        }

        public Item(string itemid, string saleDes, string upcsku, string stockUM, Decimal weight, string guid, short curTax, decimal curPrice, ItemClass itClass) : this()
        {
            this.itemId = itemid;
            this.saleDescription = saleDes;
            this.upcsku = upcsku;
            this.stockingUMID = stockUM;
            this.weight = weight;
            this.guId = guid;
            this.itemClass = itClass;
            this.currentPrice = curPrice;
            this.currenttaxType = curTax;
        }

        public Item(string itemid, string saleDes, string upcsku, string stockUM, Decimal weight, string guid, short curTax, short curPrice, ItemClass itClass, ChartOfAccount acc) : this()
        {
            this.itemId = itemid;
            this.saleDescription = saleDes;
            this.upcsku = upcsku;
            this.stockingUMID = stockUM;
            this.weight = weight;
            this.guId = guid;
            this.itemClass = itClass;
            this.currentPrice = curPrice;
            this.currenttaxType = curTax;
            this.salesAccount = acc;
        }

        public override bool Equals(object obj)
        {
            Item item = obj as Item;
            if (item == null)
            {
                return false;
            }
            return (item.itemId == this.itemId);
        }

        public bool  GetIndex(Item chr, List<Item> chrs, ItemClass itmCls)
        {
            if (chr != null)
            {
                for (int i = 0; i < chrs.Count; i++)
                {
                    
                        if (chrs[i].ItemClass  == chr.ItemClass )
                        {
                            return true ;
                        }
                     

                }
            }
            return false ;
        }

        public int GetIndex(Item chr, List<Item> chrs, String  itmguid)
        {
            if (chr != null)
            {
                for (int i = 0; i < chrs.Count; i++)
                {

                    if (chrs[i].GuId == itmguid)
                    {
                        return i;
                    }


                }
            }
            return -1;
        }
        public override string ToString()
        {
            return this.itemId;
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

        public short CurrenttaxType
        {
            get
            {
                return this.currenttaxType;
            }
            set
            {
                this.currenttaxType = value;
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

        public int HRBLineNo
        {
            get
            {
                return this.hRBLineNo;
            }
            set
            {
                this.hRBLineNo = value;
            }
        }

        public ChartOfAccount InventoryAccount
        {
            get
            {
                return this.inventoryAccount;
            }
            set
            {
                this.inventoryAccount = value;
            }
        }

        public ItemClass ItemClass
        {
            get
            {
                return this.itemClass;
            }
            set
            {
                this.itemClass = value;
            }
        }

        public List<ItemComponent> ItemComponents
        {
            get
            {
                return this.itemComponents;
            }
            set
            {
                this.itemComponents = value;
            }
        }

        public string ItemDescription
        {
            get
            {
                return this.itemDescription;
            }
            set
            {
                this.itemDescription = value;
            }
        }

        public string ItemId
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
            }
        }

        public string ItemPricelevel
        {
            get
            {
                return this.itemPricelevel;
            }
            set
            {
                this.itemPricelevel = value;
            }
        }

        public decimal LastUnitCost
        {
            get
            {
                return this.lastUnitCost;
            }
            set
            {
                this.lastUnitCost = value;
            }
        }

   



        public int NumberofComponents
        {
            get
            {
                return this.numberofComponents;
            }
            set
            {
                this.numberofComponents = value;
            }
        }

        public int PriceLevelId99
        {
            get
            {
                return this.priceLevelId99;
            }
            set
            {
                this.priceLevelId99 = value;
            }
        }

        public List<PriceLevel> PriceLevels
        {
            get
            {
                return this.priceLevels;
            }
            set
            {
                this.priceLevels = value;
            }
        }
       
        public string QtyOnHand
        {
            get
            {
                return this.quantityonHand.ToString("0.00000");
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

        public decimal QuantityonHand
        {
            get
            {
                return this.quantityonHand;
            }
            set
            {
                this.quantityonHand = value;
            }
        }

        public string SaleDescription
        {
            get
            {
                return this.saleDescription;
            }
            set
            {
                this.saleDescription = value;
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

        public string StockingUMID
        {
            get
            {
                return this.stockingUMID;
            }
            set
            {
                this.stockingUMID = value;
            }
        }
    

        public List<ItemTaxesType> TaxType
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

        public string Upcsku
        {
            get
            {
                return this.upcsku;
            }
            set
            {
                this.upcsku = value;
            }
        }

        public Decimal Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public string MasterStockId { get; set; }
        public string MasterStockGUID { get; set; }


        public ItemAttribute PrimaryAttribute { get; set; }

        public ItemAttribute SecondaryAttribute { get; set; }
    }
}

