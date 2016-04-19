using System;
class Program
{
    static void Main()
    {
        string first = Console.ReadLine().ToLower();
        string second = Console.ReadLine().ToLower();

        int limit = int.Parse(Console.ReadLine());

        bool noGoodMatch = true;
        int weightFirst = 0;
        int weightSecond = 0;
        int nakovs = 0;

        for (int i = 0; i < first.Length; i++){weightFirst += first[i];}
        for (int i = 0; i < second.Length; i++){weightSecond += second[i];}

        int aLeft = first[0];

        for (int i = 1; i < first.Length; i++)
        {
            int bLeft = second[0];
            for (int j = 1; j < second.Length; j++)
            {
                nakovs = Math.Abs(aLeft * (weightSecond - bLeft) - bLeft * (weightFirst - aLeft));
                if (nakovs <= limit)
                {
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", 
                        first.Substring(0, i), first.Substring(i, first.Length - i),
                        second.Substring(0, j), second.Substring(j, second.Length - j), nakovs);
                    noGoodMatch = false;

                }
                bLeft += second[j];
            }
            aLeft += first[i];
        }
        if (noGoodMatch)
        {
            Console.WriteLine("No");
        }
    }
}