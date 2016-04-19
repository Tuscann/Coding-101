using System;

// Дадено е цяло число – брой точки.Върху него се начисляват бонус точки по правилата, описани по-долу.Да се напише програма, която пресмята бонус точките за това число и общия брой точки с бонусите.
// Ако числото е до 100 включително, бонус точките са 5.
// Ако числото е по-голямо от 100, бонус точките са 20% от числото.
// Ако числото е по-голямо от 1000, бонус точките са 10% от числото.
// Допълнителни бонус точки (начисляват се отделно от предходните):
// За четно число + 1 т.
// За число, което завършва на 5 + 2 т.
internal class Program
{
    private static void Main()
    {
        Console.Write("Enter score: ");
        var number = int.Parse(Console.ReadLine());
        var bonusPoints = 0.0;
        if (number <= 100)
        {
            bonusPoints = 5;
        }
        else if (number > 100 && number <= 1000)
        {
            bonusPoints += 0.2 * number;
        }
        else if (number > 1000)
        {
            bonusPoints = 0.1 * number;
        }
        if (number % 2 == 0)
        {
            bonusPoints = bonusPoints + 1;
        }
        else if (number % 10 == 5)
        {
            bonusPoints = bonusPoints + 2;
        }

        var totalPoint = bonusPoints + number;
        Console.WriteLine("Bonus score: {0}", bonusPoints);
        Console.WriteLine("Total score: {0}", totalPoint);
    }
}