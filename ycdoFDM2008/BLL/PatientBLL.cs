using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;
namespace BLL
{
    public class PatientBLL
    {
        public bool SavePatientCategory(PatientCategory pc)
        {
           return new PatientDAL().SavePatientCategory(pc);
        }
        
        public List<PatientCategory> GetPatientCategories()
        {
            return new PatientDAL().GetPatientCategories();
        }
        public bool DeletePatientCategory(PatientCategory pc)
        {
            return new PatientDAL().DeletePatientCategory(pc);
        }

        public bool SavePatientToken(PatientRegistration pr)
        {
            return new PatientDAL().SavePatientToken(pr);
        }
        public long GetNextTokenNumber(Room r)
        {
            return new PatientDAL().GetNextTokenNumber(r);
        }
        public PatientRegistration GetPatientDetail(long tokenNumber,Room r)
        {
            return new PatientDAL().GetPatientDetail(tokenNumber,r);
        }
        public long GetNextTokenNumber()
        {
            return new PatientDAL().GetNextTokenNumber();
        }
        public bool PatientChecked(PatientRegistration pr)
        {
            return new PatientDAL().PatientChecked(pr);
        }

    }
}
