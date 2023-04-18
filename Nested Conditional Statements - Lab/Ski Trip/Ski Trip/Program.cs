using System;

class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        string roomType = Console.ReadLine();
        string rating = Console.ReadLine();

        double price = 0;
        int nights = days - 1;

        switch (roomType)
        {
            case "room for one person":
                price = nights * 18.00;
                break;
            case "apartment":
                price = nights * 25.00;
                if (nights < 10)
                {
                    price *= 0.7;
                }
                else if (nights <= 15)
                {
                    price *= 0.65;
                }
                else
                {
                    price *= 0.5;
                }
                break;
            case "president apartment":
                price = nights * 35.00;
                if (nights < 10)
                {
                    price *= 0.9;
                }
                else if (nights <= 15)
                {
                    price *= 0.85;
                }
                else
                {
                    price *= 0.8;
                }
                break;
            default:
                break;
        }

        if (rating == "positive")
        {
            price *= 1.25;
        }
        else if (rating == "negative")
        {
            price *= 0.9;
        }

        Console.WriteLine($"{price:f2}");
    }
}