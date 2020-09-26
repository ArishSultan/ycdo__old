using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Enum;
namespace Common
{
    public class Diagnosis
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public DiagnosisType DiagnosisType { get; set; }

    }
}
