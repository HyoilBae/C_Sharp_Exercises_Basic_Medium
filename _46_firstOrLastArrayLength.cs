using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_firstOrLastArray_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Enter a number : ");
            int userInput = int.Parse(Console.ReadLine());

            List<int> intList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                intList.Add(random.Next(1, 10));
            }

            foreach (var item in intList)
            {
                Console.WriteLine(item + " ");
            }

            bool result = firstLast(intList, userInput);
            Console.WriteLine($"result is {result} and the list has {intList.Count} long");


            //Console.WriteLine("\nInput an integer:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            //Console.WriteLine((nums[0] == x) || (nums[nums.Length - 1] == x));
        }

        static bool firstLast(List<int> list, int n)
        {

           

                if (list[0] == n || list[list.Count -1] == n)
                {
                    return true;
                   
                }
                else
                {
                    return false;
                    
                }
                      
            
            
        }

        
    }
}
