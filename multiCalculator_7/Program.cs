using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number: ");
            int firstN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int secondN = int.Parse(Console.ReadLine());

            multiCalc(firstN, secondN);

         
        }

        public static void multiCalc(int a, int b)
        {
            int plus, minus, multiply, divide, modulo;
            plus = a + b;
            minus = a - b;
            multiply = a * b;
            divide = a / b;
            modulo = a % b;

            Console.WriteLine("{0} + {1} = {2}", a, b, plus);
            Console.WriteLine("{0} - {1} = {2}", a, b, minus);
            Console.WriteLine("{0} * {1} = {2}", a, b, multiply);
            Console.WriteLine("{0} / {1} = {2}", a, b, divide);
            Console.WriteLine("{0} % {1} = {2}", a, b, modulo);
        }
    }
}
