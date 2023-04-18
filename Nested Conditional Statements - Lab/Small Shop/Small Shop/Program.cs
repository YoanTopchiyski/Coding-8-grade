using System;

class Program
{
    static void Main()
    {
        string product = Console.ReadLine();
        string city = Console.ReadLine();
        decimal quantity = decimal.Parse(Console.ReadLine());

        decimal price = 0;

        switch (city)
        {
            case "Sofia":
                switch (product)
                {
                    case "coffee": price = 0.50m; break;
                    case "water": price = 0.80m; break;
                    case "juice": price = 1.20m; break;
                    case "sweets": price = 1.45m; break;
                    case "peanuts": price = 1.60m; break;
                    default: Console.WriteLine("Invalid product"); return;
                }
                break;

            case "Plovdiv":
                switch (product)
                {
                    case "coffee": price = 0.40m; break;
                    case "water": price = 0.70m; break;
                    case "juice": price = 1.15m; break;
                    case "sweets": price = 1.30m; break;
                    case "peanuts": price = 1.50m; break;
                    default: Console.WriteLine("Invalid product"); return;
                }
                break;

            case "Varna":
                switch (product)
                {
                    case "coffee": price = 0.45m; break;
                    case "water": price = 0.70m; break;
                    case "juice": price = 1.10m; break;
                    case "sweets": price = 1.35m; break;
                    case "peanuts": price = 1.55m; break;
                    default: Console.WriteLine("Invalid product"); return;
                }
                break;

            default: Console.WriteLine("Invalid city"); return;
        }

        decimal total = quantity * price;
        Console.WriteLine(total);
    }
}