






namepace hello
{
    o references
    class Program
    {
        o references
        static void main ( straing[]args)
        {
            console.WriteLine("Hellow world");
            console.readline();
        }

    }
}













using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}


// Global using directives (C# 10 feature)
global using System;

namespace MyApp; // File-scoped namespace (C# 10 feature)

public class Program
{
    public static void Main()
    {
        var person = new Person("Alice", 25);
        Console.WriteLine(person);

        var updatedPerson = person with { Age = 26 }; // Record struct with expression-based mutation
        Console.WriteLine(updatedPerson);
    }
}

// Record struct (C# 10 feature)
public readonly record struct Person(string Name, int Age);



