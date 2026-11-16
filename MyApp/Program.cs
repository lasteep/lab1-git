using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello from main branch!");
        GreetUser("User");
        SayGoodbye("User");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    static void SayGoodbye(string name)
    {
        Console.WriteLine($"Goodbye, {name}! See you soon.");
    }
}