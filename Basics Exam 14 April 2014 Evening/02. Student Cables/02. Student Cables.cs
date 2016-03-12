using System;

class Program
{
    static void Main(string[] args)
    {
        int numberOfCalbles = int.Parse(Console.ReadLine());

        int totalLenght = 0;
        int joins = 0;

        for (int i = 0; i < numberOfCalbles; i++)
        {
            int length = int.Parse(Console.ReadLine());
            string measured = Console.ReadLine();

            if (measured == "meters") { length = length * 100; }
            if (length >= 20)
            {
                totalLenght = totalLenght + length;
                joins++;
            }
        }
        totalLenght = totalLenght - 3 * (joins - 1);

        const int studentMinLenght = 500 + 2 + 2;

        int cablesCount = totalLenght / studentMinLenght; Console.WriteLine(cablesCount);
        int remaider = totalLenght % studentMinLenght; Console.WriteLine(remaider);
    }
}

