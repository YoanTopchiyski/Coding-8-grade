using System;

class Program
{
    static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();

        string destination = "";
        string vacationType = "";
        decimal vacationCost = 0;

        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season == "summer")
            {
                vacationType = "Camp";
                vacationCost = budget * 0.3m;
            }
            else if (season == "winter")
            {
                vacationType = "Hotel";
                vacationCost = budget * 0.7m;
            }
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";
            if (season == "summer")
            {
                vacationType = "Camp";
                vacationCost = budget * 0.4m;
            }
            else if (season == "winter")
            {
                vacationType = "Hotel";
                vacationCost = budget * 0.8m;
            }
        }
        else
        {
            destination = "Europe";
            vacationType = "Hotel";
            vacationCost = budget * 0.9m;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{vacationType} - {vacationCost:f2}");
    }
}