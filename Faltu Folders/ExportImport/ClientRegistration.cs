namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class ClientRegistration
    {
        private string fileNameXML = "ClientRegistration.xml";
        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        private PeachtreeSingleTon peachtreeObj;

        public bool ExportClientRegistration()
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjCompanyInformation);
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjCompanyInformationField.peachwIEObjCompanyInformationField_CompanyName);
                export.AddToExportFieldList((short)PeachwIEObjCompanyInformationField.peachwIEObjCompanyInformationField_CompanyCity);
                export.AddToExportFieldList((short)PeachwIEObjCompanyInformationField.peachwIEObjCompanyInformationField_CompanyAddressLine1);
                export.AddToExportFieldList((short)PeachwIEObjCompanyInformationField.peachwIEObjCompanyInformationField_CompanyAddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCompanyInformationField.peachwIEObjCompanyInformationField_CompanyZip);
                export.AddToExportFieldList((short)PeachwIEObjCompanyInformationField.peachwIEObjCompanyInformationField_Email);
                export.AddToExportFieldList((short)PeachwIEObjCompanyInformationField.peachwIEObjCompanyInformationField_Phone);
                export.AddToExportFieldList((short)PeachwIEObjCompanyInformationField.peachwIEObjCompanyInformationField_Fax);
                export.AddToExportFieldList((short)PeachwIEObjCompanyInformationField.peachwIEObjCompanyInformationField_CompanyState);
                export.AddToExportFieldList((short)PeachwIEObjCompanyInformationField.peachwIEObjCompanyInformationField_CompanyAddressLine2);
                export.AddToExportFieldList((short)PeachwIEObjCompanyInformationField.peachwIEObjCompanyInformationField_CompanyCountry);
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

