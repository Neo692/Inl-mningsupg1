using System;

namespace inlämningsupg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken är din favoritbok?");
            string bok = Console.ReadLine();
            Console.WriteLine("Din favoritbok är " + bok);
        }
    }
}