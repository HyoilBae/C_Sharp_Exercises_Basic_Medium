using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _52_CreateArrayWithMiddleElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 5 };
            int[] array2 = { 0, 3, 8 };
            int[] array3 = { -1, 0, 2 };

            //easy way
            int[] middleArray = new int[3];
            middleArray[0] = array1[1];
            middleArray[1] = array2[1];
            middleArray[2] = array3[1];

            Console.WriteLine(string.Join(", ", middleArray));

            //what if 
           
        }
    }
}
