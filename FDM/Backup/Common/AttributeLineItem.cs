using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public  class AttributeLineItem
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public AttributeType Type { get; set; }

        public AttributeLineItem()
        {

        }
        public AttributeLineItem( string id,string description)
            : this()
        {
            this.Id = id;
            this.Description = description;
        }
        public override string ToString()
        {
            return this.Id;
        }
    }
}
