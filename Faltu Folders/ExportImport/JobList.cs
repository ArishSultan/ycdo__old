namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class JobList
    {
        private string fileNameXML = "JobList.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportJob()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjJobList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjJobListField.peachwIEObjJobListField_JobId);
                export.AddToExportFieldList((short)PeachwIEObjJobListField.peachwIEObjJobListField_JobGUID);
                export.AddToExportFieldList((short)PeachwIEObjJobListField.peachwIEObjJobListField_UsePhases);
                export.AddToExportFieldList((short)PeachwIEObjJobListField.peachwIEObjJobListField_Inactive);
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

