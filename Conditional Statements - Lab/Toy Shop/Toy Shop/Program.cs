using System;

class Program
{
    static void Main(string[] args)
    {
        double excursionPrice = double.Parse(Console.ReadLine());
        int puzzlesCount = int.Parse(Console.ReadLine());
        int dollsCount = int.Parse(Console.ReadLine());
        int teddyBearsCount = int.Parse(Console.ReadLine());
        int minionsCount = int.Parse(Console.ReadLine());
        int trucksCount = int.Parse(Console.ReadLine());

        double totalToysCount = puzzlesCount + dollsCount + teddyBearsCount + minionsCount + trucksCount;
        double puzzlesPrice = 2.60;
        double dollsPrice = 3.00;
        double teddyBearsPrice = 4.10;
        double minionsPrice = 8.20;
        double trucksPrice = 2.00;

        double totalPrice = 
            puzzlesCount * puzzlesPrice 
            + dollsCount * dollsPrice 
            + teddyBearsCount * teddyBearsPrice 
            + minionsCount * minionsPrice 
            + trucksCount * trucksPrice;

        if (totalToysCount >= 50)
        {
            totalPrice = totalPrice - totalPrice * 0.25;
        }

        totalPrice = totalPrice - totalPrice * 0.1;

        if (totalPrice >= excursionPrice)
        {
            Console.WriteLine($"Yes! {totalPrice - excursionPrice:f2} lv left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! {excursionPrice - totalPrice:f2} lv needed.");
        }
    }
}