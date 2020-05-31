using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "Amir";

            Console.WriteLine($"{name} us {height} metres tall.");

            // int length1 = name.Length;
            int length2 = ((string)name).Length;

            Console.WriteLine($"{name} has {length2} characters");

            dynamic anotherName = "Ahmed";

            int length = anotherName.Length;

            Console.WriteLine($"{anotherName} has {length} characters");


        }


    }
}
