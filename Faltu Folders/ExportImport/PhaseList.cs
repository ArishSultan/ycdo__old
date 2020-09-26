namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class PhaseList
    {
        private string fileNameXML = "PhaseList.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportPhase()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export) this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjPhaseList);
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

