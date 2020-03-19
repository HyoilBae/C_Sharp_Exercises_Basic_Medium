using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_MoveLeftArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 2, 8 };
            Console.WriteLine(string.Join(",", Array1));

            var empty = 0;
            empty = Array1[0];
            Array1[0] = Array1[1];
            Array1[1] = Array1[2];
            Array1[2] = empty;

            Console.WriteLine(string.Join(",", Array1));


            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            var temp = nums[0];
            for (var i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;
            Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));

        }
    }
}
