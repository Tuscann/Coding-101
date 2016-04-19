using System;
class Program
{
    static void Main()
    {
        string str = Console.ReadLine().ToLower();
        
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            Console.WriteLine(
              "str[{0}] -> '{1}'", i, ch);
        }
    }
}

