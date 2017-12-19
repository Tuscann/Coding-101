using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        double kilometers = double.Parse(Console.ReadLine());
        double sum = kilometers;

        for (int i = 0; i < n; i++)
        {
            int increase = int.Parse(Console.ReadLine());
            kilometers *= 1 + increase / 100.0;
            sum += kilometers;
        }
        if (sum <= 1000.00)
        {
            Console.WriteLine("Sorry Mrs. Ivanova, you need to run {0} more kilometers", Math.Ceiling(1000.00 - sum));
        }
        else
        {
            Console.WriteLine("You've done a great job running {0} more kilometers! ", Math.Ceiling(sum - 1000.00));
        }
    }
}