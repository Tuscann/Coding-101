using System;
class Program
{
    static void Main()
    {
        string first = Console.ReadLine();
        int rounds = int.Parse(Console.ReadLine());

        double totalFirst = (double)0;
        double totalNakov = (double)0;

        for (int i = 0; i < rounds; i++)
        {
            int points = int.Parse(Console.ReadLine());
            string fail = Console.ReadLine();

            if (i % 2 == 0 && fail == "success")
            {
                totalFirst += points;
            }
            if (i % 2 == 1 && fail == "success")
            {
                totalNakov += points;
            }
            if (totalFirst > 500 || totalNakov > 500)
            {
                if (totalFirst > 500)
                {
                    Console.WriteLine("{0}\n\n{1}",first,totalNakov);
                    break;
                }
                else
                {
                    Console.WriteLine("Nakov\n\n{0}",totalFirst);
                    break;
                }


            }
        }
    }
}

