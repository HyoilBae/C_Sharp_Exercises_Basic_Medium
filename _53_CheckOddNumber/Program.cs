using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_CheckOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 2, 4, 7, 8, 6 };

            for (int i = 0; i < intArr.Length; i++)
            {
                if (intArr[i] % 2 != 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
    }
}
