using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace _44_oddPositionChracters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What? : ");
            string userInput = Console.ReadLine();
            //oddPosition(userInput);
            //oddPositionArrList(userInput);
            oddPositionList<string>(userInput);
        }

        static void oddPosition(string str)
        {
            int arrSize = str.Length;
            string[] strArr = new string[arrSize / 2];
            int iCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
               
                if (i % 2 == 0)
                {
                strArr[iCount] = str[i].ToString();
                    iCount++;
                }
            }

            foreach (var item in strArr)
            {
                Console.Write(item);
            }
        }

        static void oddPositionArrList(string str)
        {
            ArrayList strArr = new ArrayList();
            for (int i = 0; i < str.Length; i++)
            {
                if (i%2 == 0)
                {
                    strArr.Add(str[i]);
                }
            }

            foreach (var item in strArr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        static void oddPositionList<T>(string str)
        {
            Console.WriteLine(str);
            List<char> strList = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    strList.Add(str[i]);
                }
            }
            foreach (var item in strList)
            {
                Console.Write(item +" ");
            }
        }
    }
}
