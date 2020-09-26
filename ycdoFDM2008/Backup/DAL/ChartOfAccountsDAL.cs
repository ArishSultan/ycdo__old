namespace DAL.Quotes
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;

    //public class ChartOfAccountsDAL
    //{
    //    private ChartofAccount chartofAccount;
    //    private ChartOfAccount chartOfaccount;
    //    private List<ChartOfAccount> chartofAccounts;



  
    //    public List<ChartOfAccount> GetChartofAccounts()
    //    {
    //        try
    //        {
    //            chartofAccount = new ChartofAccount();
    //            if (chartofAccount.ExportChartofAccount() == true)
    //            {
    //                chartofAccounts = new List<ChartOfAccount>();

    //                XElement xdoc = XElement.Load(chartofAccount.FileNameXML);
    //                var charElement = from el in xdoc.Elements("PAW_Account")
    //                                  select el;

    //                foreach (var el in charElement)
    //                {

    //                    if (el.Element("isInactive").Value == "FALSE")
    //                    {
    //                        chartOfaccount = new ChartOfAccount();
    //                        chartOfaccount.AccountId = el.Element("ID").Value;
    //                        chartOfaccount.Description = el.Element("Acct_Type_Description").Value;
    //                        chartOfaccount.GuId = el.Element("GUID").Value;
    //                        chartOfaccount.Type = (ChartofAccountType)Convert.ToInt16(el.Element("Type").Value);
    //                        chartofAccounts.Add(chartOfaccount);
    //                    }
    //                }
    //            }

    //            return chartofAccounts;
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message, "GetChartofAccounts");
    //            return chartofAccounts;
    //        }

    //    }
    //}
}

