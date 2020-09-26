namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class CashReceiptJournal
    {
        private string fileNameXML = "CashReceiptJournal.xml";

        public  string FilNameCSV { get { return path + "CashReceiptJournal.CSV"; } }
        public string FileNameXML
        {
            get { return (this.path + this.fileNameXML); }
            set { this.fileNameXML = value; }
        }
            
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportReceipt(string cusid, DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjCashReceiptsJournal);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_CustomerId);
                export.AddToExportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_InvoicePaid);
                export.AddToExportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_ReceiptNumber);
                export.AddToExportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_Reference);
                export.AddToExportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_CashAmount);
                export.SetFilterValue((short)PeachwIEObjCashReceiptsJournalFilter.peachwIEObjCashReceiptsJournalFilter_CustomerId, PeachwIEFilterOperation.peachwIEFilterOperationRange, cusid, cusid);
                export.SetDateFilterValue(PeachwIEDateFilterOperation.peachwIEDateFilterOperationRange, FromDate, EndDate);
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameXML);
                export.Export();
                CommonFunction.GetUTF8Supported_XmlFilePath(this.FileNameXML, this.FileNameXML);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }


        public bool ExportReceipt(  DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjCashReceiptsJournal);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_CustomerId);
                export.AddToExportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_InvoicePaid);
                export.AddToExportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_ReceiptNumber);
                export.AddToExportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_Reference);
                export.AddToExportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_DiscountAmount);
                export.AddToExportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_Amount);
                export.AddToExportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_Date );
                

                
                export.SetDateFilterValue(PeachwIEDateFilterOperation.peachwIEDateFilterOperationRange, FromDate, EndDate);
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameXML);
                export.Export();
                CommonFunction.GetUTF8Supported_XmlFilePath(this.FileNameXML, this.FileNameXML);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        public bool ImportReceipt()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Import import = (Import)this.peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjCashReceiptsJournal );
                import.ClearImportFieldList();

                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_DepositTicketId);

                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_CustomerId );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_CustomerName );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_Reference );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_Date );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_PayMethod );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_CashAccountId );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_CashAmount );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_SalesRepId );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_SalesTaxCode );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_TotalPaidOnInvoices );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_DiscountAccountId );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_VendorReceipt);


                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_Prepayment );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_NumberOfDistributions );

                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_InvoicePaid );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_DiscountAmount );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_Quantity);
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_ItemId );

                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_Description);
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_GLAccountId );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_UnitPrice );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_TaxType );

                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_Amount);
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_InventoryAccountId );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_CostOfSalesAccountId );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_CostOfSalesAmount);

                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_JobId);
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_SalesTaxAuthority);
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_ReceiptNumber );

                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_UPCSKU );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_Weight);

                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_enGL_DateClearedInBankRec);
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_enInvAcntDateClearedInBankRec );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_enCOSAcntDateClearedInBankRec);
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_enDiscDateClearedInBankRec);
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_enUMID );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_enUMStockingUnits );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_enStockingQuantity );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_enUMStockingUnitPrice );
                import.AddToImportFieldList((short)PeachwIEObjCashReceiptsJournalField.peachwIEObjCashReceiptsJournalField_enSerialNumber );

                import.SetFileType(PeachwIEFileType.peachwIEFileTypeCSV);
                import.SetFilename(FilNameCSV);
                import.Import();
                
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ImportReceipt");
            }
            return false;
        }
    }
}

