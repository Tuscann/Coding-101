using System;
 class DailyCalorieIntake
    {
        static void Main()
        {
            int weightInPounds = int.Parse(Console.ReadLine());
            int heightInInches = int.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int workouts = int.Parse(Console.ReadLine());

            double weightInKilograms = weightInPounds / 2.2d;
            double heightInCentimeters = heightInInches * 2.54d;

            double menBmr = 66.5d + (13.75d * weightInKilograms) + (5.003d * heightInCentimeters) - (6.755d * age);
            double womenBmr = 655 + (9.563d * weightInKilograms) + (1.850d * heightInCentimeters) - (4.676 * age);

            double dciConstant;
            if (workouts <= 0)
            {
                dciConstant = 1.2d;
            }
            else if (workouts >= 1 && workouts <= 3)
            {
                dciConstant = 1.375d;
            }
            else if (workouts >= 4 && workouts <= 6)
            {
                dciConstant = 1.55d;
            }
            else if (workouts >= 7 && workouts <= 9)
            {
                dciConstant = 1.725d;
            }
            else
            {
                dciConstant = 1.9d;
            }

            if (gender == 'm')
            {
                Console.WriteLine(Math.Floor(menBmr * dciConstant));
            }
            else
            {
                Console.WriteLine(Math.Floor(womenBmr * dciConstant));
            }
        }
    }

