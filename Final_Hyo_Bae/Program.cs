using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Hyo_Bae
{
    class Program
    {
        /// <summary>
        /// CSC 205 Fianl Exam
        /// HYO IL BAE
        /// </summary>
        static void Main(string[] args)
        {
            //Problem1
            //calling Problem 1 method with string input "Hyo il Bae"
            //Problem1("Hyo il Bae");

            //Problem2
            //calling Problem 2 method with string input "Hyo il" as a first name and "Bae" as a lastname
            //Problem2("Hyo il", "Bae");

            //Problem3
            //calling Problem 3 method 4 times to ask user to enter numbers
            //Problem3(); //Enter 0 1 2 3 4 5 6 7 8 9
            //Problem3(); //Enter 0 8 2 3 7 5 6 4 1 9
            //Problem3(); //Enter 0 1 2 3 5 4 6 7 8 9
            //Problem3(); //Enter 9 8 7 6 5 4 3 2 1 0

            //Problem4
            //calling Problem 4 method name "HighLow" 
            //HighLow("1 2 3 4 5");
            HighLow("1 2 -3 4 5");
            //HighLow("1 9 3 4 -5");
            //HighLow("13");
            

        }
        //Problem 1 (Function Name should be Probelm1, invoke/call the function from main method
        //In this function you need to print your name three times using for loop, then print your name again three times using while loop.
        public static void Problem1(string name)
        {
            Console.WriteLine("-----------------------Problem 1 ---------------------------");
            Console.WriteLine("Print your name 3 times using For lopp");
            //using for loop to print out name 3 times
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            //using while loop to print out name 3 times
            Console.WriteLine("Print your name 3 times using While loop");
            int n = 0;
            //once n is equal to or bigger than 3 this loop will stop
            while (n < 3)
            {
                Console.WriteLine(name);
                //increase numbers of n
                n++;
            }
            Console.WriteLine("------------------------------------------------------------");
        }

        //Problem2 (Function Name should be Problem2 invoke/call function from main method)
        //In this fuction you need to create an array. 
        //The fist index of the array should have your first name 
        //and the second index of the array should ahve your last name.
        //Use for loop to print your lastName then your firstName
        public static void Problem2(string firstName, string lastName)
        {
            Console.WriteLine("-----------------------Problem 2 ---------------------------");
            Console.WriteLine("Print your lastName and firstName using for loops from array");
            //have a name string array with two elements 
            string[] nameArr = new string[] { firstName, lastName };

            //using for loop to print out last name and first name from the last index to the first index
            for (int i = 1; i >= 0; i--)
            {
                Console.WriteLine(nameArr[i]);
            }
            Console.WriteLine("------------------------------------------------------------");
        }

        //Problem 3 (Function Name should be Problem 3)
        //Create a program to ASK the user for 10 integer numbers(from -1000 to 1000)
        //sort them and display them sorted
        //Call the function four times from main method with the following values:
        //"0,1,2,3,4,5,6,7,8,9"
        //"0,8,2,3,7,5,6,4,1,9"
        //"0,1,2,3,5,4,6,7,8,9"
        //"9,8,7,6,5,4,3,2,1,0"
        //Notes All numbers are valid Int32, no need to validate them.
        public static void Problem3()
        {
            //ask user to enter 10 numbers
            Console.WriteLine("Enter 10 integer numbers from -1000 and 1000 :");
            //set up int array size of 10
            int[] userArr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                //as user enter each number, it will assign to each index into int array
                int userInput = Convert.ToInt32(Console.ReadLine());
                userArr[i] = userInput;
            }
            Console.WriteLine("Numbers before sorted");
            //this will show you what you have in the userArr array
            Console.Write(string.Join(" ", userArr));
            Console.WriteLine();

            //using two for loop two check if number of at i index if smaller than a number of at j index
            for (int i = 0; i < userArr.Length; i++)
            {
                for (int j = 0; j < userArr.Length; j++)
                {
                    if (userArr[i] < userArr[j])
                    {
                        var temp = userArr[j];
                        userArr[j] = userArr[i];
                        userArr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Numbers after sorted");
            Console.WriteLine(string.Join(" ", userArr));
        }

        //Problem4 (Function Name should be HighLow)
        //Create a function that accepts a string of space separated numbers and returns the highest and lowest number (as string)
        //Call/invoke the function four times from main method with the following values:
        //HighLow("1 2 3 4 5")     Note: The output should be "5 1" 
        //HighLow("1 2 -3 4 5")    Note: The output should be "5 -3" 
        //HighLow("1 9 3 4 -5")    Note: The output should be "9 -5"
        //HighLow("13")           Note: The output should be "13 13"
        //Notes All numbers are valid Int32, no need to validate them.
        public static void HighLow(string str)
        {
            var format = new NumberFormatInfo();
            format.NegativeSign = "-";
            format.NumberDecimalSeparator = ".";

            Console.WriteLine("User Input :");
            Console.WriteLine(string.Join(", ", str));

            List<int> intList = new List<int>();

            for (int i = 0; i < str.Length; i++)
            {
                if ((int)char.GetNumericValue(str[i]) == -1)
                {
                    continue;
                }
                else
                {
                    int number = (int)char.GetNumericValue(str[i]);
                    intList.Add(number);
                }
            }

            Console.WriteLine("After string numbers are converted to int numbers and remove spaces between numbers");
            foreach (var item in intList)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            for (int i = 0; i < intList.Count; i++)
            {
                for (int j = 0; j < intList.Count; j++)
                {
                    if (intList[i] < intList[j])
                    {
                        var temp = intList[j];
                        intList[j] = intList[i];
                        intList[i] = temp;
                    }
                }
            }
            Console.WriteLine("Numbers after sorted");
            Console.WriteLine(string.Join(" ", intList));

            Console.WriteLine($"The smallest number is : {intList[0]}");
            Console.WriteLine($"The biggest number is : {intList[intList.Count - 1]}");


          


        }
    }
}
