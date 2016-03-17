using System;
namespace PlaidTowel
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char background = char.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            Console.WriteLine(new string(background, size) + symbol + new string(background, (size * 2) - 1) + symbol + new string(background, size));

            for (int j = 0; j < 2; j++)
            {
                int backCount = size;
                int separator = 1;
                int middle = (size * 2) - 1;
                for (int i = 0; i < size - 1; i++)
                {
                    middle -= 2;
                    backCount--;

                    Console.Write(new string(background, backCount));
                    Console.Write(symbol);
                    Console.Write(new string(background, separator));
                    Console.Write(symbol);
                    Console.Write(new string(background, middle));
                    Console.Write(symbol);
                    Console.Write(new string(background, separator));
                    Console.Write(symbol);
                    Console.Write(new string(background, backCount));
                    Console.WriteLine();
                    separator += 2;
                }
                Console.WriteLine(symbol + new string(background, (size * 2) - 1) + symbol + new string(background, (size * 2) - 1) + symbol);
                backCount = 0;
                middle = 1;
                for (int i = 0; i < size - 1; i++)
                {

                    backCount++;
                    separator -= 2;
                    Console.Write(new string(background, backCount));
                    Console.Write(symbol);
                    Console.Write(new string(background, separator));
                    Console.Write(symbol);
                    Console.Write(new string(background, middle));
                    Console.Write(symbol);
                    Console.Write(new string(background, separator));
                    Console.Write(symbol);
                    Console.Write(new string(background, backCount));
                    Console.WriteLine();
                    middle += 2;
                }
                Console.WriteLine(new string(background, size) + symbol + new string(background, (size * 2) - 1) + symbol + new string(background, size));
            }
        }
    }
}