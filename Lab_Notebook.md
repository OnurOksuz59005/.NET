# .NET Programming Fundamentals - Lab Notebook

## 1. Overview and Tools

### .NET Version

```
dotnet --version
```

I'm using .NET SDK version 9.0.202. The .NET CLI (Command Line Interface) is a powerful tool that helps in software development by providing commands for creating, building, testing, and running .NET applications. It simplifies the development process by offering a consistent interface across different platforms.

The .NET CLI aids development by allowing developers to:
- Create new projects using templates
- Manage dependencies
- Build and run applications
- Package applications for distribution

### Development Tool

I installed Visual Studio Code as my development environment. Visual Studio Code is a lightweight but powerful source code editor that runs on your desktop. It comes with built-in support for JavaScript, TypeScript and Node.js and has a rich ecosystem of extensions for other languages including C#.

Feature I like: The integrated terminal allows me to run commands without leaving the editor, making the development workflow more efficient. The IntelliSense feature provides smart completions based on variable types, function definitions, and imported modules.

## 2. Console Application

### HelloWorldApp Modification

I modified the HelloWorldApp to ask for the user's name and include a fun fact in the greeting message:

```csharp
using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! Did you know that octopuses have three hearts and their blood is blue?");
        }
    }
}
```

### Observed Input and Output

When running the application:

**Input:**
```
Enter your name: Onur
```

**Output:**
```
Hello, Onur! Did you know that octopuses have three hearts and their blood is blue?
```

## 3. Data Types and Operators

### DataTypesDemo Modifications

I updated the DataTypesDemo program to include an additional boolean variable, a new arithmetic operation, and a string concatenation with a number:

```csharp
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
```

### Code Summary

The DataTypesDemo program demonstrates various data types and operations in C#:

1. **Integer (int)**: Whole numbers used for arithmetic operations (addition, multiplication, division, remainder).
2. **Boolean (bool)**: True/false values used for logical operations and comparisons.
3. **Double**: Numbers with decimal points for more precise calculations.
4. **String**: Text data that can be concatenated and manipulated.

Using the correct data types is important because:
- It ensures memory efficiency (different types use different amounts of memory)
- It prevents data loss or unexpected behavior (e.g., integer division vs. floating-point division)
- It enables appropriate operations for the data (e.g., string concatenation vs. numeric addition)
- It helps catch errors at compile-time rather than runtime

## 4. Control Flow

### ControlFlowDemo Execution

I ran the ControlFlowDemo program with various inputs and observed the following behaviors:

#### If/Else Statements

The if/else statements handle different number inputs as follows:
- Positive numbers: Displays "The number is positive."
- Negative numbers: Displays "The number is negative."
- Zero: Displays "The number is zero."

This demonstrates how programs can make decisions based on conditions and execute different code paths accordingly.

#### For Loop

The for loop counts from 1 to the user's input number. For example, if the user enters 5, it outputs: `1 2 3 4 5`. This demonstrates how loops can repeat actions a specific number of times.

#### Switch Statement

The switch statement handles different option selections (1, 2, or 3) and displays corresponding messages. It also includes a default case for invalid inputs, showing how programs can handle multiple discrete choices efficiently.

#### While Loop

The while loop adds numbers starting from 1 until the sum reaches or exceeds 20. This demonstrates how loops can continue executing until a condition is met, rather than a predetermined number of iterations.

## 5. Object-Oriented Programming

### OOP Demo Summary

The OOP demo includes both the provided Person class and my custom Car class. After running the program, I observed how objects are created from classes and how their methods are called to display information.

#### Classes and Methods

A class is a blueprint for creating objects. It defines:
- Properties (data): Attributes that describe the object (e.g., Name, Age for Person; Model, Year, Color for Car)
- Methods (actions): Functions that operate on the object's data (e.g., DisplayInfo, DisplayCarInfo)
- Constructors: Special methods that initialize objects when they're created

Methods function by encapsulating behavior that can be reused across multiple objects of the same class. They can access and modify the object's properties, making them powerful tools for organizing code.

#### Encapsulation

Using multiple classes helps organize code by:
- Grouping related functionality together
- Hiding implementation details (encapsulation)
- Making code more maintainable and reusable
- Modeling real-world relationships between entities

For example, in our demo, the Person and Car classes encapsulate their respective data and behaviors, making the code more modular and easier to understand.

## 6. Integrated Final Project

I developed a Student Management System that combines all the concepts learned in this lab:

### Key Features

1. **User Input Handling**: The program collects the student's name and age, validating input where necessary.

2. **Data Type Manipulations**: Various data types are used including strings for names, integers for ages, arrays for courses, and doubles for grades.

3. **Control Flow Structures**: The program uses if/else statements to validate input, a while loop for the menu system, and a switch statement to handle different menu options.

4. **Object-Oriented Programming**: The Student class encapsulates data (name, age, courses, grade average) and behavior (adding courses, calculating grade average, displaying information).

### Summary

This .NET programming lab has provided a comprehensive introduction to fundamental programming concepts. Each section built upon the previous ones, culminating in an integrated application that demonstrates practical programming skills.

The concepts learned in this lab are essential building blocks for more complex software development. By understanding these fundamentals, I'm now better equipped to tackle more advanced programming challenges using the .NET framework.
