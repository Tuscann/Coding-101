using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int targetCount = int.Parse(Console.ReadLine());

        int count = 0;
        bool hasResult = false;

        for (int first = 0; first < input.Length; first++)
        {
            for (int second = 0; second < input.Length; second++)
            {
                for (int third = 0; third < input.Length; third++)
                {
                    for (int fourth = 0; fourth < input.Length; fourth++)
                    {
                        for (int fifth = 0; fifth < input.Length; fifth++)
                        {
                            if (count == targetCount)
                            {
                                string output = "" + input[first] + input[second] + input[third] + input[fourth] + input[fifth];
                                Console.WriteLine(output);
                                hasResult = true;
                            }
                            count++;
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

