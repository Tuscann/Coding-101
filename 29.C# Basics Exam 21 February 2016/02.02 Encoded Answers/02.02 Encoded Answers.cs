using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string result = null;
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        for (int i = 0; i < n; i++)
        {
            string answer;

            long das = long.Parse(Console.ReadLine());

            if (das % 4 == 2)
            {
                c++;
                answer = "c ";
            }
            else if (das % 4 == 3)
            {
                d++;
                answer = "d ";
            }
            else if (das % 4 == 0)
            {
                a++;
                answer = "a ";
            }
            else
            {
                b++;
                answer = "b ";
            }
            result = result + answer;
        }
        Console.WriteLine("{0}", result);
        Console.WriteLine("Answer A: {0}", a);
        Console.WriteLine("Answer B: {0}", b);
        Console.WriteLine("Answer C: {0}", c);
        Console.WriteLine("Answer D: {0}", d);
    }
}