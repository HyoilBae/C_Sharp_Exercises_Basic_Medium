using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildBaseOverride
{
    class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine(" === ChildClass Constructor ===");
        }

        public override void makeJjajang()
        {
            Console.WriteLine(" === makeJjajang() of ChildClass Start ===");
            //base.makeJjajang();
        }

        public new void makeJjamppong()
        {
            Console.WriteLine(" === Jjamppong() of ChildClass START ===");
        }

  
    }
}
