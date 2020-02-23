using System;
using System.Collections.Generic;
using System.Text;

namespace lambdaPjt
{

    delegate int Calculator(int a, int b);
    delegate void CalculatorPrint(int a, int b);

    class Anonymouse
    {

        public Anonymouse()
        {
            Console.WriteLine("=== Anonymouse DEFAULT CONSTRUCTOR ===");
        }

        public int DoAddition(int a, int b)
        {
            return a + b;
        }
        public int DoSubtraction(int a, int b)
        {
            return a - b;
        }

    }
}
