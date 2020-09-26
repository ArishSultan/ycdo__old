namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class EditQuote
    {
        private string fileNameXML = "EditUSTQuote.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportEditQuote(string cusid, DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesJournal);
                export.ClearExportFieldList();
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilterValue((short)PeachwIEObjSalesJournalFilter.peachwIEObjSalesJournalFilter_CustomerId , PeachwIEFilterOperation.peachwIEFilterOperationRange, cusid, cusid);
                export.SetDateFilterValue(PeachwIEDateFilterOperation.peachwIEDateFilterOperationRange, FromDate, EndDate);
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

        public bool ExportEditQuoteShortList(DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesJournal);
                export.ClearExportFieldList();
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);

                //_Quote=true means it is qute 

                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Quote);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_CustomerId);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Date);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_QuoteNumber);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_ARAmount);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_TransactionGUID);
                export.SetDateFilterValue(PeachwIEDateFilterOperation.peachwIEDateFilterOperationRange, FromDate, EndDate);
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

        public bool ExportQuoteGUID(DateTime FromDate, DateTime EndDate, string cusid)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesJournal);
                export.ClearExportFieldList();
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                //_Quote=true means it is qute 
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Quote);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_TransactionGUID);
                export.SetFilterValue((short)PeachwIEObjSalesJournalFilter.peachwIEObjSalesJournalFilter_CustomerId, PeachwIEFilterOperation.peachwIEFilterOperationRange, cusid, cusid);
                export.SetDateFilterValue(PeachwIEDateFilterOperation.peachwIEDateFilterOperationRange, FromDate, EndDate);
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

        public bool ExportQuoteNumber(DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesJournal);
                export.ClearExportFieldList();
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                //_Quote=true means it is qute 
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_Quote);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_QuoteNumber);
                export.AddToExportFieldList((short)PeachwIEObjSalesJournalField.peachwIEObjSalesJournalField_TransactionGUID);
                export.SetDateFilterValue(PeachwIEDateFilterOperation.peachwIEDateFilterOperationRange, FromDate, EndDate);
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

