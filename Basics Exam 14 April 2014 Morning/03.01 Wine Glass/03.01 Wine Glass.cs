using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int counter = 0; // used to count the printed rows

        int stars = n - 2; // initial number of stars
        int dots = 0; // initial number of dots

        // printing the first half of the glass
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', dots));
            Console.Write("\\");
            Console.Write(new string('*', stars));
            Console.Write("/");
            Console.WriteLine(new string('.', dots));
            dots++;
            stars -= 2;
            counter++;
        }
        dots--; //in every iteration (even the last one) we increase the value of "dots" by one
                // that's why we must now decrease it just once. See what happens when you remove the line above :)

        //check whether n is more than 12 or not (described in the problem)
        //printing the stem
        if (n >= 12)
        {
            for (int i = 0; i < (n / 2) - 2; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write("||");
                Console.WriteLine(new string('.', dots));
                counter++; // we still use the "counter" variable
            }
        }
        else
        {
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write("||");
                Console.WriteLine(new string('.', dots));
                counter++;
            }
        }
        //printing the remaining rows
        for (int i = 0; i < n - counter; i++)//time to use counter
        {
            Console.WriteLine(new string('-', n));
        }
    }
}