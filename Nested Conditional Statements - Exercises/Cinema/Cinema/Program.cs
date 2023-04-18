using System;

class Program
{
    static void Main()
    {
        string projectionType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        double ticketPrice = 0;
        if (projectionType == "Premiere")
        {
            ticketPrice = 12.00;
        }
        else if (projectionType == "Normal")
        {
            ticketPrice = 7.50;
        }
        else if (projectionType == "Discount")
        {
            ticketPrice = 5.00;
        }

        double totalIncome = rows * columns * ticketPrice;
        Console.WriteLine("{0:f2} leva", totalIncome);
    }
}