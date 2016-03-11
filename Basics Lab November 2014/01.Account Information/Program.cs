using System;

class Program
{
    static void Main()
    {
        var firstName = Console.ReadLine();
        var lastName = Console.ReadLine();
        var id = int.Parse(Console.ReadLine());
        var totalBalance = double.Parse(Console.ReadLine());


        Console.WriteLine("Hello, {0} {1}", firstName, lastName);
        Console.WriteLine("Client id: {0}", id);
        Console.WriteLine("Total balance: {0:f2}", totalBalance);
        if (totalBalance >= 0) { Console.WriteLine("Active: yes"); }
        else { Console.WriteLine("Active: no"); }

    }
}

