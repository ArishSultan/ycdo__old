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
        public bool LabTestAssigned(PatientRegistration pr, List<LabTest> meds)
        {
            return new PatientDAL().LabTestAssigned(pr, meds);
        }
        public bool LabTestAssignedPaid(InjectionLabTest pr, List<LabTest> meds)
        {
            return new PatientDAL().LabTestAssignedPaid(pr, meds);
        }
        public bool LabTestCanceled(PatientRegistration pr, LabTest medicine)
        {
            return new PatientDAL().LabTestCanceled(pr, medicine);
        }
        public bool MedicineCanceled(PatientRegistration pr, LabTest medicine)
        {
            return new PatientDAL().MedicineCanceled(pr, medicine);
        }
        #region Faheem Work
        public bool PatientChecked(PatientRegistration pr, List<LabTest> meds)
        {
            return new PatientDAL().PatientChecked(pr, meds);
        }
        #endregion
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
        public PatientRegistration GetPatientDetail(long tokenNumber)
        {
            return new PatientDAL().GetPatientDetail(tokenNumber);
        }
        public List<PatientRegistration> GetPatientDetails()
        {
            return new PatientDAL().GetPatientDetails();
        }
        public bool SaveLabTestRemarks(PatientRegistration pr, LabTestRemarks  ltr)
        {
            return new PatientDAL().SaveLabTestRemarks(pr, ltr);
        }
        public List<PatientRegistration> GetPatientLabTestDetail()
        {
            return new PatientDAL().GetPatientLabTestDetail();
        }
        public long GetNextTokenNumber()
        {
            return new PatientDAL().GetNextTokenNumber();
        }
        public bool PatientChecked(PatientRegistration pr)
        {
            return new PatientDAL().PatientChecked(pr);
        }
        public List<Patient> GetPatientData()
        {
            return new PatientDAL().GetPatientData();
        }
        public List<PatientRegistration> GetAllPatientNotChecked()
        {
            return new PatientDAL().GetAllPatientNotChecked();
        }
    }
}
