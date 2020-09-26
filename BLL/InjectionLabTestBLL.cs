using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;
using Common.Datasets;
namespace BLL
{
    public class InjectionLabTestBLL
    {
        #region FaheemWork
        public List<PatientRegistration> GetAllMedicineNotIssued()
        {
            return new InjectionLabTestDAL().GetAllMedicineNotIssued();
        }
        public List<PatientRegistration> GetAllMedicinesIssued()
        {
            return new InjectionLabTestDAL().GetAllMedicinesIssued();
        }
        public List<LabTest> GetMedicineIssued(PatientRegistration pr)
        {
            return new InjectionLabTestDAL().GetMedicineIssued(pr);
        }
        public List<LabTest> GetMedicineIssued3(PatientRegistration pr)
        {
            return new InjectionLabTestDAL().GetMedicineIssued3(pr);
        }
        public List<LabTest> GetLabTestAssigned(PatientRegistration pr)
        {
            return new InjectionLabTestDAL().GetLabTestAssigned(pr);
        }
        public List<LabTest> GetLabTestPerformed(PatientRegistration pr)
        {
            return new InjectionLabTestDAL().GetLabTestPerformed(pr);
        }
        public List<LabTest> GetLabTestCanceled(PatientRegistration pr)
        {
            return new InjectionLabTestDAL().GetLabTestCanceled(pr);
        }
        public List<LabTest> GetLabTestAssignedUnPaid(PatientRegistration pr)
        {
            return new InjectionLabTestDAL().GetLabTestAssignedUnPaid(pr);
        }
        public List<LabTest> GetLabTestAssignedUnPaid2(PatientRegistration pr)
        {
            return new InjectionLabTestDAL().GetLabTestAssignedUnPaid2(pr);
        }
        public bool SetPharmacyIssued(List<LabTest> medicines)
        {
            return new InjectionLabTestDAL().SetPharmacyIssued(medicines);
        }
        public bool SetPaidLabTest(List<LabTest> medicines)
        {
            return new InjectionLabTestDAL().SetPaidLabTest(medicines);
        }
        #endregion
        public List<LabTest> GetPaidTokens(int TokenId, DateTime TokenDate)
        {
            return new InjectionLabTestDAL().GetInjectionLabTests(TokenId, TokenDate);
        }
        public InjectionLabTestBLL() { }
        public bool SavePatientTokenInjandLabTest(InjectionLabTest pr)
        {
            return new InjectionLabTestDAL().SavePatientTokenInjandLabTest(pr);
        }
        public bool SavePatientToken(InjectionLabTest  pr)
        {
            return new InjectionLabTestDAL().SavePatientToken(pr);
        }
        public long GetNextTokenNumber()
        {
            return new InjectionLabTestDAL().GetNextTokenNumber();
        }
        public PatientRegistration GetPatientRegistrationLab(PatientRegistration pr)
        {
            return new InjectionLabTestDAL().GetPatientRegistrationLab(pr);
        }
        public PatientRegistration GetPatientRegistration(PatientRegistration pr)
        {
            return new InjectionLabTestDAL().GetPatientRegistration(pr);
        }
        public List<PatientRegistration> GetPatientRegistration2()
        {
            return new InjectionLabTestDAL().GetPatientRegistration2();
        }

        public List<LabTest> GetMedicineCanceled(PatientRegistration pr)
        {
            return new InjectionLabTestDAL().GetMedicineCanceled(pr);
        }
        public List<LabTest> GetMedicineIssued2(PatientRegistration pr)
        {
            return new InjectionLabTestDAL().GetMedicineIssued2(pr);
        }
        public InjectionLabTest GetInjectionLabTest(InjectionLabTest inLb)
        {
            return new InjectionLabTestDAL().GetInjectionLabTest(inLb);
        }
        public List<InjectionLabTest> GetInjectionLabTests()
        {
            return new InjectionLabTestDAL().GetInjectionLabTests();
        }
        public bool UpdateInjectionLabTest(InjectionLabTest inLb)
        {
            return new InjectionLabTestDAL().UpdateLabTestToken(inLb);
        }

        public List<InjectionLabTest> GetTokenNum(DateTime Date)
        {
            return new InjectionLabTestDAL().GetTokenNum(Date);
        }
        public List<RecieveMedicine> GetIssuedMedicine()
        {
            return new InjectionLabTestDAL().GetIssuedMedicines();
        }
        public List<RecieveMedicine> GetIssuedMedicines(string IssueNumber)
        {
            return new InjectionLabTestDAL().GetIssuedMedicines(IssueNumber);
        }
        public long GetNexReceiptNumber()
        {
            return new InjectionLabTestDAL().GetNextReceiptNumber();
        }
        public bool DeleteIssuedMedicine(int ID)
        {
            return new InjectionLabTestDAL().DeleteIssuedMedicine(ID);
        }
        public bool SaveIssuedMedicine(RecieveMedicine rm)
        {
            return new InjectionLabTestDAL().SaveIssuedMedicine(rm);
        }
        public DSIssueBill.DTIssueBillDataTable PrintIssueMedBill(RecieveMedicine Obj,bool Retail,bool Purchase)
        {
            return new InjectionLabTestDAL().PrintIssueMedBill(Obj,Retail,Purchase);
        }

        public List<LabTest> GetLabTestAssignedUnPaid3(InjectionLabTest inLB)
        {
            return new InjectionLabTestDAL().GetLabTestAssignedUnPaid3(inLB);
        }
    }
}
