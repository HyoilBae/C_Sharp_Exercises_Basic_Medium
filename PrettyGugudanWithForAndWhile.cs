using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyGugudan
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    Console.Write($"{j} * {i} = {i * j}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int n = 1;
            int nn = 2;
            while (n <= 9)
            {
                while (nn <= 9)
                {
                    Console.Write($"{nn} * {n} = {nn * n}\t");
                    nn++;
                }
                Console.WriteLine();
                nn = 2;
                n++;
                
            }
        }
    }
}
