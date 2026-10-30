using System;
using System.ComponentModel.Design;

namespace PrimeNumberProblem


{
    class Null
    {
        static void IsPrime(int number)
        {
            bool isPrime = true;
            for (int divisor = 2; divisor < (number / 2); divisor++)
            {
                if ((number % divisor) == 0)
                    isPrime = false;
                else
                    isPrime = true;
            }
            Console.Write(isPrime);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number is prime = ");
            IsPrime(number);
            Console.ReadLine();

        }

    }
}
