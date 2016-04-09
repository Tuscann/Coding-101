using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        List<double> result = new List<double>();

        bool areAllDiferent = false;
        while (!areAllDiferent)
        {
            areAllDiferent = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (i < list.Count - 1 && list[i] == list[i + 1])
                {
                    result.Add(list[i] * 2);
                    i++;
                    areAllDiferent = false;
                }
                else
                {
                    result.Add(list[i]);
                }
            }
            list = result;
            result = new List<double>();
        }
        Console.WriteLine(string.Join(" ", list));
    }
}

