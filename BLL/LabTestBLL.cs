using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common ;
using DAL;
using Common.Datasets;
namespace BLL
{
    public  class LabTestBLL
    {
        public LabTestBLL() { }

        public List<LabTest> GetLabTests()
        {
            return new LabTestDAL().GetLabTests();
        }
        public DsCurrentStock.CurrentStockDataTable GetCurrentStock(bool WithLabTest,bool WithoutLabnTest,bool LabTest)
        {
            return new LabTestDAL().GetCurrentStock(WithLabTest,WithoutLabnTest,LabTest);
        }
        public List<LabTest> GetMedicines()
        {
            return new LabTestDAL().GetMedicines();
        }
        public List<LabTest> GetLabTest()
        {
            return new LabTestDAL().GetLabTest();
        }
        public LabTest GetSyring()
        {
            return new LabTestDAL().GetSyring();
        }
        public bool  SaveLabTests(List<LabTest>  labTests)
        {
            return new LabTestDAL().SaveLabTests(labTests);
        }
        public bool SaveSyring(LabTest syring)
        {
            return new LabTestDAL().SaveSyring(syring);
        }
        public long GetNextReceiptNumber()
        {
            return new LabTestDAL().GetNextReceiptNumber();
        }
        public List<RecieveMedicine> GetRecieveMedicines()
        {
            return new LabTestDAL().GetRecieveMedicines();
        }
        public List<RecieveMedicine> GetRecieveMedicines(string RecieveNumber)
        {
            return new LabTestDAL().GetRecieveMedicines(RecieveNumber);
        }
        public bool SaveReceivedMedicine(RecieveMedicine rm)
        {
            return new LabTestDAL().SaveRecieveMedicine(rm);
        }
        public bool DeleteReceivedMedicine(int ReceiveNumber)
        {
            return new LabTestDAL().DeleteReceiveMedicine(ReceiveNumber);
        }
        public DSMedicinesIssuedAndReceived GetItemLedger(DateTime From, DateTime To, String Name)
        {
            return new LabTestDAL().GetItemLedger(From, To, Name);
        }
        public DSCurrentStockWithValue.dtCurrentStockWithValueDataTable GetCurrentStockWithValue(bool LabTest,bool Medicine,bool All)
        {
            return new LabTestDAL().GetCurrentStockWithValue(LabTest,Medicine,All);
        }
        public DSIssuedMedPur.dtIssuedMedPurDataTable GetIssuedMedPur(bool All,bool Purchase,bool Retail, LabTest MedID,DateTime From,DateTime TO)
        {
            return new LabTestDAL().GetIssuedMedPur( All,Purchase,Retail,MedID,From,TO);
        }
        public DSIssueBill.DTIssueBillDataTable PrintRecMedBill(RecieveMedicine Obj)
        {
            return new LabTestDAL().PrintRecMedBill(Obj);
        }
        public DSMedicines GetListOfMed()
        {
            return new LabTestDAL().GetListOfMed();
        }

        public List<LabTest> GetAvailabeMedicines()
        {
            return new LabTestDAL().GetAvailabeMedicines();
        }
    }
}
