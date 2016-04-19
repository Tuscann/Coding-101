using System;

class BookOrders
{
    static void Main()
    {
        int numberOfOrders = int.Parse(Console.ReadLine());
        double finalPrice = 0;
        int allBoughtBooks = 0;

        for (int i = 0; i < numberOfOrders; i++)
        {
            int packets = int.Parse(Console.ReadLine());
            int booksPerPacket = int.Parse(Console.ReadLine());
            double bookPrice = double.Parse(Console.ReadLine());

            int allOrderBooks = packets * booksPerPacket;
            allBoughtBooks += allOrderBooks;

            double discount = 0;
            if (packets >= 10 && packets < 110)
            {
                discount = (packets / 10) + 4;
            }
            else if (packets >= 110)
            {
                discount = 15;
            }
            double priceWithDiscount = bookPrice * (100 - discount) / 100;
            finalPrice += priceWithDiscount * allOrderBooks;
        }
        Console.WriteLine(allBoughtBooks);
        Console.WriteLine("{0:F2}", finalPrice);
    }
}