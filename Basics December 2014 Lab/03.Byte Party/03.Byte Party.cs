using System;
using System.Collections.Generic;
using System.Text;

class ByteParty
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char[,] numbersAsBinary = new char[n, 8];

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            string bits = Convert.ToString(num, 2).PadLeft(8, '0');
            char[] line = bits.ToCharArray();

            for (int j = numbersAsBinary.GetLength(1) - 1; j >= 0; j--)
            {
                numbersAsBinary[i, j] = bits[j];
            }
        }

        List<int> commands = new List<int>();
        List<int> positions = new List<int>();

        while (true)
        {
            string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (line[0] == "party")
            {
                break;
            }
            else
            {
                commands.Add(int.Parse(line[0]));
                positions.Add(int.Parse(line[1]));
            }
        }

        for (int i = 0; i < commands.Count; i++)
        {
            int currentCommand = commands[i];
            int pos = 7 - positions[i];
            switch (currentCommand)
            {
                case -1:
                    for (int k = 0; k < n; k++)
                    {
                        if (numbersAsBinary[k, pos] == '0')
                        {
                            numbersAsBinary[k, pos] = '1';
                        }
                        else
                        {
                            numbersAsBinary[k, pos] = '0';
                        }
                    }
                    break;
                case 0:
                    for (int k = 0; k < n; k++)
                    {
                        numbersAsBinary[k, pos] = '0';
                    }
                    break;
                case 1:
                    for (int k = 0; k < n; k++)
                    {
                        numbersAsBinary[k, pos] = '1';
                    }
                    break;
            }
        }

        for (int i = 0; i < numbersAsBinary.GetLength(0); i++)
        {
            StringBuilder currentNumber = new StringBuilder();

            for (int j = 0; j < numbersAsBinary.GetLength(1); j++)
            {
                currentNumber.Append(numbersAsBinary[i, j]);
            }

            int newNumber = Convert.ToInt32(currentNumber.ToString(), 2);
            Console.WriteLine(newNumber);
        }
    }
}