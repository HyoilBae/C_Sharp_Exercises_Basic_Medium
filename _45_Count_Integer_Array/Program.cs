using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Count_Integer_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] intArr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                intArr[i] = random.Next(1, 10);
            }

            foreach (var item in intArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            arrCounter(intArr,random.Next(1, 10));
        }

        static void arrCounter(int[] arr, int target)
        {
            //List<int> counter = new List<int>();
            int numInCounter = 0;
            

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    numInCounter++;
                }
            }
            Console.WriteLine($"This array has {target} | {numInCounter} times");
        }
    }
}
