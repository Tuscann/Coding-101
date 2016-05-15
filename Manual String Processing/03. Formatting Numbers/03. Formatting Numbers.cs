using System;
using System.Linq;
class Program
{
    static void Main()
    {
        //444 -7.5   7.5
       
     string [] k = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        

        int a = int.Parse(k[0]);
        string a1 = a.ToString("X");
        string binary = Convert.ToString(a, 2);

        double b = double.Parse(k[1]);
        double c = double.Parse(k[2]);

        Console.WriteLine(b);
        
        //Console.Write("|{0}{1}", a1, new string(' ', 10 - 1 - a1.Length));
        //Console.Write("|{0}{1}|", new String('0', 10 - binary.Length), binary);
        //Console.Write("{0}{1:f2}", new string(' ', 10 - 1 - k[1].Length), b);
        //Console.Write("|{0:f3}{1}|",c, new string(' ', 10 - 2 - k[2].Length));
        
    }
}