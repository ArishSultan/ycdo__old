namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class ChartofAccount
    {
        private string fileNameXML;
        private string path;

        public ChartofAccount()
        {
            this.path = System.Windows.Forms.Application.StartupPath + @"\";
            this.fileNameXML = "ChartofAccount.xml";
        }

        private PeachtreeSingleTon peachtreeObj;
        private System.Array chartofAccount = new Array[4, 0];
        /// <summary>
        /// it will give the path and filename of exported XML file.
        /// </summary>
        public string FileNameXML
        {
            get
            {
                return this.path + this.fileNameXML;
            }
            set
            {
                fileNameXML = value;
            }
        }
        /// <summary>
        /// it will export Chart of accounts data (GUID,Type,Description,ID). if no error then return true.
        /// </summary>
        /// <returns></returns>
        public bool ExportChartofAccount()
        {


            try
            {
                peachtreeObj = new PeachtreeSingleTon();

                //peachtreeObj.AppObj.GetActiveAccountsWithGuid(out chartofAccount, out chartofAccount, out chartofAccount, out chartofAccount);
                Export exp = (Export)peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjChartOfAccounts);
                exp.ClearExportFieldList();

                exp.AddToExportFieldList((short)PeachwIEObjChartOfAccountsField.peachwIEObjChartOfAccountsField_GUID);
                exp.AddToExportFieldList((short)PeachwIEObjChartOfAccountsField.peachwIEObjChartOfAccountsField_Type);
                exp.AddToExportFieldList((short)PeachwIEObjChartOfAccountsField.peachwIEObjChartOfAccountsField_AccountTypeDescription);
                exp.AddToExportFieldList((short)PeachwIEObjChartOfAccountsField.peachwIEObjChartOfAccountsField_GeneralLedgerId);
                exp.AddToExportFieldList((short)PeachwIEObjChartOfAccountsField.peachwIEObjChartOfAccountsField_Inactive);
                exp.AddToExportFieldList((short)PeachwIEObjChartOfAccountsField.peachwIEObjChartOfAccountsField_GeneralLedgerDescription );

                exp.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                exp.SetFilename(FileNameXML);
                exp.Export();
                CommonFunction.GetUTF8Supported_XmlFilePath(FileNameXML, FileNameXML);
                return true;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}

