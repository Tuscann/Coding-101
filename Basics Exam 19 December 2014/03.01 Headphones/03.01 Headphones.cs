using System;
class Program
{
    static void Main(string[] args)
    {
        int diameter = int.Parse(Console.ReadLine());

        int width = 2 * diameter + 1;
        int height = 2 * diameter;
        int monkc = diameter + 2;

        int dashesc = (width - monkc) / 2;

        string dashes1 = new String('-', dashesc);
        string astrikos1 = new String('*', monkc);

        Console.WriteLine("{0}{1}{0}", dashes1, astrikos1);
        // handles height
        int handlesHeight = diameter - 1;

        int dashoutc = (width - monkc) / 2;
        int dashinc = (diameter);

        string dashesout = new String('-', dashoutc);
        string dashin = new String('-', dashinc);

        for (int i = 0; i < handlesHeight; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", dashesout, dashin);
        }

        // speakers 
        int numberOfdashOutc = (width - monkc) / 2;
        int numberOfdashInc = (diameter);
        int numberOfStarsc = 1;

        for (; numberOfStarsc < diameter;)
        {
            string numberOfdashOut = new String('-', numberOfdashOutc);
            string numberOfdashIn = new String('-', numberOfdashInc);
            string numberOfStars = new String('*', numberOfStarsc);

            Console.WriteLine("{0}{1}{2}{1}{0}", numberOfdashOut, numberOfStars, numberOfdashIn);

            if (numberOfStarsc < diameter)
            {

                numberOfdashOutc--;
                numberOfStarsc += 2;
                numberOfdashInc -= 2;
            }

        }

        for (; numberOfStarsc <= diameter && numberOfStarsc >= 1;)
        {
            string numberOfdashOut = new String('-', numberOfdashOutc);
            string numberOfdashIn = new String('-', numberOfdashInc);
            string numberOfStars = new String('*', numberOfStarsc);

            Console.WriteLine("{0}{1}{2}{1}{0}", numberOfdashOut, numberOfStars, numberOfdashIn);


            numberOfdashOutc++;
            numberOfStarsc -= 2;
            numberOfdashInc += 2;
        }
    }
}
