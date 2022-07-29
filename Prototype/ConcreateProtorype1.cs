using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ConcreateProtorype1 : IPrototype
    {
        public int Property1 { get; set; }
        public string Property2 { get; set; }
        public ConcreateProtorype1(int property1, string property2)
        {
            this.Property1 = property1;
            this.Property2 = property2;
        }

        public IPrototype Clone()
        {
            return (IPrototype)this.MemberwiseClone();
        }
    }
}
