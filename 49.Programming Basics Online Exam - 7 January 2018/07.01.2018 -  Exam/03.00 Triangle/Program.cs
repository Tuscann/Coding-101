using System;
class Program
{
    static void Main() // 100/100
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a < b + c && b < a + c && c < a + b)
        {
            if (!a.Equals(b) && !b.Equals(c) && !a.Equals(c))
            {
                Console.WriteLine("Triangle with sides {0}, {1} and {2} is scalene.", a, b, c);
            }
            else if (a == b && b == c && c == a)
            {
                Console.WriteLine("Triangle with sides {0}, {1} and {2} is equilateral.", a, b, c);
            }
            else
            {
                Console.WriteLine("Triangle with sides {0}, {1} and {2} is isosceles.", a, b, c);
            }
        }
        else
        {
            Console.WriteLine("There is no triangle with sides {0}, {1} and {2}.", a, b, c);
        }
    }
}