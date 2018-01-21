using System;
class Program
{
    static void Main()  // 100/100 wrong test
    {
        decimal sum = decimal.Parse(Console.ReadLine());
        int monthCount = int.Parse(Console.ReadLine());

        decimal totalll = sum;
        decimal last = sum;

        for (int i = 1; i <= monthCount; i++)
        {
            totalll = (1.00m + 0.027m) * last;
            last = (1.00m + 0.027m) * last;
        }
        Console.WriteLine("Simple interest rate: {0:f2} lv. ", (1.00m + monthCount * 0.03m) * sum);
        Console.WriteLine("Complex interest rate: {0:f2} lv.", totalll);

        if ((1.00m + monthCount * 0.03m) * sum > totalll)
        {
            Console.WriteLine("Choose a simple interest rate. You will win {0:f2} lv.", (1.00m + monthCount * 0.03m) * sum - totalll);
        }
        else
        {
            Console.WriteLine("Choose a complex interest rate. You will win {0:f2} lv.",  totalll- (1.00m + monthCount * 0.03m) * sum);
        }
    }
}