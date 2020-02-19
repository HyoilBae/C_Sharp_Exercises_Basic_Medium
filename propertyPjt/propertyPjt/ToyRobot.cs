using System;
using System.Collections.Generic;
using System.Text;

namespace propertyPjt
{
    class ToyRobot : AToy
    {
        public override string Origin
        {
            get; set;
        }

        public override string Name
        {
            get; set;
        }

        public override void DoFly()
        {
            Console.WriteLine(" === DoFly() === ");
            Console.WriteLine(" === This toy cannot fly. Because it's a robot. === ");
        }

        public override void PrintInfo()
        {
            Console.WriteLine(" === PrintInfo() === ");
            Console.WriteLine($"Origin : {Origin}");
            Console.WriteLine($"Name : {Name}");
        }
    }
}
