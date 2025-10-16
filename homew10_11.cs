//lab1
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ստեղծում ենք թվերի ցուցակ՝ 1-ից 20
        List<int> numbers = Enumerable.Range(1, 20).ToList();

        var evenNumbers =
            from n in numbers
            where n % 2 == 0
            select n;

        Console.WriteLine("Even numbers:");
        foreach (var num in evenNumbers)
            Console.Write(num + " ");
    }
}


//lab2

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> names = new() 
        { 
            "Anna", "Aram", "Nane", "Karen", "Ani", "Sona", "Artur" 
        };

        var aNames =
            from n in names
            where n.StartsWith("A")
            select n;

        foreach (var name in aNames)
            Console.WriteLine(name);
    }
}


//lab3


using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Phone", Price = 650 },
            new Product { Name = "Laptop", Price = 700 },
            new Product { Name = "Mouse", Price = 1000 },
            new Product { Name = "Keyboard", Price = 950 },
            new Product { Name = "Monitor", Price = 180 }
        };

        var cheapProducts = products.Where(p => p.Price < 1000);

        foreach (var p in cheapProducts)
            Console.WriteLine($"{p.Name} → {p.Price}");
    }
}

//lab4


using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public double Grade { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Anna", Grade = 19.5 },
            new Student { Name = "Aram", Grade = 16.7 },
            new Student { Name = "Mari", Grade = 18.5 },
            new Student { Name = "Tatev", Grade = 12.4 }
        };

        double avgGrade = students.Average(s => s.Grade);

        Console.WriteLine($"AVG: {avgGrade:F2}");
    }
}


