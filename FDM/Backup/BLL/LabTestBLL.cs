using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common ;
using DAL;
namespace BLL
{
    public  class LabTestBLL
    {
        public LabTestBLL() { }

        public List<LabTest> GetLabTests()
        {
            return new LabTestDAL().GetLabTests();
        }

        public bool  SaveLabTests(List<LabTest>  labTests)
        {
            return new LabTestDAL().SaveLabTests(labTests);
        }
    }
}
