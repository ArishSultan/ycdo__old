namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class EmployeeAsSaleRep
    {
        private string fileNameXML = "EmployeeAsSaleRep.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportEmployeeAsSaleRep()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjEmployeeList);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjEmployeeListField.peachwIEObjEmployeeListField_EmployeeID);
                export.AddToExportFieldList((short)PeachwIEObjEmployeeListField.peachwIEObjEmployeeListField_EmployeeName);
                export.AddToExportFieldList((short)PeachwIEObjEmployeeListField.peachwIEObjEmployeeListField_EmployeeAddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjEmployeeListField.peachwIEObjEmployeeListField_SalesRep);
                export.AddToExportFieldList((short)PeachwIEObjEmployeeListField.peachwIEObjEmployeeListField_GUID);
                export.AddToExportFieldList((short)PeachwIEObjEmployeeListField.peachwIEObjEmployeeListField_Inactive);
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

