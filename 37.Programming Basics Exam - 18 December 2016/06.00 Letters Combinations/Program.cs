using System;
using System.Text;
class Program
{
    static void Main()
    {
        char firstLetter = Convert.ToChar(Console.ReadLine());
        char secontLetter = Convert.ToChar(Console.ReadLine());
        char missingLetter = Convert.ToChar(Console.ReadLine());

        int count = 0;
        for (char i = firstLetter; i <= secontLetter; i++)
        {
            for (char j = firstLetter; j <= secontLetter; j++)
            {
                for (char k = firstLetter; k <= secontLetter; k++)
                {
                    StringBuilder answer = new StringBuilder(i + "" + "" + j + "" + k + " ");
                    if (i == missingLetter)
                    {
                        answer.Remove(0, 0);
                    }
                    else if (j == missingLetter)
                    {
                        answer.Remove(1, 1);
                    }
                    else if (k == missingLetter)
                    {
                        answer.Remove(2, 2);
                    }
                    else
                    {
                        Console.Write(i + "" + "" + j + "" + k + " ");
                        count++;
                    }
                }   
            }
        }
        Console.Write(count);
    }
}