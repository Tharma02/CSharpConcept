using System;

namespace Training__12_arithmetic_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3;

            int sum = a + b;
            int sub = a - b;
            int div = a / b;
            int rem = a % b;

            Console.WriteLine("Addition value of :" + sum);
            Console.WriteLine("Subtract value of :" + sub);
            Console.WriteLine("Divide value of :" + div);
            Console.WriteLine("Remainder value of :" + rem);
        }
    }
}
