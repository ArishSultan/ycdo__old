namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class InventoryItemsList
    {
        private string fileNameCSV = "InventoryItemsList.csv";
        private string fileNameXML = "InventoryItemsList.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportInventoryItem()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Inactive);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_GUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemDescription);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesDesc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesAccountGUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesAccountId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_QuantityOnHand);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitOfMeasure);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InventoryAccountId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InventoryAccountGUID);
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
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Class);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UPCSKU);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Weight);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesTaxType);
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

        public bool ExportInventoryItem(string itemclass)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Inactive);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_GUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemDescription);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Class);
                export.SetFilterValue((short)PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemClass, PeachwIEFilterOperation.peachwIEFilterOperationEqualTo, itemclass, "");
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

        public bool ExportItemClass(string itemid)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Inactive);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_GUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Class);
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

        public bool ExportItemID(string fromItemId,string toItemId)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();

                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_GUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Class);

                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilterValue((short)PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemId, PeachwIEFilterOperation.peachwIEFilterOperationRange, fromItemId, toItemId);
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
        public bool ExportInventoryItemHRB()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Inactive);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_GUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Class);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Category);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_QuantityOnHand);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemDescription);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_LaborCost);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesDesc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesAccountGUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesAccountId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitOfMeasure);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InventoryAccountId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InventoryAccountGUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InvChgAccountId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InvChgAccountGUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UPCSKU);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Weight);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesTaxType);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice1);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price1Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price1Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price1RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice2);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price2Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price2Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price2RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice3);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price3Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price3Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price3RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice4);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price4Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price4Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price4RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice5);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price5Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price5Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price5RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice6);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price6Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price6Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price6RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice7);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price7Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price7Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price7RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice8);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price8Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price8Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price8RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice9);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price9Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price9Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price9RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice10);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price10Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price10Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price10RoundingNum);
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

        public bool ExportInventoryItemGEN()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();

                

                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Inactive);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_GUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Class);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Category);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_QuantityOnHand);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemDescription);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_LaborCost);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesDesc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesAccountGUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesAccountId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitOfMeasure);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InventoryAccountId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InventoryAccountGUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InvChgAccountId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InvChgAccountGUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UPCSKU);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Weight);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesTaxType);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice1);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price1Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price1Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price1RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice2);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price2Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price2Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price2RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice3);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price3Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price3Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price3RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice4);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price4Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price4Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price4RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice5);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price5Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price5Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price5RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice6);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price6Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price6Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price6RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice7);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price7Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price7Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price7RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice8);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price8Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price8Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price8RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice9);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price9Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price9Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price9RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice10);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price10Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price10Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price10RoundingNum);


                ///descriptions of primary attributes

                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc1);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc2);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc3);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc4);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc5);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc6);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc7);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc8);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc9);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc10);

                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc11);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc12);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc13);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc14);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc15);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc16);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc17);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc18);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc19);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeDesc20);


                //2ndry attributes description

                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc1);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc2);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc3);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc4);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc5);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc6);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc7);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc8);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc9);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc10);

                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc11);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc12);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc13);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc14);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc15);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc16);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc17);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc18);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc19);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeDesc20);

                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SubstockPrimaryAttributeDesc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SubstockPrimaryAttributeId );

                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SubstockSecondaryAttributeDesc );
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SubstockSecondaryAttributeId);

                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_PrimaryAttributeName);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SecondaryAttributeName);

                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_MasterStockItemId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_MasterStockItemGUID);

                



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

        public bool ExportItemIDandDes()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Inactive);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_GUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Class);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemDescription);
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

        public bool ExportItemNNP()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Inactive);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_GUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Class);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Category);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_QuantityOnHand);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemDescription);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_LaborCost);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesDesc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesAccountGUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesAccountId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitOfMeasure);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InventoryAccountId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InventoryAccountGUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UPCSKU);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Weight);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesTaxType);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice1);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price1Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price1Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price1RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice2);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price2Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price2Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price2RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice3);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price3Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price3Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price3RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice4);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price4Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price4Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price4RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice5);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price5Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price5Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price5RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice6);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price6Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price6Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price6RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice7);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price7Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price7Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price7RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice8);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price8Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price8Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price8RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice9);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price9Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price9Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price9RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice10);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price10Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price10Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price10RoundingNum);
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

        public bool ExportItemQtyOnHand()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Inactive);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId );
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_QuantityOnHand );
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


        public bool ExportItemLastUnitCost(String itemid)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();
                
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_LaborCost );
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_GUID );
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameXML);

                export.SetFilterValue((short)PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemId, PeachwIEFilterOperation.peachwIEFilterOperationRange, itemid, itemid);

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

        public bool ExportInventoryItemSSP()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Inactive);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_GUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemDescription);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Class);
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

        public bool ExportNonStockNewCreatedItem(String fisrtItem,string lastItem)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Inactive);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_GUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Class);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Category);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_QuantityOnHand);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemDescription);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_LaborCost);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesDesc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesAccountGUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesAccountId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitOfMeasure);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InventoryAccountId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InventoryAccountGUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InvChgAccountId);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_InvChgAccountGUID);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UPCSKU);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Weight);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_SalesTaxType);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice1);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price1Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price1Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price1RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice2);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price2Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price2Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price2RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice3);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price3Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price3Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price3RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice4);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price4Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price4Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price4RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice5);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price5Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price5Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price5RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice6);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price6Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price6Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price6RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice7);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price7Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price7Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price7RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice8);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price8Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price8Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price8RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice9);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price9Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price9Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price9RoundingNum);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice10);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price10Calc);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price10Rounding);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Price10RoundingNum);

                export.SetFilterValue((short)PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemId , PeachwIEFilterOperation.peachwIEFilterOperationRange , fisrtItem , lastItem );
                export.SetFilterValue((short)PeachwIEObjInventoryItemsListFilter.peachwIEObjInventoryItemsListFilter_ItemClass, PeachwIEFilterOperation.peachwIEFilterOperationEqualTo, "Non-stock item", "Non-stock item");
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

        public bool   ImportNewItem()
        {
            string[] gUIDs = new string[1];
            string bstrFilename = this.path + this.fileNameCSV;
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Import import = (Import)this.peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                import.ClearImportFieldList();
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemDescription);
                
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Class);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitOfMeasure);
                //import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_LaborCost);
                //import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice1);
                
                import.SetFileType(PeachwIEFileType.peachwIEFileTypeCSV);
                import.SetFilename(bstrFilename);
                import.Import ();
                //return gUIDs;
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false ;
            }
        }

        public bool  ImportLastUnitCost()
        {
            string[] gUIDs = new string[1];
            string bstrFilename = this.path + this.fileNameCSV;
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Import import = (Import)this.peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                import.ClearImportFieldList();



                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);

                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_LaborCost);

                
                
                import.SetFileType(PeachwIEFileType.peachwIEFileTypeCSV);
                import.SetFilename(bstrFilename);
                import.Import ();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false ;
            }
        }

        public string[] ImportNewItemALLAssemblies()
        {
            string[] gUIDs = new string[1];
            string bstrFilename = this.path + this.fileNameCSV;
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Import import = (Import)this.peachtreeObj.AppObj.CreateImporter(PeachwIEObj.peachwIEObjInventoryItemsList);
                import.ClearImportFieldList();
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemId);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ItemDescription);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_Class);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_LaborCost);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_UnitPrice1);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_RevisionNumber);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_EffectiveDate);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_ComponentID);
                import.AddToImportFieldList((short)PeachwIEObjInventoryItemsListField.peachwIEObjInventoryItemsListField_QuantityNeeded);
                import.SetFileType(PeachwIEFileType.peachwIEFileTypeCSV);
                import.SetFilename(bstrFilename);
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

