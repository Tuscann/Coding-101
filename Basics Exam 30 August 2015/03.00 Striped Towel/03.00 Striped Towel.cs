using System;
class StripedTowel
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int width = size;
        int height = size + size / 2;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                bool isStripe = (j + i) % 3 == 0;
                if (isStripe)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}

