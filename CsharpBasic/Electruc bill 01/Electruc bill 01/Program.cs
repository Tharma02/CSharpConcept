using System;

namespace Electruc_bill_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialvalue = 300;
            int subtotal = 0;
            int unit = 100;

            int unitperhundred = unit / 100;
            int remainderunit = unit - (unitperhundred * 100);
            int remainderamount = remainderunit;

            for (int i = 1; i <= unitperhundred; i++)
            {
                int tempvalue;
                switch (i)

                {
                    case 1:
                        tempvalue = 100 * 7;
                        subtotal = subtotal + tempvalue;
                        break;


                    case 2:
                        tempvalue = 100 * 11;
                        subtotal = subtotal + tempvalue;
                        break;
                }
            }
            if (remainderunit > 0)
            {
                Console.WriteLine(remainderamount = remainderunit * 7);
            }
            int total = initialvalue + subtotal + remainderamount;
            Console.WriteLine("The total value of :{0} is {1}", unit, total);

        }
    }
}

