namespace ExportImport
{
    using System;
    using System.IO;
    using System.Text;

    internal class CommonFunction
    {
        public static bool GetUTF8Supported_XmlFilePath(string FilepathToMakeUTFsupported, string UTFFilePath)
        {
            StreamReader reader = new StreamReader(FilepathToMakeUTFsupported, Encoding.UTF8);
            string str = reader.ReadToEnd();
            reader.Close();
            StreamWriter writer = new StreamWriter(UTFFilePath);
            writer.Write(str);
            writer.Close();
            return true;
        }
    }
}

