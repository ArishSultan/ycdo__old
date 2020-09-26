using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
// using ExportImport;

using System.Windows.Forms;
using System.Xml.Linq;

namespace DAL
{
    //public  class DefaultAccountsDAL
    //{
    //    ChartOfAccount ch;
    //    DefaultAccountsList defAccLst;

    //    public ChartOfAccount GetFreightAccount()
    //    {
    //        ch = new ChartOfAccount();
    //        try
    //        {
    //            defAccLst = new DefaultAccountsList ();
    //            if (defAccLst.ExportDefaultAccounts () == true)
    //            {
                    
    //                XElement xdoc = XElement.Load(defAccLst.FileNameXML);
    //                var xjob = from el in xdoc.Elements("PAW_DefaultAccount")
    //                           select el;

    //                foreach (var el in xjob)
    //                {
    //                    if(el.Element("Freight")  !=null )
    //                    ch.AccountId = el.Element("Freight") == null ? "" :Convert.ToString   ( el.Element("Freight").Value);
                         
                        
    //                }
    //            }

    //            return ch;
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message, "GetFreightAccount");
    //            return ch;
    //        }

    //    }


    //}
}
