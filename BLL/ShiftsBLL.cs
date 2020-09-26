using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace BLL
{
  public  class ShiftsBLL
    {


        public List<Shift> GetShifts()
        {
            return new DAL.ShiftDAL().GetShifts();
        }
        public Shift GetActiveShift()
        {
            return new DAL.ShiftDAL().GetActiveShift();
        }
        public bool SetActiveShift(Shift shift) 
        {
            return new DAL.ShiftDAL().SetActiveShift(shift);
        }
        public bool SetActiveShift(Shift shift,User LoginUser)
        {
            return new DAL.ShiftDAL().SetActiveShift(shift,LoginUser);
        }


        public bool ShiftCanChange(Shift shift)
        {
            return new DAL.ShiftDAL().ShiftCanChange(shift);
        }

        public Shift GetShiftStartEndTime(Shift shift, DateTime date)
        {

            return new DAL.ShiftDAL().GetShiftStartEndTime(shift,date);
        }
    }
}
