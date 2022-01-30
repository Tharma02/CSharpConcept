using System;

namespace Training_05_Demonstrate_the_example_of_new_keyword
{
    class sample1
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Sample1.method() called");
        }
    }
        class sample2
        {
            public void Main(string[] args)
            {
                Console.WriteLine("Sample2.method() called");
            }
        }
            class NewDemo
            {
                static void Main()
                {
                    Sample1 S1 = new sample1();
                    Sample2 S2 = new sample2();

                    S1.method();
                    S2.method();
                }
            }
        
    
}
