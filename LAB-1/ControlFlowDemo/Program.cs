using System;

namespace ControlFlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // If-Else Statement
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            // For Loop Example
            Console.WriteLine("Counting from 1 to " + number + ":");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Switch Statement Example
            Console.WriteLine("Choose an option (1, 2, or 3):");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("You chose option 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose option 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose option 3.");
                    break;
                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }

            // While Loop Example
            int sum = 0;
            int counter = 1;
            while (sum < 20)
            {
                sum += counter;
                counter++;
            }
            Console.WriteLine("The sum reached: " + sum);
        }
    }
}
