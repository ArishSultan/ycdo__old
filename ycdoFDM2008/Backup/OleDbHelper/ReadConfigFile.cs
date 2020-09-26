  using Common;
  using System;
  using System.IO;
  using System.Windows.Forms;
  namespace OleDbHelper
{
  

    public class ReadConfigFile
    {
        private string FileNameXML;
        private ProjectDetail prj;

        public string ConfigString(ConfigFiles confile)
        {
            this.prj = new ProjectDetail();
            string str = "";
            if (confile == ConfigFiles.MainConfigFile)
            {
                this.FileNameXML = this.prj.MainConfigfileName;
                if (File.Exists(Application.StartupPath + @"\" + this.FileNameXML))
                {
                    str = File.ReadAllText(Application.StartupPath + @"\" + this.FileNameXML);
                }
                return str;
            }
            if (confile == ConfigFiles.ProjectConfigFile)
            {
                this.FileNameXML = this.prj.ProjectConfigfileName;
                if (File.Exists(Application.StartupPath + @"\" + this.FileNameXML))
                {
                    str = File.ReadAllText(Application.StartupPath + @"\" + this.FileNameXML);
                }
            }
            return str;
        }
    }
}

