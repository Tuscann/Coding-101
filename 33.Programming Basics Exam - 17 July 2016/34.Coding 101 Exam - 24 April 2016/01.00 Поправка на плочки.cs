using System;
class Program
{
    static void Main()
    {
        double lenght = double.Parse(Console.ReadLine());
        double weight = double.Parse(Console.ReadLine());
        double lenghtBlock = double.Parse(Console.ReadLine());
        double weightPeika = double.Parse(Console.ReadLine());
        double lenghtPeika = double.Parse(Console.ReadLine());
        
        double needBlocks = (lenght * lenght - (weightPeika * lenghtPeika)) / (weight * lenghtBlock);
        double needTime = needBlocks * 0.2;
        
        Console.WriteLine("{0}", needBlocks);
        Console.WriteLine("{0}", needTime);
    }
}