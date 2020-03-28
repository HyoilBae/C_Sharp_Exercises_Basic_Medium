using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ReverseTheWordOfSentence_28
{
    class Program
    {
        static void Main(string[] args)
        {
            string randLine = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Original String: {0}", randLine);
            Console.WriteLine("\n");


            string[] words = randLine.Split();
            //string[] words = randLine.Split(new[] {" "}, StringSplitOptions.None);
            Console.Write("string[] words = ");
            foreach (string word in words)
            {
                Console.Write("[" + word + "]" + ", ");
            }
            Console.WriteLine("\n");


            //List<string> wordsList = new List<string>();
            ArrayList wordsList = new ArrayList();

            string result = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result = result + words[i] + " ";
            }
            wordsList.Add(result);


            foreach (String s in wordsList)
            {
                Console.WriteLine("Reverse String: " + s);
            }
            Console.WriteLine("\n");
        }
    }
    
}
