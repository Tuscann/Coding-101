using System;
class Program
{
    static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());

        if (b - a < 3)
        {
            Console.WriteLine("No");
        }
        for (int first = a; first <= b - 3; first++)
        {
            for (int second = first + 1; second <= b - 2; second++)
            {
                for (int third = second + 1; third <= b - 1; third++)
                {
                    for (int four = third + 1; four <= b; four++)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", first, second, third, four);
                    }
                }
            }
        }
    }
}

