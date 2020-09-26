using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;


namespace BLL
{
    public class DiagnosisBLL
    {
        public bool SaveDiagnosis(Diagnosis c)
       {
           return new DiagnosisDAL().SaveDiagnosis(c);
       }

        public List<Diagnosis> GetDiagnosis()
       {
           return new DiagnosisDAL().GetDiagnosis();
       }

        public bool DeleteDiagnosis(Diagnosis c)
       {
           return new DiagnosisDAL().DeleteDiagnosis(c);
       }
       
    }
}
