using System;
class DrawChristmasThree
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < (n / 2) + 1; i++)
        {
            int countChar1 = n - i;
            int countChar2 = (2 * i) + 1;
            string char1 = new string('\'', countChar1);
            string char2 = new string('^', countChar2);

            Console.Write(char1);
            Console.Write(char2);
            Console.Write(char1);
            Console.WriteLine();
        }

        for (int j = 1; j <= (n / 2) + 1; j++)
        {
            int countChar1 = n - j;
            int countChar2 = (2 * j) + 1;
            string char1 = new string('\'', countChar1);
            string char2 = new string('^', countChar2);
            Console.Write(char1);
            Console.Write(char2);
            Console.Write(char1);
            Console.WriteLine();
        }

        for (int k = 0; k < (n / 2) + 1; k++)
        {
            int countChar1 = n - 1;
            string char1 = new string('\'', countChar1);

            Console.Write("{0}| |{0}", char1);
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', n * 2 + 1));


    }
}