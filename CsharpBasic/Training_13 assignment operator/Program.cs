using System;

namespace Training_13_assignment_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 3;

            Console.WriteLine("a:{0}", a += b);
            Console.WriteLine("sub:{0}", a -= b);
            Console.WriteLine("multiple:{0}", a *= b);
            Console.WriteLine("remainder :{0}", a %= b);
        }
    }
}
