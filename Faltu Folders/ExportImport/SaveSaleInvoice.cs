namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class SaveSaleInvoice
    {
        private string fileNameCSV = "SaveUSTSaleInvoice.csv";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool DeleteSaleInvoice(ref string[] recToDel)
        {
            bool flag;
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                this.peachtreeObj.AppObj.DeleteRecord(PeachBusObjects.pboSalesEntry, PeachObjectKey.pboKey_ByGUID, ref recToDel);
                flag = true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return flag;
        }

        public string[] ImportSaleInvoice()
        {
            string[] gUIDs = new string[1];
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Import import = (Import)this.peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjSalesJournal);
                import.ClearImportFieldList();
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_CustomerId);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_CustomerName);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_InvoiceNumber);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Date);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Quote);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_QuoteNumber);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_QuoteGoodThruDate);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_DropShip);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipToName);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipToAddressLine1);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipToAddressLine2);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipToCity);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipToState);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipToZip);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipToCountry);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_CustomerPurchaseOrder);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipVia);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipDate);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_DateDue);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_DiscountAmount);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_DiscountDate);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_DisplayedTerms);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_SalesRepId);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ARAccountId);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ARAmount);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_SalesTaxCode);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_InvoiceNote);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_NotePrintsAfterLineItems);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_StatementNote);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_StatementNotePrintsBeforeInvoiceRef);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_BeginningBalanceTransaction);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_DateClearedInAccountRec);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_NumberOfDistributions);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ApplyToSalesOrder);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_SalesOrderNumber);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_SalesOrderDistNum);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Quantity);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ItemId);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Description);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_GLAccountId);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_UnitPrice);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_TaxType);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Amount);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_InventoryAccountId);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_CostOfSalesAccountId);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_CostOfSalesAmount);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_JobId);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_SalesTaxAuthority);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_TransactionPeriod);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_TransactionNumber);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ReceiptNum);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_InvoiceNote2);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_ShipByDate);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_TransactionGUID);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_UPCSKU);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Weight);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_ApplyToInvoiceNumber);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_ReturnAuthorization);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_InvoiceDistNum);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ApplyToInvoiceDistNum);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_IsCreditMemo);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_CustomerGUID);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_SalesRepresentativeGUID);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_ARAccountGUID);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_ItemGUID);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_GLAccountGUID);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_INVAccountGUID);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_COSTAccountGUID);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_JobGUID);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_enGL_DateClearedInBankRec);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_enInvAcntDateClearedInBankRec);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_enCOSAcntDateClearedInBankRec);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_enUMID);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_enUMStockingUnits);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_enStockingQuantity);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_enUMStockingUnitPrice);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_enSerialNumber);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesJournalField .peachwIEObjSalesJournalField_enVoidedBy);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_enRetainagePercent);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_enProgressBillingInvoice);
                import.AddToImportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_enApplyToProposal);
                import.SetFileType(PeachwIEFileType.peachwIEFileTypeCSV);
                import.SetFilename(this.FileNameCSV);
                import.ImportAndReturnGUIDs(out gUIDs);
                return gUIDs;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return gUIDs;
            }
        }

        public string FileNameCSV
        {
            get
            {
                return (this.path + this.fileNameCSV);
            }
            set
            {
                this.fileNameCSV = value;
            }
        }
    }
}

