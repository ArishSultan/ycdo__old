using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
     public  class CommissionCriteria
    {
         public CommissionCriteria() { }

         public static String Condition;


         private Int64 criteriaId;
         private bool isTeamBased;
         private string refernceId;
         private string itemType;
         private string itemId;
         private string customerType;
         private string priceCode;
         private Decimal percentage;
         private DateTime insertionDate;
         private Int64 comShare;


      

         public Int64 CriteriaId
         {
             get { return criteriaId; }
             set { criteriaId = value; }
         }
        
         public bool IsTeamBased
         {
             get { return isTeamBased; }
             set { isTeamBased = value; }
         }
         
         public string RefernceId
         {
             get { return refernceId; }
             set { refernceId = value; }
         }
         
         public string ItemType
         {
             get { return itemType; }
             set { itemType = value; }
         }
         
         public string ItemId
         {
             get { return itemId; }
             set { itemId = value; }
         }
         
         public string CustomerType
         {
             get { return customerType; }
             set { customerType = value; }
         }
        
         public string PriceCode
         {
             get { return priceCode; }
             set { priceCode = value; }
         }
        
         public Decimal Percentage
         {
             get { return percentage; }
             set { percentage = value; }
         }
        
         public DateTime InsertionDate
         {
             get { return insertionDate; }
             set { insertionDate = value; }
         }
        

         public Int64 ComShare
         {
             get { return comShare; }
             set { comShare = value; }
         }




    }
}
