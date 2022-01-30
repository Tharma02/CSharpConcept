using System;

namespace Training_07_conversion_from_double_to_int_data_tpye
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1234.56;
            int b =0;

            b = (int)a;

            Console.WriteLine("value of a {0}", a);
            Console.WriteLine("value of b {0}", b);
        }
    }
}
