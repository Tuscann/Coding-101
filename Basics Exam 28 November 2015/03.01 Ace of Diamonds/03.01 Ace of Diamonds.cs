using System;
class AceOfDiamonds
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int topDash = ((size - 1) / 2) - 1;
        int topSymbol = 1;
        int bottomDash = 1;
        int bottomSymbol = size - 4;
        
        Console.WriteLine("{0}", new string('*', size)); // First row
        while (topDash >= 0)
        {
            Console.WriteLine("*{0}{1}{0}*", new string('-', topDash), new string('@', topSymbol));
            topDash--;                    
            topSymbol += 2;     // Top half + middle part
        }

        while (bottomSymbol >= 1)
        {
            Console.WriteLine("*{0}{1}{0}*", new string('-', bottomDash), new string('@', bottomSymbol));
            bottomDash ++;
            bottomSymbol -= 2;
        }
        Console.WriteLine("{0}", new string('*', size)); // Last row
    }
}