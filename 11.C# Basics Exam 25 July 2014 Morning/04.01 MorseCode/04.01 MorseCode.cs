using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool found = false; int sumN = 0;

        List<int> a = new List<int>();

        while (n > 0)
        {
            sumN += n % 10;
            n /= 10;
        }
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                for (int k = 0; k < 6; k++)
                {
                    for (int l = 0; l < 6; l++)
                    {
                        for (int m = 0; m < 6; m++)
                        {
                            for (int o = 0; o < 6; o++)
                            {
                                int g = i * j * k * l * m * o;

                                if (g == sumN)
                                {
                                    found = true;

                                    a.Add(i);
                                    a.Add(j);
                                    a.Add(k);
                                    a.Add(l);
                                    a.Add(m);
                                    a.Add(o);

                                    for (int p = 0; p < a.Count; p++)
                                    {
                                        string r = null;

                                        if (a[p] == 0)
                                        {
                                            r = "-----";
                                        }
                                        else if (a[p] == 1)
                                        {
                                            r = ".----";
                                        }
                                        else if (a[p] == 2)
                                        {
                                            r = "..---";
                                        }
                                        else if (a[p] == 3)
                                        {
                                            r = "...--";
                                        }
                                        else if (a[p] == 4)
                                        {
                                            r = "....-";
                                        }
                                        else if (a[p] == 5)
                                        {
                                            r = ".....";
                                        }


                                        Console.Write("{0}|", r);
                                    }

                                    a.Clear();
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }

        if (!found)
        {
            Console.Write("No");
        }
    }
}