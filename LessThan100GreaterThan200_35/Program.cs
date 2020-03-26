using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessThan100GreaterThan200_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number : ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber < 100 && secondNumber > 200)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
