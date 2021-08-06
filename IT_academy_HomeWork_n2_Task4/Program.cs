using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Start();
            calculator.StartChange();

            calculator.ExitCalculator();

            Console.ReadLine();
        }
    }

    class Calculator
    {
        public void Start()
        {
            Instruction();
        }
        void Instruction()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hi. It's a calculator. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Some rules for using calculator: ");
            Console.WriteLine("\t\t\t'+' - addition of numbers;");
            Console.WriteLine("\t\t\t'-' - subtraction of numbers;");
            Console.WriteLine("\t\t\t'*' - multiplication of numbers;");
            Console.WriteLine("\t\t\t'/' - division of numbers;");
            Console.WriteLine("\t\t\t'^' - raising the first number to the power of the second number;");
            Console.WriteLine("\t\t\t'F' - factorial of a number;");
            Console.WriteLine("\t\t\t'q' - exit the program.");

            Console.ForegroundColor = ConsoleColor.White;
        }

        public string EnterNumber()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Please enter a number!");
            var N = Console.ReadLine();
            return N;
        }

        public char EnterOperation()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Please enter an operation symbole !");
            var Operation = Console.ReadLine();
            return Convert.ToChar(Operation);
        }

        void NumberExeption()
        {
            Console.WriteLine("You entered incorrect symbol! Please try again.");
        }

        public void ActionsOnNumbers()
        {
            char OperationNumber;


            try
            {

                var FirstNumber = Convert.ToDouble(EnterNumber());
                var SecondNumber = Convert.ToDouble(EnterNumber());


                OperationNumber = EnterOperation();

                if (OperationNumber == '+' || OperationNumber == '-' || OperationNumber == '*' || OperationNumber == '/' || OperationNumber == '^' || OperationNumber == 'q')
                {

                }
                else
                {
                    NumberExeption();
                    ActionsOnNumbers();
                }

                switch (OperationNumber)
                {

                    case '+': Console.WriteLine($"{FirstNumber} {OperationNumber} {SecondNumber} = {FirstNumber + SecondNumber}"); break;
                    case '-': Console.WriteLine($"{FirstNumber} {OperationNumber} {SecondNumber} = {FirstNumber - SecondNumber}"); break;
                    case '*': Console.WriteLine($"{FirstNumber} {OperationNumber} {SecondNumber} = {FirstNumber * SecondNumber}"); break;
                    case '/': Console.WriteLine($"{FirstNumber} {OperationNumber} {SecondNumber} = {FirstNumber / SecondNumber}"); break;
                    case '^': Console.WriteLine($"{Math.Pow(FirstNumber, SecondNumber)}"); break;
                    case 'q': Console.WriteLine($"You entered 'q'."); break;
                    default: Console.WriteLine("Incorrect data!"); break;
                }
                if (OperationNumber == 'q')
                {
                    GoodBye();
                }
                else
                {
                    ActionsOnNumbers();
                }

            }
            catch
            {
                Console.WriteLine("You have entered invalid characters. Please enter two numbers!!!");
            }

        }

        public void CalculateFactorial()
        {
            try
            {
                var ForFactNumber = Convert.ToDouble(EnterNumber());

                double x = 1;

                for (int i = 1; i <= ForFactNumber; i++)
                {
                    x = x * i;

                }

                Console.WriteLine($"Factorial of number {ForFactNumber} : {x}.");
            }
            catch
            {
                NumberExeption();
            }
        }

        public void StartChange()
        {
            Console.WriteLine("If you want to calculate FACTORIAL, you should write 'F'");
            Console.WriteLine("If you want to calculate SUM OF NUMBERS, you should write 'S'");
            Console.WriteLine("If you want to calculate OTHER OPERATIONS, you should write any symbol");
            Console.WriteLine("If you want to EXIT, you should write ' EXIT !!! '");

            var OperationWrite = Console.ReadLine();
            if (OperationWrite == "EXIT")
            {
                ExitCalculator();
            }
            else
            {
                if (OperationWrite == "F")
                {
                    CalculateFactorial();
                }
                else if (OperationWrite == "S")
                {
                    RowSum();
                }

                else
                {
                    ActionsOnNumbers();
                }
                StartChange();
            }
        }

        public void RowSum()
        {
            Console.WriteLine("Enter a number - it's amount of numbers what you want to enter!");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter {n} numbers!");
                string s = Console.ReadLine();
                string[] ss = s.Split(' ');

                int k = 0;

                int[] num = new int[n];
                for (int i = 0; i < n; i++)
                {
                    try
                    {
                        int number = Convert.ToInt32(ss[i]);

                        k += number;
                    }
                    catch
                    {
                        Console.WriteLine("Digits are entered into a string separated by a space.");
                    }
                }
                Console.WriteLine($"Sum of numbers : {k}.");
            }

            catch
            {
                NumberExeption();
            }
        }

        public void GoodBye()
        {
            Console.WriteLine("Good Bye!!!!!");
        }

        public void ExitCalculator()
        {
            Console.WriteLine("EXIT from Calculator !!!");
        }

    }

}