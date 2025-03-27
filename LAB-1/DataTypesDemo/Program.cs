using System;

namespace DataTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operators
            int a = 10;
            int b = 5;
            Console.WriteLine("Addition (a + b): " + (a + b));
            Console.WriteLine("Multiplication (a * b): " + (a * b));

            // Comparison Operators
            bool isEqual = (a == b);
            Console.WriteLine("Are a and b equal? " + isEqual);

            // Logical Operators
            bool condition = (a > b) && (b > 0);
            Console.WriteLine("Is a greater than b and b greater than 0? " + condition);

            // Data types example: double and string
            double pi = 3.14159;
            string message = "The value of pi is approximately ";
            Console.WriteLine(message + pi);

            // Additional boolean variable
            bool isPositive = a > 0;
            Console.WriteLine("Is 'a' a positive number? " + isPositive);

            // New arithmetic operation with another integer
            int c = 7;
            int division = a / c;
            Console.WriteLine("Division (a / c): " + division);
            Console.WriteLine("Remainder (a % c): " + (a % c));

            // String concatenation with a number
            int year = 2025;
            string programmingMessage = "I'm learning C# programming in ";
            Console.WriteLine(programmingMessage + year + "!");

        }
    }
}
