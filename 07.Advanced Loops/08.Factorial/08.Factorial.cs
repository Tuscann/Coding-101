using System;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var factoriel = 1;
        do
        {
            factoriel = factoriel * n;
            n--;
        } while (n > 1);
        Console.WriteLine(factoriel);

    }
}

