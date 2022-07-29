using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ConcreateProtorype2 : IPrototype
    {
        public ConcreateProtorype1 MyApplicationService { get; set; }
        public ConcreateProtorype2(ConcreateProtorype1 myApplicationService)
        {
            this.MyApplicationService = myApplicationService;
        }
        public IPrototype Clone()
        {
            var result = (ConcreateProtorype2)this.MemberwiseClone();
            result.MyApplicationService = (ConcreateProtorype1)this.MyApplicationService.Clone();
            return (IPrototype)result;
        }
    }
}
