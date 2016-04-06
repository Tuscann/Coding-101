using System;
class Program
{
    static void Main()
    {
        string[] pets = { "dog", "cat", "bird","mouse","lion", "giraffe","fish","aligator","eagle","monkey","hourse","ant","tortoise","girl" };

        string[] rabbits ={"Forest Rabbit","Dice's Cottontail","Brush Rabbit","San Jose Brush Rabbit"};

        // ... Loop with the foreach keyword.
        foreach (var pet in pets)
        {
            Console.WriteLine(pets[0]);
        }

        Console.Write(string.Join("\\",pets));
        Console.WriteLine();
    }
}

