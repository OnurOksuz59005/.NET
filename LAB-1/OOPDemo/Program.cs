using System;

// Define a class named Person
public class Person
{
    // Properties
    public string Name;
    public int Age;

    // Constructor: Initializes a new instance of Person
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method: Displays the person's information
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name + ", Age: " + Age);
    }
}

// Define a custom Car class
public class Car
{
    // Properties
    public string Model;
    public int Year;
    public string Color;

    // Constructor
    public Car(string model, int year, string color)
    {
        Model = model;
        Year = year;
        Color = color;
    }

    // Method to display car details
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Car: {Color} {Model}, Year: {Year}");
    }
}

// Main program to demonstrate OOP
namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two Person objects and display their information
            Person person1 = new Person("Alice", 30);
            person1.DisplayInfo();

            Person person2 = new Person("Bob", 25);
            person2.DisplayInfo();

            Console.WriteLine(); // Add a blank line for readability

            // Create two Car objects and display their information
            Car car1 = new Car("Tesla Model 3", 2023, "Red");
            car1.DisplayCarInfo();

            Car car2 = new Car("Toyota Corolla", 2020, "Blue");
            car2.DisplayCarInfo();
        }
    }
}
