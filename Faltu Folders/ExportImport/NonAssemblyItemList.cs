namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class NonAssemblyItemList
    {
        private string fileNameCSV = "NonAssemblyItemList.csv";
        private string fileNameXML = "NonAssemblyItemList.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportItems(string itemId, string toitemId, short itemClass)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();
                export.SetFilterValue((short)  PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemId  , PeachwIEFilterOperation.peachwIEFilterOperationRange, itemId, toitemId);
                switch (itemClass)
                {
                    case 0:
                        export.SetFilterValue((short)PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemClass , PeachwIEFilterOperation.peachwIEFilterOperationEqualTo, "Non-stock item", "Non-stock item");
                        break;

                    case 1:
                        export.SetFilterValue((short)PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemClass , PeachwIEFilterOperation.peachwIEFilterOperationEqualTo, "Stock item", "Stock item");
                        break;

                    case 2:
                        export.SetFilterValue((short)PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemClass , PeachwIEFilterOperation.peachwIEFilterOperationEqualTo, "Description only", "Description only");
                        break;

                    case 4:
                        export.SetFilterValue((short)PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemClass , PeachwIEFilterOperation.peachwIEFilterOperationEqualTo, "Service", "Service");
                        break;

                    case 5:
                        export.SetFilterValue((short)PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemClass , PeachwIEFilterOperation.peachwIEFilterOperationEqualTo, "Labor", "Labor");
                        break;

                    case 6:
                        export.SetFilterValue((short)PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemClass , PeachwIEFilterOperation.peachwIEFilterOperationEqualTo, "Activity item", "Activity item");
                        break;

                    case 7:
                        export.SetFilterValue((short)PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemClass , PeachwIEFilterOperation.peachwIEFilterOperationEqualTo, "Charge item", "Charge item");
                        break;
                }
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

        public bool ImportHideItem()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Import import = (Import)this.peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                import.ClearImportFieldList();
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Inactive);
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
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UPCSKU);
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

