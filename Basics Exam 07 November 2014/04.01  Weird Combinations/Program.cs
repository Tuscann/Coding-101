using System;
class WeirdCombinations
{
    public static void Main()
    {
        string letter = Console.ReadLine();
        char[] letters = letter.ToCharArray();
        int nthNumber = int.Parse(Console.ReadLine());

        int counter = 0;
        bool hasResult = false;
        foreach (char c in letters)
        {
            foreach (char c1 in letters)
            {
                foreach (char c2 in letters)
                {
                    foreach (char c3 in letters)
                    {
                        foreach (char c4 in letters)
                        {
                            if (counter == nthNumber)
                            {
                                string result =
                                    c + "" +
                                    c1 + "" +
                                    c2 + "" +
                                    c3 + "" +
                                    c4;
                                Console.WriteLine(result);
                                hasResult = true;
                            }

                            counter++;
                        }
                    }
                }
            }
        }

        if (!hasResult)
        {
            Console.WriteLine("No");
        }
    }
}
