using System;

class Program
{
    static void Main()
    {
        double strawberryPrice = double.Parse(Console.ReadLine());
        double bananasQuantity = double.Parse(Console.ReadLine());
        double orangesQuantity = double.Parse(Console.ReadLine());
        double raspberriesQuantity = double.Parse(Console.ReadLine());
        double strawberriesQuantity = double.Parse(Console.ReadLine());

        double raspberriesPrice = strawberryPrice / 2;
        double orangesPrice = raspberriesPrice * 0.6;
        double bananasPrice = raspberriesPrice * 0.2;

        double moneyNeeded = 
              strawberriesQuantity * strawberryPrice
            + raspberriesQuantity * raspberriesPrice
            + orangesQuantity * orangesPrice
            + bananasQuantity * bananasPrice;

        Console.WriteLine($"{moneyNeeded:f2}");
    }
}
