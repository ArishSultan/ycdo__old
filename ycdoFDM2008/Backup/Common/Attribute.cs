using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public  class ItemAttribute
    {
        public string Name { get; set; }
        public List<AttributeLineItem> AttributeLines { get; set; }
        public ItemAttribute()
        {
            if(this.AttributeLines ==null )
                this.AttributeLines =new List<AttributeLineItem>();
        }
        public ItemAttribute(string name)
            : this()
        {
            this.Name = name;
        }
        
    }
}
