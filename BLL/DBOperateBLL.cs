namespace BLL
{
    using DAL;
    using System;

    public class DBOperateBLL
    {
        public DBOperateBLL()
        {
        }
        public string DataPath()
        {
            return new DBOperateDAL().DataPath();
            return "";
        }
    }
}

