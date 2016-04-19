using System;
class Program
{
    static void Main()
    {
        string[] batteryPercentagessss = Console.ReadLine().Split('%');
        int batteryPercentage = int.Parse(batteryPercentagessss[0]);

        int remainingApps = 0;
        while (true)
        {
            string application = Console.ReadLine();
            if (application == "END") { break; }
            
            if (batteryPercentage > 15)
            {
                string[] appDetails = Console.ReadLine().Split('_', '%');
                int currApp = int.Parse(appDetails[1]);
                batteryPercentage -= currApp;
            }
            else
            {
                remainingApps++;
            }
        }
        if (batteryPercentage <= 0)
        {
            Console.WriteLine("Phone Off");
        }
        else if (batteryPercentage <= 15)
        {
            Console.WriteLine("Connect charger -> {0}%", batteryPercentage);
            Console.WriteLine("Programs left -> {0}", remainingApps);
        }
        if (batteryPercentage  > 15)
        {
            Console.WriteLine("Successful complete -> {0}%", batteryPercentage );
        }
    }
}
