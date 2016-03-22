using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Book_Orders
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            int totalBooks = 0;
            double totalPrice = 0.0;
            for (int i = 0; i < n; i++)
            {
                int packets = int.Parse(Console.ReadLine());
                int books = int.Parse(Console.ReadLine());
                double price = double.Parse(Console.ReadLine());

                int allBooks = packets * books;
                totalBooks = totalBooks + allBooks;
                double discount = 0.0;

                if (packets >= 10 && packets <= 19) { discount = 0.05; }
                else if (packets >= 20 && packets <= 29) { discount = 0.06; }
                else if (packets >= 30 && packets <= 39) { discount = 0.07; }
                else if (packets >= 40 && packets <= 49) { discount = 0.08; }
                else if (packets >= 50 && packets <= 59) { discount = 0.09; }
                else if (packets >= 60 && packets <= 69) { discount = 0.10; }
                else if (packets >= 70 && packets <= 79) { discount = 0.11; }
                else if (packets >= 80 && packets <= 89) { discount = 0.12; }
                else if (packets >= 90 && packets <= 99) { discount = 0.13; }
                else if (packets >= 100 && packets <= 109) { discount = 0.14; }
                else if (packets >= 110) { discount = 0.15; }

                double finalPrice = price*allBooks - ((allBooks * price) * discount);
                totalPrice = totalPrice + finalPrice;
            }
            Console.WriteLine(totalBooks);
            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
