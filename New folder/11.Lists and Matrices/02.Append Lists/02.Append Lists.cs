using System;
using System.Collections.Generic;
class Program
{
    private static void Main()
    {
        string[] lists = Console.ReadLine().Split('|');
        List<string> result = new List<string>();
        
        for (int i = lists.Length - 1; i >= 0; i--)
        {
            var list = lists[i].Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in list)
            {
                result.Add(item);
            }
        }
        Console.WriteLine(string.Join(" ", result));
    }
}

