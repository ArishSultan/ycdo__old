using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
      using Interop.PeachwServer;
    
    using System.Windows.Forms;

namespace ExportImport
{


    public class CustomerContactList
    {
        private string fileNameExportxml = "CustomerContactList.xml";
        private string fileNameImportCSV = "CustomerContactListImport.csv";
        private string path =  System.Windows.Forms.Application.StartupPath + @"\" ;
        private PeachtreeSingleTon peachtreeObj;
        public string FileNameExportXML
        {
            get
            {
                return (this.path + this.fileNameExportxml);
            }
            set
            {
                this.fileNameExportxml = value;
            }
        }

        public string FileNameImportCSV
        {
            get
            {
                return (this.path + this.fileNameImportCSV);
            }
            set
            {
                this.fileNameImportCSV = value;
            }
        }

        public bool ExportContacts()
        {

            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjContactsList);
                export.ClearExportFieldList();
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilename(this.FileNameExportXML);
                export.Export();
                CommonFunction.GetUTF8Supported_XmlFilePath(this.FileNameExportXML, this.FileNameExportXML);
                return true;

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
