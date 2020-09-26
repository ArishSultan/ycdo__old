namespace Common
{
    using System;
    using System.Collections.Generic;

    public class Job
    {
        private string guId;
        private string id;
        private List<Phase> phases;
        private bool usePhases;

        public Job()
        {
            this.phases = new List<Phase>();
        }

        public Job(string id) : this()
        {
            this.id = id;
        }

        public override bool Equals(object obj)
        {
            Job job = obj as Job;
            if (obj == null)
            {
                return false;
            }
            return (job.id == this.id);
        }

        public string GuId
        {
            get
            {
                return this.guId;
            }
            set
            {
                this.guId = value;
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

        public List<Phase> Phases
        {
            get
            {
                return this.phases;
            }
            set
            {
                this.phases = value;
            }
        }

        public bool UsePhases
        {
            get
            {
                return this.usePhases;
            }
            set
            {
                this.usePhases = value;
            }
        }
    }
}

