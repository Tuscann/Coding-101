using System;
using System.Collections.Generic;
class EncodedAnswers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<char> answers = new List<char>();
        int[] counts = new int[4];

        for (int i = 0; i < n; i++)
        {
            uint qustion = uint.Parse(Console.ReadLine());
            uint answer = qustion % 4;
            char answerAsLetter = Convert.ToChar(97 + answer);
            answers.Add(answerAsLetter);

            switch (answerAsLetter)
            {
                case 'a': counts[0]++; break;
                case 'b': counts[1]++; break;
                case 'c': counts[2]++; break;
                case 'd': counts[3]++; break;
            }
        }

        PrintAnswers(answers);
        Console.WriteLine("Answer A: {0}", counts[0]);
        Console.WriteLine("Answer B: {0}", counts[1]);
        Console.WriteLine("Answer C: {0}", counts[2]);
        Console.WriteLine("Answer D: {0}", counts[3]);
    }

    static void PrintAnswers(List<char> answers)
    {
        for (int i = 0; i < answers.Count; i++)
        {
            if (i < answers.Count - 1)
            {
                Console.Write("{0} ", answers[i]);
            }
            else
            {
                Console.WriteLine("{0}", answers[i]);
            }
        }
    }
}