using System;
class Program
{
    static void Main()
    {
        var koridorVsredata = 100;
        var zagubeniRabotniMesta = 3;
        
        double daljina = double.Parse(Console.ReadLine()) * 100;
        double shirina = double.Parse(Console.ReadLine()) * 100 - koridorVsredata;

        double peikiShirna = (int)(shirina / 70);
        double peikiDaljina = (int)(daljina / 120);
     
        Console.WriteLine(peikiShirna * peikiDaljina - zagubeniRabotniMesta);
    }
}

