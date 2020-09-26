using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Datasets;
using Common;
using DAL;
namespace BLL
{
    public class MedicineBLL
    {
        public DSMedicineStatus GetMedicinesData(LabTest lt,bool all )
        {
            return new MedicinesDAL().GetData(lt, all);
        }
    }
}
