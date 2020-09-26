namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class ShippingMethod
    {
        private string fileNameXML = "ShippingMethod.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportShippingMethod()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export) this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjShippingMethods);
                export.ClearExportFieldList();
	export.AddToExportFieldList((short )PeachwIEObjShippingMethodsField.peachwIEObjShippingMethodsField_GUID);
	export.AddToExportFieldList((short )PeachwIEObjShippingMethodsField.peachwIEObjShippingMethodsField_ShippingMethod);
	export.AddToExportFieldList((short )PeachwIEObjShippingMethodsField.peachwIEObjShippingMethodsField_ShippingMethodNumber);
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

