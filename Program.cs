using System;

namespace SimpleConsoleApp
{
    // Class Definition
    class MathOperation
    {
        // Method that performs a math operation and displays a value
        public void PerformOperation(int number1, int number2)
        {
            // Perform a simple addition with the first integer
            int result = number1 + 10;
            // Display the second integer
            Console.WriteLine("Displayed Number: " + number2);
            // Optionally, showing the result of the operation
            Console.WriteLine("Result of number1 + 10: " + result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class
            MathOperation operation = new MathOperation();

            // Call the PerformOperation method with positional parameters
            operation.PerformOperation(5, 20);

            // Call the PerformOperation method with named parameters
            operation.PerformOperation(number1: 15, number2: 30);
        }
    }
}
