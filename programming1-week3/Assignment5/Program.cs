using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PerformCalculation();
        }

        // Method to display the menu
        void DisplayMenu()
        {
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1: Addition (+).");
            Console.WriteLine("2: Subtraction (-).");
            Console.WriteLine("3: Multiplication (*).");
            Console.WriteLine("4: Division (/).");
            Console.WriteLine("5: Exit.");
        }

        // Method to perform the calculation based on user input
        void PerformCalculation()
        {
            while (true)
            {
                DisplayMenu();

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Exiting Calculator. Thank you, Goodbye!");
                    break;
                }

                Console.WriteLine("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                // Perform the selected operation
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Result: {num1} + {num2} = {Add(num1, num2)}");
                        break;

                    case "2":
                        Console.WriteLine($"Result: {num1} - {num2} = {Subtract(num1, num2)}");
                        break;

                    case "3":
                        Console.WriteLine($"Result: {num1} * {num2} = {Multiply(num1, num2)}");
                        break;

                    case "4":
                        double result = Divide(num1, num2);
                        if (!double.IsNaN(result)) // Check if result is valid
                        {
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        // Method for addition
        int Add(int a, int b)
        {
            return a + b;
        }

        // Method for subtraction
        int Subtract(int a, int b)
        {
            return a - b;
        }

        // Method for multiplication
        int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method for division
        double Divide(int a, int b)
        {
            if (b == 0)
            {
                return double.NaN; // Return NaN to indicate division by zero
            }
            return (double)a / b;
        }
    }
}
