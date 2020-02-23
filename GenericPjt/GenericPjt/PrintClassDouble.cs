using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPjt
{
    class PrintClassDouble
    {
        private double var;

        public PrintClassDouble(double param)
        {
            Console.WriteLine(" === PrintClassDouble(double param) CONSTRUCTOR === ");
            this.var = param;
        }

        public void printVar()
        {
            Console.WriteLine($"var = {var}");
        }
    }
}
