namespace DAL
{
    using OleDbHelper;
    using System;

    public class DBOperateDAL
    {
        private ReadConfigFile readconfile;

        public string DataPath()
        {
            this.readconfile = new ReadConfigFile();
            string ConnectionString = readconfile.ConfigString(ConfigFiles.ProjectConfigFile);
            ConnectionString= ConnectionString.Split(';').GetValue(1) .ToString().Replace("Data Source=","");
            return ConnectionString;
        }
    }
}

