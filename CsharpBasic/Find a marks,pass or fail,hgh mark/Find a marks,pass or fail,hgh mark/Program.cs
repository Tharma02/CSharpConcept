using System;

namespace Find_a_marks_pass_or_fail_hgh_mark
{
    class Program
    {
        static void Main(string[] args)
        {
            int avgmark, m1, m2, m3;

            Console.WriteLine("Enter your mark:");
            m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your mark:");
            m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your mark:");
            m3 = Convert.ToInt32(Console.ReadLine());

            avgmark = m1 + m2 + m3 / 3;
            Console.WriteLine("Average mark is:" + mark);

            if (avgmark>=40)
            {
                Console.WriteLine("You are pass");
            }
            else
            {
                Console.WriteLine("You are fail");
            }

            if (m1 > m2 && m1 > m3)
            {
                Console.WriteLine("Highest number:" + m1);
            }
            else if (m2 > m1 && m2 > m3)
            {
                Console.WriteLine("Highest number:" + m2);
            }
            else if (m3 > m1 && m3 > m1)
            {
                Console.WriteLine("Highest number:"+m3);
            }

        }
    }
}
