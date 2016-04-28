using System;
class Program
{
    static void Main()
    {
        string animal = Console.ReadLine();

        //switch (animal)
        //{
        //    case "dog": Console.WriteLine("mammal"); break;
        //    case "crocodile": Console.WriteLine("reptile"); break;
        //    case "tortoise": Console.WriteLine("reptile"); break;
        //    case "snake": Console.WriteLine("reptile"); break;

        //    default: Console.WriteLine("unknown"); break;

        //}

        if (animal == "dog")
        {
            Console.WriteLine("mammal");
        }
        else if (animal == "crocodile" || animal == "tortoise" || animal == "snake")
        {
            Console.WriteLine("reptile");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}