using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int spacescount = 2 * n - 2;
        int starscount = 2;

        for (int row = 0; row < n; row++)
        {
            Console.WriteLine("{0}{1}",new string(' ',spacescount),new string('*',starscount));
            spacescount -= 2;
            starscount += 2;
        }
        spacescount = 2;
        starscount = 2 * n - 2;

        for (int row = 0; row < 2; row++)
        {
            Console.WriteLine("{0}{1}", new string('*', starscount), new string(' ', spacescount));
            spacescount += 2;
            starscount -= 2;
        }
        spacescount = 2;
        starscount = 2 * n - 2;

      
        for (int row = 0; row < 2; row++)
        {
            Console.Write(new string('*', starscount));
            Console.Write(new string(' ', spacescount));
            if (spacescount > 0 && starscount > 0)
            {
                spacescount -= 2;
                starscount += 2;
            }
            Console.WriteLine();
        }
        spacescount = 2;
        starscount = 2 * n - 2;
       
        for (int row = 0; row < 2; row++)
        {
            Console.Write(new string(' ', spacescount));
            Console.Write(new string('*', starscount));
            spacescount += 2;
            starscount -= 2;
            Console.WriteLine();
        }
        spacescount = 2;
        starscount = 2 * n - 2;
        
        for (int row = 0; row < 2; row++)
        {
            Console.Write(new string(' ', spacescount));
            Console.Write(new string('*', starscount));
            if (spacescount > 0 && starscount > 0)
            {
                spacescount -= 2;
                starscount += 2;
            }
            Console.WriteLine();
        }
        spacescount = 2;
        starscount = 2 * n - 2;

        for (int row = 0; row < n; row++)
        {
            Console.Write(new string('*', starscount));
            Console.Write(new string(' ', spacescount));
            spacescount += 2;
            starscount -= 2;
            Console.WriteLine();
        }
    }
}