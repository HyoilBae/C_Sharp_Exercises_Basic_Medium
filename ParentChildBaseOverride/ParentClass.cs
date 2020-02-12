using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildBaseOverride
{
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("=== ParentsClass CONSTRUCTOR ===");
        }

        public virtual void makeJjajang()
        {
            Console.WriteLine("=== makeJjajang() of PrentsClass START ===");
        }

        public void makeJjamppong()
        {
            Console.WriteLine("=== Jjamppong() of ParentsClass START ===");
        }
    }
}
