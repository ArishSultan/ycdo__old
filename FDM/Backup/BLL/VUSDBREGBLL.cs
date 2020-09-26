namespace BLL
{
    using DAL;
    using Common;
    using System;
    using System.Data;

    public class VUSDBREGBLL
    {
        public bool GetACode()
        {
            return new Sec().VerifyDBUser();
        }

        public DataTable GetALLUnRegEnh()
        {
            return new Sec().GetALLUnRegEnh();
        }

        public DataTable GetCompanyInfo()
        {
           // return new CompanyInfoDAL().GetCompanyInfo();
            return new DataTable();
        }

        public DataTable GetCusInfo()
        {
            //return new CompanyInfoDAL().GetCusInfo();
            return new DataTable();
        }

        public string GetPeachCustomerNumber()
        {
            //return new CompanyInfoDAL().GetPeachCustomerNumber();
            return "";
        }

        public string GetPeachSerialNo()
        {
            //return new CompanyInfoDAL().GetPeachSerialNo();
            return "";

        }

        public bool SaveCustInfo(CompanyInformation com, string regno, string srno, string Cusno)
        {
           //return new CompanyInfoDAL().SaveCusInfo(com, regno, srno, Cusno);
            return false ;
        }

        public bool SaveReg(ProjectDetail prjdet)
        {
            return new Sec().SaveReg(prjdet);
        }
    }
}

