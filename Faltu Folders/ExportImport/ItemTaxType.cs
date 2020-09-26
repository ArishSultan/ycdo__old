namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class ItemTaxType
    {
        private string fileNameXML = "ItemTaxType.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportItemTaxType()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export) this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjItemTaxTypes);
                export.ClearExportFieldList();
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

