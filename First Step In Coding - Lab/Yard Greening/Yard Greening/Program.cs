using System;

class Program
{
    static void Main()
    {
        double squareMeters = double.Parse(Console.ReadLine());
        double totalPrice = squareMeters * 7.61;
        double discount = totalPrice * 0.18;
        double finalPrice = totalPrice - discount;

        Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
        Console.WriteLine($"The discount is: {discount:F2} lv.");
    }
}