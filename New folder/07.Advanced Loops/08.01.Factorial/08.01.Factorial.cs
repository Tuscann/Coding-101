using System;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var factoriel = 1;
        for (int i = 1; i <= n; i++)
        {
            factoriel = factoriel * i;
        }

        Console.WriteLine(factoriel);

    }
}

