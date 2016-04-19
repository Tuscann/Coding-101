using System;
class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double workHours = (d - (d / 10)) * 12;
        double effWorkHours = workHours * (p / 100);
        int diff = h - (int)Math.Floor(effWorkHours);
        if (diff <= 0)
        {
            Console.WriteLine("Yes\n{0}", -diff);
        }
        else
        {
            Console.WriteLine("No\n{0}", -diff);
        }

    }
}