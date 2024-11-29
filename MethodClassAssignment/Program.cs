using System;

namespace MethodExample
{
    // Define the class MathOperations
    public class MathOperations
    {
        // Method that takes two integers as parameters
        public void PerformMath(int number1, int number2)
        {
            // Perform a math operation on the first number (e.g., multiply by 2)
            int result = number1 * 2;

            // Display the result of the math operation and also display the second number
            Console.WriteLine($"The result of {number1} * 2 is: {result}");
            Console.WriteLine($"The second number passed is: {number2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the PerformMath method using positional arguments
            // Passing in the values 5 and 10 as the first and second parameters, respectively
            mathOps.PerformMath(5, 10);

            // Call the PerformMath method using named arguments
            // Specify the parameters by name: first number as 8 and second number as 15
            mathOps.PerformMath(number1: 8, number2: 15);

            // Pause the program so that the user can see the output before closing
            Console.ReadLine();
        }
    }
}
