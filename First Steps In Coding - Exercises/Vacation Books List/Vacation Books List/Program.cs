using System;

class Program
{
    static void Main()
    {

        int totalPages = int.Parse(Console.ReadLine());
        double pagesPerHour = double.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        double hoursPerDay = totalPages / (pagesPerHour * days);

        Console.WriteLine(hoursPerDay);
    }
}