using System;
class Program
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string secondName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string gender = Console.ReadLine();
        double PersonalID = double.Parse(Console.ReadLine());
        int UniqueEmployeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", secondName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID: {0}", PersonalID);
        Console.WriteLine("Unique Employee number: {0}", UniqueEmployeeNumber);
    }
}