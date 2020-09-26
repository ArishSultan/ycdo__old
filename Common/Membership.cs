using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Enum;
namespace Common
{
   public  class Membership
    {
       private int mid;
       private string membername;
       private string memberlastname;
       private decimal age;
       private string  nic;
      // private Membership refrence;
       public string refrence { get; set; }
       private string phone;
       private string email;
       private decimal membershipfee;
       private string adress;
       
       private DateTime collectiondate;

       private string gender ;

       private string memberships;
       private string bloodgroups;
       private decimal membershipno;
       private string status;

       private decimal monthlyfee;
       private string  membertype;
       private string goodentries;
       private string badentries;
       private byte[] pics;


       
       private DateTime currentDate;

       public Branch branch { get; set; }
       public Donor Donor { get; set; }
       public City City { get; set; }
       public Country Country { get; set; }
       public List<Counsil> Counsil { get; set; }
       public List<Committe> Committe { get; set; }
       public string Refrence { get; set; }
       public Membership()
       {
           this.branch = new Branch();
           this.Donor = new Donor();
           this.City = new City();
           this.Country = new Country();
           this.Counsil = new List<Counsil>();
           this.Committe = new List<Committe>();
           
       }

       




       //////Properties////

  //public Branch Branch
  //{
  //    get { return  this.branch;}
  //    set{branch=value;}
  // }

       public string MemberName
       {
           get{return this.membername;}
           set { this.membername = value; }
       }

       public string MemberLastName
       {
           get { return this.memberlastname; }
           set { this.memberlastname = value; }
       }

       public decimal AGE
       {
           get { return this.age; }
           set { this.age = value; }
       }

       public string NIC
       {
           get { return this.nic; }
           set { this.nic = value; }
       }

       //public Membership Refrence
       //{
       //    get { return this.refrence; }
       //    set { this.refrence = value; }
       //}

       public string Phone
       {
           get { return this.phone; }
           set { this.phone = value; }
       }

       public string Email
       {
           get { return this.email; }
           set { this.email = value; }
       }

       public decimal MembershipFee
       {
           get { return this.membershipfee; }
           set { this.membershipfee = value; }
       }


       public string Adress
       {
           get { return this.adress; }
           set { this.adress = value; }
       }

       public DateTime CollectionDate
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
       public decimal MembershipNo
       {
           get { return this.membershipno; }
           set { this.membershipno = value; }
       }

       public string Status
       {
           get { return this.status; }
           set { this.status = value; }
       }
       public decimal MonthlyFee
       {

          get { return this.monthlyfee; }
           set { this.monthlyfee = value; }
       }

       public int MID
       {
           get { return this.mid; }
           set { this.mid = value; }
       }

       public DateTime CurrentDate
       {
           get { return this.currentDate; }
           set { currentDate = value; }
       
       }

       public string MemberType
       {
           get { return this.membertype; }
           set { this.membertype = value; }
       }
       public string GoodEntries
       {
           get { return this.goodentries; }
           set { this.goodentries = value; }
       }
       public string BadEntries
       {
           get { return this.badentries; }
           set { this.badentries = value; }
       }

       public byte[] Pics
       {
           get;
           set;
       }

       //public override string ToString()
       //{
       //    return MembershipNo.ToString() + " - " + MemberName + " " + MemberLastName ;
       //}
   }
}
