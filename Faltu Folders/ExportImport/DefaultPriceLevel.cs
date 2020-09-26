namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class DefaultPriceLevel
    {
        private string fileNameXML = "DefaultPriceLevel.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportDefaultPrices()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjInventoryItemDefaults);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel1);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel1Enabled);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel2);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel2Enabled);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel3);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel3Enabled);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel4);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel4Enabled);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel5);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel5Enabled);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel6);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel6Enabled);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel7);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel7Enabled);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel8);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel8Enabled);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel9);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel9Enabled);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel10);
                export.AddToExportFieldList((short)PeachwIEObjInventoryItemDefaultsField.peachwIEObjInventoryItemDefaultsField_PriceLevel10Enabled);
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

