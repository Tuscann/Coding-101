using System;

public class ScotlandFlag
{
    static char letter = '@';
    public static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        int innerDieses = n - 2;
        int outerTildas = 1;
        
        if (n == 1){Console.WriteLine("A");}
        else if (n == 3)
        {
            Console.WriteLine("{0}{1}{2}", IncreasedLetter(), new string('#', innerDieses), IncreasedLetter());
            Console.WriteLine("{0}{1}{0}", new string('-', n / 2), IncreasedLetter());innerDieses = 1; 
            Console.WriteLine("{0}{1}{2}", IncreasedLetter(), new string('#', innerDieses), IncreasedLetter());
        }
        else
        {
            Console.WriteLine("{0}{1}{2}", IncreasedLetter(), new string('#', innerDieses), IncreasedLetter());
            innerDieses -= 2;

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('~', outerTildas), IncreasedLetter(), new string('#', innerDieses), IncreasedLetter());
                innerDieses -= 2; outerTildas++;
            }
            Console.WriteLine("{0}{1}{0}", new string('-', n / 2), IncreasedLetter());
            innerDieses = 1; outerTildas -= 1;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('~', outerTildas), IncreasedLetter(), new string('#', innerDieses), IncreasedLetter());
                innerDieses += 2;outerTildas--;
            }
            Console.WriteLine("{0}{1}{2}", IncreasedLetter(), new string('#', innerDieses), IncreasedLetter());
        }
    }
    static string IncreasedLetter()
    {
        letter++;

        if ((int)letter == 91) { letter = 'A'; }
        return letter.ToString();
    }
}

