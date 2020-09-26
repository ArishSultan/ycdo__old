namespace ExportImport
{
    using Interop.PeachwServer;
    using System;
    using System.Windows.Forms;

    public class CostCodeList
    {
        private string fileNameXML;
        private string path;

        public CostCodeList()
        {
            this.path = System.Windows.Forms.Application.StartupPath + @"\";
            this.fileNameXML = "CostCodeList.xml";
        }

        private PeachtreeSingleTon peachtreeObj;
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
        /// it will export CostCode's data. if no error then return true.
        /// </summary>
        /// <returns></returns>
        public bool ExportCostCode()
        {


            try
            {
                peachtreeObj = new PeachtreeSingleTon();
                Export exp = (Export)peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjCostCodeList);
                exp.ClearExportFieldList();


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

