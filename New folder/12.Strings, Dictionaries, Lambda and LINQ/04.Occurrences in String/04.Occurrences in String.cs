using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string word = Console.ReadLine().ToLower();

        int offset = input.IndexOf(word);
        bool flag = false;

        int cnt = 0;

        while (offset != -1)
        {
            flag = true;
            offset = input.IndexOf(word, offset + 1);

            if (offset != -1)
            {
                cnt++;
            }
        }
        if (flag)
        {
            cnt++;
        }
        Console.WriteLine(cnt);
    }
}

