using System;

class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int extrasCount = int.Parse(Console.ReadLine());
        double outfitPricePerExtra = double.Parse(Console.ReadLine());

        double decorPrice = budget * 0.1;
        double outfitPrice = extrasCount * outfitPricePerExtra;
        if (extrasCount > 150)
        {
            outfitPrice *= 0.9;
        }

        double totalCost = decorPrice + outfitPrice;
        if (totalCost <= budget)
        {
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {budget - totalCost:F2} leva left.");
        }
        else
        {
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {totalCost - budget:F2} leva more.");
        }
    }
}