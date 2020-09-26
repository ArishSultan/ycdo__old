using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Branch
    {
        private int id;
        private int branchcode;
        private string branchname;
        private int phonenumber;
        private string adress;
        

        private City city ;//{ get; set; }
        private bool isActive;
        

        ////constructor///
       

        public Branch()
        {
            this.city = new City();
        }
        public Branch( int id,int branchcode,string branchname,int phonenumber,string adress,City c)
        {
            this.id = id;
            this.branchcode = branchcode;
            this.branchname = branchname;
            this.phonenumber = phonenumber;
            this.adress = adress;

            this.city = c;
        }

        public Branch(int id, int branchcode, string branchname, int phonenumber, string adress, City c, bool isActive)
        {
            this.id = id;
            this.branchcode = branchcode;
            this.branchname = branchname;
            this.phonenumber = phonenumber;
            this.adress = adress;

            this.city = c;
            this.isActive = isActive;
            
        }

        /////properties/////



        public City City
        {
            get { return city; }
            set { city = value; }
        }

        public int BranchID
        {
            get { return id; }
            set { id = value; }

        }

        public int BranchCode
        {
            get { return branchcode; }
            set { branchcode = value; }
        
        }


        public string BranchName
        {
            get { return branchname; }
            set { branchname = value; }

        }

        public int Phone
        {
            get { return phonenumber; }
            set { phonenumber = value; }

        }

        public string BranchAdress
        {
            get { return adress; }
            set { adress = value; }

        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

      

    }
}
