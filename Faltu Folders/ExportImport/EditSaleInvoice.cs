namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class EditSaleInvoice
    {
        private string fileNameXML = "SaleInvoice.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportEditSaleInvNumber(DateTime FromDate, DateTime EndDate, string invno)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesJournal);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Quote);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_IsCreditMemo);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_enProgressBillingInvoice);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_TransactionGUID);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_InvoiceNumber);
                
                export.SetDateFilterValue(PeachwIEDateFilterOperation.peachwIEDateFilterOperationRange, FromDate, EndDate);
                export.SetFilterValue((short)PeachwIEObjSalesJournalFilter.peachwIEObjSalesJournalFilter_InvoiceNumber, PeachwIEFilterOperation.peachwIEFilterOperationRange, invno, invno);
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

        public bool ExportEditSaleInvoice(string cusid, DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesJournal);
                export.ClearExportFieldList();
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameXML);
                export.SetFilterValue((short)PeachwIEObjSalesJournalFilter.peachwIEObjSalesJournalFilter_CustomerId, PeachwIEFilterOperation.peachwIEFilterOperationRange, cusid, cusid);
                export.SetDateFilterValue(PeachwIEDateFilterOperation.peachwIEDateFilterOperationRange, FromDate, EndDate);
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

        public bool ExportEditSaleInvoice(string saleinvoiceno, string cusid, DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesJournal);
                export.ClearExportFieldList();
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameXML);
                export.SetFilterValue((short)PeachwIEObjSalesJournalFilter.peachwIEObjSalesJournalFilter_InvoiceNumber, PeachwIEFilterOperation.peachwIEFilterOperationRange, saleinvoiceno, saleinvoiceno);
                export.SetFilterValue((short)PeachwIEObjSalesJournalFilter.peachwIEObjSalesJournalFilter_CustomerId, PeachwIEFilterOperation.peachwIEFilterOperationRange, cusid, cusid);
                export.SetDateFilterValue(PeachwIEDateFilterOperation.peachwIEDateFilterOperationRange, FromDate, EndDate);
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

        public bool ExportEditSaleInvShortList(DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesJournal);
                export.ClearExportFieldList();
                
                //following are used to distinguish b/w quote -Credit Memo -Progres Billing from Invoice 
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Quote);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_IsCreditMemo);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_enProgressBillingInvoice);



                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_CustomerId);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Date);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_InvoiceNumber);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ARAmount);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_TransactionGUID);
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

        public bool ExportSaleInvGuid(DateTime FromDate, DateTime EndDate, string invno, string cusid)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesJournal);
                export.ClearExportFieldList();

                //following are used to distinguish b/w quote -Credit Memo -Progres Billing from Invoice 
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Quote);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_IsCreditMemo);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_enProgressBillingInvoice);


                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_TransactionGUID);
                export.SetDateFilterValue(PeachwIEDateFilterOperation.peachwIEDateFilterOperationRange, FromDate, EndDate);
                export.SetFilterValue((short)PeachwIEObjSalesJournalFilter.peachwIEObjSalesJournalFilter_CustomerId, PeachwIEFilterOperation.peachwIEFilterOperationRange, cusid, cusid);
                export.SetFilterValue((short)PeachwIEObjSalesJournalFilter.peachwIEObjSalesJournalFilter_InvoiceNumber, PeachwIEFilterOperation.peachwIEFilterOperationRange, invno, invno);
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


        public bool ExportSaleInvoice(DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesJournal);
                export.ClearExportFieldList();

              
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_CustomerId);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_InvoiceNumber);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_CustomerName);
                
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_DropShip);

                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipToName);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipToAddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipToAddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipToCity);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipToState);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipToZip);

                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Date);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_TransactionGUID);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_CustomerPurchaseOrder);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ShipVia);

                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ARAccountId);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ARAmount);

                ////following are used to distinguish b/w quote -Credit Memo -Progres Billing from Invoice 
                ////below 4 are for filtering invoice only
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_BeginningBalanceTransaction);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_IsCreditMemo);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Quote);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_enProgressBillingInvoice );
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_NumberOfDistributions);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_SalesOrderDistNum);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Quantity);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ItemId);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ItemGUID );
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Description);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_GLAccountId);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_GLAccountGUID );
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_UnitPrice);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Amount);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_TaxType );
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_SalesTaxAuthority);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_SalesRepId);
                ////export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_UPCSKU);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_CostOfSalesAmount);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_TransactionGUID);
                
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


 
      
        public string FileNameXML
        {
            get
            {
                return (this.path + this.fileNameXML);
            }
            set
            {
                this.fileNameXML = value;
            }
        }
    }
}

