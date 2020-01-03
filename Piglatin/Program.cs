using System;

namespace Piglatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PIG LATIN \n This converts normal words into pig-latin ... enter a word below!");
            string input = Console.ReadLine();
            input = input.ToLower();

            var firstLetter = input[0];
            string suffix = "ay";
            string ending = firstLetter + suffix;
            string result = input.Remove(0,1) + ending;
            Console.WriteLine(result);

        }
    }
}
