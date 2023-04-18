using System;

class Program
{
    static void Main(string[] args)
    {
        int budget = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        int fishermenCount = int.Parse(Console.ReadLine());

        double price = 0;

        switch (season)
        {
            case "Spring":
                price = 3000;
                break;
            case "Summer":
            case "Autumn":
                price = 4200;
                break;
            case "Winter":
                price = 2600;
                break;
        }

        if (fishermenCount <= 6)
        {
            price *= 0.9;
        }
        else if (fishermenCount <= 11)
        {
            price *= 0.85;
        }
        else
        {
            price *= 0.75;
        }

        if (fishermenCount % 2 == 0 && season != "Autumn")
        {
            price *= 0.95;
        }

        double diff = Math.Abs(budget - price);

        if (budget >= price)
        {
            Console.WriteLine($"Yes! You have {diff:f2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
        }
    }
}