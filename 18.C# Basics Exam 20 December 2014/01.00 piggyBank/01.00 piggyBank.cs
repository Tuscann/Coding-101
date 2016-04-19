using System;
class PiggyBank
{
    static void Main()
    {
        int tankPrice = int.Parse(Console.ReadLine());
        int numberOfPartyDays = int.Parse(Console.ReadLine());

        int savingsDays = 30 - numberOfPartyDays;
        int lostManyOfMonth = 5 * numberOfPartyDays;
        int savedManyOfMonth = 2 * savingsDays;
        int totalSavedManyOfMont = (savedManyOfMonth - lostManyOfMonth);
        double totalSavedMonth = (double)tankPrice / totalSavedManyOfMont;
        int requiredYears = (int)totalSavedMonth / 12;
        double montsOver = (double)totalSavedMonth % 12;
        int requiredMonts = (int)Math.Ceiling(montsOver);



        if (requiredMonts == 12)
        {
            requiredYears = requiredYears + 1;
            requiredMonts = 0;
        }
        if (totalSavedManyOfMont < 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            Console.WriteLine("{0} years, {1} months", requiredYears, requiredMonts);
        }
    }
}
