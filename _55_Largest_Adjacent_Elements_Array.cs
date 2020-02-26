using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_LargestAdjacentElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            GenericList genericList = new GenericList();
            List<int> intList = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                intList.Add(random.Next(1, 10));
            }
            Console.Write(string.Join(", ", intList));


            //genericList.caclLargestAdjs<int>(10);
            calLargest(intList);


        }

        static void calLargest(List<int> intList)
        {
            int largestEle = 0;

            for (int i = 0; i < intList.Count - 1; i++)
            {
                if (largestEle < (intList[i] * intList[i + 1]))
                {
                    largestEle = (intList[i] * intList[i + 1]);
                }
                Console.WriteLine();
                Console.WriteLine($"{intList[i]} * {intList[i + 1]} has the value of {largestEle}");
            }

            Console.WriteLine($"Largest value is {largestEle}");
        }

    }

    class GenericList
    {
        public GenericList()
        {
            Console.WriteLine("Default Constructor");
        }

        public void caclLargestAdjs<T>(T para)
        {

        }
    }
}


