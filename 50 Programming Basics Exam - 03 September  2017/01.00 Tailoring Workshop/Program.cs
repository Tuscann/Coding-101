using System;
class Program
{
    static void Main() // 100/100
    {
        int tableCount = int.Parse(Console.ReadLine());
        double tableLenght = double.Parse(Console.ReadLine());
        double tableWeight = double.Parse(Console.ReadLine());

        double prizeDolars = tableCount * (tableLenght + 2 * 0.3) * (tableWeight + 2 * 0.3) * 7;
        double prizeDolars1 = tableCount * (tableLenght / 2) * (tableLenght / 2) * 9;
        double prizeTotal = prizeDolars1 + prizeDolars;
        
        Console.WriteLine("{0:f2} USD", prizeTotal);
        Console.WriteLine("{0:f2} BGN", prizeTotal * 1.85);
    }
}