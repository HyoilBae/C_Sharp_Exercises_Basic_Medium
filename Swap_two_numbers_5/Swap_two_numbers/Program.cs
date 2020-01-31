using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter You First Number: ");
            int firstN = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Second Number ");
            int secondN = int.Parse(Console.ReadLine());

            Swap(firstN, secondN);

            void Swap(int a, int b)
            {
                int temp;
                temp = a;
                a = b;
                b = temp;

                Console.WriteLine("First Number is: "+ a);
                Console.WriteLine("Second Number is: "+ b);

            }
        }
    }
}
