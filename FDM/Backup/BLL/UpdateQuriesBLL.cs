using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
namespace BLL
{
   public   class UpdateQuriesBLL
    {
       public void UpdateDatabaseQuries()
       {
           new UpdateQuriesDAL().UpdateV1();
           new UpdateQuriesDAL().UpdateV2();
           new UpdateQuriesDAL().UpdateV3();
       }
    }
}
