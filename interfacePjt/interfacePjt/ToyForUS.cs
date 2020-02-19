using System;
using System.Collections.Generic;
using System.Text;

namespace interfacePjt
{
    class ToyForUS : IToy
    {
        public ToyForUS()
        {
            Console.WriteLine(" === ToyForUS CONSTRUCTOR === ");
        }

        public void DoGreet()
        {
            Console.WriteLine("Hello. Nice to meet you.");
        }

        public void GreetFirst()
        {
            Console.WriteLine("Hello. Nice to meet you.");
        }
    }
}
