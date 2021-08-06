using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the number of rows.");
            Console.ForegroundColor = ConsoleColor.Green;

            int Nunber = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;


            for (int i = 0; i <= Nunber; i++) // the number of rows
            {
                for (int j = Nunber; j >= i; j--) // the number of " "
                {
                    Console.Write(" "); // enter " "
                }

                for (int s = 1; s <= i * 2 - 1; s++) // the number of symbols
                {
                    Console.Write("^");  // enter "^"
                }

                Console.WriteLine(); // go to new row
            }
        }
    }
}
