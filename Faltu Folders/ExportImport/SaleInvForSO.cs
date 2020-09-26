namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class SaleInvForSO
    {
        private string fileNameXML = "EditSaleInvForSO.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;
        /// <summary>
        /// it will export the sales jrnal of given customer and date range.
        /// it aims on exporting the sale order number that has been used in sales invoice.
        /// </summary>
        /// <param name="cusid"></param>
        /// <param name="FromDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public bool ExportSaleInv(string cusid, DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export) this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesJournal);
                export.ClearExportFieldList();

                //the Quantity and SalesOrderDistNum is neceassary as it won't show the sale order number with out it.

                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ApplyToSalesOrder);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_SalesOrderNumber);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_SalesOrderDistNum);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Quantity);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ItemId);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Description);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_GLAccountId);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_UnitPrice);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_TaxType);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Amount);


                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_InvoiceDistNum);
                // export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ApplyToInvoiceDistNum);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Quote);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_IsCreditMemo);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_enProgressBillingInvoice);
                //export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_enApplyToProposal);
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(FileNameXML);
                export.SetFilterValue((short)PeachwIEObjSalesJournalFilter.peachwIEObjSalesJournalFilter_CustomerId , PeachwIEFilterOperation.peachwIEFilterOperationRange, cusid, cusid);
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

