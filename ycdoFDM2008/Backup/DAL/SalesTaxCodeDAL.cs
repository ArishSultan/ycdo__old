namespace DAL
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;

//    public class SalesTaxCodeDAL
//    {
//        private SalesTaxCodes salestaxCode;
//        private SalesTaxCode saletaxcode;
//        private List<SalesTaxCode> saletaxCodes;

//        public List<SalesTaxCode> GetSalesTaxCodes()
//        {
//            try
//            {
//                salestaxCode = new SalesTaxCodes();
//                if (salestaxCode.ExportSalesTaxCode() == true)
//                {
//                    saletaxCodes = new List<SalesTaxCode>();
//                    XElement xdoc = XElement.Load(salestaxCode.FileNameXML);
//                    var salTaxElement = from el in xdoc.Elements("PAW_Sales_Tax_Code")
//                                        select el;
//                    foreach (var el in salTaxElement)
//                    {
//                        saletaxcode = new SalesTaxCode();
//                        saletaxcode.SalestaxId = el.Element("ID").Value;
//                        saletaxcode.SalestaxDescription = el.Element("Description") == null ? "" : el.Element("Description").Value;
//                        saletaxcode.SalestaxGuid = el.Element("GUID") == null ? "" : el.Element("GUID").Value;
//                        List<SalesTaxAuthority> saletaxAuthorities = new SalesTaxAuthoritiesDAL().GetSalesTaxAuthorities();
//                        //A sales tax code can have 1-5 authority.
//                        var autElement = from autl in el.Descendants("Authority")
//                                         select autl;
//                        // it will read it's related authorities that may be more than 1 
//                        // and add them in list 

//                        foreach (var autl in autElement)
//                        {
//                            foreach (var item in saletaxAuthorities)
//                            {
//                                if (item.AuthorityId == autl.Element("ID").Value)
//                                {
//                                    saletaxcode.SalesTaxAuthority.Add(item);
//                                }
//                            }
//                        }
//                        saletaxCodes.Add(saletaxcode);
//                    }
//                }
//                return saletaxCodes;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message, "GetSalesTaxCodes");
//                return saletaxCodes;
//            }

//        }
//    }
}

