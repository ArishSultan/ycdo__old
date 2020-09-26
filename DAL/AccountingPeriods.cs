namespace DAL
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;

    //public class AccountingPeriods
    //{
    //    private AccountPeriods accountperiod;
    //    private AccountingPeriodsList accountperiodList;
    //    private PeachtreeSingleTon peachobj;

    //    public AccountPeriods GetAccountingPeriods()
    //    {
    //        try
    //        {
    //            accountperiod = new AccountPeriods();
    //            peachobj = new PeachtreeSingleTon();
    //            accountperiodList = new AccountingPeriodsList();
    //            accountperiod.CurrentPeriod = peachobj.GetCurrentPeriod();
    //            if (accountperiodList.ExportAccountingPeriods() == true)
    //            {

    //                XElement xdoc = XElement.Load(accountperiodList.FileNameXML);
    //                var xquot = from el in xdoc.Descendants("PAW_Accounting_Period")
    //                            select el;
    //                foreach (var el in xquot)
    //                {
    //                    accountperiod.PeriodPerYear = Convert.ToInt32(el.Element("NumberOfPeriodsPerYear").Value);
    //                    var accperd = from perd in el.Element("Periods").Descendants("Period")
    //                                  select perd;
    //                    foreach (var ped in accperd)
    //                    {
    //                        accountperiod.PeriodNumber.Add(Convert.ToInt32(ped.Element("Number").Value));
    //                        accountperiod.Periods.Add(Convert.ToString(ped.Element("BeginDate").Value + " to " + ped.Element("EndDate").Value));


    //                    }
    //                }
    //            }
    //            return accountperiod;
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetAccountingPeriods");
    //            return accountperiod;
    //        }

    //    }
    //}
}

