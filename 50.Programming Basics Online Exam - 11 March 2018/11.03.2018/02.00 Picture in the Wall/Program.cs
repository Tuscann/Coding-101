using System;
class Program
{
    static void Main()
    {
        int shirina = int.Parse(Console.ReadLine());
        int daljina = int.Parse(Console.ReadLine());
        int strana = int.Parse(Console.ReadLine());
        int countPaintings = int.Parse(Console.ReadLine());

        long sum = shirina * daljina;
        long tt = strana * strana * countPaintings;

        if (sum > tt)
        {
            Console.WriteLine("The pictures fit in the hole. Hole area is {0} bigger than pictures area.", sum - tt);
        }
        else
        {
            Console.WriteLine("The pictures don't fit in the hole. Picture area is {0} bigger than hole area.", tt - sum);
        }
    }
}