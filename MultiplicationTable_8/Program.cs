using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Basic No.8
/// </summary>

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int inputN = int.Parse(Console.ReadLine());

            MultiTable(inputN);

        }

        static void MultiTable(int a)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, (a*i));
            }
        }
    }
}
