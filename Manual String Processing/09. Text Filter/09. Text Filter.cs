using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string inputs = @"Linux, Windows
It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client
";
        string inputss = Console.ReadLine();
        string input = inputs.Remove(0, 16);

        StringBuilder b = new StringBuilder(input);

        b.Replace("Linux","*****");
        b.Replace("Windows", "*******");
        Console.WriteLine(string.Join("", b));
        
        //var f = x.Replace("Windows", "*******");
        // string dsasda = f.Replace("Linux", "*****");

        //Console.WriteLine(input);
        //Console.WriteLine();
        //Console.WriteLine(dsasda);
    }
}