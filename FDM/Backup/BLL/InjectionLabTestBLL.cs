using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;
namespace BLL
{
    public class InjectionLabTestBLL
    {
        public InjectionLabTestBLL() { }

        public bool SavePatientToken(InjectionLabTest  pr)
        {
            return new InjectionLabTestDAL().SavePatientToken(pr);
        }
        public long GetNextTokenNumber()
        {
            return new InjectionLabTestDAL().GetNextTokenNumber();
        }
        public PatientRegistration GetPatientRegistration(PatientRegistration pr)
        {
            return new InjectionLabTestDAL().GetPatientRegistration(pr);
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
    }
}
