using System;
using static System.Console;

namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;

            //Bitwise operator examples
            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"a & b = {a & b}");
            WriteLine($"a | b = {a | b}");
            WriteLine($"a ^ b = {a ^ b}\n");

            //Binary Shift operator
            WriteLine($"a << 3 = {a << 3}");

            WriteLine($"a * 8 = {a * 8}");

            WriteLine($"b >> 1 = {b >> 1}");

            //Misc Operators
            int age = 47;
            char firstDigit = age.ToString()[1];
            WriteLine($"firstDigit = {firstDigit}");
        }
    }
}
