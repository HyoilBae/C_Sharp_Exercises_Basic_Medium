using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Absolute_Difference_Between_51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you number :");
            int userInt = int.Parse(Console.ReadLine());

            Console.WriteLine(absFromFiftyOne(userInt));
        }

        static int absFromFiftyOne(int n)
        {
            //int result;
            //if (n > 51)
            //{
            //    result = (Math.Abs(51 - n)) * 3;
            //    return result;
            //}
            //else
            //{
            //    result = (Math.Abs(51 - n));
            //    return result;
            //}

            return n > 51 ? (Math.Abs(51 - n)) * 3 : (Math.Abs(51 - n));
        }
    }
}
