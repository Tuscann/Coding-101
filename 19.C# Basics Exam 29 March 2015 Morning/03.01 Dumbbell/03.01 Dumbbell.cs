using System;
class Dumbbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string dumbbellTop = new string('&', n / 2 + 1);
        string emptyTop = new string('.', n / 2);
        string emtpyMiddle = new string('.', n);
        Console.WriteLine(emptyTop + dumbbellTop + emtpyMiddle + dumbbellTop + emptyTop);

        for (int i = 0; i < n / 2 - 1; i++)
        {
            string empty = new string('.', n / 2 - i - 1);
            string dumbbell = "&" + new string('*', n / 2 + i) + "&";
            Console.WriteLine(empty + dumbbell + emtpyMiddle + dumbbell + empty);
        }
        //Print middle line
        string bar = new string('=', n);
        string dumbbellCenter = "&" + new string('*', n - 2) + "&";
        Console.WriteLine(dumbbellCenter + bar + dumbbellCenter);

        for (int i = n / 2 - 1; i > 0; i--)
        {
            string empty = new string('.', n / 2 - i);
            string dumbbell = "&" + new string('*', n / 2 + i - 1) + "&";
            Console.WriteLine(empty + dumbbell + emtpyMiddle + dumbbell + empty);
        }
        Console.WriteLine(emptyTop + dumbbellTop + emtpyMiddle + dumbbellTop + emptyTop);
    }
}

