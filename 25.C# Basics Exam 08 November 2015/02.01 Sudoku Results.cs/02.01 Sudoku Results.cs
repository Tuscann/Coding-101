using System;
class Program
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        int counter = 0, sum = 0;
        double average = 0;

        while (inputString != "Quit")
        {
            sum += int.Parse(inputString.Substring(0, 2)) * 60 + int.Parse(inputString.Substring(3, 2));
            counter++;

            inputString = Console.ReadLine();
        }
        average = Math.Ceiling((double)sum / counter);


        if (average < 720)
        {
            Console.WriteLine("Gold Star\nGames - {0} \\ Average seconds - {1}", counter, average);
        }
        else if (average >= 720 && average <= 1440)
        {
            Console.WriteLine("Silver Star\nGames - {0} \\ Average seconds - {1}", counter, average);
        }
        else if (average > 1440)
        {
            Console.WriteLine("Bronze Star\nGames - {0} \\ Average seconds - {1}", counter, average);
        }
    }
}