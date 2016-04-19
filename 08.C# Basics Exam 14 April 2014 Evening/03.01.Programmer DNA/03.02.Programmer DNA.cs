using System;
class ProgrammerDNA
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        string start = Console.ReadLine();
        int sign = 1;
        int cycles = n / 7;
        int residual = n % 7;

        string DNA = "ABCDEFG";
        int index = DNA.IndexOf(start);
        for (int a = 0; a <= cycles * 4; a++)
        {
            DNA += "ABCDEFG";
        }

        for (int c = 0; c < cycles; c++)
        {
            for (int i = -3; i <= 3; i++)
            {
                sign = (i < 0) ? -1 : 1;
                string substring = DNA.Substring(index, (7 - 2 * i * sign));

                Console.WriteLine("{0}{1}{0}", new string('.', i * sign), substring);
                index += (int)(7 - 2 * i * sign);
            }
        }

        for (int i = -3; i < -3 + residual; i++)
        {
            sign = (i < 0) ? -1 : 1;
            string substring = DNA.Substring(index, (7 - 2 * i * sign));

            Console.WriteLine("{0}{1}{0}", new string('.', i * sign), substring);
            index += (int)(7 - 2 * i * sign);
        }
    }
}