using System;
class Program
{
    static void Main()
    {
        int countpassengers = int.Parse(Console.ReadLine());
        int bustops = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= bustops; i++)
        {
            int newpasnegersOUT = int.Parse(Console.ReadLine());
            int newPannegersIN = int.Parse(Console.ReadLine());

            countpassengers -= newpasnegersOUT;
            countpassengers += newPannegersIN;

            if (i % 2 == 1)
            {
                countpassengers += 2;
            }
            else
            {
                countpassengers -= 2;
            }
        }
        Console.WriteLine("The final number of passengers is : {0}", countpassengers);
    }
}