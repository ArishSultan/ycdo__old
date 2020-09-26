namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class SerializedAssemblyItemList
    {
        private string fileNameCSV = "SerializedAssemblyItemList.csv";
        private string fileNameXML = "SerializedAssemblyItemList.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportItems(string itemId, string toitemid)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();
                export.SetFilterValue(0, PeachwIEFilterOperation.peachwIEFilterOperationRange, itemId, toitemid);
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

        public bool ImportHideAssemblyItem()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Import import = (Import)this.peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                import.ClearImportFieldList();
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Inactive);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_NumComp);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_RevisionNumber);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_EffectiveDate);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ComponentNumber);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ComponentID);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_QuantityNeeded);
                import.SetFileType(PeachwIEFileType.peachwIEFileTypeCSV);
                import.SetFilename(this.FileNameCSV);
                import.Import();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        public bool ImportNewItem()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Import import = (Import)this.peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                import.ClearImportFieldList();
                import.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                import.SetFilename(this.FileNameXML);
                import.Import();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        public bool ImportUPCandPartNoItem()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Import import = (Import)this.peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                import.ClearImportFieldList();
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_NumComp);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UPCSKU);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_RevisionNumber);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_EffectiveDate);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ComponentNumber);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ComponentID);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_QuantityNeeded);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PartNumber);
                import.SetFileType(PeachwIEFileType.peachwIEFileTypeCSV);
                import.SetFilename(this.FileNameCSV);
                import.Import();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
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

