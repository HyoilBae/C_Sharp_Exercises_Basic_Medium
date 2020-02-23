using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPjt
{
    class PrintClassString
    {
        private string var;

        public PrintClassString(string param)
        {
            Console.WriteLine(" === PrintClassString(string param) CONSTRUCTOR === ");
            this.var = param;
        }

        public void printVar()
        {
            Console.WriteLine($"var = {var}");
        }
    }
}
