namespace DAL
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;

    //public class ShipViaDAL
    //{
    //    private ShippingMethod shippingMethod;
    //    private ShipVia shipVia;
    //    private List<ShipVia> shipVias;

    //    public List<ShipVia> GetShipVia()
    //    {
    //        try
    //        {
    //            shippingMethod = new ShippingMethod();
    //            if (shippingMethod.ExportShippingMethod() == true)
    //            {

    //                shipVias = new List<ShipVia>();
    //                XElement xe = XElement.Load(shippingMethod.FileNameXML);
    //                var shipElement = from el in xe.Elements("PAW_Shipping_Method")
    //                                  select el;
    //                foreach (var el in shipElement)
    //                {
    //                    shipVia = new ShipVia();
    //                    shipVia.Number = Convert.ToInt16(el.Element("Number").Value);
    //                    shipVia.ShippingMethod = el.Element("ShippingMethod").Value;
    //                    shipVia.GuId = el.Element("GUID").Value;

    //                    shipVias.Add(shipVia);
    //                }

    //            }

    //            return shipVias;
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message, "GetShipVia");
    //            return shipVias;
    //        }
    //    }
    //}
}

