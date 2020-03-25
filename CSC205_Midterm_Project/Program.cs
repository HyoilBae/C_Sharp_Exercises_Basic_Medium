using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace CSC205_Midterm_Project
{
    class Program
    {

        static void Main(string[] args)
        {
            ///*
            // * Reference Website: https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=netframework-4.8
            // * 
            // * _#1 Namespace "System.Collections"
            // */
            ////-------------------------------------------------------------------------------ArrayList Class --------------------------------------------------------------------------------------
            ////---------------------------------------------------------------------------------Add Method --------------------------------------------------------------------------------------------

            //// Creates and initializes a new ArrayList.
            //ArrayList myAL = new ArrayList();
            //myAL.Add("Hi");
            //myAL.Add("MSSA");
            //myAL.Add("Cohort");
            //myAL.Add("27");
            //// Displays the ArrayList and the Queue using foreach loop
            //Console.WriteLine("Original ArrayList :");
            //foreach (string word in myAL)
            //{
            //    Console.Write(word + " ");
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("\n");

            ////---------------------------------------------------------------------------------CopyTo Method --------------------------------------------------------------------------------------------
            //// Creates and initializes the one-dimensional target Array.
            //// Creates string array size of 15
            //String[] myTargetArray = new String[15];
            //myTargetArray[0] = "Good";
            //myTargetArray[1] = "Afternoon!";
            //myTargetArray[2] = "How";
            //myTargetArray[3] = "are";
            //myTargetArray[4] = "you";
            //myTargetArray[5] = "guys";
            //myTargetArray[6] = "doing";
            //myTargetArray[7] = "today";
            //myTargetArray[8] = "?";
            //// Displays the values of the target Array Using foreach loop
            //Console.WriteLine("myTargetArray : ");
            //foreach (string word in myTargetArray)
            //{
            //    Console.Write(word + " ");
            //}
            //Console.WriteLine("\n");
            //// Copies the second element from the source ArrayList to the target Array starting at index 7.
            //myAL.CopyTo(1, myTargetArray, 7, 1);
            //// Displays the values of the target Array.
            //foreach (string word in myTargetArray)
            //{
            //    Console.Write(word + " ");
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("\n");

            ////---------------------------------------------------------------------------------IndexOf Method --------------------------------------------------------------------------------------------
            //// Search for the first occurrence of the duplicated value.
            //String myString = "MSSA";
            //// Gettig int Index by using IndexOf Method
            //int myIndex = myAL.IndexOf(myString);
            //Console.WriteLine("The first occurrence of \"{0}\" is at index {1}.", myString, myIndex);
            //Console.WriteLine("\n");
            //Console.WriteLine("\n");

            ////---------------------------------------------------------------------------------Sort Method --------------------------------------------------------------------------------------------
            ////Create new ArrayList
            //ArrayList myNumberAL = new ArrayList();
            ////Ading int numbers into myNumberAL ArrayList using Add Method
            //myNumberAL.Add(10000);
            //myNumberAL.Add(9);
            //myNumberAL.Add(88);
            //myNumberAL.Add(101);
            //// Displays the values of the ArrayList.
            //Console.WriteLine("The ArrayList initially contains the following values:");
            //foreach (int num in myNumberAL)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine("\n");

            //// Sorts the values of the ArrayList.
            //myNumberAL.Sort();

            //// Displays the values of the ArrayList.
            //Console.WriteLine("After sorting:");
            //foreach (int num in myNumberAL)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("\n");

            ////---------------------------------------------------------------------------------Clear Method --------------------------------------------------------------------------------------------
            //// Clear the ArrayList.
            //myAL.Clear();
            //Console.Write("This won't print out anything");
            //foreach (string word in myAL)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.WriteLine("\n");












            // /*
            // * Reference Website: https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=netframework-4.8
            // * 
            // * _#2 Namespace "System.Collections.Generic"
            // */
            // //---------------------------------------------------------------------------------  Queue<T> Class --------------------------------------------------------------------------------------
            // //--------------------------------------------------------------------------------- Enqueue(T) Method ------------------------------------------------------------------------------------
            // //Cretes Queue<string>
            // Queue<string> numbers = new Queue<string>();

            // //Enqueue(T) Adds an object to the end of the Queue<T>
            // numbers.Enqueue("one");
            // numbers.Enqueue("two");
            // numbers.Enqueue("three");
            // numbers.Enqueue("four");
            // numbers.Enqueue("five");

            // // A queue can be enumerated without disturbing its contents.
            // foreach (string number in numbers)
            // {
            //     Console.WriteLine(number);
            // }
            // Console.WriteLine("\n");


            // //--------------------------------------------------------------------------------- Dequeue() Method --------------------------------------------------------------------------------------------
            // Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());
            // Console.WriteLine("\n");

            // //--------------------------------------------------------------------------------- Peek() Method --------------------------------------------------------------------------------------------
            // Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());



            // //--------------------------------------------------------------------------------- ToArray() Method --------------------------------------------------------------------------------------------
            // // Create a copy of the queue, using the ToArray method
            // Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            // Console.WriteLine("\nContents of the first copy:");
            // foreach (string number in queueCopy)
            // {
            //     Console.WriteLine(number);
            // }

            // //--------------------------------------------------------------------------------- Contains(T) Method --------------------------------------------------------------------------------------------
            // //Checking if four in the Queue using Contains Method
            // Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}", queueCopy.Contains("four"));


            // //--------------------------------------------------------------------------------- Clear() Method --------------------------------------------------------------------------------------------
            // //Clear the Queue using Clear Method
            // queueCopy.Clear();
            // Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);













            // /*
            // * Reference Website: https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=netframework-4.8
            // * 
            // * _#3 Namespace "System.IO"
            // */
            // //------------------------------------------------------------------------------ File Class --------------------------------------------------------------------------------------
            // //------------------------------------------------------------------------------ Exists(String)  Method --------------------------------------------------------------------------------------------
            // //Determines whether the specified file exists.
            // string path = @"C:\Users\hyoil\Desktop\MSSA\MyTest.txt";
            // Console.WriteLine(File.Exists(path) ? "File exists." : "File does not exist.");

            // //------------------------------------------------------------------------------ OpenText Method --------------------------------------------------------------------------------------------
            // // Open the file to read from.
            // using (StreamReader sr = File.OpenText(path))
            // {
            //     string s;
            //     //if an opening text file does have text
            //     while ((s = sr.ReadLine()) != null)
            //     {
            //         Console.WriteLine(s);
            //     }
            // }

            // //------------------------------------------------------------------------------ Create / Write Method --------------------------------------------------------------------------------------------
            // string path1 = @"C:\Users\hyoil\Desktop\MSSA\Create.txt";
            // try
            // {
            //     // Create the file if there's none, or overwrite if the file exists.
            //     using (FileStream fs = File.Create(path1))
            //     {
            //         // Add some information to the file.
            //         byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
            //         fs.Write(info, 0, info.Length);
            //     }
            //     // Open the stream and read it back.
            //     using (StreamReader sr = File.OpenText(path1))
            //     {
            //         string s = "";
            //         while ((s = sr.ReadLine()) != null)
            //         {
            //             Console.WriteLine(s);
            //         }
            //     }
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.ToString());
            // }

            // //------------------------------------------------------------------------------ AppendText(String) Method --------------------------------------------------------------------------------------------
            // using (StreamWriter sw = File.AppendText(path))
            // {
            //     sw.WriteLine("");
            //     sw.WriteLine("This");
            //     sw.WriteLine("is Extra");
            //     sw.WriteLine("Text");
            // }
            // // Open the file to read from.
            // using (StreamReader sr = File.OpenText(path))
            // {
            //     string s = "";
            //     while ((s = sr.ReadLine()) != null)
            //     {
            //         Console.WriteLine(s);
            //     }
            // }

            // //------------------------------------------------------------------------------ Delete Method --------------------------------------------------------------------------------------------
            // File.Delete(path);
            // if (File.Exists(path))
            // {
            //     Console.WriteLine("The original file still exists, which is unexpected.");
            // }
            // else
            // {
            //     Console.WriteLine("The original file no longer exists, which is expected.");
            // }

            // File.Delete(path1);
            // if (File.Exists(path1))
            // {
            //     Console.WriteLine("The original file still exists, which is unexpected.");
            // }
            // else
            // {
            //     Console.WriteLine("The original file no longer exists, which is expected.");
            // }










            ///*
            //* Reference Website: https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=netframework-4.8
            //* 
            //* _#4 Namespace "System.Linq"
            //*/
            ////------------------------------------------------------------------------------ Enumerable Class --------------------------------------------------------------------------------------
            ////------------------------------------------------------------------------------ Average(IEnumerable<Int32>) Method --------------------------------------------------------------------------------------------
            //List<int> grades = new List<int> { 78, 92, 100, 37, 81 };
            //double average = grades.Average();
            //Console.WriteLine("The average grade is {0}.", average);

            ////------------------------------------------------------------------------------ Max(IEnumerable<Int32>) Method --------------------------------------------------------------------------------------------
            //List<int> ints = new List<int> { 42949672, 466855, 81125 };
            //int max = ints.Max();
            //Console.WriteLine("The largest number is {0}.", max);

            ////------------------------------------------------------------------------------ Min(IEnumerable<Double>) Method --------------------------------------------------------------------------------------------
            //double[] doubles = { 1.5E+104, 9E+103, -2E+103 };
            //double min = doubles.Min();
            //Console.WriteLine("The smallest number is {0}.", min);

            ////------------------------------------------------------------------------------ Range(Int32, Int32) Method --------------------------------------------------------------------------------------------
            //// Generate a sequence of integers from 1 to 10 
            //// and then select their squares.
            //IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

            ////foreach (int num in squares)
            ////{
            ////    Console.WriteLine(num);
            ////}
            //Console.WriteLine(string.Join(", ", squares));

            ////------------------------------------------------------------------------------ Reverse Method --------------------------------------------------------------------------------------------
            //char[] apple = { 'a', 'p', 'p', 'l', 'e' };
            //char[] reversed = apple.Reverse().ToArray();
            //foreach (char chr in reversed)
            //{
            //    Console.Write(chr + " ");
            //}
            //Console.WriteLine();

            ////------------------------------------------------------------------------------ Sum Method --------------------------------------------------------------------------------------------
            //List<float> numbers = new List<float> { 43.68F, 1.25F, 583.7F, 6.5F };
            //float sum = numbers.Sum();
            //Console.WriteLine("The sum of the numbers is {0}.", sum);









           // /*
           //* Reference Website: https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=netframework-4.8
           //* 
           //* _#5 Namespace "System."
           //*/
           // //------------------------------------------------------------------------------ DateTime Struct --------------------------------------------------------------------------------------
           // //------------------------------------------------------------------------------ Add Method --------------------------------------------------------------------------------------------
           // // Calculate what day of the week is 36 days from this instant.
           // DateTime today = DateTime.Now;
           // TimeSpan duration = new System.TimeSpan(100, 0, 0, 0);
           // DateTime answer = today.Add(duration);
           // Console.WriteLine(today);
           // Console.WriteLine(duration);
           // //Console.WriteLine("{0:dddd}", answer);
           // Console.WriteLine(answer);

           // //------------------------------------------------------------------------------ AddDays Method --------------------------------------------------------------------------------------------
           // Console.WriteLine();
           // DateTime answer1 = today.AddDays(36);
           // Console.WriteLine("Today: {0:dddd}", today);
           // Console.WriteLine("36 days from today: {0:dddd}", answer1);

           // //------------------------------------------------------------------------------ AddHours Method --------------------------------------------------------------------------------------------
           // Console.WriteLine();
           // double[] hours = {29, 30, 31, 90, 365};
           // DateTime dateValue = new DateTime(2020, 2, 25, 12, 0, 0);
           // foreach (double hour in hours)
           //     Console.WriteLine("{0} + {1} hour(s) = {2}", dateValue, hour,
           //                       dateValue.AddHours(hour));

           // //------------------------------------------------------------------------------ AddMinutes Method --------------------------------------------------------------------------------------------
           // Console.WriteLine();
           // DateTime dateValue1 = new DateTime(2020, 2, 25, 12, 0, 0);
           // double[] minutes = {30, 17, 45, 60, 180};
           // foreach (double minute in minutes)
           //     Console.WriteLine("{0} + {1} minute(s) = {2}", dateValue1, minute,
           //                       dateValue.AddMinutes(minute));

           // //------------------------------------------------------------------------------ AddMonths Method --------------------------------------------------------------------------------------------
           // Console.WriteLine();
           // var dat = new DateTime(2020, 02, 25);
           // for (int addingMonth = 0; addingMonth <= 5; addingMonth++)
           //     Console.WriteLine(dat.AddMonths(addingMonth).ToString("d"));


           // //------------------------------------------------------------------------------ AddYears Method --------------------------------------------------------------------------------------------
           // Console.WriteLine();
           // DateTime baseDate = new DateTime(2020, 2, 25);
           // Console.WriteLine("    Base Date:        {0:d}\n", baseDate);

           // // Show dates of previous fifteen years.
           // for (int ctr = -1; ctr >= -5; ctr--)
           //     Console.WriteLine("{0,2} year(s) ago:        {1:d}",
           //                       Math.Abs(ctr), baseDate.AddYears(ctr));
           // Console.WriteLine();

           // // Show dates of next fifteen years.
           // for (int ctr = 1; ctr <= 5; ctr++)
           //     Console.WriteLine("{0,2} year(s) from now:   {1:d}",
           //                       ctr, baseDate.AddYears(ctr));

           // //------------------------------------------------------------------------------ Compare Method --------------------------------------------------------------------------------------------
           // Console.WriteLine();
           // DateTime dateCompare1 = new DateTime(2020, 2, 25, 0, 0, 0);
           // DateTime dateCompare2 = new DateTime(2020, 2, 25, 12, 0, 0);
           // int result = DateTime.Compare(dateCompare1, dateCompare2);
           // string relationship;

           // if (result < 0)
           //     relationship = "is earlier than";
           // else if (result == 0)
           //     relationship = "is the same time as";
           // else
           //     relationship = "is later than";

           // Console.WriteLine("{0} {1} {2}", dateCompare1, relationship, dateCompare2);


           // //------------------------------------------------------------------------------ DaysInMonth Method --------------------------------------------------------------------------------------------
           // Console.WriteLine();
           //  const int July = 7;
           //  const int Feb = 2;

           //  int daysInJuly = System.DateTime.DaysInMonth(2001, July);
           //  Console.WriteLine(daysInJuly);

           //  // daysInFeb gets 28 because the year 1998 was not a leap year.
           //  int daysInFeb = System.DateTime.DaysInMonth(1998, Feb);
           //  Console.WriteLine(daysInFeb);

           //  // daysInFebLeap gets 29 because the year 1996 was a leap year.
           //  int daysInFebLeap = System.DateTime.DaysInMonth(1996, Feb);
           //  Console.WriteLine(daysInFebLeap);

           // //------------------------------------------------------------------------------ IsLeapYear Method --------------------------------------------------------------------------------------------
           // Console.WriteLine();
           // for (int year = 2020; year <= 2030; year++)
           // {
           //     if (DateTime.IsLeapYear(year))
           //     {
           //         Console.WriteLine("{0} is a leap year.", year);
           //         DateTime leapDay = new DateTime(year, 2, 29);
           //         DateTime nextYear = leapDay.AddYears(1);
           //         Console.WriteLine("   One year from {0} is {1}.",
           //                           leapDay.ToString("d"),
           //                           nextYear.ToString("d"));
           //     }
           // }

           // //------------------------------------------------------------------------------ ToLocalTime Method --------------------------------------------------------------------------------------------
           // Console.WriteLine();
           // DateTime localDateTime, univDateTime;

           // Console.WriteLine("Enter a date and time. Format(MM/DD/YYYY 00:00:00 AM/PM)");
           // string strDateTime = Console.ReadLine();

           // try
           // {
           //     localDateTime = DateTime.Parse(strDateTime);
           //     univDateTime = localDateTime.ToUniversalTime();

           //     Console.WriteLine("{0} local time is {1} universal time.",
           //                         localDateTime,
           //                             univDateTime);
           // }
           // catch (FormatException)
           // {
           //     Console.WriteLine("Invalid format.");
           //     return;
           // }

           // Console.WriteLine();
           // Console.WriteLine("Enter a date and time in universal time.");
           // strDateTime = Console.ReadLine();

           // try
           // {
           //     univDateTime = DateTime.Parse(strDateTime);
           //     localDateTime = univDateTime.ToLocalTime();

           //     Console.WriteLine("{0} universal time is {1} local time.",
           //                              univDateTime,
           //                              localDateTime);
           // }
           // catch (FormatException)
           // {
           //     Console.WriteLine("Invalid format.");
           //     return;
           // }



        }


    }

}
