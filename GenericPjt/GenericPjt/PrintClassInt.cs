using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPjt
{
    class PrintClassInt
    {
        private int var;

        public PrintClassInt(int param)
        {
            Console.WriteLine(" === PrintClassInt(int param) CONSTRUCTOR === ");
            this.var = param;
        }

        public void printVar()
        {
            Console.WriteLine($"var = {var}");
        }
    }
}
