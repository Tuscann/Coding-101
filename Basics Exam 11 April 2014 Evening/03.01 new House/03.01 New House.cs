using System;

internal class NewHouse
{
    private static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (var i = 1; i <= n; i += 2)
        {
            var dashesCount = (n - i)/2;
            var dashes = new string('-', dashesCount);
            var asterisks = new string('*', i);
            Console.Write(dashes);
            Console.Write(asterisks);
            Console.Write(dashes);
            Console.WriteLine();
        }
        for (var i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}{1}{0}", "|", new string('*', n - 2));
        }
    }
}