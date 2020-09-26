using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public  class Team
    {

        public Team() {
            this.sPersons = new List<SalesPerson>();
        }


        private List<SalesPerson> sPersons;
        private string id;

        private Int64 teamId;

        public static string Condition;


        public Int64 TeamId
        {
            get { return this.teamId; }
            set { this.teamId = value; }
        }


        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public List<SalesPerson> SPersons
        {
            get { return this.sPersons; }
            set { this.sPersons = value; }
        }
    }
}
