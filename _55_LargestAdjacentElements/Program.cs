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

            for (int i = 0; i < 20; i++)
            {
            intList.Add(random.Next(1, 20));
            }
            Console.Write(string.Join(", ", intList));
            

            //genericList.caclLargestAdjs<int>();
           
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


