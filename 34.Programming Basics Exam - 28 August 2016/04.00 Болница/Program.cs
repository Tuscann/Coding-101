using System;
class Program
{
    static void Main()
    {
        int period = int.Parse(Console.ReadLine());

        int doctors = 7;
        int treated = 0;
        int untreated = 0;

        for (int i = 1; i <= period; i++)
        {
            int patients = int.Parse(Console.ReadLine());

            if (i % 3 == 0 && untreated > treated)
            {
                doctors++; // nachaloto na vseki den 3 den ako ima poveche nelkuvani se naznachva doktor
            }
            if (doctors >= patients)
            {
                treated = treated + patients;
            }
            else if (doctors < patients)
            {
                untreated = untreated + (patients - doctors); //nelekuvani pazineti kogato ne stigat doktorite
                treated = treated + doctors; //lekuvanite e raven na broq doctory;
            }
        }
        Console.WriteLine("Treated patients: {0}.", treated);
        Console.WriteLine("Untreated patients: {0}.", untreated);
    }
}