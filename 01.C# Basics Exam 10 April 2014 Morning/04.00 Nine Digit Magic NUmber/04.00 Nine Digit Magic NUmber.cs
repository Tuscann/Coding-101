using System;
class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool foundSolution = false;
        for (int abc = 111; abc <= 777; abc++)
        {
            int tempoSum = 0;
            int def = abc + diff;
            int ghi = def + diff;

            if (ghi <= 777)
            {
                string number = ("" + abc + def + ghi);
                number.ToCharArray();

                for (int i = 0; i < 9; i++)
                {
                    if (number[i] - '0' > 7 || number[i] - '0' < 1)
                    {
                        tempoSum = -1;
                        break;
                    }
                    tempoSum += number[i] - '0';
                }
                if (tempoSum == sum)
                {
                    Console.WriteLine(number);
                    foundSolution = true;
                }
            }
        }

        if (!foundSolution)
        {
            Console.WriteLine("No");
        }
    }
}