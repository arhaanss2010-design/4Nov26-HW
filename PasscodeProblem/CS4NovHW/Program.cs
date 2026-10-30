using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;

namespace CS4NovHW

{
    class Null//Password Problem
    {
        static void WordOne(string one)
        {

            for (int index = 0; index < one.Length; index++)//loop to identify index of vowels in first word
            {
                string number = "";

                if ((one[index] == 'a' ) || (one[index] == 'e') || (one[index] == 'i') || (one[index] == 'o') || (one[index] == 'u'))
                {
                    number = Convert.ToString(index);
                   
                }
                Console.Write(number);
            }
        
        }
        static void WordTwo(string two)//loop to identify index of vowels in second word
        {

            for (int index = 0; index < two.Length; index++)
            {
                string number = "";

                if (two[index] == 'a' || two[index] == 'e' || two[index] == 'i' || two[index] == 'o' || two[index] == 'u')
                {
                    number = Convert.ToString(index);

                }
                Console.Write(number);
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("First word");
            string one = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Second word");
            string two = Convert.ToString(Console.ReadLine());
            Console.Write("Password is: ");
            WordOne(one);
            WordTwo(two);

            Console.ReadLine();


        }

    }
}