namespace DAL
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;

    //public class SalesTaxAuthoritiesDAL
    //{
    //    private SalesTaxAuthority salestaxAuthority;
    //    private SalesTaxAuthorities salestaxAuthorties;
    //    private List<SalesTaxAuthority> saletaxAuthorities;

    //    public List<SalesTaxAuthority> GetSalesTaxAuthorities()
    //    {

    //        try
    //        {
    //            salestaxAuthorties = new SalesTaxAuthorities();
    //            if (salestaxAuthorties.ExportSalesTaxAuthorities() == true)
    //            {
    //                saletaxAuthorities = new List<SalesTaxAuthority>();
    //                XElement xdoc = XElement.Load(salestaxAuthorties.FileNameXML);
    //                var salTaxElement = from el in xdoc.Elements("PAW_Sales_Tax_Authority")
    //                                    select el;
    //                foreach (var el in salTaxElement)
    //                {
    //                    salestaxAuthority = new SalesTaxAuthority(el.Element("ID").Value, Convert.ToDecimal(el.Element("Rate").Value), el.Element("AccountID").Value, el.Element("GUID").Value, Convert.ToBoolean(el.Element("UsesFormula").Value), Convert.ToDecimal(el.Element("Rate2").Value), (TaxBasis)Convert.ToInt16(el.Element("TaxBasis").Value), Convert.ToDecimal(el.Element("TaxLimit").Value));
    //                    saletaxAuthorities.Add(salestaxAuthority);
    //                }

    //            }
    //            return saletaxAuthorities;
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message, "GetSalesTaxAuthorities");
    //            return saletaxAuthorities;
    //        }
    //    }
    //}
}

