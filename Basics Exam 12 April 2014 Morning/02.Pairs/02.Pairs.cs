using System;
class Program
{
    static void Main()
    {
        string[] n = Console.ReadLine().Split(' ');

        int firstElement = int.Parse(n[0]);
        int secondElement = int.Parse(n[1]);
        int prevValue = firstElement + secondElement;

        int maxdiff = 0;
        for (int i = 2; i < n.Length - 1; i += 2)
        {
            firstElement = int.Parse(n[i]);
            secondElement = int.Parse(n[i + 1]);
            int lastValue = firstElement + secondElement;
            int diff = Math.Abs(lastValue - prevValue);
            maxdiff = Math.Max(diff, maxdiff);
            prevValue = lastValue;
        }
        if (maxdiff == 0)
        {
            Console.WriteLine("Yes, value=" + prevValue);
        }
        else
        {
            Console.WriteLine("No, maxdiff=" + maxdiff);
        }





    }
}

