using System;

namespace Training_19_swap_two_numbers_with_and_without_using_third_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20,add;

            //swapping 

            a= a+b;

            a = a - b;
            b = a - b;

            Console.WriteLine("Values after swapping :" +"a=" + a + "and \n  b= " + b);
        }
    }
}
