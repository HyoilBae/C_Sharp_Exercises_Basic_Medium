using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPjt
{
    class PrintMethodGeneric
    {

        public PrintMethodGeneric()
        {
            Console.WriteLine(" === PrintMethodGeneric DEFAULT CONSTRUCTOR === ");
        }

        public void doPrint<T>(T param)
        {
            Console.WriteLine("=== doPrint<T>(T param) STARAT ===");
            Console.WriteLine($"param = {param}");
        }

    }
}
