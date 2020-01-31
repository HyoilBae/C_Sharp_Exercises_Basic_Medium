using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNumberAverage_9
{
    class A
    {
        public void Average(int a, int b, int c, int d)
        {
            float avgNumber = (float)(a + b + c + d) / 4;
            Console.WriteLine("The average of {0} {1} {2} {3} = {4}", a, b, c, d, avgNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four random numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            A test = new A();
            test.Average(num1, num2, num3, num4);
        }
    }
}
