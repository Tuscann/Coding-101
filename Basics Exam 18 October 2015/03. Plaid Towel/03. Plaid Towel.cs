using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char background = char.Parse(Console.ReadLine());
        char rhombus = char.Parse(Console.ReadLine());

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, n), rhombus, new string(background, n * 2 - 1));
            int outter = n - 1; // left and right background symbols
            int middle = n * 2 - 3; // background symbols between two rhombus
            int inner = 1; // background symbols inside rhombus
            for (int j = 0; j < n - 1; j++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                    new string(background, outter), rhombus, new string(background, inner),
                    new string(background, middle));

                outter--;
                inner += 2;
                middle -= 2;
            }
            Console.WriteLine("{0}{1}{0}{1}{0}", rhombus, new string(background, inner));

            for (int j = 0; j < n - 1; j++)
            {
                outter++;
                inner -= 2;
                middle += 2;
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(background, outter),
                    rhombus, new string(background, inner), new string(background, middle));
            }

        }
      Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, n), rhombus, new string(background, n * 2 - 1));
    }
}

