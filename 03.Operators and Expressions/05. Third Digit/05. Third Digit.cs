using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        if(n / 100 % 10 == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}",n/100%10);
        }
    }
}
