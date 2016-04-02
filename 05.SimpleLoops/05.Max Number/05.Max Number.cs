using System;
class Program
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        double max = 0;
        for (int i = 0; i < number; i++)
        {
            var num = double.Parse(Console.ReadLine());
            if (num > max)
            {
                num = max; Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}

