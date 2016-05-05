/*
 * C# Program to Calculate Size of File using LINQ
 */
using System;
using System.Linq;
using System.IO;
class Program
{
    static void Main()
    {
        string[] dirfiles = Directory.GetFiles("C:\\NVIDIA");
        var avg = dirfiles.Select(file => new FileInfo(file).Length).Average();
        avg = Math.Round(avg / 10, 1);
        Console.WriteLine("The Average file size is {0} MB", avg);
        Console.ReadLine();
    }
}