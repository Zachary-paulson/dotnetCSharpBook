using System;
using static System.Console;
using System.IO;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                WriteLine("There are no arguments");
            else    
                WriteLine("There is at least one Argument");

            object o = 3;
            int j = 4;

            if(o is int i){
                WriteLine($"{i} * {j} = {i * j}");
            }
            else{
                WriteLine("o is not an int so it cannot multiply!");
            }

            WriteLine($"o is {o.GetType().Name}");

            A_label:
                var number = (new Random()).Next(1,7);

                WriteLine($"\n\nMy random number is {number}");

            switch(number)
            {
                case 1:
                    WriteLine("one");
                    break;
                case 2:
                    WriteLine("Two");
                    goto case 1;
                    break;
                case 3:
                case 4:
                    WriteLine("Three or four");
                    goto case 1;
                    break;
                case 5:
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                    break;
                default:
                    WriteLine("Default");
                    break;   
            }//end of switch

            string path = "/home/zach/Repo/dotnetCSharpBook/Chp03";

            Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            string message = string.Empty;

            // switch (s)
            // {
            //     case FileStream writeableFile when s.CanWrite:
            //         message = "The stream is a file that I can write to.";
            //         break;
            //     case FileStream readOnlyFile:
            //         message = "the stream is a read-only file";
            //         break;
            //     case MemoryStream memoryStream:
            //         message = "The stream is a memory address.";
            //         break;
            //     case null:
            //         message = "The stream is null";
            //     break;    
            // }//End of Switch

            WriteLine(message);

            message = s switch
            {
                FileStream writeableFile when s.CanWrite 
                    => "The stream is a file that I can write to.",
                FileStream readOnlyFile 
                    => "The stream is a read-only file",
                MemoryStream ms
                    => "The stream is a memory address",
                null
                    => "The stream is null.",
                _
                    => "The stream is some other type."    
            };

            WriteLine(message);

        }
    }
}
