# ASP.NET Core MVC Projects Documentation

> **IMPORTANT SUBMISSION REQUIREMENTS:**
> - Convert this documentation to PDF or DOCX format before submission
> - Do NOT include this documentation in a ZIP file - submit it as a separate file
> - Add screenshots demonstrating each task's completion in the designated [SCREENSHOT] placeholders below
> - Ensure all screenshots clearly show the implemented functionality running in the browser

This document provides step-by-step implementation details for the five ASP.NET Core MVC tasks:

1. Understanding Web Applications
2. Constructing Data-Driven Web Apps
3. Model-View-Controller (MVC) in ASP.NET
4. Session, Cookies, and File Handling in ASP.NET
5. Introducing Entity Framework Using In-Memory Database

## Environment Setup

- Windows operating system
- Visual Studio 2022
- .NET 8.0 SDK

## Task 1: Understanding Web Applications

### Objective
Learn how web applications work and how they differ from console or desktop GUI apps. Explore the HTTP request/response cycle and the MVC structure in ASP.NET Core.

### Implementation

1. Created a new ASP.NET Core MVC project named `Task1_WebAppIntro`
2. Examined the MVC structure including Controllers, Views, and Models
3. Analyzed the HomeController and its Index action method
4. Added a new action method `WebAppInfo` that demonstrates the stateless nature of web applications

### Code Highlights

**HomeController.cs**
```csharp
public IActionResult WebAppInfo()
{
    ViewBag.Message = "Web apps are request-based and stateless.";
    return View();
}
```

**WebAppInfo.cshtml**
```html
@{
    ViewData["Title"] = "Web App Information";
}

<div class="text-center">
    <h1 class="display-4">Web Application Information</h1>
    <p>@ViewBag.Message</p>
</div>
```

### Screenshots

[SCREENSHOT 1: Home page of Task1_WebAppIntro showing the default welcome page]

[SCREENSHOT 2: WebAppInfo page showing the message about web apps being request-based and stateless]

## Task 2: Constructing Data-Driven Web Apps

### Objective
Build a simple web page that displays a list of data objects from a controller. Simulate data storage without using a real database.

### Implementation

1. Created a new ASP.NET Core MVC project named `Task2_DataDrivenApp`
2. Created a Student model class with Id, Name, and Grade properties
3. Created a StudentController that returns a list of Student objects with grades
4. Created a view to display the list of students with their grades
5. Added a navigation link to the Students page in the layout

### Code Highlights

**Student.cs**
```csharp
namespace Task2_DataDrivenApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
    }
}
```

**StudentController.cs**
```csharp
public IActionResult Index()
{
    var students = new List<Student>
    {
        new Student { Id = 1, Name = "Anna", Grade = "A" },
        new Student { Id = 2, Name = "Piotr", Grade = "B" }
    };

    return View(students);
}
```

**Index.cshtml**
```html
@model List<Task2_DataDrivenApp.Models.Student>

<h2>Student List</h2>
<ul>
@foreach (var student in Model)
{
    <li>@student.Name (ID: @student.Id, Grade: @student.Grade)</li>
}
</ul>
```

### Screenshots

[SCREENSHOT 3: Student List page showing students with their IDs and grades]

## Task 3: Model-View-Controller (MVC) in ASP.NET

### Objective
Understand the structure and responsibility of each MVC component by modifying the existing student list.

### Implementation

1. Created a new ASP.NET Core MVC project named `Task3_MVC`
2. Enhanced the Student model with a Grade property
3. Created a StudentController that sorts students by ID
4. Created a view to display the list of students with their grades
5. Added a navigation link to the Students page in the layout

### Code Highlights

**Student.cs**
```csharp
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Grade { get; set; }
}
```

**StudentController.cs**
```csharp
public IActionResult Index()
{
    var students = new List<Student>
    {
        new Student { Id = 1, Name = "Anna", Grade = "A" },
        new Student { Id = 2, Name = "Piotr", Grade = "B" }
    };
    
    // Sort the students by ID instead of name
    // This ensures that students are displayed in order of their ID numbers
    // rather than alphabetically by name, making it easier to find students
    // by their unique identifier in larger lists
    students.Sort((a, b) => a.Id.CompareTo(b.Id));
    
    return View(students);
}
```

**Index.cshtml**
```html
@model List<Task3_MVC.Models.Student>

<h2>Student List</h2>
<ul>
@foreach (var student in Model)
{
    <li>@student.Name (ID: @student.Id, Grade: @student.Grade)</li>
}
</ul>
```

### Screenshots

[SCREENSHOT 4: Student List page showing students sorted by ID with their grades]

## Task 4: Session, Cookies, and File Handling in ASP.NET

### Objective
Learn how to store and retrieve user-specific data using cookies and session, and how to write/read files on the server.

### Implementation

1. Created a new ASP.NET Core MVC project named `Task4_StateAndFiles`
2. Enabled session in Program.cs
3. Created a HomeController with methods for handling cookies, session, and files
4. Added methods to store and retrieve a favorite color using cookies
5. Created views to display the stored data

### Code Highlights

**Program.cs (Session Configuration)**
```csharp
builder.Services.AddSession();
// ...
app.UseSession();
```

**HomeController.cs**
```csharp
public IActionResult SetData()
{
    HttpContext.Response.Cookies.Append("UserName", "Anna");
    HttpContext.Session.SetString("Greeting", "Hello from session!");
    return RedirectToAction("GetData");
}

public IActionResult GetData()
{
    ViewBag.Name = HttpContext.Request.Cookies["UserName"];
    ViewBag.Message = HttpContext.Session.GetString("Greeting");
    return View();
}

public IActionResult WriteFile()
{
    string path = "wwwroot/data.txt";
    System.IO.File.WriteAllText(path, "Saved at: " + DateTime.Now);
    return Content("File saved.");
}

public IActionResult SetFavoriteColor(string color = "blue")
{
    HttpContext.Response.Cookies.Append("FavoriteColor", color);
    return RedirectToAction("DisplayFavoriteColor");
}

public IActionResult DisplayFavoriteColor()
{
    ViewBag.FavoriteColor = HttpContext.Request.Cookies["FavoriteColor"] ?? "No color selected";
    return View();
}
```

**DisplayFavoriteColor.cshtml**
```html
@{
    ViewData["Title"] = "Favorite Color";
}

<h2>Your Favorite Color</h2>
<p>Your favorite color is: <strong style="color:@ViewBag.FavoriteColor">@ViewBag.FavoriteColor</strong></p>

<h3>Change your favorite color:</h3>
<ul>
    <li><a asp-action="SetFavoriteColor" asp-route-color="red">Red</a></li>
    <li><a asp-action="SetFavoriteColor" asp-route-color="green">Green</a></li>
    <li><a asp-action="SetFavoriteColor" asp-route-color="blue">Blue</a></li>
</ul>
```

### Screenshots

[SCREENSHOT 5: Session and Cookie page showing stored user data]

[SCREENSHOT 6: Favorite Color page showing the selected color and options to change it]

## Task 5: Introducing Entity Framework Using In-Memory Database

### Objective
Understand how Entity Framework Core works by creating a simple data model, setting up an in-memory database context, and performing data operations without using a physical database.

### Implementation

1. Created a new ASP.NET Core MVC project named `Task5_EF_InMemory`
2. Added the Microsoft.EntityFrameworkCore.InMemory NuGet package
3. Created a Product model class
4. Created an AppDbContext class for Entity Framework
5. Registered the DbContext with the In-Memory provider in Program.cs
6. Created a ProductController that adds sample data and retrieves it
7. Created a view to display the list of products
8. Added a navigation link to the Products page in the layout

### Code Highlights

**Product.cs**
```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```

**AppDbContext.cs**
```csharp
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}
```

**Program.cs (DbContext Registration)**
```csharp
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("ProductDatabase"));
```

**ProductController.cs**
```csharp
public class ProductController : Controller
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;

        // Add default data if empty
        if (!_context.Products.Any())
        {
            _context.Products.Add(new Product { Name = "Notebook" });
            _context.Products.Add(new Product { Name = "Pen" });
            _context.Products.Add(new Product { Name = "Laptop" });
            _context.SaveChanges();
        }
    }

    public IActionResult Index()
    {
        var products = _context.Products.ToList();
        return View(products);
    }
}
```

**Index.cshtml (Product View)**
```html
@model List<Task5_EF_InMemory.Models.Product>

<h2>Product List</h2>
<ul>
@foreach (var product in Model)
{
    <li>@product.Name (ID: @product.Id)</li>
}
</ul>
```

### Screenshots

[SCREENSHOT 7: Products page showing the list of products including the added Laptop]

## Final Task: Modifications

All the requested modifications have been implemented:

1. Task 1: Added a method in HomeController that returns a view with a message about web apps being request-based and stateless.
2. Task 2: Added a Grade field to the student model and displayed it in the list.
3. Task 3: Sorted the student list by Id and added detailed explanatory comments in the controller.
4. Task 4: Added actions to store and display a favorite color using cookies.
5. Task 5: Added another product (Laptop) to the database in ProductController.

## Conclusion

These five tasks demonstrate the core concepts of ASP.NET Core MVC development, including:

- The basic structure of web applications and the MVC pattern
- Working with data models and controllers
- Managing state with cookies and session
- File handling on the server
- Using Entity Framework Core with an in-memory database

The implementations follow best practices for ASP.NET Core development and provide a solid foundation for building more complex web applications.

## Submission Instructions

1. **Format**: Convert this documentation to PDF or DOCX format before submission.
2. **Screenshots**: Replace all [SCREENSHOT] placeholders with actual screenshots of the running applications.
3. **Separate File**: Submit this documentation as a separate file, not included in any ZIP archive.
4. **Verification**: Before submission, verify that all screenshots clearly demonstrate the implemented functionality for each task.
