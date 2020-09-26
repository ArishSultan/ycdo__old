using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;
namespace BLL
{
    public class RoomBLL
    {
        List<Room> rs;
        public List<Room> GetRooms()
        {
            return new RoomDAL().GetRooms();
        }

        public bool  DeleteRoom(Room pc)
        {
            return new RoomDAL().DeleteRoom (pc);
        }

        public bool SaveRoom(Room pc)
        {
            return new RoomDAL().SaveRoom (pc);
        }
    }
}
