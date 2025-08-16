using System;

namespace MethodClassApp
{
    // A class with a void method that takes two integers.
    // It performs a math operation on the FIRST integer
    // and displays the SECOND integer to the screen.
    public class MathOps
    {
        public void ProcessNumbers(int first, int second)
        {
            // Math on the FIRST integer (example: double it)
            int doubled = first * 2;

            // Display results
            Console.WriteLine($"First number doubled = {doubled}");
            Console.WriteLine($"Second number = {second}");
        }
    }
}
