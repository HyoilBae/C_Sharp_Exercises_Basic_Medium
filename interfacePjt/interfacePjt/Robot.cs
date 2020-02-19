using System;
using System.Collections.Generic;
using System.Text;

namespace interfacePjt
{
    class Robot : INewGenerationRobot
    {
        public void DoFly()
        {
            Console.WriteLine(" === DoFly() START === ");
        }

        public void DoWalk()
        {
            Console.WriteLine(" === DoWalk() START === ");
        }
    }
}
