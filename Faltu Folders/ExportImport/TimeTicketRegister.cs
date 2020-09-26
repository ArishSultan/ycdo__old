using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Interop.PeachwServer;

namespace ExportImport
{
   public   class TimeTicketRegister
    {

       

        private string path = (System.Windows.Forms.Application.StartupPath + @"\");
        public string FileNameXML { get { return path + "TimeTicketRegister.xml"; } }

        private PeachtreeSingleTon peachtreeObj;

        public bool ExportTicket(String CusID)
        {
            try
            {
                this.peachtreeObj = new PeachtreeSingleTon();
                Export export = (Export)this.peachtreeObj.AppObj.CreateExporter(PeachwIEObj.peachwIEObjTimeTicketRegister );
                export.ClearExportFieldList();
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_EmployeeOrVendor);
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_RecordedById);
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_TicketNumber);
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_TicketDate);
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_UsedInSalesInvoice);
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_ItemId);
                
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_CustJobAdm);
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_CompletedForId);
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_UsedInPayroll);

                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_BillType);
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_BillRate);
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_BillingStatus);
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_UnitDuration);
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_BillAmount);
                
               export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_MemoSalesInvoice);
               export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_Memo);
                
                export.AddToExportFieldList((short)PeachwIEObjTimeTicketRegisterField.peachwIEObjTimeTicketRegisterField_InvoiceNumUsed );
                export.SetDateFilterValue(PeachwIEDateFilterOperation.peachwIEDateFilterOperationAll, new DateTime(), new DateTime());
                export.SetFilename(FileNameXML);
                export.SetFileType(PeachwIEFileType.peachwIEFileTypeXML);
                export.SetFilterValue((short)PeachwIEObjTimeTicketRegisterFilter.peachwIEObjTimeTicketRegisterFilter_CustomerId, PeachwIEFilterOperation.peachwIEFilterOperationRange, CusID, CusID);
                export.Export();
                
                CommonFunction.GetUTF8Supported_XmlFilePath(this.FileNameXML, this.FileNameXML);
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ExportTicket");
            }
            return false;
        }
    }
}
