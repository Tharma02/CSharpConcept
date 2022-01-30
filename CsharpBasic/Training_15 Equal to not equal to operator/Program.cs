using System;

namespace Training_15_Equal_to_not_equal_to_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 5;

            Console.WriteLine("Return type of == operator:{0}",(a==b).GetType());
            Console.WriteLine("Return type of != opertor:{0}", (a != b).GetType());

            Console.WriteLine("a==b:{0}", a == b);
            Console.WriteLine("a!=b:{0}", a != b);

            if (a==b)
            {
                Console.WriteLine("your number is equal");
            }
            else
            {
                Console.WriteLine("your number is not equal");
            }
        }
    }
}
