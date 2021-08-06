using System;

namespace IT_academy_HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter any numbers! When you enter 0 the programm will stop!");
            Console.WriteLine("When your program stops, you will see the number of entered \nnumbers, their total and  the middle arithmetic mean!");
            Console.ForegroundColor = ConsoleColor.Green;

            double count = 0;
            double SumNumbers = 0;
            double MiddleArithmeticNumber = 0;

            double k = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (k == 0)
            {
                Console.WriteLine("Enter another number!)");
            }
            else
            {
                while (k != 0)
                {
                    count++;
                    SumNumbers += k;
                    k = Convert.ToDouble(Console.ReadLine());
                }
                MiddleArithmeticNumber = SumNumbers / count;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"The number of entered numbers - {count}.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The total of entered numbers - {SumNumbers}.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"The middle arithmetic mean - {MiddleArithmeticNumber}.");
            Console.WriteLine();



            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.ReadLine();
        }
    }
}
