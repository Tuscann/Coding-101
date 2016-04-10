using System;
using System.Linq;
class MatrixOfPalindromes
{
    static void Main()
    {
        string[] dada = Console.ReadLine().Split(' ');

        int r = int.Parse(dada[0]);
        int c = int.Parse(dada[1]);

        string[] alphabet = { "0", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        for (int i = 1; i <= r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write("{0}{1}{0} ", alphabet[i], alphabet[i + j]);
            }
            Console.WriteLine();
        }
    }
}