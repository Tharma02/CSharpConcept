using System;

namespace Training_3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good\nmorning");

            Console.WriteLine("Good\xAmorning");

            Console.WriteLine("Good\x0Amorning");

            Console.ReadLine();
        }
    }
}
