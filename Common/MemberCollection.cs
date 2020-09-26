using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class MemberCollection
    {
       private int id;
       private string memberName;
       private DateTime collectionDate;
       private decimal collectionfee;
       public decimal ReciptNo { get; set; }
       public string CollectionMonth { get; set; }
       public Membership Member { get; set; }
        //cons////
       public MemberCollection()
       {
           
       }


       public MemberCollection(string memberName): this()
       {
           this.MemberName = memberName;
       }
       

       public int ID
       {
           get { return id; }
           set { id = value; }
       }

       public string MemberName
       {
           get { return memberName; }
           set { memberName = value; }
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
