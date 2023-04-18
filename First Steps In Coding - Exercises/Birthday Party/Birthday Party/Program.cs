using System;

class Program
{
    static void Main()
    {
        double rent = double.Parse(Console.ReadLine());

        double cake = rent * 0.2;
        double drink = cake * 0.55;
        double animator = rent / 3.0;

        double budget = rent + cake + drink + animator;

        Console.WriteLine($"{budget:F2}");
    }
}