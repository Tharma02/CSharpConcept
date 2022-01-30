using System;

namespace ELECTRIC_BILL
{
    class Program
    {
        static void Main(string[] args)
        {
            int unit, Totpay,i,j;

            Console.WriteLine("No of units :");

            unit = Convert.ToInt32(Console.ReadLine());

            Totpay = unit ;

            if (unit <= 100)

            {
                Console.WriteLine("you will pay:{0}", Totpay=7);
            }
            else if (unit <= 200)
                    {
                Console.WriteLine("you wil pay:{0}", Totpay =11);
            }
            else if (unit<=300)
            {
                Console.WriteLine("you will pay:{0}", Totpay = 15);
            }
            else if (unit >=300)
            {
                Console.WriteLine("you will pay:{0}", Totpay =300+unit/7+7+4);
            }
        }
    }
}
