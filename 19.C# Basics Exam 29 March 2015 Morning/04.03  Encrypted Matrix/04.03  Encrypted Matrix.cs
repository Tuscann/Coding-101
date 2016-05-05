using System;
class EncryptedMatrix
{
    static void Main()
    {
        string input = Console.ReadLine();

        string bigNumber = String.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            bigNumber += Convert.ToInt32(input[i]) % 10;
        }
        //Console.WriteLine(bigNumber);
        string newNumber = String.Empty;
        for (int i = 0; i < bigNumber.Length; i++)
        {
            int currentNumber = Int32.Parse(bigNumber[i].ToString());
            if (currentNumber % 2 == 0)
            {
                newNumber += currentNumber * currentNumber;
            }
            else
            {
                int nextNumber = 0;
                int prevNumber = 0;
                if (bigNumber.Length != 1)
                {
                    if (i > 0)
                    {
                        prevNumber = Int32.Parse(bigNumber[i - 1].ToString());
                    }
                    if (i < bigNumber.Length - 1)
                    {
                        nextNumber = Int32.Parse(bigNumber[i + 1].ToString());
                    }
                }
                int numberAfterMath = currentNumber + prevNumber + nextNumber;
                newNumber += numberAfterMath;
            }
        }
        //Console.WriteLine(newNumber);
        string way = Console.ReadLine();
        int length = newNumber.Length;
        int[,] matrix = new int[length, length];

        switch (way)
        {
            case "\\":
                {
                    for (int i = 0; i < length; i++)
                    {
                        matrix[i, i] = int.Parse(newNumber[i].ToString());
                    }
                    break;
                }
            case "/":
                {
                    for (int i = 0; i < length; i++)
                    {
                        matrix[length - i - 1, i] = int.Parse(newNumber[i].ToString());
                    }
                    break;
                }
        }
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}