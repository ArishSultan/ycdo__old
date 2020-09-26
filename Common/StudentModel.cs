using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class StudentModel
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Program { get; set; }
        public string Session { get; set; }
        public string RollNo { get; set; }
        public byte[] FingurePrint { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Code.ToString("00000"), Name);
        }
    }
}
