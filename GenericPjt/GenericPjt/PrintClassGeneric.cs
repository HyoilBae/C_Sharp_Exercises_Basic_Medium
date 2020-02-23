using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPjt
{
    class PrintClassGeneric<T>
    {
        private T var;

        public PrintClassGeneric(T param)
        {
            Console.WriteLine(" === PrintClassGeneric(T param) CONSTRUCTOR === ");
            this.var = param;
        }

        public void printVar()
        {
            Console.WriteLine($"var = {var}");
        }
    }
}
