using System;

namespace SizeofTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");

            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");

            Console.WriteLine($"Decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
        }
    }
}
