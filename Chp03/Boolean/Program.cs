using System;
using static System.Console;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing Booleans
            bool a = true;
            bool b = false;

            WriteLine($"\nAND | a      | b ");
            WriteLine($"a   | {a & a, -5}  | {a & b, -5} ");
            WriteLine($"b   | {b & a, -5}  | {b & b, -5} ");
            WriteLine();
            WriteLine($"OR | a      | b ");
            WriteLine($"a  | {a | a, -5}  | {a | b, -5} ");
            WriteLine($"b  | {b | a, -5}  | {b | b, -5} ");
            WriteLine();
            WriteLine($"XOR | a      | b ");
            WriteLine($"a   | {a ^ a, -5}  | {a ^ b, -5} ");
            WriteLine($"b   | {b ^ a, -5}  | {b ^ b, -5} ");
            WriteLine("\n**************END**************");
         
        }
    }
}