using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPjt
{
    class PrintMethod
    {
        public PrintMethod()
        {
            Console.WriteLine(" === PrintMethod DEFAULT CONSTRUCTOR === ");
        }

        public void doPrint(int param)
        {
            Console.WriteLine("=== doPrint(int a) STARAT ===");
            Console.WriteLine($"param = {param}");
        }

        public void doPrint(double param)
        {
            Console.WriteLine("=== doPrint(double a) STARAT ===");
            Console.WriteLine($"param = {param}");
        }

        public void doPrint(string param)
        {
            Console.WriteLine("=== doPrint(string a) STARAT ===");
            Console.WriteLine($"param = {param}");
        }
    }
}
