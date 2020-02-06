using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyTwoArrayInt_31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array1: [1, 3, -5, 4]
            //Array2: [1, 4, -5, -2]
            int[] intArr1 = { 1, 3, -5, 4 };
            int[] intArr2 = { 1, 4, -5, -2 };

            //for (int i = 0; i < intArr1.Length; i++)
            //{
            //    for (int j = 0; j < intArr2.Length; j++)
            //    {
            //        int multiArr = intArr1[i] * intArr2[j];
            //        Console.WriteLine(multiArr);
            //    }
            //}

            for (int i = 0; i < intArr1.Length; i++)
            {
                int multiplyArr = intArr1[i] * intArr2[i];
                Console.WriteLine("{0} * {1} = {2}", intArr1[i], intArr2[i], multiplyArr);
            }
            
        }
    }
}
