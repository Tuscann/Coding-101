using System;

class Greeting
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());

        //Console.WriteLine("Hello, {0} {1}.\nYou are {2} years old.", firstName, lastName, age);
        Console.WriteLine($"Hello, {firstName} {lastName}.\r\nYou are {age} years old.");
    }
}

