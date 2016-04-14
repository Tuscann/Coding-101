using System;
class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char leftLetter = 'A';
        char rightletter;
        int inner = n - 2;
        int outer;

        for (int i = 0; i < n / 2; i++)
        {
            outer = i;
            string outerStr = string.Empty;
            if (outer != 0)
            {
                outerStr = new string('~', outer);
            }
            if (leftLetter == '[')
            {
                leftLetter = 'A';
            }
            else if (leftLetter == '\\')
            {
                leftLetter = 'B';
            }
            rightletter = leftLetter;
            rightletter++;
            if (rightletter == '[')
            {
                rightletter = 'A';
            }
            else if (rightletter == '\\')
            {
                rightletter = 'B';
            }
            string innerStr = new string('#', inner);
            string row = outerStr + leftLetter + innerStr + rightletter + outerStr;
            Console.WriteLine(row);
            inner -= 2;
            leftLetter++;
            leftLetter++;
        }
        Console.WriteLine(new string('-', (n - 1) / 2) + leftLetter + new string('-', (n - 1) / 2));
        leftLetter++;

        outer = (n - 3) / 2;
        inner = 1;
        for (int i = 0; i < n / 2; i++)
        {
            string outerStr = string.Empty;
            if (outer != 0)
            {
                outerStr = new string('~', outer);
            }
            if (leftLetter == '[')
            {
                leftLetter = 'A';
            }
            else if (leftLetter == '\\')
            {
                leftLetter = 'B';
            }
            rightletter = leftLetter;
            rightletter++;
            if (rightletter == '[')
            {
                rightletter = 'A';
            }
            else if (rightletter == '\\')
            {
                rightletter = 'B';
            }
            string innerStr = new string('#', inner);
            string row = outerStr + leftLetter + innerStr + rightletter + outerStr;
            Console.WriteLine(row);
            inner += 2;
            outer--;
            leftLetter++;
            leftLetter++;
        }
    }
}