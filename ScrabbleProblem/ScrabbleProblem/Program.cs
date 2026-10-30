using System;
using System.ComponentModel.Design;

namespace ScrabbleProblem

{
    class Null//Scrabble Problem
    {
        static int Points(string word)
        {
            int start = 0;
            {
                for (int index = 0; index < word.Length; index++)//Checking each letter in each index and adding point values
                    if (word[index] == 'a' || word[index] == 'e' || word[index] == 'i' || word[index] == 'o' || word[index] == 'u' || word[index] == 'n'  ||word[index] == 'r' || word[index] == 't' || word[index] == 'l' || word[index] == 's' )
                    {
                        start = start + 1;

                    }
                    else if (word[index] == 'd' || word[index] == 'g')
                    {
                        start = start + 2;
                    }
                    else if (word[index] == 'b' || word[index] == 'm' || word[index] == 'c' || word[index] == 'p')
                    {
                        start = start + 3;
                    }
                    else if (word[index] == 'f' || word[index] == 'h' || word[index] == 'v' || word[index] == 'w' || word[index] == 'y')
                    {
                        start = start + 4;
                    }
                    else if (word[index] == 'k')
                    {
                        start = start + 5;
                    }
                    else if (word[index] == 'j' || word[index] == 'x')
                    {
                        start = start + 8;
                    }
                    else
                    {
                        start = start + 10;
                    }
            }
            return start;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine("Your score would be " + Points(word));
            Console.ReadLine();
        }

    }
}
