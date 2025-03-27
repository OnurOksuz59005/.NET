using System;

// Define a Student class to manage and display data
public class Student
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    private string[] _courses; // Private backing field for Courses
    public string[] Courses { get { return _courses; } } // Read-only property
    public double GradeAverage { get; set; }

    // Constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        _courses = new string[0]; // Initialize the backing field
        GradeAverage = 0.0;
    }

    // Method to add a course to the student's list
    public void AddCourse(string course)
    {
        Array.Resize(ref _courses, _courses.Length + 1); // Use the backing field with ref
        _courses[_courses.Length - 1] = course;
    }

    // Method to calculate grade average
    public void CalculateGradeAverage(double[] grades)
    {
        if (grades.Length == 0)
        {
            GradeAverage = 0;
            return;
        }

        double sum = 0;
        foreach (double grade in grades)
        {
            sum += grade;
        }

        GradeAverage = sum / grades.Length;
    }

    // Method to display student information
    public void DisplayInfo()
    {
        Console.WriteLine($"\nStudent Information:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        
        Console.WriteLine("Courses:");
        if (_courses.Length == 0)
        {
            Console.WriteLine("  No courses registered");
        }
        else
        {
            foreach (string course in _courses)
            {
                Console.WriteLine($"  - {course}");
            }
        }
        
        Console.WriteLine($"Grade Average: {GradeAverage:F2}");
    }
}

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Student Management System =====\n");

            // User input handling
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine(); // Use nullable string

            Console.Write("Enter your age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.Write("Invalid age. Please enter a positive number: ");
            }

            // Create a student object
            Student student = new Student(name ?? "Unknown", age); // Provide default if null

            // Control flow with a menu system
            bool exitProgram = false;
            while (!exitProgram)
            {
                // Display menu options
                Console.WriteLine("\n===== Menu =====");
                Console.WriteLine("1. Add a course");
                Console.WriteLine("2. Enter grades");
                Console.WriteLine("3. Display student information");
                Console.WriteLine("4. Exit");
                Console.Write("\nSelect an option (1-4): ");

                // Get user choice
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.Write("Invalid option. Please enter a number between 1 and 4: ");
                }

                // Process user choice using switch statement
                switch (choice)
                {
                    case 1: // Add a course
                        Console.Write("Enter course name: ");
                        string? course = Console.ReadLine(); // Use nullable string
                        student.AddCourse(course ?? "Unnamed Course"); // Provide default if null
                        Console.WriteLine($"Course '{course}' added successfully!");
                        break;

                    case 2: // Enter grades
                        if (student.Courses.Length == 0)
                        {
                            Console.WriteLine("Please add courses first!");
                            break;
                        }

                        double[] grades = new double[student.Courses.Length];
                        
                        for (int i = 0; i < student.Courses.Length; i++)
                        {
                            Console.Write($"Enter grade for {student.Courses[i]} (0-100): ");
                            double grade;
                            while (!double.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
                            {
                                Console.Write("Invalid grade. Please enter a number between 0 and 100: ");
                            }
                            grades[i] = grade;
                        }

                        student.CalculateGradeAverage(grades);
                        Console.WriteLine("Grades entered successfully!");
                        break;

                    case 3: // Display information
                        student.DisplayInfo();
                        break;

                    case 4: // Exit
                        exitProgram = true;
                        Console.WriteLine("\nThank you for using the Student Management System!");
                        break;
                }
            }
        }
    }
}
