namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class EditSaleOrder
    {
        private string fileNameXML = "EditUSTSaleOrder.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportEditSaleOrder(string saleordernumber, DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesOrders);
                export.ClearExportFieldList();
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);

                //so number is unique in peachtree

                export.SetFilterValue((short) PeachwIEObjSalesOrdersFilter.peachwIEObjSalesOrdersFilter_SalesOrderNumber , PeachwIEFilterOperation.peachwIEFilterOperationRange, saleordernumber, saleordernumber);
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

        public bool ExportEditSaleOrderShortList(DateTime FromDate, DateTime EndDate)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesOrders);
                export.ClearExportFieldList();
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                //so number is unique in peachtree
                //first list fields for distinction between Sale Order & other Transactions
                export.AddToExportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_enProposal);
                //short list
                export.AddToExportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_ARAmount);
                export.AddToExportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_CustomerId);
                export.AddToExportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_Date);
                export.AddToExportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_SalesOrderNumber);
                export.AddToExportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_TransactionGUID);
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

        public bool ExportSaleOrderGUIDAndNO(DateTime FromDate, DateTime EndDate, string saleordernumber)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjSalesOrders);
                export.ClearExportFieldList();
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                //first list fields for distinction between Sale Order & other Transactions
                export.AddToExportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_enProposal);
                //short list
                export.AddToExportFieldList((short)PeachwIEObjSalesOrdersField.peachwIEObjSalesOrdersField_TransactionGUID);
                //so number is unique in peachtree
                export.SetFilterValue((short) PeachwIEObjSalesOrdersFilter.peachwIEObjSalesOrdersFilter_SalesOrderNumber , PeachwIEFilterOperation.peachwIEFilterOperationRange, saleordernumber, saleordernumber);
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

