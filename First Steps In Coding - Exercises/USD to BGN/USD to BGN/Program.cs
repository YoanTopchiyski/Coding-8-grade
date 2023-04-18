using System;

class Program
{
    static void Main()
    {
        decimal exchangeRate = 1.79549m;
        decimal usd = decimal.Parse(Console.ReadLine());
        decimal bgn = usd * exchangeRate;
        Console.WriteLine($"BGN amount: {bgn}");
    }
}