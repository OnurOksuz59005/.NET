using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Task3_MVC.Models;

namespace Task3_MVC.Controllers
{
    public class StudentController : Controller
    {
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
    }
}
