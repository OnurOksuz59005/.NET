# .NET Programming: Data Processing, Web Communication, Asynchronous Operations, and GUI Development

Date: April 23, 2025

## Task 1: Using Generic Collection Classes

### Objective
Learn how to store, organize, and access structured data using .NET's built-in generic collections, specifically `List<T>` and `Dictionary<TKey, TValue>`.

### Implementation

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of cities
        List<string> cities = new List<string> { "Warsaw", "Krakow", "Gdansk" };
        cities.Add("Lodz");
        
        Console.WriteLine("List of cities:");
        foreach (var city in cities)
        {
            Console.WriteLine("- " + city);
        }
        
        // Create a list of countries
        List<string> countries = new List<string> { "Poland", "Germany", "France" };
        countries.Add("Spain");
        
        Console.WriteLine("\nList of countries:");
        foreach (var country in countries)
        {
            Console.WriteLine("- " + country);
        }
        
        // Display all cities again
        Console.WriteLine("\nUpdated list of cities:");
        cities.Add("Poznan"); // Add a new city
        foreach (var city in cities)
        {
            Console.WriteLine("- " + city);
        }
        
        // Create a dictionary of city populations
        Dictionary<string, int> population = new Dictionary<string, int>
        {
            { "Warsaw", 1800000 },
            { "Krakow", 770000 }
        };
        
        Console.WriteLine();
        Console.WriteLine("Population of Warsaw: " + population["Warsaw"]);
    }
}
```

### Explanation

- `List<T>` is a collection that stores values in a specific order. You can add elements using the `Add` method and access them using a loop.
- `Dictionary<TKey, TValue>` is used to store key-value pairs. In this example, we map city names (keys) to population numbers (values).
- This task demonstrates how generic collections help manage dynamic sets of data in a type-safe way.
- **Modifications made**: Added a second `List<string>` for countries and displayed the list below the cities. Also added a new city to the list and showed all cities again.

## Task 2: HTTP Protocol and JSON Data Exchange

### Objective
Learn how to connect to an external web service using the HTTP protocol and handle the response in JSON format using .NET's `HttpClient` class and JSON deserialization.

### Implementation

```csharp
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
    
    static async Task Main()
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/2");
        
        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            Post post = JsonSerializer.Deserialize<Post>(json);
            Console.WriteLine("Post Title: " + post.Title);
            Console.WriteLine("Post ID: " + post.Id);
        }
        else
        {
            Console.WriteLine("Error: " + response.StatusCode);
        }
    }
}
```

### Explanation

- The `HttpClient` class allows you to send HTTP requests to remote servers.
- The response you get is in text format (JSON), which we parse into a C# object using `JsonSerializer.Deserialize`.
- The `Post` class defines the structure that matches the JSON data received from the API.
- This task introduces you to client-server communication, which is key for building applications that rely on external data sources.
- **Modifications made**: Changed the URL from `/posts/1` to `/posts/2` to retrieve a different post. Added code to print both the post title and the post ID.

## Task 3: Asynchronous Programming in .NET

### Objective
Understand how to perform long-running tasks like HTTP requests without freezing your application, using the `async` and `await` keywords along with `Task`.

### Implementation

```csharp
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Downloading data...");
        
        string content = await DownloadAsync();
        
        // Only print the first 100 characters of the result
        string truncatedContent = content.Length > 100 ? content.Substring(0, 100) + "..." : content;
        Console.WriteLine("Downloaded content (first 100 chars): " + truncatedContent);
    }
    
    static async Task<string> DownloadAsync()
    {
        HttpClient client = new HttpClient();
        string result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
        return result;
    }
}
```

### Explanation

- Asynchronous programming allows the program to continue running other operations while waiting for a long task (like a network call) to finish.
- The `async` keyword marks a method that uses asynchronous features.
- The `await` keyword tells the program to pause at that point until the task completes, without freezing the whole application.
- This model is crucial when building responsive desktop or web applications.
- **Modifications made**: Instead of showing the full content length, the program now prints only the first 100 characters of the result.

## Task 4: Creating Visual Applications

### Objective
Learn how to build a simple graphical interface using Windows Forms, creating a form with text boxes, buttons, and labels to display personalized messages.

### Implementation

```csharp
// Form1.cs (Designer code not shown for brevity)
using System;
using System.Windows.Forms;

namespace Task4_VisualApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // Set initial properties
            buttonGreet.Text = "Greet";
            labelGreeting.Text = "Greeting will appear here";
        }
        
        private void buttonGreet_Click(object sender, EventArgs e)
        {
            string firstName = textBoxName.Text;
            string surname = textBoxSurname.Text;
            labelGreeting.Text = $"Hello, {firstName} {surname}!";
        }
    }
}
```

### Designer Setup
1. Create a Windows Forms App (.NET) project named Task4_VisualApp.
2. Add the following controls to the form:
   - A TextBox named textBoxName
   - A TextBox named textBoxSurname
   - A Button named buttonGreet
   - A Label named labelGreeting
3. Set these properties in the Designer:
   - buttonGreet.Text = "Greet"
   - labelGreeting.Text = "Greeting will appear here"

### Explanation

- Windows Forms allows you to design graphical user interfaces using a drag-and-drop editor.
- You interact with UI elements in code by accessing their properties.
- Event handlers like `buttonGreet_Click` are triggered when users interact with controls.
- This task introduces event-driven programming and UI feedback.
- **Modifications made**: Added a second TextBox for the user's surname and updated the greeting label to display the full name: "Hello, [first name] [surname]!".

## Task 5: Visual Containers in UI Development

### Objective
Organize controls into visual groups to make the user interface more readable and structured using a GroupBox to contain related inputs.

### Implementation

```csharp
// Form1.cs (Designer code not shown for brevity)
using System;
using System.Windows.Forms;

namespace Task5_UIContainers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // Set initial properties
            groupBoxUser.Text = "User Input";
            buttonDisplay.Text = "Show";
            labelOutput.Text = "Output will appear here";
            
            // Second GroupBox
            groupBoxCounter.Text = "Character Counter";
            buttonCount.Text = "Count";
        }
        
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            labelOutput.Text = "You entered: " + input;
        }
        
        private void buttonCount_Click(object sender, EventArgs e)
        {
            string text = textBoxCounter.Text;
            labelCounter.Text = $"Character count: {text.Length}";
        }
    }
}
```

### Designer Setup
1. Continue in the same Windows Forms App or create a new one named Task5_UIContainers.
2. In the Designer:
   - Add a GroupBox named groupBoxUser and set its Text to "User Input".
   - Inside the GroupBox, add:
     - A TextBox named textBoxInput
     - A Button named buttonDisplay
     - A Label named labelOutput
   - Set the Text property of buttonDisplay to "Show" and labelOutput to "Output will appear here"
   - Add a second GroupBox named groupBoxCounter below the first one
   - Inside the second GroupBox, add:
     - A TextBox named textBoxCounter
     - A Button named buttonCount
     - A Label named labelCounter

### Explanation

- GroupBox helps organize related UI controls visually and logically.
- By grouping inputs together, the form becomes clearer for users.
- The interaction is similar to the previous task but demonstrates a better layout structure for real applications.
- **Modifications made**: Added a second GroupBox below the first one. In the new group, placed a TextBox and a Button. When the button is clicked, it shows how many characters the user typed into that TextBox.

## Final Summary

This lab introduced several key concepts in .NET programming:

1. **Generic Collections**: Using strongly-typed collections like List<T> and Dictionary<TKey, TValue> to manage data efficiently.

2. **Web Communication**: Making HTTP requests to external APIs and processing JSON responses.

3. **Asynchronous Programming**: Using async/await to perform time-consuming operations without blocking the application.

4. **GUI Development**: Creating user interfaces with Windows Forms, handling events, and organizing controls with containers.

These concepts form the foundation for building more complex applications that can process data, communicate with external services, perform operations without freezing the UI, and present information in a user-friendly way.

The modifications made to each task demonstrate an understanding of the underlying concepts and the ability to extend the provided examples with new functionality.
