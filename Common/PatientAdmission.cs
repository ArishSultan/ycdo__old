using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class PatientAdmission
    {
        public PatientRegistration PatientRegistration { get; set; }
        public DateTime AdmissoinDate { get; set; }
       public int AdmissoinNo {get; set;}
       public string DiffDiag { get; set; }
        public string provDiag {get; set;}
        public int Pluse { get; set; }
       public double Temp {get; set;}
       public int BPsys { get; set; }
       public int BPdia { get; set; }
       public string RR { get; set; }
       public string BP
       {
           get
           {
               return this.BPsys + "/" + this.BPdia;
           }
       }

    public    PatientAdmission()
        {
            this.PatientRegistration = new PatientRegistration();
        }
            
    }
}
