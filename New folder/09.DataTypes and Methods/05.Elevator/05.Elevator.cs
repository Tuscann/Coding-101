using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());


        int courses = n / p;
        int ostatuk = n % p;
        Console.WriteLine(courses);
        Console.WriteLine(ostatuk);

        if (ostatuk == 0)
        {
            Console.WriteLine(courses);
        }
        else if (ostatuk != 0)
        {
            Console.WriteLine(courses + ostatuk / ostatuk);
        }

        //(n+p-1)/3
        //(16+3-1)/3  18/3
 
    }
}

