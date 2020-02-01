using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLastLetterChange_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string testData = Console.ReadLine();
            Console.WriteLine(first_last(testData));

            //Solution #2
            char[] testDataChar = testData.ToCharArray();
            switchLetter(testDataChar);

        }

        public static string first_last(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }


        //Solution #2
        static void switchLetter(char[] charlist)
        {
                char temp;

                temp = charlist[0];

                charlist[0] = charlist[charlist.Length - 1];

                charlist[charlist.Length - 1] = temp;

            for (int i = 0; i < charlist.Length; i++)
            {

                Console.Write(charlist[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
