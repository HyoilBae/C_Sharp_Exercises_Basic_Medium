using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //this is the start of my coding journey//
            Console.WriteLine("Hello World!");
            Console.WriteLine("\n");

            //this is the code that asking a question and show the answers with your input//
            Console.WriteLine("How old are you?");
            String input = Console.ReadLine();
            Console.WriteLine($"Your age is {input} years old");
            Console.WriteLine("\n");

            //this is the code converting string to int//
            Console.WriteLine("Enter your Favorite number!");
            int faveNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your favorite number is {faveNumber}");
            Console.WriteLine("\n");

            //try to covert different variables to the other variables//
            Console.WriteLine("he is a liar");
            //Bool??// _ = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");


            //Playing with Number with Built-in Methods//
            int numberOne = 12932;
            int numberTwo = -2828472;
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));
            Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));
            Console.WriteLine("\n");

            //String Interpolation//
            string beginning = "Once upon a time,";
            string middle = "The kid climbed a tree.";
            string end = "Everyone lived happily ever after.";
            string story = $"{beginning} {middle} {end}";
            Console.WriteLine(story);
            Console.WriteLine("\n");

            //Get info about strings//
            string password = "a92301j2add";
            int passwordLength = password.Length;
            int passwordCheck = password.IndexOf("!");
            Console.WriteLine($"The user password is {password}, its length is {passwordLength}, and it receives a {passwordCheck} check.");
            Console.WriteLine("\n");

            //Get parts of Strings//
            string name = "Farhad Hesam Abbasi";
            int charPosition = name.IndexOf("F");
            char firstLetter = name[charPosition];
            charPosition = name.IndexOf("Abbasi");
            string lastName = name.Substring(charPosition);
            Console.WriteLine($"{firstLetter}. {lastName}");
            Console.WriteLine("\n");

            //Manipulate Strings//
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";
            int charPosition1 = script.IndexOf("Close");
            int length = "Close on".Length;
            string cameraDirections = script.Substring(charPosition1, length);
            charPosition1 = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(charPosition1);
            cameraDirections = cameraDirections.ToUpper();
            sceneDescription = sceneDescription.ToLower();
            Console.WriteLine($"{cameraDirections} {sceneDescription}");
            Console.WriteLine("\n");


            //Conin Maker//
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins");
            String howMuch = Console.ReadLine();
            double howMuchDouble = Convert.ToDouble(howMuch);
            Console.WriteLine($"{howMuchDouble} cents is equal to...");
            int goldValue = 10;
            int silverValue = 5;
            double goldCoins = Math.Floor(howMuchDouble / goldValue);
            //Console.WriteLine($"{goldCoins}");//
            double leftOver = howMuchDouble % goldValue;
            //Console.WriteLine($"{leftOver}");//
            double silverCoins = Math.Floor(leftOver / silverValue);
            //Console.WriteLine($"{silverCoins}");//
            leftOver = leftOver % silverValue;
            //Console.WriteLine($"{leftOver}");//
            Console.WriteLine($"Gold coins {goldCoins}");
            Console.WriteLine($"Silver coins {silverCoins}");
            Console.WriteLine($"Bronze coins {leftOver}");
            Console.WriteLine("\n");





        }
    }
}
