using System;
class Program
{
    static void Main()
    {
        int onsite = 0;
        int online = 0;

        for (int i = 0; i < 3; i++)
        {
            string predvaritelno = Console.ReadLine();
            int predvaritelnoBefore = int.Parse(Console.ReadLine());

            if (predvaritelno == "onsite")
            {
                onsite += predvaritelnoBefore;

                if (onsite > 600)
                {
                    online += onsite-600;
                    onsite = 600;
                }
            }
            else if (predvaritelno == "online")
            {
                online += predvaritelnoBefore;
            }
        }
        Console.WriteLine("Online students: {0}", online);
        Console.WriteLine("Onsite students: {0}", onsite);
        Console.WriteLine("Total students: {0}", online + onsite);
    }
}