using System;

namespace double_vs_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using doubles:");

            double a = 0.1;
            double b = 0.2;

            if(a + b == 0.3)
                Console.WriteLine($"{a} + {b} equals 0.3");
            else
                Console.WriteLine($"{a} + {b} does not equal 0.3");


            Console.WriteLine("Using Decimals:");

            decimal c = 0.1M;
            decimal d = 0.2M;

            if(c + d == 0.3M)
                Console.WriteLine($"{c} + {d} equals 0.3");
            else
                Console.WriteLine($"{c} + {d} does not equal 0.3");    
        }
    }
}
