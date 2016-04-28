using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        String myHexNumber = n.ToString("X");

        Console.WriteLine(myHexNumber);

        int remainder;
        string result = string.Empty;
        while (n > 0)
        {
            remainder = n % 2;
            n /= 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine(result);
    }
}