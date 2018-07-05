using System;
class Program
{
    static void Main()
    {
        char gender = char.Parse(Console.ReadLine());
        double weight = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        string activity = Console.ReadLine();

        double sum = 0;

        if (gender == 'm')
        {
            sum = 66 + 13.7 * weight + 5 * height * 100 - 6.8 * age;
        }
        else if (gender == 'f')
        {
            sum = 655 + 9.6 * weight + 1.8 * height * 100 - 4.7 * age;
        }

        if (activity == "sedentary")
        {
            sum *= 1.2;
        }
        else if (activity == "lightly active")
        {
            sum *= 1.375;
        }
        else if (activity == "moderately active")
        {
            sum *= 1.55;
        }
        else if (activity == "very active")
        {
            sum *= 1.725;
        }
        Console.WriteLine("To maintain your current weight you will need {0} calories per day.", Math.Ceiling(sum));
    }
}