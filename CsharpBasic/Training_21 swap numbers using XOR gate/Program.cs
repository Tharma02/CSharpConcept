using System;

namespace Training_21_swap_numbers_using_XOR_gate
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Enter the first the number:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before swapping.........");
            Console.WriteLine("a={0} \t b={1}", a, b);


            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("After swapping..........");
            Console.WriteLine("a={0} \t b={1}", a, b);

        }
    }
}
