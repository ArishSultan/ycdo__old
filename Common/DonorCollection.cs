using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class DonorCollection
    {
       private int id;
       private string donorName;
       private DateTime collectionDate;
       private decimal collectionfee;
       public decimal ReciptNo { get; set; }
       public string DonationType { get; set; }
       public string Others { get; set; }
       public decimal CheckDetail { get; set; }
      
        //cons////
       public DonorCollection()
       {
       
       }


       public DonorCollection(string memberName)
           : this()
       {
           this.DonorName = donorName;
       }
       

       public int ID
       {
           get { return id; }
           set { id = value; }
       }

       public string DonorName
       {
           get { return donorName; }
           set { donorName = value; }
       }
       public DateTime CollectionDate
       {
           get { return collectionDate;}
           set { collectionDate = value; }
       }
       public decimal CollectionFee
       {
           get { return collectionfee; }
           set { collectionfee = value; }
       }
    }
}
