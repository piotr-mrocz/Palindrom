using System;
using System.Linq;

namespace Zadanie2
{
    class Program
    {
        public bool Palindrom(string word)
        {
            
            return false;
        }
        static void Main(string[] args)
        {
            // Sprawdź czy string jest palindromem.

            Console.Write("Wprowadź słowo: ");
            string word = Console.ReadLine();
            string reverseWord = new string(word.ToCharArray().Reverse().ToArray());

            bool palindrom = word.ToLower().Equals(reverseWord.ToLower());
            if (palindrom == true)
            {
                Console.WriteLine($"Wyraz \"{word}\" jest palindromem.");
            }
            else
            {
                Console.WriteLine($"Wyraz \"{word}\" nie jest palindromem.");
            }
        }
    }
}
