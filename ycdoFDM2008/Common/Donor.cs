using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Enum;
namespace Common
{
   public  class Donor
    {
       private int mid;
       private string donorname;
       private string donorlastname;
       private decimal age;
       private decimal nic;
       private string refrence;
       private decimal phone;
       private string email;
       private decimal donorfee;
       private string adress;
       
       private decimal collectiondate;

       private string gender ;

       private string memberships;
       private string bloodgroups;
       private decimal donorno;
       private string status;

       public static string Condition;

       private string fundtype;

       private DateTime currentdate;

       public Branch branch { get; set; }
       public City City { get; set; }

       public Donor()
       {
           this.branch = new Branch();
           this.City = new City();
       }




       //////Properties////

  //public Branch Branch
  //{
  //    get { return  this.branch;}
  //    set{branch=value;}
  // }

       public string DonorName
       {
           get{return this.donorname;}
           set { this.donorname = value; }
       }

       public string DonorLastName
       {
           get { return this.donorlastname; }
           set { this.donorlastname = value; }
       }

       public decimal AGE
       {
           get { return this.age; }
           set { this.age = value; }
       }

       public decimal NIC
       {
           get { return this.nic; }
           set { this.nic = value; }
       }

       public string Refrence
       {
           get { return this.refrence; }
           set { this.refrence = value; }
       }

       public decimal Phone
       {
           get { return this.phone; }
           set { this.phone = value; }
       }

       public string Email
       {
           get { return this.email; }
           set { this.email = value; }
       }

       public decimal DonorFee
       {
           get { return this.donorfee; }
           set { this.donorfee = value; }
       }


       public string Adress
       {
           get { return this.adress; }
           set { this.adress = value; }
       }

       public decimal CollectionDate
       {
           get { return this.collectiondate; }
           set { this.collectiondate = value; }
       }

       public string BloodGroup
       {
           get { return this.bloodgroups; }
           set { this.bloodgroups = value; }
       }


       public string Gender
       {
           get { return this.gender; }
           set { this.gender = value; }
       }

       public string Memberships
       {
           get { return this.memberships; }
           set { this.memberships = value; }
       }
       public decimal DonorNo
       {
           get { return this.donorno; }
           set { this.donorno = value; }
       }

       public string Status
       {
           get { return this.status; }
           set { this.status = value; }
       }
       public string FundType
       {

          get { return this.fundtype; }
           set { this.fundtype = value; }
       }

       public int MID
       {
           get { return this.mid; }
           set { this.mid = value; }
       }

       public DateTime CurrentDate
       {
           get { return this.currentdate; }
           set { this.currentdate = value; }
       }
   }
}
