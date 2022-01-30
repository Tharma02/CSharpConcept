using System;

namespace Training_17_Bitwise_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 5, result;

            result = a & b;

            Console.WriteLine("a&b:{0}", result);

            result = a | b;
            Console.WriteLine("a|b:{0}", result);

            result = a ^ b;
            Console.WriteLine("a^b:{0}", result);

            Console.WriteLine("a^b:{0}", (a ^ b).GetType());
        }
    }
}
