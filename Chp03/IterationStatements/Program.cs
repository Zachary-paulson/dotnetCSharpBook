using System;
using static System.Console;
using System.Collections;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x = 0;
            // while(x < 10)
            // {
            //     WriteLine(x);
            //     x++;
            // }

            string password = string.Empty;

            // do
            // {
            //     Write("Enter your password: ");
            //     password = ReadLine();
            // }
            // while (password != "Pa$$w0rd");

            //WriteLine("Correct!");

            string[] names = { "Adam", "Barry", "Charlie"};

            // foreach(string name in names)
            // {
            //     WriteLine($"{name} has {name.Length} characters.");
            // }
            IEnumerator e = names.GetEnumerator();

            while(e.MoveNext())
            {
                string name = (string)e.Current;
                WriteLine($"{name} has {name.Length} Characters.");
            }


        }//end of main
    }
}
