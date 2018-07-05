using System;
class Program
{
    static void Main()
    {
        int numberOfcats = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < numberOfcats; i++)
        {
            string firstName = Console.ReadLine();
            string secoundName = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());

            Console.Write(year);
            Console.Write((int)firstName[0]);
            Console.Write((int)secoundName[0]);
            Console.WriteLine(i + 1);
        }
    }
}