using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your first name?");
        string name = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string Lname = Console.ReadLine();
        Console.WriteLine($"Your name is, {name} {Lname}");
    }
} 