using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> cities = new List<string> { "Warsaw", "Krakow", "Gdansk" };
        cities.Add("Lodz");
        
        Console.WriteLine("List of cities:");
        foreach (var city in cities)
        {
            Console.WriteLine("- " + city);
        }
        
        List<string> countries = new List<string> { "Poland", "Germany", "France" };
        
        Console.WriteLine("\nList of countries:");
        foreach (var country in countries)
        {
            Console.WriteLine("- " + country);
        }
        
        Console.WriteLine("\nUpdated list of cities:");
        cities.Add("Poznan");
        foreach (var city in cities)
        {
            Console.WriteLine("- " + city);
        }
        
        Dictionary<string, int> population = new Dictionary<string, int>
        {
            { "Warsaw", 1800000 },
            { "Krakow", 770000 }
        };
        
        Console.WriteLine();
        Console.WriteLine("Population of Warsaw: " + population["Warsaw"]);
    }
}
