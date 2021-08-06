using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the number.");
            Console.ForegroundColor = ConsoleColor.Green;

            double Number = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            int SumNumbers = 0;

            for (int i = 1; i <= Number; i++)
            {
                if (i % 2 != 0)
                {
                    SumNumbers += i;
                }

            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Sum of odd integers ranging from 1 to {Number}  -  {SumNumbers}.");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.ReadLine();
        }
    }
}
