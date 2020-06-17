using System;
using static System.Console;
namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
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
