using System;
using System.Collections.Generic;
using System.Text;

namespace interfacePjt
{
    class ToyForCN : IToy
    {
        public ToyForCN()
        {
            Console.WriteLine(" === ToyForCN CONSTRUCTOR === ");
        }

        public void DoGreet()
        {
            Console.WriteLine("你好.");
        }

        public void GreetForFirst()
        {
            Console.WriteLine("你好.");
        }

    }
}
