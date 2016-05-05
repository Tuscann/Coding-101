using System;
class Program
{
    static void Main()
    {
        double downloadData = double.Parse(Console.ReadLine());
        int cinemaPrice = int.Parse(Console.ReadLine());
        int wifeSpendingPerHour = int.Parse(Console.ReadLine());

        const int DownloadSpeed = 2;
        const int MovieSize = 1500;

        double dowloadTimeInSeconds = (downloadData / DownloadSpeed) / (60*60);
        double pricePerDowload = dowloadTimeInSeconds * wifeSpendingPerHour;
        double numberMovieDownload = downloadData / MovieSize;
        double costAtCinema = numberMovieDownload * cinemaPrice;

        if (pricePerDowload > costAtCinema)
        {
            Console.WriteLine("cinema -> {0:f2}lv", costAtCinema);
        }
        else if (pricePerDowload <= costAtCinema)
        {
            Console.WriteLine("mall -> {0:f2}lv", pricePerDowload);
        }
    }
}