using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_20
{
    class difference
    {
        public int twoDiff (int a, int b)
        {
            return a > b ? (Math.Abs(a - b)) * 2 : b - a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());

            difference d = new difference();
            int result = d.twoDiff(firstN, secondN);
            Console.WriteLine(result);
        }
    }
}
