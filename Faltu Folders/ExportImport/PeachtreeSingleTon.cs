namespace ExportImport
{
    using Interop.PeachwServer;
    using System;

    public class PeachtreeSingleTon
    {

        private static Application appObj;
        private static LoginClass login = new LoginClass();
        private DateTime[] acctPers;

        private DateTime[] StartDate = new DateTime[1];
        private DateTime[] EndDate = new DateTime[1];
        private int PeriodsPerYear;
        private int CurrentPeriod;
        private Array[] activeaccount;
        private String[] acctID = new String[1];
        private int[] acctType = new int[1];
        private String[] acctDesc = new String[1];
        private String[] acctGuid = new String[1];

        internal Application AppObj
        {
            get
            {

                if (appObj == null) appObj = (Application)login.GetApplication("SKS Consulting Inc", "1N6276XFP018X6L");
                return appObj;
            }
        }
        public Array[] GetActiveAccountsWithGuid()
        {
            activeaccount = new Array[4];

            appObj.GetActiveAccountsWithGuid(out acctID, out acctType, out acctDesc, out acctGuid);
            activeaccount[0] = acctID;
            activeaccount[1] = acctType;
            activeaccount[2] = acctDesc;
            activeaccount[3] = acctGuid;
            return activeaccount;
        }

        /// <summary>
        /// it will have null values when peachtree company is closed.
        /// </summary>
        public string CurrentCompanyGUID
        {
              get { return   AppObj.CurrentCompanyGUID; }
        //get{ return  "{ED78C510-14A9-4efb-9874-C9558B085082}"; }
            // set { CurrentCompanyGUID = value; }
            
        }
        /// <summary>
        /// It will return Current Company Name.
        /// </summary>
        public string CurrentCompanyName
        {
            get { return AppObj.CurrentCompanyName; }

        }
        public string CompanyPath
        {
            get { return AppObj.CompanyPath; }

        }
        /// <summary>
        /// Return Peach tree Data files 
        /// </summary>
        public String DataPath
        {
            get { return AppObj.DataPath; }
        }
        /// <summary>
        /// Return Serial Number of peach tree.
        /// </summary>
        public string SerialNumber
        {
            get { return AppObj.SerialNumber; }

        }
        /// <summary>
        /// Return Customer Number of Peach tree.
        /// </summary>
        public string CustomerNumber
        {
            get { return AppObj.CustomerNumber; }

        }
        private void GetAccountingPeriods()
        {
            // acctPers = new DateTime  [3];
            //= new int [1];
            //appObj.GetAccountingPeriods(out periodsPerYear,out  CurrentPeriod, acctPers[0], acctPers[1]);
            AppObj.GetAccountingPeriods(out PeriodsPerYear, out CurrentPeriod, out  StartDate, out EndDate);
        }
        /// <summary>
        /// it will give first day of fiscal year.
        /// i.e. company has 2 fiscal year 2009 and 2010.
        /// then it will give 1 jan 2009
        /// </summary>
        /// <returns></returns>
        public DateTime GetFirstDay()
        {
            GetAccountingPeriods();
            return StartDate[0 + 12];//13);
        }
        /// <summary>
        /// it will give last day of fiscal year 
        ///  i.e. company has 2 fiscal year 2009 and 2010.
        /// then it will give 31 Dec 2010.
        /// </summary>
        /// <returns></returns>
        public DateTime GetLastDay()
        {
            GetAccountingPeriods();
            return EndDate[PeriodsPerYear + 23]; //( + 13);

        }
        public DateTime GetCurrentPeriod()
        {
            GetAccountingPeriods();
            int curper = CurrentPeriod;
            //peachtree gets the period in ODD manner ,this is not EVen odd,


            //we have 36 total periods in case of 12 per year periods
            //we need to get info from these 36 periods
            if (CurrentPeriod >= 1 && CurrentPeriod <= 12)
                curper = curper;
            else if (CurrentPeriod >= 15 && CurrentPeriod <= 26)

                curper = curper - 3;
            else if (CurrentPeriod >= 29 && CurrentPeriod <= 40)

            { curper = curper - 5; }
            return StartDate[curper];

        }
        public DateTime SystemDate
        {
            get { return AppObj.SystemDate; }
        }

    }  
}

