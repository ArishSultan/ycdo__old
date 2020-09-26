namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class ItemAccountList
    {
        private string fileNameCSV = "ItemAccountList.csv";
        private string fileNameCSV1 = "ItemAccountList1.csv";
        private string fileNameCSV2 = "ItemAccountList2.csv";
        private string fileNameCSV3 = "ItemAccountList3.csv";
        private string fileNameXML = "ItemAccountList.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ImportAssemblyAccountsType()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Import import = (Import)this.peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                import.ClearImportFieldList();
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesAccountId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InventoryAccountId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InvChgAccountId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_NumComp);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_RevisionNumber);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_EffectiveDate);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ComponentNumber);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ComponentID);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_QuantityNeeded);
                import.SetFileType(PeachwIEFileType.peachwIEFileTypeCSV);
                import.SetFilename(this.FileNameCSV2);
                import.Import();
                return true;
            }
            catch (Exception exception)
            {
               // MessageBox.Show(exception.Message);
                return false;
            }
        }

        public bool ImportNonAssemblyItemAccount()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Import import = (Import)this.peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                import.ClearImportFieldList();
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesAccountId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InventoryAccountId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InvChgAccountId);
                import.SetFileType(PeachwIEFileType.peachwIEFileTypeCSV);
                import.SetFilename(this.FileNameCSV1);
                import.Import();
                return true;
            }
            catch (Exception exception)
            {
              //  MessageBox.Show(exception.Message);
                return false;
            }
        }

        public bool ImportSerializedAssemblyAccountsType()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Import import = (Import)this.peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                import.ClearImportFieldList();
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesAccountId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InventoryAccountId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InvChgAccountId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_NumComp);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_RevisionNumber);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_EffectiveDate);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ComponentNumber);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ComponentID);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_QuantityNeeded);
                import.SetFileType(PeachwIEFileType.peachwIEFileTypeCSV);
                import.SetFilename(this.FileNameCSV3);
                import.Import();
                return true;
            }
            catch (Exception exception)
            {
               // MessageBox.Show(exception.Message);
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

        public string FileNameCSV1
        {
            get
            {
                return (this.path + this.fileNameCSV1);
            }
            set
            {
                this.fileNameCSV1 = value;
            }
        }
        public string FileNameCSV2
        {
            get
            {
                return (this.path + this.fileNameCSV2);
            }
            set
            {
                this.fileNameCSV2 = value;
            }
        }

        public string FileNameCSV3
        {
            get
            {
                return (this.path + this.fileNameCSV3);
            }
            set
            {
                this.fileNameCSV3 = value;
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

