using System;

namespace Electric_bill_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int unit,initialvalue;
            double billpay;

            Console.WriteLine("Enter no of units:");
            unit = Convert.ToInt32(Console.ReadLine());

            initialvalue = 300;
            billpay = unit;

            if(unit<=100)
            {
               Console.WriteLine("You will pay:{0}", billpay =initialvalue+ unit * 0.07);
            }
            else if(unit<=200)
            {
                Console.WriteLine("You will pay:{0}", billpay = initialvalue+0.07+ (unit - 100) * 0.11);
            }
            else 
            {
                Console.WriteLine("You will pay:{0}", billpay =initialvalue + 0.07 + 0.11 + (unit - 200) * 0.15);
            }
            
        }
    }
}
