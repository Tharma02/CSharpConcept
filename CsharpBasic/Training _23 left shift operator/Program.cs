using System;

namespace Training__23_left_shift_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 128, b = 256, z;

            z = a <<2;
            Console.WriteLine("left shift is a<<2:"+z);

            z = b <<3;
            Console.WriteLine("left shift is b<<3:"+z);
        }
    }
}
