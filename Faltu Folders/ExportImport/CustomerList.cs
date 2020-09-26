namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class CustomerList
    {
        private string fileNameExportxml = "CustomerList.xml";
        private string fileNameImportCSV = "CustomerImport.csv";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

      

        public bool ExportCustomer()
        {
            try
            {
                
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjCustomerList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerInactive);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerId);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerName);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerContact);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToAddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToAddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToCity);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToState);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToZip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToCountry);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerPhone1 );
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerGUID);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToTaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerOpenPurchaseOrder);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipVia);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipViaText);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerSalesRep);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerSalesRepGUID);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerUseStandardTerms);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerCODTerms);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerPrePayTerms);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerDueDays);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerDayIsActual);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerDiscountDays);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerDiscountPercent);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerDueMonthEnd);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerCategory);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerPriceLevel);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19TaxCode);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20Name);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20AddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20AddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20City);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20State);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20Zip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20Country);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20TaxCode);
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameExportXML);
                export.Export();
                CommonFunction.GetUTF8Supported_XmlFilePath(this.FileNameExportXML, this.FileNameExportXML);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        /// <summary>
        /// Export Balance,Credit Limit,Credit Status of given Customer.
        /// </summary>
        /// <param name="cusid"></param>
        /// <returns></returns>
        public bool ExportCustomer(String cusid)
        {


            try
            {
                peachtreeObj = new PeachtreeSingleTon();
                Export exp = (Export)peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjCustomerList);
                exp.ClearExportFieldList();
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerInactive);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerId);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerGUID);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBalance);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerCreditLimit);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerCreditStatus);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerChargeInt);
                exp.SetFilterValue((short)PeachwIEObjCustomerListFilter.peachwIEObjCustomerListFilter_CustomerId, PeachwIEFilterOperation.peachwIEFilterOperationRange, cusid, cusid);

                exp.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                exp.SetFilename(FileNameExportXML);
                exp.Export();
                CommonFunction.GetUTF8Supported_XmlFilePath(FileNameExportXML, FileNameExportXML);
                return true;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool ExportCustomer20ShipAddress(String cusid)
        {


            try
            {
                peachtreeObj = new PeachtreeSingleTon();
                Export exp = (Export)peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjCustomerList);
                exp.ClearExportFieldList();
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerInactive);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerId);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerGUID);
                //export the 2o ship to address of customer.
                //addres 1
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo1TaxCode);
                //addres 2
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo2TaxCode);
                //addres 3
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo3TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo4TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo5TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo6TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo7TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo8TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo9TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo10TaxCode);


                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo11TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo12TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo13TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo14TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo15TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo16TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo17TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo18TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo19TaxCode);

                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20Name);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20AddressLine1);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20AddressLine2);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20City);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20State);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20Zip);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20Country);
                exp.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerShipTo20TaxCode);



                exp.SetFilterValue((short)PeachwIEObjCustomerListFilter.peachwIEObjCustomerListFilter_CustomerId, PeachwIEFilterOperation.peachwIEFilterOperationRange, cusid, cusid);

                exp.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                exp.SetFilename(FileNameExportXML);
                exp.Export();
                CommonFunction.GetUTF8Supported_XmlFilePath(FileNameExportXML, FileNameExportXML);
                return true;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        /// <summary>
        /// it will export only customer ID's and price level and guid
        /// </summary>
        /// <returns></returns>
        public bool ExportCustomerIDandPriceLevel()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjCustomerList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerInactive);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerId);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerGUID);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerName);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerPriceLevel);
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameExportXML);
                export.Export();
                CommonFunction.GetUTF8Supported_XmlFilePath(this.FileNameExportXML, this.FileNameExportXML);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        public bool ExportCustomerSSP()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjCustomerList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerInactive);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerId);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerName);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerCategory);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerGUID);
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameExportXML);
                export.Export();
                CommonFunction.GetUTF8Supported_XmlFilePath(this.FileNameExportXML, this.FileNameExportXML);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        public bool ExportCustomerUST()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjCustomerList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerInactive);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerId);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerName);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerContact);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToAddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToAddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToCity);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToState);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToZip);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToCountry);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerGUID);
                export.AddToExportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerBillToTaxCode);
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameExportXML);
                export.Export();
                CommonFunction.GetUTF8Supported_XmlFilePath(this.FileNameExportXML, this.FileNameExportXML);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        /// <summary>
        /// Import Customer Use default term,Charge Finance Charges only.
        /// </summary>
        /// <returns></returns>
        public Boolean ImportCustomerFinanceCharges()
        {
            string FileNameExportXML = FileNameImportCSV;
            try
            {

                peachtreeObj = new PeachtreeSingleTon();
                Import impcus = (Import)peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjCustomerList);
                impcus.ClearImportFieldList();
                impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerId);

                //the below fields are neceassary to import the Charge Finance Charges of customer
                impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerUseStandardTerms);
                //impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerChargeInt);
                impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerCreditStatus);
                impcus.SetFilename(FileNameExportXML);
                impcus.SetFileType(PeachwIEFileType.peachwIEFileTypeCSV);

                impcus.Import();
                return true;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        /// Import the Term of the customer 
        /// </summary>
        /// <returns></returns>
        public Boolean ImportCustomerTerm()
        {
            string FileNameExportXML = FileNameImportCSV;
            try
            {

                peachtreeObj = new PeachtreeSingleTon();
                Import impcus = (Import)peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjCustomerList);
                impcus.ClearImportFieldList();
                impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerId);

                //the below fields are neceassary to import the Term info of customer
                impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerUseStandardTerms);
                impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerCODTerms);
                impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerPrePayTerms);
                impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerDueDays);
                impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerDiscountDays);
                impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerDiscountPercent);
                impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerDueMonthEnd);
                //this is the Credit Finance Charges.
                impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerChargeInt);
                impcus.AddToImportFieldList((short)PeachwIEObjCustomerListField.peachwIEObjCustomerListField_CustomerCreditStatus);
                impcus.SetFilename(FileNameExportXML);
                impcus.SetFileType(PeachwIEFileType.peachwIEFileTypeCSV);

                impcus.Import();
                return true;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public string FileNameExportXML
        {
            get
            {
                return (this.path + this.fileNameExportxml);
            }
            set
            {
                this.fileNameExportxml = value;
            }
        }

        public string FileNameImportCSV
        {
            get
            {
                return (this.path + this.fileNameImportCSV);
            }
            set
            {
                this.fileNameImportCSV = value;
            }
        }
    }
}

