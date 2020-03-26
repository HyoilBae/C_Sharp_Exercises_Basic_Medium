using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaDeciToDeci_30
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexaDeci = "4B0";
            Console.WriteLine("Hexadecimal number: " + hexaDeci);

            int deci = int.Parse(hexaDeci, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine("Convert to Decimal number: " + deci);
        }
    }
}
