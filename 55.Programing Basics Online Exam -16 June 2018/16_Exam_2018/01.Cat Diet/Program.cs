using System;
class Program
{
    static void Main()
    {
        int fats = int.Parse(Console.ReadLine());
        int proteins = int.Parse(Console.ReadLine());
        int carbs = int.Parse(Console.ReadLine());
        int calories = int.Parse(Console.ReadLine());
        int waterProzent = int.Parse(Console.ReadLine());

        var total = fats / 100.0 * calories/ 9;
        var total2 = proteins / 100.0 * calories / 4;
        var total3 = carbs / 100.0 * calories / 4;
        var x = calories / (total + total2 + total3);

        Console.WriteLine("{0:f4}", x * (1 - waterProzent / 100.0));
    }
}