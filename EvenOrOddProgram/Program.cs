using System;

namespace EvenOrOddProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            Console.WriteLine("================================");
            Console.WriteLine("   Even or Odd Number Checker   ");
            Console.WriteLine("================================");
            Console.WriteLine($"Date and Time: {DateTime.Now}");
            Console.WriteLine();

            while (repeat)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Result: The number is EVEN.");
                    }
                    else
                    {
                        Console.WriteLine("Result: The number is ODD.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
                }

                Console.WriteLine();
                Console.Write("Do you want to try another number? (Y/N): ");
                string option = Console.ReadLine().ToUpper();

                if (option != "Y")
                {
                    repeat = false;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the program!");
            Console.ReadKey();
        }
    }
}
