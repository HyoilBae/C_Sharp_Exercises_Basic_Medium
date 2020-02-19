using System;
using System.Collections.Generic;
using System.Text;

namespace propertyPjt
{
    abstract class AToy
    {
        abstract public string Origin
        {
            get; set;
        }

        abstract public string Name
        {
            get; set;
        }

        public void DoWalk()
        {
            Console.WriteLine(" === DoWalk() === ");
        }

        abstract public void DoFly();

        abstract public void PrintInfo();

    }
}
