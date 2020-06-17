﻿using System;
using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Examples of Unary operators
            int a = 3;
            int b = a++;

            WriteLine($"a is {a}, b is {b}");

            int c = 3;
            int d = ++c;

            WriteLine($"c is {c}, d is {d}");

            //Examples of Binary operators
            int e = 11;
            int f = 3;

            WriteLine($"e is {e}, f is {f}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");

            double g = 11.0;
            WriteLine($"g is {g:N1}, f is {f}");
            WriteLine($"g / f = {g/f:N1}");

            //Assignment operators
            int p = 6;
            WriteLine($"p = {p}");
            p += 3;
            WriteLine($"p += 3, p = {p}");

            

        }
    }
}
