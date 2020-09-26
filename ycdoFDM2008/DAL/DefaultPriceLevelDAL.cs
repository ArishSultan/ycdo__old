namespace DAL
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;

    //public class DefaultPriceLevelDAL
    //{
    //    private List<PriceLevel> defaultprices;
    //    private DefaultPriceLevel defpricelevel;
    //    private PriceLevel pricelevel;

    //    public List<PriceLevel> GetDefaultPrices()
    //    {
    //        try
    //        {
    //            defpricelevel = new DefaultPriceLevel();
    //            defaultprices = new List<PriceLevel>();
    //            if (defpricelevel.ExportDefaultPrices() == true)
    //            {

    //                XElement xdoc = XElement.Load(defpricelevel.FileNameXML);
    //                var invElement = from el in xdoc.Elements("PAW_InventoryItem_Default")
    //                                 select el;

    //                foreach (var el in invElement)
    //                {

    //                    pricelevel = new PriceLevel();
    //                    for (int i = 1; i <= 10; i++)
    //                    {
    //                       // if (Convert.ToBoolean(el.Element("Price_Level_" + i + "_Enabled").Value) == true)
    //                        {
    //                            pricelevel = new PriceLevel();
    //                            pricelevel.Level = el.Element("Price_Level_" + i + "_Name") == null ? "" : el.Element("Price_Level_" + i + "_Name").Value;
    //                            pricelevel.Id = i;
    //                            defaultprices.Add(pricelevel);
    //                        }
    //                    }
    //                }
    //            }
    //            return defaultprices;
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetDefaultPrices");
    //            return defaultprices;
    //        }
    //    }
    //}
}

