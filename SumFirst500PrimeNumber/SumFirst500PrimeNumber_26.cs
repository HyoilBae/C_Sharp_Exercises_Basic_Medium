using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFirst500PrimeNumber
{
    class SumFirst500PrimeNumber_26
    {
        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) 
                return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            int primeNumber = 2;
            int sumPrime = 0;
            int count = 0;

            while(count < 500)
            {
                if (isPrime(primeNumber))
                {
                    Console.WriteLine("The prime number is " + primeNumber);
                    sumPrime = sumPrime + primeNumber;
                    Console.WriteLine("The sum so far : " + sumPrime);
                    count++;
                    Console.WriteLine("The count :" + count);
                }
                primeNumber++;
            }

            Console.WriteLine("Sum of the first 500 prime numbers: " + sumPrime);




            //while (count < 501)
            //{
            //    if (primeNumber % 2 != 0 && 
            //        primeNumber % 3 != 0 && 
            //        primeNumber % 5 != 0 && 
            //        primeNumber % 7 !=0 && 
            //        primeNumber % 11 != 0 &&
            //        primeNumber % 13 != 0 &&
            //        primeNumber % 17 != 0)
            //    {
            //        Console.WriteLine("Count : {0}", count);
            //        Console.WriteLine("PrimeNumber : {0}", primeNumber);
            //        Console.WriteLine("sumPrime : {0} + primeNumber {1}", sumPrime, primeNumber);
            //        sumPrime = sumPrime + primeNumber;
                    
            //    }
            //    count = count + 1;
            //    primeNumber = primeNumber + 1;
            //}
            
            
         
        }
    }
}
