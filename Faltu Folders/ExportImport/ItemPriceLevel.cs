namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class ItemPriceLevel
    {
        private string fileNameXML = "InventoryItemsPriceList.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportInventoryItemPrices(string itemid)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Inactive);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeId1);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice1);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice2);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice3);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice4);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice5);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice6);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice7);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice8);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice9);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice10);
                export.SetFilterValue((short)PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemId, PeachwIEFilterOperation.peachwIEFilterOperationRange, itemid, itemid);
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

