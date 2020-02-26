using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_pairOfadjacentElementsHighest
{
    class Program
    {
        public static int adjacent_Elements_Product(int[] input_Array)
        {
            int max = input_Array[0] * input_Array[1];
            for (int x = 1; x <= input_Array.Length - 2; x++)
            {
                max = Math.Max(max, input_Array[x] * input_Array[x + 1]);
            }
            return max;
        }
        public static void Main()
        {
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, -3, 4, -5, 1 }));
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, 4, 5, 2 }));
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, -4, 5, 2 }));
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 0, -4, 0, 2 }));
        }
    }
}
