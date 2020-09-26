namespace Common
{
    using System;

    public abstract class Person
    {
        private string guid;
        private string id;
        private string name;

        public Person()
        {
        }

        public Person(string id, string name) : this()
        {
        }

        public Person(string guid, string id, string name) : this()
        {
            this.guid = guid;
            this.id = id;
            this.name = name;
        }

        public string Guid
        {
            get
            {
                return this.guid;
            }
            set
            {
                this.guid = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}

