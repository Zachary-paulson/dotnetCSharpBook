using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            //example of implicit casting
            int a  = 10;
            double b = a;
            WriteLine($"a = {a} \nb = {b}");

            //Example of explicit casting
            double c = 9.8;
            int d = (int)c;
            WriteLine($"c = {c} \nd = {d}");

            //Example of losing data when explicitly casting
            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            //Another example of losing data
            // e = long.MaxValue;
            e = 5_000_000_000;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            //Converting using System.Convert
            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            //Understanding rounding
            double[] doubles = new[]
                { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51};

            WriteLine();    

            foreach(double n in doubles)
            {
                WriteLine($"ToInt({n}) is {ToInt32(n)}");
            }

            foreach(double n in doubles)
            {
                WriteLine(format:
                    "Math.Round({0}, 0, MidpointRounding.AwayFromZero is {1})",
                    arg0: n,
                    arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero)

                );        
            }

            WriteLine();

            //ToString
            int number = 12;
            WriteLine(number.ToString());

            bool boolean = true;
            WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            WriteLine(now.ToString());

            object me = new object();
            WriteLine(me.ToString());

            WriteLine();

            //allocate array of 128 bytes
            byte[] binaryObject = new byte[128];

            //populate array with random bytes
            (new Random()).NextBytes(binaryObject);

            WriteLine("Binary object as bytes:");
            for(int i = 0; i < binaryObject.Length; i++)
            {
                Write($"{binaryObject[i]:X} ");
            }
            WriteLine();
            //Convert to Base64 string and output as text
            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"Binary Object as Base64: {encoded}");

            //Parsing
            WriteLine();

            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("6 March 1988");

            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}");
            WriteLine($"My birthday is {birthday:D}");

            // int count = int.Parse("abc");

            Write($"for testing: {int.Parse("abc")}");

            //TryParse
            Write("How many eggs are there?");
            int count;
            string input = ReadLine();
            if(int.TryParse(input, out count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not parse the input");
            }
        }
    }
}
