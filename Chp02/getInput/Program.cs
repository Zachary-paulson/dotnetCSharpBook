﻿using System;
using static System.Console;

namespace getInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Press any key combination: ");

            ConsoleKeyInfo key = ReadKey();

            WriteLine("\nKey: {0}, Char: {1}, Modifiers: {2}", arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);



        }
    }
}