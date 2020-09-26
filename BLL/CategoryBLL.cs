using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DAL;


namespace BLL
{
   public class CategoryBLL
    {
       public bool SaveCategory(Category c)
       {
           return new CategoryDAL().SaveCategory(c);
       }

       public List<Category> GetCategory()
       {
           return new CategoryDAL().GetCategory();
       }

       public bool DeleteCategory(Category c)
       {
           return new CategoryDAL().DeleteCategory(c);
       }
    }
}
