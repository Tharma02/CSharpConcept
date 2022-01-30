using System;

namespace Training__16_Relational_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 4;

            Console.WriteLine("a==b:{0}", a == b);
            Console.WriteLine("a!=b:{0}",a!=b);
            Console.WriteLine("a>b:{0}", a > b);
            Console.WriteLine("a>=b:{0}", a > b);


            Console.WriteLine("type of a==b:{0}", (a==b).GetType());


            Console.WriteLine("type of a>b:{0}", (a > b).GetType());
        }
        
    }
}
