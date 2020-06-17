using System;
using static System.Console;

namespace ConditionalLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            WriteLine($"a & DoStuff() = {a & DoStuff()}");
            WriteLine($"b & DoStuff() = {b & DoStuff()}");
            WriteLine();
            WriteLine($"a && DoStuff() = {a && DoStuff()}");
            WriteLine($"b && DoStuff() = {b && DoStuff()}");

            
        }

        private static bool DoStuff(){
            WriteLine("I'm doing a thing!");
            return true;
        }
    }
}
