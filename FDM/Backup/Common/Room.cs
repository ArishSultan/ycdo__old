using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Room
    {
        public long Number { get; set; }
        public string Name { get; set; }
        public string LabelName { get; set; }
        public string Type { get; set; }

        public Room() { }
        public Room(long number, string name, string labelName):this ()
        {
            this.Number = number;
            this.Name = name;
            this.LabelName = labelName;
        }
        public Room(long number, string name, string labelName,string type)
            : this()
        {
            this.Number = number;
            this.Name = name;
            this.LabelName = labelName;
            this.Type =type;
        }
        public override string ToString()
        {
            return this.Name + " - " + this.LabelName;
        }
    }
}
