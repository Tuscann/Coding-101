using System;
class Program
{
    static void Main()
    {
        int peopleCount = int.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        int blood = int.Parse(Console.ReadLine());

        if (peopleCount * power > blood)
        {
            Console.WriteLine("Illidan has been slain! You defeated him with {0} points.", peopleCount * power - blood);
        }
        else
        {
            Console.WriteLine("You are not prepared! You need {0} more points.", blood - peopleCount * power);
        }
    }
}