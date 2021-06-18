using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter a word to search:");
            string word = Console.ReadLine();
            Console.WriteLine($"Word found {str.Split(word).Length-1} times in the string");
        }
    }
}
