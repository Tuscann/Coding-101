using System;
class Program
{
    static void Main()
    {
        char n = char.Parse(Console.ReadLine());
        int n1 = int.Parse(Console.ReadLine());
        char m = char.Parse(Console.ReadLine());
        int m1 = int.Parse(Console.ReadLine());
        char k = char.Parse(Console.ReadLine());
        int k1 = int.Parse(Console.ReadLine());

        char after1 = Convert.ToChar(n + n1);
        char after2 = Convert.ToChar(m + m1);
        char after3 = Convert.ToChar(k + k1);

        string x = "" + after1 + after2 + after3;

        Console.WriteLine(x);
        if (x == "@@@")
        {
            Console.WriteLine("!!! YOU LOSE EVERYTHING !!!");
        }
        else if (x == "777")
        {
            Console.WriteLine("*** JACKPOT ***");
        }
    }
}