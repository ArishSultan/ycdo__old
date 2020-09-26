namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class SaveSaleOrder
    {
        private string fileNameCSV = "SaveUSTSaleOrder.csv";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool DeleteSaleOrder(ref string[] recToDel)
        {
            bool flag;
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                this.peachtreeObj.AppObj.DeleteRecord(PeachBusObjects.pboSalesOrderEntry, PeachObjectKey.pboKey_ByGUID, ref recToDel);
                flag = true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return flag;
        }

        public string[] ImportSaleOrder()
        {
            string[] gUIDs = new string[1];
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Import import = (Import)this.peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjSalesOrders);
                import.ClearImportFieldList();
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_CustomerId);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_CustomerName);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_SalesOrderNumber);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_Date);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_SalesOrderClosed);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_QuoteNumber);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_DropShip);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ShipToName);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ShipToAddressLine1);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ShipToAddressLine2);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ShipToCity);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ShipToState);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ShipToZip);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ShipToCountry);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_CustomerPurchaseOrder);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ShipVia);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_DiscountAmount);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_DisplayedTerms);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_SalesRepId);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ARAccountId);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ARAmount);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_SalesTaxCode);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_InvoiceNote);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_NotePrintsAfterLineItems);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_StatementNote);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_StatementPrintsBeforeInvoiceRef);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_NumberOfDistributions);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_SalesOrderDistNum);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_Quantity);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ItemId);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_Description);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_GLAccountId);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_UnitPrice);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_TaxType);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_Amount);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_JobId);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_SalesTaxAuthority);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_TransactionPeriod);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_TransactioNumber);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_InvoiceNote2);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ShipByDate);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_TransactionGUID);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_UPCSKU);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_Weight);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_CustomerGUID);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_SalesRepresentativeGUID);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ARAccountGUID);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_GLAccountGUID);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ItemGUID);
                //imp.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_JobGUID);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_enUMID);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_enUMStockingUnits);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_enStockingQuantity);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_enUMStockingUnitPrice);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_enProposal);
                import.AddToImportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_enProposalAccepted);
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

