using System;

namespace Training__18_Addition_of_two_integer_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a , b, sum;

            Console.WriteLine("Enter the frst no:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second no:");
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;
            Console.WriteLine("sum of " + a + " and " + b + "is:"+sum);
        }
    }
}
