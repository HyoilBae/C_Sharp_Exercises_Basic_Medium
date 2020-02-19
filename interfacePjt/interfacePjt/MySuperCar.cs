using System;
using System.Collections.Generic;
using System.Text;

namespace interfacePjt
{
    class MySuperCar : ICar, IAirplane
    {
        public void DoDriving()
        {
            Console.WriteLine(" === DoDriving() START === ");
        }

        public void DoFlight()
        {
            Console.WriteLine(" === DoFlight() START === ");
        }
    }
}
