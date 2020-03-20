using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_CenturyFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(centuryFromYear(1799) == 18);
            Console.WriteLine(centuryFromYear(1900) == 19);
            Console.WriteLine(centuryFromYear(1901) == 19);
            Console.WriteLine(centuryFromYear(1901) == 20);
            Console.WriteLine(centuryFromYear(1806) == 19);
            Console.WriteLine(centuryFromYear(1568) == 20);
            Console.WriteLine(centuryFromYear(2010) == 21);
        }

        public static int centuryFromYear(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }
    }
}
