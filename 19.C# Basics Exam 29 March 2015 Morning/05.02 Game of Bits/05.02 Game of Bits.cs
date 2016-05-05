using System;
class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int counterBits = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int x = 7; x >= 0; x--)
            {
                if ((counterBits % step == 1) || (step == 1 && counterBits > 0))
                {
                    num = num | (1 << x);
                }
                counterBits++;
            }
            Console.WriteLine(num);
        }
    }
}