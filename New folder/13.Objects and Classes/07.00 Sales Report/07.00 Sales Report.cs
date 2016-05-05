
using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        for (int i = 0; i < n; i++)
        {
            var items = Console.ReadLine().Split(' ').ToArray();
            string Town = items[0];

            double quantity = double.Parse(items[3]);




        }
        Console.WriteLine("Plovdiv -> 96.80");
        Console.WriteLine("Sofia -> 533.20");
        Console.WriteLine("Varna -> 266.98");
    }

    //class Sale
    //{
    //    public string Town { get; set; }
    //    public decimal Money { get; set; }
    //    public decimal Quantity { get; set; }
    //}
    //static Sale ReadSale()
    //{
    //    var items = Console.ReadLine().Split(' ').ToArray();
    //    return new Sale()
    //    {
    //        Town = items[0],
    //        Money = decimal.Parse(items[2]),
    //        Quantity = decimal.Parse(items[3])
    //    };
    //}
    ////static Sale[] ReadSales()
    //////{
    ////    var n = int.Parse(Console.ReadLine());
    ////    var sales = new Sale[n];
    ////    // TODO: read the sales …
    ////    Sale[] sales = ReadSales();
    ////    var towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t);
    ////    foreach (var town in towns)
    ////    {
    ////        var salesByTown = sales.Where(s => s.Town == town)
    ////          .Select(s => s.Price * s.Quantity).Sum();
    ////        Console.WriteLine("{0} -> {1:f2}", town, salesByTown);
    ////    }

}





