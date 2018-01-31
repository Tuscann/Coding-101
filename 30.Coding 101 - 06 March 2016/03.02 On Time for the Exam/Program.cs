using System;
using System.Globalization;
class Program
{
    static void Main() // 100/100
    {
        int hour_izpit = int.Parse(Console.ReadLine());
        int minutes_izpit = int.Parse(Console.ReadLine());
        int hrs_arrival = int.Parse(Console.ReadLine());
        int minute_arrival = int.Parse(Console.ReadLine());

        string izpithrs = hour_izpit + ":" + minutes_izpit.ToString("00");
        string arrivalhrs = hrs_arrival + ":" + minute_arrival.ToString("00");

        DateTime izpitHours = DateTime.ParseExact(izpithrs, "H:mm", CultureInfo.InvariantCulture);
        DateTime arrivaltime = DateTime.ParseExact(arrivalhrs, "H:mm", CultureInfo.InvariantCulture);

        if (arrivaltime > izpitHours)
        {
            Console.WriteLine("Late");

            if (arrivaltime > izpitHours && arrivaltime <= izpitHours.AddMinutes(59))
            {
                Console.WriteLine((arrivaltime - izpitHours).TotalMinutes +" minutes after the start");
            }
            else
            {
                Console.WriteLine((izpitHours - arrivaltime).ToString("h\\:mm") +" hours after the start");
            }
        }
        else if (arrivaltime == izpitHours)
        {
            Console.WriteLine("On time");
        }
        else if (arrivaltime < izpitHours)
        {
            if (arrivaltime < izpitHours && arrivaltime >= izpitHours.AddMinutes(-30))
            {
                Console.WriteLine("On time");
                Console.WriteLine((izpitHours - arrivaltime).TotalMinutes +" minutes before the start");
            }
            else if (arrivaltime < izpitHours && arrivaltime >= izpitHours.AddMinutes(-59))
            {
                Console.WriteLine("Early");
                Console.WriteLine((izpitHours - arrivaltime).TotalMinutes +" minutes before the start");
            }
            else
            {
                Console.WriteLine("Early");
                Console.WriteLine((izpitHours - arrivaltime).ToString("h\\:mm") +" hours before the start");
            }
        }
    }
}