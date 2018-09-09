using System;

class Programs
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int heigth = int.Parse(Console.ReadLine());
        int space = width * length * heigth;
        int moreSpaceNeeded = 0;

        string command;

        while ((command = Console.ReadLine()) != "Done")
        {
            int computers = int.Parse(command);

            if (space >= computers)
            {
                space -= computers;
            }
            else
            {
                moreSpaceNeeded = computers - space;
                Console.WriteLine($"No more free space! You need {moreSpaceNeeded} Cubic meters more.");
                break;
            }
        }

        if (moreSpaceNeeded == 0)
        {
            Console.WriteLine("{0} Cubic meters left.", space);
        }
    }
}