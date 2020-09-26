namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class SaleOrdersForInvoice
    {
        private string fileNameXML = "EditSaleOrdersForInvoice.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportSaleOrder(DateTime FromDate, DateTime EndDate, string salordernumber)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export) this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesOrders);
                export.ClearExportFieldList();
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameXML);
                export.SetFilterValue(0, PeachwIEFilterOperation.peachwIEFilterOperationRange, salordernumber, salordernumber);
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

        public bool ExportSaleOrder(string cusid, DateTime FromDate, DateTime EndDate, string salordernumber)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesOrders);
                export.ClearExportFieldList();
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameXML);
                export.SetFilterValue(0, PeachwIEFilterOperation.peachwIEFilterOperationRange, salordernumber, salordernumber);
                export.SetFilterValue((short)PeachwIEObjSalesOrdersFilter.peachwIEObjSalesOrdersFilter_CustomerId, PeachwIEFilterOperation.peachwIEFilterOperationRange , cusid, cusid);

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

        public bool ExportSaleOrder(string cusid, DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export) this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesOrders);
                export.ClearExportFieldList();
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameXML);
                export.SetFilterValue(1, PeachwIEFilterOperation.peachwIEFilterOperationRange, cusid, cusid);
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


        public bool ExportSaleOrderNumbers(string cusid, DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesOrders);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_enProposal);
                export.AddToExportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_SalesOrderClosed );
                export.AddToExportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_SalesOrderNumber );
                export.AddToExportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_TransactionGUID);
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameXML);
                export.SetFilterValue(1, PeachwIEFilterOperation.peachwIEFilterOperationRange, cusid, cusid);
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

