namespace DAL
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;

    public class ItemTaxTypeDAL
    {
        //private ItemTaxType itemtaxType;
        private ItemTaxesType taxType;
        private List<ItemTaxesType> taxTypes;

        public List<ItemTaxesType> GetItemTaxType()
        {
            try
            {
                //itemtaxType = new ItemTaxType();
                //if (itemtaxType.ExportItemTaxType() == true)
                //{
                    taxTypes = new List<ItemTaxesType>();
                //    XElement xdoc = XElement.Load(itemtaxType.FileNameXML);
                //    var itemType = from el in xdoc.Elements("PAW_Item_Tax_Type")
                //                   select el;
                //    foreach (var el in itemType)
                //    {
                //        if (Convert.ToInt32(el.Element("Number").Value) != 26 && Convert.ToInt32(el.Element("Number").Value) != 27)
                //        {
                //            taxType = new ItemTaxesType();
                //            taxType.IsTaxable = Convert.ToBoolean(el.Element("IsTaxable").Value);
                //            taxType.Number = Convert.ToInt16(el.Element("Number").Value);
                //            taxType.TaxType = el.Element("ItemTaxType") == null ? "" : el.Element("ItemTaxType").Value;

                //            taxTypes.Add(taxType);
                //        }
                //    }
                //}
                taxTypes.TrimExcess();
                return taxTypes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "GetItemTaxType");
                return taxTypes;
            }
        }
    }
}

