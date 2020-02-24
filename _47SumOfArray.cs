using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] Array1 = new int[10];

            int i = 0;
            while (i < 10)
            {

                Array1[i] = (random.Next(1, 10));
                i++;
            }



            Console.WriteLine(string.Join(", ", Array1));



            sumArray(Array1);

        }

        public static void sumArray(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum = sum + item;
            }
            Console.WriteLine(sum);
        }
    }
}
