using System;
class Program
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int melons = 0;  int watermelons = 0; 
        
        for (int i = s; i < d + s; i++)
        {
            switch (i%7)
            {
                case 1:watermelons += 1;break;
                case 2:melons += 2;break;
                case 3:watermelons += 1;melons += 1;break;
                case 4:watermelons += 2; break;
                case 5:melons += 2;watermelons += 2;break;
                case 6:watermelons += 1;melons += 2;break;
                default:break;
            }
        }
        int diff = Math.Abs(melons - watermelons);

        if (melons>watermelons)
        {
            Console.WriteLine("{0} more melons", diff);
        }
        else if (watermelons > melons)
        {
            Console.WriteLine("{0} more watermelons ", diff);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}", melons);
        }
    }
}

